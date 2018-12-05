namespace App
module App =


open System.Collections.Generic
open Fable.Core
open Fable.Import
open Fable.Import.Browser
open ThreeJs.ThreeJsTypes


[<Emit("var globalScene, globalMesh, globalCamera, globalRenderer;")>]
let globalVarsDeclaration: unit = jsNative

[<Emit("globalCamera = camera")>]
let saveCameraToGlobal: unit = jsNative

[<Emit("globalScene = scene")>]
let sceneAssignment: unit = jsNative

[<Emit("globalMesh = mesh")>]
let meshAssignment: unit = jsNative

[<Emit("globalRenderer = renderer")>]
let rendererAssignment: unit = jsNative

globalVarsDeclaration

let [<Erase>] globalCamera = Globals.ArrayCamera.Create()
let [<Erase>] globalScene = Globals.Scene.Create()
let [<Erase>] globalRenderer =  Globals.WebGLRenderer.Create()
let [<Erase>] globalMesh = Globals.Mesh.Create()

let onWindowResize(e:Browser.UIEvent) =
   globalCamera.aspect <- window.innerWidth / window.innerHeight
   globalCamera.updateProjectionMatrix()
   globalRenderer.setSize( window.innerWidth, window.innerHeight)         
   null

let init() = 

  let amount = 5.
  let size = 1. / amount
  let aspectRatio = window.innerWidth / window.innerHeight
  let cameras = new List<PerspectiveCamera>()

  for y = 0 to (int)amount do
    for x = 0 to (int)amount do      
      
      let mutable subcamera = Globals.PerspectiveCamera.Create( 40, aspectRatio, 0.1, 10 )
      
      subcamera.bounds <- Globals.Vector4.Create( (float)x / amount, (float)y / amount, size, size )
     
      subcamera.position.x <- ( (float)x / amount ) - 0.5
      subcamera.position.y <- 0.5 - ( (float)y / amount )
      subcamera.position.z <- 1.5
      subcamera.position.multiplyScalar( 2.)        
      subcamera.lookAt( 0., 0., 0. ) 
      subcamera.updateMatrixWorld()
                  
      cameras.Add(subcamera)     

  // Camera at a higher level (ArrayCamera)  
  let mutable camera = Globals.ArrayCamera.Create(cameras)
  
  camera.position.z <- 3.
  
  // F#
  globalCamera = camera
  // Js
  saveCameraToGlobal

  let mutable scene = Globals.Scene.Create()
  let ambientLight = Globals.AmbientLight.Create(Globals.Color.Create(0xFF8080))
  
  scene.add(ambientLight)  
  
  let dirLight = Globals.DirectionalLight.Create()
  dirLight.position.set( 0.5, 0.5, 1. ) 
  dirLight.castShadow <- true
  dirLight.shadow.camera.zoom <- 4. 
  scene.add( dirLight ) 
  
  let geometry = Globals.PlaneBufferGeometry.Create(100,100)  
  let material = Globals.MeshPhongMaterial.Create(color=Globals.Color.Create(0x006600)) 
  let background = Globals.Mesh.Create(geometry, material)  
  background.receiveShadow <- true
  background.position.set( 0., 0., -1. ) 
  scene.add( background ) 
  
  let cbGeometry = Globals.CylinderBufferGeometry.Create(0.5, 0., 1, 45)
  cbGeometry.parameters.radiusTop <- 0.5  
  let cbMaterial = Globals.MeshPhongMaterial.Create(color=Globals.Color.Create(0xFFAA00))   
  let mutable mesh = Globals.Mesh.Create(cbGeometry, cbMaterial)
   
  mesh.castShadow <- true
  mesh.receiveShadow <- true
  scene.add(mesh)   
  
  globalScene = scene
  globalMesh = mesh

  sceneAssignment
  meshAssignment

  let mutable renderer = Globals.WebGLRenderer.Create()
  renderer.setPixelRatio( window.devicePixelRatio )
  renderer.setSize( window.innerWidth, window.innerHeight )
  renderer.shadowMap.enabled <- true
  document.body.appendChild( renderer.domElement ) 
  
  globalRenderer = renderer

  rendererAssignment  

  Browser.window.addEventListener_resize(onWindowResize, false )


[<Emit("requestAnimationFrame($0)")>]
let request_animation_frame callback: unit = jsNative<unit>

[<Emit("animate")>]
let animate_callback: string = jsNative

let rec animate (): unit =
   globalMesh.rotation.x <- globalMesh.rotation.x + 0.005
   globalMesh.rotation.z <-  globalMesh.rotation.z + 0.01
   globalRenderer.render( globalScene, globalCamera )
  
   request_animation_frame animate_callback   

init()

animate()
