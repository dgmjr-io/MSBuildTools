/*
 * Constants.cs
 *
 *   Created: 2022-11-26-01:43:13
 *   Modified: 2022-11-26-01:43:14
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */
namespace Dgmjr.MSBuild.Constants;

public static class MSBuildPropertyNames
{
    /// <summary>
    /// Path to the root folder for .NET Framework tools.
    /// </summary>
    /// <example>
    /// C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\
    /// </example>
    /// <remarks>Well-known</remarks>
    public const string FrameworkSDKRoot = nameof(FrameworkSDKRoot);

    /// <summary>
    /// Specifies the property name that defines the multitargeting build dimension (applicable only if the current build is a graph build).
    /// </summary>
    /// <example>
    /// TargetFramework
    /// </example>
    /// <remarks>Well-known</remarks>
    public const string InnerBuildProperty = nameof(InnerBuildProperty);

    /// <summary>
    /// Specifies the property name that holds the possible values for the InnerBuildProperty (applicable only if the current build is a graph build).
    /// </summary>
    /// <example>
    /// TargetFrameworks
    /// </example>
    /// <remarks>Well-known</remarks>
    public const string InnerBuildPropertyValues = nameof(InnerBuildPropertyValues);

    /// <summary>
    /// True if this is a graph build; that is, the -graphBuild option is in effect. This option means that MSBuild constructs and builds a project graph. Constructing a graph involves identifying project references to form dependencies. Building that graph involves attempting to build project references prior to the projects that reference them, differing from traditional MSBuild scheduling.
    /// </summary>
    /// <example>
    ///
    /// </example>
    /// <remarks>Well-known</remarks>
    public const string IsGraphBuild = nameof(IsGraphBuild);

    /// <summary>
    /// The version of MSBuild assemblies used to build the project.
    /// </summary>
    /// <example>
    /// 17
    /// </example>
    /// <remarks>Reserved</remarks>
    public const string MSBuildAssemblyVersion = nameof(MSBuildAssemblyVersion);

    /// <summary>
    /// The absolute path of the folder where the MSBuild binaries that are currently being used are located (for example, C:\Windows\Microsoft.Net\Framework\&lt;versionNumber&gt;). This property is useful if you have to refer to files in the MSBuild directory.
    ///
    /// Do not include the final backslash on this property.
    /// </summary>
    /// <example>
    /// C:\Program Files\Microsoft Visual Studio\2022\MSBuild\Current\Bin\amd64
    /// </example>
    /// <remarks>Reserved</remarks>
    public const string MSBuildBinPath = nameof(MSBuildBinPath);

    /// <summary>
    /// <para>Introduced in the .NET Framework 4: there is no difference between the default values of MSBuildExtensionsPath and MSBuildExtensionsPath32. You can set the environment variable MSBUILDLEGACYEXTENSIONSPATH to a non-null value to enable the behavior of the default value of MSBuildExtensionsPath in earlier versions.</para>
    ///
    /// <para>In the .NET Framework 3.5 and earlier, the default value of MSBuildExtensionsPath points to the path of the MSBuild subfolder under the \Program Files\ or \Program Files (x86) folder, depending on the bitness of the current process. For example, for a 32-bit process on a 64-bit machine, this property points to the \Program Files (x86) folder. For a 64-bit process on a 64-bit machine, this property points to the \Program Files folder.</para>
    ///
    /// <para>Do not include the final backslash on this property.</para>
    ///
    /// <para>This location is a useful place to put custom target files. For example, your target files could be installed at \Program Files\MSBuild\MyFiles\Northwind.targets and then imported in project files by using this XML code:</para>
    ///
    /// &lt;Import Project=$(MSBuildExtensionsPath)\MyFiles\Northwind.targets/&gt;
    /// </summary>
    /// <example>
    /// C:\Program Files\Microsoft Visual Studio\2022\MSBuild
    /// </example>
    /// <remarks>Well-known</remarks>
    public const string MSBuildExtensionsPath = nameof(MSBuildExtensionsPath);

