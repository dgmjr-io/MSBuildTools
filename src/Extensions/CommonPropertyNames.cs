namespace Dgmjr.MSBuild.Constants;

/// <summary>Contains the names of common MSBuild properties.</summary>
/// <remarks>See <see href="https://learn.microsoft.com/en-us/dotnet/core/project-sdk/msbuild-props">MSBuild Properties</see></remarks>
public static class CommonPropertyNames
{
    /// <summary>Specifies additional folders in which compilers should look for reference assemblies.</summary>
    /// <remarks>Project types: .NET</remarks>
    /// <value><c>AdditionalLibPaths</c></value>
    public const string AdditionalLibPaths = "AdditionalLibPaths";

    /// <summary>Causes the compiler to make all type information from the specified files available to the project you are compiling. This property is equivalent to the <c>/addModules</c> compiler switch.</summary>
    /// <remarks>Project types: .NET</remarks>
    /// <value><c>AddModules</c></value>
    public const string AddModules = "AddModules";

    /// <summary>The path where AL.exe can be found. This property overrides the current version of AL.exe to enable use of a different version.</summary>
    /// <remarks>Project types: .NET</remarks>
    /// <value><c>ALToolPath</c></value>
    public const string ALToolPath = "ALToolPath";

    /// <summary>The .ico icon file to pass to the compiler for embedding as a Win32 icon. The property is equivalent to the <c>/win32icon</c> compiler switch.</summary>
    /// <remarks>Project types: .NET</remarks>
    /// <value><c>ApplicationIcon</c></value>
    public const string ApplicationIcon = "ApplicationIcon";

    /// <summary>Specifies the path of the file that is used to generate external User Account Control (UAC) manifest information. Applies only to Visual Studio projects targeting Windows Vista.
    /// In most cases, the manifest is embedded. However, if you use Registration Free COM or ClickOnce deployment, then the manifest can be an external file that is installed together with your application assemblies. For more information, see the NoWin32Manifest property in this topic.</summary>
    /// <remarks>Project types: All</remarks>
    /// <value><c>ApplicationManifest</c></value>
    public const string ApplicationManifest = "ApplicationManifest";

    /// <summary>Specifies the file that's used to sign the assembly (.snk or .pfx) and that's passed to the ResolveKeySource task to generate the actual key that's used to sign the assembly.</summary>
    /// <remarks>Project types: .NET</remarks>
    /// <value><c>AssemblyOriginatorKeyFile</c></value>
    public const string AssemblyOriginatorKeyFile = "AssemblyOriginatorKeyFile";

    /// <summary>A list of locations to search during build-time reference assembly resolution. The order in which paths appear in this list is meaningful because paths listed earlier takes precedence over later entries.</summary>
    /// <remarks>Project types: .NET</remarks>
    /// <value><c>AssemblySearchPaths</c></value>
    public const string AssemblySearchPaths = "AssemblySearchPaths";

    /// <summary>The name of the final output assembly after the project is built.</summary>
    /// <remarks>Project types: .NET</remarks>
    /// <value><c>AssemblyName</c></value>
    public const string AssemblyName = "AssemblyName";

    /// <summary>Specifies the base address of the main output assembly. This property is equivalent to the <c>/baseaddress</c> compiler switch.</summary>
    /// <remarks>Project types: .NET</remarks>
    /// <value><c>BaseAddress</c></value>
    public const string BaseAddress = "BaseAddress";

    /// <summary>The top-level folder where all configuration-specific intermediate output folders are created. The default value is <c>obj\</c>.</summary>
    /// <example>&lt;BaseIntermediateOutputPath&gt;c:\xyz\obj\&lt;/BaseIntermediateOutputPath&gt;</example>
    /// <remarks>Project types: All</remarks>
    /// <value><c>BaseIntermediateOutputPath</c></value>
    public const string BaseIntermediateOutputPath = "BaseIntermediateOutputPath";

    /// <summary>Specifies the base path for the output file. If it is set, MSBuild will use OutputPath = $(BaseOutputPath)\$(Configuration)\.</summary>
    /// <example>&lt;BaseOutputPath&gt;c:\xyz\bin\&lt;/BaseOutputPath&gt;</example>
    /// <remarks>Project types: All</remarks>
    /// <value><c>BaseOutputPath</c></value>
    public const string BaseOutputPath = "BaseOutputPath";

    /// <summary>A boolean value that indicates whether project references are built or cleaned in parallel when Multi-Proc MSBuild is used. The default value is true, which means that projects will be built in parallel if the system has multiple cores or processors.</summary>
    /// <remarks>Project types: All</remarks>
    /// <value><c>BuildInParallel</c></value>
    public const string BuildInParallel = "BuildInParallel";

    /// <summary>A boolean value that indicates whether project references are built by MSBuild. Automatically set to false if you are building your project in the Visual Studio integrated development environment (IDE), true if otherwise. -p:BuildProjectReferences=false can be specified on the command line to avoid checking that referenced projects are up to date.</summary>
    /// <remarks>Project types: All</remarks>
    /// <value><c>BuildProjectReferences</c></value>
    public const string BuildProjectReferences = "BuildProjectReferences";

