# omnisharp-scaffolding

> A community project to provide a full-featured scaffolding experience for cross-platform .NET development via a command-line interface (CLI).

## Vitals

Info          | Badges
--------------|--------------
Version       | [![NuGet Version][nuget-v-image]][nuget-url] [![MyGet Version][myget-v-image]][myget-url]
License       | [![License][license-image]][license]
Downloads     | [![NuGet Downloads][nuget-d-image]][nuget-url] [![MyGet Downloads][myget-d-image]][myget-url]
Build Status  | [![Travis Build Status][travis-image]][travis-url] [![AppVeyor Build Status][appveyor-image]][appveyor-url]
Chat          | [![Join Chat][gitter-image]][gitter-url]

## What is OmniSharp Scaffolding

OmniSharp Scaffolding is a CLI that is capable of enabling dynamic asset scaffolding for cross-platform development. Some examples include:

* Generating an Entity Framework DbContext
* Generating MVC and API controllers for CRUD operations based on an existing Entity Framework DbContext.
* Generate MVC views for CRUD operations based on an existing Entity Framework context

## Why not Yeoman?

Yeoman is an excellent tool for generating static assets such as boilerplate and starter code, but it lacks the ability to reflect the type 
system of a .NET project. While we love and use Yeoman nearly every day, it just isn't the right tool for generating assets dynamically through 
reasoning about a code base and understanding its object hierarchy.

These scaffolding tools are meant to suplement Yeoman generators, not replace them.

## Goals and Objectives

Our long term goals and objectives include the following:

* Maintain feature parity with the scaffolding capabilities included in Visual Studio (full version).
* Provide an extensibility story that is easy to use, similiar to the customization afforded .NET projects in the past through T4 templating.
* Provide extensions for popular editors, such as Visual Studio Code, Atom, and Sublime Text

## Contributing

We welcome any and all contributors that would like to help. Please refer to the [CONTRIBUTING][] document for more information.

## Building OmniSharp Scaffolding

This project is currently using [condo][condo-url]: a cross-platform build, test, and packaging system for DNX-based projects. Once you have 
cloned the repository, you can build the project using the commands below:

### Windows
``` cmd
# with code coverage results
condo --coverage default

# without code coverage results
condo
```

*Note: code coverage results are only available on Windows. We are not currently aware of any cross-platform code coverage tools for dnx-based
projects.*

### OS X and Linux
``` bash
./condo.sh
```

## Copyright and License

&copy; OmniSharp Team and contributors. Distributed under the MIT license. See [LICENSE][] for details.

[license-image]: https://img.shields.io/badge/license-MIT-blue.svg
[license]: LICENSE.md
[contributing]: CONTRIBUTING.md

[travis-url]: https://travis-ci.org/OmniSharp/omnisharp-scaffolding
[travis-image]: https://img.shields.io/travis/OmniSharp/omnisharp-scaffolding.svg?label=travis

[appveyor-url]: https://ci.appveyor.com/project/pulsebridge/omnisharp-scaffolding
[appveyor-image]: https://img.shields.io/appveyor/ci/pulsebridge/omnisharp-scaffolding.svg?label=appveyor

[nuget-url]: https://www.nuget.org/packages/omnisharp.scaffolding
[nuget-v-image]: https://img.shields.io/nuget/v/omnisharp.scaffolding.svg?label=nuget
[nuget-d-image]: https://img.shields.io/nuget/dt/omnisharp.scaffolding.svg?label=nuget

[myget-url]: https://www.myget.org/feed/omnisharp/package/nuget/OmniSharp.Scaffolding
[myget-v-image]: https://img.shields.io/myget/omnisharp/vpre/OmniSharp.Scaffolding.svg?label=myget
[myget-d-image]: https://img.shields.io/myget/omnisharp/dt/OmniSharp.Scaffolding.svg?label=myget

[gitter-url]: https://gitter.im/omnisharp
[gitter-image]: https://img.shields.io/badge/⊪%20gitter-join%20chat%20→-1dce73.svg

[condo-url]: https://github.com/pulsebridge/condo