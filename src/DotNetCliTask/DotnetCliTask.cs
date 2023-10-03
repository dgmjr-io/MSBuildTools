using System.Linq;
using System.Xml.Linq;

namespace Dgmjr.MSBuild.Tasks;

using Microsoft.Build.Framework;
using Microsoft.Build.Tasks;
using Microsoft.Build.Utilities;

public class Dotnet : MSBTask
{
    public string Command { get; set; } = "build";

    [Required]
    public ITaskItem[] Projects { get; set; } = Array.Empty<ITaskItem>();

    [Output]
    public ITaskItem[] ExitCodes =>
        _exitCodes
            .Select(
                kvp =>
                    new TaskItem(
                        kvp.Key,
                        new Dictionary<string, string> { ["ExitCode"] = kvp.Value.ToString(), }
                    )
            )
            .ToArray();

    private IDictionary<string, int> _exitCodes;

    public string Configuration { get; set; } = "Release";

    public string? Framework { get; set; }

    public string? OutputDirectory { get; set; }

    public string? OutputName { get; set; }

    public string OutputType { get; set; } = "Library";

    public string? Version { get; set; }

    public string? AssemblyName { get; set; }

    public bool IgnoreExitCodes { get; set; }

    public ITaskItem[] Properties { get; set; } = Array.Empty<ITaskItem>();
    public ITaskItem[] Targets { get; set; } = Array.Empty<ITaskItem>();
    public ITaskItem[] RemoveProperties { get; set; } = Array.Empty<TaskItem>();

    public override bool Execute()
    {
        Log.LogMessage("Starting dotnet command");

        var args = new List<string>();

        if (Command != null)
        {
            args.Add(Command);
        }

        if (Projects != null)
        {
            args.AddRange(Projects.Select(p => p.ItemSpec));
        }

        if (Configuration != null)
        {
            args.Add($"/p:Configuration={Configuration}");
        }

        if (Framework != null)
        {
            args.Add($"/p:Framework={Framework}");
        }

        if (OutputDirectory != null)
        {
            args.Add($"/p:OutputDirectory={OutputDirectory}");
        }

        if (OutputName != null)
        {
            args.Add($"/p:OutputName={OutputName}");
        }

        if (OutputType != null)
        {
            args.Add($"/p:OutputType={OutputType}");
        }

        if (Version != null)
        {
            args.Add($"/p:Version={Version}");
        }

        if (AssemblyName != null)
        {
            args.Add($"/p:AssemblyName={AssemblyName}");
        }

        if (Properties != null)
        {
            args.AddRange(Properties.Select(p => $"/p:{p.ItemSpec}={p.GetMetadata("Value")}"));
        }

        if (Targets != null)
        {
            args.AddRange(Targets.Select(t => $"/t:{t.ItemSpec}"));
        }

        if (RemoveProperties != null)
        {
            args.AddRange(RemoveProperties.Select(p => $"/p:{p.ItemSpec}"));
        }

        _exitCodes = Projects.ToDictionary(p => p.ItemSpec, p => -1);

        foreach (var project in Projects)
        {
            Log.LogExternalProjectStarted(
                $"Started {Command} of project {project.ItemSpec}...",
                Command,
                project.ItemSpec,
                Targets.Join(";")
            );
            var psi = new ProcessStartInfo("dotnet", args.Join(" "))
            {
                WorkingDirectory = project.GetMetadata("RootDir"),
                // RedirectStandardOutput = true,
                // RedirectStandardError = true,
                UseShellExecute = true,
                CreateNoWindow = true
            };
            try
            {
                using var p = Process.Start(psi);
                // p.OutputDataReceived += (sender, e) => Log.LogMessage(e.Data ?? "Unknown Message");
                // p.ErrorDataReceived += (sender, e) => Log.LogError(e.Data ?? "Unknown Error");
                // p.BeginOutputReadLine();
                // p.BeginErrorReadLine();
                p.WaitForExit();
                // Log.LogMessage(p.StandardOutput.ReadToEnd());
                // var error = p.StandardError.ReadToEnd();
                // if (!string.IsNullOrWhiteSpace(error))
                // {
                //     Log.LogError(error);
                // }
                Log.LogExternalProjectFinished(
                    $"Finished {Command} of project {project.ItemSpec}...",
                    Command,
                    project.ItemSpec,
                    p.ExitCode == 0
                );
                if (p.ExitCode != 0 && !IgnoreExitCodes)
                {
                    Log.LogError($"dotnet {Command} failed with exit code {p.ExitCode}.");
                    return false;
                }
                else
                {
                    Log.LogMessage($"dotnet {Command} succeeded with exit code {p.ExitCode}.");
                }
            }
            catch (Exception ex)
            {
                Log.LogErrorFromException(ex);
                return false;
            }
        }

        return true;
    }
}
