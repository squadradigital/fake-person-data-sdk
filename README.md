# fake-person-data-sdk
[![CI](https://github.com/squadradigital/fake-person-data-sdk/workflows/CI/badge.svg)](https://github.com/squadradigital/fake-person-data-sdk/workflows/CI)
[![NuGet](http://img.shields.io/nuget/v/Squadra.Person.Data.Sdk.svg)](https://www.nuget.org/packages/Squadra.Person.Data.Sdk/)

### What is fake-person-data-sdk?
this is a fake person data SDK, that can be used for resolving  selection tests.

### Where can I get it?

First, [install NuGet](http://docs.nuget.org/docs/start-here/installing-nuget). Then, install [Squadra.Person.Data.Sdk](https://www.nuget.org/packages/Squadra.Person.Data.Sdk/) from the package manager console:

```
PM> Install-Package Squadra.Person.Data.Sdk
```

### How do I get started?

First configure fake-person-data-sdk in the startup of your application:

```csharp
services.AddFakePersonDataSdk();
```

so in your application code, you can inject the `IPersonReadRepository`

### License, etc.

This project has adopted the code of conduct defined by the Contributor Covenant to clarify expected behavior in our community.
For more information see the [.NET Foundation Code of Conduct](https://dotnetfoundation.org/code-of-conduct).

AutoMapper is Copyright &copy; 2020 [Squadra Digital](https://www.squadra.com.br) and other contributors under the [MIT license](LICENSE.md).
