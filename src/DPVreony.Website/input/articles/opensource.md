# Getting involved as an Open Source maintainer

## New Project or Contribute elsewhere
### What's your motivation?

**TAKE NOTE:** If your motivation is money be aware it's very difficult to make a living from open source software.
If you're lucky you may get a job where you're paid to do open source software, or you may occasionally be offered money to support changes \ usages of your project.
It's also possible your open source may land you a job.

### What are your limitations?

Everyone has limitations. Time is finite and people have different strengths and weaknesses. Be honest with yourself and others. Look after your physical and mental health and avoid burnout.

## Managing your process and project via a maturity model

Your aim should be to have a project that is sustainable. The documentation below will detail a lot of things to consider and the more you can structure and automate the more you help yourself and other contributors not get bogged down in manual housekeeping. However taking the time to put processes in place also requires time and there are tradeoffs in up front time and the long term returns. The key is to understand the different considerations and keep a note of the decisions you make on them. This will help drive your understanding and plan your way through a sustainability and maturity model as you progress through the life of the project.

Source Code Storage
Personal Repo vs Organisation
Open Source Repository Management
Readme
* Give credit to others

## License

A license is an absolute must. Businesses and developers will not use projects where the legal protections are unclear.
[Choose a license](https://choosealicense.com/) is a great resource for understanding your choices on licenses.
It's also worth time to look and understand the views held for and against GPL and Microsoft originating licenses.

## Code Of Conduct

TODO

Be aware of the toxicity, allow yourself to disconnect from it. You can't please everyone.
Very few people engage with projects. A number will feel self entitlement to tell you what to do. It's rare for people to positively engage with a project to say thank you and\or help it expand.
Keep this in mind when you engage as well, be gracious and keep things civil and simple.

## Contributing Guidelines

TODO

## Security Disclosures

TODO

## Support Policy \ Lifespan

### In your readme establish a support policy.
* Will you offer support, or is the software "as is"?
* Will you offer paid support?
Having an open source license and paid support are not mutually exclusive, despite what you may be told by some consumers of your project.
* Will you accept requests for help via Github Issues?
* Will you suggest using an alternative site\platform for support?
* If you have dependencies on other packages, operating systems what is your lifetime support policy?

Things to consider here are operating systems have 10 year lifecycles. Some people will expect you to continue supporting old operating systems or frameworks. One strategy to this is "we work with the latest long term support version and offer no gurantees on old versions" and leave it up to consumers to contribute to help ensure things don't break on older versions. However it can be unreasonable for someone to expect an old out of support framework to be maintained. They have the option to fork the repository if they so desire, be aware of ther overhead of taking on a contribution if it's going to cause you excess overhead on the sustainability model of the project.

### Dealing with Issues \ Tickets
* Consider templates for the different types of tickets
* Enforcement of tickets not following the templates
* Auto lock old closed items.

## Covering costs \ Monetization
### Sponsorship

Github run a sponsorship program and there are also options such as Open Collab. As previously mentioned the amount of money these tend to generate is not a lot to make a living off. It may cover costs.

Be aware of sponsorship abuse if you list sponsors on your site and\or project. There are some organizations such as Casinos that place sponsorship as a form of advertisement and Page Rank boosting for links into their own domains.

### Licensing for open source projects
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
Stack overflow is a community site that can self driving for knowledge can be a good way of having a community help each other and articles are archived by a search engine. Unlike IM platforms they don't require additional tools. When starting out it can be important to keep an eye, as your userbase grows you may find you gain a critical mass and others will keep the knowledge flowing.
Stack overflow can be a toxic and intimidating environment with over zealous, opaque and unaccountable moderation combined with "newbie" intolerant contributors it can be an offputting experience. Stack Overflow has introduced a code of contact but as of May 2020 it has no visible benefit. I would recommend using an integration with a messaging tool such as Slack to monitor keywords relating to your project. But I would NOT use it as the primary driver of support and knowledge.

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

## Tooling

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

Getting a developer started.

### Codespaces
### Gitpod
### Local development environment

Automated Builds.

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
    * Use a dependency update tool
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
  * Jetbrains duplicate code scanner
* Benchmarking

## Continous Integration
* Choosing a build host
  AppVeyor
  Github Actions
  Azure Devops Pipelines
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