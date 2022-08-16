# Simple Starter Template

This is a template for boostrapping a simple solution for doing quick verifications in C#. It creates a solution that includes a class library project, a xUnit project and a console app project. Project references have already been added.

This template is a [custom template for dotnet new](https://docs.microsoft.com/en-us/dotnet/core/tools/custom-templates).

## Usage

1. Download the code.
```sh
$ git clone https://github.com/CoderYihaoWang/SimpleStarter.git
```

2. Install the template
```sh
$ dotnet new --install ./SimpleStarter
```

3. Create new project from the template
```sh
$ dotnet new simple -o MyProject # Change this to your project name 
```
You will see that a solution folder was created as `MyProject` that contains the project. The project names, references and namespaces should have been automatically changed correspondingly.

> **NOTE** The project name should be a valid identifier for a class name, and should not contain dots, otherwise the generated projects may contain incorrectly formatted references.