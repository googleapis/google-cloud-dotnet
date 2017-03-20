# Supported platforms

We aim to make the Google Cloud Libraries for .NET run in as wide a
set of environments as possible, where we have confidence that they
will work correctly.

## REST-based libraries

These libraries target the **netstandard1.3** and **net45** [Target
Framework
Monikers](https://docs.microsoft.com/en-us/nuget/schema/target-frameworks).

Unfortunately there are currently issues supporting Universal
Windows Platform (UWP) applications, as discussed
[here](https://github.com/google/google-api-dotnet-client/issues/787).
When UWP is supported by the `google-api-dotnet-client` project, we
hope a subsequent release of the REST-based Google Cloud Libraries
for .NET will support UWP as well.

## gRPC-based libraries

These libraries target **netstandard1.5** and **net45**. They depend
on the [Grpc.Core](https://www.nuget.org/packages/Grpc.Core)
library, which has the same targets.

An additional constraint is that `Grpc.Core` contains a
platform-native component. This currently ships on x86 and x64 for
Linux, Windows and OS X, but not other platforms such as ARM.