    /// <summary>
    /// <para>The path of the MSBuild subfolder under the \Program Files or \Program Files (x86) folder. The path always points to the 32-bit \Program Files (x86) folder on a 32-bit machine and \Program Files on a 64-bit machine.. See also MSBuildExtensionsPath and MSBuildExtensionsPath64.</para>
    ///
    /// <para>Do not include the final backslash on this property.</para>
    /// </summary>
    /// <example>
    /// C:\Program Files\Microsoft Visual Studio\2022\MSBuild
    /// </example>
    /// <remarks>Well-known</remarks>
    public const string MSBuildExtensionsPath32 = nameof(MSBuildExtensionsPath32);

    /// <summary>
    /// <para>The path of the MSBuild subfolder under the \Program Files folder. For a 64-bit machine, this path always points to the \Program Files folder. For a 32-bit machine, this path is blank. See also MSBuildExtensionsPath and MSBuildExtensionsPath32.</para>
    ///
    /// <para>Do not include the final backslash on this property.</para>
    /// </summary>
    /// <example>
    /// C:\Program Files\MSBuild
    /// </example>
    /// <remarks>Well-known</remarks>
    public const string MSBuildExtensionsPath64 = nameof(MSBuildExtensionsPath64);

    /// <summary>
    /// The 4 part version of MSBuild assemblies used to build the project.
    /// </summary>
    /// <example>
    /// 17.4.0.46505
    /// </example>
    /// <remarks>Reserved</remarks>
    public const string MSBuildFileVersion = nameof(MSBuildFileVersion);

    /// <summary>
    /// The path to the .NET Framework tools that the currently executing MSBuild was built with, with a trailing slash.
    /// </summary>
    /// <example>
    /// C:\WINDOWS\Microsoft.NET\Framework\v4.0.30319\
    /// </example>
    /// <remarks>Well-known</remarks>
    public const string MSBuildFrameworkToolsPath = nameof(MSBuildFrameworkToolsPath);

    /// <summary>
    /// The path to the 32-bit version of the .NET Framework tools for the same framework version that the currently executing MSBuild was built with, with a trailing slash.
    /// </summary>
    /// <example>
    /// C:\WINDOWS\Microsoft.NET\Framework\v4.0.30319\
    /// </example>
    /// <remarks>Well-known</remarks>
    public const string MSBuildFrameworkToolsPath32 = nameof(MSBuildFrameworkToolsPath32);

    /// <summary>
    /// The path to the 64-bit version of the .NET Framework tools for the same framework version that the currently executing MSBuild was built with, with a trailing slash.
    /// </summary>
    /// <example>
    /// C:\WINDOWS\Microsoft.NET\Framework64\v4.0.30319\
    /// </example>
    /// <remarks>Well-known</remarks>
    public const string MSBuildFrameworkToolsPath64 = nameof(MSBuildFrameworkToolsPath64);

    /// <summary>
    /// true if MSBuild is running interactively, allowing user input. This setting is controlled by the -interactive command-line option.
    /// </summary>
    /// <example>
    /// FALSE
    /// </example>
    /// <remarks>Reserved</remarks>
    public const string MSBuildInteractive = nameof(MSBuildInteractive);

    /// <summary>
    /// <c><see langword="true" /></c> if the previous task completed without any errors (even if there were warnings), or false if the previous task had errors. Typically, when an error occurs in a task, the error is the last thing that happens in that project. Therefore, the value of this property is never false, except in these scenarios:
    /// * When the ContinueOnError attribute of the Task element (MSBuild) is set to WarnAndContinue (or true) or ErrorAndContinue.
    /// * When the Target has an OnError element (MSBuild) as a child element.
    /// </summary>
    /// <example>
    /// TRUE
    /// </example>
    /// <remarks>Reserved</remarks>
    public const string MSBuildLastTaskResult = nameof(MSBuildLastTaskResult);

    /// <summary>
    /// The maximum number of concurrent processes that are used when building. This is the value that you specified for -maxcpucount on the command line. If you specified -maxcpucount without specifying a value, then MSBuildNodeCount specifies the number of processors in the computer. For more information, see Command-line reference and Build multiple projects in parallel.
    /// </summary>
    /// <example>
    /// 1
    /// </example>
    /// <remarks>Reserved</remarks>
    public const string MSBuildNodeCount = nameof(MSBuildNodeCount);

