namespace ThreeJs

module ThreeJsTypes =

    open System
    open System.Collections.Generic
    open Fable.Core
    open Fable.Import.JS
    open Fable.Core.JsInterop
    open Fable.Import.Browser   
       
        type [<AllowNullLiteral>] Matrix4 =
            interface end      

        type [<AllowNullLiteral>] Euler =
            abstract x : float with get,set                
            abstract y : float with get, set
            abstract z  : float with get, set

        type [<AllowNullLiteral>] Vector3 = 
            abstract x : float with get,set                
            abstract y : float with get, set
            abstract z  : float with get, set 
            // Sets value of this vector.
            abstract set: x: float * y: float * z: float -> Vector3
           /// Multiplies this vector by scalar s.
            abstract multiplyScalar: s: float -> Vector3
        and [<AllowNullLiteral>] Vector3Type =
                [<Emit("new THREE.$0($1...)")>] abstract Create: unit -> Vector3       


       type [<AllowNullLiteral>] Vector4 =
            abstract x : float with get,set                
            abstract y : float with get, set
            abstract z  : float with get, set  
            abstract w  : float with get, set 
       and [<AllowNullLiteral>] Vector4Type =
                [<Emit("new THREE.$0($1...)")>] abstract Create:  ?p1:obj * ?p2:obj * ?p3:obj * ?p4:obj -> Vector4       


       type [<AllowNullLiteral>] Color =
             /// Red channel value between 0 and 1. Default is 1.
            abstract r: float with get, set
            /// Green channel value between 0 and 1. Default is 1.
            abstract g: float with get, set
            /// Blue channel value between 0 and 1. Default is 1.
            abstract b: float with get, set
            abstract setHex: hex: float -> Color
            abstract set: color: string -> Color
            abstract setRGB: r: float * g: float * b: float -> Color
       and [<AllowNullLiteral>] ColorType =
                [<Emit("new THREE.$0($1...)")>] abstract Create: ?p1:obj -> Color       



       type [<AllowNullLiteral>] Object3D =
            abstract position: Vector3 with get, set        
            abstract add: param : obj -> obj //ResizeArray<Object3D> -> Object3D        
            abstract castShadow: bool with get, set
            abstract receiveShadow: bool with get, set
            abstract rotation: Euler with get, set   

       type [<AllowNullLiteral>] Camera = 
            inherit Object3D

       type [<AllowNullLiteral>] OrthographicCamera =
            inherit Camera
            abstract zoom: float with get, set

        
       type [<AllowNullLiteral>] PerspectiveCamera =                    
            inherit Camera
            
            /// Camera frustum vertical field of view, from bottom to top of view, in degrees.
            abstract fov: float with get, set
            
            /// Camera frustum aspect ratio, window width divided by window height.
            abstract aspect: float with get, set
            
            /// Camera frustum near plane.
            abstract near: float with get, set
            
            /// Camera frustum far plane.
            abstract far: float with get, set            
            abstract bounds : Vector4 with get, set // not found in TS
            abstract lookAt: p1:float * p2:float * p3:float -> unit
            abstract updateMatrixWorld: ?force: bool -> unit
            abstract updateProjectionMatrix: unit -> unit      

        and [<AllowNullLiteral>] PerspectiveCameraType =
                [<Emit("new THREE.$0($1...)")>] abstract Create: ?p1:obj * ?p2:obj * ?p3:obj * ?p4:obj -> PerspectiveCamera       

        
        type [<AllowNullLiteral>] ArrayCamera =            
                inherit PerspectiveCamera
                abstract cameras: ResizeArray<PerspectiveCamera> with get, set
                abstract isArrayCamera: obj with get, set
        
        and [<AllowNullLiteral>] ArrayCameraType =
                [<Emit("new THREE.$0($1...)")>] abstract Create: ?p1:obj -> ArrayCamera


        type [<AllowNullLiteral>] Scene =
            inherit Object3D  
        and [<AllowNullLiteral>] SceneType =
            [<Emit("new THREE.$0($1...)")>] abstract Create: unit -> Scene        

        type [<AllowNullLiteral>] LightShadow =
            abstract camera: Camera with get, set        

        type [<AllowNullLiteral>] DirectionalLightShadow =
            interface
                inherit LightShadow
                abstract camera: OrthographicCamera with get, set
            end  

        type [<AllowNullLiteral>] Light  =
            inherit Object3D      
            abstract color: Color with get, set

        type [<AllowNullLiteral>] AmbientLight =            
            inherit Light
            abstract castShadow: bool with get, set
         and [<AllowNullLiteral>] AmbientLightType =
            [<Emit("new THREE.$0($1...)")>] abstract Create: ?p1:obj -> AmbientLight        


        type [<AllowNullLiteral>] DirectionalLight =            
            inherit Light
            /// Target used for shadow camera orientation.
            abstract target: Object3D with get, set
            abstract shadow: DirectionalLightShadow with get, set
         and [<AllowNullLiteral>] DirectionalLightType =
            [<Emit("new THREE.$0($1...)")>] abstract Create: unit -> DirectionalLight        

           

        type [<AllowNullLiteral>] EventDispatcher = 
            interface end        

        // Type to resolve parameters for Geometries.
        type [<AllowNullLiteral>] GeometryParameters = 
            abstract width : int with get, set
            abstract height : int with get, set
            abstract radiusTop : float with get, set
            abstract radiusBottom : float with get, set
            abstract radialSegments : int with get, set

        type [<AllowNullLiteral>] Geometry =
            inherit EventDispatcher

        type [<AllowNullLiteral>] BufferGeometry =
            inherit Geometry
            

        type [<AllowNullLiteral>] CylinderBufferGeometry =
            inherit BufferGeometry        
            abstract parameters: GeometryParameters with get, set
        and [<AllowNullLiteral>] CylinderBufferGeometryType =
                [<Emit("new THREE.$0($1...)")>] abstract Create: ?p1:obj * ?p2:obj * ?p3:obj * ?p4:obj -> CylinderBufferGeometry



        type [<AllowNullLiteral>] PlaneBufferGeometry =   
            inherit BufferGeometry
            abstract parameters: GeometryParameters with get, set
        and [<AllowNullLiteral>] PlaneBufferGeometryType =
                [<Emit("new THREE.$0($1...)")>] abstract Create: ?p1:obj * ?p:obj -> PlaneBufferGeometry
   

        type [<AllowNullLiteral>] Material =
            inherit EventDispatcher

        type [<AllowNullLiteral>] MeshPhongMaterial =
            inherit Material
            abstract color: Color with get, set
        and [<AllowNullLiteral>] MeshPhongMaterialType =
                [<Emit("new THREE.$0($1...)")>] abstract Create: ?p1:obj -> MeshPhongMaterial


        type [<AllowNullLiteral>] Mesh =
           inherit Object3D
           abstract geometry: obj with get, set //U2<Geometry, BufferGeometry>
           abstract material: obj with get, set //U2<Material, ResizeArray<Material>>
         and [<AllowNullLiteral>] MeshType =
                [<Emit("new THREE.$0($1...)")>] abstract Create: ?p1 :obj * ?p2:obj -> Mesh


        type [<AllowNullLiteral>] Renderer =        
            abstract domElement: HTMLCanvasElement with get, set
            abstract render: scene: Scene * camera: Camera -> unit
            abstract setSize: width: float * height: float * ?updateStyle: bool -> unit
           
        type [<AllowNullLiteral>] WebGLShadowMap =
            abstract enabled: bool with get, set

        type [<AllowNullLiteral>] WebGLRenderer =            
                inherit Renderer
                abstract shadowMap: WebGLShadowMap with get, set
                abstract getPixelRatio: unit -> float
                abstract setPixelRatio: value: float -> unit
        and [<AllowNullLiteral>] WebGLRendererType =
                [<Emit("new THREE.$0($1...)")>] abstract Create: unit -> WebGLRenderer

        type [<Erase>] Globals =
            [<Global>] static member PerspectiveCamera with get(): PerspectiveCameraType = jsNative and set(v: PerspectiveCameraType): unit = jsNative
            [<Global>] static member ArrayCamera with get(): ArrayCameraType = jsNative and set(v: ArrayCameraType): unit = jsNative
            [<Global>] static member Scene with get(): SceneType = jsNative and set(v: SceneType): unit = jsNative
            [<Global>] static member WebGLRenderer with get(): WebGLRendererType = jsNative and set(v: WebGLRendererType): unit = jsNative
            [<Global>] static member Mesh with get(): MeshType = jsNative and set(v: MeshType): unit = jsNative
            [<Global>] static member Vector4 with get(): Vector4Type = jsNative and set(v: Vector4Type): unit = jsNative
            [<Global>] static member Vector3 with get(): Vector3Type = jsNative and set(v: Vector3Type): unit = jsNative
            [<Global>] static member AmbientLight with get(): AmbientLightType = jsNative and set(v: AmbientLightType): unit = jsNative
            [<Global>] static member Color with get(): ColorType = jsNative and set(v: ColorType): unit = jsNative
            [<Global>] static member DirectionalLight with get(): DirectionalLightType = jsNative and set(v: DirectionalLightType): unit = jsNative
            [<Global>] static member PlaneBufferGeometry with get(): PlaneBufferGeometryType = jsNative and set(v: PlaneBufferGeometryType): unit = jsNative
            [<Global>] static member MeshPhongMaterial with get(): MeshPhongMaterialType = jsNative and set(v: MeshPhongMaterialType): unit = jsNative
            [<Global>] static member CylinderBufferGeometry with get(): CylinderBufferGeometryType = jsNative and set(v: CylinderBufferGeometryType): unit = jsNative



        [<Emit("requestAnimationFrame($0)")>]
        let requestAnimationFrame (callback) : unit = jsNative

        [<Emit("animate")>]
        let Animate() : unit = jsNative
    
    
