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

## Mobile platform support

We do not currently support Xamarin or Unity. While we would like
to, there are significant challenges around providing the level of
automated testing and developer reproducibility required for us to
feel comfortable describing these platforms as "supported".

Additionally, the authentication model for the services is intended
primarily for end user access to user-owned resources (such as
calendars or documents), or for access based on Google Cloud
Platform projects. The latter adds challenges to accessing general
Google services such as Cloud Speech-to-Text from user-owned devices.

For Unity users, we recommend consulting the [Firebase Unity
documentation](https://firebase.google.com/docs/unity/setup) to see
whether the service you wish to access is covered by the Firebase Unity
SDKs.

You may find that the packages provided work in some scenarios for
Xamarin and Unity, but we are unable to provide support for this,
and would recommend not relying on this for production applications.

We review our support for mobile platforms regularly, and hope to be
able to support at least Xamarin and Unity at some point, but with
no specific plans at the moment.
