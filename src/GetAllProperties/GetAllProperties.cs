/*
 * GetAllProperties.cs
 *
 *   Created: 2023-01-24-03:31:43
 *   Modified: 2023-01-24-03:31:44
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace Dgmjr.MSBuild.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dgmjr.MSBuild.Extensions;
using Microsoft.Build.Construction;
using Microsoft.Build.Evaluation;
using Microsoft.Build.Execution;
using Microsoft.Build.Framework;
using Microsoft.Build.Logging;
using Microsoft.Build.Utilities;

public class GetAllProperties : MSBTask
{
    private string? _projectFile;
    public string ProjectFile
    {
        get => _projectFile ??= this.TryGetProject().FullPath;
        set => _projectFile = value;
    }

    [Output]
    public ITaskItem[] Properties { get; set; }

    public override bool Execute()
    {
        if (!File.Exists(ProjectFile))
        {
            Log.LogError($"Project file '{ProjectFile}' does not exist.");
            return false;
        }

        var project = ProjectRootElement.Open(ProjectFile);
        var properties = project.Properties;

        var items = new List<ITaskItem>();
        foreach (var property in properties)
        {
            var item = new TaskItem(property.Name);
            item.SetMetadata("Value", property.Value);
            items.Add(item);
        }

        Properties = items.ToArray();

        return true;
    }
}
