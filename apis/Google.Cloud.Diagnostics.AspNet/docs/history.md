# Version history

# Version 4.0.0, released 2020-04-07

This is now expected to be the last version
of this package. It targets GAX 3.0, which allows the use of other
new client libraries also targeting GAX 3.0, but otherwise has no
new features. We are not expecting to continue working on this
package at all after this release, other than if a patch is
required.

# Version 4.0.0-beta01, released 2020-03-26

This is a beta for 4.0.0, which is now expected to be the last version
of this package. It targets GAX 3.0, which allows the use of other
new client libraries also targeting GAX 3.0, but otherwise has no
new features. We are not expecting to continue working on this
package at all after the 4.0.0 release, other than if a patch is
required.

# Version 3.0.0, released 2019-12-16

Note that this is the last version to depend on GAX 2.x and
Grpc.Core 1.x, and may be the last release of this package. If
there is significant demand for a version of this package depending
on GAX 3.x and Grpc.Core 2.x, we may create a new release for it,
but otherwise this package will be retired.

New features since 2.0.0:

- Remove service name and version requirement for error reporting.
- When logging exceptions, we have stopped logging HTTP Status Code information since we were storing inconsistent values.
- Adding GoogleWebApiExceptionLogger which supports proper exception logging, including HTTP context information for ASP.NET Web API applications.

# Version 2.0.0, released 2017-11-27

New features since 1.0.0:

- Support for .Net Framework 4.6.

# Version 1.0.0, released 2017-08-25

Initial Release
