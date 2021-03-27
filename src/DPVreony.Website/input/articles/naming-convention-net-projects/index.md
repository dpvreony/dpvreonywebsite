# Devising a naming convention for .NET projects

| | |
| - | - |
| Article Status | Draft |
| Article Version | 0.2 |
| First Written | 2021-03-06 |
| Last Revision | 2021-03-26 |
| License | MIT |

When structuring repositories it helps to document your naming convention for projects. It helps establish a pattern and practice for the team, ensuring consistency and reducing mental burden on working across codebases. As you add new components you may extend the naming convention or adjust it, but you can add to your CI process checks for projects that don't fit the naming convention.

<div class="alert alert-warning">
Be careful about having a naming convention that solely uses a technology and\or brand name. Some toolsets can use internal concepts that misbehave. One such example is Xamarin Forms when using the namespace "Android" as demonstrated by [James Montemagno's December 2020 blog post](https://montemagno.com/dont-put-android-in-your-namespace-in-xamarin-apps/).
</div>

<div class="alert alert-info">
This is not meant to be definitive, it's an example pattern. You may be using a tech stack that has different concepts ranging from COM+ libraries, device drivers to plug in's for web browsers or applications.
</div>


| Project Name Suffix | Description |
| - | - |
| ?.Client | Strongly Typed Client Logic. i.e. Http clients
| ?.DotNetTool | Dot Net Core Command Line Tool
| ?.Server | Shared Server Logic
| ?.Shared | Shared Client \ Server Logic
| ?.WebSocketApp | Web Socket Application (If using one and splitting from WebApp \ WebApi app)
| ?.WebApp | Web Application
| ?.WinformsApp | Winforms Application
| ?.WpfApp | WPF Application
| ?.Testing | Reusable Testing logic for use in Unit Tests and Integration Tests
| ?.UnitTests | Unit Tests for the whole solution
| ?.IntegrationTests | Integration Tests for the whole solution
| ?.Benchmarks | Benchmarks for the whole solution
| ?.MsiInstaller | Windows MSI installer
| ?.ForAndroid | Reusable logic for use in a platform such as Android whilst avoiding toolchain issues.<a href="#1">[1]</a>


## How do you check the naming convention automatically?

TODO.

## References

<href id="#1"></a>Montemagno, James (2020) Don't Put Android in Your Namespace in Xamarin Projects https://montemagno.com/dont-put-android-in-your-namespace-in-xamarin-apps/ (Accessed 2020-03-26)