    /// <summary>
    /// The location of the 32-bit program folder; for example, C:\Program Files (x86).
    ///
    /// Do not include the final backslash on this property.
    /// </summary>
    /// <example>
    /// C:\Program Files (x86)
    /// </example>
    /// <remarks>Reserved</remarks>
    public const string MSBuildProgramFiles32 = nameof(MSBuildProgramFiles32);

    /// <summary>
    /// The complete list of targets that are specified in the DefaultTargets attribute of the Project element. For example, the following Project element would have an MSBuildDefaultTargets property value of A;B;C:
    ///
    /// &lt;Project DefaultTargets=A;B;C &gt;
    /// </summary>
    /// <example>
    /// Build
    /// </example>
    /// <remarks>Reserved</remarks>
    public const string MSBuildProjectDefaultTargets = nameof(MSBuildProjectDefaultTargets);

    /// <summary>
    /// The absolute path of the directory where the project file is located, for example C:\MyCompany\MyProduct.
    ///
    /// Do not include the final backslash on this property.
    /// </summary>
    /// <example>
    /// C:\Source\Repos\ConsoleApp1\ConsoleApp1
    /// </example>
    /// <remarks>Reserved</remarks>
    public const string MSBuildProjectDirectory = nameof(MSBuildProjectDirectory);

    /// <summary>
    /// The value of the MSBuildProjectDirectory property, excluding the root drive.
    ///
    /// Do not include the final backslash on this property.
    /// </summary>
    /// <example>
    /// Source\Repos\ConsoleApp1\ConsoleApp1
    /// </example>
    /// <remarks>Reserved</remarks>
    public const string MSBuildProjectDirectoryNoRoot = nameof(MSBuildProjectDirectoryNoRoot);

    /// <summary>
    /// The file name extension of the project file, including the period; for example, .proj.
    /// </summary>
    /// <example>
    /// .csproj
    /// </example>
    /// <remarks>Reserved</remarks>
    public const string MSBuildProjectExtension = nameof(MSBuildProjectExtension);

    /// <summary>
    /// The complete file name of the project file, including the file name extension; for example, MyApp.proj.
    /// </summary>
    /// <example>
    /// ConsoleApp1.csproj
    /// </example>
    /// <remarks>Reserved</remarks>
    public const string MSBuildProjectFile = nameof(MSBuildProjectFile);

    /// <summary>
    /// The absolute path and complete file name of the project file, including the file name extension; for example, C:\MyCompany\MyProduct\MyApp.proj.
    /// </summary>
    /// <example>
    /// c:\Source\Repos\ConsoleApp1\ConsoleApp1\ConsoleApp1.csproj
    /// </example>
    /// <remarks>Reserved</remarks>
    public const string MSBuildProjectFullPath = nameof(MSBuildProjectFullPath);

    /// <summary>
    /// The file name of the project file without the file name extension; for example, MyApp.
    /// </summary>
    /// <example>
    /// ConsoleApp1
    /// </example>
    /// <remarks>Reserved</remarks>
    public const string MSBuildProjectName = nameof(MSBuildProjectName);

    /// <summary>
    /// The type of the runtime that is currently executing. Introduced in MSBuild 15. Value may be undefined (prior to MSBuild 15), Full indicating that MSBuild is running on the desktop .NET Framework, Core indicating that MSBuild is running on .NET Core (for example in dotnet build), or Mono indicating that MSBuild is running on Mono.
    /// </summary>
    /// <example>
    /// Full
    /// </example>
    /// <remarks>Reserved</remarks>
    public const string MSBuildRuntimeType = nameof(MSBuildRuntimeType);

    /// <summary>
    /// The absolute path of the folder where MSBuild is called. By using this property, you can build everything below a specific point in a project tree without creating &lt;dirs&gt;.proj files in every directory. Instead, you have just one project—for example, c:\traversal.proj, as shown here:
    ///
    /// &lt;Project ...&gt; &lt;ItemGroup&gt; &lt;ProjectFiles Include=$ (MSBuildStartupDirectory) **\*.csproj/&gt; &lt;/ItemGroup&gt; &lt;Target Name=build&gt; &lt;MSBuild Projects=@(ProjectFiles)/&gt; &lt;/Target&gt; &lt;/Project&gt;
    ///
    /// To build at any point in the tree, type:
    ///
    /// msbuild c:\traversal.proj
    ///
    /// Do not include the final backslash on this property.
    /// </summary>
    /// <example>
    /// c:\Source\Repos\ConsoleApp1
    /// </example>
    /// <remarks>Reserved</remarks>
    public const string MSBuildStartupDirectory = nameof(MSBuildStartupDirectory);

