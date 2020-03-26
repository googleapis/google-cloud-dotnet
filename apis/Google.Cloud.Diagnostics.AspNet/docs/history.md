# Version history

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