    /// <summary>The name of the file that will be used as the "clean cache." The clean cache is a list of generated files to be deleted during the cleaning operation. The file is put in the intermediate output path by the build process.
    /// This property specifies only file names that do not have path information.</summary>
    /// <remarks>Project types: All</remarks>
    /// <value><c>CleanFile</c></value>
    public const string CleanFile = "CleanFile";

    /// <summary>Specifies the code page to use for all source-code files in the compilation. This property is equivalent to the <c>/codepage</c> compiler switch.</summary>
    /// <remarks>Project types: .NET</remarks>
    /// <value><c>CodePage</c></value>
    public const string CodePage = "CodePage";

    /// <summary>An optional response file that can be passed to the compiler tasks.</summary>
    /// <remarks>Project types: .NET</remarks>
    /// <value><c>CompilerResponseFile</c></value>
    public const string CompilerResponseFile = "CompilerResponseFile";

    /// <summary>The configuration that you are building, generally Debug or Release, but configurable at the solution and project levels.</summary>
    /// <remarks>Project types: All</remarks>
    /// <value><c>Configuration</c></value>
    public const string Configuration = "Configuration";

    /// <summary>The path of csc.exe, the C# compiler.</summary>
    /// <remarks>Project types: C#</remarks>
    /// <value><c>CscToolPath</c></value>
    public const string CscToolPath = "CscToolPath";

    /// <summary>The name of a project file or targets file that is to be imported automatically before the common targets import.</summary>
    /// <remarks>Project types: All</remarks>
    /// <value><c>CustomBeforeMicrosoftCommonTargets</c></value>
    public const string CustomBeforeMicrosoftCommonTargets = "CustomBeforeMicrosoftCommonTargets";

    /// <summary>A boolean value that indicates whether symbols are generated by the build.
    /// Setting -p:DebugSymbols=false on the command line disables generation of program database (.pdb) symbol files.</summary>
    /// <remarks>Project types: All</remarks>
    /// <value><c>DebugSymbols</c></value>
    public const string DebugSymbols = "DebugSymbols";

    /// <summary>Defines the level of debug information that you want generated. Valid values are "full," "pdbonly," "portable", "embedded", and "none."</summary>
    /// <remarks>Project types: All</remarks>
    /// <value><c>DebugType</c></value>
    public const string DebugType = "DebugType";

    /// <summary>Defines conditional compiler constants. Symbol<c>/value</c> pairs are separated by semicolons and are specified by using the following syntax:
    ///
    /// symbol1 = value1 ; symbol2 = value2
    ///
    /// The property is equivalent to the <c>/define</c> compiler switch.</summary>
    /// <remarks>Project types: .NET</remarks>
    /// <value><c>DefineConstants</c></value>
    public const string DefineConstants = "DefineConstants";

    /// <summary>A boolean value that indicates whether you want the DEBUG constant defined.</summary>
    /// <remarks>Project types: All</remarks>
    /// <value><c>DefineDebug</c></value>
    public const string DefineDebug = "DefineDebug";

    /// <summary>A boolean value that indicates whether you want the TRACE constant defined.</summary>
    /// <remarks>Project types: All</remarks>
    /// <value><c>DefineTrace</c></value>
    public const string DefineTrace = "DefineTrace";

    /// <summary>A boolean value that indicates whether you want to delay-sign the assembly rather than full-sign it.</summary>
    /// <remarks>Project types: .NET</remarks>
    /// <value><c>DelaySign</c></value>
    public const string DelaySign = "DelaySign";

    /// <summary>A boolean value that indicates whether the compiler should produce identical assemblies for identical inputs. This parameter corresponds to the <c>/deterministic</c> switch of the compilers.</summary>
    /// <remarks>Project types: .NET</remarks>
    /// <value><c>Deterministic</c></value>
    public const string Deterministic = "Deterministic";

    /// <summary>A boolean value that applies to Visual Studio only. The Visual Studio build manager uses a process called FastUpToDateCheck to determine whether a project must be rebuilt to be up to date. This process is faster than using MSBuild to determine this. Setting the DisableFastUpToDateCheck property to true lets you bypass the Visual Studio build manager and force it to use MSBuild to determine whether the project is up to date.</summary>
    /// <remarks>Project types: All</remarks>
    /// <value><c>DisableFastUpToDateCheck</c></value>
    public const string DisableFastUpToDateCheck = "DisableFastUpToDateCheck";

    ///// <summary>The name of the file that is generated as the XML documentation file. This name includes only the file name and has no path information.</summary>
    ///// <remarks>Project types: .NET</remarks>
    ///// <value><c>DocumentationFile</c></value>
    //public const string DocumentationFile = "DocumentationFile";
    /// <summary>Specifies how the compiler task should report internal compiler errors. Valid values are "prompt," "send," or "none." This property is equivalent to the <c>/errorreport</c> compiler switch.</summary>
    /// <remarks>Project types: .NET</remarks>
    /// <value><c>ErrorReport</c></value>
    public const string ErrorReport = "ErrorReport";

