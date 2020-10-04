# Getting involved as an Open Source maintainer

New Project or Contribute elsewhere
* What's your motivation?
STOP: If your motivation is money be aware it's very difficult to make a living from open source software.
If you're lucky you may get a job where you're paid to do open source software, or you may occasionally be offered money to support changes \ usages of your project.
It's also possible your open source may land you a job.
* What's your limitations?
Everyone has limitations. Time is finite and people have different strengths and weaknesses. Be honest with yourself and others. Look after your physical and mental health and avoid burnout.

Managing your process and project via a maturity model

Source Code Storage
Personal Repo vs Organisation
Open Source Repository Management
Readme
* Give credit to others

License

Choose a license

Code Of Conduct

Contributing Guidelines

Security Disclosures

Support Policy \ Lifespan

* Auto lock old closed items.

Sponsorship

Github run a sponsorship program and there are also options such as Open Collab. As previously mentioned the amount of money these tend to generate is not a lot to make a living off. It may cover costs.

Be aware of sponsorship abuse if you list sponsors on your site and\or project. There are some organizations such as Casinos that place sponsorship as a form of advertisement and Page Rank boosting for links into their own domains.

Another possibility is the coverage of costs of licenses and\or hosting. There are suppliers of development tools and hosting that offer incentives to open source projects. These may be free in return for a logo or mention on your site.

Conformance \ Branch Policies

Merge - Squash Commit

Automation

* Dependency Updates
  * Dependabot

Github

Repository tags

Wiki or not to wiki?

Generating Traffic and Raising awareness

Project succession

## Community

### Own websites

* Issues \ Bugs workflows on github

### External Management

#### Stack overflow
Stack overflow is a community site that can self driving for knowledge can be a good is a good way of having a community help each other and articles are archived by a search engine. Unlike IM platforms they don't require additional tools. When starting out it can be important to keep an eye, as your userbase grows you mya find you gain a critical mass and others will keep the knowledge flowing.
Stack overflow can be a toxic environment with over zealous, opaque and unaccountable moderation combined with "newbie" intolerant contributors it can be an offputting experience. Stack Overflow has introduced a code of contact but as of May 2020 it has no visible benefit. I would recommend using an integration with a messaging tool such as Slack to monitor keywords relating to your project. But I would NOT use it as the primary driver of support and knowledge.

One of the uses to consider using Stack Overflow for is to track requests for the problem your product \ project is aiming to solve. Be careful not to have your answer look like advertisements but show how it solves the problem of the question being asked.

#### Comms tools such as Slack \ Gitter.im
* Messaging tools can be a handy platform but take into consideration there is knowledge being captured that can be useful to others in the future and not readily available. Look for a way to extract them automatically, have people update the documentation, or encourage the use of sites like stack overflow.

### Idea Management
** Capture ideas.
Capture accepted and rejected reasons.
*** Requests for Comments (RFC's)
** Architecture Design Reasoning.
** UML
** Iteration

Tooling

Solution Structure
Unit Tests
Benchmarks
Experimental
Sharing configuration across .NET projects with directory.props and directory.targets
** 
Strong Name Signing
* Don't (explain the headaches)
* Give instructions to Claire Ovotony's self sign tool
Authenticode Signing

Getting a developer started locally.

Automated Build Script.
* Script Bootstrapping
  * Cake
  * Nuke
  * Vanilla MSBuild
* Build Solution
  * Restore logs
  * Build logs
* Treat Warnings as Errors
* Unit Tests
* Code Coverage
* Integration Testing
  * In memory test harness
  * OWASP ZAP Scanning
* Breaking Change Scanning
* Documentation Generation
  * OMD generation
  * Enable xmldoc generation
  * Use a separate branch or repo for documentation?
    * Ship a nuget package
    * make the recipient docfx repository depend on the package
    * Use a depedency update tool
    * run a package restore task
    * run a pre build task to extract the nuget package contents
  * DocFx
    * configure docfx to scan the extracted nuget packages for dll and xml
  * PlantUml
  * Structuring content
* Integration Tests
* Fail Build On Lack of Coverage
* Package Artifacts
  * Docker
  * Nuget
    * Package signing
    * Reviewing packages
    * Testing packages
  * WIX
    * Machine or PerUser install?
  * Octopack
  * Zip
  * MSDeploy
* Out of date depedency analysis
* Dependency License Analysis
* Static Code Analysis
  * Sonarqube
* Technical Debt Monitoring
  * Sonarqube
* Benchmarking
  * Jetbrains duplicate code scanner

## Continous Integration
* Choosing a build host
* Upload coverage
* Deploy documentation

## Continous Deployment
* Libraries vs Applications
* Choosing a deployment toolset
* Managing risk

## Planning hosting
* Planning decomission
* Planning rollback \ rollforward fixing
* Planning Staging \ Canary deployments
* Planning High Availability \ Disaster Recover
* Planning deployment

## Milestone deployments

## Deployment Verificiation
* Entity Framework
* HTTP endpoint available per node
* Healthcheck API call
* Windows service installed + running

## Dealing with consumers
* Change requests
* Defining value

## Branch strategy

### Work Items and Pull Requests
## Defining exit criteria

## Versioning

## Fault Tracking and Performance Monitoring
# Defining performance

## Releasing