    /// <summary>
    /// The file name and file extension portion of MSBuildThisFileFullPath.
    /// </summary>
    /// <example>
    /// ConsoleApp1.csproj
    /// </example>
    /// <remarks>Reserved</remarks>
    public const string MSBuildThisFile = nameof(MSBuildThisFile);

    /// <summary>
    /// The directory portion of MSBuildThisFileFullPath.
    ///
    /// Include the final backslash in the path.
    /// </summary>
    /// <example>
    /// c:\Source\Repos\ConsoleApp1\ConsoleApp1\
    /// </example>
    /// <remarks>Reserved</remarks>
    public const string MSBuildThisFileDirectory = nameof(MSBuildThisFileDirectory);

    /// <summary>
    /// The directory portion of MSBuildThisFileFullPath, excluding the root drive.
    ///
    /// Include the final backslash in the path.
    /// </summary>
    /// <example>
    /// Source\Repos\ConsoleApp1\ConsoleApp1\
    /// </example>
    /// <remarks>Reserved</remarks>
    public const string MSBuildThisFileDirectoryNoRoot = nameof(MSBuildThisFileDirectoryNoRoot);

    /// <summary>
    /// The file name extension portion of MSBuildThisFileFullPath.
    /// </summary>
    /// <example>
    /// .csproj
    /// </example>
    /// <remarks>Reserved</remarks>
    public const string MSBuildThisFileExtension = nameof(MSBuildThisFileExtension);

    /// <summary>
    /// The absolute path of the project or targets file that contains the target that is running.
    ///
    /// Tip: You can specify a relative path in a targets file that's relative to the targets file and not relative to the original project file.
    /// </summary>
    /// <example>
    /// c:\Source\Repos\ConsoleApp1\ConsoleApp1\ConsoleApp1.csproj
    /// </example>
    /// <remarks>Reserved</remarks>
    public const string MSBuildThisFileFullPath = nameof(MSBuildThisFileFullPath);

    /// <summary>
    /// The file name portion of MSBuildThisFileFullPath, without the file name extension.
    /// </summary>
    /// <example>
    /// ConsoleApp1
    /// </example>
    /// <remarks>Reserved</remarks>
    public const string MSBuildThisFileName = nameof(MSBuildThisFileName);

    /// <summary>
    /// The installation path of the MSBuild version that's associated with the value of MSBuildToolsVersion.
    ///
    /// Do not include the final backslash in the path.
    ///
    /// This property cannot be overridden.
    /// </summary>
    /// <example>
    /// C:\Program Files\Microsoft Visual Studio\2022\MSBuild\Current\Bin\amd64
    /// </example>
    /// <remarks>Reserved</remarks>
    public const string MSBuildToolsPath = nameof(MSBuildToolsPath);

    /// <summary>
    /// The installation path of the 32-bit MSBuild version that's associated with the value of MSBuildToolsVersion.
    ///
    /// Do not include the final backslash in the path.
    ///
    /// This property cannot be overridden.
    /// </summary>
    /// <example>
    /// C:\Program Files\Microsoft Visual Studio\2022\MSBuild\Current\Bin
    /// </example>
    /// <remarks>Well-known</remarks>
    public const string MSBuildToolsPath32 = nameof(MSBuildToolsPath32);

    /// <summary>
    /// The installation path of the 64-bit MSBuild version that's associated with the value of MSBuildToolsVersion.
    ///
    /// Do not include the final backslash in the path.
    ///
    /// This property cannot be overridden.
    /// </summary>
    /// <example>
    /// C:\Program Files\Microsoft Visual Studio\2022\MSBuild\Current\Bin\amd64
    /// </example>
    /// <remarks>Well-known</remarks>
    public const string MSBuildToolsPath64 = nameof(MSBuildToolsPath64);