    /// <summary>The GenerateDeploymentManifest task adds a deploymentProvider tag to the deployment manifest if the project file includes any of the following elements:
    ///
    /// - UpdateUrl
    /// - InstallUrl
    /// - PublishUrl
    ///
    /// Using ExcludeDeploymentUrl, however, you can prevent the deploymentProvider tag from being added to the deployment manifest even if any of the above URLs are specified. To do this, add the following property to your project file:
    ///
    /// <ExcludeDeploymentUrl>true</ExcludeDeploymentUrl>
    ///
    /// Note: ExcludeDeploymentUrl is not exposed in the Visual Studio IDE and can be set only by manually editing the project file. Setting this property does not affect publishing within Visual Studio; that is, the deploymentProvider tag will still be added to the URL specified by PublishUrl.</summary>
    /// <remarks>Project types: .NET</remarks>
    /// <value><c>ExcludeDeploymentUrl</c></value>
    public const string ExcludeDeploymentUrl = "ExcludeDeploymentUrl";

    /// <summary>Specifies, in bytes, where to align the sections of the output file. Valid values are 512, 1024, 2048, 4096, 8192. This property is equivalent to the <c>/filealignment</c> compiler switch.</summary>
    /// <remarks>Project types: .NET</remarks>
    /// <value><c>FileAlignment</c></value>
    public const string FileAlignment = "FileAlignment";

    /// <summary>Specifies the location of mscorlib.dll and microsoft.visualbasic.dll. This parameter is equivalent to the <c>/sdkpath</c> switch of the vbc.exe compiler.</summary>
    /// <remarks>Project types: Visual Basic</remarks>
    /// <value><c>FrameworkPathOverride</c></value>
    public const string FrameworkPathOverride = "FrameworkPathOverride";

    /// <summary>
    /// <para>The DocumentationFile property lets you specify a file name for the XML file that contains the documentation for your library. For IntelliSense to function correctly with your documentation, the file name must be the same as the assembly name and must be in the same directory as the assembly. If you don't specify this property but you do set <see cref="GenerateDocumentationFile" /> to true, the name of the documentation file defaults to the name of your assembly but with an .xml file extension. For this reason, it's often easier to omit this property and use the <see cref="GenerateDocumentationFile" /> property instead.</para>
    /// <para>If you specify this property but you set GenerateDocumentationFile to false, the compiler does not generate a documentation file. If you specify this property and omit the <see cref="GenerateDocumentationFile" /> property, the compiler does generate a documentation file.</para>
    /// </summary>
    /// <value><c>DocumentationFile</c></value>
    public const string DocumentationFile = nameof(DocumentationFile);

    /// <summary>A boolean parameter that indicates whether documentation is generated by the build. If true, the build generates documentation information and puts it in an .xml file together with the name of the executable file or library that the build task created.</summary>
    /// <remarks>Project types: .NET</remarks>
    /// <value><c>GenerateDocumentationFile</c></value>
    public const string GenerateDocumentationFile = "GenerateDocumentationFile";

    /// <summary>Generate full paths for filenames in output by using the -fullpaths compiler option.</summary>
    /// <remarks>Project types: C#</remarks>
    /// <value><c>GenerateFullPaths</c></value>
    public const string GenerateFullPaths = "GenerateFullPaths";

    /// <summary>Indicates whether XML serialization assemblies should be generated by SGen.exe, which can be set to on, auto, or off. This property is used for assemblies that target .NET Framework only. To generate XML serialization assemblies for .NET Standard or .NET Core assemblies, reference the Microsoft.XmlSerializer.Generator NuGet package.</summary>
    /// <remarks>Project types: .NET</remarks>
    /// <value><c>GenerateSerializationAssemblies</c></value>
    public const string GenerateSerializationAssemblies = "GenerateSerializationAssemblies";

    /// <summary>The full intermediate output path as derived from BaseIntermediateOutputPath, if no path is specified.</summary>
    /// <example>obj\debug\</example>
    /// <remarks>Project types: All</remarks>
    /// <value><c>IntermediateOutputPath</c></value>
    public const string IntermediateOutputPath = "IntermediateOutputPath";

    /// <summary>The name of the strong-name key container.</summary>
    /// <remarks>Project types: All</remarks>
    /// <value><c>KeyContainerName</c></value>
    public const string KeyContainerName = "KeyContainerName";

    /// <summary>The name of the strong-name key file.</summary>
    /// <remarks>Project types: All</remarks>
    /// <value><c>KeyOriginatorFile</c></value>
    public const string KeyOriginatorFile = "KeyOriginatorFile";

    /// <summary>The name of the assembly that the compiled module is to be incorporated into. The property is equivalent to the <c>/moduleassemblyname</c> compiler switch.</summary>
    /// <remarks>Project types: .NET</remarks>
    /// <value><c>ModuleAssemblyName</c></value>
    public const string ModuleAssemblyName = "ModuleAssemblyName";

    /// <summary>Specifies the path where project extensions are located. By default, this takes the same value as BaseIntermediateOutputPath.</summary>
    /// <remarks>Project types: All</remarks>
    /// <value><c>MSBuildProjectExtensionsPath</c></value>
    public const string MSBuildProjectExtensionsPath = "MSBuildProjectExtensionsPath";

