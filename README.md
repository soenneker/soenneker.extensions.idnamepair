[![](https://img.shields.io/nuget/v/soenneker.extensions.idnamepair.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.extensions.idnamepair/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.extensions.idnamepair/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.extensions.idnamepair/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.extensions.idnamepair.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.extensions.idnamepair/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.extensions.idnamepair/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.extensions.idnamepair/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Extensions.IdNamePair
An empty extension namespace reserved for `IdNamePair`-specific APIs.

## Installation

```bash
dotnet add package Soenneker.Extensions.IdNamePair
```

## API surface

This package contains the empty static type `IdNamePairExtension`. It does not define extension methods or reference the `IdNamePair` DTO package, so installing it adds no runtime behavior.

For operations on collections of `IdNamePair` values—including ID lookup, ID projection, and deduplicated adds—use [`Soenneker.Extensions.List.IdNamePair`](https://www.nuget.org/packages/Soenneker.Extensions.List.IdNamePair/) instead.
