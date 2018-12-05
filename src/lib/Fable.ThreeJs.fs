    // ts2fable 0.0.0
namespace Fable.Three 
//rec 

open System
open Fable.Core
open Fable.Import.JS
open Fable.Import.Browser

module Three =
    
    module Detector =

        type [<AllowNullLiteral>] IExports =
            abstract canvas: bool
            abstract webgl: bool
            abstract workers: bool
            abstract fileapi: bool
            abstract getWebGLErrorMessage: unit -> HTMLElement
            abstract addGetWebGLMessage: ?parameters: AddGetWebGLMessageParameters -> unit

        type [<AllowNullLiteral>] AddGetWebGLMessageParameters =
            abstract id: string option with get, set
            abstract parent: HTMLElement option with get, set

    module Three_FirstPersonControls =
        type Camera = Three_core.Camera
        type Object3D = Three_core.Object3D
        type Vector3 = Three_core.Vector3

        type [<AllowNullLiteral>] IExports =
            abstract FirstPersonControls: FirstPersonControlsStatic

        type [<AllowNullLiteral>] FirstPersonControls =
            abstract ``object``: Object3D with get, set
            abstract target: Vector3 with get, set
            abstract domElement: U2<HTMLCanvasElement, HTMLDocument> with get, set
            abstract enabled: bool with get, set
            abstract movementSpeed: float with get, set
            abstract lookSpeed: float with get, set
            abstract noFly: bool with get, set
            abstract lookVertical: bool with get, set
            abstract autoForward: bool with get, set
            abstract activeLook: bool with get, set
            abstract heightSpeed: bool with get, set
            abstract heightCoef: float with get, set
            abstract heightMin: float with get, set
            abstract heightMax: float with get, set
            abstract constrainVertical: bool with get, set
            abstract verticalMin: float with get, set
            abstract verticalMax: float with get, set
            abstract autoSpeedFactor: float with get, set
            abstract mouseX: float with get, set
            abstract mouseY: float with get, set
            abstract lat: float with get, set
            abstract lon: float with get, set
            abstract phi: float with get, set
            abstract theta: float with get, set
            abstract moveForward: bool with get, set
            abstract moveBackward: bool with get, set
            abstract moveLeft: bool with get, set
            abstract moveRight: bool with get, set
            abstract freeze: bool with get, set
            abstract mouseDragOn: bool with get, set
            abstract update: delta: float -> unit
            abstract dispose: unit -> unit

        type [<AllowNullLiteral>] FirstPersonControlsStatic =
            [<Emit "new $0($1...)">] abstract Create: ``object``: Camera * ?domElement: HTMLElement -> FirstPersonControls

    module Three_canvasrenderer =
        type Camera = Three_core.Camera
        type Color = Three_core.Color
        type Material = Three_core.Material
        type MaterialParameters = Three_core.MaterialParameters
        type Renderer = Three_core.Renderer
        type Scene = Three_core.Scene

        type [<AllowNullLiteral>] IExports =
            abstract SpriteCanvasMaterial: SpriteCanvasMaterialStatic
            abstract CanvasRenderer: CanvasRendererStatic

        type [<AllowNullLiteral>] SpriteCanvasMaterialParameters =
            inherit MaterialParameters
            abstract color: float option with get, set
            abstract program: (CanvasRenderingContext2D -> Color -> unit) option with get, set

        type [<AllowNullLiteral>] SpriteCanvasMaterial =
            inherit Material
            abstract color: Color with get, set
            abstract program: context: CanvasRenderingContext2D * color: Color -> unit

        type [<AllowNullLiteral>] SpriteCanvasMaterialStatic =
            [<Emit "new $0($1...)">] abstract Create: ?parameters: SpriteCanvasMaterialParameters -> SpriteCanvasMaterial

        type [<AllowNullLiteral>] CanvasRendererParameters =
            abstract canvas: HTMLCanvasElement option with get, set
            abstract devicePixelRatio: float option with get, set
            abstract alpha: bool option with get, set

        type [<AllowNullLiteral>] CanvasRenderer =
            inherit Renderer
            abstract domElement: HTMLCanvasElement with get, set
            abstract autoClear: bool with get, set
            abstract sortObjects: bool with get, set
            abstract sortElements: bool with get, set
            abstract info: obj with get, set
            abstract supportsVertexTextures: unit -> unit
            abstract setFaceCulling: unit -> unit
            abstract getPixelRatio: unit -> float
            abstract setPixelRatio: value: float -> unit
            abstract setSize: width: float * height: float * ?updateStyle: bool -> unit
            abstract setViewport: x: float * y: float * width: float * height: float -> unit
            abstract setScissor: unit -> unit
            abstract enableScissorTest: unit -> unit
            abstract setClearColor: color: U3<Color, string, float> * ?opacity: float -> unit
            abstract setClearColorHex: hex: float * ?alpha: float -> unit
            abstract getClearColor: unit -> Color
            abstract getClearAlpha: unit -> float
            abstract getMaxAnisotropy: unit -> float
            abstract clear: unit -> unit
            abstract clearColor: unit -> unit
            abstract clearDepth: unit -> unit
            abstract clearStencil: unit -> unit
            abstract render: scene: Scene * camera: Camera -> unit

        type [<AllowNullLiteral>] CanvasRendererStatic =
            [<Emit "new $0($1...)">] abstract Create: ?parameters: CanvasRendererParameters -> CanvasRenderer

    module Three_colladaLoader =
        type Scene = Three_core.Scene

        type [<AllowNullLiteral>] IExports =
            abstract ColladaModel: ColladaModelStatic
            abstract ColladaLoader: ColladaLoaderStatic

        type [<AllowNullLiteral>] ColladaLoaderReturnType =
            interface end

        type [<AllowNullLiteral>] ColladaModel =
            abstract animations: ResizeArray<obj option> with get, set
            abstract kinematics: obj option with get, set
            abstract scene: Scene with get, set
            abstract library: obj option with get, set

        type [<AllowNullLiteral>] ColladaModelStatic =
            [<Emit "new $0($1...)">] abstract Create: unit -> ColladaModel

        type [<AllowNullLiteral>] ColladaLoader =
            abstract load: url: string * onLoad: (ColladaModel -> unit) * ?onProgress: (ProgressEvent -> unit) * ?onError: (ErrorEvent -> unit) -> unit
            abstract setCrossOrigin: value: obj option -> unit
            abstract parse: text: string -> ColladaModel

        type [<AllowNullLiteral>] ColladaLoaderStatic =
            [<Emit "new $0($1...)">] abstract Create: unit -> ColladaLoader

    module Three_copyshader =
        type Shader = Three_core.Shader

        type [<AllowNullLiteral>] IExports =
            abstract CopyShader: Shader

    module Three_core =
        let [<Import("AnimationUtils","three/three-core")>] animationUtils: AnimationUtils.IExports = jsNative
        let [<Import("BufferGeometryUtils","three/three-core")>] bufferGeometryUtils: BufferGeometryUtils.IExports = jsNative
        let [<Import("Cache","three/three-core")>] cache: Cache.IExports = jsNative
        let [<Import("ColorKeywords","three/three-core")>] colorKeywords: ColorKeywords.IExports = jsNative
        let [<Import("CurveUtils","three/three-core")>] curveUtils: CurveUtils.IExports = jsNative
        let [<Import("GeometryUtils","three/three-core")>] geometryUtils: GeometryUtils.IExports = jsNative
        let [<Import("ImageUtils","three/three-core")>] imageUtils: ImageUtils.IExports = jsNative
        let [<Import("Math","three/three-core")>] math: Math.IExports = jsNative
        let [<Import("PropertyBinding","three/three-core")>] propertyBinding: PropertyBinding.IExports = jsNative
        let [<Import("SceneUtils","three/three-core")>] sceneUtils: SceneUtils.IExports = jsNative
        let [<Import("ShapeUtils","three/three-core")>] shapeUtils: ShapeUtils.IExports = jsNative
        let [<Import("UniformsUtils","three/three-core")>] uniformsUtils: UniformsUtils.IExports = jsNative

        type [<AllowNullLiteral>] IExports =
            abstract REVISION: string
            abstract CullFaceNone: CullFace
            abstract CullFaceBack: CullFace
            abstract CullFaceFront: CullFace
            abstract CullFaceFrontBack: CullFace
            abstract FrontFaceDirectionCW: FrontFaceDirection
            abstract FrontFaceDirectionCCW: FrontFaceDirection
            abstract BasicShadowMap: ShadowMapType
            abstract PCFShadowMap: ShadowMapType
            abstract PCFSoftShadowMap: ShadowMapType
            abstract FrontSide: Side
            abstract BackSide: Side
            abstract DoubleSide: Side
            abstract FlatShading: Shading
            abstract SmoothShading: Shading
            abstract NoColors: Colors
            abstract FaceColors: Colors
            abstract VertexColors: Colors
            abstract NoBlending: Blending
            abstract NormalBlending: Blending
            abstract AdditiveBlending: Blending
            abstract SubtractiveBlending: Blending
            abstract MultiplyBlending: Blending
            abstract CustomBlending: Blending
            abstract AddEquation: BlendingEquation
            abstract SubtractEquation: BlendingEquation
            abstract ReverseSubtractEquation: BlendingEquation
            abstract MinEquation: BlendingEquation
            abstract MaxEquation: BlendingEquation
            abstract ZeroFactor: BlendingDstFactor
            abstract OneFactor: BlendingDstFactor
            abstract SrcColorFactor: BlendingDstFactor
            abstract OneMinusSrcColorFactor: BlendingDstFactor
            abstract SrcAlphaFactor: BlendingDstFactor
            abstract OneMinusSrcAlphaFactor: BlendingDstFactor
            abstract DstAlphaFactor: BlendingDstFactor
            abstract OneMinusDstAlphaFactor: BlendingDstFactor
            abstract DstColorFactor: BlendingDstFactor
            abstract OneMinusDstColorFactor: BlendingDstFactor
            abstract SrcAlphaSaturateFactor: BlendingSrcFactor
            abstract NeverDepth: DepthModes
            abstract AlwaysDepth: DepthModes
            abstract LessDepth: DepthModes
            abstract LessEqualDepth: DepthModes
            abstract EqualDepth: DepthModes
            abstract GreaterEqualDepth: DepthModes
            abstract GreaterDepth: DepthModes
            abstract NotEqualDepth: DepthModes
            abstract MultiplyOperation: Combine
            abstract MixOperation: Combine
            abstract AddOperation: Combine
            abstract NoToneMapping: ToneMapping
            abstract LinearToneMapping: ToneMapping
            abstract ReinhardToneMapping: ToneMapping
            abstract Uncharted2ToneMapping: ToneMapping
            abstract CineonToneMapping: ToneMapping
            abstract UVMapping: Mapping
            abstract CubeReflectionMapping: Mapping
            abstract CubeRefractionMapping: Mapping
            abstract EquirectangularReflectionMapping: Mapping
            abstract EquirectangularRefractionMapping: Mapping
            abstract SphericalReflectionMapping: Mapping
            abstract CubeUVReflectionMapping: Mapping
            abstract CubeUVRefractionMapping: Mapping
            abstract RepeatWrapping: Wrapping
            abstract ClampToEdgeWrapping: Wrapping
            abstract MirroredRepeatWrapping: Wrapping
            abstract NearestFilter: TextureFilter
            abstract NearestMipMapNearestFilter: TextureFilter
            abstract NearestMipMapLinearFilter: TextureFilter
            abstract LinearFilter: TextureFilter
            abstract LinearMipMapNearestFilter: TextureFilter
            abstract LinearMipMapLinearFilter: TextureFilter
            abstract UnsignedByteType: TextureDataType
            abstract ByteType: TextureDataType
            abstract ShortType: TextureDataType
            abstract UnsignedShortType: TextureDataType
            abstract IntType: TextureDataType
            abstract UnsignedIntType: TextureDataType
            abstract FloatType: TextureDataType
            abstract HalfFloatType: TextureDataType
            abstract UnsignedShort4444Type: PixelType
            abstract UnsignedShort5551Type: PixelType
            abstract UnsignedShort565Type: PixelType
            abstract UnsignedInt248Type: PixelType
            abstract AlphaFormat: PixelFormat
            abstract RGBFormat: PixelFormat
            abstract RGBAFormat: PixelFormat
            abstract LuminanceFormat: PixelFormat
            abstract LuminanceAlphaFormat: PixelFormat
            abstract RGBEFormat: PixelFormat
            abstract DepthFormat: PixelFormat
            abstract DepthStencilFormat: PixelFormat
            abstract RGB_S3TC_DXT1_Format: CompressedPixelFormat
            abstract RGBA_S3TC_DXT1_Format: CompressedPixelFormat
            abstract RGBA_S3TC_DXT3_Format: CompressedPixelFormat
            abstract RGBA_S3TC_DXT5_Format: CompressedPixelFormat
            abstract RGB_PVRTC_4BPPV1_Format: CompressedPixelFormat
            abstract RGB_PVRTC_2BPPV1_Format: CompressedPixelFormat
            abstract RGBA_PVRTC_4BPPV1_Format: CompressedPixelFormat
            abstract RGBA_PVRTC_2BPPV1_Format: CompressedPixelFormat
            abstract RGB_ETC1_Format: CompressedPixelFormat
            abstract LoopOnce: AnimationActionLoopStyles
            abstract LoopRepeat: AnimationActionLoopStyles
            abstract LoopPingPong: AnimationActionLoopStyles
            abstract InterpolateDiscrete: InterpolationModes
            abstract InterpolateLinear: InterpolationModes
            abstract InterpolateSmooth: InterpolationModes
            abstract ZeroCurvatureEnding: InterpolationEndingModes
            abstract ZeroSlopeEnding: InterpolationEndingModes
            abstract WrapAroundEnding: InterpolationEndingModes
            abstract TrianglesDrawMode: TrianglesDrawModes
            abstract TriangleStripDrawMode: TrianglesDrawModes
            abstract TriangleFanDrawMode: TrianglesDrawModes
            abstract LinearEncoding: TextureEncoding
            abstract sRGBEncoding: TextureEncoding
            abstract GammaEncoding: TextureEncoding
            abstract RGBEEncoding: TextureEncoding
            abstract LogLuvEncoding: TextureEncoding
            abstract RGBM7Encoding: TextureEncoding
            abstract RGBM16Encoding: TextureEncoding
            abstract RGBDEncoding: TextureEncoding
            abstract BasicDepthPacking: DepthPackingStrategies
            abstract RGBADepthPacking: DepthPackingStrategies
            abstract warn: ?message: obj option * [<ParamArray>] optionalParams: ResizeArray<obj option> -> unit
            abstract error: ?message: obj option * [<ParamArray>] optionalParams: ResizeArray<obj option> -> unit
            abstract log: ?message: obj option * [<ParamArray>] optionalParams: ResizeArray<obj option> -> unit
            abstract AnimationAction: AnimationActionStatic
            abstract AnimationClip: AnimationClipStatic
            abstract AnimationMixer: AnimationMixerStatic
            abstract AnimationObjectGroup: AnimationObjectGroupStatic
            abstract KeyframeTrack: KeyframeTrackStatic
            abstract PropertyBinding: PropertyBindingStatic
            abstract PropertyMixer: PropertyMixerStatic
            abstract BooleanKeyframeTrack: BooleanKeyframeTrackStatic
            abstract ColorKeyframeTrack: ColorKeyframeTrackStatic
            abstract NumberKeyframeTrack: NumberKeyframeTrackStatic
            abstract QuaternionKeyframeTrack: QuaternionKeyframeTrackStatic
            abstract StringKeyframeTrack: StringKeyframeTrackStatic
            abstract VectorKeyframeTrack: VectorKeyframeTrackStatic
            abstract Camera: CameraStatic
            abstract CubeCamera: CubeCameraStatic
            abstract OrthographicCamera: OrthographicCameraStatic
            abstract PerspectiveCamera: PerspectiveCameraStatic
            abstract StereoCamera: StereoCameraStatic
            abstract ArrayCamera: ArrayCameraStatic
            abstract BufferAttribute: BufferAttributeStatic
            abstract Int8Attribute: Int8AttributeStatic
            abstract Uint8Attribute: Uint8AttributeStatic
            abstract Uint8ClampedAttribute: Uint8ClampedAttributeStatic
            abstract Int16Attribute: Int16AttributeStatic
            abstract Uint16Attribute: Uint16AttributeStatic
            abstract Int32Attribute: Int32AttributeStatic
            abstract Uint32Attribute: Uint32AttributeStatic
            abstract Float32Attribute: Float32AttributeStatic
            abstract Float64Attribute: Float64AttributeStatic
            abstract Int8BufferAttribute: Int8BufferAttributeStatic
            abstract Uint8BufferAttribute: Uint8BufferAttributeStatic
            abstract Uint8ClampedBufferAttribute: Uint8ClampedBufferAttributeStatic
            abstract Int16BufferAttribute: Int16BufferAttributeStatic
            abstract Uint16BufferAttribute: Uint16BufferAttributeStatic
            abstract Int32BufferAttribute: Int32BufferAttributeStatic
            abstract Uint32BufferAttribute: Uint32BufferAttributeStatic
            abstract Float32BufferAttribute: Float32BufferAttributeStatic
            abstract Float64BufferAttribute: Float64BufferAttributeStatic
            abstract DynamicBufferAttribute: DynamicBufferAttributeStatic
            abstract BufferGeometry: BufferGeometryStatic
            abstract Clock: ClockStatic
            abstract DirectGeometry: DirectGeometryStatic
            abstract EventDispatcher: EventDispatcherStatic
            abstract Face3: Face3Static
            abstract Face4: Face4Static
            abstract GeometryIdCount: float
            abstract Geometry: GeometryStatic
            abstract InstancedBufferAttribute: InstancedBufferAttributeStatic
            abstract InstancedBufferGeometry: InstancedBufferGeometryStatic
            abstract InterleavedBuffer: InterleavedBufferStatic
            abstract InstancedInterleavedBuffer: InstancedInterleavedBufferStatic
            abstract InterleavedBufferAttribute: InterleavedBufferAttributeStatic
            abstract Object3DIdCount: float
            abstract Object3D: Object3DStatic
            abstract Raycaster: RaycasterStatic
            abstract Layers: LayersStatic
            abstract Font: FontStatic
            abstract Light: LightStatic
            abstract LightShadow: LightShadowStatic
            abstract AmbientLight: AmbientLightStatic
            abstract DirectionalLight: DirectionalLightStatic
            abstract DirectionalLightShadow: DirectionalLightShadowStatic
            abstract HemisphereLight: HemisphereLightStatic
            abstract PointLight: PointLightStatic
            abstract PointLightShadow: PointLightShadowStatic
            abstract SpotLight: SpotLightStatic
            abstract SpotLightShadow: SpotLightShadowStatic
            abstract Loader: LoaderStatic
            abstract FileLoader: FileLoaderStatic
            abstract FontLoader: FontLoaderStatic
            abstract ImageLoader: ImageLoaderStatic
            abstract JSONLoader: JSONLoaderStatic
            abstract LoadingManager: LoadingManagerStatic
            abstract DefaultLoadingManager: LoadingManager
            abstract BufferGeometryLoader: BufferGeometryLoaderStatic
            abstract MaterialLoader: MaterialLoaderStatic
            abstract ObjectLoader: ObjectLoaderStatic
            abstract TextureLoader: TextureLoaderStatic
            abstract CubeTextureLoader: CubeTextureLoaderStatic
            abstract DataTextureLoader: DataTextureLoaderStatic
            abstract BinaryTextureLoader: BinaryTextureLoaderStatic
            abstract CompressedTextureLoader: CompressedTextureLoaderStatic
            abstract AudioLoader: AudioLoaderStatic
            abstract LoaderUtils: LoaderUtilsStatic
            abstract MaterialIdCount: float
            abstract Material: MaterialStatic
            abstract LineBasicMaterial: LineBasicMaterialStatic
            abstract LineDashedMaterial: LineDashedMaterialStatic
            abstract MeshBasicMaterial: MeshBasicMaterialStatic
            abstract MeshDepthMaterial: MeshDepthMaterialStatic
            abstract MeshLambertMaterial: MeshLambertMaterialStatic
            abstract MeshStandardMaterial: MeshStandardMaterialStatic
            abstract MeshNormalMaterial: MeshNormalMaterialStatic
            abstract MeshPhongMaterial: MeshPhongMaterialStatic
            abstract MeshPhysicalMaterial: MeshPhysicalMaterialStatic
            abstract MultiMaterial: MultiMaterialStatic
            abstract MeshFaceMaterial: MeshFaceMaterialStatic
            abstract PointsMaterial: PointsMaterialStatic
            abstract PointCloudMaterial: PointCloudMaterialStatic
            abstract ParticleBasicMaterial: ParticleBasicMaterialStatic
            abstract ParticleSystemMaterial: ParticleSystemMaterialStatic
            abstract ShaderMaterial: ShaderMaterialStatic
            abstract RawShaderMaterial: RawShaderMaterialStatic
            abstract SpriteMaterial: SpriteMaterialStatic
            abstract ShadowMaterial: ShadowMaterialStatic
            abstract Box2: Box2Static
            abstract Box3: Box3Static
            abstract Color: ColorStatic
            abstract Euler: EulerStatic
            abstract Frustum: FrustumStatic
            abstract Line3: Line3Static
            abstract Matrix3: Matrix3Static
            abstract Matrix4: Matrix4Static
            abstract Plane: PlaneStatic
            abstract Spherical: SphericalStatic
            abstract Cylindrical: CylindricalStatic
            abstract Quaternion: QuaternionStatic
            abstract Ray: RayStatic
            abstract Sphere: SphereStatic
            abstract Triangle: TriangleStatic
            abstract Vector2: Vector2Static
            abstract Vector3: Vector3Static
            abstract Vertex: VertexStatic
            abstract Vector4: Vector4Static
            abstract Interpolant: InterpolantStatic
            abstract CubicInterpolant: CubicInterpolantStatic
            abstract DiscreteInterpolant: DiscreteInterpolantStatic
            abstract LinearInterpolant: LinearInterpolantStatic
            abstract QuaternionLinearInterpolant: QuaternionLinearInterpolantStatic
            abstract Bone: BoneStatic
            abstract Group: GroupStatic
            abstract LOD: LODStatic
            abstract Line: LineStatic
            abstract LineStrip: float
            abstract LinePieces: float
            abstract LineSegments: LineSegmentsStatic
            abstract Mesh: MeshStatic
            abstract Points: PointsStatic
            abstract PointCloud: PointCloudStatic
            abstract ParticleSystem: ParticleSystemStatic
            abstract Skeleton: SkeletonStatic
            abstract SkinnedMesh: SkinnedMeshStatic
            abstract Sprite: SpriteStatic
            abstract Particle: ParticleStatic
            abstract WebGLRenderer: WebGLRendererStatic
            abstract WebGLRenderList: WebGLRenderListStatic
            abstract WebGLRenderLists: WebGLRenderListsStatic
            abstract WebGLRenderTarget: WebGLRenderTargetStatic
            abstract WebGLRenderTargetCube: WebGLRenderTargetCubeStatic
            abstract ShaderChunk: obj
            abstract ShaderLib: obj
            abstract UniformsLib: obj
            abstract Uniform: UniformStatic
            abstract WebGLBufferRenderer: WebGLBufferRendererStatic
            abstract WebGLClipping: WebGLClippingStatic
            abstract WebGLCapabilities: WebGLCapabilitiesStatic
            abstract WebGLExtensions: WebGLExtensionsStatic
            abstract WebGLGeometries: WebGLGeometriesStatic
            abstract WebGLLights: WebGLLightsStatic
            abstract WebGLInfo: WebGLInfoStatic
            abstract WebGLIndexedBufferRenderer: WebGLIndexedBufferRendererStatic
            abstract WebGLObjects: WebGLObjectsStatic
            abstract WebGLProgram: WebGLProgramStatic
            abstract WebGLPrograms: WebGLProgramsStatic
            abstract WebGLTextures: WebGLTexturesStatic
            abstract WebGLUniforms: WebGLUniformsStatic
            abstract WebGLProperties: WebGLPropertiesStatic
            abstract WebGLShader: WebGLShaderStatic
            abstract WebGLShadowMap: WebGLShadowMapStatic
            abstract WebGLState: WebGLStateStatic
            abstract WebGLColorBuffer: WebGLColorBufferStatic
            abstract WebGLDepthBuffer: WebGLDepthBufferStatic
            abstract WebGLStencilBuffer: WebGLStencilBufferStatic
            abstract SpritePlugin: SpritePluginStatic
            abstract Scene: SceneStatic
            abstract Fog: FogStatic
            abstract FogExp2: FogExp2Static
            abstract TextureIdCount: float
            abstract Texture: TextureStatic
            abstract DepthTexture: DepthTextureStatic
            abstract CanvasTexture: CanvasTextureStatic
            abstract CubeTexture: CubeTextureStatic
            abstract CompressedTexture: CompressedTextureStatic
            abstract DataTexture: DataTextureStatic
            abstract VideoTexture: VideoTextureStatic
            abstract Audio: AudioStatic
            abstract AudioAnalyser: AudioAnalyserStatic
            abstract AudioContext: AudioContext
            abstract AudioBuffer: AudioBufferStatic
            abstract PositionalAudio: PositionalAudioStatic
            abstract AudioListener: AudioListenerStatic
            abstract Curve: CurveStatic
            abstract CurvePath: CurvePathStatic
            abstract Path: PathStatic
            abstract ShapePath: ShapePathStatic
            abstract Shape: ShapeStatic
            abstract CatmullRomCurve3: CatmullRomCurve3Static
            abstract CubicBezierCurve: CubicBezierCurveStatic
            abstract CubicBezierCurve3: CubicBezierCurve3Static
            abstract EllipseCurve: EllipseCurveStatic
            abstract ArcCurve: ArcCurveStatic
            abstract LineCurve: LineCurveStatic
            abstract LineCurve3: LineCurve3Static
            abstract QuadraticBezierCurve: QuadraticBezierCurveStatic
            abstract QuadraticBezierCurve3: QuadraticBezierCurve3Static
            abstract SplineCurve: SplineCurveStatic
            abstract BoxBufferGeometry: BoxBufferGeometryStatic
            abstract BoxGeometry: BoxGeometryStatic
            abstract CubeGeometry: CubeGeometryStatic
            abstract CircleBufferGeometry: CircleBufferGeometryStatic
            abstract CircleGeometry: CircleGeometryStatic
            abstract CylinderBufferGeometry: CylinderBufferGeometryStatic
            abstract CylinderGeometry: CylinderGeometryStatic
            abstract ConeBufferGeometry: ConeBufferGeometryStatic
            abstract ConeGeometry: ConeGeometryStatic
            abstract DodecahedronBufferGeometry: DodecahedronBufferGeometryStatic
            abstract DodecahedronGeometry: DodecahedronGeometryStatic
            abstract EdgesGeometry: EdgesGeometryStatic
            abstract ExtrudeGeometry: ExtrudeGeometryStatic
            abstract ExtrudeBufferGeometry: ExtrudeBufferGeometryStatic
            abstract IcosahedronBufferGeometry: IcosahedronBufferGeometryStatic
            abstract IcosahedronGeometry: IcosahedronGeometryStatic
            abstract LatheBufferGeometry: LatheBufferGeometryStatic
            abstract LatheGeometry: LatheGeometryStatic
            abstract OctahedronBufferGeometry: OctahedronBufferGeometryStatic
            abstract OctahedronGeometry: OctahedronGeometryStatic
            abstract ParametricBufferGeometry: ParametricBufferGeometryStatic
            abstract ParametricGeometry: ParametricGeometryStatic
            abstract PlaneBufferGeometry: PlaneBufferGeometryStatic
            abstract PlaneGeometry: PlaneGeometryStatic
            abstract PolyhedronBufferGeometry: PolyhedronBufferGeometryStatic
            abstract PolyhedronGeometry: PolyhedronGeometryStatic
            abstract RingBufferGeometry: RingBufferGeometryStatic
            abstract RingGeometry: RingGeometryStatic
            abstract ShapeGeometry: ShapeGeometryStatic
            abstract ShapeBufferGeometry: ShapeBufferGeometryStatic
            abstract SphereBufferGeometry: SphereBufferGeometryStatic
            abstract SphereGeometry: SphereGeometryStatic
            abstract TetrahedronBufferGeometry: TetrahedronBufferGeometryStatic
            abstract TetrahedronGeometry: TetrahedronGeometryStatic
            abstract TextGeometry: TextGeometryStatic
            abstract TextBufferGeometry: TextBufferGeometryStatic
            abstract TorusBufferGeometry: TorusBufferGeometryStatic
            abstract TorusGeometry: TorusGeometryStatic
            abstract TorusKnotBufferGeometry: TorusKnotBufferGeometryStatic
            abstract TorusKnotGeometry: TorusKnotGeometryStatic
            abstract TubeGeometry: TubeGeometryStatic
            abstract TubeBufferGeometry: TubeBufferGeometryStatic
            abstract WireframeGeometry: WireframeGeometryStatic
            abstract ArrowHelper: ArrowHelperStatic
            abstract AxesHelper: AxesHelperStatic
            abstract BoundingBoxHelper: BoundingBoxHelperStatic
            abstract BoxHelper: BoxHelperStatic
            abstract CameraHelper: CameraHelperStatic
            abstract DirectionalLightHelper: DirectionalLightHelperStatic
            abstract EdgesHelper: EdgesHelperStatic
            abstract FaceNormalsHelper: FaceNormalsHelperStatic
            abstract GridHelper: GridHelperStatic
            abstract HemisphereLightHelper: HemisphereLightHelperStatic
            abstract PointLightHelper: PointLightHelperStatic
            abstract SkeletonHelper: SkeletonHelperStatic
            abstract SpotLightHelper: SpotLightHelperStatic
            abstract VertexNormalsHelper: VertexNormalsHelperStatic
            abstract PlaneHelper: PlaneHelperStatic
            abstract WireframeHelper: WireframeHelperStatic
            abstract ImmediateRenderObject: ImmediateRenderObjectStatic
            abstract MorphBlendMesh: MorphBlendMeshStatic
            abstract VRDisplay: VRDisplay

        type MOUSE =
            obj

        //workaround temporarily
        type [<AllowNullLiteral>] VRDisplay = 
            class end

        type [<RequireQualifiedAccess>] CullFace = 
            class end

        type [<RequireQualifiedAccess>] FrontFaceDirection =
            class end

        type [<RequireQualifiedAccess>] ShadowMapType =
            class end

        type [<RequireQualifiedAccess>] Side =
            class end

        type [<RequireQualifiedAccess>] Shading =
            class end

        type [<RequireQualifiedAccess>] Colors =
            class end

        type [<RequireQualifiedAccess>] Blending =
            class end

        type [<RequireQualifiedAccess>] BlendingEquation =
            class end

        type [<RequireQualifiedAccess>] BlendingDstFactor =
            class end

        type [<RequireQualifiedAccess>] BlendingSrcFactor =
            class end

        type [<RequireQualifiedAccess>] DepthModes =
            class end

        type [<RequireQualifiedAccess>] Combine =
            class end

        type [<RequireQualifiedAccess>] ToneMapping =
            class end

        type [<RequireQualifiedAccess>] Mapping =
            class end

        type [<RequireQualifiedAccess>] Wrapping =
            class end

        type [<RequireQualifiedAccess>] TextureFilter =
            class end

        type [<RequireQualifiedAccess>] TextureDataType =
            class end

        type [<RequireQualifiedAccess>] PixelType =
            class end

        type [<RequireQualifiedAccess>] PixelFormat =
            class end

        type [<RequireQualifiedAccess>] CompressedPixelFormat =
            class end            

        type [<RequireQualifiedAccess>] AnimationActionLoopStyles =
            class end

        type [<RequireQualifiedAccess>] InterpolationModes =
            class end

        type [<RequireQualifiedAccess>] InterpolationEndingModes =
            class end

        type [<RequireQualifiedAccess>] TrianglesDrawModes =
            class end

        type [<RequireQualifiedAccess>] TextureEncoding =
            class end

        type [<RequireQualifiedAccess>] DepthPackingStrategies =
            class end

        type TypedArray =
            obj

        type [<AllowNullLiteral>] AnimationAction =
            abstract loop: bool with get, set
            abstract time: float with get, set
            abstract timeScale: float with get, set
            abstract weight: float with get, set
            abstract repetitions: float with get, set
            abstract paused: bool with get, set
            abstract enabled: bool with get, set
            abstract clampWhenFinished: bool with get, set
            abstract zeroSlopeAtStart: bool with get, set
            abstract zeroSlopeAtEnd: bool with get, set
            abstract play: unit -> AnimationAction
            abstract stop: unit -> AnimationAction
            abstract reset: unit -> AnimationAction
            abstract isRunning: unit -> bool
            abstract startAt: time: float -> AnimationAction
            abstract setLoop: mode: AnimationActionLoopStyles * repetitions: float -> AnimationAction
            abstract setEffectiveWeight: weight: float -> AnimationAction
            abstract getEffectiveWeight: unit -> float
            abstract fadeIn: duration: float -> AnimationAction
            abstract fadeOut: duration: float -> AnimationAction
            abstract crossFadeFrom: fadeOutAction: AnimationAction * duration: float * warp: bool -> AnimationAction
            abstract crossFadeTo: fadeInAction: AnimationAction * duration: float * warp: bool -> AnimationAction
            abstract stopFading: unit -> AnimationAction
            abstract setEffectiveTimeScale: timeScale: float -> AnimationAction
            abstract getEffectiveTimeScale: unit -> float
            abstract setDuration: duration: float -> AnimationAction
            abstract syncWith: action: AnimationAction -> AnimationAction
            abstract halt: duration: float -> AnimationAction
            abstract warp: statTimeScale: float * endTimeScale: float * duration: float -> AnimationAction
            abstract stopWarping: unit -> AnimationAction
            abstract getMixer: unit -> AnimationMixer
            abstract getClip: unit -> AnimationClip
            abstract getRoot: unit -> obj option

        type [<AllowNullLiteral>] AnimationActionStatic =
            [<Emit "new $0($1...)">] abstract Create: unit -> AnimationAction

        type [<AllowNullLiteral>] AnimationClip =
            abstract name: string with get, set
            abstract tracks: ResizeArray<KeyframeTrack> with get, set
            abstract duration: float with get, set
            abstract uuid: string with get, set
            abstract results: ResizeArray<obj option> with get, set
            abstract resetDuration: unit -> unit
            abstract trim: unit -> AnimationClip
            abstract optimize: unit -> AnimationClip

        type [<AllowNullLiteral>] AnimationClipStatic =
            [<Emit "new $0($1...)">] abstract Create: ?name: string * ?duration: float * ?tracks: ResizeArray<KeyframeTrack> -> AnimationClip
            abstract CreateFromMorphTargetSequence: name: string * morphTargetSequence: ResizeArray<MorphTarget> * fps: float * noLoop: bool -> AnimationClip
            abstract findByName: clipArray: ResizeArray<AnimationClip> * name: string -> AnimationClip
            abstract CreateClipsFromMorphTargetSequences: morphTargets: ResizeArray<MorphTarget> * fps: float * noLoop: bool -> ResizeArray<AnimationClip>
            abstract parse: json: obj option -> AnimationClip
            abstract parseAnimation: animation: obj option * bones: ResizeArray<Bone> * nodeName: string -> AnimationClip
            abstract toJSON: unit -> obj option

        type [<AllowNullLiteral>] AnimationMixer =
            inherit EventDispatcher
            abstract time: float with get, set
            abstract timeScale: float with get, set
            abstract clipAction: clip: AnimationClip * ?root: obj option -> AnimationAction
            abstract existingAction: clip: AnimationClip * ?root: obj option -> AnimationAction
            abstract stopAllAction: unit -> AnimationMixer
            abstract update: deltaTime: float -> AnimationMixer
            abstract getRoot: unit -> obj option
            abstract uncacheClip: clip: AnimationClip -> unit
            abstract uncacheRoot: root: obj option -> unit
            abstract uncacheAction: clip: AnimationClip * ?root: obj option -> unit

        type [<AllowNullLiteral>] AnimationMixerStatic =
            [<Emit "new $0($1...)">] abstract Create: root: obj option -> AnimationMixer

        type [<AllowNullLiteral>] AnimationObjectGroup =
            abstract uuid: string with get, set
            abstract stats: obj with get, set
            abstract add: [<ParamArray>] args: ResizeArray<obj option> -> unit
            abstract remove: [<ParamArray>] args: ResizeArray<obj option> -> unit
            abstract uncache: [<ParamArray>] args: ResizeArray<obj option> -> unit

        type [<AllowNullLiteral>] AnimationObjectGroupStatic =
            [<Emit "new $0($1...)">] abstract Create: [<ParamArray>] args: ResizeArray<obj option> -> AnimationObjectGroup

        module AnimationUtils =

            type [<AllowNullLiteral>] IExports =
                abstract arraySlice: array: obj option * from: float * ``to``: float -> obj option
                abstract convertArray: array: obj option * ``type``: obj option * forceClone: bool -> obj option
                abstract isTypedArray: ``object``: obj option -> bool
                abstract getKeyFrameOrder: times: float -> ResizeArray<float>
                abstract sortedArray: values: ResizeArray<obj option> * stride: float * order: ResizeArray<float> -> ResizeArray<obj option>
                abstract flattenJSON: jsonKeys: ResizeArray<string> * times: ResizeArray<obj option> * values: ResizeArray<obj option> * valuePropertyName: string -> unit

        type [<AllowNullLiteral>] KeyframeTrack =
            abstract name: string with get, set
            abstract times: ResizeArray<obj option> with get, set
            abstract values: ResizeArray<obj option> with get, set
            abstract ValueTypeName: string with get, set
            abstract TimeBufferType: Float32Array with get, set
            abstract ValueBufferType: Float32Array with get, set
            abstract DefaultInterpolation: InterpolationModes with get, set
            abstract InterpolantFactoryMethodDiscrete: result: obj option -> DiscreteInterpolant
            abstract InterpolantFactoryMethodLinear: result: obj option -> LinearInterpolant
            abstract InterpolantFactoryMethodSmooth: result: obj option -> CubicInterpolant
            abstract setInterpolation: interpolation: InterpolationModes -> unit
            abstract getInterpolation: unit -> InterpolationModes
            abstract getValuesize: unit -> float
            abstract shift: timeOffset: float -> KeyframeTrack
            abstract scale: timeScale: float -> KeyframeTrack
            abstract trim: startTime: float * endTime: float -> KeyframeTrack
            abstract validate: unit -> bool
            abstract optimize: unit -> KeyframeTrack

        type [<AllowNullLiteral>] KeyframeTrackStatic =
            [<Emit "new $0($1...)">] abstract Create: name: string * times: ResizeArray<obj option> * values: ResizeArray<obj option> * ?interpolation: InterpolationModes -> KeyframeTrack
            abstract parse: json: obj option -> KeyframeTrack
            abstract toJSON: track: KeyframeTrack -> obj option

        type [<AllowNullLiteral>] PropertyBinding =
            abstract path: string with get, set
            abstract parsedPath: obj option with get, set
            abstract node: obj option with get, set
            abstract rootNode: obj option with get, set
            abstract getValue: targetArray: obj option * offset: float -> obj option
            abstract setValue: sourceArray: obj option * offset: float -> unit
            abstract bind: unit -> unit
            abstract unbind: unit -> unit
            abstract BindingType: obj with get, set
            abstract Versioning: obj with get, set
            abstract GetterByBindingType: ResizeArray<Function> with get, set
            abstract SetterByBindingTypeAndVersioning: Array<ResizeArray<Function>> with get, set

        type [<AllowNullLiteral>] PropertyBindingStatic =
            [<Emit "new $0($1...)">] abstract Create: rootNode: obj option * path: string * ?parsedPath: obj option -> PropertyBinding
            abstract create: root: obj option * path: obj option * ?parsedPath: obj option -> U2<PropertyBinding, PropertyBinding.Composite>
            abstract parseTrackName: trackName: string -> obj option
            abstract findNode: root: obj option * nodeName: string -> obj option

        module PropertyBinding =

            type [<AllowNullLiteral>] IExports =
                abstract Composite: CompositeStatic

            type [<AllowNullLiteral>] Composite =
                abstract getValue: array: obj option * offset: float -> obj option
                abstract setValue: array: obj option * offset: float -> unit
                abstract bind: unit -> unit
                abstract unbind: unit -> unit

            type [<AllowNullLiteral>] CompositeStatic =
                [<Emit "new $0($1...)">] abstract Create: targetGroup: obj option * path: obj option * ?parsedPath: obj option -> Composite

        type [<AllowNullLiteral>] PropertyMixer =
            abstract binding: obj option with get, set
            abstract valueSize: float with get, set
            abstract buffer: obj option with get, set
            abstract cumulativeWeight: float with get, set
            abstract useCount: float with get, set
            abstract referenceCount: float with get, set
            abstract accumulate: accuIndex: float * weight: float -> unit
            abstract apply: accuIndex: float -> unit
            abstract saveOriginalState: unit -> unit
            abstract restoreOriginalState: unit -> unit

        type [<AllowNullLiteral>] PropertyMixerStatic =
            [<Emit "new $0($1...)">] abstract Create: binding: obj option * typeName: string * valueSize: float -> PropertyMixer

        type [<AllowNullLiteral>] BooleanKeyframeTrack =
            inherit KeyframeTrack

        type [<AllowNullLiteral>] BooleanKeyframeTrackStatic =
            [<Emit "new $0($1...)">] abstract Create: name: string * times: ResizeArray<obj option> * values: ResizeArray<obj option> -> BooleanKeyframeTrack

        type [<AllowNullLiteral>] ColorKeyframeTrack =
            inherit KeyframeTrack

        type [<AllowNullLiteral>] ColorKeyframeTrackStatic =
            [<Emit "new $0($1...)">] abstract Create: name: string * times: ResizeArray<obj option> * values: ResizeArray<obj option> * ?interpolation: InterpolationModes -> ColorKeyframeTrack

        type [<AllowNullLiteral>] NumberKeyframeTrack =
            inherit KeyframeTrack

        type [<AllowNullLiteral>] NumberKeyframeTrackStatic =
            [<Emit "new $0($1...)">] abstract Create: name: string * times: ResizeArray<obj option> * values: ResizeArray<obj option> * ?interpolation: InterpolationModes -> NumberKeyframeTrack

        type [<AllowNullLiteral>] QuaternionKeyframeTrack =
            inherit KeyframeTrack

        type [<AllowNullLiteral>] QuaternionKeyframeTrackStatic =
            [<Emit "new $0($1...)">] abstract Create: name: string * times: ResizeArray<obj option> * values: ResizeArray<obj option> * ?interpolation: InterpolationModes -> QuaternionKeyframeTrack

        type [<AllowNullLiteral>] StringKeyframeTrack =
            inherit KeyframeTrack

        type [<AllowNullLiteral>] StringKeyframeTrackStatic =
            [<Emit "new $0($1...)">] abstract Create: name: string * times: ResizeArray<obj option> * values: ResizeArray<obj option> * ?interpolation: InterpolationModes -> StringKeyframeTrack

        type [<AllowNullLiteral>] VectorKeyframeTrack =
            inherit KeyframeTrack

        type [<AllowNullLiteral>] VectorKeyframeTrackStatic =
            [<Emit "new $0($1...)">] abstract Create: name: string * times: ResizeArray<obj option> * values: ResizeArray<obj option> * ?interpolation: InterpolationModes -> VectorKeyframeTrack

        /// Abstract base class for cameras. This class should always be inherited when you build a new camera.
        type [<AllowNullLiteral>] Camera =
            inherit Object3D
            /// This is the inverse of matrixWorld. MatrixWorld contains the Matrix which has the world transform of the Camera.
            abstract matrixWorldInverse: Matrix4 with get, set
            /// This is the matrix which contains the projection.
            abstract projectionMatrix: Matrix4 with get, set
            abstract isCamera: obj with get, set
            abstract copy: source: Camera * ?recursive: bool -> Camera
            abstract getWorldDirection: target: Vector3 -> Vector3
            abstract updateMatrixWorld: force: bool -> unit

        /// Abstract base class for cameras. This class should always be inherited when you build a new camera.
        type [<AllowNullLiteral>] CameraStatic =
            /// This constructor sets following properties to the correct type: matrixWorldInverse, projectionMatrix and projectionMatrixInverse.
            [<Emit "new $0($1...)">] abstract Create: unit -> Camera

        type [<AllowNullLiteral>] CubeCamera =
            inherit Object3D
            abstract ``type``: string with get, set
            abstract renderTarget: WebGLRenderTargetCube with get, set
            abstract updateCubeMap: renderer: Renderer * scene: Scene -> unit
            abstract update: renderer: WebGLRenderer * scene: Scene -> unit

        type [<AllowNullLiteral>] CubeCameraStatic =
            [<Emit "new $0($1...)">] abstract Create: ?near: float * ?far: float * ?cubeResolution: float -> CubeCamera

        /// Camera with orthographic projection
        type [<AllowNullLiteral>] OrthographicCamera =
            inherit Camera
            abstract ``type``: string with get, set
            abstract isOrthographicCamera: obj with get, set
            abstract zoom: float with get, set
            abstract view: obj option with get, set
            /// Camera frustum left plane.
            abstract left: float with get, set
            /// Camera frustum right plane.
            abstract right: float with get, set
            /// Camera frustum top plane.
            abstract top: float with get, set
            /// Camera frustum bottom plane.
            abstract bottom: float with get, set
            /// Camera frustum near plane.
            abstract near: float with get, set
            /// Camera frustum far plane.
            abstract far: float with get, set
            /// Updates the camera projection matrix. Must be called after change of parameters.
            abstract updateProjectionMatrix: unit -> unit
            abstract setViewOffset: fullWidth: float * fullHeight: float * offsetX: float * offsetY: float * width: float * height: float -> unit
            abstract clearViewOffset: unit -> unit
            abstract toJSON: ?meta: obj option -> obj option

        /// Camera with orthographic projection
        type [<AllowNullLiteral>] OrthographicCameraStatic =
            /// <param name="left">Camera frustum left plane.</param>
            /// <param name="right">Camera frustum right plane.</param>
            /// <param name="top">Camera frustum top plane.</param>
            /// <param name="bottom">Camera frustum bottom plane.</param>
            /// <param name="near">Camera frustum near plane.</param>
            /// <param name="far">Camera frustum far plane.</param>
            [<Emit "new $0($1...)">] abstract Create: left: float * right: float * top: float * bottom: float * ?near: float * ?far: float -> OrthographicCamera

        /// Camera with perspective projection.
        /// 
        /// # example
        ///      var camera = new THREE.PerspectiveCamera( 45, width / height, 1, 1000 );
        ///      scene.add( camera );
        type [<AllowNullLiteral>] PerspectiveCamera =
            inherit Camera
            abstract ``type``: string with get, set
            abstract isPerspectiveCamera: obj with get, set
            abstract zoom: float with get, set
            /// Camera frustum vertical field of view, from bottom to top of view, in degrees.
            abstract fov: float with get, set
            /// Camera frustum aspect ratio, window width divided by window height.
            abstract aspect: float with get, set
            /// Camera frustum near plane.
            abstract near: float with get, set
            /// Camera frustum far plane.
            abstract far: float with get, set
            abstract focus: float with get, set
            abstract view: obj option with get, set
            abstract filmGauge: float with get, set
            abstract filmOffset: float with get, set
            abstract setFocalLength: focalLength: float -> unit
            abstract getFocalLength: unit -> float
            abstract getEffectiveFOV: unit -> float
            abstract getFilmWidth: unit -> float
            abstract getFilmHeight: unit -> float
            /// <summary>Sets an offset in a larger frustum. This is useful for multi-window or multi-monitor/multi-machine setups.
            /// For example, if you have 3x2 monitors and each monitor is 1920x1080 and the monitors are in grid like this:
            /// 
            ///      +---+---+---+
            ///      | A | B | C |
            ///      +---+---+---+
            ///      | D | E | F |
            ///      +---+---+---+
            /// 
            /// then for each monitor you would call it like this:
            /// 
            ///      var w = 1920;
            ///      var h = 1080;
            ///      var fullWidth = w * 3;
            ///      var fullHeight = h * 2;
            /// 
            ///      // A
            ///      camera.setViewOffset( fullWidth, fullHeight, w * 0, h * 0, w, h );
            ///      // B
            ///      camera.setViewOffset( fullWidth, fullHeight, w * 1, h * 0, w, h );
            ///      // C
            ///      camera.setViewOffset( fullWidth, fullHeight, w * 2, h * 0, w, h );
            ///      // D
            ///      camera.setViewOffset( fullWidth, fullHeight, w * 0, h * 1, w, h );
            ///      // E
            ///      camera.setViewOffset( fullWidth, fullHeight, w * 1, h * 1, w, h );
            ///      // F
            ///      camera.setViewOffset( fullWidth, fullHeight, w * 2, h * 1, w, h ); Note there is no reason monitors have to be the same size or in a grid.</summary>
            /// <param name="fullWidth">full width of multiview setup</param>
            /// <param name="fullHeight">full height of multiview setup</param>
            /// <param name="x">horizontal offset of subcamera</param>
            /// <param name="y">vertical offset of subcamera</param>
            /// <param name="width">width of subcamera</param>
            /// <param name="height">height of subcamera</param>
            abstract setViewOffset: fullWidth: float * fullHeight: float * x: float * y: float * width: float * height: float -> unit
            abstract clearViewOffset: unit -> unit
            /// Updates the camera projection matrix. Must be called after change of parameters.
            abstract updateProjectionMatrix: unit -> unit
            abstract toJSON: ?meta: obj option -> obj option
            abstract setLens: focalLength: float * ?frameHeight: float -> unit

        /// Camera with perspective projection.
        /// 
        /// # example
        ///      var camera = new THREE.PerspectiveCamera( 45, width / height, 1, 1000 );
        ///      scene.add( camera );
        type [<AllowNullLiteral>] PerspectiveCameraStatic =
            /// <param name="fov">Camera frustum vertical field of view. Default value is 50.</param>
            /// <param name="aspect">Camera frustum aspect ratio. Default value is 1.</param>
            /// <param name="near">Camera frustum near plane. Default value is 0.1.</param>
            /// <param name="far">Camera frustum far plane. Default value is 2000.</param>
            [<Emit "new $0($1...)">] abstract Create: ?fov: float * ?aspect: float * ?near: float * ?far: float -> PerspectiveCamera

        type [<AllowNullLiteral>] StereoCamera =
            inherit Camera
            abstract ``type``: string with get, set
            abstract aspect: float with get, set
            abstract eyeSep: float with get, set
            abstract cameraL: PerspectiveCamera with get, set
            abstract cameraR: PerspectiveCamera with get, set
            abstract update: camera: PerspectiveCamera -> unit

        type [<AllowNullLiteral>] StereoCameraStatic =
            [<Emit "new $0($1...)">] abstract Create: unit -> StereoCamera

        type [<AllowNullLiteral>] ArrayCamera =
            inherit PerspectiveCamera
            abstract cameras: ResizeArray<PerspectiveCamera> with get, set
            abstract isArrayCamera: obj with get, set

        type [<AllowNullLiteral>] ArrayCameraStatic =
            [<Emit "new $0($1...)">] abstract Create: ?cameras: ResizeArray<PerspectiveCamera> -> ArrayCamera

        type [<AllowNullLiteral>] BufferAttribute =
            abstract uuid: string with get, set
            abstract array: ArrayLike<float> with get, set
            abstract itemSize: float with get, set
            abstract dynamic: bool with get, set
            abstract updateRange: obj with get, set
            abstract version: float with get, set
            abstract normalized: bool with get, set
            abstract needsUpdate: bool with get, set
            abstract count: float with get, set
            abstract onUpload: Function with get, set
            abstract setArray: ?array: ArrayBufferView -> unit
            abstract setDynamic: dynamic: bool -> BufferAttribute
            abstract clone: unit -> BufferAttribute
            abstract copy: source: BufferAttribute -> BufferAttribute
            abstract copyAt: index1: float * attribute: BufferAttribute * index2: float -> BufferAttribute
            abstract copyArray: array: ArrayLike<float> -> BufferAttribute
            abstract copyColorsArray: colors: ResizeArray<obj> -> BufferAttribute
            abstract copyVector2sArray: vectors: ResizeArray<obj> -> BufferAttribute
            abstract copyVector3sArray: vectors: ResizeArray<obj> -> BufferAttribute
            abstract copyVector4sArray: vectors: ResizeArray<obj> -> BufferAttribute
            abstract set: value: U2<ArrayLike<float>, ArrayBufferView> * ?offset: float -> BufferAttribute
            abstract getX: index: float -> float
            abstract setX: index: float * x: float -> BufferAttribute
            abstract getY: index: float -> float
            abstract setY: index: float * y: float -> BufferAttribute
            abstract getZ: index: float -> float
            abstract setZ: index: float * z: float -> BufferAttribute
            abstract getW: index: float -> float
            abstract setW: index: float * z: float -> BufferAttribute
            abstract setXY: index: float * x: float * y: float -> BufferAttribute
            abstract setXYZ: index: float * x: float * y: float * z: float -> BufferAttribute
            abstract setXYZW: index: float * x: float * y: float * z: float * w: float -> BufferAttribute
            abstract length: float with get, set

        type [<AllowNullLiteral>] BufferAttributeStatic =
            [<Emit "new $0($1...)">] abstract Create: array: ArrayLike<float> * itemSize: float * ?normalized: bool -> BufferAttribute

        type [<AllowNullLiteral>] Int8Attribute =
            inherit BufferAttribute

        type [<AllowNullLiteral>] Int8AttributeStatic =
            [<Emit "new $0($1...)">] abstract Create: array: obj option * itemSize: float -> Int8Attribute

        type [<AllowNullLiteral>] Uint8Attribute =
            inherit BufferAttribute

        type [<AllowNullLiteral>] Uint8AttributeStatic =
            [<Emit "new $0($1...)">] abstract Create: array: obj option * itemSize: float -> Uint8Attribute

        type [<AllowNullLiteral>] Uint8ClampedAttribute =
            inherit BufferAttribute

        type [<AllowNullLiteral>] Uint8ClampedAttributeStatic =
            [<Emit "new $0($1...)">] abstract Create: array: obj option * itemSize: float -> Uint8ClampedAttribute

        type [<AllowNullLiteral>] Int16Attribute =
            inherit BufferAttribute

        type [<AllowNullLiteral>] Int16AttributeStatic =
            [<Emit "new $0($1...)">] abstract Create: array: obj option * itemSize: float -> Int16Attribute

        type [<AllowNullLiteral>] Uint16Attribute =
            inherit BufferAttribute

        type [<AllowNullLiteral>] Uint16AttributeStatic =
            [<Emit "new $0($1...)">] abstract Create: array: obj option * itemSize: float -> Uint16Attribute

        type [<AllowNullLiteral>] Int32Attribute =
            inherit BufferAttribute

        type [<AllowNullLiteral>] Int32AttributeStatic =
            [<Emit "new $0($1...)">] abstract Create: array: obj option * itemSize: float -> Int32Attribute

        type [<AllowNullLiteral>] Uint32Attribute =
            inherit BufferAttribute

        type [<AllowNullLiteral>] Uint32AttributeStatic =
            [<Emit "new $0($1...)">] abstract Create: array: obj option * itemSize: float -> Uint32Attribute

        type [<AllowNullLiteral>] Float32Attribute =
            inherit BufferAttribute

        type [<AllowNullLiteral>] Float32AttributeStatic =
            [<Emit "new $0($1...)">] abstract Create: array: obj option * itemSize: float -> Float32Attribute

        type [<AllowNullLiteral>] Float64Attribute =
            inherit BufferAttribute

        type [<AllowNullLiteral>] Float64AttributeStatic =
            [<Emit "new $0($1...)">] abstract Create: array: obj option * itemSize: float -> Float64Attribute

        type [<AllowNullLiteral>] Int8BufferAttribute =
            inherit BufferAttribute

        type [<AllowNullLiteral>] Int8BufferAttributeStatic =
            [<Emit "new $0($1...)">] abstract Create: array: U3<Iterable<float>, ArrayLike<float>, ArrayBuffer> * itemSize: float * ?normalized: bool -> Int8BufferAttribute

        type [<AllowNullLiteral>] Uint8BufferAttribute =
            inherit BufferAttribute

        type [<AllowNullLiteral>] Uint8BufferAttributeStatic =
            [<Emit "new $0($1...)">] abstract Create: array: U3<Iterable<float>, ArrayLike<float>, ArrayBuffer> * itemSize: float * ?normalized: bool -> Uint8BufferAttribute

        type [<AllowNullLiteral>] Uint8ClampedBufferAttribute =
            inherit BufferAttribute

        type [<AllowNullLiteral>] Uint8ClampedBufferAttributeStatic =
            [<Emit "new $0($1...)">] abstract Create: array: U3<Iterable<float>, ArrayLike<float>, ArrayBuffer> * itemSize: float * ?normalized: bool -> Uint8ClampedBufferAttribute

        type [<AllowNullLiteral>] Int16BufferAttribute =
            inherit BufferAttribute

        type [<AllowNullLiteral>] Int16BufferAttributeStatic =
            [<Emit "new $0($1...)">] abstract Create: array: U3<Iterable<float>, ArrayLike<float>, ArrayBuffer> * itemSize: float * ?normalized: bool -> Int16BufferAttribute

        type [<AllowNullLiteral>] Uint16BufferAttribute =
            inherit BufferAttribute

        type [<AllowNullLiteral>] Uint16BufferAttributeStatic =
            [<Emit "new $0($1...)">] abstract Create: array: U3<Iterable<float>, ArrayLike<float>, ArrayBuffer> * itemSize: float * ?normalized: bool -> Uint16BufferAttribute

        type [<AllowNullLiteral>] Int32BufferAttribute =
            inherit BufferAttribute

        type [<AllowNullLiteral>] Int32BufferAttributeStatic =
            [<Emit "new $0($1...)">] abstract Create: array: U3<Iterable<float>, ArrayLike<float>, ArrayBuffer> * itemSize: float * ?normalized: bool -> Int32BufferAttribute

        type [<AllowNullLiteral>] Uint32BufferAttribute =
            inherit BufferAttribute

        type [<AllowNullLiteral>] Uint32BufferAttributeStatic =
            [<Emit "new $0($1...)">] abstract Create: array: U3<Iterable<float>, ArrayLike<float>, ArrayBuffer> * itemSize: float * ?normalized: bool -> Uint32BufferAttribute

        type [<AllowNullLiteral>] Float32BufferAttribute =
            inherit BufferAttribute

        type [<AllowNullLiteral>] Float32BufferAttributeStatic =
            [<Emit "new $0($1...)">] abstract Create: array: U3<Iterable<float>, ArrayLike<float>, ArrayBuffer> * itemSize: float * ?normalized: bool -> Float32BufferAttribute

        type [<AllowNullLiteral>] Float64BufferAttribute =
            inherit BufferAttribute

        type [<AllowNullLiteral>] Float64BufferAttributeStatic =
            [<Emit "new $0($1...)">] abstract Create: array: U3<Iterable<float>, ArrayLike<float>, ArrayBuffer> * itemSize: float * ?normalized: bool -> Float64BufferAttribute

        type [<AllowNullLiteral>] DynamicBufferAttribute =
            inherit BufferAttribute

        type [<AllowNullLiteral>] DynamicBufferAttributeStatic =
            [<Emit "new $0($1...)">] abstract Create: unit -> DynamicBufferAttribute

        /// This is a superefficent class for geometries because it saves all data in buffers.
        /// It reduces memory costs and cpu cycles. But it is not as easy to work with because of all the nessecary buffer calculations.
        /// It is mainly interesting when working with static objects.
        type [<AllowNullLiteral>] BufferGeometry =
            inherit EventDispatcher
            abstract MaxIndex: float with get, set
            /// Unique number of this buffergeometry instance
            abstract id: float with get, set
            abstract uuid: string with get, set
            abstract name: string with get, set
            abstract ``type``: string with get, set
            abstract index: BufferAttribute with get, set
            abstract attributes: obj with get, set
            abstract morphAttributes: obj option with get, set
            abstract groups: ResizeArray<obj> with get, set
            abstract boundingBox: Box3 with get, set
            abstract boundingSphere: Sphere with get, set
            abstract drawRange: obj with get, set
            abstract getIndex: unit -> BufferAttribute
            abstract setIndex: index: U2<BufferAttribute, ResizeArray<float>> -> unit
            abstract addAttribute: name: string * attribute: U2<BufferAttribute, InterleavedBufferAttribute> -> BufferGeometry
            abstract getAttribute: name: string -> U2<BufferAttribute, InterleavedBufferAttribute>
            abstract removeAttribute: name: string -> BufferGeometry
            abstract addGroup: start: float * count: float * ?materialIndex: float -> unit
            abstract clearGroups: unit -> unit
            abstract setDrawRange: start: float * count: float -> unit
            /// Bakes matrix transform directly into vertex coordinates.
            abstract applyMatrix: matrix: Matrix4 -> BufferGeometry
            abstract rotateX: angle: float -> BufferGeometry
            abstract rotateY: angle: float -> BufferGeometry
            abstract rotateZ: angle: float -> BufferGeometry
            abstract translate: x: float * y: float * z: float -> BufferGeometry
            abstract scale: x: float * y: float * z: float -> BufferGeometry
            abstract lookAt: v: Vector3 -> unit
            abstract center: unit -> BufferGeometry
            abstract setFromObject: ``object``: Object3D -> BufferGeometry
            abstract setFromPoints: points: U2<ResizeArray<Vector3>, ResizeArray<Vector2>> -> BufferGeometry
            abstract updateFromObject: ``object``: Object3D -> unit
            abstract fromGeometry: geometry: Geometry * ?settings: obj option -> BufferGeometry
            abstract fromDirectGeometry: geometry: DirectGeometry -> BufferGeometry
            /// Computes bounding box of the geometry, updating Geometry.boundingBox attribute.
            /// Bounding boxes aren't computed by default. They need to be explicitly computed, otherwise they are null.
            abstract computeBoundingBox: unit -> unit
            /// Computes bounding sphere of the geometry, updating Geometry.boundingSphere attribute.
            /// Bounding spheres aren't' computed by default. They need to be explicitly computed, otherwise they are null.
            abstract computeBoundingSphere: unit -> unit
            /// Computes vertex normals by averaging face normals.
            abstract computeVertexNormals: unit -> unit
            abstract merge: geometry: BufferGeometry * offset: float -> BufferGeometry
            abstract normalizeNormals: unit -> unit
            abstract toNonIndexed: unit -> BufferGeometry
            abstract toJSON: unit -> obj option
            abstract clone: unit -> BufferGeometry
            abstract copy: source: BufferGeometry -> BufferGeometry
            /// Disposes the object from memory.
            /// You need to call this when you want the bufferGeometry removed while the application is running.
            abstract dispose: unit -> unit
            abstract drawcalls: obj option with get, set
            abstract offsets: obj option with get, set
            abstract addIndex: index: obj option -> unit
            abstract addDrawCall: start: obj option * count: obj option * ?indexOffset: obj option -> unit
            abstract clearDrawCalls: unit -> unit
            abstract addAttribute: name: obj option * array: obj option * itemSize: obj option -> obj option

        /// This is a superefficent class for geometries because it saves all data in buffers.
        /// It reduces memory costs and cpu cycles. But it is not as easy to work with because of all the nessecary buffer calculations.
        /// It is mainly interesting when working with static objects.
        type [<AllowNullLiteral>] BufferGeometryStatic =
            /// This creates a new BufferGeometry. It also sets several properties to an default value.
            [<Emit "new $0($1...)">] abstract Create: unit -> BufferGeometry

        /// Object for keeping track of time.
        type [<AllowNullLiteral>] Clock =
            /// If set, starts the clock automatically when the first update is called.
            abstract autoStart: bool with get, set
            /// When the clock is running, It holds the starttime of the clock.
            /// This counted from the number of milliseconds elapsed since 1 January 1970 00:00:00 UTC.
            abstract startTime: float with get, set
            /// When the clock is running, It holds the previous time from a update.
            /// This counted from the number of milliseconds elapsed since 1 January 1970 00:00:00 UTC.
            abstract oldTime: float with get, set
            /// When the clock is running, It holds the time elapsed between the start of the clock to the previous update.
            /// This parameter is in seconds of three decimal places.
            abstract elapsedTime: float with get, set
            /// This property keeps track whether the clock is running or not.
            abstract running: bool with get, set
            /// Starts clock.
            abstract start: unit -> unit
            /// Stops clock.
            abstract stop: unit -> unit
            /// Get the seconds passed since the clock started.
            abstract getElapsedTime: unit -> float
            /// Get the seconds passed since the last call to this method.
            abstract getDelta: unit -> float

        /// Object for keeping track of time.
        type [<AllowNullLiteral>] ClockStatic =
            /// <param name="autoStart">Automatically start the clock.</param>
            [<Emit "new $0($1...)">] abstract Create: ?autoStart: bool -> Clock

        type [<AllowNullLiteral>] DirectGeometry =
            inherit EventDispatcher
            abstract id: float with get, set
            abstract uuid: string with get, set
            abstract name: string with get, set
            abstract ``type``: string with get, set
            abstract indices: ResizeArray<float> with get, set
            abstract vertices: ResizeArray<Vector3> with get, set
            abstract normals: ResizeArray<Vector3> with get, set
            abstract colors: ResizeArray<Color> with get, set
            abstract uvs: ResizeArray<Vector2> with get, set
            abstract uvs2: ResizeArray<Vector2> with get, set
            abstract groups: ResizeArray<obj> with get, set
            abstract morphTargets: ResizeArray<MorphTarget> with get, set
            abstract skinWeights: ResizeArray<Vector4> with get, set
            abstract skinIndices: ResizeArray<Vector4> with get, set
            abstract boundingBox: Box3 with get, set
            abstract boundingSphere: Sphere with get, set
            abstract verticesNeedUpdate: bool with get, set
            abstract normalsNeedUpdate: bool with get, set
            abstract colorsNeedUpdate: bool with get, set
            abstract uvsNeedUpdate: bool with get, set
            abstract groupsNeedUpdate: bool with get, set
            abstract computeBoundingBox: unit -> unit
            abstract computeBoundingSphere: unit -> unit
            abstract computeGroups: geometry: Geometry -> unit
            abstract fromGeometry: geometry: Geometry -> DirectGeometry
            abstract dispose: unit -> unit
            abstract addEventListener: ``type``: string * listener: (Event -> unit) -> unit
            abstract hasEventListener: ``type``: string * listener: (Event -> unit) -> bool
            abstract removeEventListener: ``type``: string * listener: (Event -> unit) -> unit
            abstract dispatchEvent: ``event``: DirectGeometryDispatchEventEvent -> unit

        type [<AllowNullLiteral>] DirectGeometryDispatchEventEvent =
            abstract ``type``: string with get, set
            [<Emit "$0[$1]{{=$2}}">] abstract Item: attachment: string -> obj option with get, set

        type [<AllowNullLiteral>] DirectGeometryStatic =
            [<Emit "new $0($1...)">] abstract Create: unit -> DirectGeometry

        /// JavaScript events for custom objects
        /// 
        /// # Example
        ///      var Car = function () {
        /// 
        ///          EventDispatcher.call( this );
        ///          this.start = function () {
        /// 
        ///              this.dispatchEvent( { type: 'start', message: 'vroom vroom!' } );
        /// 
        ///          };
        /// 
        ///      };
        /// 
        ///      var car = new Car();
        ///      car.addEventListener( 'start', function ( event ) {
        /// 
        ///          alert( event.message );
        /// 
        ///      } );
        ///      car.start();
        type [<AllowNullLiteral>] EventDispatcher =
            /// <summary>Adds a listener to an event type.</summary>
            /// <param name="type">The type of event to listen to.</param>
            /// <param name="listener">The function that gets called when the event is fired.</param>
            abstract addEventListener: ``type``: string * listener: (Event -> unit) -> unit
            /// <summary>Checks if listener is added to an event type.</summary>
            /// <param name="type">The type of event to listen to.</param>
            /// <param name="listener">The function that gets called when the event is fired.</param>
            abstract hasEventListener: ``type``: string * listener: (Event -> unit) -> bool
            /// <summary>Removes a listener from an event type.</summary>
            /// <param name="type">The type of the listener that gets removed.</param>
            /// <param name="listener">The listener function that gets removed.</param>
            abstract removeEventListener: ``type``: string * listener: (Event -> unit) -> unit
            /// Fire an event type.
            abstract dispatchEvent: ``event``: EventDispatcherDispatchEventEvent -> unit

        type [<AllowNullLiteral>] EventDispatcherDispatchEventEvent =
            abstract ``type``: string with get, set
            [<Emit "$0[$1]{{=$2}}">] abstract Item: attachment: string -> obj option with get, set

        /// JavaScript events for custom objects
        /// 
        /// # Example
        ///      var Car = function () {
        /// 
        ///          EventDispatcher.call( this );
        ///          this.start = function () {
        /// 
        ///              this.dispatchEvent( { type: 'start', message: 'vroom vroom!' } );
        /// 
        ///          };
        /// 
        ///      };
        /// 
        ///      var car = new Car();
        ///      car.addEventListener( 'start', function ( event ) {
        /// 
        ///          alert( event.message );
        /// 
        ///      } );
        ///      car.start();
        type [<AllowNullLiteral>] EventDispatcherStatic =
            /// Creates eventDispatcher object. It needs to be call with '.call' to add the functionality to an object.
            [<Emit "new $0($1...)">] abstract Create: unit -> EventDispatcher

        type [<AllowNullLiteral>] Event =
            abstract ``type``: string with get, set
            abstract target: obj option with get, set
            [<Emit "$0[$1]{{=$2}}">] abstract Item: attachment: string -> obj option with get, set

        /// Triangle face.
        /// 
        /// # Example
        ///      var normal = new THREE.Vector3( 0, 1, 0 );
        ///      var color = new THREE.Color( 0xffaa00 );
        ///      var face = new THREE.Face3( 0, 1, 2, normal, color, 0 );
        type [<AllowNullLiteral>] Face3 =
            /// Vertex A index.
            abstract a: float with get, set
            /// Vertex B index.
            abstract b: float with get, set
            /// Vertex C index.
            abstract c: float with get, set
            /// Face normal.
            abstract normal: Vector3 with get, set
            /// Array of 4 vertex normals.
            abstract vertexNormals: ResizeArray<Vector3> with get, set
            /// Face color.
            abstract color: Color with get, set
            /// Array of 4 vertex normals.
            abstract vertexColors: ResizeArray<Color> with get, set
            /// Material index (points to {@link Geometry.materials}).
            abstract materialIndex: float with get, set
            abstract clone: unit -> Face3
            abstract copy: source: Face3 -> Face3

        /// Triangle face.
        /// 
        /// # Example
        ///      var normal = new THREE.Vector3( 0, 1, 0 );
        ///      var color = new THREE.Color( 0xffaa00 );
        ///      var face = new THREE.Face3( 0, 1, 2, normal, color, 0 );
        type [<AllowNullLiteral>] Face3Static =
            /// <param name="a">Vertex A index.</param>
            /// <param name="b">Vertex B index.</param>
            /// <param name="c">Vertex C index.</param>
            /// <param name="normal">Face normal or array of vertex normals.</param>
            /// <param name="color">Face color or array of vertex colors.</param>
            /// <param name="materialIndex">Material index.</param>
            [<Emit "new $0($1...)">] abstract Create: a: float * b: float * c: float * ?normal: Vector3 * ?color: Color * ?materialIndex: float -> Face3
            [<Emit "new $0($1...)">] abstract Create: a: float * b: float * c: float * ?normal: Vector3 * ?vertexColors: ResizeArray<Color> * ?materialIndex: float -> Face3
            [<Emit "new $0($1...)">] abstract Create: a: float * b: float * c: float * ?vertexNormals: ResizeArray<Vector3> * ?color: Color * ?materialIndex: float -> Face3
            [<Emit "new $0($1...)">] abstract Create: a: float * b: float * c: float * ?vertexNormals: ResizeArray<Vector3> * ?vertexColors: ResizeArray<Color> * ?materialIndex: float -> Face3

        type [<AllowNullLiteral>] Face4 =
            inherit Face3

        type [<AllowNullLiteral>] Face4Static =
            [<Emit "new $0($1...)">] abstract Create: unit -> Face4

        type [<AllowNullLiteral>] MorphTarget =
            abstract name: string with get, set
            abstract vertices: ResizeArray<Vector3> with get, set

        type [<AllowNullLiteral>] MorphColor =
            abstract name: string with get, set
            abstract colors: ResizeArray<Color> with get, set

        type [<AllowNullLiteral>] MorphNormals =
            abstract name: string with get, set
            abstract normals: ResizeArray<Vector3> with get, set

        /// Base class for geometries
        /// 
        /// # Example
        ///      var geometry = new THREE.Geometry();
        ///      geometry.vertices.push( new THREE.Vector3( -10, 10, 0 ) );
        ///      geometry.vertices.push( new THREE.Vector3( -10, -10, 0 ) );
        ///      geometry.vertices.push( new THREE.Vector3( 10, -10, 0 ) );
        ///      geometry.faces.push( new THREE.Face3( 0, 1, 2 ) );
        ///      geometry.computeBoundingSphere();
        type [<AllowNullLiteral>] Geometry =
            inherit EventDispatcher
            /// Unique number of this geometry instance
            abstract id: float with get, set
            abstract uuid: string with get, set
            /// Name for this geometry. Default is an empty string.
            abstract name: string with get, set
            abstract ``type``: string with get, set
            /// The array of vertices hold every position of points of the model.
            /// To signal an update in this array, Geometry.verticesNeedUpdate needs to be set to true.
            abstract vertices: ResizeArray<Vector3> with get, set
            /// Array of vertex colors, matching number and order of vertices.
            /// Used in ParticleSystem, Line and Ribbon.
            /// Meshes use per-face-use-of-vertex colors embedded directly in faces.
            /// To signal an update in this array, Geometry.colorsNeedUpdate needs to be set to true.
            abstract colors: ResizeArray<Color> with get, set
            /// Array of triangles or/and quads.
            /// The array of faces describe how each vertex in the model is connected with each other.
            /// To signal an update in this array, Geometry.elementsNeedUpdate needs to be set to true.
            abstract faces: ResizeArray<Face3> with get, set
            /// Array of face UV layers.
            /// Each UV layer is an array of UV matching order and number of vertices in faces.
            /// To signal an update in this array, Geometry.uvsNeedUpdate needs to be set to true.
            abstract faceVertexUvs: ResizeArray<ResizeArray<ResizeArray<Vector2>>> with get, set
            /// Array of morph targets. Each morph target is a Javascript object:
            /// 
            ///      { name: "targetName", vertices: [ new THREE.Vector3(), ... ] }
            /// 
            /// Morph vertices match number and order of primary vertices.
            abstract morphTargets: ResizeArray<MorphTarget> with get, set
            /// Array of morph normals. Morph normals have similar structure as morph targets, each normal set is a Javascript object:
            /// 
            ///      morphNormal = { name: "NormalName", normals: [ new THREE.Vector3(), ... ] }
            abstract morphNormals: ResizeArray<MorphNormals> with get, set
            /// Array of skinning weights, matching number and order of vertices.
            abstract skinWeights: ResizeArray<Vector4> with get, set
            /// Array of skinning indices, matching number and order of vertices.
            abstract skinIndices: ResizeArray<Vector4> with get, set
            abstract lineDistances: ResizeArray<float> with get, set
            /// Bounding box.
            abstract boundingBox: Box3 with get, set
            /// Bounding sphere.
            abstract boundingSphere: Sphere with get, set
            /// Set to true if the vertices array has been updated.
            abstract verticesNeedUpdate: bool with get, set
            /// Set to true if the faces array has been updated.
            abstract elementsNeedUpdate: bool with get, set
            /// Set to true if the uvs array has been updated.
            abstract uvsNeedUpdate: bool with get, set
            /// Set to true if the normals array has been updated.
            abstract normalsNeedUpdate: bool with get, set
            /// Set to true if the colors array has been updated.
            abstract colorsNeedUpdate: bool with get, set
            /// Set to true if the linedistances array has been updated.
            abstract lineDistancesNeedUpdate: bool with get, set
            abstract groupsNeedUpdate: bool with get, set
            /// Bakes matrix transform directly into vertex coordinates.
            abstract applyMatrix: matrix: Matrix4 -> Geometry
            abstract rotateX: angle: float -> Geometry
            abstract rotateY: angle: float -> Geometry
            abstract rotateZ: angle: float -> Geometry
            abstract translate: x: float * y: float * z: float -> Geometry
            abstract scale: x: float * y: float * z: float -> Geometry
            abstract lookAt: vector: Vector3 -> unit
            abstract fromBufferGeometry: geometry: BufferGeometry -> Geometry
            abstract center: unit -> Geometry
            abstract normalize: unit -> Geometry
            /// Computes face normals.
            abstract computeFaceNormals: unit -> unit
            /// Computes vertex normals by averaging face normals.
            /// Face normals must be existing / computed beforehand.
            abstract computeVertexNormals: ?areaWeighted: bool -> unit
            /// Compute vertex normals, but duplicating face normals.
            abstract computeFlatVertexNormals: unit -> unit
            /// Computes morph normals.
            abstract computeMorphNormals: unit -> unit
            /// Computes bounding box of the geometry, updating {@link Geometry.boundingBox} attribute.
            abstract computeBoundingBox: unit -> unit
            /// Computes bounding sphere of the geometry, updating Geometry.boundingSphere attribute.
            /// Neither bounding boxes or bounding spheres are computed by default. They need to be explicitly computed, otherwise they are null.
            abstract computeBoundingSphere: unit -> unit
            abstract merge: geometry: Geometry * ?matrix: Matrix * ?materialIndexOffset: float -> unit
            abstract mergeMesh: mesh: Mesh -> unit
            /// Checks for duplicate vertices using hashmap.
            /// Duplicated vertices are removed and faces' vertices are updated.
            abstract mergeVertices: unit -> float
            abstract setFromPoints: points: U2<Array<Vector2>, Array<Vector3>> -> Geometry
            abstract sortFacesByMaterialIndex: unit -> unit
            abstract toJSON: unit -> obj option
            /// Creates a new clone of the Geometry.
            abstract clone: unit -> Geometry
            abstract copy: source: Geometry -> Geometry
            /// Removes The object from memory.
            /// Don't forget to call this method when you remove an geometry because it can cuase meomory leaks.
            abstract dispose: unit -> unit
            abstract bones: ResizeArray<Bone> with get, set
            abstract animation: AnimationClip with get, set
            abstract animations: ResizeArray<AnimationClip> with get, set
            abstract addEventListener: ``type``: string * listener: (Event -> unit) -> unit
            abstract hasEventListener: ``type``: string * listener: (Event -> unit) -> bool
            abstract removeEventListener: ``type``: string * listener: (Event -> unit) -> unit
            abstract dispatchEvent: ``event``: GeometryDispatchEventEvent -> unit

        type [<AllowNullLiteral>] GeometryDispatchEventEvent =
            abstract ``type``: string with get, set
            [<Emit "$0[$1]{{=$2}}">] abstract Item: attachment: string -> obj option with get, set

        /// Base class for geometries
        /// 
        /// # Example
        ///      var geometry = new THREE.Geometry();
        ///      geometry.vertices.push( new THREE.Vector3( -10, 10, 0 ) );
        ///      geometry.vertices.push( new THREE.Vector3( -10, -10, 0 ) );
        ///      geometry.vertices.push( new THREE.Vector3( 10, -10, 0 ) );
        ///      geometry.faces.push( new THREE.Face3( 0, 1, 2 ) );
        ///      geometry.computeBoundingSphere();
        type [<AllowNullLiteral>] GeometryStatic =
            [<Emit "new $0($1...)">] abstract Create: unit -> Geometry

        module BufferGeometryUtils =

            type [<AllowNullLiteral>] IExports =
                abstract mergeBufferGeometries: geometries: ResizeArray<BufferGeometry> -> BufferGeometry
                abstract computeTangents: geometry: BufferGeometry -> obj
                abstract mergeBufferAttributes: attributes: ResizeArray<BufferAttribute> -> BufferAttribute

        module GeometryUtils =

            type [<AllowNullLiteral>] IExports =
                abstract merge: geometry1: obj option * geometry2: obj option * ?materialIndexOffset: obj option -> obj option
                abstract center: geometry: obj option -> obj option

        type [<AllowNullLiteral>] InstancedBufferAttribute =
            inherit BufferAttribute
            abstract meshPerAttribute: float with get, set

        type [<AllowNullLiteral>] InstancedBufferAttributeStatic =
            [<Emit "new $0($1...)">] abstract Create: data: ArrayLike<float> * itemSize: float * ?meshPerAttribute: float -> InstancedBufferAttribute

        type [<AllowNullLiteral>] InstancedBufferGeometry =
            inherit BufferGeometry
            abstract groups: ResizeArray<obj> with get, set
            abstract maxInstancedCount: float with get, set
            abstract addGroup: start: float * count: float * instances: float -> unit

        type [<AllowNullLiteral>] InstancedBufferGeometryStatic =
            [<Emit "new $0($1...)">] abstract Create: unit -> InstancedBufferGeometry

        type [<AllowNullLiteral>] InterleavedBuffer =
            abstract array: ArrayLike<float> with get, set
            abstract stride: float with get, set
            abstract dynamic: bool with get, set
            abstract updateRange: obj with get, set
            abstract version: float with get, set
            abstract length: float with get, set
            abstract count: float with get, set
            abstract needsUpdate: bool with get, set
            abstract setArray: ?array: ArrayBufferView -> unit
            abstract setDynamic: dynamic: bool -> InterleavedBuffer
            abstract clone: unit -> InterleavedBuffer
            abstract copy: source: InterleavedBuffer -> InterleavedBuffer
            abstract copyAt: index1: float * attribute: InterleavedBufferAttribute * index2: float -> InterleavedBuffer
            abstract set: value: ArrayLike<float> * index: float -> InterleavedBuffer

        type [<AllowNullLiteral>] InterleavedBufferStatic =
            [<Emit "new $0($1...)">] abstract Create: array: ArrayLike<float> * stride: float -> InterleavedBuffer

        type [<AllowNullLiteral>] InstancedInterleavedBuffer =
            inherit InterleavedBuffer
            abstract meshPerAttribute: float with get, set

        type [<AllowNullLiteral>] InstancedInterleavedBufferStatic =
            [<Emit "new $0($1...)">] abstract Create: array: ArrayLike<float> * stride: float * ?meshPerAttribute: float -> InstancedInterleavedBuffer

        type [<AllowNullLiteral>] InterleavedBufferAttribute =
            abstract uuid: string with get, set
            abstract data: InterleavedBuffer with get, set
            abstract itemSize: float with get, set
            abstract offset: float with get, set
            abstract count: float with get, set
            abstract normalized: bool with get, set
            abstract array: ResizeArray<obj option> with get, set
            abstract getX: index: float -> float
            abstract setX: index: float * x: float -> InterleavedBufferAttribute
            abstract getY: index: float -> float
            abstract setY: index: float * y: float -> InterleavedBufferAttribute
            abstract getZ: index: float -> float
            abstract setZ: index: float * z: float -> InterleavedBufferAttribute
            abstract getW: index: float -> float
            abstract setW: index: float * z: float -> InterleavedBufferAttribute
            abstract setXY: index: float * x: float * y: float -> InterleavedBufferAttribute
            abstract setXYZ: index: float * x: float * y: float * z: float -> InterleavedBufferAttribute
            abstract setXYZW: index: float * x: float * y: float * z: float * w: float -> InterleavedBufferAttribute
            abstract length: float with get, set

        type [<AllowNullLiteral>] InterleavedBufferAttributeStatic =
            [<Emit "new $0($1...)">] abstract Create: interleavedBuffer: InterleavedBuffer * itemSize: float * offset: float * ?normalized: bool -> InterleavedBufferAttribute

        /// Base class for scene graph objects
        type [<AllowNullLiteral>] Object3D =
            inherit EventDispatcher
            /// Unique number of this object instance.
            abstract id: float with get, set
            abstract uuid: string with get, set
            /// Optional name of the object (doesn't need to be unique).
            abstract name: string with get, set
            abstract ``type``: string with get, set
            /// Object's parent in the scene graph.
            abstract parent: Object3D option with get, set
            /// Array with object's children.
            abstract children: ResizeArray<Object3D> with get, set
            /// Up direction.
            abstract up: Vector3 with get, set
            /// Object's local position.
            abstract position: Vector3 with get, set
            /// Object's local rotation (Euler angles), in radians.
            abstract rotation: Euler with get, set
            /// Global rotation.
            abstract quaternion: Quaternion with get, set
            /// Object's local scale.
            abstract scale: Vector3 with get, set
            abstract modelViewMatrix: Matrix4 with get, set
            abstract normalMatrix: Matrix3 with get, set
            /// Local transform.
            abstract matrix: Matrix4 with get, set
            /// The global transform of the object. If the Object3d has no parent, then it's identical to the local transform.
            abstract matrixWorld: Matrix4 with get, set
            /// When this is set, it calculates the matrix of position, (rotation or quaternion) and scale every frame and also recalculates the matrixWorld property.
            abstract matrixAutoUpdate: bool with get, set
            /// When this is set, it calculates the matrixWorld in that frame and resets this property to false.
            abstract matrixWorldNeedsUpdate: bool with get, set
            abstract layers: Layers with get, set
            /// Object gets rendered if true.
            abstract visible: bool with get, set
            /// Gets rendered into shadow map.
            abstract castShadow: bool with get, set
            /// Material gets baked in shadow receiving.
            abstract receiveShadow: bool with get, set
            /// When this is set, it checks every frame if the object is in the frustum of the camera. Otherwise the object gets drawn every frame even if it isn't visible.
            abstract frustumCulled: bool with get, set
            abstract renderOrder: float with get, set
            /// An object that can be used to store custom data about the Object3d. It should not hold references to functions as these will not be cloned.
            abstract userData: obj with get, set
            /// Used to check whether this or derived classes are Object3Ds. Default is true.
            /// You should not change this, as it is used internally for optimisation.
            abstract isObject3D: obj with get, set
            /// Calls before rendering object
            abstract onBeforeRender: (WebGLRenderer -> Scene -> Camera -> U2<Geometry, BufferGeometry> -> Material -> Group -> unit) with get, set
            /// Calls after rendering object
            abstract onAfterRender: (WebGLRenderer -> Scene -> Camera -> U2<Geometry, BufferGeometry> -> Material -> Group -> unit) with get, set
            abstract DefaultUp: Vector3 with get, set
            abstract DefaultMatrixAutoUpdate: bool with get, set
            /// This updates the position, rotation and scale with the matrix.
            abstract applyMatrix: matrix: Matrix4 -> unit
            abstract applyQuaternion: quaternion: Quaternion -> Object3D
            abstract setRotationFromAxisAngle: axis: Vector3 * angle: float -> unit
            abstract setRotationFromEuler: euler: Euler -> unit
            abstract setRotationFromMatrix: m: Matrix4 -> unit
            abstract setRotationFromQuaternion: q: Quaternion -> unit
            /// <summary>Rotate an object along an axis in object space. The axis is assumed to be normalized.</summary>
            /// <param name="axis">A normalized vector in object space.</param>
            /// <param name="angle">The angle in radians.</param>
            abstract rotateOnAxis: axis: Vector3 * angle: float -> Object3D
            /// <summary>Rotate an object along an axis in world space. The axis is assumed to be normalized. Method Assumes no rotated parent.</summary>
            /// <param name="axis">A normalized vector in object space.</param>
            /// <param name="angle">The angle in radians.</param>
            abstract rotateOnWorldAxis: axis: Vector3 * angle: float -> Object3D
            /// <param name="angle"></param>
            abstract rotateX: angle: float -> Object3D
            /// <param name="angle"></param>
            abstract rotateY: angle: float -> Object3D
            /// <param name="angle"></param>
            abstract rotateZ: angle: float -> Object3D
            /// <param name="axis">A normalized vector in object space.</param>
            /// <param name="distance">The distance to translate.</param>
            abstract translateOnAxis: axis: Vector3 * distance: float -> Object3D
            /// <summary>Translates object along x axis by distance.</summary>
            /// <param name="distance">Distance.</param>
            abstract translateX: distance: float -> Object3D
            /// <summary>Translates object along y axis by distance.</summary>
            /// <param name="distance">Distance.</param>
            abstract translateY: distance: float -> Object3D
            /// <summary>Translates object along z axis by distance.</summary>
            /// <param name="distance">Distance.</param>
            abstract translateZ: distance: float -> Object3D
            /// <summary>Updates the vector from local space to world space.</summary>
            /// <param name="vector">A local vector.</param>
            abstract localToWorld: vector: Vector3 -> Vector3
            /// <summary>Updates the vector from world space to local space.</summary>
            /// <param name="vector">A world vector.</param>
            abstract worldToLocal: vector: Vector3 -> Vector3
            /// <summary>Rotates object to face point in space.</summary>
            /// <param name="vector">A world vector to look at.</param>
            abstract lookAt: vector: U2<Vector3, float> * ?y: float * ?z: float -> unit
            /// Adds object as child of this object.
            abstract add: [<ParamArray>] ``object``: ResizeArray<Object3D> -> Object3D
            /// Removes object as child of this object.
            abstract remove: [<ParamArray>] ``object``: ResizeArray<Object3D> -> Object3D
            /// <summary>Searches through the object's children and returns the first with a matching id.</summary>
            /// <param name="id">Unique number of the object instance</param>
            abstract getObjectById: id: float -> Object3D option
            /// <summary>Searches through the object's children and returns the first with a matching name.</summary>
            /// <param name="name">String to match to the children's Object3d.name property.</param>
            abstract getObjectByName: name: string -> Object3D option
            abstract getObjectByProperty: name: string * value: string -> Object3D option
            abstract getWorldPosition: target: Vector3 -> Vector3
            abstract getWorldQuaternion: target: Quaternion -> Quaternion
            abstract getWorldScale: target: Vector3 -> Vector3
            abstract getWorldDirection: target: Vector3 -> Vector3
            abstract raycast: raycaster: Raycaster * intersects: ResizeArray<Intersection> -> unit
            abstract traverse: callback: (Object3D -> obj option) -> unit
            abstract traverseVisible: callback: (Object3D -> obj option) -> unit
            abstract traverseAncestors: callback: (Object3D -> obj option) -> unit
            /// Updates local transform.
            abstract updateMatrix: unit -> unit
            /// Updates global transform of the object and its children.
            abstract updateMatrixWorld: force: bool -> unit
            abstract toJSON: ?meta: Object3DToJSONMeta -> obj option
            abstract clone: ?recursive: bool -> Object3D
            /// <param name="recursive"></param>
            abstract copy: source: Object3D * ?recursive: bool -> Object3D

        type [<AllowNullLiteral>] Object3DToJSONMeta =
            abstract geometries: obj option with get, set
            abstract materials: obj option with get, set
            abstract textures: obj option with get, set
            abstract images: obj option with get, set

        /// Base class for scene graph objects
        type [<AllowNullLiteral>] Object3DStatic =
            [<Emit "new $0($1...)">] abstract Create: unit -> Object3D

        type [<AllowNullLiteral>] Intersection =
            abstract distance: float with get, set
            abstract distanceToRay: float option with get, set
            abstract point: Vector3 with get, set
            abstract index: float option with get, set
            abstract face: Face3 option with get, set
            abstract faceIndex: float option with get, set
            abstract ``object``: Object3D with get, set
            abstract uv: Vector2 option with get, set

        type [<AllowNullLiteral>] RaycasterParameters =
            abstract Mesh: obj option with get, set
            abstract Line: obj option with get, set
            abstract LOD: obj option with get, set
            abstract Points: obj option with get, set
            abstract Sprite: obj option with get, set

        type [<AllowNullLiteral>] Raycaster =
            /// The Ray used for the raycasting. 
            abstract ray: Ray with get, set
            /// The near factor of the raycaster. This value indicates which objects can be discarded based on the
            /// distance. This value shouldn't be negative and should be smaller than the far property.
            abstract near: float with get, set
            /// The far factor of the raycaster. This value indicates which objects can be discarded based on the
            /// distance. This value shouldn't be negative and should be larger than the near property.
            abstract far: float with get, set
            abstract ``params``: RaycasterParameters with get, set
            /// The precision factor of the raycaster when intersecting Line objects.
            abstract linePrecision: float with get, set
            /// <summary>Updates the ray with a new origin and direction.</summary>
            /// <param name="origin">The origin vector where the ray casts from.</param>
            /// <param name="direction">The normalized direction vector that gives direction to the ray.</param>
            abstract set: origin: Vector3 * direction: Vector3 -> unit
            /// <summary>Updates the ray with a new origin and direction.</summary>
            /// <param name="coords">2D coordinates of the mouse, in normalized device coordinates (NDC)---X and Y components should be between -1 and 1.</param>
            /// <param name="camera">camera from which the ray should originate</param>
            abstract setFromCamera: coords: RaycasterSetFromCameraCoords * camera: Camera -> unit
            /// <summary>Checks all intersection between the ray and the object with or without the descendants. Intersections are returned sorted by distance, closest first.</summary>
            /// <param name="object">The object to check for intersection with the ray.</param>
            /// <param name="recursive">If true, it also checks all descendants. Otherwise it only checks intersecton with the object. Default is false.</param>
            /// <param name="optionalTarget">(optional) target to set the result. Otherwise a new Array is instantiated. If set, you must clear this array prior to each call (i.e., array.length = 0;).</param>
            abstract intersectObject: ``object``: Object3D * ?recursive: bool * ?optionalTarget: ResizeArray<Intersection> -> ResizeArray<Intersection>
            /// <summary>Checks all intersection between the ray and the objects with or without the descendants. Intersections are returned sorted by distance, closest first. Intersections are of the same form as those returned by .intersectObject.</summary>
            /// <param name="objects">The objects to check for intersection with the ray.</param>
            /// <param name="recursive">If true, it also checks all descendants of the objects. Otherwise it only checks intersecton with the objects. Default is false.</param>
            /// <param name="optionalTarget">(optional) target to set the result. Otherwise a new Array is instantiated. If set, you must clear this array prior to each call (i.e., array.length = 0;).</param>
            abstract intersectObjects: objects: ResizeArray<Object3D> * ?recursive: bool * ?optionalTarget: ResizeArray<Intersection> -> ResizeArray<Intersection>

        type [<AllowNullLiteral>] RaycasterSetFromCameraCoords =
            abstract x: float with get, set
            abstract y: float with get, set

        type [<AllowNullLiteral>] RaycasterStatic =
            /// <summary>This creates a new raycaster object.</summary>
            /// <param name="origin">The origin vector where the ray casts from.</param>
            /// <param name="direction">The direction vector that gives direction to the ray. Should be normalized.</param>
            /// <param name="near">All results returned are further away than near. Near can't be negative. Default value is 0.</param>
            /// <param name="far">All results returned are closer then far. Far can't be lower then near . Default value is Infinity.</param>
            [<Emit "new $0($1...)">] abstract Create: ?origin: Vector3 * ?direction: Vector3 * ?near: float * ?far: float -> Raycaster

        type [<AllowNullLiteral>] Layers =
            abstract mask: float with get, set
            abstract set: channel: float -> unit
            abstract enable: channel: float -> unit
            abstract toggle: channel: float -> unit
            abstract disable: channel: float -> unit
            abstract test: layers: Layers -> bool

        type [<AllowNullLiteral>] LayersStatic =
            [<Emit "new $0($1...)">] abstract Create: unit -> Layers

        type [<AllowNullLiteral>] Font =
            abstract data: string with get, set
            abstract generateShapes: text: string * size: float * divisions: float -> ResizeArray<obj option>

        type [<AllowNullLiteral>] FontStatic =
            [<Emit "new $0($1...)">] abstract Create: jsondata: obj option -> Font

        /// Abstract base class for lights.
        type [<AllowNullLiteral>] Light =
            inherit Object3D
            abstract color: Color with get, set
            abstract intensity: float with get, set
            abstract receiveShadow: bool with get, set
            abstract shadow: LightShadow with get, set
            abstract shadowCameraFov: obj option with get, set
            abstract shadowCameraLeft: obj option with get, set
            abstract shadowCameraRight: obj option with get, set
            abstract shadowCameraTop: obj option with get, set
            abstract shadowCameraBottom: obj option with get, set
            abstract shadowCameraNear: obj option with get, set
            abstract shadowCameraFar: obj option with get, set
            abstract shadowBias: obj option with get, set
            abstract shadowMapWidth: obj option with get, set
            abstract shadowMapHeight: obj option with get, set

        /// Abstract base class for lights.
        type [<AllowNullLiteral>] LightStatic =
            [<Emit "new $0($1...)">] abstract Create: ?hex: U2<float, string> * ?intensity: float -> Light

        type [<AllowNullLiteral>] LightShadow =
            abstract camera: Camera with get, set
            abstract bias: float with get, set
            abstract radius: float with get, set
            abstract mapSize: Vector2 with get, set
            abstract map: RenderTarget with get, set
            abstract matrix: Matrix4 with get, set
            abstract copy: source: LightShadow -> LightShadow
            abstract clone: ?recursive: bool -> LightShadow
            abstract toJSON: unit -> obj option

        type [<AllowNullLiteral>] LightShadowStatic =
            [<Emit "new $0($1...)">] abstract Create: camera: Camera -> LightShadow

        /// This light's color gets applied to all the objects in the scene globally.
        /// 
        /// # example
        ///      var light = new THREE.AmbientLight( 0x404040 ); // soft white light
        ///      scene.add( light );
        type [<AllowNullLiteral>] AmbientLight =
            inherit Light
            abstract castShadow: bool with get, set

        /// This light's color gets applied to all the objects in the scene globally.
        /// 
        /// # example
        ///      var light = new THREE.AmbientLight( 0x404040 ); // soft white light
        ///      scene.add( light );
        type [<AllowNullLiteral>] AmbientLightStatic =
            /// <summary>This creates a Ambientlight with a color.</summary>
            /// <param name="color">Numeric value of the RGB component of the color or a Color instance.</param>
            [<Emit "new $0($1...)">] abstract Create: ?color: U3<Color, string, float> * ?intensity: float -> AmbientLight

        /// Affects objects using MeshLambertMaterial or MeshPhongMaterial.
        type [<AllowNullLiteral>] DirectionalLight =
            inherit Light
            /// Target used for shadow camera orientation.
            abstract target: Object3D with get, set
            /// Light's intensity.
            /// Default — 1.0.
            abstract intensity: float with get, set
            abstract shadow: DirectionalLightShadow with get, set

        /// Affects objects using MeshLambertMaterial or MeshPhongMaterial.
        type [<AllowNullLiteral>] DirectionalLightStatic =
            [<Emit "new $0($1...)">] abstract Create: ?color: U3<Color, string, float> * ?intensity: float -> DirectionalLight

        type [<AllowNullLiteral>] DirectionalLightShadow =
            inherit LightShadow
            abstract camera: OrthographicCamera with get, set

        type [<AllowNullLiteral>] DirectionalLightShadowStatic =
            [<Emit "new $0($1...)">] abstract Create: unit -> DirectionalLightShadow

        type [<AllowNullLiteral>] HemisphereLight =
            inherit Light
            abstract skyColor: Color with get, set
            abstract groundColor: Color with get, set
            abstract intensity: float with get, set

        type [<AllowNullLiteral>] HemisphereLightStatic =
            [<Emit "new $0($1...)">] abstract Create: ?skyColor: U3<Color, string, float> * ?groundColor: U3<Color, string, float> * ?intensity: float -> HemisphereLight

        /// Affects objects using {@link MeshLambertMaterial} or {@link MeshPhongMaterial}.
        type [<AllowNullLiteral>] PointLight =
            inherit Light
            abstract intensity: float with get, set
            /// If non-zero, light will attenuate linearly from maximum intensity at light position down to zero at distance.
            /// Default — 0.0.
            abstract distance: float with get, set
            abstract decay: float with get, set
            abstract shadow: PointLightShadow with get, set
            abstract power: float with get, set

        /// Affects objects using {@link MeshLambertMaterial} or {@link MeshPhongMaterial}.
        type [<AllowNullLiteral>] PointLightStatic =
            [<Emit "new $0($1...)">] abstract Create: ?color: U3<Color, string, float> * ?intensity: float * ?distance: float * ?decay: float -> PointLight

        type [<AllowNullLiteral>] PointLightShadow =
            inherit LightShadow
            abstract camera: PerspectiveCamera with get, set

        type [<AllowNullLiteral>] PointLightShadowStatic =
            [<Emit "new $0($1...)">] abstract Create: unit -> PointLightShadow

        /// A point light that can cast shadow in one direction.
        type [<AllowNullLiteral>] SpotLight =
            inherit Light
            /// Spotlight focus points at target.position.
            /// Default position — (0,0,0).
            abstract target: Object3D with get, set
            /// Light's intensity.
            /// Default — 1.0.
            abstract intensity: float with get, set
            /// If non-zero, light will attenuate linearly from maximum intensity at light position down to zero at distance.
            /// Default — 0.0.
            abstract distance: float with get, set
            abstract angle: float with get, set
            /// Rapidity of the falloff of light from its target direction.
            /// Default — 10.0.
            abstract exponent: float with get, set
            abstract decay: float with get, set
            abstract shadow: SpotLightShadow with get, set
            abstract power: float with get, set
            abstract penumbra: float with get, set

        /// A point light that can cast shadow in one direction.
        type [<AllowNullLiteral>] SpotLightStatic =
            [<Emit "new $0($1...)">] abstract Create: ?color: U3<Color, string, float> * ?intensity: float * ?distance: float * ?angle: float * ?exponent: float * ?decay: float -> SpotLight

        type [<AllowNullLiteral>] SpotLightShadow =
            inherit LightShadow
            abstract camera: PerspectiveCamera with get, set
            abstract update: light: Light -> unit

        type [<AllowNullLiteral>] SpotLightShadowStatic =
            [<Emit "new $0($1...)">] abstract Create: unit -> SpotLightShadow

        /// Base class for implementing loaders.
        /// 
        /// Events:
        ///      load
        ///          Dispatched when the image has completed loading
        ///          content — loaded image
        /// 
        ///      error
        /// 
        ///           Dispatched when the image can't be loaded
        ///           message — error message
        type [<AllowNullLiteral>] Loader =
            /// Will be called when load starts.
            /// The default is a function with empty body.
            abstract onLoadStart: (unit -> unit) with get, set
            /// Will be called while load progresses.
            /// The default is a function with empty body.
            abstract onLoadProgress: (unit -> unit) with get, set
            /// Will be called when load completes.
            /// The default is a function with empty body.
            abstract onLoadComplete: (unit -> unit) with get, set
            /// default — null.
            /// If set, assigns the crossOrigin attribute of the image to the value of crossOrigin, prior to starting the load.
            abstract crossOrigin: string with get, set
            abstract extractUrlBase: url: string -> string
            abstract initMaterials: materials: ResizeArray<Material> * texturePath: string -> ResizeArray<Material>
            abstract createMaterial: m: Material * texturePath: string * ?crossOrigin: string -> bool
            abstract Handlers: LoaderHandler with get, set

        /// Base class for implementing loaders.
        /// 
        /// Events:
        ///      load
        ///          Dispatched when the image has completed loading
        ///          content — loaded image
        /// 
        ///      error
        /// 
        ///           Dispatched when the image can't be loaded
        ///           message — error message
        type [<AllowNullLiteral>] LoaderStatic =
            [<Emit "new $0($1...)">] abstract Create: unit -> Loader

        /// Interface for all loaders
        /// CompressedTextureLoader don't extends Loader class, but have load method
        type [<AllowNullLiteral>] AnyLoader =
            abstract load: url: string * ?onLoad: (obj option -> unit) * ?onProgress: (ProgressEvent -> unit) * ?onError: (ErrorEvent -> unit) -> obj option

        type [<AllowNullLiteral>] LoaderHandler =
            abstract handlers: ResizeArray<U2<RegExp, AnyLoader>> with get, set
            abstract add: regex: RegExp * loader: AnyLoader -> unit
            abstract get: file: string -> AnyLoader option

        type [<AllowNullLiteral>] FileLoader =
            abstract manager: LoadingManager with get, set
            abstract mimeType: MimeType with get, set
            abstract path: string with get, set
            abstract responseType: string with get, set
            abstract withCredentials: string with get, set
            abstract load: url: string * ?onLoad: (U2<string, ArrayBuffer> -> unit) * ?onProgress: (ProgressEvent -> unit) * ?onError: (ErrorEvent -> unit) -> obj option
            abstract setMimeType: mimeType: MimeType -> FileLoader
            abstract setPath: path: string -> FileLoader
            abstract setResponseType: responseType: string -> FileLoader
            abstract setWithCredentials: value: string -> FileLoader
            abstract setRequestHeader: value: FileLoaderSetRequestHeaderValue -> FileLoader

        type [<AllowNullLiteral>] FileLoaderSetRequestHeaderValue =
            [<Emit "$0[$1]{{=$2}}">] abstract Item: header: string -> string with get, set

        type [<AllowNullLiteral>] FileLoaderStatic =
            [<Emit "new $0($1...)">] abstract Create: ?manager: LoadingManager -> FileLoader

        type [<AllowNullLiteral>] FontLoader =
            abstract manager: LoadingManager with get, set
            abstract load: url: string * ?onLoad: (Font -> unit) * ?onProgress: (ProgressEvent -> unit) * ?onError: (ErrorEvent -> unit) -> unit
            abstract parse: json: obj option -> Font

        type [<AllowNullLiteral>] FontLoaderStatic =
            [<Emit "new $0($1...)">] abstract Create: ?manager: LoadingManager -> FontLoader

        /// A loader for loading an image.
        /// Unlike other loaders, this one emits events instead of using predefined callbacks. So if you're interested in getting notified when things happen, you need to add listeners to the object.
        type [<AllowNullLiteral>] ImageLoader =
            abstract manager: LoadingManager with get, set
            abstract crossOrigin: string with get, set
            abstract withCredentials: string with get, set
            abstract path: string with get, set
            /// <summary>Begin loading from url</summary>
            /// <param name="url"></param>
            abstract load: url: string * ?onLoad: (HTMLImageElement -> unit) * ?onProgress: (ProgressEvent -> unit) * ?onError: (ErrorEvent -> unit) -> HTMLImageElement
            abstract setCrossOrigin: crossOrigin: string -> ImageLoader
            abstract setWithCredentials: value: string -> ImageLoader
            abstract setPath: value: string -> ImageLoader

        /// A loader for loading an image.
        /// Unlike other loaders, this one emits events instead of using predefined callbacks. So if you're interested in getting notified when things happen, you need to add listeners to the object.
        type [<AllowNullLiteral>] ImageLoaderStatic =
            [<Emit "new $0($1...)">] abstract Create: ?manager: LoadingManager -> ImageLoader

        /// A loader for loading objects in JSON format.
        type [<AllowNullLiteral>] JSONLoader =
            inherit Loader
            abstract manager: LoadingManager with get, set
            abstract withCredentials: bool with get, set
            abstract load: url: string * ?onLoad: (Geometry -> ResizeArray<Material> -> unit) * ?onProgress: (ProgressEvent -> unit) * ?onError: (ErrorEvent -> unit) -> unit
            abstract setTexturePath: value: string -> unit
            abstract parse: json: obj option * ?texturePath: string -> obj

        /// A loader for loading objects in JSON format.
        type [<AllowNullLiteral>] JSONLoaderStatic =
            [<Emit "new $0($1...)">] abstract Create: ?manager: LoadingManager -> JSONLoader

        /// Handles and keeps track of loaded and pending data.
        type [<AllowNullLiteral>] LoadingManager =
            abstract onStart: (string -> float -> float -> unit) option with get, set
            /// Will be called when load starts.
            /// The default is a function with empty body.
            abstract onLoad: (unit -> unit) with get, set
            /// Will be called while load progresses.
            /// The default is a function with empty body.
            abstract onProgress: (obj option -> float -> float -> unit) with get, set
            /// Will be called when each element in the scene completes loading.
            /// The default is a function with empty body.
            abstract onError: (string -> unit) with get, set
            /// <summary>If provided, the callback will be passed each resource URL before a request is sent.
            /// The callback may return the original URL, or a new URL to override loading behavior.
            /// This behavior can be used to load assets from .ZIP files, drag-and-drop APIs, and Data URIs.</summary>
            /// <param name="callback">URL modifier callback. Called with url argument, and must return resolvedURL.</param>
            abstract setURLModifier: ?callback: (string -> string) -> unit
            /// <summary>Given a URL, uses the URL modifier callback (if any) and returns a resolved URL.
            /// If no URL modifier is set, returns the original URL.</summary>
            /// <param name="url">the url to load</param>
            abstract resolveURL: url: string -> string
            abstract itemStart: url: string -> unit
            abstract itemEnd: url: string -> unit
            abstract itemError: url: string -> unit

        /// Handles and keeps track of loaded and pending data.
        type [<AllowNullLiteral>] LoadingManagerStatic =
            [<Emit "new $0($1...)">] abstract Create: ?onLoad: (unit -> unit) * ?onProgress: (string -> float -> float -> unit) * ?onError: (unit -> unit) -> LoadingManager

        type [<AllowNullLiteral>] BufferGeometryLoader =
            abstract manager: LoadingManager with get, set
            abstract load: url: string * onLoad: (BufferGeometry -> unit) * ?onProgress: (obj option -> unit) * ?onError: (obj option -> unit) -> unit
            abstract parse: json: obj option -> BufferGeometry

        type [<AllowNullLiteral>] BufferGeometryLoaderStatic =
            [<Emit "new $0($1...)">] abstract Create: ?manager: LoadingManager -> BufferGeometryLoader

        type [<AllowNullLiteral>] MaterialLoader =
            abstract manager: LoadingManager with get, set
            abstract textures: obj with get, set
            abstract load: url: string * onLoad: (Material -> unit) * ?onProgress: (ProgressEvent -> unit) * ?onError: (U2<Error, ErrorEvent> -> unit) -> unit
            abstract setTextures: textures: MaterialLoaderSetTexturesTextures -> unit
            abstract getTexture: name: string -> Texture
            abstract parse: json: obj option -> Material

        type [<AllowNullLiteral>] MaterialLoaderSetTexturesTextures =
            [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> Texture with get, set

        type [<AllowNullLiteral>] MaterialLoaderStatic =
            [<Emit "new $0($1...)">] abstract Create: ?manager: LoadingManager -> MaterialLoader

        type [<AllowNullLiteral>] ObjectLoader =
            abstract manager: LoadingManager with get, set
            abstract texturePass: string with get, set
            abstract crossOrigin: string with get, set
            abstract load: url: string * ?onLoad: (Object3D -> unit) * ?onProgress: (ProgressEvent -> unit) * ?onError: (U2<Error, ErrorEvent> -> unit) -> unit
            abstract setTexturePath: value: string -> unit
            abstract setCrossOrigin: crossOrigin: string -> unit
            abstract parse: json: obj option * ?onLoad: (Object3D -> unit) -> 'T
            abstract parseGeometries: json: obj option -> ResizeArray<obj option>
            abstract parseMaterials: json: obj option * textures: ResizeArray<Texture> -> ResizeArray<Material>
            abstract parseAnimations: json: obj option -> ResizeArray<AnimationClip>
            abstract parseImages: json: obj option * onLoad: (unit -> unit) -> obj
            abstract parseTextures: json: obj option * images: obj option -> ResizeArray<Texture>
            abstract parseObject: data: obj option * geometries: ResizeArray<obj option> * materials: ResizeArray<Material> -> 'T

        type [<AllowNullLiteral>] ObjectLoaderStatic =
            [<Emit "new $0($1...)">] abstract Create: ?manager: LoadingManager -> ObjectLoader

        /// Class for loading a texture.
        /// Unlike other loaders, this one emits events instead of using predefined callbacks. So if you're interested in getting notified when things happen, you need to add listeners to the object.
        type [<AllowNullLiteral>] TextureLoader =
            abstract manager: LoadingManager with get, set
            abstract crossOrigin: string with get, set
            abstract withCredentials: string with get, set
            abstract path: string with get, set
            /// <summary>Begin loading from url</summary>
            /// <param name="url"></param>
            abstract load: url: string * ?onLoad: (Texture -> unit) * ?onProgress: (ProgressEvent -> unit) * ?onError: (ErrorEvent -> unit) -> Texture
            abstract setCrossOrigin: crossOrigin: string -> TextureLoader
            abstract setWithCredentials: value: string -> TextureLoader
            abstract setPath: path: string -> TextureLoader

        /// Class for loading a texture.
        /// Unlike other loaders, this one emits events instead of using predefined callbacks. So if you're interested in getting notified when things happen, you need to add listeners to the object.
        type [<AllowNullLiteral>] TextureLoaderStatic =
            [<Emit "new $0($1...)">] abstract Create: ?manager: LoadingManager -> TextureLoader

        type [<AllowNullLiteral>] CubeTextureLoader =
            abstract manager: LoadingManager with get, set
            abstract crossOrigin: string with get, set
            abstract path: string option with get, set
            abstract load: urls: Array<string> * ?onLoad: (CubeTexture -> unit) * ?onProgress: (ProgressEvent -> unit) * ?onError: (ErrorEvent -> unit) -> CubeTexture
            abstract setCrossOrigin: crossOrigin: string -> CubeTextureLoader
            abstract setPath: path: string -> CubeTextureLoader

        type [<AllowNullLiteral>] CubeTextureLoaderStatic =
            [<Emit "new $0($1...)">] abstract Create: ?manager: LoadingManager -> CubeTextureLoader

        type [<AllowNullLiteral>] DataTextureLoader =
            abstract manager: LoadingManager with get, set
            abstract load: url: string * onLoad: (DataTexture -> unit) * ?onProgress: (ProgressEvent -> unit) * ?onError: (ErrorEvent -> unit) -> unit

        type [<AllowNullLiteral>] DataTextureLoaderStatic =
            [<Emit "new $0($1...)">] abstract Create: ?manager: LoadingManager -> DataTextureLoader

        type [<AllowNullLiteral>] BinaryTextureLoader =
            inherit DataTextureLoader

        type [<AllowNullLiteral>] BinaryTextureLoaderStatic =
            [<Emit "new $0($1...)">] abstract Create: unit -> BinaryTextureLoader

        type [<AllowNullLiteral>] CompressedTextureLoader =
            abstract manager: LoadingManager with get, set
            abstract path: string with get, set
            abstract load: url: string * onLoad: (CompressedTexture -> unit) * ?onProgress: (ProgressEvent -> unit) * ?onError: (ErrorEvent -> unit) -> unit
            abstract setPath: path: string -> CompressedTextureLoader

        type [<AllowNullLiteral>] CompressedTextureLoaderStatic =
            [<Emit "new $0($1...)">] abstract Create: ?manager: LoadingManager -> CompressedTextureLoader

        type [<AllowNullLiteral>] AudioLoader =
            abstract load: url: string * onLoad: Function * onPrgress: Function * onError: Function -> unit

        type [<AllowNullLiteral>] AudioLoaderStatic =
            [<Emit "new $0($1...)">] abstract Create: ?manager: LoadingManager -> AudioLoader

        module Cache =

            type [<AllowNullLiteral>] IExports =
                abstract enabled: bool
                abstract files: obj option
                abstract add: key: string * file: obj option -> unit
                abstract get: key: string -> obj option
                abstract remove: key: string -> unit
                abstract clear: unit -> unit

        type [<AllowNullLiteral>] LoaderUtils =
            interface end

        type [<AllowNullLiteral>] LoaderUtilsStatic =
            [<Emit "new $0($1...)">] abstract Create: unit -> LoaderUtils
            abstract decodeText: array: TypedArray -> string
            abstract extractUrlBase: url: string -> string

        type [<AllowNullLiteral>] MaterialParameters =
            abstract alphaTest: float option with get, set
            abstract blendDst: BlendingDstFactor option with get, set
            abstract blendDstAlpha: float option with get, set
            abstract blendEquation: BlendingEquation option with get, set
            abstract blendEquationAlpha: float option with get, set
            abstract blending: Blending option with get, set
            abstract blendSrc: U2<BlendingSrcFactor, BlendingDstFactor> option with get, set
            abstract blendSrcAlpha: float option with get, set
            abstract clipIntersection: bool option with get, set
            abstract clippingPlanes: ResizeArray<Plane> option with get, set
            abstract clipShadows: bool option with get, set
            abstract colorWrite: bool option with get, set
            abstract depthFunc: DepthModes option with get, set
            abstract depthTest: bool option with get, set
            abstract depthWrite: bool option with get, set
            abstract fog: bool option with get, set
            abstract lights: bool option with get, set
            abstract name: string option with get, set
            abstract opacity: float option with get, set
            abstract overdraw: float option with get, set
            abstract polygonOffset: bool option with get, set
            abstract polygonOffsetFactor: float option with get, set
            abstract polygonOffsetUnits: float option with get, set
            abstract precision: U3<string, string, string> option with get, set
            abstract premultipliedAlpha: bool option with get, set
            abstract dithering: bool option with get, set
            abstract flatShading: bool option with get, set
            abstract side: Side option with get, set
            abstract transparent: bool option with get, set
            abstract vertexColors: Colors option with get, set
            abstract visible: bool option with get, set

        /// Materials describe the appearance of objects. They are defined in a (mostly) renderer-independent way, so you don't have to rewrite materials if you decide to use a different renderer.
        type [<AllowNullLiteral>] Material =
            inherit EventDispatcher
            /// Sets the alpha value to be used when running an alpha test. Default is 0.
            abstract alphaTest: float with get, set
            /// Blending destination. It's one of the blending mode constants defined in Three.js. Default is {@link OneMinusSrcAlphaFactor}.
            abstract blendDst: BlendingDstFactor with get, set
            /// The tranparency of the .blendDst. Default is null.
            abstract blendDstAlpha: float option with get, set
            /// Blending equation to use when applying blending. It's one of the constants defined in Three.js. Default is {@link AddEquation}.
            abstract blendEquation: BlendingEquation with get, set
            /// The tranparency of the .blendEquation. Default is null.
            abstract blendEquationAlpha: float option with get, set
            /// Which blending to use when displaying objects with this material. Default is {@link NormalBlending}.
            abstract blending: Blending with get, set
            /// Blending source. It's one of the blending mode constants defined in Three.js. Default is {@link SrcAlphaFactor}.
            abstract blendSrc: U2<BlendingSrcFactor, BlendingDstFactor> with get, set
            /// The tranparency of the .blendSrc. Default is null.
            abstract blendSrcAlpha: float option with get, set
            /// Changes the behavior of clipping planes so that only their intersection is clipped, rather than their union. Default is false.
            abstract clipIntersection: bool with get, set
            /// User-defined clipping planes specified as THREE.Plane objects in world space. These planes apply to the objects this material is attached to. Points in space whose signed distance to the plane is negative are clipped (not rendered). See the WebGL / clipping /intersection example. Default is null.
            abstract clippingPlanes: obj option with get, set
            /// Defines whether to clip shadows according to the clipping planes specified on this material. Default is false.
            abstract clipShadows: bool with get, set
            /// Whether to render the material's color. This can be used in conjunction with a mesh's .renderOrder property to create invisible objects that occlude other objects. Default is true.
            abstract colorWrite: bool with get, set
            /// Which depth function to use. Default is {@link LessEqualDepth}. See the depth mode constants for all possible values.
            abstract depthFunc: DepthModes with get, set
            /// Whether to have depth test enabled when rendering this material. Default is true.
            abstract depthTest: bool with get, set
            /// Whether rendering this material has any effect on the depth buffer. Default is true.
            /// When drawing 2D overlays it can be useful to disable the depth writing in order to layer several things together without creating z-index artifacts.
            abstract depthWrite: bool with get, set
            /// Whether the material is affected by fog. Default is true.
            abstract fog: bool with get, set
            /// Unique number of this material instance.
            abstract id: float with get, set
            /// Used to check whether this or derived classes are materials. Default is true.
            /// You should not change this, as it used internally for optimisation.
            abstract isMaterial: bool with get, set
            /// Whether the material is affected by lights. Default is true.
            abstract lights: bool with get, set
            /// Material name. Default is an empty string.
            abstract name: string with get, set
            /// Specifies that the material needs to be updated, WebGL wise. Set it to true if you made changes that need to be reflected in WebGL.
            /// This property is automatically set to true when instancing a new material.
            abstract needsUpdate: bool with get, set
            /// Opacity. Default is 1.
            abstract opacity: float with get, set
            /// Enables/disables overdraw. If greater than zero, polygons are drawn slightly bigger in order to fix antialiasing gaps when using the CanvasRenderer. Default is 0.
            abstract overdraw: float with get, set
            /// Whether to use polygon offset. Default is false. This corresponds to the POLYGON_OFFSET_FILL WebGL feature.
            abstract polygonOffset: bool with get, set
            /// Sets the polygon offset factor. Default is 0.
            abstract polygonOffsetFactor: float with get, set
            /// Sets the polygon offset units. Default is 0.
            abstract polygonOffsetUnits: float with get, set
            /// Override the renderer's default precision for this material. Can be "highp", "mediump" or "lowp". Defaults is null.
            abstract precision: U3<string, string, string> option with get, set
            /// Whether to premultiply the alpha (transparency) value. See WebGL / Materials / Transparency for an example of the difference. Default is false.
            abstract premultipliedAlpha: bool with get, set
            /// Whether to apply dithering to the color to remove the appearance of banding. Default is false.
            abstract dithering: bool with get, set
            /// Define whether the material is rendered with flat shading. Default is false.
            abstract flatShading: bool with get, set
            /// Defines which of the face sides will be rendered - front, back or both.
            /// Default is THREE.FrontSide. Other options are THREE.BackSide and THREE.DoubleSide.
            abstract side: Side with get, set
            /// Defines whether this material is transparent. This has an effect on rendering as transparent objects need special treatment and are rendered after non-transparent objects.
            /// When set to true, the extent to which the material is transparent is controlled by setting it's .opacity property.
            /// Default is false.
            abstract transparent: bool with get, set
            /// Value is the string 'Material'. This shouldn't be changed, and can be used to find all objects of this type in a scene.
            abstract ``type``: string with get, set
            /// UUID of this material instance. This gets automatically assigned, so this shouldn't be edited.
            abstract uuid: string with get, set
            /// Defines whether vertex coloring is used. Default is THREE.NoColors. Other options are THREE.VertexColors and THREE.FaceColors.
            abstract vertexColors: Colors with get, set
            /// Defines whether this material is visible. Default is true.
            abstract visible: bool with get, set
            /// An object that can be used to store custom data about the Material. It should not hold references to functions as these will not be cloned.
            abstract userData: obj option with get, set
            /// Return a new material with the same parameters as this material.
            abstract clone: unit -> Material
            /// <summary>Copy the parameters from the passed material into this material.</summary>
            /// <param name="material"></param>
            abstract copy: material: Material -> Material
            /// This disposes the material. Textures of a material don't get disposed. These needs to be disposed by {@link Texture}.
            abstract dispose: unit -> unit
            /// <summary>Sets the properties based on the values.</summary>
            /// <param name="values">A container with parameters.</param>
            abstract setValues: values: MaterialParameters -> unit
            /// <summary>Convert the material to three.js JSON format.</summary>
            /// <param name="meta">Object containing metadata such as textures or images for the material.</param>
            abstract toJSON: ?meta: obj option -> obj option
            /// Call .dispatchEvent ( { type: 'update' }) on the material.
            abstract update: unit -> unit

        /// Materials describe the appearance of objects. They are defined in a (mostly) renderer-independent way, so you don't have to rewrite materials if you decide to use a different renderer.
        type [<AllowNullLiteral>] MaterialStatic =
            [<Emit "new $0($1...)">] abstract Create: unit -> Material

        type [<AllowNullLiteral>] LineBasicMaterialParameters =
            inherit MaterialParameters
            abstract color: U3<Color, string, float> option with get, set
            abstract linewidth: float option with get, set
            abstract linecap: string option with get, set
            abstract linejoin: string option with get, set

        type [<AllowNullLiteral>] LineBasicMaterial =
            inherit Material
            abstract color: Color with get, set
            abstract linewidth: float with get, set
            abstract linecap: string with get, set
            abstract linejoin: string with get, set
            abstract setValues: parameters: LineBasicMaterialParameters -> unit

        type [<AllowNullLiteral>] LineBasicMaterialStatic =
            [<Emit "new $0($1...)">] abstract Create: ?parameters: LineBasicMaterialParameters -> LineBasicMaterial

        type [<AllowNullLiteral>] LineDashedMaterialParameters =
            inherit MaterialParameters
            abstract color: U3<Color, string, float> option with get, set
            abstract linewidth: float option with get, set
            abstract scale: float option with get, set
            abstract dashSize: float option with get, set
            abstract gapSize: float option with get, set

        type [<AllowNullLiteral>] LineDashedMaterial =
            inherit LineBasicMaterial
            abstract scale: float with get, set
            abstract dashSize: float with get, set
            abstract gapSize: float with get, set
            abstract isLineDashedMaterial: bool with get, set
            abstract setValues: parameters: LineDashedMaterialParameters -> unit

        type [<AllowNullLiteral>] LineDashedMaterialStatic =
            [<Emit "new $0($1...)">] abstract Create: ?parameters: LineDashedMaterialParameters -> LineDashedMaterial

        /// parameters is an object with one or more properties defining the material's appearance.
        type [<AllowNullLiteral>] MeshBasicMaterialParameters =
            inherit MaterialParameters
            abstract color: U3<Color, string, float> option with get, set
            abstract opacity: float option with get, set
            abstract map: Texture option with get, set
            abstract aoMap: Texture option with get, set
            abstract aoMapIntensity: float option with get, set
            abstract specularMap: Texture option with get, set
            abstract alphaMap: Texture option with get, set
            abstract envMap: Texture option with get, set
            abstract combine: Combine option with get, set
            abstract reflectivity: float option with get, set
            abstract refractionRatio: float option with get, set
            abstract wireframe: bool option with get, set
            abstract wireframeLinewidth: float option with get, set
            abstract wireframeLinecap: string option with get, set
            abstract wireframeLinejoin: string option with get, set
            abstract skinning: bool option with get, set
            abstract morphTargets: bool option with get, set

        type [<AllowNullLiteral>] MeshBasicMaterial =
            inherit Material
            abstract color: Color with get, set
            abstract map: Texture option with get, set
            abstract aoMap: Texture option with get, set
            abstract aoMapIntensity: float with get, set
            abstract specularMap: Texture option with get, set
            abstract alphaMap: Texture option with get, set
            abstract envMap: Texture option with get, set
            abstract combine: Combine with get, set
            abstract reflectivity: float with get, set
            abstract refractionRatio: float with get, set
            abstract wireframe: bool with get, set
            abstract wireframeLinewidth: float with get, set
            abstract wireframeLinecap: string with get, set
            abstract wireframeLinejoin: string with get, set
            abstract skinning: bool with get, set
            abstract morphTargets: bool with get, set
            abstract setValues: parameters: MeshBasicMaterialParameters -> unit

        type [<AllowNullLiteral>] MeshBasicMaterialStatic =
            [<Emit "new $0($1...)">] abstract Create: ?parameters: MeshBasicMaterialParameters -> MeshBasicMaterial

        type [<AllowNullLiteral>] MeshDepthMaterialParameters =
            inherit MaterialParameters
            abstract wireframe: bool option with get, set
            abstract wireframeLinewidth: float option with get, set

        type [<AllowNullLiteral>] MeshDepthMaterial =
            inherit Material
            abstract wireframe: bool with get, set
            abstract wireframeLinewidth: float with get, set
            abstract depthPacking: DepthPackingStrategies with get, set
            abstract setValues: parameters: MeshDepthMaterialParameters -> unit

        type [<AllowNullLiteral>] MeshDepthMaterialStatic =
            [<Emit "new $0($1...)">] abstract Create: ?parameters: MeshDepthMaterialParameters -> MeshDepthMaterial

        type [<AllowNullLiteral>] MeshLambertMaterialParameters =
            inherit MaterialParameters
            abstract color: U3<Color, string, float> option with get, set
            abstract emissive: U3<Color, string, float> option with get, set
            abstract emissiveIntensity: float option with get, set
            abstract emissiveMap: Texture option with get, set
            abstract map: Texture option with get, set
            abstract lightMap: Texture option with get, set
            abstract lightMapIntensity: float option with get, set
            abstract aoMap: Texture option with get, set
            abstract aoMapIntensity: float option with get, set
            abstract specularMap: Texture option with get, set
            abstract alphaMap: Texture option with get, set
            abstract envMap: Texture option with get, set
            abstract combine: Combine option with get, set
            abstract reflectivity: float option with get, set
            abstract refractionRatio: float option with get, set
            abstract wireframe: bool option with get, set
            abstract wireframeLinewidth: float option with get, set
            abstract wireframeLinecap: string option with get, set
            abstract wireframeLinejoin: string option with get, set
            abstract skinning: bool option with get, set
            abstract morphTargets: bool option with get, set
            abstract morphNormals: bool option with get, set

        type [<AllowNullLiteral>] MeshLambertMaterial =
            inherit Material
            abstract color: Color with get, set
            abstract emissive: Color with get, set
            abstract emissiveIntensity: float with get, set
            abstract emissiveMap: Texture option with get, set
            abstract map: Texture option with get, set
            abstract lightMap: Texture option with get, set
            abstract lightMapIntensity: float with get, set
            abstract aoMap: Texture option with get, set
            abstract aoMapIntensity: float with get, set
            abstract specularMap: Texture option with get, set
            abstract alphaMap: Texture option with get, set
            abstract envMap: Texture option with get, set
            abstract combine: Combine with get, set
            abstract reflectivity: float with get, set
            abstract refractionRatio: float with get, set
            abstract wireframe: bool with get, set
            abstract wireframeLinewidth: float with get, set
            abstract wireframeLinecap: string with get, set
            abstract wireframeLinejoin: string with get, set
            abstract skinning: bool with get, set
            abstract morphTargets: bool with get, set
            abstract morphNormals: bool with get, set
            abstract setValues: parameters: MeshLambertMaterialParameters -> unit

        type [<AllowNullLiteral>] MeshLambertMaterialStatic =
            [<Emit "new $0($1...)">] abstract Create: ?parameters: MeshLambertMaterialParameters -> MeshLambertMaterial

        type [<AllowNullLiteral>] MeshStandardMaterialParameters =
            inherit MaterialParameters
            abstract color: U3<Color, string, float> option with get, set
            abstract roughness: float option with get, set
            abstract metalness: float option with get, set
            abstract map: Texture option with get, set
            abstract lightMap: Texture option with get, set
            abstract lightMapIntensity: float option with get, set
            abstract aoMap: Texture option with get, set
            abstract aoMapIntensity: float option with get, set
            abstract emissive: U3<Color, string, float> option with get, set
            abstract emissiveIntensity: float option with get, set
            abstract emissiveMap: Texture option with get, set
            abstract bumpMap: Texture option with get, set
            abstract bumpScale: float option with get, set
            abstract normalMap: Texture option with get, set
            abstract normalScale: Vector2 option with get, set
            abstract displacementMap: Texture option with get, set
            abstract displacementScale: float option with get, set
            abstract displacementBias: float option with get, set
            abstract roughnessMap: Texture option with get, set
            abstract metalnessMap: Texture option with get, set
            abstract alphaMap: Texture option with get, set
            abstract envMap: Texture option with get, set
            abstract envMapIntensity: float option with get, set
            abstract refractionRatio: float option with get, set
            abstract wireframe: bool option with get, set
            abstract wireframeLinewidth: float option with get, set
            abstract skinning: bool option with get, set
            abstract morphTargets: bool option with get, set
            abstract morphNormals: bool option with get, set

        type [<AllowNullLiteral>] MeshStandardMaterial =
            inherit Material
            abstract defines: obj option with get, set
            abstract color: Color with get, set
            abstract roughness: float with get, set
            abstract metalness: float with get, set
            abstract map: Texture option with get, set
            abstract lightMap: Texture option with get, set
            abstract lightMapIntensity: float with get, set
            abstract aoMap: Texture option with get, set
            abstract aoMapIntensity: float with get, set
            abstract emissive: Color with get, set
            abstract emissiveIntensity: float with get, set
            abstract emissiveMap: Texture option with get, set
            abstract bumpMap: Texture option with get, set
            abstract bumpScale: float with get, set
            abstract normalMap: Texture option with get, set
            abstract normalScale: float with get, set
            abstract displacementMap: Texture option with get, set
            abstract displacementScale: float with get, set
            abstract displacementBias: float with get, set
            abstract roughnessMap: Texture option with get, set
            abstract metalnessMap: Texture option with get, set
            abstract alphaMap: Texture option with get, set
            abstract envMap: Texture option with get, set
            abstract envMapIntensity: float with get, set
            abstract refractionRatio: float with get, set
            abstract wireframe: bool with get, set
            abstract wireframeLinewidth: float with get, set
            abstract skinning: bool with get, set
            abstract morphTargets: bool with get, set
            abstract morphNormals: bool with get, set
            abstract setValues: parameters: MeshStandardMaterialParameters -> unit

        type [<AllowNullLiteral>] MeshStandardMaterialStatic =
            [<Emit "new $0($1...)">] abstract Create: ?parameters: MeshStandardMaterialParameters -> MeshStandardMaterial

        type [<AllowNullLiteral>] MeshNormalMaterialParameters =
            inherit MaterialParameters
            /// Render geometry as wireframe. Default is false (i.e. render as smooth shaded). 
            abstract wireframe: bool option with get, set
            /// Controls wireframe thickness. Default is 1. 
            abstract wireframeLinewidth: float option with get, set
            abstract morphTargets: bool option with get, set

        type [<AllowNullLiteral>] MeshNormalMaterial =
            inherit Material
            abstract wireframe: bool with get, set
            abstract wireframeLinewidth: float with get, set
            abstract morphTargets: bool with get, set
            abstract setValues: parameters: MeshNormalMaterialParameters -> unit

        type [<AllowNullLiteral>] MeshNormalMaterialStatic =
            [<Emit "new $0($1...)">] abstract Create: ?parameters: MeshNormalMaterialParameters -> MeshNormalMaterial

        type [<AllowNullLiteral>] MeshPhongMaterialParameters =
            inherit MaterialParameters
            /// geometry color in hexadecimal. Default is 0xffffff. 
            abstract color: U3<Color, string, float> option with get, set
            abstract specular: U3<Color, string, float> option with get, set
            abstract shininess: float option with get, set
            abstract opacity: float option with get, set
            abstract map: Texture option with get, set
            abstract lightMap: Texture option with get, set
            abstract lightMapIntensity: float option with get, set
            abstract aoMap: Texture option with get, set
            abstract aoMapIntensity: float option with get, set
            abstract emissive: U3<Color, string, float> option with get, set
            abstract emissiveIntensity: float option with get, set
            abstract emissiveMap: Texture option with get, set
            abstract bumpMap: Texture option with get, set
            abstract bumpScale: float option with get, set
            abstract normalMap: Texture option with get, set
            abstract normalScale: Vector2 option with get, set
            abstract displacementMap: Texture option with get, set
            abstract displacementScale: float option with get, set
            abstract displacementBias: float option with get, set
            abstract specularMap: Texture option with get, set
            abstract alphaMap: Texture option with get, set
            abstract envMap: Texture option with get, set
            abstract combine: Combine option with get, set
            abstract reflectivity: float option with get, set
            abstract refractionRatio: float option with get, set
            abstract wireframe: bool option with get, set
            abstract wireframeLinewidth: float option with get, set
            abstract wireframeLinecap: string option with get, set
            abstract wireframeLinejoin: string option with get, set
            abstract skinning: bool option with get, set
            abstract morphTargets: bool option with get, set
            abstract morphNormals: bool option with get, set

        type [<AllowNullLiteral>] MeshPhongMaterial =
            inherit Material
            abstract color: Color with get, set
            abstract specular: Color with get, set
            abstract shininess: float with get, set
            abstract map: Texture option with get, set
            abstract lightMap: Texture option with get, set
            abstract lightMapIntensity: float with get, set
            abstract aoMap: Texture option with get, set
            abstract aoMapIntensity: float with get, set
            abstract emissive: Color with get, set
            abstract emissiveIntensity: float with get, set
            abstract emissiveMap: Texture option with get, set
            abstract bumpMap: Texture option with get, set
            abstract bumpScale: float with get, set
            abstract normalMap: Texture option with get, set
            abstract normalScale: Vector2 with get, set
            abstract displacementMap: Texture option with get, set
            abstract displacementScale: float with get, set
            abstract displacementBias: float with get, set
            abstract specularMap: Texture option with get, set
            abstract alphaMap: Texture option with get, set
            abstract envMap: Texture option with get, set
            abstract combine: Combine with get, set
            abstract reflectivity: float with get, set
            abstract refractionRatio: float with get, set
            abstract wireframe: bool with get, set
            abstract wireframeLinewidth: float with get, set
            abstract wireframeLinecap: string with get, set
            abstract wireframeLinejoin: string with get, set
            abstract skinning: bool with get, set
            abstract morphTargets: bool with get, set
            abstract morphNormals: bool with get, set
            abstract metal: bool with get, set
            abstract setValues: parameters: MeshPhongMaterialParameters -> unit

        type [<AllowNullLiteral>] MeshPhongMaterialStatic =
            [<Emit "new $0($1...)">] abstract Create: ?parameters: MeshPhongMaterialParameters -> MeshPhongMaterial

        type [<AllowNullLiteral>] MeshPhysicalMaterialParameters =
            inherit MeshStandardMaterialParameters
            abstract reflectivity: float option with get, set
            abstract clearCoat: float option with get, set
            abstract clearCoatRoughness: float option with get, set

        type [<AllowNullLiteral>] MeshPhysicalMaterial =
            inherit MeshStandardMaterial
            abstract defines: obj option with get, set
            abstract reflectivity: float with get, set
            abstract clearCoat: float with get, set
            abstract clearCoatRoughness: float with get, set

        type [<AllowNullLiteral>] MeshPhysicalMaterialStatic =
            [<Emit "new $0($1...)">] abstract Create: parameters: MeshPhysicalMaterialParameters -> MeshPhysicalMaterial

        type [<AllowNullLiteral>] MultiMaterial =
            inherit Material
            abstract isMultiMaterial: obj with get, set
            abstract materials: ResizeArray<Material> with get, set
            abstract toJSON: meta: obj option -> obj option

        type [<AllowNullLiteral>] MultiMaterialStatic =
            [<Emit "new $0($1...)">] abstract Create: ?materials: ResizeArray<Material> -> MultiMaterial

        type [<AllowNullLiteral>] MeshFaceMaterial =
            inherit MultiMaterial

        type [<AllowNullLiteral>] MeshFaceMaterialStatic =
            [<Emit "new $0($1...)">] abstract Create: unit -> MeshFaceMaterial

        type [<AllowNullLiteral>] PointsMaterialParameters =
            inherit MaterialParameters
            abstract color: U3<Color, string, float> option with get, set
            abstract map: Texture option with get, set
            abstract size: float option with get, set
            abstract sizeAttenuation: bool option with get, set

        type [<AllowNullLiteral>] PointsMaterial =
            inherit Material
            abstract color: Color with get, set
            abstract map: Texture option with get, set
            abstract size: float with get, set
            abstract sizeAttenuation: bool with get, set
            abstract setValues: parameters: PointsMaterialParameters -> unit

        type [<AllowNullLiteral>] PointsMaterialStatic =
            [<Emit "new $0($1...)">] abstract Create: ?parameters: PointsMaterialParameters -> PointsMaterial

        type [<AllowNullLiteral>] PointCloudMaterial =
            inherit PointsMaterial

        type [<AllowNullLiteral>] PointCloudMaterialStatic =
            [<Emit "new $0($1...)">] abstract Create: unit -> PointCloudMaterial

        type [<AllowNullLiteral>] ParticleBasicMaterial =
            inherit PointsMaterial

        type [<AllowNullLiteral>] ParticleBasicMaterialStatic =
            [<Emit "new $0($1...)">] abstract Create: unit -> ParticleBasicMaterial

        type [<AllowNullLiteral>] ParticleSystemMaterial =
            inherit PointsMaterial

        type [<AllowNullLiteral>] ParticleSystemMaterialStatic =
            [<Emit "new $0($1...)">] abstract Create: unit -> ParticleSystemMaterial

        type [<AllowNullLiteral>] ShaderMaterialParameters =
            inherit MaterialParameters
            abstract defines: obj option with get, set
            abstract uniforms: obj option with get, set
            abstract vertexShader: string option with get, set
            abstract fragmentShader: string option with get, set
            abstract lineWidth: float option with get, set
            abstract wireframe: bool option with get, set
            abstract wireframeLinewidth: float option with get, set
            abstract lights: bool option with get, set
            abstract clipping: bool option with get, set
            abstract skinning: bool option with get, set
            abstract morphTargets: bool option with get, set
            abstract morphNormals: bool option with get, set

        type [<AllowNullLiteral>] ShaderMaterial =
            inherit Material
            abstract defines: obj option with get, set
            abstract uniforms: obj with get, set
            abstract vertexShader: string with get, set
            abstract fragmentShader: string with get, set
            abstract linewidth: float with get, set
            abstract wireframe: bool with get, set
            abstract wireframeLinewidth: float with get, set
            abstract lights: bool with get, set
            abstract clipping: bool with get, set
            abstract skinning: bool with get, set
            abstract morphTargets: bool with get, set
            abstract morphNormals: bool with get, set
            abstract derivatives: obj option with get, set
            abstract extensions: obj with get, set
            abstract defaultAttributeValues: obj option with get, set
            abstract index0AttributeName: string option with get, set
            abstract setValues: parameters: ShaderMaterialParameters -> unit
            abstract toJSON: meta: obj option -> obj option

        type [<AllowNullLiteral>] ShaderMaterialStatic =
            [<Emit "new $0($1...)">] abstract Create: ?parameters: ShaderMaterialParameters -> ShaderMaterial

        type [<AllowNullLiteral>] RawShaderMaterial =
            inherit ShaderMaterial

        type [<AllowNullLiteral>] RawShaderMaterialStatic =
            [<Emit "new $0($1...)">] abstract Create: ?parameters: ShaderMaterialParameters -> RawShaderMaterial

        type [<AllowNullLiteral>] SpriteMaterialParameters =
            inherit MaterialParameters
            abstract color: U3<Color, string, float> option with get, set
            abstract map: Texture option with get, set
            abstract rotation: float option with get, set

        type [<AllowNullLiteral>] SpriteMaterial =
            inherit Material
            abstract color: Color with get, set
            abstract map: Texture option with get, set
            abstract rotation: float with get, set
            abstract setValues: parameters: SpriteMaterialParameters -> unit

        type [<AllowNullLiteral>] SpriteMaterialStatic =
            [<Emit "new $0($1...)">] abstract Create: ?parameters: SpriteMaterialParameters -> SpriteMaterial

        type [<AllowNullLiteral>] ShadowMaterial =
            inherit ShaderMaterial

        type [<AllowNullLiteral>] ShadowMaterialStatic =
            [<Emit "new $0($1...)">] abstract Create: ?parameters: ShaderMaterialParameters -> ShadowMaterial

        type [<AllowNullLiteral>] Box2 =
            abstract max: Vector2 with get, set
            abstract min: Vector2 with get, set
            abstract set: min: Vector2 * max: Vector2 -> Box2
            abstract setFromPoints: points: ResizeArray<Vector2> -> Box2
            abstract setFromCenterAndSize: center: Vector2 * size: Vector2 -> Box2
            abstract clone: unit -> Box2
            abstract copy: box: Box2 -> Box2
            abstract makeEmpty: unit -> Box2
            abstract isEmpty: unit -> bool
            abstract getCenter: target: Vector2 -> Vector2
            abstract getSize: target: Vector2 -> Vector2
            abstract expandByPoint: point: Vector2 -> Box2
            abstract expandByVector: vector: Vector2 -> Box2
            abstract expandByScalar: scalar: float -> Box2
            abstract containsPoint: point: Vector2 -> bool
            abstract containsBox: box: Box2 -> bool
            abstract getParameter: point: Vector2 -> Vector2
            abstract intersectsBox: box: Box2 -> bool
            abstract clampPoint: point: Vector2 * target: Vector2 -> Vector2
            abstract distanceToPoint: point: Vector2 -> float
            abstract intersect: box: Box2 -> Box2
            abstract union: box: Box2 -> Box2
            abstract translate: offset: Vector2 -> Box2
            abstract equals: box: Box2 -> bool
            abstract empty: unit -> obj option
            abstract isIntersectionBox: b: obj option -> obj option

        type [<AllowNullLiteral>] Box2Static =
            [<Emit "new $0($1...)">] abstract Create: ?min: Vector2 * ?max: Vector2 -> Box2

        type [<AllowNullLiteral>] Box3 =
            abstract max: Vector3 with get, set
            abstract min: Vector3 with get, set
            abstract set: min: Vector3 * max: Vector3 -> Box3
            abstract setFromArray: array: ArrayLike<float> -> Box3
            abstract setFromPoints: points: ResizeArray<Vector3> -> Box3
            abstract setFromCenterAndSize: center: Vector3 * size: Vector3 -> Box3
            abstract setFromObject: ``object``: Object3D -> Box3
            abstract clone: unit -> Box3
            abstract copy: box: Box3 -> Box3
            abstract makeEmpty: unit -> Box3
            abstract isEmpty: unit -> bool
            abstract getCenter: target: Vector3 -> Vector3
            abstract getSize: target: Vector3 -> Vector3
            abstract expandByPoint: point: Vector3 -> Box3
            abstract expandByVector: vector: Vector3 -> Box3
            abstract expandByScalar: scalar: float -> Box3
            abstract expandByObject: ``object``: Object3D -> Box3
            abstract containsPoint: point: Vector3 -> bool
            abstract containsBox: box: Box3 -> bool
            abstract getParameter: point: Vector3 -> Vector3
            abstract intersectsBox: box: Box3 -> bool
            abstract intersectsSphere: sphere: Sphere -> bool
            abstract intersectsPlane: plane: Plane -> bool
            abstract clampPoint: point: Vector3 * target: Vector3 -> Vector3
            abstract distanceToPoint: point: Vector3 -> float
            abstract getBoundingSphere: target: Sphere -> Sphere
            abstract intersect: box: Box3 -> Box3
            abstract union: box: Box3 -> Box3
            abstract applyMatrix4: matrix: Matrix4 -> Box3
            abstract translate: offset: Vector3 -> Box3
            abstract equals: box: Box3 -> bool
            abstract empty: unit -> obj option
            abstract isIntersectionBox: b: obj option -> obj option
            abstract isIntersectionSphere: s: obj option -> obj option

        type [<AllowNullLiteral>] Box3Static =
            [<Emit "new $0($1...)">] abstract Create: ?min: Vector3 * ?max: Vector3 -> Box3

        type [<AllowNullLiteral>] HSL =
            abstract h: float with get, set
            abstract s: float with get, set
            abstract l: float with get, set

        /// Represents a color. See also {@link ColorUtils}.
        type [<AllowNullLiteral>] Color =
            /// Red channel value between 0 and 1. Default is 1.
            abstract r: float with get, set
            /// Green channel value between 0 and 1. Default is 1.
            abstract g: float with get, set
            /// Blue channel value between 0 and 1. Default is 1.
            abstract b: float with get, set
            abstract set: color: Color -> Color
            abstract set: color: float -> Color
            abstract set: color: string -> Color
            abstract setScalar: scalar: float -> Color
            abstract setHex: hex: float -> Color
            /// <summary>Sets this color from RGB values.</summary>
            /// <param name="r">Red channel value between 0 and 1.</param>
            /// <param name="g">Green channel value between 0 and 1.</param>
            /// <param name="b">Blue channel value between 0 and 1.</param>
            abstract setRGB: r: float * g: float * b: float -> Color
            /// <summary>Sets this color from HSL values.
            /// Based on MochiKit implementation by Bob Ippolito.</summary>
            /// <param name="h">Hue channel value between 0 and 1.</param>
            /// <param name="s">Saturation value channel between 0 and 1.</param>
            /// <param name="l">Value channel value between 0 and 1.</param>
            abstract setHSL: h: float * s: float * l: float -> Color
            /// Sets this color from a CSS context style string.
            abstract setStyle: style: string -> Color
            /// Clones this color.
            abstract clone: unit -> Color
            /// <summary>Copies given color.</summary>
            /// <param name="color">Color to copy.</param>
            abstract copy: color: Color -> Color
            /// <summary>Copies given color making conversion from gamma to linear space.</summary>
            /// <param name="color">Color to copy.</param>
            abstract copyGammaToLinear: color: Color * ?gammaFactor: float -> Color
            /// <summary>Copies given color making conversion from linear to gamma space.</summary>
            /// <param name="color">Color to copy.</param>
            abstract copyLinearToGamma: color: Color * ?gammaFactor: float -> Color
            /// Converts this color from gamma to linear space.
            abstract convertGammaToLinear: unit -> Color
            /// Converts this color from linear to gamma space.
            abstract convertLinearToGamma: unit -> Color
            /// Returns the hexadecimal value of this color.
            abstract getHex: unit -> float
            /// Returns the string formated hexadecimal value of this color.
            abstract getHexString: unit -> string
            abstract getHSL: target: HSL -> HSL
            /// Returns the value of this color in CSS context style.
            /// Example: rgb(r, g, b)
            abstract getStyle: unit -> string
            abstract offsetHSL: h: float * s: float * l: float -> Color
            abstract add: color: Color -> Color
            abstract addColors: color1: Color * color2: Color -> Color
            abstract addScalar: s: float -> Color
            abstract sub: color: Color -> Color
            abstract multiply: color: Color -> Color
            abstract multiplyScalar: s: float -> Color
            abstract lerp: color: Color * alpha: float -> Color
            abstract lerpHSL: color: Color * alpha: float -> Color
            abstract equals: color: Color -> bool
            abstract fromArray: rgb: ResizeArray<float> * ?offset: float -> Color
            abstract toArray: ?array: ResizeArray<float> * ?offset: float -> ResizeArray<float>

        /// Represents a color. See also {@link ColorUtils}.
        type [<AllowNullLiteral>] ColorStatic =
            [<Emit "new $0($1...)">] abstract Create: ?color: U3<Color, string, float> -> Color
            [<Emit "new $0($1...)">] abstract Create: r: float * g: float * b: float -> Color

        module ColorKeywords =

            type [<AllowNullLiteral>] IExports =
                abstract aliceblue: float
                abstract antiquewhite: float
                abstract aqua: float
                abstract aquamarine: float
                abstract azure: float
                abstract beige: float
                abstract bisque: float
                abstract black: float
                abstract blanchedalmond: float
                abstract blue: float
                abstract blueviolet: float
                abstract brown: float
                abstract burlywood: float
                abstract cadetblue: float
                abstract chartreuse: float
                abstract chocolate: float
                abstract coral: float
                abstract cornflowerblue: float
                abstract cornsilk: float
                abstract crimson: float
                abstract cyan: float
                abstract darkblue: float
                abstract darkcyan: float
                abstract darkgoldenrod: float
                abstract darkgray: float
                abstract darkgreen: float
                abstract darkgrey: float
                abstract darkkhaki: float
                abstract darkmagenta: float
                abstract darkolivegreen: float
                abstract darkorange: float
                abstract darkorchid: float
                abstract darkred: float
                abstract darksalmon: float
                abstract darkseagreen: float
                abstract darkslateblue: float
                abstract darkslategray: float
                abstract darkslategrey: float
                abstract darkturquoise: float
                abstract darkviolet: float
                abstract deeppink: float
                abstract deepskyblue: float
                abstract dimgray: float
                abstract dimgrey: float
                abstract dodgerblue: float
                abstract firebrick: float
                abstract floralwhite: float
                abstract forestgreen: float
                abstract fuchsia: float
                abstract gainsboro: float
                abstract ghostwhite: float
                abstract gold: float
                abstract goldenrod: float
                abstract gray: float
                abstract green: float
                abstract greenyellow: float
                abstract grey: float
                abstract honeydew: float
                abstract hotpink: float
                abstract indianred: float
                abstract indigo: float
                abstract ivory: float
                abstract khaki: float
                abstract lavender: float
                abstract lavenderblush: float
                abstract lawngreen: float
                abstract lemonchiffon: float
                abstract lightblue: float
                abstract lightcoral: float
                abstract lightcyan: float
                abstract lightgoldenrodyellow: float
                abstract lightgray: float
                abstract lightgreen: float
                abstract lightgrey: float
                abstract lightpink: float
                abstract lightsalmon: float
                abstract lightseagreen: float
                abstract lightskyblue: float
                abstract lightslategray: float
                abstract lightslategrey: float
                abstract lightsteelblue: float
                abstract lightyellow: float
                abstract lime: float
                abstract limegreen: float
                abstract linen: float
                abstract magenta: float
                abstract maroon: float
                abstract mediumaquamarine: float
                abstract mediumblue: float
                abstract mediumorchid: float
                abstract mediumpurple: float
                abstract mediumseagreen: float
                abstract mediumslateblue: float
                abstract mediumspringgreen: float
                abstract mediumturquoise: float
                abstract mediumvioletred: float
                abstract midnightblue: float
                abstract mintcream: float
                abstract mistyrose: float
                abstract moccasin: float
                abstract navajowhite: float
                abstract navy: float
                abstract oldlace: float
                abstract olive: float
                abstract olivedrab: float
                abstract orange: float
                abstract orangered: float
                abstract orchid: float
                abstract palegoldenrod: float
                abstract palegreen: float
                abstract paleturquoise: float
                abstract palevioletred: float
                abstract papayawhip: float
                abstract peachpuff: float
                abstract peru: float
                abstract pink: float
                abstract plum: float
                abstract powderblue: float
                abstract purple: float
                abstract red: float
                abstract rosybrown: float
                abstract royalblue: float
                abstract saddlebrown: float
                abstract salmon: float
                abstract sandybrown: float
                abstract seagreen: float
                abstract seashell: float
                abstract sienna: float
                abstract silver: float
                abstract skyblue: float
                abstract slateblue: float
                abstract slategray: float
                abstract slategrey: float
                abstract snow: float
                abstract springgreen: float
                abstract steelblue: float
                abstract tan: float
                abstract teal: float
                abstract thistle: float
                abstract tomato: float
                abstract turquoise: float
                abstract violet: float
                abstract wheat: float
                abstract white: float
                abstract whitesmoke: float
                abstract yellow: float
                abstract yellowgreen: float

        type [<AllowNullLiteral>] Euler =
            abstract x: float with get, set
            abstract y: float with get, set
            abstract z: float with get, set
            abstract order: string with get, set
            abstract onChangeCallback: Function with get, set
            abstract set: x: float * y: float * z: float * ?order: string -> Euler
            abstract clone: unit -> Euler
            abstract copy: euler: Euler -> Euler
            abstract setFromRotationMatrix: m: Matrix4 * ?order: string * ?update: bool -> Euler
            abstract setFromQuaternion: q: Quaternion * ?order: string * ?update: bool -> Euler
            abstract setFromVector3: v: Vector3 * ?order: string -> Euler
            abstract reorder: newOrder: string -> Euler
            abstract equals: euler: Euler -> bool
            abstract fromArray: xyzo: ResizeArray<obj option> -> Euler
            abstract toArray: ?array: ResizeArray<float> * ?offset: float -> ResizeArray<float>
            abstract toVector3: ?optionalResult: Vector3 -> Vector3
            abstract onChange: callback: Function -> unit
            abstract RotationOrders: ResizeArray<string> with get, set
            abstract DefaultOrder: string with get, set

        type [<AllowNullLiteral>] EulerStatic =
            [<Emit "new $0($1...)">] abstract Create: ?x: float * ?y: float * ?z: float * ?order: string -> Euler

        /// Frustums are used to determine what is inside the camera's field of view. They help speed up the rendering process.
        type [<AllowNullLiteral>] Frustum =
            /// Array of 6 vectors.
            abstract planes: ResizeArray<Plane> with get, set
            abstract set: ?p0: float * ?p1: float * ?p2: float * ?p3: float * ?p4: float * ?p5: float -> Frustum
            abstract clone: unit -> Frustum
            abstract copy: frustum: Frustum -> Frustum
            abstract setFromMatrix: m: Matrix4 -> Frustum
            abstract intersectsObject: ``object``: Object3D -> bool
            abstract intersectsObject: sprite: Sprite -> bool
            abstract intersectsSphere: sphere: Sphere -> bool
            abstract intersectsBox: box: Box3 -> bool
            abstract containsPoint: point: Vector3 -> bool

        /// Frustums are used to determine what is inside the camera's field of view. They help speed up the rendering process.
        type [<AllowNullLiteral>] FrustumStatic =
            [<Emit "new $0($1...)">] abstract Create: ?p0: Plane * ?p1: Plane * ?p2: Plane * ?p3: Plane * ?p4: Plane * ?p5: Plane -> Frustum

        type [<AllowNullLiteral>] Line3 =
            abstract start: Vector3 with get, set
            abstract ``end``: Vector3 with get, set
            abstract set: ?start: Vector3 * ?``end``: Vector3 -> Line3
            abstract clone: unit -> Line3
            abstract copy: line: Line3 -> Line3
            abstract getCenter: target: Vector3 -> Vector3
            abstract delta: target: Vector3 -> Vector3
            abstract distanceSq: unit -> float
            abstract distance: unit -> float
            abstract at: t: float * target: Vector3 -> Vector3
            abstract closestPointToPointParameter: point: Vector3 * ?clampToLine: bool -> float
            abstract closestPointToPoint: point: Vector3 * clampToLine: bool * target: Vector3 -> Vector3
            abstract applyMatrix4: matrix: Matrix4 -> Line3
            abstract equals: line: Line3 -> bool

        type [<AllowNullLiteral>] Line3Static =
            [<Emit "new $0($1...)">] abstract Create: ?start: Vector3 * ?``end``: Vector3 -> Line3

        module Math =

            type [<AllowNullLiteral>] IExports =
                abstract DEG2RAD: float
                abstract RAD2DEG: float
                abstract generateUUID: unit -> string
                /// <summary>Clamps the x to be between a and b.</summary>
                /// <param name="value">Value to be clamped.</param>
                /// <param name="min">Minimum value</param>
                /// <param name="max">Maximum value.</param>
                abstract clamp: value: float * min: float * max: float -> float
                abstract euclideanModulo: n: float * m: float -> float
                /// <summary>Linear mapping of x from range [a1, a2] to range [b1, b2].</summary>
                /// <param name="x">Value to be mapped.</param>
                /// <param name="a1">Minimum value for range A.</param>
                /// <param name="a2">Maximum value for range A.</param>
                /// <param name="b1">Minimum value for range B.</param>
                /// <param name="b2">Maximum value for range B.</param>
                abstract mapLinear: x: float * a1: float * a2: float * b1: float * b2: float -> float
                abstract smoothstep: x: float * min: float * max: float -> float
                abstract smootherstep: x: float * min: float * max: float -> float
                /// Random float from 0 to 1 with 16 bits of randomness.
                /// Standard Math.random() creates repetitive patterns when applied over larger space.
                abstract random16: unit -> float
                /// Random integer from low to high interval.
                abstract randInt: low: float * high: float -> float
                /// Random float from low to high interval.
                abstract randFloat: low: float * high: float -> float
                /// Random float from - range / 2 to range / 2 interval.
                abstract randFloatSpread: range: float -> float
                abstract degToRad: degrees: float -> float
                abstract radToDeg: radians: float -> float
                abstract isPowerOfTwo: value: float -> bool
                /// <summary>Returns a value linearly interpolated from two known points based
                /// on the given interval - t = 0 will return x and t = 1 will return y.</summary>
                /// <param name="x">Start point.</param>
                /// <param name="y">End point.</param>
                /// <param name="t">interpolation factor in the closed interval [0, 1]</param>
                abstract lerp: x: float * y: float * t: float -> float
                abstract nearestPowerOfTwo: value: float -> float
                abstract nextPowerOfTwo: value: float -> float
                abstract floorPowerOfTwo: value: float -> float
                abstract ceilPowerOfTwo: value: float -> float

        /// ( interface Matrix&lt;T&gt; )
        type [<AllowNullLiteral>] Matrix =
            /// Float32Array with matrix values.
            abstract elements: Float32Array with get, set
            /// identity():T;
            abstract identity: unit -> Matrix
            /// copy(m:T):T;
            abstract copy: m: Matrix -> Matrix
            /// multiplyScalar(s:number):T;
            abstract multiplyScalar: s: float -> Matrix
            abstract determinant: unit -> float
            /// getInverse(matrix:T, throwOnInvertible?:boolean):T;
            abstract getInverse: matrix: Matrix * ?throwOnInvertible: bool -> Matrix
            /// transpose():T;
            abstract transpose: unit -> Matrix
            /// clone():T;
            abstract clone: unit -> Matrix

        /// ( class Matrix3 implements Matrix&lt;Matrix3&gt; )
        type [<AllowNullLiteral>] Matrix3 =
            inherit Matrix
            /// Float32Array with matrix values.
            abstract elements: Float32Array with get, set
            abstract set: n11: float * n12: float * n13: float * n21: float * n22: float * n23: float * n31: float * n32: float * n33: float -> Matrix3
            abstract identity: unit -> Matrix3
            abstract clone: unit -> Matrix3
            abstract copy: m: Matrix3 -> Matrix3
            abstract setFromMatrix4: m: Matrix4 -> Matrix3
            abstract applyToBuffer: buffer: BufferAttribute * ?offset: float * ?length: float -> BufferAttribute
            abstract applyToBufferAttribute: attribute: BufferAttribute -> BufferAttribute
            abstract multiplyScalar: s: float -> Matrix3
            abstract determinant: unit -> float
            abstract getInverse: matrix: Matrix3 * ?throwOnDegenerate: bool -> Matrix3
            /// Transposes this matrix in place.
            abstract transpose: unit -> Matrix3
            abstract getNormalMatrix: matrix4: Matrix4 -> Matrix3
            /// Transposes this matrix into the supplied array r, and returns itself.
            abstract transposeIntoArray: r: ResizeArray<float> -> ResizeArray<float>
            abstract fromArray: array: ResizeArray<float> * ?offset: float -> Matrix3
            abstract toArray: unit -> ResizeArray<float>
            /// Multiplies this matrix by m.
            abstract multiply: m: Matrix3 -> Matrix3
            abstract premultiply: m: Matrix3 -> Matrix3
            /// Sets this matrix to a x b.
            abstract multiplyMatrices: a: Matrix3 * b: Matrix3 -> Matrix3
            abstract multiplyVector3: vector: Vector3 -> obj option
            abstract multiplyVector3Array: a: obj option -> obj option
            abstract getInverse: matrix: Matrix4 * ?throwOnDegenerate: bool -> Matrix3
            abstract flattenToArrayOffset: array: ResizeArray<float> * offset: float -> ResizeArray<float>

        /// ( class Matrix3 implements Matrix&lt;Matrix3&gt; )
        type [<AllowNullLiteral>] Matrix3Static =
            /// Creates an identity matrix.
            [<Emit "new $0($1...)">] abstract Create: unit -> Matrix3

        /// A 4x4 Matrix.
        type [<AllowNullLiteral>] Matrix4 =
            inherit Matrix
            /// Float32Array with matrix values.
            abstract elements: Float32Array with get, set
            /// Sets all fields of this matrix.
            abstract set: n11: float * n12: float * n13: float * n14: float * n21: float * n22: float * n23: float * n24: float * n31: float * n32: float * n33: float * n34: float * n41: float * n42: float * n43: float * n44: float -> Matrix4
            /// Resets this matrix to identity.
            abstract identity: unit -> Matrix4
            abstract clone: unit -> Matrix4
            abstract copy: m: Matrix4 -> Matrix4
            abstract copyPosition: m: Matrix4 -> Matrix4
            abstract extractBasis: xAxis: Vector3 * yAxis: Vector3 * zAxis: Vector3 -> Matrix4
            abstract makeBasis: xAxis: Vector3 * yAxis: Vector3 * zAxis: Vector3 -> Matrix4
            /// Copies the rotation component of the supplied matrix m into this matrix rotation component.
            abstract extractRotation: m: Matrix4 -> Matrix4
            abstract makeRotationFromEuler: euler: Euler -> Matrix4
            abstract makeRotationFromQuaternion: q: Quaternion -> Matrix4
            /// Constructs a rotation matrix, looking from eye towards center with defined up vector.
            abstract lookAt: eye: Vector3 * target: Vector3 * up: Vector3 -> Matrix4
            /// Multiplies this matrix by m.
            abstract multiply: m: Matrix4 -> Matrix4
            abstract premultiply: m: Matrix4 -> Matrix4
            /// Sets this matrix to a x b.
            abstract multiplyMatrices: a: Matrix4 * b: Matrix4 -> Matrix4
            /// Sets this matrix to a x b and stores the result into the flat array r.
            /// r can be either a regular Array or a TypedArray.
            abstract multiplyToArray: a: Matrix4 * b: Matrix4 * r: ResizeArray<float> -> Matrix4
            /// Multiplies this matrix by s.
            abstract multiplyScalar: s: float -> Matrix4
            abstract applyToBuffer: buffer: BufferAttribute * ?offset: float * ?length: float -> BufferAttribute
            abstract applyToBufferAttribute: attribute: BufferAttribute -> BufferAttribute
            /// Computes determinant of this matrix.
            /// Based on http://www.euclideanspace.com/maths/algebra/matrix/functions/inverse/fourD/index.htm
            abstract determinant: unit -> float
            /// Transposes this matrix.
            abstract transpose: unit -> Matrix4
            /// Sets the position component for this matrix from vector v.
            abstract setPosition: v: Vector3 -> Matrix4
            /// Sets this matrix to the inverse of matrix m.
            /// Based on http://www.euclideanspace.com/maths/algebra/matrix/functions/inverse/fourD/index.htm.
            abstract getInverse: m: Matrix4 * ?throwOnDegeneratee: bool -> Matrix4
            /// Multiplies the columns of this matrix by vector v.
            abstract scale: v: Vector3 -> Matrix4
            abstract getMaxScaleOnAxis: unit -> float
            /// Sets this matrix as translation transform.
            abstract makeTranslation: x: float * y: float * z: float -> Matrix4
            /// <summary>Sets this matrix as rotation transform around x axis by theta radians.</summary>
            /// <param name="theta">Rotation angle in radians.</param>
            abstract makeRotationX: theta: float -> Matrix4
            /// <summary>Sets this matrix as rotation transform around y axis by theta radians.</summary>
            /// <param name="theta">Rotation angle in radians.</param>
            abstract makeRotationY: theta: float -> Matrix4
            /// <summary>Sets this matrix as rotation transform around z axis by theta radians.</summary>
            /// <param name="theta">Rotation angle in radians.</param>
            abstract makeRotationZ: theta: float -> Matrix4
            /// <summary>Sets this matrix as rotation transform around axis by angle radians.
            /// Based on http://www.gamedev.net/reference/articles/article1199.asp.</summary>
            /// <param name="axis">Rotation axis.</param>
            abstract makeRotationAxis: axis: Vector3 * angle: float -> Matrix4
            /// Sets this matrix as scale transform.
            abstract makeScale: x: float * y: float * z: float -> Matrix4
            /// Sets this matrix to the transformation composed of translation, rotation and scale.
            abstract compose: translation: Vector3 * rotation: Quaternion * scale: Vector3 -> Matrix4
            /// Decomposes this matrix into the translation, rotation and scale components.
            /// If parameters are not passed, new instances will be created.
            abstract decompose: ?translation: Vector3 * ?rotation: Quaternion * ?scale: Vector3 -> ResizeArray<Object>
            /// Creates a frustum matrix.
            abstract makePerspective: left: float * right: float * bottom: float * top: float * near: float * far: float -> Matrix4
            /// Creates a perspective projection matrix.
            abstract makePerspective: fov: float * aspect: float * near: float * far: float -> Matrix4
            /// Creates an orthographic projection matrix.
            abstract makeOrthographic: left: float * right: float * top: float * bottom: float * near: float * far: float -> Matrix4
            abstract equals: matrix: Matrix4 -> bool
            abstract fromArray: array: ResizeArray<float> * ?offset: float -> Matrix4
            abstract toArray: unit -> ResizeArray<float>
            abstract extractPosition: m: Matrix4 -> Matrix4
            abstract setRotationFromQuaternion: q: Quaternion -> Matrix4
            abstract multiplyVector3: v: obj option -> obj option
            abstract multiplyVector4: v: obj option -> obj option
            abstract multiplyVector3Array: array: ResizeArray<float> -> ResizeArray<float>
            abstract rotateAxis: v: obj option -> unit
            abstract crossVector: v: obj option -> unit
            abstract flattenToArrayOffset: array: ResizeArray<float> * offset: float -> ResizeArray<float>

        /// A 4x4 Matrix.
        type [<AllowNullLiteral>] Matrix4Static =
            [<Emit "new $0($1...)">] abstract Create: unit -> Matrix4

        type [<AllowNullLiteral>] Plane =
            abstract normal: Vector3 with get, set
            abstract constant: float with get, set
            abstract set: normal: Vector3 * constant: float -> Plane
            abstract setComponents: x: float * y: float * z: float * w: float -> Plane
            abstract setFromNormalAndCoplanarPoint: normal: Vector3 * point: Vector3 -> Plane
            abstract setFromCoplanarPoints: a: Vector3 * b: Vector3 * c: Vector3 -> Plane
            abstract clone: unit -> Plane
            abstract copy: plane: Plane -> Plane
            abstract normalize: unit -> Plane
            abstract negate: unit -> Plane
            abstract distanceToPoint: point: Vector3 -> float
            abstract distanceToSphere: sphere: Sphere -> float
            abstract projectPoint: point: Vector3 * target: Vector3 -> Vector3
            abstract orthoPoint: point: Vector3 * target: Vector3 -> Vector3
            abstract intersectLine: line: Line3 * target: Vector3 -> Vector3
            abstract intersectsLine: line: Line3 -> bool
            abstract intersectsBox: box: Box3 -> bool
            abstract coplanarPoint: target: Vector3 -> Vector3
            abstract applyMatrix4: matrix: Matrix4 * ?optionalNormalMatrix: Matrix3 -> Plane
            abstract translate: offset: Vector3 -> Plane
            abstract equals: plane: Plane -> bool
            abstract isIntersectionLine: l: obj option -> obj option

        type [<AllowNullLiteral>] PlaneStatic =
            [<Emit "new $0($1...)">] abstract Create: ?normal: Vector3 * ?constant: float -> Plane

        type [<AllowNullLiteral>] Spherical =
            abstract radius: float with get, set
            abstract phi: float with get, set
            abstract theta: float with get, set
            abstract set: radius: float * phi: float * theta: float -> Spherical
            abstract clone: unit -> Spherical
            abstract copy: other: Spherical -> Spherical
            abstract makeSafe: unit -> unit
            abstract setFromVector3: vec3: Vector3 -> Spherical

        type [<AllowNullLiteral>] SphericalStatic =
            [<Emit "new $0($1...)">] abstract Create: ?radius: float * ?phi: float * ?theta: float -> Spherical

        type [<AllowNullLiteral>] Cylindrical =
            abstract radius: float with get, set
            abstract theta: float with get, set
            abstract y: float with get, set
            abstract clone: unit -> Cylindrical
            abstract copy: other: Cylindrical -> Cylindrical
            abstract set: radius: float * theta: float * y: float -> Cylindrical
            abstract setFromVector3: vec3: Vector3 -> Cylindrical

        type [<AllowNullLiteral>] CylindricalStatic =
            [<Emit "new $0($1...)">] abstract Create: ?radius: float * ?theta: float * ?y: float -> Cylindrical

        /// Implementation of a quaternion. This is used for rotating things without incurring in the dreaded gimbal lock issue, amongst other advantages.
        type [<AllowNullLiteral>] Quaternion =
            abstract x: float with get, set
            abstract y: float with get, set
            abstract z: float with get, set
            abstract w: float with get, set
            /// Sets values of this quaternion.
            abstract set: x: float * y: float * z: float * w: float -> Quaternion
            /// Clones this quaternion.
            abstract clone: unit -> Quaternion
            /// Copies values of q to this quaternion.
            abstract copy: q: Quaternion -> Quaternion
            /// Sets this quaternion from rotation specified by Euler angles.
            abstract setFromEuler: euler: Euler * ?update: bool -> Quaternion
            /// Sets this quaternion from rotation specified by axis and angle.
            /// Adapted from http://www.euclideanspace.com/maths/geometry/rotations/conversions/angleToQuaternion/index.htm.
            /// Axis have to be normalized, angle is in radians.
            abstract setFromAxisAngle: axis: Vector3 * angle: float -> Quaternion
            /// Sets this quaternion from rotation component of m. Adapted from http://www.euclideanspace.com/maths/geometry/rotations/conversions/matrixToQuaternion/index.htm.
            abstract setFromRotationMatrix: m: Matrix4 -> Quaternion
            abstract setFromUnitVectors: vFrom: Vector3 * vTo: Vector3 -> Quaternion
            /// Inverts this quaternion.
            abstract inverse: unit -> Quaternion
            abstract conjugate: unit -> Quaternion
            abstract dot: v: Quaternion -> float
            abstract lengthSq: unit -> float
            /// Computes length of this quaternion.
            abstract length: unit -> float
            /// Normalizes this quaternion.
            abstract normalize: unit -> Quaternion
            /// Multiplies this quaternion by b.
            abstract multiply: q: Quaternion -> Quaternion
            abstract premultiply: q: Quaternion -> Quaternion
            /// Sets this quaternion to a x b
            /// Adapted from http://www.euclideanspace.com/maths/algebra/realNormedAlgebra/quaternions/code/index.htm.
            abstract multiplyQuaternions: a: Quaternion * b: Quaternion -> Quaternion
            abstract slerp: qb: Quaternion * t: float -> Quaternion
            abstract equals: v: Quaternion -> bool
            abstract fromArray: n: ResizeArray<float> -> Quaternion
            abstract toArray: unit -> ResizeArray<float>
            abstract fromArray: xyzw: ResizeArray<float> * ?offset: float -> Quaternion
            abstract toArray: ?xyzw: ResizeArray<float> * ?offset: float -> ResizeArray<float>
            abstract onChange: callback: Function -> Quaternion
            abstract onChangeCallback: Function with get, set
            abstract multiplyVector3: v: obj option -> obj option

        /// Implementation of a quaternion. This is used for rotating things without incurring in the dreaded gimbal lock issue, amongst other advantages.
        type [<AllowNullLiteral>] QuaternionStatic =
            /// <param name="x">x coordinate</param>
            /// <param name="y">y coordinate</param>
            /// <param name="z">z coordinate</param>
            /// <param name="w">w coordinate</param>
            [<Emit "new $0($1...)">] abstract Create: ?x: float * ?y: float * ?z: float * ?w: float -> Quaternion
            /// Adapted from http://www.euclideanspace.com/maths/algebra/realNormedAlgebra/quaternions/slerp/.
            abstract slerp: qa: Quaternion * qb: Quaternion * qm: Quaternion * t: float -> Quaternion
            abstract slerpFlat: dst: ResizeArray<float> * dstOffset: float * src0: ResizeArray<float> * srcOffset: float * src1: ResizeArray<float> * stcOffset1: float * t: float -> Quaternion

        type [<AllowNullLiteral>] Ray =
            abstract origin: Vector3 with get, set
            abstract direction: Vector3 with get, set
            abstract set: origin: Vector3 * direction: Vector3 -> Ray
            abstract clone: unit -> Ray
            abstract copy: ray: Ray -> Ray
            abstract at: t: float * target: Vector3 -> Vector3
            abstract lookAt: v: Vector3 -> Vector3
            abstract recast: t: float -> Ray
            abstract closestPointToPoint: point: Vector3 * target: Vector3 -> Vector3
            abstract distanceToPoint: point: Vector3 -> float
            abstract distanceSqToPoint: point: Vector3 -> float
            abstract distanceSqToSegment: v0: Vector3 * v1: Vector3 * ?optionalPointOnRay: Vector3 * ?optionalPointOnSegment: Vector3 -> float
            abstract intersectSphere: sphere: Sphere * target: Vector3 -> Vector3
            abstract intersectsSphere: sphere: Sphere -> bool
            abstract distanceToPlane: plane: Plane -> float
            abstract intersectPlane: plane: Plane * target: Vector3 -> Vector3
            abstract intersectsPlane: plane: Plane -> bool
            abstract intersectBox: box: Box3 * target: Vector3 -> Vector3
            abstract intersectsBox: box: Box3 -> bool
            abstract intersectTriangle: a: Vector3 * b: Vector3 * c: Vector3 * backfaceCulling: bool * target: Vector3 -> Vector3
            abstract applyMatrix4: matrix4: Matrix4 -> Ray
            abstract equals: ray: Ray -> bool
            abstract isIntersectionBox: b: obj option -> obj option
            abstract isIntersectionPlane: p: obj option -> obj option
            abstract isIntersectionSphere: s: obj option -> obj option

        type [<AllowNullLiteral>] RayStatic =
            [<Emit "new $0($1...)">] abstract Create: ?origin: Vector3 * ?direction: Vector3 -> Ray

        type [<AllowNullLiteral>] Sphere =
            abstract center: Vector3 with get, set
            abstract radius: float with get, set
            abstract set: center: Vector3 * radius: float -> Sphere
            abstract setFromPoints: points: ResizeArray<Vector3> * ?optionalCenter: Vector3 -> Sphere
            abstract clone: unit -> Sphere
            abstract copy: sphere: Sphere -> Sphere
            abstract empty: unit -> bool
            abstract containsPoint: point: Vector3 -> bool
            abstract distanceToPoint: point: Vector3 -> float
            abstract intersectsSphere: sphere: Sphere -> bool
            abstract intersectsBox: box: Box3 -> bool
            abstract intersectsPlane: plane: Plane -> bool
            abstract clampPoint: point: Vector3 * target: Vector3 -> Vector3
            abstract getBoundingBox: target: Box3 -> Box3
            abstract applyMatrix4: matrix: Matrix4 -> Sphere
            abstract translate: offset: Vector3 -> Sphere
            abstract equals: sphere: Sphere -> bool

        type [<AllowNullLiteral>] SphereStatic =
            [<Emit "new $0($1...)">] abstract Create: ?center: Vector3 * ?radius: float -> Sphere

        type [<AllowNullLiteral>] SplineControlPoint =
            abstract x: float with get, set
            abstract y: float with get, set
            abstract z: float with get, set

        type [<AllowNullLiteral>] Triangle =
            abstract a: Vector3 with get, set
            abstract b: Vector3 with get, set
            abstract c: Vector3 with get, set
            abstract set: a: Vector3 * b: Vector3 * c: Vector3 -> Triangle
            abstract setFromPointsAndIndices: points: ResizeArray<Vector3> * i0: float * i1: float * i2: float -> Triangle
            abstract clone: unit -> Triangle
            abstract copy: triangle: Triangle -> Triangle
            abstract getArea: unit -> float
            abstract getMidpoint: target: Vector3 -> Vector3
            abstract getNormal: target: Vector3 -> Vector3
            abstract getPlane: target: Vector3 -> Plane
            abstract getBarycoord: point: Vector3 * target: Vector3 -> Vector3
            abstract containsPoint: point: Vector3 -> bool
            abstract closestPointToPoint: point: Vector3 * target: Vector3 -> Vector3
            abstract equals: triangle: Triangle -> bool

        type [<AllowNullLiteral>] TriangleStatic =
            [<Emit "new $0($1...)">] abstract Create: ?a: Vector3 * ?b: Vector3 * ?c: Vector3 -> Triangle
            abstract getNormal: a: Vector3 * b: Vector3 * c: Vector3 * target: Vector3 -> Vector3
            abstract getBarycoord: point: Vector3 * a: Vector3 * b: Vector3 * c: Vector3 * target: Vector3 -> Vector3
            abstract containsPoint: point: Vector3 * a: Vector3 * b: Vector3 * c: Vector3 -> bool

        /// ( interface Vector&lt;T&gt; )
        /// 
        /// Abstract interface of Vector2, Vector3 and Vector4.
        /// Currently the members of Vector is NOT type safe because it accepts different typed vectors.
        /// Those definitions will be changed when TypeScript innovates Generics to be type safe.
        type [<AllowNullLiteral>] Vector =
            abstract setComponent: index: float * value: float -> Vector
            abstract getComponent: index: float -> float
            abstract set: [<ParamArray>] args: ResizeArray<float> -> Vector
            abstract setScalar: scalar: float -> Vector
            /// copy(v:T):T;
            abstract copy: v: Vector -> Vector
            /// NOTE: The second argument is deprecated.
            /// 
            /// add(v:T):T;
            abstract add: v: Vector * ?w: Vector -> Vector
            /// addVectors(a:T, b:T):T;
            abstract addVectors: a: Vector * b: Vector -> Vector
            abstract addScaledVector: vector: Vector * scale: float -> Vector
            /// Adds the scalar value s to this vector's values.
            abstract addScalar: scalar: float -> Vector
            /// sub(v:T):T;
            abstract sub: v: Vector -> Vector
            /// subVectors(a:T, b:T):T;
            abstract subVectors: a: Vector * b: Vector -> Vector
            /// multiplyScalar(s:number):T;
            abstract multiplyScalar: s: float -> Vector
            /// divideScalar(s:number):T;
            abstract divideScalar: s: float -> Vector
            /// negate():T;
            abstract negate: unit -> Vector
            /// dot(v:T):T;
            abstract dot: v: Vector -> float
            /// lengthSq():number;
            abstract lengthSq: unit -> float
            /// length():number;
            abstract length: unit -> float
            /// normalize():T;
            abstract normalize: unit -> Vector
            /// NOTE: Vector4 doesn't have the property.
            /// 
            /// distanceTo(v:T):number;
            abstract distanceTo: v: Vector -> float
            /// NOTE: Vector4 doesn't have the property.
            /// 
            /// distanceToSquared(v:T):number;
            abstract distanceToSquared: v: Vector -> float
            /// setLength(l:number):T;
            abstract setLength: l: float -> Vector
            /// lerp(v:T, alpha:number):T;
            abstract lerp: v: Vector * alpha: float -> Vector
            /// equals(v:T):boolean;
            abstract equals: v: Vector -> bool
            /// clone():T;
            abstract clone: unit -> Vector

        /// 2D vector.
        /// 
        /// ( class Vector2 implements Vector<Vector2> )
        type [<AllowNullLiteral>] Vector2 =
            inherit Vector
            abstract x: float with get, set
            abstract y: float with get, set
            abstract width: float with get, set
            abstract height: float with get, set
            abstract isVector2: obj with get, set
            /// Sets value of this vector.
            abstract set: x: float * y: float -> Vector2
            /// Sets the x and y values of this vector both equal to scalar.
            abstract setScalar: scalar: float -> Vector2
            /// Sets X component of this vector.
            abstract setX: x: float -> Vector2
            /// Sets Y component of this vector.
            abstract setY: y: float -> Vector2
            /// Sets a component of this vector.
            abstract setComponent: index: float * value: float -> Vector2
            /// Gets a component of this vector.
            abstract getComponent: index: float -> float
            /// Returns a new Vector2 instance with the same `x` and `y` values.
            abstract clone: unit -> Vector2
            /// Copies value of v to this vector.
            abstract copy: v: Vector2 -> Vector2
            /// Adds v to this vector.
            abstract add: v: Vector2 * ?w: Vector2 -> Vector2
            /// Adds the scalar value s to this vector's x and y values.
            abstract addScalar: s: float -> Vector2
            /// Sets this vector to a + b.
            abstract addVectors: a: Vector2 * b: Vector2 -> Vector2
            /// Adds the multiple of v and s to this vector.
            abstract addScaledVector: v: Vector2 * s: float -> Vector2
            /// Subtracts v from this vector.
            abstract sub: v: Vector2 -> Vector2
            /// Subtracts s from this vector's x and y components.
            abstract subScalar: s: float -> Vector2
            /// Sets this vector to a - b.
            abstract subVectors: a: Vector2 * b: Vector2 -> Vector2
            /// Multiplies this vector by v.
            abstract multiply: v: Vector2 -> Vector2
            /// Multiplies this vector by scalar s.
            abstract multiplyScalar: scalar: float -> Vector2
            /// Divides this vector by v.
            abstract divide: v: Vector2 -> Vector2
            /// Divides this vector by scalar s.
            /// Set vector to ( 0, 0 ) if s == 0.
            abstract divideScalar: s: float -> Vector2
            /// Multiplies this vector (with an implicit 1 as the 3rd component) by m.
            abstract applyMatrix3: m: Matrix3 -> Vector2
            /// If this vector's x or y value is greater than v's x or y value, replace that value with the corresponding min value.
            abstract min: v: Vector2 -> Vector2
            /// If this vector's x or y value is less than v's x or y value, replace that value with the corresponding max value.
            abstract max: v: Vector2 -> Vector2
            /// <summary>If this vector's x or y value is greater than the max vector's x or y value, it is replaced by the corresponding value.
            /// If this vector's x or y value is less than the min vector's x or y value, it is replaced by the corresponding value.</summary>
            /// <param name="min">the minimum x and y values.</param>
            /// <param name="max">the maximum x and y values in the desired range.</param>
            abstract clamp: min: Vector2 * max: Vector2 -> Vector2
            /// <summary>If this vector's x or y values are greater than the max value, they are replaced by the max value.
            /// If this vector's x or y values are less than the min value, they are replaced by the min value.</summary>
            /// <param name="min">the minimum value the components will be clamped to.</param>
            /// <param name="max">the maximum value the components will be clamped to.</param>
            abstract clampScalar: min: float * max: float -> Vector2
            /// <summary>If this vector's length is greater than the max value, it is replaced by the max value.
            /// If this vector's length is less than the min value, it is replaced by the min value.</summary>
            /// <param name="min">the minimum value the length will be clamped to.</param>
            /// <param name="max">the maximum value the length will be clamped to.</param>
            abstract clampLength: min: float * max: float -> Vector2
            /// The components of the vector are rounded down to the nearest integer value.
            abstract floor: unit -> Vector2
            /// The x and y components of the vector are rounded up to the nearest integer value.
            abstract ceil: unit -> Vector2
            /// The components of the vector are rounded to the nearest integer value.
            abstract round: unit -> Vector2
            /// The components of the vector are rounded towards zero (up if negative, down if positive) to an integer value.
            abstract roundToZero: unit -> Vector2
            /// Inverts this vector.
            abstract negate: unit -> Vector2
            /// Computes dot product of this vector and v.
            abstract dot: v: Vector2 -> float
            /// Computes squared length of this vector.
            abstract lengthSq: unit -> float
            /// Computes length of this vector.
            abstract length: unit -> float
            abstract lengthManhattan: unit -> float
            /// Computes the Manhattan length of this vector.
            abstract manhattanLength: unit -> float
            /// Normalizes this vector.
            abstract normalize: unit -> Vector2
            /// computes the angle in radians with respect to the positive x-axis
            abstract angle: unit -> float
            /// Computes distance of this vector to v.
            abstract distanceTo: v: Vector2 -> float
            /// Computes squared distance of this vector to v.
            abstract distanceToSquared: v: Vector2 -> float
            abstract distanceToManhattan: v: Vector2 -> float
            /// <summary>Computes the Manhattan length (distance) from this vector to the given vector v</summary>
            /// <param name="v"></param>
            abstract manhattanDistanceTo: v: Vector2 -> float
            /// Normalizes this vector and multiplies it by l.
            abstract setLength: length: float -> Vector2
            /// <summary>Linearly interpolates between this vector and v, where alpha is the distance along the line - alpha = 0 will be this vector, and alpha = 1 will be v.</summary>
            /// <param name="v">vector to interpolate towards.</param>
            /// <param name="alpha">interpolation factor in the closed interval [0, 1].</param>
            abstract lerp: v: Vector2 * alpha: float -> Vector2
            /// <summary>Sets this vector to be the vector linearly interpolated between v1 and v2 where alpha is the distance along the line connecting the two vectors - alpha = 0 will be v1, and alpha = 1 will be v2.</summary>
            /// <param name="v1">the starting vector.</param>
            /// <param name="v2">vector to interpolate towards.</param>
            /// <param name="alpha">interpolation factor in the closed interval [0, 1].</param>
            abstract lerpVectors: v1: Vector2 * v2: Vector2 * alpha: float -> Vector2
            /// Checks for strict equality of this vector and v.
            abstract equals: v: Vector2 -> bool
            /// <summary>Sets this vector's x value to be array[offset] and y value to be array[offset + 1].</summary>
            /// <param name="array">the source array.</param>
            /// <param name="offset">(optional) offset into the array. Default is 0.</param>
            abstract fromArray: array: ResizeArray<float> * ?offset: float -> Vector2
            /// <summary>Returns an array [x, y], or copies x and y into the provided array.</summary>
            /// <param name="array">(optional) array to store the vector to. If this is not provided, a new array will be created.</param>
            /// <param name="offset">(optional) optional offset into the array.</param>
            abstract toArray: ?array: ResizeArray<float> * ?offset: float -> ResizeArray<float>
            /// <summary>Sets this vector's x and y values from the attribute.</summary>
            /// <param name="attribute">the source attribute.</param>
            /// <param name="index">index in the attribute.</param>
            abstract fromBufferAttribute: attribute: BufferAttribute * index: float -> Vector2
            /// <summary>Rotates the vector around center by angle radians.</summary>
            /// <param name="center">the point around which to rotate.</param>
            /// <param name="angle">the angle to rotate, in radians.</param>
            abstract rotateAround: center: Vector2 * angle: float -> Vector2

        /// 2D vector.
        /// 
        /// ( class Vector2 implements Vector<Vector2> )
        type [<AllowNullLiteral>] Vector2Static =
            [<Emit "new $0($1...)">] abstract Create: ?x: float * ?y: float -> Vector2

        /// 3D vector.
        type [<AllowNullLiteral>] Vector3 =
            inherit Vector
            abstract x: float with get, set
            abstract y: float with get, set
            abstract z: float with get, set
            abstract isVector3: obj with get, set
            /// Sets value of this vector.
            abstract set: x: float * y: float * z: float -> Vector3
            /// Sets all values of this vector.
            abstract setScalar: scalar: float -> Vector3
            /// Sets x value of this vector.
            abstract setX: x: float -> Vector3
            /// Sets y value of this vector.
            abstract setY: y: float -> Vector3
            /// Sets z value of this vector.
            abstract setZ: z: float -> Vector3
            abstract setComponent: index: float * value: float -> Vector3
            abstract getComponent: index: float -> float
            /// Clones this vector.
            abstract clone: unit -> Vector3
            /// Copies value of v to this vector.
            abstract copy: v: Vector3 -> Vector3
            /// Adds v to this vector.
            abstract add: a: Vector3 * ?b: Vector3 -> Vector3
            abstract addScalar: s: float -> Vector3
            abstract addScaledVector: v: Vector3 * s: float -> Vector3
            /// Sets this vector to a + b.
            abstract addVectors: a: Vector3 * b: Vector3 -> Vector3
            /// Subtracts v from this vector.
            abstract sub: a: Vector3 -> Vector3
            abstract subScalar: s: float -> Vector3
            /// Sets this vector to a - b.
            abstract subVectors: a: Vector3 * b: Vector3 -> Vector3
            abstract multiply: v: Vector3 -> Vector3
            /// Multiplies this vector by scalar s.
            abstract multiplyScalar: s: float -> Vector3
            abstract multiplyVectors: a: Vector3 * b: Vector3 -> Vector3
            abstract applyEuler: euler: Euler -> Vector3
            abstract applyAxisAngle: axis: Vector3 * angle: float -> Vector3
            abstract applyMatrix3: m: Matrix3 -> Vector3
            abstract applyMatrix4: m: Matrix4 -> Vector3
            abstract applyQuaternion: q: Quaternion -> Vector3
            abstract project: camrea: Camera -> Vector3
            abstract unproject: camera: Camera -> Vector3
            abstract transformDirection: m: Matrix4 -> Vector3
            abstract divide: v: Vector3 -> Vector3
            /// Divides this vector by scalar s.
            /// Set vector to ( 0, 0, 0 ) if s == 0.
            abstract divideScalar: s: float -> Vector3
            abstract min: v: Vector3 -> Vector3
            abstract max: v: Vector3 -> Vector3
            abstract clamp: min: Vector3 * max: Vector3 -> Vector3
            abstract clampScalar: min: float * max: float -> Vector3
            abstract clampLength: min: float * max: float -> Vector3
            abstract floor: unit -> Vector3
            abstract ceil: unit -> Vector3
            abstract round: unit -> Vector3
            abstract roundToZero: unit -> Vector3
            /// Inverts this vector.
            abstract negate: unit -> Vector3
            /// Computes dot product of this vector and v.
            abstract dot: v: Vector3 -> float
            /// Computes squared length of this vector.
            abstract lengthSq: unit -> float
            /// Computes length of this vector.
            abstract length: unit -> float
            /// Computes Manhattan length of this vector.
            /// http://en.wikipedia.org/wiki/Taxicab_geometry
            abstract lengthManhattan: unit -> float
            /// Computes the Manhattan length of this vector.
            abstract manhattanLength: unit -> float
            /// <summary>Computes the Manhattan length (distance) from this vector to the given vector v</summary>
            /// <param name="v"></param>
            abstract manhattanDistanceTo: v: Vector3 -> float
            /// Normalizes this vector.
            abstract normalize: unit -> Vector3
            /// Normalizes this vector and multiplies it by l.
            abstract setLength: l: float -> Vector3
            abstract lerp: v: Vector3 * alpha: float -> Vector3
            abstract lerpVectors: v1: Vector3 * v2: Vector3 * alpha: float -> Vector3
            /// Sets this vector to cross product of itself and v.
            abstract cross: a: Vector3 * ?w: Vector3 -> Vector3
            /// Sets this vector to cross product of a and b.
            abstract crossVectors: a: Vector3 * b: Vector3 -> Vector3
            abstract projectOnVector: v: Vector3 -> Vector3
            abstract projectOnPlane: planeNormal: Vector3 -> Vector3
            abstract reflect: vector: Vector3 -> Vector3
            abstract angleTo: v: Vector3 -> float
            /// Computes distance of this vector to v.
            abstract distanceTo: v: Vector3 -> float
            /// Computes squared distance of this vector to v.
            abstract distanceToSquared: v: Vector3 -> float
            abstract distanceToManhattan: v: Vector3 -> float
            abstract setFromSpherical: s: Spherical -> Vector3
            abstract setFromCylindrical: s: Cylindrical -> Vector3
            abstract setFromMatrixPosition: m: Matrix4 -> Vector3
            abstract setFromMatrixScale: m: Matrix4 -> Vector3
            abstract setFromMatrixColumn: matrix: Matrix4 * index: float -> Vector3
            /// Checks for strict equality of this vector and v.
            abstract equals: v: Vector3 -> bool
            abstract fromArray: xyz: ResizeArray<float> * ?offset: float -> Vector3
            abstract toArray: ?xyz: ResizeArray<float> * ?offset: float -> ResizeArray<float>
            abstract fromBufferAttribute: attribute: BufferAttribute * index: float * ?offset: float -> Vector3

        /// 3D vector.
        type [<AllowNullLiteral>] Vector3Static =
            [<Emit "new $0($1...)">] abstract Create: ?x: float * ?y: float * ?z: float -> Vector3

        type [<AllowNullLiteral>] Vertex =
            inherit Vector3

        type [<AllowNullLiteral>] VertexStatic =
            [<Emit "new $0($1...)">] abstract Create: unit -> Vertex

        /// 4D vector.
        /// 
        /// ( class Vector4 implements Vector<Vector4> )
        type [<AllowNullLiteral>] Vector4 =
            inherit Vector
            abstract x: float with get, set
            abstract y: float with get, set
            abstract z: float with get, set
            abstract w: float with get, set
            abstract isVector4: obj with get, set
            /// Sets value of this vector.
            abstract set: x: float * y: float * z: float * w: float -> Vector4
            /// Sets all values of this vector.
            abstract setScalar: scalar: float -> Vector4
            /// Sets X component of this vector.
            abstract setX: x: float -> Vector4
            /// Sets Y component of this vector.
            abstract setY: y: float -> Vector4
            /// Sets Z component of this vector.
            abstract setZ: z: float -> Vector4
            /// Sets w component of this vector.
            abstract setW: w: float -> Vector4
            abstract setComponent: index: float * value: float -> Vector4
            abstract getComponent: index: float -> float
            /// Clones this vector.
            abstract clone: unit -> Vector4
            /// Copies value of v to this vector.
            abstract copy: v: Vector4 -> Vector4
            /// Adds v to this vector.
            abstract add: v: Vector4 * ?w: Vector4 -> Vector4
            abstract addScalar: scalar: float -> Vector4
            /// Sets this vector to a + b.
            abstract addVectors: a: Vector4 * b: Vector4 -> Vector4
            abstract addScaledVector: v: Vector4 * s: float -> Vector4
            /// Subtracts v from this vector.
            abstract sub: v: Vector4 -> Vector4
            abstract subScalar: s: float -> Vector4
            /// Sets this vector to a - b.
            abstract subVectors: a: Vector4 * b: Vector4 -> Vector4
            /// Multiplies this vector by scalar s.
            abstract multiplyScalar: s: float -> Vector4
            abstract applyMatrix4: m: Matrix4 -> Vector4
            /// Divides this vector by scalar s.
            /// Set vector to ( 0, 0, 0 ) if s == 0.
            abstract divideScalar: s: float -> Vector4
            /// <summary>http://www.euclideanspace.com/maths/geometry/rotations/conversions/quaternionToAngle/index.htm</summary>
            /// <param name="q">is assumed to be normalized</param>
            abstract setAxisAngleFromQuaternion: q: Quaternion -> Vector4
            /// <summary>http://www.euclideanspace.com/maths/geometry/rotations/conversions/matrixToAngle/index.htm</summary>
            /// <param name="m">assumes the upper 3x3 of m is a pure rotation matrix (i.e, unscaled)</param>
            abstract setAxisAngleFromRotationMatrix: m: Matrix3 -> Vector4
            abstract min: v: Vector4 -> Vector4
            abstract max: v: Vector4 -> Vector4
            abstract clamp: min: Vector4 * max: Vector4 -> Vector4
            abstract clampScalar: min: float * max: float -> Vector4
            abstract floor: unit -> Vector4
            abstract ceil: unit -> Vector4
            abstract round: unit -> Vector4
            abstract roundToZero: unit -> Vector4
            /// Inverts this vector.
            abstract negate: unit -> Vector4
            /// Computes dot product of this vector and v.
            abstract dot: v: Vector4 -> float
            /// Computes squared length of this vector.
            abstract lengthSq: unit -> float
            /// Computes length of this vector.
            abstract length: unit -> float
            /// Computes the Manhattan length of this vector.
            abstract manhattanLength: unit -> float
            /// Normalizes this vector.
            abstract normalize: unit -> Vector4
            /// Normalizes this vector and multiplies it by l.
            abstract setLength: length: float -> Vector4
            /// Linearly interpolate between this vector and v with alpha factor.
            abstract lerp: v: Vector4 * alpha: float -> Vector4
            abstract lerpVectors: v1: Vector4 * v2: Vector4 * alpha: float -> Vector4
            /// Checks for strict equality of this vector and v.
            abstract equals: v: Vector4 -> bool
            abstract fromArray: xyzw: ResizeArray<float> * ?offset: float -> Vector4
            abstract toArray: ?xyzw: ResizeArray<float> * ?offset: float -> ResizeArray<float>
            abstract fromBufferAttribute: attribute: BufferAttribute * index: float * ?offset: float -> Vector4

        /// 4D vector.
        /// 
        /// ( class Vector4 implements Vector<Vector4> )
        type [<AllowNullLiteral>] Vector4Static =
            [<Emit "new $0($1...)">] abstract Create: ?x: float * ?y: float * ?z: float * ?w: float -> Vector4

        type [<AllowNullLiteral>] Interpolant =
            abstract parameterPositions: obj option with get, set
            abstract samplesValues: obj option with get, set
            abstract valueSize: float with get, set
            abstract resultBuffer: obj option with get, set
            abstract evaluate: time: float -> obj option

        type [<AllowNullLiteral>] InterpolantStatic =
            [<Emit "new $0($1...)">] abstract Create: parameterPositions: obj option * samplesValues: obj option * sampleSize: float * ?resultBuffer: obj option -> Interpolant

        type [<AllowNullLiteral>] CubicInterpolant =
            inherit Interpolant
            abstract interpolate_: i1: float * t0: float * t: float * t1: float -> obj option

        type [<AllowNullLiteral>] CubicInterpolantStatic =
            [<Emit "new $0($1...)">] abstract Create: parameterPositions: obj option * samplesValues: obj option * sampleSize: float * ?resultBuffer: obj option -> CubicInterpolant

        type [<AllowNullLiteral>] DiscreteInterpolant =
            inherit Interpolant
            abstract interpolate_: i1: float * t0: float * t: float * t1: float -> obj option

        type [<AllowNullLiteral>] DiscreteInterpolantStatic =
            [<Emit "new $0($1...)">] abstract Create: parameterPositions: obj option * samplesValues: obj option * sampleSize: float * ?resultBuffer: obj option -> DiscreteInterpolant

        type [<AllowNullLiteral>] LinearInterpolant =
            inherit Interpolant
            abstract interpolate_: i1: float * t0: float * t: float * t1: float -> obj option

        type [<AllowNullLiteral>] LinearInterpolantStatic =
            [<Emit "new $0($1...)">] abstract Create: parameterPositions: obj option * samplesValues: obj option * sampleSize: float * ?resultBuffer: obj option -> LinearInterpolant

        type [<AllowNullLiteral>] QuaternionLinearInterpolant =
            inherit Interpolant
            abstract interpolate_: i1: float * t0: float * t: float * t1: float -> obj option

        type [<AllowNullLiteral>] QuaternionLinearInterpolantStatic =
            [<Emit "new $0($1...)">] abstract Create: parameterPositions: obj option * samplesValues: obj option * sampleSize: float * ?resultBuffer: obj option -> QuaternionLinearInterpolant

        type [<AllowNullLiteral>] Bone =
            inherit Object3D
            abstract isBone: obj with get, set
            abstract ``type``: string with get, set

        type [<AllowNullLiteral>] BoneStatic =
            [<Emit "new $0($1...)">] abstract Create: unit -> Bone

        type [<AllowNullLiteral>] Group =
            inherit Object3D
            abstract ``type``: string with get, set
            abstract isGroup: obj with get, set

        type [<AllowNullLiteral>] GroupStatic =
            [<Emit "new $0($1...)">] abstract Create: unit -> Group

        type [<AllowNullLiteral>] LOD =
            inherit Object3D
            abstract ``type``: string with get, set
            abstract levels: ResizeArray<obj> with get, set
            abstract addLevel: ``object``: Object3D * ?distance: float -> unit
            abstract getObjectForDistance: distance: float -> Object3D
            abstract raycast: raycaster: Raycaster * intersects: ResizeArray<Intersection> -> unit
            abstract update: camera: Camera -> unit
            abstract toJSON: meta: obj option -> obj option
            abstract objects: ResizeArray<obj option> with get, set

        type [<AllowNullLiteral>] LODStatic =
            [<Emit "new $0($1...)">] abstract Create: unit -> LOD

        type [<AllowNullLiteral>] Line =
            inherit Object3D
            abstract geometry: U2<Geometry, BufferGeometry> with get, set
            abstract material: U2<Material, ResizeArray<Material>> with get, set
            abstract ``type``: string with get, set
            abstract isLine: obj with get, set
            abstract computeLineDistances: unit -> Line
            abstract raycast: raycaster: Raycaster * intersects: ResizeArray<Intersection> -> unit

        type [<AllowNullLiteral>] LineStatic =
            [<Emit "new $0($1...)">] abstract Create: ?geometry: U2<Geometry, BufferGeometry> * ?material: U2<Material, ResizeArray<Material>> * ?mode: float -> Line

        type [<AllowNullLiteral>] LineSegments =
            inherit Line

        type [<AllowNullLiteral>] LineSegmentsStatic =
            [<Emit "new $0($1...)">] abstract Create: ?geometry: U2<Geometry, BufferGeometry> * ?material: U2<Material, ResizeArray<Material>> * ?mode: float -> LineSegments

        type [<AllowNullLiteral>] Mesh =
            inherit Object3D
            abstract geometry: U2<Geometry, BufferGeometry> with get, set
            abstract material: U2<Material, ResizeArray<Material>> with get, set
            abstract drawMode: TrianglesDrawModes with get, set
            abstract morphTargetInfluences: ResizeArray<float> option with get, set
            abstract morphTargetDictionary: obj option with get, set
            abstract isMesh: obj with get, set
            abstract ``type``: string with get, set
            abstract setDrawMode: drawMode: TrianglesDrawModes -> unit
            abstract updateMorphTargets: unit -> unit
            abstract raycast: raycaster: Raycaster * intersects: ResizeArray<Intersection> -> unit
            abstract copy: source: Mesh * ?recursive: bool -> Mesh

        type [<AllowNullLiteral>] MeshStatic =
            [<Emit "new $0($1...)">] abstract Create: ?geometry: U2<Geometry, BufferGeometry> * ?material: U2<Material, ResizeArray<Material>> -> Mesh

        /// A class for displaying particles in the form of variable size points. For example, if using the WebGLRenderer, the particles are displayed using GL_POINTS.
        type [<AllowNullLiteral>] Points =
            inherit Object3D
            abstract ``type``: string with get, set
            abstract isPoints: obj with get, set
            /// An instance of Geometry or BufferGeometry, where each vertex designates the position of a particle in the system.
            abstract geometry: U2<Geometry, BufferGeometry> with get, set
            /// An instance of Material, defining the object's appearance. Default is a PointsMaterial with randomised colour.
            abstract material: U2<Material, ResizeArray<Material>> with get, set
            abstract raycast: raycaster: Raycaster * intersects: ResizeArray<Intersection> -> unit

        /// A class for displaying particles in the form of variable size points. For example, if using the WebGLRenderer, the particles are displayed using GL_POINTS.
        type [<AllowNullLiteral>] PointsStatic =
            /// <param name="geometry">An instance of Geometry or BufferGeometry.</param>
            /// <param name="material">An instance of Material (optional).</param>
            [<Emit "new $0($1...)">] abstract Create: ?geometry: U2<Geometry, BufferGeometry> * ?material: U2<Material, ResizeArray<Material>> -> Points

        type [<AllowNullLiteral>] PointCloud =
            inherit Points

        type [<AllowNullLiteral>] PointCloudStatic =
            [<Emit "new $0($1...)">] abstract Create: unit -> PointCloud

        type [<AllowNullLiteral>] ParticleSystem =
            inherit Points

        type [<AllowNullLiteral>] ParticleSystemStatic =
            [<Emit "new $0($1...)">] abstract Create: unit -> ParticleSystem

        type [<AllowNullLiteral>] Skeleton =
            abstract useVertexTexture: bool with get, set
            abstract identityMatrix: Matrix4 with get, set
            abstract bones: ResizeArray<Bone> with get, set
            abstract boneTextureWidth: float with get, set
            abstract boneTextureHeight: float with get, set
            abstract boneMatrices: Float32Array with get, set
            abstract boneTexture: DataTexture with get, set
            abstract boneInverses: ResizeArray<Matrix4> with get, set
            abstract calculateInverses: bone: Bone -> unit
            abstract pose: unit -> unit
            abstract update: unit -> unit
            abstract clone: unit -> Skeleton

        type [<AllowNullLiteral>] SkeletonStatic =
            [<Emit "new $0($1...)">] abstract Create: bones: ResizeArray<Bone> * ?boneInverses: ResizeArray<Matrix4> -> Skeleton

        type [<AllowNullLiteral>] SkinnedMesh =
            inherit Mesh
            abstract bindMode: string with get, set
            abstract bindMatrix: Matrix4 with get, set
            abstract bindMatrixInverse: Matrix4 with get, set
            abstract skeleton: Skeleton with get, set
            abstract bind: skeleton: Skeleton * ?bindMatrix: Matrix4 -> unit
            abstract pose: unit -> unit
            abstract normalizeSkinWeights: unit -> unit
            abstract updateMatrixWorld: ?force: bool -> unit

        type [<AllowNullLiteral>] SkinnedMeshStatic =
            [<Emit "new $0($1...)">] abstract Create: ?geometry: U2<Geometry, BufferGeometry> * ?material: U2<Material, ResizeArray<Material>> * ?useVertexTexture: bool -> SkinnedMesh

        type [<AllowNullLiteral>] Sprite =
            inherit Object3D
            abstract ``type``: string with get, set
            abstract isSprite: obj with get, set
            abstract material: Material with get, set
            abstract center: Vector2 with get, set
            abstract raycast: raycaster: Raycaster * intersects: ResizeArray<Intersection> -> unit
            abstract copy: source: Sprite * ?recursive: bool -> Sprite

        type [<AllowNullLiteral>] SpriteStatic =
            [<Emit "new $0($1...)">] abstract Create: ?material: Material -> Sprite

        type [<AllowNullLiteral>] Particle =
            inherit Sprite

        type [<AllowNullLiteral>] ParticleStatic =
            [<Emit "new $0($1...)">] abstract Create: unit -> Particle

        type [<AllowNullLiteral>] Renderer =
            abstract domElement: HTMLCanvasElement with get, set
            abstract render: scene: Scene * camera: Camera -> unit
            abstract setSize: width: float * height: float * ?updateStyle: bool -> unit

        type [<AllowNullLiteral>] WebGLRendererParameters =
            /// A Canvas where the renderer draws its output.
            abstract canvas: HTMLCanvasElement option with get, set
            /// A WebGL Rendering Context.
            /// (https://developer.mozilla.org/en-US/docs/Web/API/WebGLRenderingContext)
            ///   Default is null
            abstract context: WebGLRenderingContext option with get, set
            /// shader precision. Can be "highp", "mediump" or "lowp".
            abstract precision: string option with get, set
            /// default is true.
            abstract alpha: bool option with get, set
            /// default is true.
            abstract premultipliedAlpha: bool option with get, set
            /// default is false.
            abstract antialias: bool option with get, set
            /// default is true.
            abstract stencil: bool option with get, set
            /// default is false.
            abstract preserveDrawingBuffer: bool option with get, set
            /// default is 0x000000.
            abstract clearColor: float option with get, set
            /// default is 0.
            abstract clearAlpha: float option with get, set
            abstract devicePixelRatio: float option with get, set
            /// default is false.
            abstract logarithmicDepthBuffer: bool option with get, set

        /// The WebGL renderer displays your beautifully crafted scenes using WebGL, if your device supports it.
        /// This renderer has way better performance than CanvasRenderer.
        type [<AllowNullLiteral>] WebGLRenderer =
            inherit Renderer
            /// A Canvas where the renderer draws its output.
            /// This is automatically created by the renderer in the constructor (if not provided already); you just need to add it to your page.
            abstract domElement: HTMLCanvasElement with get, set
            /// The HTML5 Canvas's 'webgl' context obtained from the canvas where the renderer will draw.
            abstract context: WebGLRenderingContext with get, set
            /// Defines whether the renderer should automatically clear its output before rendering.
            abstract autoClear: bool with get, set
            /// If autoClear is true, defines whether the renderer should clear the color buffer. Default is true.
            abstract autoClearColor: bool with get, set
            /// If autoClear is true, defines whether the renderer should clear the depth buffer. Default is true.
            abstract autoClearDepth: bool with get, set
            /// If autoClear is true, defines whether the renderer should clear the stencil buffer. Default is true.
            abstract autoClearStencil: bool with get, set
            /// Defines whether the renderer should sort objects. Default is true.
            abstract sortObjects: bool with get, set
            abstract clippingPlanes: ResizeArray<obj option> with get, set
            abstract localClippingEnabled: bool with get, set
            abstract extensions: WebGLExtensions with get, set
            /// Default is false.
            abstract gammaInput: bool with get, set
            /// Default is false.
            abstract gammaOutput: bool with get, set
            abstract physicallyCorrectLights: bool with get, set
            abstract toneMapping: ToneMapping with get, set
            abstract toneMappingExposure: float with get, set
            abstract toneMappingWhitePoint: float with get, set
            /// Default is false.
            abstract shadowMapDebug: bool with get, set
            /// Default is 8.
            abstract maxMorphTargets: float with get, set
            /// Default is 4.
            abstract maxMorphNormals: float with get, set
            abstract info: WebGLInfo with get, set
            abstract shadowMap: WebGLShadowMap with get, set
            abstract pixelRation: float with get, set
            abstract capabilities: WebGLCapabilities with get, set
            abstract properties: WebGLProperties with get, set
            abstract renderLists: WebGLRenderLists with get, set
            abstract state: WebGLState with get, set
            abstract allocTextureUnit: obj option with get, set
            abstract vr: WebVRManager with get, set
            /// Return the WebGL context.
            abstract getContext: unit -> WebGLRenderingContext
            abstract getContextAttributes: unit -> obj option
            abstract forceContextLoss: unit -> unit
            abstract getMaxAnisotropy: unit -> float
            abstract getPrecision: unit -> string
            abstract getPixelRatio: unit -> float
            abstract setPixelRatio: value: float -> unit
            abstract getDrawingBufferSize: unit -> obj
            abstract setDrawingBufferSize: width: float * height: float * pixelRatio: float -> unit
            abstract getSize: unit -> obj
            /// Resizes the output canvas to (width, height), and also sets the viewport to fit that size, starting in (0, 0).
            abstract setSize: width: float * height: float * ?updateStyle: bool -> unit
            abstract getCurrentViewport: unit -> Vector4
            /// Sets the viewport to render from (x, y) to (x + width, y + height).
            abstract setViewport: ?x: float * ?y: float * ?width: float * ?height: float -> unit
            /// Sets the scissor area from (x, y) to (x + width, y + height).
            abstract setScissor: x: float * y: float * width: float * height: float -> unit
            /// Enable the scissor test. When this is enabled, only the pixels within the defined scissor area will be affected by further renderer actions.
            abstract setScissorTest: enable: bool -> unit
            /// Returns a THREE.Color instance with the current clear color.
            abstract getClearColor: unit -> Color
            /// Sets the clear color, using color for the color and alpha for the opacity.
            abstract setClearColor: color: Color * ?alpha: float -> unit
            abstract setClearColor: color: string * ?alpha: float -> unit
            abstract setClearColor: color: float * ?alpha: float -> unit
            /// Returns a float with the current clear alpha. Ranges from 0 to 1.
            abstract getClearAlpha: unit -> float
            abstract setClearAlpha: alpha: float -> unit
            /// Tells the renderer to clear its color, depth or stencil drawing buffer(s).
            /// Arguments default to true
            abstract clear: ?color: bool * ?depth: bool * ?stencil: bool -> unit
            abstract clearColor: unit -> unit
            abstract clearDepth: unit -> unit
            abstract clearStencil: unit -> unit
            abstract clearTarget: renderTarget: WebGLRenderTarget * color: bool * depth: bool * stencil: bool -> unit
            abstract resetGLState: unit -> unit
            abstract dispose: unit -> unit
            /// Tells the shadow map plugin to update using the passed scene and camera parameters.
            abstract renderBufferImmediate: ``object``: Object3D * program: Object * material: Material -> unit
            abstract renderBufferDirect: camera: Camera * fog: Fog * material: Material * geometryGroup: obj option * ``object``: Object3D -> unit
            /// <summary>A build in function that can be used instead of requestAnimationFrame. For WebVR projects this function must be used.</summary>
            /// <param name="callback">The function will be called every available frame. If `null` is passed it will stop any already ongoing animation.</param>
            abstract setAnimationLoop: callback: Function -> unit
            abstract animate: callback: Function -> unit
            /// Render a scene using a camera.
            /// The render is done to the renderTarget (if specified) or to the canvas as usual.
            /// If forceClear is true, the canvas will be cleared before rendering, even if the renderer's autoClear property is false.
            abstract render: scene: Scene * camera: Camera * ?renderTarget: RenderTarget * ?forceClear: bool -> unit
            abstract setTexture: texture: Texture * slot: float -> unit
            abstract setTexture2D: texture: Texture * slot: float -> unit
            abstract setTextureCube: texture: Texture * slot: float -> unit
            abstract getRenderTarget: unit -> RenderTarget
            abstract getCurrentRenderTarget: unit -> RenderTarget
            abstract setRenderTarget: ?renderTarget: RenderTarget -> unit
            abstract readRenderTargetPixels: renderTarget: RenderTarget * x: float * y: float * width: float * height: float * buffer: obj option -> unit
            abstract gammaFactor: float with get, set
            abstract shadowMapEnabled: bool with get, set
            abstract shadowMapType: ShadowMapType with get, set
            abstract shadowMapCullFace: CullFace with get, set
            abstract supportsFloatTextures: unit -> obj option
            abstract supportsHalfFloatTextures: unit -> obj option
            abstract supportsStandardDerivatives: unit -> obj option
            abstract supportsCompressedTextureS3TC: unit -> obj option
            abstract supportsCompressedTexturePVRTC: unit -> obj option
            abstract supportsBlendMinMax: unit -> obj option
            abstract supportsVertexTextures: unit -> obj option
            abstract supportsInstancedArrays: unit -> obj option
            abstract enableScissorTest: boolean: obj option -> obj option

        /// The WebGL renderer displays your beautifully crafted scenes using WebGL, if your device supports it.
        /// This renderer has way better performance than CanvasRenderer.
        type [<AllowNullLiteral>] WebGLRendererStatic =
            /// parameters is an optional object with properties defining the renderer's behaviour. The constructor also accepts no parameters at all. In all cases, it will assume sane defaults when parameters are missing.
            [<Emit "new $0($1...)">] abstract Create: ?parameters: WebGLRendererParameters -> WebGLRenderer

        type [<AllowNullLiteral>] RenderTarget =
            interface end

        type [<AllowNullLiteral>] RenderItem =
            abstract id: float with get, set
            abstract ``object``: Object3D with get, set
            abstract geometry: U2<Geometry, BufferGeometry> with get, set
            abstract material: Material with get, set
            abstract program: WebGLProgram with get, set
            abstract renderOrder: float with get, set
            abstract z: float with get, set
            abstract group: Group with get, set

        type [<AllowNullLiteral>] WebGLRenderList =
            abstract opaque: Array<RenderItem> with get, set
            abstract transparent: Array<obj option> with get, set
            abstract init: unit -> unit
            abstract push: ``object``: Object3D * geometry: U2<Geometry, BufferGeometry> * material: Material * z: float * group: Group -> unit
            abstract sort: unit -> unit

        type [<AllowNullLiteral>] WebGLRenderListStatic =
            [<Emit "new $0($1...)">] abstract Create: unit -> WebGLRenderList

        type [<AllowNullLiteral>] WebGLRenderLists =
            abstract dispose: unit -> unit
            /// returns {<String> : <WebGLRenderList>}
            abstract get: scene: Scene * camera: Camera -> WebGLRenderList

        type [<AllowNullLiteral>] WebGLRenderListsStatic =
            [<Emit "new $0($1...)">] abstract Create: unit -> WebGLRenderLists

        type [<AllowNullLiteral>] WebGLRenderTargetOptions =
            abstract wrapS: Wrapping option with get, set
            abstract wrapT: Wrapping option with get, set
            abstract magFilter: TextureFilter option with get, set
            abstract minFilter: TextureFilter option with get, set
            abstract format: float option with get, set
            abstract ``type``: TextureDataType option with get, set
            abstract anisotropy: float option with get, set
            abstract depthBuffer: bool option with get, set
            abstract stencilBuffer: bool option with get, set
            abstract generateMipmaps: bool option with get, set

        type [<AllowNullLiteral>] WebGLRenderTarget =
            inherit EventDispatcher
            abstract uuid: string with get, set
            abstract width: float with get, set
            abstract height: float with get, set
            abstract scissor: Vector4 with get, set
            abstract scissorTest: bool with get, set
            abstract viewport: Vector4 with get, set
            abstract texture: Texture with get, set
            abstract depthBuffer: bool with get, set
            abstract stencilBuffer: bool with get, set
            abstract depthTexture: Texture with get, set
            abstract wrapS: obj option with get, set
            abstract wrapT: obj option with get, set
            abstract magFilter: obj option with get, set
            abstract minFilter: obj option with get, set
            abstract anisotropy: obj option with get, set
            abstract offset: obj option with get, set
            abstract repeat: obj option with get, set
            abstract format: obj option with get, set
            abstract ``type``: obj option with get, set
            abstract generateMipmaps: obj option with get, set
            abstract setSize: width: float * height: float -> unit
            abstract clone: unit -> WebGLRenderTarget
            abstract copy: source: WebGLRenderTarget -> WebGLRenderTarget
            abstract dispose: unit -> unit

        type [<AllowNullLiteral>] WebGLRenderTargetStatic =
            [<Emit "new $0($1...)">] abstract Create: width: float * height: float * ?options: WebGLRenderTargetOptions -> WebGLRenderTarget

        type [<AllowNullLiteral>] WebGLRenderTargetCube =
            inherit WebGLRenderTarget
            abstract activeCubeFace: float with get, set
            abstract activeMipMapLevel: float with get, set

        type [<AllowNullLiteral>] WebGLRenderTargetCubeStatic =
            [<Emit "new $0($1...)">] abstract Create: width: float * height: float * ?options: WebGLRenderTargetOptions -> WebGLRenderTargetCube

        type [<AllowNullLiteral>] Shader =
            abstract uniforms: obj with get, set
            abstract vertexShader: string with get, set
            abstract fragmentShader: string with get, set

        type [<AllowNullLiteral>] IUniform =
            abstract value: obj option with get, set

        module UniformsUtils =

            type [<AllowNullLiteral>] IExports =
                abstract merge: uniforms: ResizeArray<obj option> -> obj option
                abstract clone: uniforms_src: obj option -> obj option

        type [<AllowNullLiteral>] Uniform =
            abstract ``type``: string with get, set
            abstract value: obj option with get, set
            abstract dynamic: bool with get, set
            abstract onUpdateCallback: Function with get, set
            abstract onUpdate: callback: Function -> Uniform

        type [<AllowNullLiteral>] UniformStatic =
            [<Emit "new $0($1...)">] abstract Create: value: obj option -> Uniform
            [<Emit "new $0($1...)">] abstract Create: ``type``: string * value: obj option -> Uniform

        type [<AllowNullLiteral>] WebGLBufferRenderer =
            abstract setMode: value: obj option -> unit
            abstract render: start: obj option * count: float -> unit
            abstract renderInstances: geometry: obj option -> unit

        type [<AllowNullLiteral>] WebGLBufferRendererStatic =
            [<Emit "new $0($1...)">] abstract Create: _gl: WebGLRenderingContext * extensions: obj option * _infoRender: obj option -> WebGLBufferRenderer

        type [<AllowNullLiteral>] WebGLClipping =
            abstract uniform: obj with get, set
            abstract numPlanes: float with get, set
            abstract init: planes: ResizeArray<obj option> * enableLocalClipping: bool * camera: Camera -> bool
            abstract beginShadows: unit -> unit
            abstract endShadows: unit -> unit
            abstract setState: planes: ResizeArray<obj option> * clipShadows: bool * camera: Camera * cache: bool * fromCache: bool -> unit

        type [<AllowNullLiteral>] WebGLClippingStatic =
            [<Emit "new $0($1...)">] abstract Create: unit -> WebGLClipping

        type [<AllowNullLiteral>] WebGLCapabilitiesParameters =
            abstract precision: obj option with get, set
            abstract logarithmicDepthBuffer: obj option with get, set

        type [<AllowNullLiteral>] WebGLCapabilities =
            abstract precision: obj option with get, set
            abstract logarithmicDepthBuffer: obj option with get, set
            abstract maxTextures: obj option with get, set
            abstract maxVertexTextures: obj option with get, set
            abstract maxTextureSize: obj option with get, set
            abstract maxCubemapSize: obj option with get, set
            abstract maxAttributes: obj option with get, set
            abstract maxVertexUniforms: obj option with get, set
            abstract maxVaryings: obj option with get, set
            abstract maxFragmentUniforms: obj option with get, set
            abstract vertexTextures: obj option with get, set
            abstract floatFragmentTextures: obj option with get, set
            abstract floatVertexTextures: obj option with get, set
            abstract getMaxAnisotropy: unit -> float
            abstract getMaxPrecision: precision: string -> string

        type [<AllowNullLiteral>] WebGLCapabilitiesStatic =
            [<Emit "new $0($1...)">] abstract Create: gl: WebGLRenderingContext * extensions: obj option * parameters: WebGLCapabilitiesParameters -> WebGLCapabilities

        type [<AllowNullLiteral>] WebGLExtensions =
            abstract get: name: string -> obj option

        type [<AllowNullLiteral>] WebGLExtensionsStatic =
            [<Emit "new $0($1...)">] abstract Create: gl: WebGLRenderingContext -> WebGLExtensions

        type [<AllowNullLiteral>] WebGLGeometries =
            abstract get: ``object``: obj option -> obj option

        type [<AllowNullLiteral>] WebGLGeometriesStatic =
            [<Emit "new $0($1...)">] abstract Create: gl: WebGLRenderingContext * extensions: obj option * _infoRender: obj option -> WebGLGeometries

        type [<AllowNullLiteral>] WebGLLights =
            abstract get: light: obj option -> obj option

        type [<AllowNullLiteral>] WebGLLightsStatic =
            [<Emit "new $0($1...)">] abstract Create: gl: WebGLRenderingContext * properties: obj option * info: obj option -> WebGLLights

        /// An object with a series of statistical information about the graphics board memory and the rendering process.
        type [<AllowNullLiteral>] WebGLInfo =
            abstract autoReset: bool with get, set
            abstract memory: obj with get, set
            abstract programs: ResizeArray<WebGLProgram> option with get, set
            abstract render: obj with get, set
            abstract reset: unit -> unit

        /// An object with a series of statistical information about the graphics board memory and the rendering process.
        type [<AllowNullLiteral>] WebGLInfoStatic =
            [<Emit "new $0($1...)">] abstract Create: unit -> WebGLInfo

        type [<AllowNullLiteral>] WebGLIndexedBufferRenderer =
            abstract setMode: value: obj option -> unit
            abstract setIndex: index: obj option -> unit
            abstract render: start: obj option * count: float -> unit
            abstract renderInstances: geometry: obj option * start: obj option * count: float -> unit

        type [<AllowNullLiteral>] WebGLIndexedBufferRendererStatic =
            [<Emit "new $0($1...)">] abstract Create: gl: WebGLRenderingContext * properties: obj option * info: obj option -> WebGLIndexedBufferRenderer

        type [<AllowNullLiteral>] WebGLObjects =
            abstract getAttributeBuffer: attribute: obj option -> obj option
            abstract getWireframeAttribute: geometry: obj option -> obj option
            abstract update: ``object``: obj option -> unit

        type [<AllowNullLiteral>] WebGLObjectsStatic =
            [<Emit "new $0($1...)">] abstract Create: gl: WebGLRenderingContext * properties: obj option * info: obj option -> WebGLObjects

        type [<AllowNullLiteral>] WebGLProgram =
            abstract id: float with get, set
            abstract code: string with get, set
            abstract usedTimes: float with get, set
            abstract program: obj option with get, set
            abstract vertexShader: WebGLShader with get, set
            abstract fragmentShader: WebGLShader with get, set
            abstract uniforms: obj option with get, set
            abstract attributes: obj option with get, set
            abstract getUniforms: unit -> WebGLUniforms
            abstract getAttributes: unit -> obj option
            abstract destroy: unit -> unit

        type [<AllowNullLiteral>] WebGLProgramStatic =
            [<Emit "new $0($1...)">] abstract Create: renderer: WebGLRenderer * code: string * material: ShaderMaterial * parameters: WebGLRendererParameters -> WebGLProgram

        type [<AllowNullLiteral>] WebGLPrograms =
            abstract programs: ResizeArray<WebGLProgram> with get, set
            abstract getParameters: material: ShaderMaterial * lights: obj option * fog: obj option * nClipPlanes: float * ``object``: obj option -> obj option
            abstract getProgramCode: material: ShaderMaterial * parameters: obj option -> string
            abstract acquireProgram: material: ShaderMaterial * parameters: obj option * code: string -> WebGLProgram
            abstract releaseProgram: program: WebGLProgram -> unit

        type [<AllowNullLiteral>] WebGLProgramsStatic =
            [<Emit "new $0($1...)">] abstract Create: renderer: WebGLRenderer * capabilities: obj option -> WebGLPrograms

        type [<AllowNullLiteral>] WebGLTextures =
            abstract setTexture2D: texture: obj option * slot: float -> unit
            abstract setTextureCube: texture: obj option * slot: float -> unit
            abstract setTextureCubeDynamic: texture: obj option * slot: float -> unit
            abstract setupRenderTarget: renderTarget: obj option -> unit
            abstract updateRenderTargetMipmap: renderTarget: obj option -> unit

        type [<AllowNullLiteral>] WebGLTexturesStatic =
            [<Emit "new $0($1...)">] abstract Create: gl: obj option * extensions: obj option * state: obj option * properties: obj option * capabilities: obj option * paramThreeToGL: Function * info: obj option -> WebGLTextures

        type [<AllowNullLiteral>] WebGLUniforms =
            abstract renderer: WebGLRenderer with get, set
            abstract setValue: gl: obj option * value: obj option * ?renderer: obj option -> unit
            abstract set: gl: obj option * ``object``: obj option * name: string -> unit
            abstract setOptional: gl: obj option * ``object``: obj option * name: string -> unit

        type [<AllowNullLiteral>] WebGLUniformsStatic =
            [<Emit "new $0($1...)">] abstract Create: gl: obj option * program: WebGLProgram * renderer: WebGLRenderer -> WebGLUniforms
            abstract upload: gl: obj option * seq: obj option * values: ResizeArray<obj option> * renderer: obj option -> unit
            abstract seqWithValue: seq: obj option * values: ResizeArray<obj option> -> ResizeArray<obj option>
            abstract splitDynamic: seq: obj option * values: ResizeArray<obj option> -> ResizeArray<obj option>
            abstract evalDynamic: seq: obj option * values: ResizeArray<obj option> * ``object``: obj option * camera: obj option -> ResizeArray<obj option>

        type [<AllowNullLiteral>] WebGLProperties =
            abstract get: ``object``: obj option -> obj option
            abstract delete: ``object``: obj option -> unit
            abstract clear: unit -> unit

        type [<AllowNullLiteral>] WebGLPropertiesStatic =
            [<Emit "new $0($1...)">] abstract Create: unit -> WebGLProperties

        type [<AllowNullLiteral>] WebGLShader =
            interface end

        type [<AllowNullLiteral>] WebGLShaderStatic =
            [<Emit "new $0($1...)">] abstract Create: gl: obj option * ``type``: string * string: string -> WebGLShader

        type [<AllowNullLiteral>] WebGLShadowMap =
            abstract enabled: bool with get, set
            abstract autoUpdate: bool with get, set
            abstract needsUpdate: bool with get, set
            abstract ``type``: ShadowMapType with get, set
            abstract render: scene: Scene * camera: Camera -> unit
            abstract cullFace: obj option with get, set

        type [<AllowNullLiteral>] WebGLShadowMapStatic =
            [<Emit "new $0($1...)">] abstract Create: _renderer: Renderer * _lights: ResizeArray<obj option> * _objects: ResizeArray<obj option> * capabilities: obj option -> WebGLShadowMap

        type [<AllowNullLiteral>] WebGLState =
            abstract buffers: obj with get, set
            abstract init: unit -> unit
            abstract initAttributes: unit -> unit
            abstract enableAttribute: attribute: string -> unit
            abstract enableAttributeAndDivisor: attribute: string * meshPerAttribute: obj option * extension: obj option -> unit
            abstract disableUnusedAttributes: unit -> unit
            abstract enable: id: string -> unit
            abstract disable: id: string -> unit
            abstract getCompressedTextureFormats: unit -> ResizeArray<obj option>
            abstract setBlending: blending: float * ?blendEquation: float * ?blendSrc: float * ?blendDst: float * ?blendEquationAlpha: float * ?blendSrcAlpha: float * ?blendDstAlpha: float * ?premultiplyAlpha: bool -> unit
            abstract setColorWrite: colorWrite: float -> unit
            abstract setDepthTest: depthTest: float -> unit
            abstract setDepthWrite: depthWrite: float -> unit
            abstract setDepthFunc: depthFunc: Function -> unit
            abstract setStencilTest: stencilTest: bool -> unit
            abstract setStencilWrite: stencilWrite: obj option -> unit
            abstract setStencilFunc: stencilFunc: Function * stencilRef: obj option * stencilMask: float -> unit
            abstract setStencilOp: stencilFail: obj option * stencilZFail: obj option * stencilZPass: obj option -> unit
            abstract setFlipSided: flipSided: float -> unit
            abstract setCullFace: cullFace: CullFace -> unit
            abstract setLineWidth: width: float -> unit
            abstract setPolygonOffset: polygonoffset: float * factor: float * units: float -> unit
            abstract setScissorTest: scissorTest: bool -> unit
            abstract getScissorTest: unit -> bool
            abstract activeTexture: webglSlot: obj option -> unit
            abstract bindTexture: webglType: obj option * webglTexture: obj option -> unit
            abstract compressedTexImage2D: unit -> unit
            abstract texImage2D: unit -> unit
            abstract clearColor: r: float * g: float * b: float * a: float -> unit
            abstract clearDepth: depth: float -> unit
            abstract clearStencil: stencil: obj option -> unit
            abstract scissor: scissor: obj option -> unit
            abstract viewport: viewport: obj option -> unit
            abstract reset: unit -> unit

        type [<AllowNullLiteral>] WebGLStateStatic =
            [<Emit "new $0($1...)">] abstract Create: gl: obj option * extensions: obj option * paramThreeToGL: Function -> WebGLState

        type [<AllowNullLiteral>] WebGLColorBuffer =
            abstract setMask: colorMask: float -> unit
            abstract setLocked: lock: bool -> unit
            abstract setClear: r: float * g: float * b: float * a: float -> unit
            abstract reset: unit -> unit

        type [<AllowNullLiteral>] WebGLColorBufferStatic =
            [<Emit "new $0($1...)">] abstract Create: gl: obj option * state: obj option -> WebGLColorBuffer

        type [<AllowNullLiteral>] WebGLDepthBuffer =
            abstract setTest: depthTest: bool -> unit
            abstract setMask: depthMask: float -> unit
            abstract setFunc: depthFunc: float -> unit
            abstract setLocked: lock: bool -> unit
            abstract setClear: depth: obj option -> unit
            abstract reset: unit -> unit

        type [<AllowNullLiteral>] WebGLDepthBufferStatic =
            [<Emit "new $0($1...)">] abstract Create: gl: obj option * state: obj option -> WebGLDepthBuffer

        type [<AllowNullLiteral>] WebGLStencilBuffer =
            abstract setTest: stencilTest: bool -> unit
            abstract setMask: stencilMask: float -> unit
            abstract setFunc: stencilFunc: float * stencilRef: obj option * stencilMask: float -> unit
            abstract setOp: stencilFail: obj option * stencilZFail: obj option * stencilZPass: obj option -> unit
            abstract setLocked: lock: bool -> unit
            abstract setClear: stencil: obj option -> unit
            abstract reset: unit -> unit

        type [<AllowNullLiteral>] WebGLStencilBufferStatic =
            [<Emit "new $0($1...)">] abstract Create: gl: obj option * state: obj option -> WebGLStencilBuffer

        type [<AllowNullLiteral>] SpritePlugin =
            abstract render: scene: Scene * camera: Camera * viewportWidth: float * viewportHeight: float -> unit

        type [<AllowNullLiteral>] SpritePluginStatic =
            [<Emit "new $0($1...)">] abstract Create: renderer: WebGLRenderer * sprites: ResizeArray<obj option> -> SpritePlugin

        /// Scenes allow you to set up what and where is to be rendered by three.js. This is where you place objects, lights and cameras.
        type [<AllowNullLiteral>] Scene =
            inherit Object3D
            abstract ``type``: string with get, set
            /// A fog instance defining the type of fog that affects everything rendered in the scene. Default is null.
            abstract fog: IFog option with get, set
            /// If not null, it will force everything in the scene to be rendered with that material. Default is null.
            abstract overrideMaterial: Material option with get, set
            abstract autoUpdate: bool with get, set
            abstract background: U2<Color, Texture> option with get, set
            abstract copy: source: Scene * ?recursive: bool -> Scene
            abstract toJSON: ?meta: obj option -> obj option

        /// Scenes allow you to set up what and where is to be rendered by three.js. This is where you place objects, lights and cameras.
        type [<AllowNullLiteral>] SceneStatic =
            [<Emit "new $0($1...)">] abstract Create: unit -> Scene

        type [<AllowNullLiteral>] IFog =
            abstract name: string with get, set
            abstract color: Color with get, set
            abstract clone: unit -> IFog
            abstract toJSON: unit -> obj option

        /// This class contains the parameters that define linear fog, i.e., that grows linearly denser with the distance.
        type [<AllowNullLiteral>] Fog =
            inherit IFog
            abstract name: string with get, set
            /// Fog color.
            abstract color: Color with get, set
            /// The minimum distance to start applying fog. Objects that are less than 'near' units from the active camera won't be affected by fog.
            abstract near: float with get, set
            /// The maximum distance at which fog stops being calculated and applied. Objects that are more than 'far' units away from the active camera won't be affected by fog.
            /// Default is 1000.
            abstract far: float with get, set
            abstract clone: unit -> Fog
            abstract toJSON: unit -> obj option

        /// This class contains the parameters that define linear fog, i.e., that grows linearly denser with the distance.
        type [<AllowNullLiteral>] FogStatic =
            [<Emit "new $0($1...)">] abstract Create: hex: float * ?near: float * ?far: float -> Fog

        /// This class contains the parameters that define linear fog, i.e., that grows exponentially denser with the distance.
        type [<AllowNullLiteral>] FogExp2 =
            inherit IFog
            abstract name: string with get, set
            abstract color: Color with get, set
            /// Defines how fast the fog will grow dense.
            /// Default is 0.00025.
            abstract density: float with get, set
            abstract clone: unit -> FogExp2
            abstract toJSON: unit -> obj option

        /// This class contains the parameters that define linear fog, i.e., that grows exponentially denser with the distance.
        type [<AllowNullLiteral>] FogExp2Static =
            [<Emit "new $0($1...)">] abstract Create: hex: U2<float, string> * ?density: float -> FogExp2

        type [<AllowNullLiteral>] Texture =
            inherit EventDispatcher
            abstract id: float with get, set
            abstract uuid: string with get, set
            abstract name: string with get, set
            abstract sourceFile: string with get, set
            abstract image: obj option with get, set
            abstract mipmaps: ResizeArray<ImageData> with get, set
            abstract mapping: Mapping with get, set
            abstract wrapS: Wrapping with get, set
            abstract wrapT: Wrapping with get, set
            abstract magFilter: TextureFilter with get, set
            abstract minFilter: TextureFilter with get, set
            abstract anisotropy: float with get, set
            abstract format: PixelFormat with get, set
            abstract ``type``: TextureDataType with get, set
            abstract offset: Vector2 with get, set
            abstract repeat: Vector2 with get, set
            abstract center: Vector2 with get, set
            abstract rotation: float with get, set
            abstract generateMipmaps: bool with get, set
            abstract premultiplyAlpha: bool with get, set
            abstract flipY: bool with get, set
            abstract unpackAlignment: float with get, set
            abstract encoding: TextureEncoding with get, set
            abstract version: float with get, set
            abstract needsUpdate: bool with get, set
            abstract onUpdate: (unit -> unit) with get, set
            abstract DEFAULT_IMAGE: obj option with get, set
            abstract DEFAULT_MAPPING: obj option with get, set
            abstract clone: unit -> Texture
            abstract copy: source: Texture -> Texture
            abstract toJSON: meta: obj option -> obj option
            abstract dispose: unit -> unit
            abstract transformUv: uv: Vector -> unit

        type [<AllowNullLiteral>] TextureStatic =
            [<Emit "new $0($1...)">] abstract Create: ?image: U3<HTMLImageElement, HTMLCanvasElement, HTMLVideoElement> * ?mapping: Mapping * ?wrapS: Wrapping * ?wrapT: Wrapping * ?magFilter: TextureFilter * ?minFilter: TextureFilter * ?format: PixelFormat * ?``type``: TextureDataType * ?anisotropy: float * ?encoding: TextureEncoding -> Texture

        type [<AllowNullLiteral>] DepthTexture =
            inherit Texture
            abstract image: obj with get, set

        type [<AllowNullLiteral>] DepthTextureStatic =
            [<Emit "new $0($1...)">] abstract Create: width: float * heighht: float * ?``type``: TextureDataType * ?mapping: Mapping * ?wrapS: Wrapping * ?wrapT: Wrapping * ?magFilter: TextureFilter * ?minFilter: TextureFilter * ?anisotropy: float -> DepthTexture

        type [<AllowNullLiteral>] CanvasTexture =
            inherit Texture

        type [<AllowNullLiteral>] CanvasTextureStatic =
            [<Emit "new $0($1...)">] abstract Create: canvas: U3<HTMLImageElement, HTMLCanvasElement, HTMLVideoElement> * ?mapping: Mapping * ?wrapS: Wrapping * ?wrapT: Wrapping * ?magFilter: TextureFilter * ?minFilter: TextureFilter * ?format: PixelFormat * ?``type``: TextureDataType * ?anisotropy: float -> CanvasTexture

        type [<AllowNullLiteral>] CubeTexture =
            inherit Texture
            abstract images: obj option with get, set

        type [<AllowNullLiteral>] CubeTextureStatic =
            [<Emit "new $0($1...)">] abstract Create: ?images: ResizeArray<obj option> * ?mapping: Mapping * ?wrapS: Wrapping * ?wrapT: Wrapping * ?magFilter: TextureFilter * ?minFilter: TextureFilter * ?format: PixelFormat * ?``type``: TextureDataType * ?anisotropy: float * ?encoding: TextureEncoding -> CubeTexture

        type [<AllowNullLiteral>] CompressedTexture =
            inherit Texture
            abstract image: obj with get, set

        type [<AllowNullLiteral>] CompressedTextureStatic =
            [<Emit "new $0($1...)">] abstract Create: mipmaps: ResizeArray<ImageData> * width: float * height: float * ?format: PixelFormat * ?``type``: TextureDataType * ?mapping: Mapping * ?wrapS: Wrapping * ?wrapT: Wrapping * ?magFilter: TextureFilter * ?minFilter: TextureFilter * ?anisotropy: float * ?encoding: TextureEncoding -> CompressedTexture

        type [<AllowNullLiteral>] DataTexture =
            inherit Texture
            abstract image: ImageData with get, set

        type [<AllowNullLiteral>] DataTextureStatic =
            [<Emit "new $0($1...)">] abstract Create: data: U2<ArrayBuffer, TypedArray> * width: float * height: float * ?format: PixelFormat * ?``type``: TextureDataType * ?mapping: Mapping * ?wrapS: Wrapping * ?wrapT: Wrapping * ?magFilter: TextureFilter * ?minFilter: TextureFilter * ?anisotropy: float * ?encoding: TextureEncoding -> DataTexture

        type [<AllowNullLiteral>] VideoTexture =
            inherit Texture

        type [<AllowNullLiteral>] VideoTextureStatic =
            [<Emit "new $0($1...)">] abstract Create: video: HTMLVideoElement * ?mapping: Mapping * ?wrapS: Wrapping * ?wrapT: Wrapping * ?magFilter: TextureFilter * ?minFilter: TextureFilter * ?format: PixelFormat * ?``type``: TextureDataType * ?anisotropy: float -> VideoTexture

        module ImageUtils =

            type [<AllowNullLiteral>] IExports =
                abstract crossOrigin: string
                abstract loadTexture: url: string * ?mapping: Mapping * ?onLoad: (Texture -> unit) * ?onError: (string -> unit) -> Texture
                abstract loadTextureCube: array: ResizeArray<string> * ?mapping: Mapping * ?onLoad: (Texture -> unit) * ?onError: (string -> unit) -> Texture

        module SceneUtils =

            type [<AllowNullLiteral>] IExports =
                abstract createMultiMaterialObject: geometry: Geometry * materials: ResizeArray<Material> -> Object3D
                abstract detach: child: Object3D * parent: Object3D * scene: Scene -> unit
                abstract attach: child: Object3D * scene: Scene * parent: Object3D -> unit

        type [<AllowNullLiteral>] Vec2 =
            abstract x: float with get, set
            abstract y: float with get, set

        module ShapeUtils =

            type [<AllowNullLiteral>] IExports =
                abstract area: contour: ResizeArray<Vec2> -> float
                abstract triangulate: contour: ResizeArray<Vec2> * indices: bool -> ResizeArray<float>
                abstract triangulateShape: contour: ResizeArray<Vec2> * holes: ResizeArray<Vec2> -> ResizeArray<ResizeArray<float>>
                abstract isClockWise: pts: ResizeArray<Vec2> -> bool

        type [<AllowNullLiteral>] Audio =
            inherit Object3D
            abstract ``type``: string with get, set
            abstract context: AudioContext with get, set
            abstract gain: GainNode with get, set
            abstract autoplay: bool with get, set
            abstract buffer: Audio option with get, set
            abstract loop: bool with get, set
            abstract startTime: float with get, set
            abstract offset: float with get, set
            abstract playbackRate: float with get, set
            abstract isPlaying: bool with get, set
            abstract hasPlaybackControl: bool with get, set
            abstract sourceType: string with get, set
            abstract source: AudioBufferSourceNode with get, set
            abstract filters: ResizeArray<obj option> with get, set
            abstract getOutput: unit -> GainNode
            abstract setNodeSource: audioNode: AudioBufferSourceNode -> Audio
            abstract setMediaElementSource: mediaElement: MediaElementAudioSourceNode -> Audio
            abstract setBuffer: audioBuffer: AudioBuffer -> Audio
            abstract play: unit -> Audio
            abstract onEnded: unit -> unit
            abstract pause: unit -> Audio
            abstract stop: unit -> Audio
            abstract connect: unit -> Audio
            abstract disconnect: unit -> Audio
            abstract getFilters: unit -> ResizeArray<obj option>
            abstract setFilter: value: ResizeArray<obj option> -> Audio
            abstract getFilter: unit -> obj option
            abstract setFilter: filter: obj option -> Audio
            abstract setPlaybackRate: value: float -> Audio
            abstract getPlaybackRate: unit -> float
            abstract getLoop: unit -> bool
            abstract setLoop: value: bool -> unit
            abstract getVolume: unit -> float
            abstract setVolume: value: float -> Audio
            abstract load: file: string -> Audio

        type [<AllowNullLiteral>] AudioStatic =
            [<Emit "new $0($1...)">] abstract Create: listener: AudioListener -> Audio

        type [<AllowNullLiteral>] AudioAnalyser =
            abstract analyser: obj option with get, set
            abstract data: Uint8Array with get, set
            abstract getFrequencyData: unit -> Uint8Array
            abstract getAverageFrequency: unit -> float
            abstract getData: file: obj option -> obj option

        type [<AllowNullLiteral>] AudioAnalyserStatic =
            [<Emit "new $0($1...)">] abstract Create: audio: obj option * fftSize: float -> AudioAnalyser

        type [<AllowNullLiteral>] AudioBuffer =
            abstract context: obj option with get, set
            abstract ready: bool with get, set
            abstract readyCallbacks: ResizeArray<Function> with get, set
            abstract load: file: string -> AudioBuffer
            abstract onReady: callback: Function -> unit

        type [<AllowNullLiteral>] AudioBufferStatic =
            [<Emit "new $0($1...)">] abstract Create: context: obj option -> AudioBuffer

        type [<AllowNullLiteral>] PositionalAudio =
            inherit Audio
            abstract panner: PannerNode with get, set
            abstract setRefDistance: value: float -> unit
            abstract getRefDistance: unit -> float
            abstract setRolloffFactor: value: float -> unit
            abstract getRolloffFactor: unit -> float
            abstract setDistanceModel: value: float -> unit
            abstract getDistanceModel: unit -> float
            abstract setMaxDistance: value: float -> unit
            abstract getMaxDistance: unit -> float

        type [<AllowNullLiteral>] PositionalAudioStatic =
            [<Emit "new $0($1...)">] abstract Create: listener: AudioListener -> PositionalAudio

        type [<AllowNullLiteral>] AudioListener =
            inherit Object3D
            abstract ``type``: string with get, set
            abstract context: AudioContext with get, set
            abstract gain: GainNode with get, set
            abstract filter: obj option option with get, set
            abstract getInput: unit -> GainNode
            abstract removeFilter: unit -> unit
            abstract setFilter: value: obj option -> unit
            abstract getFilter: unit -> obj option
            abstract setMasterVolume: value: float -> unit
            abstract getMasterVolume: unit -> float
            abstract updateMatrixWorld: ?force: bool -> unit

        type [<AllowNullLiteral>] AudioListenerStatic =
            [<Emit "new $0($1...)">] abstract Create: unit -> AudioListener

        /// An extensible curve object which contains methods for interpolation
        /// class Curve&lt;T extends Vector&gt;
        type [<AllowNullLiteral>] Curve<'T> =
            /// This value determines the amount of divisions when calculating the cumulative segment lengths of a curve via .getLengths.
            /// To ensure precision when using methods like .getSpacedPoints, it is recommended to increase .arcLengthDivisions if the curve is very large.
            /// Default is 200.
            abstract arcLengthDivisions: float with get, set
            /// Returns a vector for point t of the curve where t is between 0 and 1
            /// getPoint(t: number): T;
            abstract getPoint: t: float * ?optionalTarget: 'T -> 'T
            /// Returns a vector for point at relative position in curve according to arc length
            /// getPointAt(u: number): T;
            abstract getPointAt: u: float * ?optionalTarget: 'T -> 'T
            /// Get sequence of points using getPoint( t )
            /// getPoints(divisions?: number): T[];
            abstract getPoints: ?divisions: float -> ResizeArray<'T>
            /// Get sequence of equi-spaced points using getPointAt( u )
            /// getSpacedPoints(divisions?: number): T[];
            abstract getSpacedPoints: ?divisions: float -> ResizeArray<'T>
            /// Get total curve arc length
            abstract getLength: unit -> float
            /// Get list of cumulative segment lengths
            abstract getLengths: ?divisions: float -> ResizeArray<float>
            /// Update the cumlative segment distance cache
            abstract updateArcLengths: unit -> unit
            /// Given u ( 0 .. 1 ), get a t to find p. This gives you points which are equi distance
            abstract getUtoTmapping: u: float * distance: float -> float
            /// Returns a unit vector tangent at t. If the subclassed curve do not implement its tangent derivation, 2 points a small delta apart will be used to find its gradient which seems to give a reasonable approximation
            /// getTangent(t: number): T;
            abstract getTangent: t: float -> 'T
            /// Returns tangent at equidistance point u on the curve
            /// getTangentAt(u: number): T;
            abstract getTangentAt: u: float -> 'T

        /// An extensible curve object which contains methods for interpolation
        /// class Curve&lt;T extends Vector&gt;
        type [<AllowNullLiteral>] CurveStatic =
            [<Emit "new $0($1...)">] abstract Create: unit -> Curve<'T>
            abstract create: constructorFunc: Function * getPointFunc: Function -> Function

        type [<AllowNullLiteral>] CurvePath<'T> =
            inherit Curve<'T>
            abstract curves: ResizeArray<Curve<'T>> with get, set
            abstract autoClose: bool with get, set
            abstract add: curve: Curve<'T> -> unit
            abstract checkConnection: unit -> bool
            abstract closePath: unit -> unit
            abstract getPoint: t: float -> 'T
            abstract getLength: unit -> float
            abstract updateArcLengths: unit -> unit
            abstract getCurveLengths: unit -> ResizeArray<float>
            abstract getSpacedPoints: ?divisions: float -> ResizeArray<'T>
            abstract getPoints: ?divisions: float -> ResizeArray<'T>
            abstract createPointsGeometry: divisions: float -> Geometry
            abstract createSpacedPointsGeometry: divisions: float -> Geometry
            abstract createGeometry: points: ResizeArray<'T> -> Geometry

        type [<AllowNullLiteral>] CurvePathStatic =
            [<Emit "new $0($1...)">] abstract Create: unit -> CurvePath<'T>

        type PathActions =
            obj

        type [<AllowNullLiteral>] PathAction =
            abstract action: PathActions with get, set
            abstract args: obj option with get, set

        /// a 2d path representation, comprising of points, lines, and cubes, similar to the html5 2d canvas api. It extends CurvePath.
        type [<AllowNullLiteral>] Path =
            inherit CurvePath<Vector2>
            abstract currentPoint: Vector2 with get, set
            abstract fromPoints: vectors: ResizeArray<Vector2> -> unit
            abstract setFromPoints: vectors: ResizeArray<Vector2> -> unit
            abstract moveTo: x: float * y: float -> unit
            abstract lineTo: x: float * y: float -> unit
            abstract quadraticCurveTo: aCPx: float * aCPy: float * aX: float * aY: float -> unit
            abstract bezierCurveTo: aCP1x: float * aCP1y: float * aCP2x: float * aCP2y: float * aX: float * aY: float -> unit
            abstract splineThru: pts: ResizeArray<Vector2> -> unit
            abstract arc: aX: float * aY: float * aRadius: float * aStartAngle: float * aEndAngle: float * aClockwise: bool -> unit
            abstract absarc: aX: float * aY: float * aRadius: float * aStartAngle: float * aEndAngle: float * aClockwise: bool -> unit
            abstract ellipse: aX: float * aY: float * xRadius: float * yRadius: float * aStartAngle: float * aEndAngle: float * aClockwise: bool * aRotation: float -> unit
            abstract absellipse: aX: float * aY: float * xRadius: float * yRadius: float * aStartAngle: float * aEndAngle: float * aClockwise: bool * aRotation: float -> unit

        /// a 2d path representation, comprising of points, lines, and cubes, similar to the html5 2d canvas api. It extends CurvePath.
        type [<AllowNullLiteral>] PathStatic =
            [<Emit "new $0($1...)">] abstract Create: ?points: ResizeArray<Vector2> -> Path

        type [<AllowNullLiteral>] ShapePath =
            abstract subPaths: ResizeArray<obj option> with get, set
            abstract currentPath: obj option with get, set
            abstract moveTo: x: float * y: float -> unit
            abstract lineTo: x: float * y: float -> unit
            abstract quadraticCurveTo: aCPx: float * aCPy: float * aX: float * aY: float -> unit
            abstract bezierCurveTo: aCP1x: float * aCP1y: float * aCP2x: float * aCP2y: float * aX: float * aY: float -> unit
            abstract splineThru: pts: ResizeArray<Vector2> -> unit
            abstract toShapes: isCCW: bool * noHoles: obj option -> ResizeArray<Shape>

        type [<AllowNullLiteral>] ShapePathStatic =
            [<Emit "new $0($1...)">] abstract Create: unit -> ShapePath

        /// Defines a 2d shape plane using paths.
        type [<AllowNullLiteral>] Shape =
            inherit Path
            abstract holes: ResizeArray<Path> with get, set
            abstract extrude: ?options: obj option -> ExtrudeGeometry
            abstract makeGeometry: ?options: obj option -> ShapeGeometry
            abstract getPointsHoles: divisions: float -> ResizeArray<ResizeArray<Vector2>>
            abstract extractAllPoints: divisions: float -> obj
            abstract extractPoints: divisions: float -> ResizeArray<Vector2>

        /// Defines a 2d shape plane using paths.
        type [<AllowNullLiteral>] ShapeStatic =
            [<Emit "new $0($1...)">] abstract Create: ?points: ResizeArray<Vector2> -> Shape

        module CurveUtils =

            type [<AllowNullLiteral>] IExports =
                abstract tangentQuadraticBezier: t: float * p0: float * p1: float * p2: float -> float
                abstract tangentCubicBezier: t: float * p0: float * p1: float * p2: float * p3: float -> float
                abstract tangentSpline: t: float * p0: float * p1: float * p2: float * p3: float -> float
                abstract interpolate: p0: float * p1: float * p2: float * p3: float * t: float -> float

        type [<AllowNullLiteral>] CatmullRomCurve3 =
            inherit Curve<Vector3>
            abstract points: ResizeArray<Vector3> with get, set
            abstract getPoint: t: float -> Vector3

        type [<AllowNullLiteral>] CatmullRomCurve3Static =
            [<Emit "new $0($1...)">] abstract Create: ?points: ResizeArray<Vector3> * ?closed: bool * ?curveType: string * ?tension: float -> CatmullRomCurve3

        type [<AllowNullLiteral>] CubicBezierCurve =
            inherit Curve<Vector2>
            abstract v0: Vector2 with get, set
            abstract v1: Vector2 with get, set
            abstract v2: Vector2 with get, set
            abstract v3: Vector2 with get, set

        type [<AllowNullLiteral>] CubicBezierCurveStatic =
            [<Emit "new $0($1...)">] abstract Create: v0: Vector2 * v1: Vector2 * v2: Vector2 * v3: Vector2 -> CubicBezierCurve

        type [<AllowNullLiteral>] CubicBezierCurve3 =
            inherit Curve<Vector3>
            abstract v0: Vector3 with get, set
            abstract v1: Vector3 with get, set
            abstract v2: Vector3 with get, set
            abstract v3: Vector3 with get, set
            abstract getPoint: t: float -> Vector3

        type [<AllowNullLiteral>] CubicBezierCurve3Static =
            [<Emit "new $0($1...)">] abstract Create: v0: Vector3 * v1: Vector3 * v2: Vector3 * v3: Vector3 -> CubicBezierCurve3

        type [<AllowNullLiteral>] EllipseCurve =
            inherit Curve<Vector2>
            abstract aX: float with get, set
            abstract aY: float with get, set
            abstract xRadius: float with get, set
            abstract yRadius: float with get, set
            abstract aStartAngle: float with get, set
            abstract aEndAngle: float with get, set
            abstract aClockwise: bool with get, set
            abstract aRotation: float with get, set

        type [<AllowNullLiteral>] EllipseCurveStatic =
            [<Emit "new $0($1...)">] abstract Create: aX: float * aY: float * xRadius: float * yRadius: float * aStartAngle: float * aEndAngle: float * aClockwise: bool * aRotation: float -> EllipseCurve

        type [<AllowNullLiteral>] ArcCurve =
            inherit EllipseCurve

        type [<AllowNullLiteral>] ArcCurveStatic =
            [<Emit "new $0($1...)">] abstract Create: aX: float * aY: float * aRadius: float * aStartAngle: float * aEndAngle: float * aClockwise: bool -> ArcCurve

        type [<AllowNullLiteral>] LineCurve =
            inherit Curve<Vector2>
            abstract v1: Vector2 with get, set
            abstract v2: Vector2 with get, set

        type [<AllowNullLiteral>] LineCurveStatic =
            [<Emit "new $0($1...)">] abstract Create: v1: Vector2 * v2: Vector2 -> LineCurve

        type [<AllowNullLiteral>] LineCurve3 =
            inherit Curve<Vector3>
            abstract v1: Vector3 with get, set
            abstract v2: Vector3 with get, set
            abstract getPoint: t: float -> Vector3

        type [<AllowNullLiteral>] LineCurve3Static =
            [<Emit "new $0($1...)">] abstract Create: v1: Vector3 * v2: Vector3 -> LineCurve3

        type [<AllowNullLiteral>] QuadraticBezierCurve =
            inherit Curve<Vector2>
            abstract v0: Vector2 with get, set
            abstract v1: Vector2 with get, set
            abstract v2: Vector2 with get, set

        type [<AllowNullLiteral>] QuadraticBezierCurveStatic =
            [<Emit "new $0($1...)">] abstract Create: v0: Vector2 * v1: Vector2 * v2: Vector2 -> QuadraticBezierCurve

        type [<AllowNullLiteral>] QuadraticBezierCurve3 =
            inherit Curve<Vector3>
            abstract v0: Vector3 with get, set
            abstract v1: Vector3 with get, set
            abstract v2: Vector3 with get, set
            abstract getPoint: t: float -> Vector3

        type [<AllowNullLiteral>] QuadraticBezierCurve3Static =
            [<Emit "new $0($1...)">] abstract Create: v0: Vector3 * v1: Vector3 * v2: Vector3 -> QuadraticBezierCurve3

        type [<AllowNullLiteral>] SplineCurve =
            inherit Curve<Vector2>
            abstract points: ResizeArray<Vector2> with get, set

        type [<AllowNullLiteral>] SplineCurveStatic =
            [<Emit "new $0($1...)">] abstract Create: ?points: ResizeArray<Vector2> -> SplineCurve

        type [<AllowNullLiteral>] BoxBufferGeometry =
            inherit BufferGeometry
            abstract parameters: obj with get, set

        type [<AllowNullLiteral>] BoxBufferGeometryStatic =
            [<Emit "new $0($1...)">] abstract Create: ?width: float * ?height: float * ?depth: float * ?widthSegments: float * ?heightSegments: float * ?depthSegments: float -> BoxBufferGeometry

        /// BoxGeometry is the quadrilateral primitive geometry class. It is typically used for creating a cube or irregular quadrilateral of the dimensions provided within the (optional) 'width', 'height', & 'depth' constructor arguments.
        type [<AllowNullLiteral>] BoxGeometry =
            inherit Geometry
            abstract parameters: obj with get, set

        /// BoxGeometry is the quadrilateral primitive geometry class. It is typically used for creating a cube or irregular quadrilateral of the dimensions provided within the (optional) 'width', 'height', & 'depth' constructor arguments.
        type [<AllowNullLiteral>] BoxGeometryStatic =
            /// <param name="width">— Width of the sides on the X axis.</param>
            /// <param name="height">— Height of the sides on the Y axis.</param>
            /// <param name="depth">— Depth of the sides on the Z axis.</param>
            /// <param name="widthSegments">— Number of segmented faces along the width of the sides.</param>
            /// <param name="heightSegments">— Number of segmented faces along the height of the sides.</param>
            /// <param name="depthSegments">— Number of segmented faces along the depth of the sides.</param>
            [<Emit "new $0($1...)">] abstract Create: ?width: float * ?height: float * ?depth: float * ?widthSegments: float * ?heightSegments: float * ?depthSegments: float -> BoxGeometry

        type [<AllowNullLiteral>] CubeGeometry =
            inherit BoxGeometry

        type [<AllowNullLiteral>] CubeGeometryStatic =
            [<Emit "new $0($1...)">] abstract Create: unit -> CubeGeometry

        type [<AllowNullLiteral>] CircleBufferGeometry =
            inherit BufferGeometry
            abstract parameters: obj with get, set

        type [<AllowNullLiteral>] CircleBufferGeometryStatic =
            [<Emit "new $0($1...)">] abstract Create: ?radius: float * ?segments: float * ?thetaStart: float * ?thetaLength: float -> CircleBufferGeometry

        type [<AllowNullLiteral>] CircleGeometry =
            inherit Geometry
            abstract parameters: obj with get, set

        type [<AllowNullLiteral>] CircleGeometryStatic =
            [<Emit "new $0($1...)">] abstract Create: ?radius: float * ?segments: float * ?thetaStart: float * ?thetaLength: float -> CircleGeometry

        type [<AllowNullLiteral>] CylinderBufferGeometry =
            inherit BufferGeometry
            abstract parameters: obj with get, set

        type [<AllowNullLiteral>] CylinderBufferGeometryStatic =
            [<Emit "new $0($1...)">] abstract Create: ?radiusTop: float * ?radiusBottom: float * ?height: float * ?radialSegments: float * ?heightSegments: float * ?openEnded: bool * ?thetaStart: float * ?thetaLength: float -> CylinderBufferGeometry

        type [<AllowNullLiteral>] CylinderGeometry =
            inherit Geometry
            abstract parameters: obj with get, set

        type [<AllowNullLiteral>] CylinderGeometryStatic =
            /// <param name="radiusTop">— Radius of the cylinder at the top.</param>
            /// <param name="radiusBottom">— Radius of the cylinder at the bottom.</param>
            /// <param name="height">— Height of the cylinder.</param>
            /// <param name="radiusSegments">— Number of segmented faces around the circumference of the cylinder.</param>
            /// <param name="heightSegments">— Number of rows of faces along the height of the cylinder.</param>
            /// <param name="openEnded">- A Boolean indicating whether or not to cap the ends of the cylinder.</param>
            [<Emit "new $0($1...)">] abstract Create: ?radiusTop: float * ?radiusBottom: float * ?height: float * ?radiusSegments: float * ?heightSegments: float * ?openEnded: bool * ?thetaStart: float * ?thetaLength: float -> CylinderGeometry

        type [<AllowNullLiteral>] ConeBufferGeometry =
            inherit BufferGeometry

        type [<AllowNullLiteral>] ConeBufferGeometryStatic =
            [<Emit "new $0($1...)">] abstract Create: ?radius: float * ?height: float * ?radialSegment: float * ?heightSegment: float * ?openEnded: bool * ?thetaStart: float * ?thetaLength: float -> ConeBufferGeometry

        type [<AllowNullLiteral>] ConeGeometry =
            inherit CylinderGeometry

        type [<AllowNullLiteral>] ConeGeometryStatic =
            [<Emit "new $0($1...)">] abstract Create: ?radius: float * ?height: float * ?radialSegment: float * ?heightSegment: float * ?openEnded: bool * ?thetaStart: float * ?thetaLength: float -> ConeGeometry

        type [<AllowNullLiteral>] DodecahedronBufferGeometry =
            inherit PolyhedronBufferGeometry

        type [<AllowNullLiteral>] DodecahedronBufferGeometryStatic =
            [<Emit "new $0($1...)">] abstract Create: ?radius: float * ?detail: float -> DodecahedronBufferGeometry

        type [<AllowNullLiteral>] DodecahedronGeometry =
            inherit Geometry
            abstract parameters: obj with get, set

        type [<AllowNullLiteral>] DodecahedronGeometryStatic =
            [<Emit "new $0($1...)">] abstract Create: ?radius: float * ?detail: float -> DodecahedronGeometry

        type [<AllowNullLiteral>] EdgesGeometry =
            inherit BufferGeometry

        type [<AllowNullLiteral>] EdgesGeometryStatic =
            [<Emit "new $0($1...)">] abstract Create: geometry: U2<BufferGeometry, Geometry> * ?thresholdAngle: float -> EdgesGeometry

        type [<AllowNullLiteral>] ExtrudeGeometryOptions =
            abstract curveSegments: float option with get, set
            abstract steps: float option with get, set
            abstract depth: float option with get, set
            abstract bevelEnabled: bool option with get, set
            abstract bevelThickness: float option with get, set
            abstract bevelSize: float option with get, set
            abstract bevelSegments: float option with get, set
            abstract extrudePath: CurvePath<Vector3> option with get, set
            abstract UVGenerator: UVGenerator option with get, set

        type [<AllowNullLiteral>] UVGenerator =
            abstract generateTopUV: geometry: ExtrudeBufferGeometry * vertices: ResizeArray<float> * indexA: float * indexB: float * indexC: float -> ResizeArray<Vector2>
            abstract generateSideWallUV: geometry: ExtrudeBufferGeometry * vertices: ResizeArray<float> * indexA: float * indexB: float * indexC: float * indexD: float -> ResizeArray<Vector2>

        type [<AllowNullLiteral>] ExtrudeGeometry =
            inherit Geometry
            abstract WorldUVGenerator: UVGenerator with get, set
            abstract addShapeList: shapes: ResizeArray<Shape> * ?options: obj option -> unit
            abstract addShape: shape: Shape * ?options: obj option -> unit

        type [<AllowNullLiteral>] ExtrudeGeometryStatic =
            [<Emit "new $0($1...)">] abstract Create: shapes: U2<Shape, ResizeArray<Shape>> * ?options: ExtrudeGeometryOptions -> ExtrudeGeometry

        type [<AllowNullLiteral>] ExtrudeBufferGeometry =
            inherit BufferGeometry
            abstract WorldUVGenerator: UVGenerator with get, set
            abstract addShapeList: shapes: ResizeArray<Shape> * ?options: obj option -> unit
            abstract addShape: shape: Shape * ?options: obj option -> unit

        type [<AllowNullLiteral>] ExtrudeBufferGeometryStatic =
            [<Emit "new $0($1...)">] abstract Create: shapes: U2<Shape, ResizeArray<Shape>> * ?options: ExtrudeGeometryOptions -> ExtrudeBufferGeometry

        type [<AllowNullLiteral>] IcosahedronBufferGeometry =
            inherit PolyhedronBufferGeometry

        type [<AllowNullLiteral>] IcosahedronBufferGeometryStatic =
            [<Emit "new $0($1...)">] abstract Create: ?radius: float * ?detail: float -> IcosahedronBufferGeometry

        type [<AllowNullLiteral>] IcosahedronGeometry =
            inherit PolyhedronGeometry

        type [<AllowNullLiteral>] IcosahedronGeometryStatic =
            [<Emit "new $0($1...)">] abstract Create: ?radius: float * ?detail: float -> IcosahedronGeometry

        type [<AllowNullLiteral>] LatheBufferGeometry =
            inherit BufferGeometry
            abstract parameters: obj with get, set

        type [<AllowNullLiteral>] LatheBufferGeometryStatic =
            [<Emit "new $0($1...)">] abstract Create: points: ResizeArray<Vector2> * ?segments: float * ?phiStart: float * ?phiLength: float -> LatheBufferGeometry

        type [<AllowNullLiteral>] LatheGeometry =
            inherit Geometry
            abstract parameters: obj with get, set

        type [<AllowNullLiteral>] LatheGeometryStatic =
            [<Emit "new $0($1...)">] abstract Create: points: ResizeArray<Vector2> * ?segments: float * ?phiStart: float * ?phiLength: float -> LatheGeometry

        type [<AllowNullLiteral>] OctahedronBufferGeometry =
            inherit PolyhedronBufferGeometry

        type [<AllowNullLiteral>] OctahedronBufferGeometryStatic =
            [<Emit "new $0($1...)">] abstract Create: ?radius: float * ?detail: float -> OctahedronBufferGeometry

        type [<AllowNullLiteral>] OctahedronGeometry =
            inherit PolyhedronGeometry

        type [<AllowNullLiteral>] OctahedronGeometryStatic =
            [<Emit "new $0($1...)">] abstract Create: ?radius: float * ?detail: float -> OctahedronGeometry

        type [<AllowNullLiteral>] ParametricBufferGeometry =
            inherit BufferGeometry
            abstract parameters: obj with get, set

        type [<AllowNullLiteral>] ParametricBufferGeometryStatic =
            [<Emit "new $0($1...)">] abstract Create: func: (float -> float -> Vector3 -> unit) * slices: float * stacks: float -> ParametricBufferGeometry

        type [<AllowNullLiteral>] ParametricGeometry =
            inherit Geometry
            abstract parameters: obj with get, set

        type [<AllowNullLiteral>] ParametricGeometryStatic =
            [<Emit "new $0($1...)">] abstract Create: func: (float -> float -> Vector3 -> unit) * slices: float * stacks: float -> ParametricGeometry

        type [<AllowNullLiteral>] PlaneBufferGeometry =
            inherit BufferGeometry
            abstract parameters: obj with get, set

        type [<AllowNullLiteral>] PlaneBufferGeometryStatic =
            [<Emit "new $0($1...)">] abstract Create: ?width: float * ?height: float * ?widthSegments: float * ?heightSegments: float -> PlaneBufferGeometry

        type [<AllowNullLiteral>] PlaneGeometry =
            inherit Geometry
            abstract parameters: obj with get, set

        type [<AllowNullLiteral>] PlaneGeometryStatic =
            [<Emit "new $0($1...)">] abstract Create: ?width: float * ?height: float * ?widthSegments: float * ?heightSegments: float -> PlaneGeometry

        type [<AllowNullLiteral>] PolyhedronBufferGeometry =
            inherit BufferGeometry
            abstract parameters: obj with get, set

        type [<AllowNullLiteral>] PolyhedronBufferGeometryStatic =
            [<Emit "new $0($1...)">] abstract Create: vertices: ResizeArray<float> * indices: ResizeArray<float> * ?radius: float * ?detail: float -> PolyhedronBufferGeometry

        type [<AllowNullLiteral>] PolyhedronGeometry =
            inherit Geometry
            abstract parameters: obj with get, set
            abstract boundingSphere: Sphere with get, set

        type [<AllowNullLiteral>] PolyhedronGeometryStatic =
            [<Emit "new $0($1...)">] abstract Create: vertices: ResizeArray<float> * indices: ResizeArray<float> * ?radius: float * ?detail: float -> PolyhedronGeometry

        type [<AllowNullLiteral>] RingBufferGeometry =
            inherit BufferGeometry
            abstract parameters: obj with get, set

        type [<AllowNullLiteral>] RingBufferGeometryStatic =
            [<Emit "new $0($1...)">] abstract Create: ?innerRadius: float * ?outerRadius: float * ?thetaSegments: float * ?phiSegments: float * ?thetaStart: float * ?thetaLength: float -> RingBufferGeometry

        type [<AllowNullLiteral>] RingGeometry =
            inherit Geometry
            abstract parameters: obj with get, set

        type [<AllowNullLiteral>] RingGeometryStatic =
            [<Emit "new $0($1...)">] abstract Create: ?innerRadius: float * ?outerRadius: float * ?thetaSegments: float * ?phiSegments: float * ?thetaStart: float * ?thetaLength: float -> RingGeometry

        type [<AllowNullLiteral>] ShapeGeometry =
            inherit Geometry
            abstract addShapeList: shapes: ResizeArray<Shape> * options: obj option -> ShapeGeometry
            abstract addShape: shape: Shape * ?options: obj option -> unit

        type [<AllowNullLiteral>] ShapeGeometryStatic =
            [<Emit "new $0($1...)">] abstract Create: shapes: U2<Shape, ResizeArray<Shape>> * ?curveSegments: float -> ShapeGeometry

        type [<AllowNullLiteral>] ShapeBufferGeometry =
            inherit BufferGeometry

        type [<AllowNullLiteral>] ShapeBufferGeometryStatic =
            [<Emit "new $0($1...)">] abstract Create: shapes: U2<Shape, ResizeArray<Shape>> * ?curveSegments: float -> ShapeBufferGeometry

        type [<AllowNullLiteral>] SphereBufferGeometry =
            inherit BufferGeometry
            abstract parameters: obj with get, set

        type [<AllowNullLiteral>] SphereBufferGeometryStatic =
            [<Emit "new $0($1...)">] abstract Create: ?radius: float * ?widthSegments: float * ?heightSegments: float * ?phiStart: float * ?phiLength: float * ?thetaStart: float * ?thetaLength: float -> SphereBufferGeometry

        /// A class for generating sphere geometries
        type [<AllowNullLiteral>] SphereGeometry =
            inherit Geometry
            abstract parameters: obj with get, set

        /// A class for generating sphere geometries
        type [<AllowNullLiteral>] SphereGeometryStatic =
            /// <summary>The geometry is created by sweeping and calculating vertexes around the Y axis (horizontal sweep) and the Z axis (vertical sweep). Thus, incomplete spheres (akin to 'sphere slices') can be created through the use of different values of phiStart, phiLength, thetaStart and thetaLength, in order to define the points in which we start (or end) calculating those vertices.</summary>
            /// <param name="radius">— sphere radius. Default is 50.</param>
            /// <param name="widthSegments">— number of horizontal segments. Minimum value is 3, and the default is 8.</param>
            /// <param name="heightSegments">— number of vertical segments. Minimum value is 2, and the default is 6.</param>
            /// <param name="phiStart">— specify horizontal starting angle. Default is 0.</param>
            /// <param name="phiLength">— specify horizontal sweep angle size. Default is Math.PI * 2.</param>
            /// <param name="thetaStart">— specify vertical starting angle. Default is 0.</param>
            /// <param name="thetaLength">— specify vertical sweep angle size. Default is Math.PI.</param>
            [<Emit "new $0($1...)">] abstract Create: ?radius: float * ?widthSegments: float * ?heightSegments: float * ?phiStart: float * ?phiLength: float * ?thetaStart: float * ?thetaLength: float -> SphereGeometry

        type [<AllowNullLiteral>] TetrahedronBufferGeometry =
            inherit PolyhedronBufferGeometry

        type [<AllowNullLiteral>] TetrahedronBufferGeometryStatic =
            [<Emit "new $0($1...)">] abstract Create: ?radius: float * ?detail: float -> TetrahedronBufferGeometry

        type [<AllowNullLiteral>] TetrahedronGeometry =
            inherit PolyhedronGeometry

        type [<AllowNullLiteral>] TetrahedronGeometryStatic =
            [<Emit "new $0($1...)">] abstract Create: ?radius: float * ?detail: float -> TetrahedronGeometry

        type [<AllowNullLiteral>] TextGeometryParameters =
            abstract font: Font option with get, set
            abstract size: float option with get, set
            abstract height: float option with get, set
            abstract curveSegments: float option with get, set
            abstract bevelEnabled: bool option with get, set
            abstract bevelThickness: float option with get, set
            abstract bevelSize: float option with get, set
            abstract bevelSegments: float option with get, set

        type [<AllowNullLiteral>] TextGeometry =
            inherit ExtrudeGeometry
            abstract parameters: obj with get, set

        type [<AllowNullLiteral>] TextGeometryStatic =
            [<Emit "new $0($1...)">] abstract Create: text: string * ?parameters: TextGeometryParameters -> TextGeometry

        type [<AllowNullLiteral>] TextBufferGeometry =
            inherit ExtrudeBufferGeometry
            abstract parameters: obj with get, set

        type [<AllowNullLiteral>] TextBufferGeometryStatic =
            [<Emit "new $0($1...)">] abstract Create: text: string * ?parameters: TextGeometryParameters -> TextBufferGeometry

        type [<AllowNullLiteral>] TorusBufferGeometry =
            inherit BufferGeometry
            abstract parameters: obj with get, set

        type [<AllowNullLiteral>] TorusBufferGeometryStatic =
            [<Emit "new $0($1...)">] abstract Create: ?radius: float * ?tube: float * ?radialSegments: float * ?tubularSegments: float * ?arc: float -> TorusBufferGeometry

        type [<AllowNullLiteral>] TorusGeometry =
            inherit Geometry
            abstract parameters: obj with get, set

        type [<AllowNullLiteral>] TorusGeometryStatic =
            [<Emit "new $0($1...)">] abstract Create: ?radius: float * ?tube: float * ?radialSegments: float * ?tubularSegments: float * ?arc: float -> TorusGeometry

        type [<AllowNullLiteral>] TorusKnotBufferGeometry =
            inherit BufferGeometry
            abstract parameters: obj with get, set

        type [<AllowNullLiteral>] TorusKnotBufferGeometryStatic =
            [<Emit "new $0($1...)">] abstract Create: ?radius: float * ?tube: float * ?tubularSegments: float * ?radialSegments: float * ?p: float * ?q: float -> TorusKnotBufferGeometry

        type [<AllowNullLiteral>] TorusKnotGeometry =
            inherit Geometry
            abstract parameters: obj with get, set

        type [<AllowNullLiteral>] TorusKnotGeometryStatic =
            [<Emit "new $0($1...)">] abstract Create: ?radius: float * ?tube: float * ?tubularSegments: float * ?radialSegments: float * ?p: float * ?q: float -> TorusKnotGeometry

        type [<AllowNullLiteral>] TubeGeometry =
            inherit Geometry
            abstract parameters: obj with get, set
            abstract tangents: ResizeArray<Vector3> with get, set
            abstract normals: ResizeArray<Vector3> with get, set
            abstract binormals: ResizeArray<Vector3> with get, set

        type [<AllowNullLiteral>] TubeGeometryStatic =
            [<Emit "new $0($1...)">] abstract Create: path: Curve<Vector3> * ?tubularSegments: float * ?radius: float * ?radiusSegments: float * ?closed: bool -> TubeGeometry

        type [<AllowNullLiteral>] TubeBufferGeometry =
            inherit BufferGeometry
            abstract parameters: obj with get, set
            abstract tangents: ResizeArray<Vector3> with get, set
            abstract normals: ResizeArray<Vector3> with get, set
            abstract binormals: ResizeArray<Vector3> with get, set

        type [<AllowNullLiteral>] TubeBufferGeometryStatic =
            [<Emit "new $0($1...)">] abstract Create: path: Curve<Vector3> * ?tubularSegments: float * ?radius: float * ?radiusSegments: float * ?closed: bool -> TubeBufferGeometry

        type [<AllowNullLiteral>] WireframeGeometry =
            inherit BufferGeometry

        type [<AllowNullLiteral>] WireframeGeometryStatic =
            [<Emit "new $0($1...)">] abstract Create: geometry: U2<Geometry, BufferGeometry> -> WireframeGeometry

        type [<AllowNullLiteral>] ArrowHelper =
            inherit Object3D
            abstract line: Line with get, set
            abstract cone: Mesh with get, set
            abstract setDirection: dir: Vector3 -> unit
            abstract setLength: length: float * ?headLength: float * ?headWidth: float -> unit
            abstract setColor: color: Color -> unit

        type [<AllowNullLiteral>] ArrowHelperStatic =
            [<Emit "new $0($1...)">] abstract Create: dir: Vector3 * ?origin: Vector3 * ?length: float * ?hex: float * ?headLength: float * ?headWidth: float -> ArrowHelper

        type [<AllowNullLiteral>] AxesHelper =
            inherit LineSegments

        type [<AllowNullLiteral>] AxesHelperStatic =
            [<Emit "new $0($1...)">] abstract Create: ?size: float -> AxesHelper

        type [<AllowNullLiteral>] BoundingBoxHelper =
            inherit Mesh
            abstract ``object``: Object3D with get, set
            abstract box: Box3 with get, set
            abstract update: unit -> unit

        type [<AllowNullLiteral>] BoundingBoxHelperStatic =
            [<Emit "new $0($1...)">] abstract Create: ?``object``: Object3D * ?hex: float -> BoundingBoxHelper

        type [<AllowNullLiteral>] BoxHelper =
            inherit LineSegments
            abstract update: ?``object``: Object3D -> unit

        type [<AllowNullLiteral>] BoxHelperStatic =
            [<Emit "new $0($1...)">] abstract Create: ?``object``: Object3D * ?color: Color -> BoxHelper

        type [<AllowNullLiteral>] CameraHelper =
            inherit LineSegments
            abstract camera: Camera with get, set
            abstract pointMap: obj with get, set
            abstract update: unit -> unit

        type [<AllowNullLiteral>] CameraHelperStatic =
            [<Emit "new $0($1...)">] abstract Create: camera: Camera -> CameraHelper

        type [<AllowNullLiteral>] DirectionalLightHelper =
            inherit Object3D
            abstract light: DirectionalLight with get, set
            abstract lightPlane: Line with get, set
            abstract targetPlane: Line with get, set
            abstract color: U3<Color, string, float> option with get, set
            abstract matrix: Matrix4 with get, set
            abstract matrixAutoUpdate: bool with get, set
            abstract dispose: unit -> unit
            abstract update: unit -> unit

        type [<AllowNullLiteral>] DirectionalLightHelperStatic =
            [<Emit "new $0($1...)">] abstract Create: light: DirectionalLight * ?size: float * ?color: U3<Color, string, float> -> DirectionalLightHelper

        type [<AllowNullLiteral>] EdgesHelper =
            inherit LineSegments

        type [<AllowNullLiteral>] EdgesHelperStatic =
            [<Emit "new $0($1...)">] abstract Create: ``object``: Object3D * ?hex: float * ?thresholdAngle: float -> EdgesHelper

        type [<AllowNullLiteral>] FaceNormalsHelper =
            inherit LineSegments
            abstract ``object``: Object3D with get, set
            abstract size: float with get, set
            abstract update: ?``object``: Object3D -> unit

        type [<AllowNullLiteral>] FaceNormalsHelperStatic =
            [<Emit "new $0($1...)">] abstract Create: ``object``: Object3D * ?size: float * ?hex: float * ?linewidth: float -> FaceNormalsHelper

        type [<AllowNullLiteral>] GridHelper =
            inherit LineSegments
            abstract setColors: ?color1: U2<Color, float> * ?color2: U2<Color, float> -> unit

        type [<AllowNullLiteral>] GridHelperStatic =
            [<Emit "new $0($1...)">] abstract Create: size: float * divisions: float * ?color1: U2<Color, float> * ?color2: U2<Color, float> -> GridHelper

        type [<AllowNullLiteral>] HemisphereLightHelper =
            inherit Object3D
            abstract light: HemisphereLight with get, set
            abstract matrix: Matrix4 with get, set
            abstract matrixAutoUpdate: bool with get, set
            abstract material: MeshBasicMaterial with get, set
            abstract color: U3<Color, string, float> option with get, set
            abstract dispose: unit -> unit
            abstract update: unit -> unit

        type [<AllowNullLiteral>] HemisphereLightHelperStatic =
            [<Emit "new $0($1...)">] abstract Create: light: HemisphereLight * size: float * ?color: U3<Color, float, string> -> HemisphereLightHelper

        type [<AllowNullLiteral>] PointLightHelper =
            inherit Object3D
            abstract light: PointLight with get, set
            abstract color: U3<Color, string, float> option with get, set
            abstract matrix: Matrix4 with get, set
            abstract matrixAutoUpdate: bool with get, set
            abstract dispose: unit -> unit
            abstract update: unit -> unit

        type [<AllowNullLiteral>] PointLightHelperStatic =
            [<Emit "new $0($1...)">] abstract Create: light: PointLight * ?sphereSize: float * ?color: U3<Color, string, float> -> PointLightHelper

        type [<AllowNullLiteral>] SkeletonHelper =
            inherit LineSegments
            abstract bones: ResizeArray<Bone> with get, set
            abstract root: Object3D with get, set
            abstract getBoneList: ``object``: Object3D -> ResizeArray<Bone>
            abstract update: unit -> unit

        type [<AllowNullLiteral>] SkeletonHelperStatic =
            [<Emit "new $0($1...)">] abstract Create: bone: Object3D -> SkeletonHelper

        type [<AllowNullLiteral>] SpotLightHelper =
            inherit Object3D
            abstract light: Light with get, set
            abstract matrix: Matrix4 with get, set
            abstract matrixAutoUpdate: bool with get, set
            abstract color: U3<Color, string, float> option with get, set
            abstract dispose: unit -> unit
            abstract update: unit -> unit

        type [<AllowNullLiteral>] SpotLightHelperStatic =
            [<Emit "new $0($1...)">] abstract Create: light: Light * ?color: U3<Color, string, float> -> SpotLightHelper

        type [<AllowNullLiteral>] VertexNormalsHelper =
            inherit LineSegments
            abstract ``object``: Object3D with get, set
            abstract size: float with get, set
            abstract update: ?``object``: Object3D -> unit

        type [<AllowNullLiteral>] VertexNormalsHelperStatic =
            [<Emit "new $0($1...)">] abstract Create: ``object``: Object3D * ?size: float * ?hex: float * ?linewidth: float -> VertexNormalsHelper

        type [<AllowNullLiteral>] PlaneHelper =
            inherit LineSegments
            abstract plane: Plane with get, set
            abstract size: float with get, set
            abstract updateMatrixWorld: force: bool -> unit

        type [<AllowNullLiteral>] PlaneHelperStatic =
            [<Emit "new $0($1...)">] abstract Create: plane: Plane * ?size: float * ?hex: float -> PlaneHelper

        type [<AllowNullLiteral>] WireframeHelper =
            inherit LineSegments

        type [<AllowNullLiteral>] WireframeHelperStatic =
            [<Emit "new $0($1...)">] abstract Create: ``object``: Object3D * ?hex: float -> WireframeHelper

        type [<AllowNullLiteral>] ImmediateRenderObject =
            inherit Object3D
            abstract material: Material with get, set
            abstract render: renderCallback: Function -> unit

        type [<AllowNullLiteral>] ImmediateRenderObjectStatic =
            [<Emit "new $0($1...)">] abstract Create: material: Material -> ImmediateRenderObject

        type [<AllowNullLiteral>] MorphBlendMeshAnimation =
            abstract start: float with get, set
            abstract ``end``: float with get, set
            abstract length: float with get, set
            abstract fps: float with get, set
            abstract duration: float with get, set
            abstract lastFrame: float with get, set
            abstract currentFrame: float with get, set
            abstract active: bool with get, set
            abstract time: float with get, set
            abstract direction: float with get, set
            abstract weight: float with get, set
            abstract directionBackwards: bool with get, set
            abstract mirroredLoop: bool with get, set

        type [<AllowNullLiteral>] MorphBlendMesh =
            inherit Mesh
            abstract animationsMap: obj with get, set
            abstract animationsList: ResizeArray<MorphBlendMeshAnimation> with get, set
            abstract createAnimation: name: string * start: float * ``end``: float * fps: float -> unit
            abstract autoCreateAnimations: fps: float -> unit
            abstract setAnimationDirectionForward: name: string -> unit
            abstract setAnimationDirectionBackward: name: string -> unit
            abstract setAnimationFPS: name: string * fps: float -> unit
            abstract setAnimationDuration: name: string * duration: float -> unit
            abstract setAnimationWeight: name: string * weight: float -> unit
            abstract setAnimationTime: name: string * time: float -> unit
            abstract getAnimationTime: name: string -> float
            abstract getAnimationDuration: name: string -> float
            abstract playAnimation: name: string -> unit
            abstract stopAnimation: name: string -> unit
            abstract update: delta: float -> unit

        type [<AllowNullLiteral>] MorphBlendMeshStatic =
            [<Emit "new $0($1...)">] abstract Create: geometry: Geometry * material: Material -> MorphBlendMesh
        

        type [<AllowNullLiteral>] WebVRManager =
            abstract enabled: bool with get, set
            abstract getDevice: unit -> VRDisplay option
            abstract setDevice: device: VRDisplay option -> unit
            abstract setPoseTarget: ``object``: Object3D option -> unit
            abstract getCamera: camera: PerspectiveCamera -> U2<PerspectiveCamera, ArrayCamera>
            abstract submitFrame: unit -> unit
            abstract dispose: unit -> unit

    module Three_css3drenderer =
        type Camera = Three_core.Camera
        type Object3D = Three_core.Object3D
        type Scene = Three_core.Scene

        type [<AllowNullLiteral>] IExports =
            abstract CSS3DObject: CSS3DObjectStatic
            abstract CSS3DSprite: CSS3DSpriteStatic
            abstract CSS3DRenderer: CSS3DRendererStatic

        type [<AllowNullLiteral>] CSS3DObject =
            inherit Object3D
            abstract element: obj option with get, set

        type [<AllowNullLiteral>] CSS3DObjectStatic =
            [<Emit "new $0($1...)">] abstract Create: element: obj option -> CSS3DObject

        type [<AllowNullLiteral>] CSS3DSprite =
            inherit CSS3DObject

        type [<AllowNullLiteral>] CSS3DSpriteStatic =
            [<Emit "new $0($1...)">] abstract Create: element: obj option -> CSS3DSprite

        type [<AllowNullLiteral>] CSS3DRenderer =
            abstract domElement: HTMLElement with get, set
            abstract setSize: width: float * height: float -> unit
            abstract render: scene: Scene * camera: Camera -> unit

        type [<AllowNullLiteral>] CSS3DRendererStatic =
            [<Emit "new $0($1...)">] abstract Create: unit -> CSS3DRenderer

    module Three_ctmloader =
        type Loader = Three_core.Loader

        type [<AllowNullLiteral>] IExports =
            abstract CTMLoader: CTMLoaderStatic

        type [<AllowNullLiteral>] CTMLoader =
            inherit Loader
            /// <summary>load multiple CTM parts defined in JSON.</summary>
            /// <param name="url">(required)</param>
            /// <param name="callback">(required)</param>
            /// <param name="parameters"></param>
            abstract loadParts: url: string * callback: (unit -> obj option) * ?parameters: obj option -> obj option
            /// <summary>Load CTMLoader compressed models</summary>
            /// <param name="url">(required)</param>
            /// <param name="callback">(required)</param>
            /// <param name="parameters"></param>
            abstract load: url: string * callback: (obj option -> obj option) * ?parameters: obj option -> obj option
            /// <summary>create buffergeometry by ctm file.</summary>
            /// <param name="file">(required)</param>
            /// <param name="callback">(required)</param>
            abstract createModel: file: string * callback: (unit -> obj option) -> obj option

        type [<AllowNullLiteral>] CTMLoaderStatic =
            [<Emit "new $0($1...)">] abstract Create: unit -> CTMLoader

    module Three_ddsloader =
        type CompressedPixelFormat = Three_core.CompressedPixelFormat
        type CompressedTextureLoader = Three_core.CompressedTextureLoader

        type [<AllowNullLiteral>] IExports =
            abstract DDSLoader: DDSLoaderStatic

        type [<AllowNullLiteral>] Dds =
            abstract mipmaps: ResizeArray<ImageData> with get, set
            abstract width: float with get, set
            abstract height: float with get, set
            abstract format: CompressedPixelFormat with get, set
            abstract mipmapCount: float with get, set

        type [<AllowNullLiteral>] DDSLoader =
            inherit CompressedTextureLoader
            abstract parse: buffer: string * loadMipmaps: bool -> Dds

        type [<AllowNullLiteral>] DDSLoaderStatic =
            [<Emit "new $0($1...)">] abstract Create: unit -> DDSLoader

    module Three_dragcontrols =
        type Camera = Three_core.Camera
        type Object3D = Three_core.Object3D

        type [<AllowNullLiteral>] IExports =
            abstract DragControls: DragControlsStatic

        type [<AllowNullLiteral>] DragControls =
            interface end

        type [<AllowNullLiteral>] DragControlsStatic =
            [<Emit "new $0($1...)">] abstract Create: objects: ResizeArray<Object3D> * camera: Camera * ?domElement: HTMLElement -> DragControls

    module Three_editorcontrols =
        type Camera = Three_core.Camera
        type EventDispatcher = Three_core.EventDispatcher
        type Object3D = Three_core.Object3D
        type Vector3 = Three_core.Vector3

        type [<AllowNullLiteral>] IExports =
            abstract EditorControls: EditorControlsStatic

        type [<AllowNullLiteral>] EditorControls =
            inherit EventDispatcher
            abstract enabled: bool with get, set
            abstract center: Vector3 with get, set
            abstract focus: target: Object3D * frame: bool -> unit
            abstract pan: delta: Vector3 -> unit
            abstract zoom: delta: Vector3 -> unit
            abstract rotate: delta: Vector3 -> unit
            abstract dispose: unit -> unit

        type [<AllowNullLiteral>] EditorControlsStatic =
            [<Emit "new $0($1...)">] abstract Create: ``object``: Camera * ?domElement: HTMLElement -> EditorControls

    module Three_effectcomposer =
        type WebGLRenderTarget = Three_core.WebGLRenderTarget
        type WebGLRenderer = Three_core.WebGLRenderer
        type ShaderPass = Three_shaderpass.ShaderPass

        type [<AllowNullLiteral>] IExports =
            abstract EffectComposer: EffectComposerStatic
            abstract Pass: PassStatic

        type [<AllowNullLiteral>] EffectComposer =
            abstract renderTarget1: WebGLRenderTarget with get, set
            abstract renderTarget2: WebGLRenderTarget with get, set
            abstract writeBuffer: WebGLRenderTarget with get, set
            abstract readBuffer: WebGLRenderTarget with get, set
            abstract passes: ResizeArray<Pass> with get, set
            abstract copyPass: ShaderPass with get, set
            abstract swapBuffers: unit -> unit
            abstract addPass: pass: obj option -> unit
            abstract insertPass: pass: obj option * index: float -> unit
            abstract render: ?delta: float -> unit
            abstract reset: ?renderTarget: WebGLRenderTarget -> unit
            abstract setSize: width: float * height: float -> unit

        type [<AllowNullLiteral>] EffectComposerStatic =
            [<Emit "new $0($1...)">] abstract Create: renderer: WebGLRenderer * ?renderTarget: WebGLRenderTarget -> EffectComposer

        type [<AllowNullLiteral>] Pass =
            abstract enabled: bool with get, set
            abstract needsSwap: bool with get, set
            abstract clear: bool with get, set
            abstract renderToScreen: bool with get, set
            abstract setSize: width: float * height: float -> unit
            abstract render: renderer: WebGLRenderer * writeBuffer: WebGLRenderTarget * readBuffer: WebGLRenderTarget * delta: float * ?maskActive: bool -> unit

        type [<AllowNullLiteral>] PassStatic =
            [<Emit "new $0($1...)">] abstract Create: unit -> Pass

    module Three_examples =
        type EventDispatcher = Three_core.EventDispatcher
        type Shader = Three_core.Shader

        type [<AllowNullLiteral>] IExports =
            abstract AWDLoader: obj option
            abstract OBJLoader2: obj option
            abstract STLLoader: obj option
            abstract FlyControls: obj option
            abstract BloomPass: obj option
            abstract DotScreenShader: Shader
            abstract RGBShiftShader: Shader
            abstract FXAAShader: Shader

    module Three_fbxloader =
        type LoadingManager = Three_core.LoadingManager
        type AnimationClip = Three_core.AnimationClip
        type Group = Three_core.Group

        type [<AllowNullLiteral>] IExports =
            abstract FBXLoader: FBXLoaderStatic

        type [<AllowNullLiteral>] IFbxSceneGraph =
            inherit Group
            abstract animations: ResizeArray<AnimationClip> with get, set

        type [<AllowNullLiteral>] FBXLoader =
            abstract manager: LoadingManager with get, set
            abstract load: url: string * onLoad: (IFbxSceneGraph -> unit) * ?onProgress: (ProgressEvent -> unit) * ?onError: (ErrorEvent -> unit) -> unit
            abstract parse: FBXText: string * resourceDirectory: string -> Group

        type [<AllowNullLiteral>] FBXLoaderStatic =
            [<Emit "new $0($1...)">] abstract Create: ?manager: LoadingManager -> FBXLoader

    module Three_filmpass =
        type OrthographicCamera = Three_core.OrthographicCamera
        type Scene = Three_core.Scene
        type WebGLRenderTarget = Three_core.WebGLRenderTarget
        type WebGLRenderer = Three_core.WebGLRenderer
        type ShaderMaterial = Three_core.ShaderMaterial
        type Mesh = Three_core.Mesh
        type IUniform = Three_core.IUniform
        type Pass = Three_effectcomposer.Pass

        type [<AllowNullLiteral>] IExports =
            abstract FilmPass: FilmPassStatic

        type [<AllowNullLiteral>] FilmPass =
            inherit Pass
            abstract scene: Scene with get, set
            abstract camera: OrthographicCamera with get, set
            abstract uniforms: obj with get, set
            abstract material: ShaderMaterial with get, set
            abstract quad: Mesh with get, set

        type [<AllowNullLiteral>] FilmPassStatic =
            [<Emit "new $0($1...)">] abstract Create: ?noiseIntensity: float * ?scanlinesIntensity: float * ?scanlinesCount: float * ?grayscale: bool -> FilmPass

    module Three_gltfexporter =
        type Object3D = Three_core.Object3D

        type [<AllowNullLiteral>] IExports =
            abstract GLTFExporter: GLTFExporterStatic

        type [<AllowNullLiteral>] GLTFExporter =
            abstract parse: input: Object3D * onCompleted: (obj -> unit) * options: obj -> obj

        type [<AllowNullLiteral>] GLTFExporterStatic =
            [<Emit "new $0($1...)">] abstract Create: unit -> GLTFExporter

    module Three_gltfloader =
        type AnimationClip = Three_core.AnimationClip
        type Camera = Three_core.Camera
        type LoadingManager = Three_core.LoadingManager
        type Scene = Three_core.Scene

        type [<AllowNullLiteral>] IExports =
            abstract GLTF: GLTFStatic
            abstract GLTFLoader: GLTFLoaderStatic

        type [<AllowNullLiteral>] GLTF =
            abstract animations: ResizeArray<AnimationClip> with get, set
            abstract scene: Scene with get, set
            abstract scenes: ResizeArray<Scene> with get, set
            abstract cameras: ResizeArray<Camera> with get, set
            abstract asset: obj with get, set

        type [<AllowNullLiteral>] GLTFStatic =
            [<Emit "new $0($1...)">] abstract Create: unit -> GLTF

        type [<AllowNullLiteral>] GLTFLoader =
            abstract manager: LoadingManager with get, set
            abstract path: string with get, set
            abstract load: url: string * onLoad: (GLTF -> unit) * ?onProgress: (ProgressEvent -> unit) * ?onError: (ErrorEvent -> unit) -> unit
            abstract setPath: path: string -> GLTFLoader
            abstract setResourcePath: path: string -> GLTFLoader
            abstract setCrossOrigin: value: string -> unit
            abstract setDRACOLoader: dracoLoader: obj -> unit
            abstract parse: data: ArrayBuffer * path: string * onLoad: (GLTF -> unit) * ?onError: (ErrorEvent -> unit) -> unit

        type [<AllowNullLiteral>] GLTFLoaderStatic =
            [<Emit "new $0($1...)">] abstract Create: ?manager: LoadingManager -> GLTFLoader

    module Three_lensflare =
        type Mesh = Three_core.Mesh
        type Camera = Three_core.Camera
        type Scene = Three_core.Scene
        type WebGLRenderer = Three_core.WebGLRenderer
        type Blending = Three_core.Blending
        type Vector3 = Three_core.Vector3
        type Color = Three_core.Color
        type Shader = Three_core.Shader
        type Texture = Three_core.Texture
        type BufferGeometry = Three_core.BufferGeometry

        type [<AllowNullLiteral>] IExports =
            abstract LensFlare: LensFlareStatic
            abstract LensFlareElement: LensFlareElementStatic

        type [<AllowNullLiteral>] LensFlare =
            inherit Mesh
            abstract ``type``: string with get, set
            abstract frustumCulled: obj with get, set
            abstract renderOrder: float with get, set
            abstract addElement: element: LensFlareElement -> LensFlare
            abstract onBeforeRender: (WebGLRenderer -> Scene -> Camera -> unit) with get, set
            abstract dispose: unit -> unit
            abstract isLensflare: obj with get, set

        type [<AllowNullLiteral>] LensFlareStatic =
            [<Emit "new $0($1...)">] abstract Create: unit -> LensFlare

        type [<AllowNullLiteral>] LensFlareElement =
            abstract texture: Texture with get, set
            abstract size: float with get, set
            abstract distance: float with get, set
            abstract color: Color with get, set
            abstract Shader: Shader with get, set
            abstract Geometry: BufferGeometry with get, set

        type [<AllowNullLiteral>] LensFlareElementStatic =
            [<Emit "new $0($1...)">] abstract Create: texture: Texture * ?size: float * ?distance: float * ?color: Color -> LensFlareElement

    module Three_maskpass =
        type Camera = Three_core.Camera
        type Scene = Three_core.Scene
        type WebGLRenderTarget = Three_core.WebGLRenderTarget
        type WebGLRenderer = Three_core.WebGLRenderer
        type Pass = Three_effectcomposer.Pass

        type [<AllowNullLiteral>] IExports =
            abstract MaskPass: MaskPassStatic
            abstract ClearMaskPass: ClearMaskPassStatic

        type [<AllowNullLiteral>] MaskPass =
            inherit Pass
            abstract scene: Scene with get, set
            abstract camera: Camera with get, set
            abstract clear: obj with get, set
            abstract needsSwap: obj with get, set
            abstract inverse: bool with get, set

        type [<AllowNullLiteral>] MaskPassStatic =
            [<Emit "new $0($1...)">] abstract Create: scene: Scene * camera: Camera -> MaskPass

        type [<AllowNullLiteral>] ClearMaskPass =
            inherit Pass
            abstract needsSwap: obj with get, set

        type [<AllowNullLiteral>] ClearMaskPassStatic =
            [<Emit "new $0($1...)">] abstract Create: unit -> ClearMaskPass

    module Three_mtlloader =
        type Material = Three_core.Material
        type LoadingManager = Three_core.LoadingManager
        type EventDispatcher = Three_core.EventDispatcher
        type BufferGeometry = Three_core.BufferGeometry
        type Texture = Three_core.Texture

        type [<AllowNullLiteral>] IExports =
            abstract MTLLoader: MTLLoaderStatic
            abstract MaterialCreator: MaterialCreatorStatic

        type [<AllowNullLiteral>] MTLLoader =
            inherit EventDispatcher
            abstract manager: LoadingManager with get, set
            abstract materialOptions: obj with get, set
            abstract materials: ResizeArray<Material> with get, set
            abstract path: string with get, set
            abstract texturePath: string with get, set
            abstract crossOrigin: bool with get, set
            abstract load: url: string * onLoad: (MaterialCreator -> unit) * ?onProgress: (ProgressEvent -> unit) * ?onError: (ErrorEvent -> unit) -> unit
            abstract parse: text: string -> MaterialCreator
            abstract setPath: path: string -> unit
            abstract setTexturePath: path: string -> unit
            abstract setBaseUrl: path: string -> unit
            abstract setCrossOrigin: value: bool -> unit
            abstract setMaterialOptions: value: obj option -> unit

        type [<AllowNullLiteral>] MTLLoaderStatic =
            [<Emit "new $0($1...)">] abstract Create: ?manager: LoadingManager -> MTLLoader

        type [<AllowNullLiteral>] MaterialCreator =
            abstract baseUrl: string with get, set
            abstract options: obj option with get, set
            abstract materialsInfo: obj option with get, set
            abstract materials: obj option with get, set
            abstract materialsArray: ResizeArray<Material> with get, set
            abstract nameLookup: obj option with get, set
            abstract side: float with get, set
            abstract wrap: float with get, set
            abstract setCrossOrigin: value: bool -> unit
            abstract setManager: value: obj option -> unit
            abstract setMaterials: materialsInfo: obj option -> unit
            abstract convert: materialsInfo: obj option -> obj option
            abstract preload: unit -> unit
            abstract getIndex: materialName: string -> Material
            abstract getAsArray: unit -> ResizeArray<Material>
            abstract create: materialName: string -> Material
            abstract createMaterial_: materialName: string -> Material
            abstract getTextureParams: value: string * matParams: obj option -> obj option
            abstract loadTexture: url: string * mapping: obj option * onLoad: (BufferGeometry -> unit) * ?onProgress: (ProgressEvent -> unit) * ?onError: (ErrorEvent -> unit) -> Texture

        type [<AllowNullLiteral>] MaterialCreatorStatic =
            [<Emit "new $0($1...)">] abstract Create: ?baseUrl: string * ?options: obj option -> MaterialCreator

    module Three_objloader =
        type Material = Three_core.Material
        type LoadingManager = Three_core.LoadingManager
        type Group = Three_core.Group
        type MaterialCreator = Three_mtlloader.MaterialCreator

        type [<AllowNullLiteral>] IExports =
            abstract OBJLoader: OBJLoaderStatic

        type [<AllowNullLiteral>] OBJLoader =
            abstract manager: LoadingManager with get, set
            abstract regexp: obj option with get, set
            abstract materials: ResizeArray<Material> with get, set
            abstract path: string with get, set
            abstract load: url: string * onLoad: (Group -> unit) * ?onProgress: (ProgressEvent -> unit) * ?onError: (ErrorEvent -> unit) -> unit
            abstract parse: data: string -> Group
            abstract setPath: value: string -> unit
            abstract setMaterials: materials: MaterialCreator -> unit
            abstract _createParserState: unit -> obj option

        type [<AllowNullLiteral>] OBJLoaderStatic =
            [<Emit "new $0($1...)">] abstract Create: ?manager: LoadingManager -> OBJLoader

    module Three_octree =
        type Vector3 = Three_core.Vector3

        type [<AllowNullLiteral>] IExports =
            abstract Octree: OctreeStatic

        type [<AllowNullLiteral>] Octree =
            abstract update: unit -> unit
            abstract add: ``object``: obj option * ?options: obj option -> obj option
            abstract addDeferred: ``object``: obj option * ?options: obj option -> obj option
            abstract addObjectData: ``object``: obj option * part: obj option -> obj option
            abstract remove: ``object``: obj option -> obj option
            abstract extend: octree: Octree -> obj option
            abstract rebuild: unit -> obj option
            abstract updateObject: ``object``: obj option -> obj option
            abstract search: position: Vector3 * radius: float * organizeByObject: bool * direction: Vector3 -> obj option
            abstract setRoot: root: obj option -> obj option
            abstract getDepthEnd: unit -> float
            abstract getNodeCountEnd: unit -> float
            abstract getObjectCountEnd: unit -> float
            abstract toConsole: unit -> obj option

        type [<AllowNullLiteral>] OctreeStatic =
            [<Emit "new $0($1...)">] abstract Create: ?parameters: obj option -> Octree

    module Three_orbitcontrols =
        type Camera = Three_core.Camera
        type MOUSE = Three_core.MOUSE

            
        type Object3D_A = Three_core.Object3D
        type Vector3 = Three_core.Vector3

        type [<AllowNullLiteral>] IExports =
            abstract OrbitControls: OrbitControlsStatic

        type [<AllowNullLiteral>] OrbitControls =
            abstract ``object``: Camera with get, set
            abstract domElement: U2<HTMLElement, HTMLDocument> with get, set
            abstract enabled: bool with get, set
            abstract target: Vector3 with get, set
            abstract center: Vector3 with get, set
            abstract enableZoom: bool with get, set
            abstract zoomSpeed: float with get, set
            abstract minDistance: float with get, set
            abstract maxDistance: float with get, set
            abstract enableRotate: bool with get, set
            abstract rotateSpeed: float with get, set
            abstract enablePan: bool with get, set
            abstract keyPanSpeed: float with get, set
            abstract autoRotate: bool with get, set
            abstract autoRotateSpeed: float with get, set
            abstract minPolarAngle: float with get, set
            abstract maxPolarAngle: float with get, set
            abstract minAzimuthAngle: float with get, set
            abstract maxAzimuthAngle: float with get, set
            abstract enableKeys: bool with get, set
            abstract keys: obj with get, set
            abstract mouseButtons: obj with get, set
            abstract enableDamping: bool with get, set
            abstract dampingFactor: float with get, set
            abstract screenSpacePanning: bool with get, set
            abstract rotateLeft: ?angle: float -> unit
            abstract rotateUp: ?angle: float -> unit
            abstract panLeft: ?distance: float -> unit
            abstract panUp: ?distance: float -> unit
            abstract pan: deltaX: float * deltaY: float -> unit
            abstract dollyIn: dollyScale: float -> unit
            abstract dollyOut: dollyScale: float -> unit
            abstract update: unit -> unit
            abstract reset: unit -> unit
            abstract dispose: unit -> unit
            abstract getPolarAngle: unit -> float
            abstract getAzimuthalAngle: unit -> float
            abstract addEventListener: ``type``: string * listener: (obj option -> unit) -> unit
            abstract hasEventListener: ``type``: string * listener: (obj option -> unit) -> bool
            abstract removeEventListener: ``type``: string * listener: (obj option -> unit) -> unit
            abstract dispatchEvent: ``event``: OrbitControlsDispatchEventEvent -> unit

        type [<AllowNullLiteral>] OrbitControlsDispatchEventEvent =
            abstract ``type``: string with get, set
            abstract target: obj option with get, set

        type [<AllowNullLiteral>] OrbitControlsStatic =
            [<Emit "new $0($1...)">] abstract Create: ``object``: Camera * ?domElement: HTMLElement -> OrbitControls

    module Three_orthographictrackballcontrols =
        type Camera = Three_core.Camera
        type EventDispatcher = Three_core.EventDispatcher
        type Vector3 = Three_core.Vector3

        type [<AllowNullLiteral>] IExports =
            abstract OrthographicTrackballControls: OrthographicTrackballControlsStatic

        type [<AllowNullLiteral>] OrthographicTrackballControls =
            inherit EventDispatcher
            abstract ``object``: Camera with get, set
            abstract domElement: HTMLElement with get, set
            abstract enabled: bool with get, set
            abstract screen: obj with get, set
            abstract radius: float with get, set
            abstract rotateSpeed: float with get, set
            abstract zoomSpeed: float with get, set
            abstract panSpeed: float with get, set
            abstract noRotate: bool with get, set
            abstract noZoom: bool with get, set
            abstract noPan: bool with get, set
            abstract noRoll: bool with get, set
            abstract staticMoving: bool with get, set
            abstract dynamicDampingFactor: float with get, set
            abstract keys: ResizeArray<float> with get, set
            abstract target: Vector3 with get, set
            abstract position0: Vector3 with get, set
            abstract target0: Vector3 with get, set
            abstract up0: Vector3 with get, set
            abstract left0: float with get, set
            abstract right0: float with get, set
            abstract top0: float with get, set
            abstract bottom0: float with get, set
            abstract update: unit -> unit
            abstract reset: unit -> unit
            abstract checkDistances: unit -> unit
            abstract zoomCamera: unit -> unit
            abstract panCamera: unit -> unit
            abstract rotateCamera: unit -> unit
            abstract handleResize: unit -> unit
            abstract handleEvent: ``event``: obj option -> unit

        type [<AllowNullLiteral>] OrthographicTrackballControlsStatic =
            [<Emit "new $0($1...)">] abstract Create: ``object``: Camera * ?domElement: HTMLElement -> OrthographicTrackballControls

    module Three_outlinepass =
        type Camera = Three_core.Camera
        type Color = Three_core.Color
        type Object3D = Three_core.Object3D
        type Scene = Three_core.Scene
        type Vector2 = Three_core.Vector2
        type MeshBasicMaterial = Three_core.MeshBasicMaterial
        type ShaderMaterial = Three_core.ShaderMaterial
        type WebGLRenderTarget = Three_core.WebGLRenderTarget
        type IUniform = Three_core.IUniform
        type Matrix4 = Three_core.Matrix4
        type Pass = Three_effectcomposer.Pass

        type [<AllowNullLiteral>] IExports =
            abstract OutlinePass: OutlinePassStatic

        type [<AllowNullLiteral>] OutlinePass =
            inherit Pass
            abstract selectedObjects: ResizeArray<Object3D> with get, set
            abstract renderCamera: Camera with get, set
            abstract renderScene: Scene with get, set
            abstract visibleEdgeColor: Color with get, set
            abstract hiddenEdgeColor: Color with get, set
            abstract edgeGlow: float with get, set
            abstract usePatternTexture: bool with get, set
            abstract edgeThickness: float with get, set
            abstract edgeStrength: float with get, set
            abstract downSampleRatio: float with get, set
            abstract pulsePeriod: float with get, set
            abstract resolution: Vector2 with get, set
            abstract maskBufferMaterial: MeshBasicMaterial with get, set
            abstract prepareMaskMaterial: ShaderMaterial with get, set
            abstract renderTargetDepthBuffer: WebGLRenderTarget with get, set
            abstract renderTargetMaskDownSampleBuffer: WebGLRenderTarget with get, set
            abstract renderTargetBlurBuffer1: WebGLRenderTarget with get, set
            abstract renderTargetBlurBuffer2: WebGLRenderTarget with get, set
            abstract edgeDetectionMaterial: ShaderMaterial with get, set
            abstract separableBlurMaterial: ShaderMaterial with get, set
            abstract overlayMaterial: ShaderMaterial with get, set
            abstract copyUniforms: obj with get, set
            abstract materialCopy: ShaderMaterial with get, set
            abstract oldClearColor: Color with get, set
            abstract tempPulseColor1: Color with get, set
            abstract tempPulseColor2: Color with get, set
            abstract textureMatrix: Matrix4 with get, set
            abstract BlurDirectionX: Vector2 with get, set
            abstract BlurDirectionY: Vector2 with get, set
            abstract dispose: unit -> unit
            abstract changeVisibilityOfSelectedObjects: bVisible: bool -> unit
            abstract changeVisibilityOfNonSelectedObjects: bVisible: bool -> unit
            abstract updateTextureMatrix: unit -> unit

        type [<AllowNullLiteral>] OutlinePassStatic =
            [<Emit "new $0($1...)">] abstract Create: resolution: Vector2 * scene: Scene * camera: Camera * ?selectedObjects: ResizeArray<Object3D> -> OutlinePass

    module Three_projector =
        type Camera = Three_core.Camera
        type Color = Three_core.Color
        type Face3 = Three_core.Face3
        type Light = Three_core.Light
        type Material = Three_core.Material
        type Object3D = Three_core.Object3D
        type Scene = Three_core.Scene
        type Vector2 = Three_core.Vector2
        type Vector3 = Three_core.Vector3
        type Vector4 = Three_core.Vector4

        type [<AllowNullLiteral>] IExports =
            abstract RenderableObject: RenderableObjectStatic
            abstract RenderableFace: RenderableFaceStatic
            abstract RenderableVertex: RenderableVertexStatic
            abstract RenderableLine: RenderableLineStatic
            abstract RenderableSprite: RenderableSpriteStatic
            abstract Projector: ProjectorStatic

        type [<AllowNullLiteral>] RenderableObject =
            abstract id: float with get, set
            abstract ``object``: obj option with get, set
            abstract z: float with get, set

        type [<AllowNullLiteral>] RenderableObjectStatic =
            [<Emit "new $0($1...)">] abstract Create: unit -> RenderableObject

        type [<AllowNullLiteral>] RenderableFace =
            abstract id: float with get, set
            abstract v1: RenderableVertex with get, set
            abstract v2: RenderableVertex with get, set
            abstract v3: RenderableVertex with get, set
            abstract normalModel: Vector3 with get, set
            abstract vertexNormalsModel: ResizeArray<Vector3> with get, set
            abstract vertexNormalsLength: float with get, set
            abstract color: Color with get, set
            abstract material: Material with get, set
            abstract uvs: ResizeArray<ResizeArray<Vector2>> with get, set
            abstract z: float with get, set

        type [<AllowNullLiteral>] RenderableFaceStatic =
            [<Emit "new $0($1...)">] abstract Create: unit -> RenderableFace

        type [<AllowNullLiteral>] RenderableVertex =
            abstract position: Vector3 with get, set
            abstract positionWorld: Vector3 with get, set
            abstract positionScreen: Vector4 with get, set
            abstract visible: bool with get, set
            abstract copy: vertex: RenderableVertex -> unit

        type [<AllowNullLiteral>] RenderableVertexStatic =
            [<Emit "new $0($1...)">] abstract Create: unit -> RenderableVertex

        type [<AllowNullLiteral>] RenderableLine =
            abstract id: float with get, set
            abstract v1: RenderableVertex with get, set
            abstract v2: RenderableVertex with get, set
            abstract vertexColors: ResizeArray<Color> with get, set
            abstract material: Material with get, set
            abstract z: float with get, set

        type [<AllowNullLiteral>] RenderableLineStatic =
            [<Emit "new $0($1...)">] abstract Create: unit -> RenderableLine

        type [<AllowNullLiteral>] RenderableSprite =
            abstract id: float with get, set
            abstract ``object``: obj option with get, set
            abstract x: float with get, set
            abstract y: float with get, set
            abstract z: float with get, set
            abstract rotation: float with get, set
            abstract scale: Vector2 with get, set
            abstract material: Material with get, set

        type [<AllowNullLiteral>] RenderableSpriteStatic =
            [<Emit "new $0($1...)">] abstract Create: unit -> RenderableSprite

        /// Projects points between spaces.
        type [<AllowNullLiteral>] Projector =
            abstract projectVector: vector: Vector3 * camera: Camera -> Vector3
            abstract unprojectVector: vector: Vector3 * camera: Camera -> Vector3
            /// <summary>Transforms a 3D scene object into 2D render data that can be rendered in a screen with your renderer of choice, projecting and clipping things out according to the used camera.
            /// If the scene were a real scene, this method would be the equivalent of taking a picture with the camera (and developing the film would be the next step, using a Renderer).</summary>
            /// <param name="scene">scene to project.</param>
            /// <param name="camera">camera to use in the projection.</param>
            abstract projectScene: scene: Scene * camera: Camera * sortObjects: bool * ?sortElements: bool -> obj

        /// Projects points between spaces.
        type [<AllowNullLiteral>] ProjectorStatic =
            [<Emit "new $0($1...)">] abstract Create: unit -> Projector

    module Three_renderpass =
        type Camera = Three_core.Camera
        type Color = Three_core.Color
        type Material = Three_core.Material
        type Scene = Three_core.Scene
        type WebGLRenderTarget = Three_core.WebGLRenderTarget
        type WebGLRenderer = Three_core.WebGLRenderer
        type Pass = Three_effectcomposer.Pass

        type [<AllowNullLiteral>] IExports =
            abstract RenderPass: RenderPassStatic

        type [<AllowNullLiteral>] RenderPass =
            inherit Pass
            abstract scene: Scene with get, set
            abstract camera: Camera with get, set
            abstract overrideMaterial: Material option with get, set
            abstract clearColor: U3<Color, string, float> option with get, set
            abstract clearAlpha: float option with get, set
            abstract clear: bool with get, set
            abstract needsSwap: obj with get, set
            abstract clearDepth: obj with get, set

        type [<AllowNullLiteral>] RenderPassStatic =
            [<Emit "new $0($1...)">] abstract Create: scene: Scene * camera: Camera * ?overrideMaterial: Material option * ?clearColor: U3<Color, string, float> * ?clearAlpha: float -> RenderPass

    module Three_shaderpass =
        type OrthographicCamera = Three_core.OrthographicCamera
        type IUniform = Three_core.IUniform
        type Mesh = Three_core.Mesh
        type Scene = Three_core.Scene
        type Shader = Three_core.Shader
        type ShaderMaterial = Three_core.ShaderMaterial
        type WebGLRenderTarget = Three_core.WebGLRenderTarget
        type WebGLRenderer = Three_core.WebGLRenderer
        type Pass = Three_effectcomposer.Pass

        type [<AllowNullLiteral>] IExports =
            abstract ShaderPass: ShaderPassStatic

        type [<AllowNullLiteral>] ShaderPass =
            inherit Pass
            abstract textureID: string with get, set
            abstract uniforms: obj with get, set
            abstract material: ShaderMaterial with get, set
            abstract camera: OrthographicCamera with get, set
            abstract scene: Scene with get, set
            abstract quad: Mesh with get, set

        type [<AllowNullLiteral>] ShaderPassStatic =
            [<Emit "new $0($1...)">] abstract Create: shader: Shader * ?textureID: string -> ShaderPass

    module Three_smaapass =
        type WebGLRenderTarget = Three_core.WebGLRenderTarget
        type Texture = Three_core.Texture
        type IUniform = Three_core.IUniform
        type ShaderMaterial = Three_core.ShaderMaterial
        type OrthographicCamera = Three_core.OrthographicCamera
        type Scene = Three_core.Scene
        type Mesh = Three_core.Mesh
        type Pass = Three_effectcomposer.Pass

        type [<AllowNullLiteral>] IExports =
            abstract SMAAPass: SMAAPassStatic

        type [<AllowNullLiteral>] SMAAPass =
            inherit Pass
            abstract edgesRT: WebGLRenderTarget with get, set
            abstract weightsRT: WebGLRenderTarget with get, set
            abstract areaTexture: Texture with get, set
            abstract searchTexture: Texture with get, set
            abstract uniformsEdges: obj with get, set
            abstract materialEdges: ShaderMaterial with get, set
            abstract uniformsWeights: obj with get, set
            abstract materialWeights: ShaderMaterial with get, set
            abstract uniformsBlend: obj with get, set
            abstract materialBlend: ShaderMaterial with get, set
            abstract needsSwap: obj with get, set
            abstract camera: OrthographicCamera with get, set
            abstract scene: Scene with get, set
            abstract quad: Mesh with get, set
            abstract getAreaTexture: unit -> string
            abstract getSearchTexture: unit -> string

        type [<AllowNullLiteral>] SMAAPassStatic =
            [<Emit "new $0($1...)">] abstract Create: width: float * height: float -> SMAAPass

    module Three_ssaapass =
        type Pass = Three_effectcomposer.Pass
        type Scene = Three_core.Scene
        type Camera = Three_core.Camera
        type Color = Three_core.Color
        type IUniform = Three_core.IUniform
        type ShaderMaterial = Three_core.ShaderMaterial
        type OrthographicCamera = Three_core.OrthographicCamera
        type Mesh = Three_core.Mesh

        type [<AllowNullLiteral>] IExports =
            abstract SSAARenderPass: SSAARenderPassStatic

        type [<AllowNullLiteral>] SSAARenderPass =
            inherit Pass
            abstract scene: Scene with get, set
            abstract camera: Camera with get, set
            abstract sampleLevel: float with get, set
            abstract unbiased: bool with get, set
            abstract clearColor: U3<Color, string, float> with get, set
            abstract clearAlpha: float with get, set
            abstract copyUniforms: obj with get, set
            abstract copyMaterial: ShaderMaterial with get, set
            abstract camera2: OrthographicCamera with get, set
            abstract scene2: Scene with get, set
            abstract quad2: Mesh with get, set
            abstract dispose: unit -> unit
            abstract JitterVectors: ResizeArray<ResizeArray<ResizeArray<float>>>

        type [<AllowNullLiteral>] SSAARenderPassStatic =
            [<Emit "new $0($1...)">] abstract Create: scene: Scene * camera: Camera * ?clearColor: U3<Color, string, float> * ?clearAlpha: float -> SSAARenderPass

    module Three_tgaloader =
        type LoadingManager = Three_core.LoadingManager
        type Texture = Three_core.Texture

        type [<AllowNullLiteral>] IExports =
            abstract TGALoader: TGALoaderStatic

        type [<AllowNullLiteral>] TGALoader =
            abstract manager: LoadingManager with get, set
            abstract load: url: string * ?onLoad: (Texture -> unit) * ?onProgress: (ProgressEvent -> unit) * ?onError: (ErrorEvent -> unit) -> Texture

        type [<AllowNullLiteral>] TGALoaderStatic =
            [<Emit "new $0($1...)">] abstract Create: ?manager: LoadingManager -> TGALoader

    module Three_trackballcontrols =
        type Camera = Three_core.Camera
        type EventDispatcher = Three_core.EventDispatcher
        type Vector3 = Three_core.Vector3

        type [<AllowNullLiteral>] IExports =
            abstract TrackballControls: TrackballControlsStatic

        type [<AllowNullLiteral>] TrackballControls =
            inherit EventDispatcher
            abstract ``object``: Camera with get, set
            abstract domElement: HTMLElement with get, set
            abstract enabled: bool with get, set
            abstract screen: obj with get, set
            abstract rotateSpeed: float with get, set
            abstract zoomSpeed: float with get, set
            abstract panSpeed: float with get, set
            abstract noRotate: bool with get, set
            abstract noZoom: bool with get, set
            abstract noPan: bool with get, set
            abstract noRoll: bool with get, set
            abstract staticMoving: bool with get, set
            abstract dynamicDampingFactor: float with get, set
            abstract minDistance: float with get, set
            abstract maxDistance: float with get, set
            abstract keys: ResizeArray<float> with get, set
            abstract target: Vector3 with get, set
            abstract position0: Vector3 with get, set
            abstract target0: Vector3 with get, set
            abstract up0: Vector3 with get, set
            abstract update: unit -> unit
            abstract reset: unit -> unit
            abstract dispose: unit -> unit
            abstract checkDistances: unit -> unit
            abstract zoomCamera: unit -> unit
            abstract panCamera: unit -> unit
            abstract rotateCamera: unit -> unit
            abstract handleResize: unit -> unit
            abstract handleEvent: ``event``: obj option -> unit

        type [<AllowNullLiteral>] TrackballControlsStatic =
            [<Emit "new $0($1...)">] abstract Create: ``object``: Camera * ?domElement: HTMLElement -> TrackballControls

    module Three_transformcontrols =
        type Camera = Three_core.Camera
        type Object3D = Three_core.Object3D

        type [<AllowNullLiteral>] IExports =
            abstract TransformControls: TransformControlsStatic

        type [<AllowNullLiteral>] TransformControls =
            inherit Object3D
            abstract size: float with get, set
            abstract space: string with get, set
            abstract ``object``: Object3D with get, set
            abstract update: unit -> unit
            abstract detach: unit -> unit
            abstract attach: ``object``: Object3D -> unit
            abstract getMode: unit -> string
            abstract setMode: mode: string -> unit
            abstract setSnap: snap: obj option -> unit
            abstract setSize: size: float -> unit
            abstract setSpace: space: string -> unit
            abstract setTranslationSnap: size: float -> unit
            abstract setRotationSnap: size: float -> unit

        type [<AllowNullLiteral>] TransformControlsStatic =
            [<Emit "new $0($1...)">] abstract Create: ``object``: Camera * ?domElement: HTMLElement -> TransformControls

    module Three_unrealbloompass =
        type Pass = Three_effectcomposer.Pass
        type Vector2 = Three_core.Vector2
        type ShaderMaterial = Three_core.ShaderMaterial
        type WebGLRenderTarget = Three_core.WebGLRenderTarget
        type IUniform = Three_core.IUniform
        type Color = Three_core.Color
        type Scene = Three_core.Scene
        type Mesh = Three_core.Mesh
        type OrthographicCamera = Three_core.OrthographicCamera

        type [<AllowNullLiteral>] IExports =
            abstract UnrealBloomPass: UnrealBloomPassStatic

        type [<AllowNullLiteral>] UnrealBloomPass =
            inherit Pass
            abstract strength: float with get, set
            abstract resolution: Vector2 with get, set
            abstract nMips: float with get, set
            abstract renderTargetBright: WebGLRenderTarget with get, set
            abstract highPassUniforms: obj with get, set
            abstract renderTargetsHorizontal: ResizeArray<WebGLRenderTarget> with get, set
            abstract renderTargetsVertical: ResizeArray<WebGLRenderTarget> with get, set
            abstract materialHighPassFilter: ShaderMaterial with get, set
            abstract separableBlurMaterials: ResizeArray<ShaderMaterial> with get, set
            abstract compositeMaterial: ShaderMaterial with get, set
            abstract bloomTintColors: ResizeArray<Color> with get, set
            abstract copyUniforms: obj with get, set
            abstract materialCopy: ShaderMaterial with get, set
            abstract needsSwap: obj with get, set
            abstract oldClearAlpha: float with get, set
            abstract oldClearColor: Color with get, set
            abstract camera: OrthographicCamera with get, set
            abstract scene: Scene with get, set
            abstract quad: Mesh with get, set
            abstract radius: float with get, set
            abstract threshold: float with get, set
            abstract dispose: unit -> unit
            abstract getSeparableBlurMaterial: unit -> ShaderMaterial
            abstract getCompositeMaterial: unit -> ShaderMaterial
            abstract BlurDirectionX: Vector2 with get, set
            abstract BlurDirectionY: Vector2 with get, set

        type [<AllowNullLiteral>] UnrealBloomPassStatic =
            [<Emit "new $0($1...)">] abstract Create: ?resolution: Vector2 * ?strength: float * ?radius: float * ?threshold: float -> UnrealBloomPass

    module Three_vrcontrols =
        type Camera = Three_core.Camera

        type [<AllowNullLiteral>] IExports =
            abstract VRControls: VRControlsStatic

        type [<AllowNullLiteral>] VRControls =
            /// Update VR Instance Tracking
            abstract update: unit -> unit
            abstract zeroSensor: unit -> unit
            abstract scale: float with get, set
            abstract setVRDisplay: display: Three_core.VRDisplay -> unit

        type [<AllowNullLiteral>] VRControlsStatic =
            [<Emit "new $0($1...)">] abstract Create: camera: Camera * ?callback: (string -> unit) -> VRControls

    module Three_vreffect =
        type Camera = Three_core.Camera
        type Matrix4 = Three_core.Matrix4
        type Renderer = Three_core.Renderer
        type Scene = Three_core.Scene

        type [<AllowNullLiteral>] IExports =
            abstract VREffect: VREffectStatic        

        type [<AllowNullLiteral>] VREffect =
            abstract render: scene: Scene * camera: Camera -> unit
            abstract setSize: width: float * height: float -> unit
            abstract setFullScreen: flag: bool -> unit
            abstract startFullscreen: unit -> unit
            abstract FovToNDCScaleOffset: fov: VRFov -> VREffectOffset
            abstract FovPortToProjection: fov: VRFov * rightHanded: bool * zNear: float * zFar: float -> Matrix4
            abstract FovToProjection: fov: VRFov * rightHanded: bool * zNear: float * zFar: float -> Matrix4
            abstract setVRDisplay: display: Three_core.VRDisplay -> unit

        type [<AllowNullLiteral>] VREffectStatic =
            [<Emit "new $0($1...)">] abstract Create: renderer: Renderer * ?callback: (string -> unit) -> VREffect

        type [<AllowNullLiteral>] VRFov =
            abstract leftTan: float with get, set
            abstract rightTan: float with get, set
            abstract upTan: float with get, set
            abstract downTan: float with get, set

        type [<AllowNullLiteral>] VREffectOffset =
            abstract scale: float with get, set
            abstract offset: float with get, set
