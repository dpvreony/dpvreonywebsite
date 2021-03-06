# Devising a naming convention for .NET projects

| | |
| - | - |
| Article Status | Draft |
| Article Version | 1.0 |
| First Written | 2021-03-06 |
| Last Revision | 2021-03-06 |
| License | MIT |

| - | - |
| ?.Client | Strongly Typed Client Logic. i.e. Http clients
| ?.DotNetTool | Dot Net Core Command Line Tool
| ?.Server | Shared Server Logic
| ?.Shared | Shared Client \ Server Logic
| ?.WebSocketApp | Web Socket Application (If using one and splitting from WebApp \ WebApi app)
| ?.WebApp | Web Application (If using one)
| ?.WinformsApp | Winforms Application (If using one)
| ?.WpfApp | WPF Application (If using one)
| ?.Testing | Reusable Testing logic for use in Unit Tests and Integration Tests
| ?.UnitTests | Unit Tests for the whole solution
| ?.IntegrationTests | Integration Tests for the whole solution
| ?.Benchmarks | Benchmarks for the whole solution