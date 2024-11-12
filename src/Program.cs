using System.IO.Compression;
using ts_project_creator.Properties;

try
{
    Console.Title = "TS Project Creator";

    var projectName = GetValidProjectName();
    var projectDir = GetProjectDirectory(projectName);

    if (Directory.Exists(projectDir))
    {
        if (!ConfirmDirectoryOverride())
            return;
        DeleteDirectory(projectDir);
    }

    CreateDirectory(projectDir);
    UnzipTemplateFile(projectDir);
    UpdateProjectFiles(projectDir, projectName);

    WriteLineLog($"Project creation completed. Project path: {projectDir}", ConsoleColor.Green);
}
catch (Exception ex)
{
    WriteLog(ex.ToString(), ConsoleColor.Red);
}

string GetValidProjectName()
{
    string? projectName;
    do
    {
        WriteLog("Please enter the project name: ");
        projectName = Console.ReadLine();
        if (string.IsNullOrEmpty(projectName))
            WriteLineLog("Please enter a valid project name!");
    } while (string.IsNullOrEmpty(projectName));
    return projectName;
}

string GetProjectDirectory(string projectName)
{
    var projectDir = Path.GetFullPath(projectName);
    WriteLog($"Please enter the project generation directory [{projectDir}]: ");
    var projectDirInput = Console.ReadLine();
    return string.IsNullOrEmpty(projectDirInput) ? projectDir : Path.Combine(projectDirInput, projectName);
}

bool ConfirmDirectoryOverride()
{
    WriteLog($"The project generation directory already exists. Continuing will clear this directory. Are you sure you want to continue? [y/N] ");
    var overrideInput = Console.ReadLine();
    return overrideInput != null && overrideInput.Equals("y", StringComparison.InvariantCultureIgnoreCase);
}

void DeleteDirectory(string projectDir)
{
    WriteLineLog($"Deleting directory: {projectDir}");
    Directory.Delete(projectDir, true);
}

void CreateDirectory(string projectDir)
{
    WriteLineLog($"Creating directory: {projectDir}");
    Directory.CreateDirectory(projectDir);
}

void UnzipTemplateFile(string extractPath)
{
    WriteLineLog("Starting to unzip template file...");
    var zipFileBytes = Resources.template;
    using (var zipFileStream = new MemoryStream(zipFileBytes))
    {
        ZipFile.ExtractToDirectory(zipFileStream, extractPath);
    }
    WriteLineLog("Template file successfully unzipped to: " + extractPath, ConsoleColor.Green);
}

void UpdateProjectFiles(string projectDir, string projectName)
{
    WriteLineLog("Creating project...");
    UpdateFileContent($"{projectDir}/src/index.ts", projectName);
    UpdateFileContent($"{projectDir}/public/index.html", projectName);
    UpdateFileContent($"{projectDir}/package.json", projectName);
}

void UpdateFileContent(string filePath, string projectName)
{
    if (File.Exists(filePath))
    {
        var fileText = File.ReadAllText(filePath);
        fileText = fileText.Replace("{ProjectName}", projectName);
        File.WriteAllText(filePath, fileText);
    }
}

void WriteLog(string msg, ConsoleColor? color = null)
{
    msg = $"[{DateTime.Now:HH:mm:ss fff}]{msg}";
    var oldColor = Console.ForegroundColor;
    if (color != null)
    {
        Console.ForegroundColor = color.Value;
    }
    Console.Write(msg);
    Console.ForegroundColor = oldColor;
}

void WriteLineLog(string msg, ConsoleColor? color = null)
{
    WriteLog(msg, color);
    Console.WriteLine();
}
