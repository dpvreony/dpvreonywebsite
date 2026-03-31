# dpvreony website

Public website for DPVreony, built with ASP.NET Core and AspNetStatic for static site generation.

## Table of contents
- [About](#about)
- [Build & test](#build--test)
- [Repository layout](#repository-layout)
- [Credits](#credits)
- [Contributing](#contributing)
- [License](#license)

## About

This repository contains the source code for the DPVreony public website. It is built as an ASP.NET Core Razor Pages application that uses [AspNetStatic](https://github.com/ZarehD/AspNetStatic) to generate a static site at build/publish time. Diagrams are rendered server-side using [Mermaid](https://github.com/mermaid-js/mermaid) via [Whipstaff.Mermaid](https://github.com/dpvreony/whipstaff) and Playwright. [.NET Aspire](https://learn.microsoft.com/en-us/dotnet/aspire/get-started/aspire-overview) is used for local orchestration.

## Build & test

You need:

* [.NET 10 SDK](https://dotnet.microsoft.com/download) or later
* [Visual Studio 2026 (18.0.0)](https://visualstudio.microsoft.com/) or later (or the `dotnet` CLI)
* [Node.js](https://nodejs.org/) (used automatically by MSBuild to restore npm packages; no manual `npm install` required)

To build from the solution root:
```bash
dotnet build src/DPVreony.Website.sln
```

To run the website locally using .NET Aspire:
```bash
dotnet run --project src/DPVreony.Website.AspireAppHost
```

To run without static site generation (useful for hot-reload during development):
```bash
dotnet run --project src/DPVreony.Website -- --no-ssg
```

## Repository layout

- `src/DPVreony.Website.sln` — main solution file
- `src/DPVreony.Website/` — ASP.NET Core Razor Pages website project with AspNetStatic static site generation
- `src/DPVreony.Website.AspireAppHost/` — .NET Aspire host project for local orchestration
- `src/DPVreony.Website/package.json` — npm dependencies (Bootstrap, Font Awesome, jQuery, Highlight.js, CookieConsent); restored automatically by MSBuild before build

## Credits

* [AspNetStatic](https://github.com/ZarehD/AspNetStatic) — static site generation for ASP.NET Core
* [.NET Aspire](https://learn.microsoft.com/en-us/dotnet/aspire/get-started/aspire-overview) — local orchestration
* [Mermaid](https://github.com/mermaid-js/mermaid) — diagram rendering
* [Whipstaff](https://github.com/dpvreony/whipstaff) — Mermaid and other .NET helpers
* [Bootstrap](https://github.com/twbs/bootstrap) — CSS framework
* [Font Awesome](https://github.com/FortAwesome/Font-Awesome) — icons
* [jQuery](https://github.com/jquery/jquery) — JavaScript utilities
* [Highlight.js](https://github.com/highlightjs/highlight.js) — syntax highlighting

## Contributing

See the [contribution guidelines](CONTRIBUTING.md) and the [Code of Conduct](CODE_OF_CONDUCT.md).

- Open an issue to propose major changes.
- Fork the repo and create a topic branch for your changes.

## License

This project is licensed under the MIT License — see the [LICENSE](LICENSE) file for details.
