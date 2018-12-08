module App

open System.Collections.Generic
open Fable.Core
open Fable.Import
open Fable.Import.Browser
open ThreeJs.ThreeJsTypes

// There's a bug in Fable that doesn't allow global values that are both mutable
// and public, we can solve it by making them private (latest version throws error):
// let [<Global>] mutable private globalCamera: ArrayCamera = jsNative

// However, in this case we do want to declare the variables ourselves
// so we can just do it in F# and initialize them to null
let mutable globalCamera: ArrayCamera = null
let mutable globalScene: Scene = null
let mutable globalRenderer: WebGLRenderer = null
let mutable globalMesh: Mesh = null

let onWindowResize(e:Browser.UIEvent) =
   globalCamera.aspect <- window.innerWidth / window.innerHeight
   globalCamera.updateProjectionMatrix()
   globalRenderer.setSize( window.innerWidth, window.innerHeight)

let init() =

  let amount = 5.
  let size = 1. / amount
  let aspectRatio = window.innerWidth / window.innerHeight
  let cameras = new List<PerspectiveCamera>()

  for y = 0 to (int)amount do
    for x = 0 to (int)amount do

      let subcamera = Globals.PerspectiveCamera.Create( 40, aspectRatio, 0.1, 10 )

      subcamera.bounds <- Globals.Vector4.Create( (float)x / amount, (float)y / amount, size, size )

      subcamera.position.x <- ( (float)x / amount ) - 0.5
      subcamera.position.y <- 0.5 - ( (float)y / amount )
      subcamera.position.z <- 1.5
      subcamera.position.multiplyScalar( 2.) |> ignore
      subcamera.lookAt( 0., 0., 0. )
      subcamera.updateMatrixWorld()

      cameras.Add(subcamera)

  // Camera at a higher level (ArrayCamera)
  let camera = Globals.ArrayCamera.Create(cameras)

  camera.position.z <- 3.

  globalCamera <- camera

  let scene = Globals.Scene.Create()
  let ambientLight = Globals.AmbientLight.Create(Globals.Color.Create(0xFF8080))

  scene.add(ambientLight) |> ignore

  let dirLight = Globals.DirectionalLight.Create()
  dirLight.position.set( 0.5, 0.5, 1. ) |> ignore
  dirLight.castShadow <- true
  dirLight.shadow.camera.zoom <- 4.
  scene.add( dirLight ) |> ignore

  let geometry = Globals.PlaneBufferGeometry.Create(100,100)
  let material = Globals.MeshPhongMaterial.Create(color=Globals.Color.Create(0x006600))
  let background = Globals.Mesh.Create(geometry, material)
  background.receiveShadow <- true
  background.position.set( 0., 0., -1. ) |> ignore
  scene.add( background ) |> ignore

  let cbGeometry = Globals.CylinderBufferGeometry.Create(0.5, 0., 1, 45)
  cbGeometry.parameters.radiusTop <- 0.5
  let cbMaterial = Globals.MeshPhongMaterial.Create(color=Globals.Color.Create(0xFFAA00))
  let mesh = Globals.Mesh.Create(cbGeometry, cbMaterial)

  mesh.castShadow <- true
  mesh.receiveShadow <- true
  scene.add(mesh) |> ignore

  globalScene <- scene
  globalMesh <- mesh

  let renderer = Globals.WebGLRenderer.Create()
  renderer.setPixelRatio( window.devicePixelRatio )
  renderer.setSize( window.innerWidth, window.innerHeight )
  renderer.shadowMap.enabled <- true
  document.body.appendChild( renderer.domElement ) |> ignore

  globalRenderer <- renderer

  Browser.window.addEventListener_resize(onWindowResize, false )


let rec animate _: unit =
   globalMesh.rotation.x <- globalMesh.rotation.x + 0.005
   globalMesh.rotation.z <-  globalMesh.rotation.z + 0.01
   globalRenderer.render( globalScene, globalCamera )

   Browser.window.requestAnimationFrame(animate) |> ignore

init()

animate 0.