    /// <summary>A boolean value that tells MSBuild to treat all warnings as errors, unless they're suppressed.</summary>
    /// <remarks>Project types: All</remarks>
    /// <value><c>MSBuildTreatWarningsAsErrors</c></value>
    public const string MSBuildTreatWarningsAsErrors = "MSBuildTreatWarningsAsErrors";

    /// <summary>Specifies a list of warning codes to treat as errors. Separate multiple warnings by semicolons. If you are using the .NET SDK property WarningsAsErrors, MSBuildWarningsAsErrors will default to the value of WarningsAsErrors.</summary>
    /// <remarks>Project types: All</remarks>
    /// <value><c>MSBuildWarningsAsErrors</c></value>
    public const string MSBuildWarningsAsErrors = "MSBuildWarningsAsErrors";

    /// <summary>Specifies a list of warning codes to suppress by treating them as low-importance messages. Separate multiple warnings by semicolons. Note that some warnings emitted by MSBuild cannot be suppressed by using this property; to suppress them, use the command-line switch -warnAsMessage. If you are using the .NET SDK property NoWarn, MSBuildWarningsAsMessages will default to the value of NoWarn.</summary>
    /// <remarks>Project types: All</remarks>
    /// <value><c>MSBuildWarningsAsMessages</c></value>
    public const string MSBuildWarningsAsMessages = "MSBuildWarningsAsMessages";

    /// <summary>A boolean value that indicates whether you want compiler logo to be turned off. This property is equivalent to the <c>/nologo</c> compiler switch.</summary>
    /// <remarks>Project types: All</remarks>
    /// <value><c>NoLogo</c></value>
    public const string NoLogo = "NoLogo";

    /// <summary>A boolean value that indicates whether to avoid referencing the standard library (mscorlib.dll). The default value is false.</summary>
    /// <remarks>Project types: .NET</remarks>
    /// <value><c>NoStdLib</c></value>
    public const string NoStdLib = "NoStdLib";

    /// <summary>A boolean value that indicates whether the Visual Basic runtime (Microsoft.VisualBasic.dll) should be included as a reference in the project.</summary>
    /// <remarks>Project types: Visual Basic</remarks>
    /// <value><c>NoVBRuntimeReference</c></value>
    public const string NoVBRuntimeReference = "NoVBRuntimeReference";

    /// <summary>Suppresses the specified warnings. Only the numeric part of the warning identifier must be specified. Multiple warnings are separated by semicolons. This parameter corresponds to the <c>/nowarn</c> switch of the compilers.</summary>
    /// <remarks>Project types: .NET</remarks>
    /// <value><c>NoWarn</c></value>
    public const string NoWarn = "NoWarn";

    /// <summary>A boolean value that indicates whether User Account Control (UAC) manifest information will be embedded in the application's executable. Applies only to Visual Studio projects targeting Windows Vista. In projects deployed using ClickOnce and Registration-Free COM, this element is ignored. False (the default value) specifies that User Account Control (UAC) manifest information be embedded in the application's executable. True specifies that UAC manifest information not be embedded.
    ///
    /// This property applies only to Visual Studio projects targeting Windows Vista. In projects deployed using ClickOnce and Registration-Free COM, this property is ignored.
    ///
    /// You should add NoWin32Manifest only if you do not want Visual Studio to embed any manifest information in the application's executable; this process is called virtualization. To use virtualization, set &lt;ApplicationManifest&gt; in conjunction with &lt;NoWin32Manifest&gt; as follows:
    ///
    /// - For Visual Basic projects, remove the &lt;ApplicationManifest&gt; node. (In Visual Basic projects, &lt;NoWin32Manifest&gt; is ignored when an &lt;ApplicationManifest&gt; node exists.)
    /// - For C# projects, set &lt;ApplicationManifest&gt; to False and &lt;NoWin32Manifest&gt; to True. (In C# projects, &lt;ApplicationManifest&gt; overrides &lt;NoWin32Manifest&gt;.)
    /// This property is equivalent to the <c>/nowin32manifest</c> compiler switch of vbc.exe.
    /// </summary>
    /// <remarks>Project types: .NET</remarks>
    /// <value><c>NoWin32Manifest</c></value>
    public const string NoWin32Manifest = "NoWin32Manifest";

    /// <summary>A boolean value that when set to true, enables compiler optimizations. This property is equivalent to the <c>/optimize</c> compiler switch.</summary>
    /// <remarks>Project types: .NET</remarks>
    /// <value><c>Optimize</c></value>
    public const string Optimize = "Optimize";

    /// <summary>Specifies how string comparisons are made. Valid values are "binary" or "text." This property is equivalent to the <c>/optioncompare</c> compiler switch of vbc.exe.</summary>
    /// <remarks>Project types: VisualBasic</remarks>
    /// <value><c>OptionCompare</c></value>
    public const string OptionCompare = "OptionCompare";

