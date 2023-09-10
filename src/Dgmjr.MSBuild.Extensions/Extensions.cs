namespace Dgmjr.MSBuild.Extensions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Generic;
using System.IO;
using System.Xml;

using Microsoft.Build.Evaluation;
using Microsoft.Build.Execution;
using Microsoft.Build.Framework;

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

        using XmlReader projectFileReader = XmlReader.Create(projectFile);
        return (project ??= projectCollection.LoadProject(projectFileReader)) != null;
    }

    public static ICollection<ProjectItem> GetAllEvaluatedItems(this ITask task)
    {
        var projectXml = File.ReadAllText(task.BuildEngine.ProjectFileOfTaskNode);
        using (var xmlReader = XmlReader.Create(new StringReader(projectXml)))
        {
            var project = new Project(xmlReader);
            return project.AllEvaluatedItems;
        }
    }

    public static IDictionary<string, string> GetAllEvaluatedProperties(this ITask task)
    {
        var projectXml = File.ReadAllText(task.BuildEngine.ProjectFileOfTaskNode);
        using (var xmlReader = XmlReader.Create(new StringReader(projectXml)))
        {
            var project = new Project(xmlReader);
            return new ProjectPropertiesDictionary(project);
        }
    }

    private class ProjectPropertiesDictionary : CaseInsensitiveStringKeyDictionary
    {
        private readonly ProjectPropertiesDictionary _dictionary = new(StringComparer.OrdinalIgnoreCase);

        public ProjectPropertiesDictionary(Project project)
        {
            foreach (var property in project.AllEvaluatedProperties)
            {
                var propertyName = property.Name;
                var propertyValue = property.EvaluatedValue;

                this[propertyName] = propertyValue;
            }
        }

        // public virtual string this[string key]
        // {
        //     get => _dictionary.TryGetValue(key, out var value) ? value : string.Empty;
        //     set => _dictionary[key] = value;
        // }

        // public ICollection<string> Keys => _dictionary.Keys;

        // public ICollection<string> Values => _dictionary.Values;

        // public int Count => _dictionary.Count();

        // public bool IsReadOnly => _dictionary.IsReadOnly;

        // public void Add(string key, string value) => _dictionary.Add(key, value);
        // public void Add(KeyValuePair<string, string> item) => _dictionary.Add(item);
        // public void Clear() => _dictionary.Clear();
        // public bool Contains(KeyValuePair<string, string> item) => _dictionary.Contains(item);
        // public bool ContainsKey(string key) => _dictionary.ContainsKey(key);
        // public void CopyTo(KeyValuePair<string, string>[] array, int arrayIndex) => _dictionary.CopyTo(array, arrayIndex);
        // public IEnumerator<KeyValuePair<string, string>> GetEnumerator() => _dictionary.GetEnumerator();
        // public bool Remove(string key) => _dictionary.Remove(key);
        // public bool Remove(KeyValuePair<string, string> item) => _dictionary.Remove(item);
        // public bool TryGetValue(string key, out string value) => _dictionary.TryGetValue(key, out value);
        // IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)_dictionary).GetEnumerator();
    }
}
