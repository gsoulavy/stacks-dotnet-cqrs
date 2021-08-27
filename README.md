stacks-dotnet-cqrs

### Templates

All templates from this repository come as part of the [Amido.Stacks.CQRS.Templates](https://www.nuget.org/packages/Amido.Stacks.CQRS.Templates/) NuGet package. The list of templates inside the package are as follows:

- `stacks-app-web-api-cqrs`. The full CQRS template including everything + build infrastructure.
- `stacks-add-web-api-cqrs`. A special template that can add `CQRS` functionality and projects to your existing Web API solution

### Template usage

#### Template installation

To install the templates on your own machine you'll need to download the [Amido.Stacks.CQRS.Templates](https://www.nuget.org/packages/Amido.Stacks.CQRS.Templates/) NuGet package.

Then you can install it locally via the command line (command is given with an example version)

```shell
dotnet new --install Amido.Stacks.CQRS.Templates::0.0.85
```

The output will list all installed templates. In that list you'll see the two installed Amido Stacks templates listed above.

```shell
Template Name                                         Short Name                       Language    Tags
----------------------------------------------------  -------------------------------  ----------  ------------------------------------------
Console Application                                   console                          [C#],F#,VB  Common/Console
Class library                                         classlib                         [C#],F#,VB  Common/Library
WPF Application                                       wpf                              [C#]        Common/WPF
WPF Class library                                     wpflib                           [C#]        Common/WPF
WPF Custom Control Library                            wpfcustomcontrollib              [C#]        Common/WPF
WPF User Control Library                              wpfusercontrollib                [C#]        Common/WPF
Windows Forms (WinForms) Application                  winforms                         [C#]        Common/WinForms
Windows Forms (WinForms) Class library                winformslib                      [C#]        Common/WinForms
Worker Service                                        worker                           [C#],F#     Common/Worker/Web
Amido Stacks Web Api CQRS - Add to existing solution  stacks-add-web-api-cqrs          [C#]        Stacks/WebAPI/CQRS/api
Amido Stacks Web Api CQRS - Full solution             stacks-app-web-api-cqrs          [C#]        Stacks/WebAPI/CQRS/api
MSTest Test Project                                   mstest                           [C#],F#,VB  Test/MSTest
NUnit 3 Test Project                                  nunit                            [C#],F#,VB  Test/NUnit
NUnit 3 Test Item                                     nunit-test                       [C#],F#,VB  Test/NUnit
xUnit Test Project                                    xunit                            [C#],F#,VB  Test/xUnit
Razor Component                                       razorcomponent                   [C#]        Web/ASP.NET
Razor Page                                            page                             [C#]        Web/ASP.NET
MVC ViewImports                                       viewimports                      [C#]        Web/ASP.NET
MVC ViewStart                                         viewstart                        [C#]        Web/ASP.NET
Blazor Server App                                     blazorserver                     [C#]        Web/Blazor
Blazor WebAssembly App                                blazorwasm                       [C#]        Web/Blazor/WebAssembly
ASP.NET Core Empty                                    web                              [C#],F#     Web/Empty
ASP.NET Core Web App (Model-View-Controller)          mvc                              [C#],F#     Web/MVC
ASP.NET Core Web App                                  webapp                           [C#]        Web/MVC/Razor Pages
ASP.NET Core with Angular                             angular                          [C#]        Web/MVC/SPA
ASP.NET Core with React.js                            react                            [C#]        Web/MVC/SPA
ASP.NET Core with React.js and Redux                  reactredux                       [C#]        Web/MVC/SPA
Razor Class Library                                   razorclasslib                    [C#]        Web/Razor/Library
ASP.NET Core Web API                                  webapi                           [C#],F#     Web/WebAPI
ASP.NET Core gRPC Service                             grpc                             [C#]        Web/gRPC
dotnet gitignore file                                 gitignore                                    Config
global.json file                                      globaljson                                   Config
NuGet Config                                          nugetconfig                                  Config
Dotnet local tool manifest file                       tool-manifest                                Config
Web Config                                            webconfig                                    Config
Solution File                                         sln                                          Solution
Protocol Buffer File                                  proto                                        Web/gRPC

Examples:
    dotnet new mvc --auth Individual
    dotnet new react --auth Individual
    dotnet new --help
```

#### Uninstalling a template

To uninstall the template pack you have to execute the following command

```shell
dotnet new -u Amido.Stacks.CQRS.Templates
```

#### Adding a CQRS template to your existing solution

Let's say you have a WebAPI solution and you want to add CQRS functionality to it.

In order for the template to generate correctly you'll need to execute it in the folder where your `.sln` file is located. Also for the purposes of this example we're assuming that in your solution the projects and namespaces have `Foo.Bar` as a prefix.

```shell
% cd src

% dotnet new stacks-add-web-api-cqrs -n Foo.Bar -d Menu
The template "Amido Stacks Web Api CQRS - Add to existing solution" was created successfully.
```

If all is well, in the output you'll see that projects are being added as references to your `.sln` file. The list of projects that you'll get by installing this template are as follows (please note the prefix provided with the `-n` flag from above):

- Foo.Bar.Infrastructure
- Foo.Bar.API
- Foo.Bar.API.Models
- Foo.Bar.Application.CommandHandlers
- Foo.Bar.Application.Integration
- Foo.Bar.Application.QueryHandlers
- Foo.Bar.Domain
- Foo.Bar.Common
- Foo.Bar.CQRS
- Foo.Bar.Common.UnitTests
- Foo.Bar.CQRS.UnitTests
- Foo.Bar.Domain.UnitTests
- Foo.Bar.Infrastructure.IntegrationTests