    /// <summary>A boolean value that when set to true, requires explicit declaration of variables in the source code. This property is equivalent to the <c>/optionexplicit</c> compiler switch.</summary>
    /// <remarks>Project types: Visual Basic</remarks>
    /// <value><c>OptionExplicit</c></value>
    public const string OptionExplicit = "OptionExplicit";

    /// <summary>A boolean value that when set to true, enables type inference of variables. This property is equivalent to the <c>/optioninfer</c> compiler switch.</summary>
    /// <remarks>Project types: Visual Basic</remarks>
    /// <value><c>OptionInfer</c></value>
    public const string OptionInfer = "OptionInfer";

    /// <summary>A boolean value that when set to true, causes the build task to enforce strict type semantics to restrict implicit type conversions. This property is equivalent to the <c>/optionstrict</c> switch of the vbc.exe compiler.</summary>
    /// <remarks>Project types: Visual Basic</remarks>
    /// <value><c>OptionStrict</c></value>
    public const string OptionStrict = "OptionStrict";

    /// <summary>Indicates the final output location for the project or solution. When building a solution, OutDir can be used to gather multiple project outputs in one location. In addition, OutDir is included in AssemblySearchPaths used for resolving references.</summary>
    /// <example>bin\Debug</example>
    /// <remarks>Project types: All</remarks>
    /// <value><c>OutDir</c></value>
    public const string OutDir = "OutDir";

    /// <summary>Specifies the path to the output directory, relative to the project directory.</summary>
    /// <example>bin\Debug</example>
    /// <example>bin\Debug\$(Platform) </example>
    /// <remarks>Project types: All</remarks>
    /// <value><c>OutputPath</c></value>
    public const string OutputPath = "OutputPath";

    /// <summary>Specifies the file format of the output file. This parameter can have one of the following values:
    ///
    /// - Library. Creates a code library. (Default value.)
    /// - Exe. Creates a console application.
    /// - Module. Creates a module.
    /// - Winexe. Creates a Windows-based program.
    ///
    /// For C# and Visual Basic, this property is equivalent to the <c>/target</c> switch. The output type can be automatically overridden by inferencing. See OutputType set to WinExe for WPF and WinForms apps. Disable inferencing by setting DisableWinExeOutputInference to true.</summary>
    /// <remarks>Project types: All</remarks>
    /// <value><c>OutputType</c></value>
    public const string OutputType = "OutputType";

    /// <summary>A boolean value that indicates whether you want to enable the build to overwrite read-only files or trigger an error.</summary>
    /// <remarks>Project types: All</remarks>
    /// <value><c>OverwriteReadOnlyFiles</c></value>
    public const string OverwriteReadOnlyFiles = "OverwriteReadOnlyFiles";

    /// <summary>Specifies how to map physical paths to source path names output by the compiler. This property is equivalent to the <c>/pathmap</c> switch of the compilers.</summary>
    /// <remarks>Project types: .NET</remarks>
    /// <value><c>PathMap</c></value>
    public const string PathMap = "PathMap";

    /// <summary>The file name of the .pdb file that you are emitting. This property is equivalent to the <c>/pdb</c> switch of the csc.exe compiler.</summary>
    /// <remarks>Project types: .NET</remarks>
    /// <value><c>PdbFile</c></value>
    public const string PdbFile = "PdbFile";

    /// <summary>The operating system you are building for. Examples for .NET Framework builds are "Any CPU", "x86", and "x64".</summary>
    /// <remarks>Project types: All</remarks>
    /// <value><c>Platform</c></value>
    public const string Platform = "Platform";

    /// <summary>The processor architecture that is used when assembly references are resolved. Valid values are "msil," "x86," "amd64," or "ia64."</summary>
    /// <remarks>Project types: .NET</remarks>
    /// <value><c>ProcessorArchitecture</c></value>
    public const string ProcessorArchitecture = "ProcessorArchitecture";

    /// <summary>A boolean value that instructs the compiler to emit only a reference assembly rather than compiled code. Cannot be used in conjunction with ProduceReferenceAssembly. This property corresponds to the <c>/refonly</c> switch of the vbc.exe and csc.exe compilers.</summary>
    /// <remarks>Project types: .NET</remarks>
    /// <value><c>ProduceOnlyReferenceAssembly</c></value>
    public const string ProduceOnlyReferenceAssembly = "ProduceOnlyReferenceAssembly";

    /// <summary>A boolean value that when set to true enables production of reference assemblies for the current assembly. Deterministic should be true when using this feature. This property corresponds to the <c>/refout</c> switch of the vbc.exe and csc.exe compilers.</summary>
    /// <remarks>Project types: .NET</remarks>
    /// <value><c>ProduceReferenceAssembly</c></value>
    public const string ProduceReferenceAssembly = "ProduceReferenceAssembly";

    /// <summary>A boolean value that indicates whether to disable integer overflow error checks. The default value is false. This property is equivalent to the <c>/removeintchecks</c> switch of the vbc.exe compiler.</summary>
    /// <remarks>Project types: Visual Basic</remarks>
    /// <value><c>RemoveIntegerChecks</c></value>
    public const string RemoveIntegerChecks = "RemoveIntegerChecks";

