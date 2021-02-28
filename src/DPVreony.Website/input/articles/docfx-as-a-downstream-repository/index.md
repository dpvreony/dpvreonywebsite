# Using DocFx as the Document Generation Toolset in a downstream repository.

| | |
| - | - |
| Article Status | Draft |
| Article Version | 0.1 |
| First Written | 2021-01-20 |
| Last Revision | 2021-02-28 |
| License | MIT |


<div class="alert alert-info">
  <strong>TLDR:</strong> The sample repository is available at: <a href="https://github.com/dpvreony/article-docfx-downstream">https://github.com/dpvreony/article-docfx-downstream</a>.
</div>


## Introduction

DocFx is a powerful document generation tool for the .NET ecosphere. It natively works with the XMLDOC of C#
and can be embedded into a build chain rather easily. The challenge is if you want to be building and managing
the article and concept documentation independently of code changes. For example you want to clarify something
in a set of instructions, typically a build chain will build + deploy both the application\ library and the documentation.

## An alternative process by isolating the docfx project

You can use either a separate repository (how microsoft docs work) or a detached git branch (which is the way the github gh-pages branch documentation feature works).

### Assumptions before you start

* You're publishing a nuget package for a library.
* You're producing code documentation and including it in the nuget package.
* This article is going to use nucleotide as the example. You may want to follow along, or use your own project.

## Getting started

### 1. Create a repository

<div class="alert alert-info">
  <strong>Template Available :</strong> The sample repository <a href="https://github.com/dpvreony/article-docfx-downstream/generate">can be used as a template</a>. This will let you skip steps 1, 2, 5 and 6 so you can follow along and just tweak the necessary files and processes.
</div>

* Create a new repository
* Place a Visual Studio .gitignore file
* Choose your license (if you desire)
* Clone the repository locally

<div class="alert alert-info">
  For further information on setting up repositories on github check out the <a href="https://guides.github.com/activities/hello-world/">github hello world guide</a>.
  To understand some of the details around github pages check out the <a href="https://guides.github.com/features/pages/">Getting started guide</a>.
</div>

### 2. Create a docfx project

* Create a blank solution in a src subdirectory of the repository
* Create a netcore library project named docfx
* Add the DocFx nuget package to the project.

<div class="alert alert-info">
  For more information on DocFx check out the getting started tutorial.
</div>

<div class="alert alert-warning" role="alert">
  To save yourself some pain and confusion when setting up the CI build later, place a nuget.config file in the repository. There are known issues with the github action images where they will fail to restore packages correctly as they may only reference the local package store.
</div>

### 3. Verify the build process works by starting the site up locally.

From a Developer Command prompt in solution run the following (assuming the current directory is the repository src folder)

`docfx serve docfx\_site`

In the console you should see a success message stating what port the site is available on.

`
SOME BLURB HERE
`

And you should be able to browse to the site and see something that looks like:

SOME IMAGE HERE

<div class="alert alert-warning" role="alert">
  You may experience issues with accessing localhost sites using Microsoft Edge. This is to do with the loopback protection that you may wish to disable by checking the <strong>Allow localhost loopback</strong> setting via <strong>about:flags</strong>. Other browsers may not have this security behaviour.
</div>


### 4. Add references to the upstream nuget packages

Unfortunately it's not as simple as **just** adding your documented packages as a PackageReference to a C# project (.csproj) file because by default the packages are no longer restored into a packages folder of the repository. So we have to do some work of our own. That said, to allow dependency management tools such as Dependabot to do their work of updating references to upstream dependencies we will take advantage of a C# project!

### 5. Create a Build event to retrieve the xmldoc from the nuget packages.

TODO.

### 6. Configure the docfx script to process the xml from the nuget packages

TODO.

### 7. Configure the repository for Continous Integration and Deployment

TODO.

### 8. Configure the repository to track changes to the upstream nuget packages

By using a C# project with package references. You're already a good way down the road to being able to automate this. In this example I will use Dependabot but there are other dependency management tools available, or you can opt to manage it via your own process.

One of the easiest ways to do this to take an existing dependabot yaml config file and place it at the root of your git repository. You want it to look something like this.

``YAML
{SOME CODE HERE}
``

## References

Solidly Stated: Edge Windows 10 can't reach localhost sites (2017) https://solidlystated.com/software/edge-windows-10-cant-reach-localhost-sites/ (Accessed 2021-02-28)
