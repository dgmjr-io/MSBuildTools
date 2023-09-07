/*
 * GetCommandLineArgs.cs
 *
 *   Created: 2022-11-12-04:15:12
 *   Modified: 2022-11-19-04:04:29
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace Dgmjr.MSBuild.Tasks;

// Taken from https://stackoverflow.com/questions/3260913/how-to-access-the-msbuild-command-line-parameters-from-within-the-project-file-b
using System;
using System.IO;
using System.Linq;
using Dgmjr.MSBuild.Extensions;
using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;
using static Dgmjr.MSBuild.Constants.MSBuildPropertyNames;

public sealed class GetCommandLineArgs : MSBTask, IEqualityComparer<string>
{
    private static readonly string[] _argsToRemove = { "msbuild", "build", "pack", "restore", "clean", "test", "publish", "run", "dotnet" };

    private readonly string[] PropertiesToRemove = {
        MSBuildToolsPath,
        MSBuildToolsPath32,
        MSBuildThisFileDirectory,
        MSBuildThisFile,
        MSBuildStartupDirectory,
        MSBuildFrameworkToolsPath,
        MSBuildFrameworkToolsPath32,
        MSBuildFrameworkToolsPath64,
        MSBuildExtensionsPath,
        MSBuildExtensionsPath32,
        MSBuildExtensionsPath64,
        MSBuildBinPath,
        FrameworkSDKRoot,
        MSBuildProjectFile,
        MSBuildThisFileFullPath,
        MSBuildProjectFullPath
    };

    private string[] ProjectFilePermutations => new[] {
        BuildEngine.ProjectFileOfTaskNode,
        Path.GetFileName(BuildEngine.ProjectFileOfTaskNode)
    };

    private string[] ArgsToRemove => _argsToRemove.Concat(PropertiesToRemove.Select(p => AllEvaluatedProperties[p])).Concat(ProjectFilePermutations).ToArray();

    [Output]
    public ITaskItem[] CommandLineArgs { get; private set; } = Array.Empty<ITaskItem>();
    [Output]
    public string FullCommandLine { get; private set; } = string.Empty;

    private IDictionary<string, string>? _allEvaluatedProperties;
    private IDictionary<string, string> AllEvaluatedProperties => _allEvaluatedProperties ??= this.GetAllEvaluatedProperties();

    /// <summary>
    /// Executes the task. This is where you get the command line arguments and properties to remove from the command line.
    /// </summary>
    /// <returns>True if the task executed successfully ; otherwise false. If false the task should be retried with another task</returns>
    public override bool Execute()
    {
        var commandLineArgs = Environment.GetCommandLineArgs().Except(ArgsToRemove, this);//.Except(new[] { "/Users/david/GitHub/Dgmjr/libs/src/MSBuild.Utils/src/GetCommandLineArgs/GetCommandLineArgs.csproj" });
        CommandLineArgs = commandLineArgs.Select(a => new TaskItem(a)).ToArray();
        FullCommandLine = string.Join(" ", Environment.GetCommandLineArgs());
        Log.LogMessage(MessageImportance.High, $"Full command line: *{FullCommandLine}*");
        Log.LogMessage(MessageImportance.High, $"Command line args: {string.Join(" ", commandLineArgs)}");
        Log.LogMessage(MessageImportance.High, $"Properties to remove: {string.Join(",\n", PropertiesToRemove.Select(p => $"{p}: {AllEvaluatedProperties[p]}"))}");
        return true;
    }

    /// <summary>Determines whether two instances are equal.</summary>
    /// <param name="x">The first to compare.</param>
    /// <param name="y">The second to compare.</param>
    /// <returns> true if the two specified instances are equal ; otherwise false</returns>
    public bool Equals(string? x, string? y)
        => x.Equals(y, StringComparison.OrdinalIgnoreCase) ||
            x.EndsWith(y + ".exe", StringComparison.OrdinalIgnoreCase) ||
            y.EndsWith(x + ".exe", StringComparison.OrdinalIgnoreCase) ||
            x.StartsWith(y + ".exe", StringComparison.OrdinalIgnoreCase) ||
            y.StartsWith(x + ".exe", StringComparison.OrdinalIgnoreCase) ||
            x.EndsWith(y + ".dll", StringComparison.OrdinalIgnoreCase) ||
            y.EndsWith(x + ".dll", StringComparison.OrdinalIgnoreCase) ||
            x.StartsWith(y + ".dll", StringComparison.OrdinalIgnoreCase) ||
            y.StartsWith(x + ".dll", StringComparison.OrdinalIgnoreCase);


    /// <summary>
    /// Returns a hash code for the specified object. This is used to determine whether or not a object is the same as another object in the same language.
    /// </summary>
    /// <param name="obj">The object to get a hash code for.</param>
    /// <returns>A hash code for the specified object or if the object is the same as another object in the same language</returns>
    public int GetHashCode(string obj) => 1;
}