    /// <summary>The root namespace to use when you name an embedded resource. This namespace is part of the embedded resource manifest name.</summary>
    /// <remarks>Project types: All</remarks>
    /// <value><c>RootNamespace</c></value>
    public const string RootNamespace = "RootNamespace";

    /// <summary>The ID of the AL.exe hashing algorithm to use when satellite assemblies are created.</summary>
    /// <remarks>Project types: .NET</remarks>
    /// <value><c>Satellite_AlgorithmId</c></value>
    public const string Satellite_AlgorithmId = "Satellite_AlgorithmId";

    /// <summary>The base address to use when culture-specific satellite assemblies are built by using the CreateSatelliteAssemblies target.</summary>
    /// <remarks>Project types: .NET</remarks>
    /// <value><c>Satellite_BaseAddress</c></value>
    public const string Satellite_BaseAddress = "Satellite_BaseAddress";

    /// <summary>The company name to pass into AL.exe during satellite assembly generation.</summary>
    /// <remarks>Project types: .NET</remarks>
    /// <value><c>Satellite_CompanyName</c></value>
    public const string Satellite_CompanyName = "Satellite_CompanyName";

    /// <summary>The configuration name to pass into AL.exe during satellite assembly generation.</summary>
    /// <remarks>Project types: .NET</remarks>
    /// <value><c>Satellite_Configuration</c></value>
    public const string Satellite_Configuration = "Satellite_Configuration";

    /// <summary>The description text to pass into AL.exe during satellite assembly generation.</summary>
    /// <remarks>Project types: .NET</remarks>
    /// <value><c>Satellite_Description</c></value>
    public const string Satellite_Description = "Satellite_Description";

    /// <summary>Embeds the specified file in the satellite assembly that has the resource name "Security.Evidence."</summary>
    /// <remarks>Project types: .NET</remarks>
    /// <value><c>Satellite_EvidenceFile</c></value>
    public const string Satellite_EvidenceFile = "Satellite_EvidenceFile";

    /// <summary>Specifies a string for the File Version field in the satellite assembly.</summary>
    /// <remarks>Project types: .NET</remarks>
    /// <value><c>Satellite_FileVersion</c></value>
    public const string Satellite_FileVersion = "Satellite_FileVersion";

    /// <summary>Specifies a value for the Flags field in the satellite assembly.</summary>
    /// <remarks>Project types: .NET</remarks>
    /// <value><c>Satellite_Flags</c></value>
    public const string Satellite_Flags = "Satellite_Flags";

    /// <summary>Causes the build task to use absolute paths for any files reported in an error message.</summary>
    /// <remarks>Project types: .NET</remarks>
    /// <value><c>Satellite_GenerateFullPaths</c></value>
    public const string Satellite_GenerateFullPaths = "Satellite_GenerateFullPaths";

    /// <summary>Links the specified resource files to a satellite assembly.</summary>
    /// <remarks>Project types: .NET</remarks>
    /// <value><c>Satellite_LinkResource</c></value>
    public const string Satellite_LinkResource = "Satellite_LinkResource";

    /// <summary>Specifies the fully-qualified name (that is, class.method) of the method to use as an entry point when a module is converted to an executable file during satellite assembly generation.</summary>
    /// <remarks>Project types: .NET</remarks>
    /// <value><c>Satellite_MainEntryPoint</c></value>
    public const string Satellite_MainEntryPoint = "Satellite_MainEntryPoint";

    /// <summary>Specifies a string for the Product field in the satellite assembly.</summary>
    /// <remarks>Project types: .NET</remarks>
    /// <value><c>Satellite_ProductName</c></value>
    public const string Satellite_ProductName = "Satellite_ProductName";

    /// <summary>Specifies a string for the ProductVersion field in the satellite assembly.</summary>
    /// <remarks>Project types: .NET</remarks>
    /// <value><c>Satellite_ProductVersion</c></value>
    public const string Satellite_ProductVersion = "Satellite_ProductVersion";

    /// <summary>Specifies the file format of the satellite assembly output file as "library," "exe," or "win." The default value is "library."</summary>
    /// <remarks>Project types: .NET</remarks>
    /// <value><c>Satellite_TargetType</c></value>
    public const string Satellite_TargetType = "Satellite_TargetType";

    /// <summary>Specifies a string for the Title field in the satellite assembly.</summary>
    /// <remarks>Project types: .NET</remarks>
    /// <value><c>Satellite_Title</c></value>
    public const string Satellite_Title = "Satellite_Title";

    /// <summary>Specifies a string for the Trademark field in the satellite assembly.</summary>
    /// <remarks>Project types: .NET</remarks>
    /// <value><c>Satellite_Trademark</c></value>
    public const string Satellite_Trademark = "Satellite_Trademark";

    /// <summary>Specifies the version information for the satellite assembly.</summary>
    /// <remarks>Project types: .NET</remarks>
    /// <value><c>Satellite_Version</c></value>
    public const string Satellite_Version = "Satellite_Version";

    /// <summary>Inserts an .ico icon file in the satellite assembly.</summary>
    /// <remarks>Project types: .NET</remarks>
    /// <value><c>Satellite_Win32Icon</c></value>
    public const string Satellite_Win32Icon = "Satellite_Win32Icon";