    /// <summary>
    /// The version of the MSBuild Toolset that is used to build the project.
    ///
    /// Note: An MSBuild Toolset consists of tasks, targets, and tools that are used to build an application. The tools include compilers such as csc.exe and vbc.exe. For more information, see Toolset (ToolsVersion), and Standard and custom Toolset configurations.
    /// </summary>
    /// <example>
    /// Current
    /// </example>
    /// <remarks>Reserved</remarks>
    public const string MSBuildToolsVersion = nameof(MSBuildToolsVersion);

    /// <summary>
    /// The path MSBuild uses to find SDKs.
    /// </summary>
    /// <example>
    /// C:\Program Files\Microsoft Visual Studio\2022\MSBuild\Sdks
    /// </example>
    /// <remarks>Well-known</remarks>
    public const string MSBuildSDKsPath = nameof(MSBuildSDKsPath);

    /// <summary>
    /// The full semver 2.0 version of MSBuild assemblies used to build the project.
    /// </summary>
    /// <example>
    /// 17.4.0-preview-22465-05+6033e4c95
    /// </example>
    /// <remarks>Reserved</remarks>
    public const string MSBuildSemanticVersion = nameof(MSBuildSemanticVersion);

    /// <summary>
    /// The version of MSBuild used to build the project.
    ///
    /// This property can't be overridden, otherwise the error message MSB4004 - The 'MSBuildVersion' property is reserved, and can not be modified. is returned.
    /// </summary>
    /// <example>
    /// 17.4.0
    /// </example>
    /// <remarks>Reserved</remarks>
    public const string MSBuildVersion = nameof(MSBuildVersion);

    /// <summary>
    /// A list of warning codes to treat as errors.
    /// </summary>
    /// <example>
    /// MSB1234;MSB5678
    /// </example>
    /// <remarks>Well-known</remarks>
    public const string MSBuildWarningsAsErrors = nameof(MSBuildWarningsAsErrors);

    /// <summary>
    /// A list of warning codes to treat as messages.
    /// </summary>
    /// <example>
    /// MSB1234;MSB5678
    /// </example>
    /// <remarks>Well-known</remarks>
    public const string MSBuildWarningsAsMessages = nameof(MSBuildWarningsAsMessages);

    /// <summary>
    /// A list of warning codes that should not be promoted to errors even if the -warnAsError switch is set to promote all other warnings to errors. Note that it has no effect if that is not true.
    /// </summary>
    /// <example>
    /// MSB1234;MSB5678
    /// </example>
    /// <remarks>Well-known</remarks>
    public const string MSBuildWarningsNotAsErrors = nameof(MSBuildWarningsNotAsErrors);

    /// <summary>
    /// Path to targets for Roslyn compilers.
    /// </summary>
    /// <example>
    /// C:\Program Files\Microsoft Visual Studio\2022\MSBuild\Current\Bin\Roslyn
    /// </example>
    /// <remarks>Well-known</remarks>
    public const string RoslynTargetsPath = nameof(RoslynTargetsPath);

    /// <summary>
    /// Path to .NET Framework 3.5 tools.
    /// </summary>
    /// <example>
    ///
    /// </example>
    /// <remarks>Well-known</remarks>
    public const string SDK35ToolsPath = nameof(SDK35ToolsPath);

    /// <summary>
    /// Path to .NET Framework 4.0 tools.
    /// </summary>
    /// <example>
    /// C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\bin\NETFX 4.8 Tools\
    /// </example>
    /// <remarks>Well-known</remarks>
    public const string SDK40ToolsPath = nameof(SDK40ToolsPath);

    /// <summary>
    /// The Visual Studio installation folder.
    /// </summary>
    /// <example>
    /// C:\Program Files\Microsoft Visual Studio\2022
    /// </example>
    /// <remarks>Well-known</remarks>
    public const string VsInstallRoot = nameof(VsInstallRoot);

    /// <summary>
    /// Path to the Windows 8 SDK.
    /// </summary>
    /// <example>
    ///
    /// </example>
    /// <remarks>Well-known</remarks>
    public const string WindowsSDK80Path = nameof(WindowsSDK80Path);

    /// <summary>A long description of the NuGet package for UI display</summary>

    public const string Description = nameof(Description);
}
