namespace Dgmjr.MSBuild.Extensions;

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml;

using Microsoft.Build.Evaluation;
using Microsoft.Build.Execution;
using Microsoft.Build.Framework;
using Microsoft.Build.Definition;

public static class TaskExtensions
{
    /// <summary>
    /// Attempts to get the current <see cref="ProjectInstance"/> of the executing task via reflection.
    /// </summary>
    /// <returns>A <see cref="ProjectInstance"/> object if one could be determined, otherwise null..</returns>
    public static bool TryGetProjectInstance(this ITask task, out ProjectInstance projectInstance)
    {
        task.TryGetProject(out var project);
        return (projectInstance = project?.CreateProjectInstance()) != null;
    }

    public static bool TryGetProject(this ITask task, out Project project)
    {
        var projectFile = task.BuildEngine.ProjectFileOfTaskNode;

        var projectCollection = new ProjectCollection();
        project = projectCollection.LoadProject(projectFile);

        using var projectFileReader = XmlReader.Create(projectFile);
        return (project ??= projectCollection.LoadProject(projectFileReader)) != null;
    }

    public static ICollection<ProjectItem> GetAllEvaluatedItems(this ITask task)
    {
        var projectCollection = new ProjectCollection();
        var project = projectCollection.LoadProject(task.BuildEngine.ProjectFileOfTaskNode);

        var projectXml = File.ReadAllText(task.BuildEngine.ProjectFileOfTaskNode);
        using var xmlReader = XmlReader.Create(new StringReader(projectXml));
        project ??= Project.FromXmlReader(
            xmlReader,
            new ProjectOptions { ProjectCollection = projectCollection }
        );
        return project.AllEvaluatedItems;
    }

    public static IStringDictionary GetAllEvaluatedProperties(this ITask task)
    {
        var projectCollection = new ProjectCollection();
        var project = projectCollection.LoadProject(task.BuildEngine.ProjectFileOfTaskNode);

        var projectXml = File.ReadAllText(task.BuildEngine.ProjectFileOfTaskNode);
        using var xmlReader = XmlReader.Create(new StringReader(projectXml));
        project ??= Project.FromXmlReader(
            xmlReader,
            new ProjectOptions { ProjectCollection = projectCollection }
        );
        return new ProjectPropertiesDictionary(project);
    }

    private sealed class ProjectPropertiesDictionary : StringDictionary
    {
        public ProjectPropertiesDictionary(Project project)
            : base(StringComparer.OrdinalIgnoreCase)
        {
            foreach (var property in project.AllEvaluatedProperties)
            {
                this[property.Name] = property.EvaluatedValue;
            }
        }
    }
}