    /// <summary>Inserts a Win32 resource (.res file) into the satellite assembly.</summary>
    /// <remarks>Project types: .NET</remarks>
    /// <value><c>Satellite_Win32Resource</c></value>
    public const string Satellite_Win32Resource = "Satellite_Win32Resource";

    /// <summary>An optional tool path that indicates where to obtain SGen.exe when the current version of SGen.exe is overridden.</summary>
    /// <remarks>Project types: .NET</remarks>
    /// <value><c>SGenToolPath</c></value>
    public const string SGenToolPath = "SGenToolPath";

    /// <summary>A boolean value that indicates whether proxy types should be generated by SGen.exe. This applies only when GenerateSerializationAssemblies is set to on.
    ///
    /// The SGen target uses this property to set the UseProxyTypes flag. This property defaults to true, and there is no UI to change this. To generate the serialization assembly for non-webservice types, add this property to the project file and set it to false before importing the Microsoft.Common.Targets or the C#/VB.targets.</summary>
    /// <remarks>Project types: .NET</remarks>
    /// <value><c>SGenUseProxyTypes</c></value>
    public const string SGenUseProxyTypes = "SGenUseProxyTypes";

    /// <summary>When true, generate a warning on invalid platform and configuration combinations, but do not fail the build; when false or undefined (the default), generate an error.</summary>
    /// <remarks>Project types: All</remarks>
    /// <value><c>SkipInvalidConfigurations</c></value>
    public const string SkipInvalidConfigurations = "SkipInvalidConfigurations";

    /// <summary>Specifies the class or module that contains the Main method or Sub Main procedure. This property is equivalent to the <c>/main</c> compiler switch.</summary>
    /// <remarks>Project types: .NET</remarks>
    /// <value><c>StartupObject</c></value>
    public const string StartupObject = "StartupObject";

    /// <summary>Specifies the minimum version of the subsystem that the generated executable file can use. This property is equivalent to the <c>/subsystemversion</c> compiler switch. For information about the default value of this property, see <c>/subsystemversion</c> (Visual Basic) or <c>/subsystemversion</c> (C# compiler options).</summary>
    /// <remarks>Project types: .NET</remarks>
    /// <value><c>SubsystemVersion</c></value>
    public const string SubsystemVersion = "SubsystemVersion";

    /// <summary>The version of the .NET Compact Framework that is required to run the application that you are building. Specifying this lets you reference certain framework assemblies that you may not be able to reference otherwise.</summary>
    /// <remarks>Project types: .NET</remarks>
    /// <value><c>TargetCompactFramework</c></value>
    public const string TargetCompactFramework = "TargetCompactFramework";

    /// <summary>The version of the .NET Framework that is required to run the application that you are building. Specifying this lets you reference certain framework assemblies that you may not be able to reference otherwise.</summary>
    /// <remarks>Project types: .NET</remarks>
    /// <value><c>TargetFrameworkVersion</c></value>
    public const string TargetFrameworkVersion = "TargetFrameworkVersion";

    /// <summary>A boolean parameter that, if true, causes all warnings to be treated as errors. This parameter is equivalent to the <c>/nowarn</c> compiler switch.</summary>
    /// <remarks>Project types: .NET</remarks>
    /// <value><c>TreatWarningsAsErrors</c></value>
    public const string TreatWarningsAsErrors = "TreatWarningsAsErrors";

    /// <summary>A boolean property that you can set to true when you want all build outputs in a solution to use the same output directory. If true, referenced projects' output is not copied to projects that use those dependencies, as is normally the case when this setting is false. Setting this parameter to true does not change the actual output directory of any projects; you still need to set the output directory to the desired common output directory for each project that requires it.</summary>
    /// <remarks>Project types: .NET</remarks>
    /// <value><c>UseCommonOutputDirectory</c></value>
    public const string UseCommonOutputDirectory = "UseCommonOutputDirectory";

    /// <summary>A boolean parameter that, if true, causes the build task to use the in-process compiler object, if it is available. This parameter is used only by Visual Studio.</summary>
    /// <remarks>Project types: .NET</remarks>
    /// <value><c>UseHostCompilerIfAvailable</c></value>
    public const string UseHostCompilerIfAvailable = "UseHostCompilerIfAvailable";

    /// <summary>A boolean parameter that, if true, logs compiler output by using UTF-8 encoding. This parameter is equivalent to the <c>/utf8Output</c> compiler switch.</summary>
    /// <remarks>Project types: .NET</remarks>
    /// <value><c>Utf8Output</c></value>
    public const string Utf8Output = "Utf8Output";

    /// <summary>An optional path that indicates another location for vbc.exe when the current version of vbc.exe is overridden.</summary>
    /// <remarks>Project types: Visual Basic</remarks>
    /// <value><c>VbcToolPath</c></value>
    public const string VbcToolPath = "VbcToolPath";

