# Version history

# Version 4.2.0, released 2020-12-07

No API changes since 4.0.0-beta01, but this is the first stable release.

The version number is 4.2.0 to align with
Google.Cloud.Diagnostics.AspNetCore and
Google.Cloud.Diagnostics.Common.

# Version 4.0.0-beta01, released 2020-10-12

- [Commit 1cd4ee6](https://github.com/googleapis/google-cloud-dotnet/commit/1cd4ee6): feat: Adds Google.Cloud.Diagnostics.AspNetCore3 library. Towards [issue 4750](https://github.com/googleapis/google-cloud-dotnet/issues/4750).
  - Initial release of Google.Cloud.Diagnostics.AspNetCore3 which supports ASP.NET Core 3.1.
  - Main differences with respect to Google.Cloud.Diagnostics.AspNetCore:
    - Depends on Microsoft.AspNetCore.App framework instead of the Microsoft.AspNetCore* packages.
    - Microsoft.AspNetCore.Hosting.IHostingEnvironment => Microsoft.AspNetCore.Hosting.IWebHostEnvironment
