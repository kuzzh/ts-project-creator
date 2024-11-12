中文 | [English](README.md)

# TS项目创建器 🚀

## 项目概述 🌟

**TS项目创建器** 是一个基于.NET 8的应用程序，旨在简化创建TypeScript项目的过程。该工具通过生成目录结构、解压缩模板文件并使用指定的项目名称更新项目文件，自动完成新TypeScript项目的设置。该项目以简单和高效为目标，是开发人员快速启动TypeScript项目的理想选择。

## 项目特点 🛠️

- **自动化项目设置**：快速创建具有预定义目录结构的新TypeScript项目。
- **模板解压缩**：将模板文件（以`.zip`格式）解压缩到项目目录中。
- **动态文件更新**：自动使用指定的项目名称更新关键项目文件（例如，`index.ts`、`index.html`、`package.json`）。
- **用户友好的界面**：通过清晰的提示和反馈引导用户完成项目创建过程。
- **错误处理**：强大的错误处理确保在项目创建过程中出现的任何问题都会被记录和报告。

## 使用方法 📘

### 前提条件

- 在您的机器上安装.NET 8 SDK。
- 安装Visual Studio 2022或任何兼容的IDE。

### 创建新项目的步骤

1. **克隆仓库**：
   ```bash
   git clone https://github.com/kuzzh/ts-project-creator.git
   cd ts-project-creator/src
   ```

2. **构建项目**：
   ```bash
   dotnet build
   ```

3. **运行应用程序**：
   ```bash
   dotnet run
   ```

4. **按照提示操作**：
   - 当提示时输入所需的项目名称。
   - 指定您希望创建项目的目录。
   - 如果目录已存在并希望覆盖它，请确认。

5. **项目创建**：
   - 应用程序将创建项目目录，解压缩模板文件，并使用项目名称更新必要的文件。
   - 完成后，将显示项目路径。

### 示例用法

```bash
请输入项目名称: MyAwesomeProject
请输入项目生成目录 [C:\Users\YourName\MyAwesomeProject]:
项目生成目录已存在。继续将清除该目录。您确定要继续吗？[y/N] y
项目创建完成。项目路径: C:\Users\YourName\MyAwesomeProject
```

## 项目结构 📁

- **`ts-project-creator.csproj`**：定义构建设置和依赖项的项目文件。
- **`Program.cs`**：应用程序的主入口点，包含项目创建的逻辑。
- **`Resources.resx`**：包含用于创建项目结构的模板文件（以`.zip`格式）。
- **`Resources.Designer.cs`**：自动生成的文件，提供对`Resources.resx`中定义的资源的强类型访问。
- **`ts-project-creator.sln`**：将项目分组的Visual Studio解决方案文件。

## 自定义 🎨

- **模板文件**：您可以自定义模板文件（`template.zip`）以包含您需要的任何额外文件或配置。
- **文件更新**：修改`Program.cs`中的`UpdateProjectFiles`方法，以包含或排除需要使用项目名称更新的特定文件。

## 贡献 🤝

欢迎贡献！请随时打开问题或提交拉取请求以帮助改进此项目。

## 许可证 📄

该项目在MIT许可证下发布。有关更多详细信息，请参阅 [LICENSE](LICENSE)文件。

---

祝您编码愉快！ 🎉