# Supported platforms

We aim to make the Google Cloud Libraries for .NET run in as wide a
set of environments as possible, where we have confidence that they
will work correctly.

Libraries with dependencies on Google.Api.Gax 4.8.0 and later
target the **netstandard2.0** and **net462** [Target
Framework Monikers](https://docs.microsoft.com/en-us/nuget/schema/target-frameworks).
The `netstandard2.0` target is supported by .NET Core 2.0, and .NET
5+, as well some versions of .NET Framework. .NET Core and .NET
runtimes prior to .NET 6 are not supported by Microsoft however, and
the support for the `netstandard2.0` target from .NET Framework is
complex. (See the [Microsoft documentation]
(https://learn.microsoft.com/en-us/dotnet/standard/net-standard?tabs=net-standard-2-0)
for more details.)

Please see the [Google Open Source .NET Support Policy]
(https://opensource.google/documentation/policies/dotnet-support)
(which are followed by Google Cloud Libraries for .NET) for details
on how the set of supported platforms changes over time.

## netstandard2.1 vs netstandard2.0

Client libraries with dependencies on GAX 4.0.x-4.7.x used Target
Framework Monikers of netstandard2.1 and net462; in March 2024 we
changed to use netstandard2.0 where possible to make the libraries
compatible with other open source libraries targeting netstandard2.0,
as most don't require anything from netstandard2.1. For most clients,
this change will not be noticeable at all.

In testing this change, we discovered one very specific situation in
which the change could break users. If gRPC client libraries are
loaded via reflection using `Assembly.LoadFrom`, the version of
the Grpc.Net.Client assembly loaded could change to the one with the
netstandard2.0 target. This will always fail to create channels
(even when running in a .NET runtime with full HTTP/2 support),
leading to an attempt to use the Grpc.Core implementation. (This
attempt will fail unless a Grpc.Core dependency is in place.) While we
think it unlikely that customers will be using the libraries in this
way, if you encounter this problem you can work around it by adding
a direct Grpc.Net.Client dependency to your application. If this
doesn't help, please [file an
issue](https://github.com/googleapis/google-cloud-dotnet/issues/new/choose)
with details.

## Mobile platform support

We do not currently support mobile platforms such as MAUI, Xamarin,
or Unity. While we would like to, there are significant challenges
around providing the level of automated testing and developer
reproducibility required for us to feel comfortable describing these
platforms as "supported".

Additionally, the authentication model for the services is intended
primarily for end user access to user-owned resources (such as
calendars or documents), or for access based on Google Cloud projects.
The latter adds challenges to accessing general Google services such
as Cloud Speech-to-Text from user-owned devices.

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
