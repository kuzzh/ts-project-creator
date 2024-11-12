[中文](README.zh-CN.md) | English

# TS Project Creator 🚀

## Project Overview 🌟

**TS Project Creator** is a .NET 8 application designed to streamline the process of creating TypeScript projects. This tool automates the setup of a new TypeScript project by generating a directory structure, unzipping a template file, and updating project files with the specified project name. The project is built with simplicity and efficiency in mind, making it an ideal choice for developers looking to quickly bootstrap their TypeScript projects.

## Features 🛠️

- **Automated Project Setup**: Quickly create a new TypeScript project with a predefined directory structure.
- **Template Unzipping**: Extracts a template file (in `.zip` format) into the project directory.
- **Dynamic File Updates**: Automatically updates key project files (e.g., `index.ts`, `index.html`, `package.json`) with the specified project name.
- **User-Friendly Interface**: Guides the user through the project creation process with clear prompts and feedback.
- **Error Handling**: Robust error handling ensures that any issues during the project creation process are logged and reported.

## How to Use 📘

### Prerequisites

- .NET 8 SDK installed on your machine.
- Visual Studio 2022 or any compatible IDE.

### Steps to Create a New Project

1. **Clone the Repository**:
   ```bash
   git clone https://github.com/kuzzh/ts-project-creator.git
   cd ts-project-creator/src
   ```

2. **Build the Project**:
   ```bash
   dotnet build
   ```

3. **Run the Application**:
   ```bash
   dotnet run
   ```

4. **Follow the Prompts**:
   - Enter the desired project name when prompted.
   - Specify the directory where you want to create the project.
   - Confirm if the directory already exists and you want to override it.

5. **Project Creation**:
   - The application will create the project directory, unzip the template file, and update the necessary files with the project name.
   - Once completed, the project path will be displayed.

### Example Usage

```bash
Please enter the project name: MyAwesomeProject
Please enter the project generation directory [C:\Users\YourName\MyAwesomeProject]:
The project generation directory already exists. Continuing will clear this directory. Are you sure you want to continue? [y/N] y
Project creation completed. Project path: C:\Users\YourName\MyAwesomeProject
```

## Project Structure 📁

- **`ts-project-creator.csproj`**: The project file that defines the build settings and dependencies.
- **`Program.cs`**: The main entry point of the application, containing the logic for project creation.
- **`Resources.resx`**: Contains the template file (in `.zip` format) that is used to create the project structure.
- **`Resources.Designer.cs`**: Auto-generated file that provides strongly-typed access to the resources defined in `Resources.resx`.
- **`ts-project-creator.sln`**: The Visual Studio solution file that groups the project.

## Customization 🎨

- **Template File**: You can customize the template file (`template.zip`) to include any additional files or configurations you need for your TypeScript projects.
- **File Updates**: Modify the `UpdateProjectFiles` method in `Program.cs` to include or exclude specific files that need to be updated with the project name.

## Contributing 🤝

Contributions are welcome! Feel free to open issues or submit pull requests to help improve this project.

## License 📄

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for more details.

---

Happy coding! 🎉