    /// <summary>Specifies the verbosity of the Visual Basic compiler's output. Valid values are "Quiet," "Normal" (the default value), or "Verbose."</summary>
    /// <remarks>Project types: Visual Basic</remarks>
    /// <value><c>VbcVerbosity</c></value>
    public const string VbcVerbosity = "VbcVerbosity";

    /// <summary>Specifies the version of Visual Studio under which this project should be considered to be running. If this property isn't specified, MSBuild sets it to a default value of {VisualStudioMajorVersion}.0; for instance it will be 17.0 for all versions of Visual Studio 2022.
    ///
    /// This property is used in several project types to specify the set of targets that are used for the build. If ToolsVersion is set to 4.0 or higher for a project, VisualStudioVersion is used to specify which sub-toolset to use. For more information, see Toolset (ToolsVersion).</summary>
    /// <remarks>Project types: All</remarks>
    /// <value><c>VisualStudioVersion</c></value>
    public const string VisualStudioVersion = "VisualStudioVersion";

    /// <summary>Specifies a list of warnings to treat as errors. This parameter is equivalent to the <c>/warnaserror</c> compiler switch.</summary>
    /// <remarks>Project types: .NET</remarks>
    /// <value><c>WarningsAsErrors</c></value>
    public const string WarningsAsErrors = "WarningsAsErrors";

    /// <summary>Specifies the warning level to pass to the compilers for warnings emitted by the compiler. This setting doesn't affect MSBuild warnings, which do not have level designations. See Warning Level in the C# compiler documentation and <c>/W</c> (Warning level) in the C++ compiler documentation.</summary>
    /// <remarks>Project types: All</remarks>
    /// <value><c>WarningLevel</c></value>
    public const string WarningLevel = "WarningLevel";

    /// <summary>Specifies a list of warnings that are not treated as errors. This parameter is equivalent to the <c>/warnaserror</c> compiler switch.</summary>
    /// <remarks>Project types: .NET</remarks>
    /// <value><c>WarningsNotAsErrors</c></value>
    public const string WarningsNotAsErrors = "WarningsNotAsErrors";

    /// <summary>The name of the manifest file that should be embedded in the final assembly. This parameter is equivalent to the <c>/win32Manifest</c> compiler switch.</summary>
    /// <remarks>Project types: .NET</remarks>
    /// <value><c>Win32Manifest</c></value>
    public const string Win32Manifest = "Win32Manifest";

    /// <summary>The file name of the Win32 resource to be embedded in the final assembly. This parameter is equivalent to the <c>/win32resource</c> compiler switch.</summary>
    /// <remarks>Project types: .NET</remarks>
    /// <value><c>Win32Resource</c></value>
    public const string Win32Resource = "Win32Resource";

    /// <summary>Framework that this project targets. Must be a Target Framework Moniker (e.g. netcoreapp1.0).</summary>
    /// <example>netcoreapp1.0</example>
    /// <value><c>TargetFramework</c></value>
    public const string TargetFramework = "TargetFramework";

    /// <summary>Semi-colon separated list of frameworks that this project targets. Must be a Target Framework Moniker.</summary>
    /// <example>netcoreapp1.0;net461</example>
    /// <value><c>TargetFrameworks</c></value>
    public const string TargetFrameworks = "TargetFrameworks";

    /// <summary>Specifies the version of the .NET Framework that is required to run the application that you are building. Specifying this lets you reference certain framework assemblies that you may not be able to reference otherwise.</summary>
    /// <remarks>Project types: .NET</remarks>
    /// <value><c>TargetFrameworkMoniker</c></value>
    public const string TargetFrameworkMoniker = "TargetFrameworkMoniker";

    /// <summary>Semi-colon separated list of culture names to preserve satellite resource assemblies during build and publish. Names must be a valid culture name (like en-US;it; or fr). If left empty, all satellite resource assemblies will be preserved. Defaults to empty.</summary>
    /// <example>en-US;it;fr</example>
    /// <value><c>SatelliteResourceLanguages</c></value>
    public const string SatelliteResourceLanguages = "SatelliteResourceLanguages";

    /// <summary>The type of the repository where the project is stored (e.g. git)</summary>
    /// <example>git</example>
    /// <value><c>RepositoryType</c></value>
    public const string RepositoryType = "RepositoryType";

    /// <summary>The URL of the repository where the project is stored</summary>
    /// <example>https://github.com/Dgmjr/MSBuild.Utils</example>
    /// <value><c>RepositoryUrl</c></value>
    public const string RepositoryUrl = "RepositoryUrl";

    /// <summary>Set the nullable annotations and warnings context for the C# project. Possible values are enable, disable, warnings and annotations.</summary>
    /// <example>enable</example>
    /// <value><c>Nullable</c></value>
    public const string Nullable = "Nullable";

    /// <summary>Specifies the version of the  programming language the project uses</summary>
    /// <example>enable</example>
    /// <value><c>LangVersion</c></value>
    public const string LangVersion = "LangVersion";

    /// <summary>Specifies whether to allow <see langword="unsafe" /> code blaocks in the project</summary>
    /// <example>enable</example>
    /// <value><c>AllowUnsafeBlocks</c></value>
    public const string AllowUnsafeBlocks = "AllowUnsafeBlocks";
}
