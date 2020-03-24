# BugGuardian.MVC
![CI](https://github.com/n3wt0n/BugGuardian.MVC/workflows/CI/badge.svg)
[![Release](https://img.shields.io/github/release/n3wt0n/BugGuardian.MVC.svg)](https://github.com/n3wt0n/BugGuardian.MVC/releases/latest)
[![License](https://img.shields.io/github/license/n3wt0n/BugGuardian.MVC.svg)](https://github.com/n3wt0n/BugGuardian.MVC/blob/master/LICENSE)

## Easily track you ASP.NET Core exceptions on Azure DevOps and TFS

**BugGuardian.MVC** is an extension for [*BugGuardian*](https://github.com/n3wt0n/BugGuardian), a library that allows to easily create a Bug or a Task work item on your *Azure DevOps* account or on your on-premises *Azure DevOps Server* and *Team Foundation Server 2015, 2017 and 2018* in the case your application throws an Unhandled Exception), specifically written to support ASP.NET MVC applications on Full .Net Framework. It adds an Action Filter to your application to let you automatically intercept all the exceptions.

It supports projects with .Net Framework 4.5 and above.

### Installation

The **BugGuardian.MVC** library is available on [NuGet](https://www.nuget.org/packages/DBTek.BugGuardian.MVC).
Just search *BugGuardian.MVC* in the **Package Manager GUI** or run the following command in the **Package Manager Console**:

```PowerShell
Install-Package DBTek.BugGuardian.MVC
```

> **WARNING**: If you are experiencing an error like *"BugGuardian.MVC already has a dependency defined for XXX"*, update your NuGet client to the latest version

### Usage

Refer to the [project documentation](https://github.com/n3wt0n/BugGuardian.MVC/wiki/Home) to find more information about this library.

Refer to the [BugGuardian project documentation](https://github.com/n3wt0n/BugGuardian/wiki/Home) to find examples about that.

> **WARNING**: From Dec 9, 2019 Azure DevOps does not support "Alternate Credentials" anymore. Please be sure to use a "Personal Access Token" instead (more info: https://devblogs.microsoft.com/devops/azure-devops-will-no-longer-support-alternate-credentials-authentication/))

### Support

If you encounter some issues trying this library, please let me know through the [Issues page](https://github.com/n3wt0n/BugGuardian.MVC/issues) and I'll fix the problem as soon as possible!

