# ComputerCodeBlue.AWS.Lambda

ComputerCodeBlue.AWS.Lambda is a set of classes to integrate Lambda functions with infrastructure running on EC2 instances, such as MySql databases.

Contents
========

 * [Why?](#why)
 * [Installation](#installation)
 * [Usage](#usage)

## Why?

While creating a Lambda function to handle a generic contact form from a website, I discovered there was a lot of boilerplate code that would be shared between many Lambda functions using databases I had running on an EC2 instance. Best practices for handling the connection information for the database were to store the information using AWS Secrets Manager. All functions can start from a base abstract class. As other projects use more resources, like AWS S3, I could add additional generic functionality here.

## Installation

#### Method 1: [`dotnet add package`](https://nuget.org)

```cmd
dotnet add package ComputerCodeBlue.AWS.Lambda
```

#### Method 2: [`Install-Package`](https://nuget.org)

```powershell
Install-Package ComputerCodeBlue.AWS.Lambda
```

#### Method 3: Install from Source

```cmd
git clone https://github.com/computercodeblue/AWS.git
cd AWS
cd ComputerCodeBlue.AWS.Lambda
dotnet build
```

End if your .csproj file to include the following:

```XML
<ItemGroup>
  <Reference Include="MyAssembly">
    <HintPath>Path\To\AWS\ComputerCodeBlue.AWS.Lambda\bin\Release\net6.0\ComputerCodeBlue.AWS.Lambda.dll</HintPath>
  </Reference>
</ItemGroup>
```

## Usage

The library contains two abstract classes to inherit your function from: EventFunction and RequestResponseFunction, which both inherit from a generic Function class. Both classes contain methods that are similar to a standard .NET Application Host such as Configure, ConfigureLogging, and ConfigureServices. The function does its work using a HandleAsync method. With a Function.cs serving as a replacement for the Program.cs file, you can write code that is very similar to any other .NET application, only with much narrower scope, as an AWS Lambda would represent a single endpoint in an AWS application gateway.

The following is an example of a project structure:

```
.
├── Function.cs
├── Data
│   └── DatabaseCredentials.cs
├── Services
│   ├── SomeService.cs
│   └── ISomeService.cs
└── Models
    ├── SomeClass.cs
    └── SomeOtherClass.cs
```

