using System.Runtime.CompilerServices;

using global::System;

using static System.IO.Path;

internal static class ProjectSourcePath
{
    private const string myRelativePath = nameof(ProjectSourcePath) + ".cs";
    private static string? lazyValue;
    public static string Value => lazyValue ??= calculatePath();

    private static string calculatePath()
    {
        var pathName = GetSourceFilePathName();
        // Assert(pathName.EndsWith(myRelativePath, StringComparison.Ordinal));
        return pathName.Substring(0, pathName.Length - myRelativePath.Length);
    }

    public static string GetSourceFilePathName(
        [CallerFilePath] string? callerFilePath = null
    ) //
        => callerFilePath ?? "";

    public static readonly string ProjectDir = Path.GetFullPath(
        Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..")
    );
}
