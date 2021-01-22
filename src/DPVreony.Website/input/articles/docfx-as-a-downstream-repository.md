# Using DocFx for Document Generation Toolset in a downstream repository

DocFx is powerful document generation tool for the .NET ecosphere. It natively works with XMLDOC of C#
and can be embedded into a build chain rather easily. The challenge is if you want to be building and managing
the article and concept documentation independently of code changes. For example you want to clarify something
in a set of instructions, typically a build chain will build + deploy both the application and the documentation.

# An alternative process by isolating the docfx project

You can use either a separate repository (how microsoft docs work) or a detatched git branch (which is the way the gh-pages branch documentation works)

## Assumptions before you start

* You're publishing a nuget package.

* You're producing code documentation and including it in the nuget package.

## Working in a separate repository

* Create a repository

* Create a doxfx project

* Add references to the upstream nuget packages

* Configure the docfx script to process the xml from the nuget packages

* Configure the repository for a Continous Integration and Deployment

* Configure the repository to track changes to the upstream nuget packages
