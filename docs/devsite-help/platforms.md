# Supported platforms

We aim to make the Google Cloud Libraries for .NET run in as wide a
set of environments as possible, where we have confidence that they
will work correctly.

The latest libraries (the ones with dependencies on Google.Api.Gax
3.x) target the **netstandard2.0** and **net461** [Target
Framework Monikers](https://docs.microsoft.com/en-us/nuget/schema/target-frameworks).

> Note: Grpc.Core, the current default impementation of gRPC, does
> not support Apple M1 CPUs. If you are developing on a device using
> an M1, please adapt your client creation code to specify the
> Grpc.Net.Client implemenation [as shown here](https://github.com/googleapis/google-cloud-dotnet/issues/7560#issuecomment-975414370).
> This will become the default implementation in the next major
> version of the libraries.

Older versions of libraries (targeting Google.Api.Gax 2.x) support
older frameworks (netstandard1.3 or netstandard1.5, and net45) but
those are incompatible with the latest versions of Grpc.Core and
with C# 8 asynchronous sequences. We strongly recommend updating to
a newer framework supported by the latest libraries if you possibly
can.

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
