# Supported platforms

We aim to make the Google Cloud Libraries for .NET run in as wide a
set of environments as possible, where we have confidence that they
will work correctly.

The latest libraries (the ones with dependencies on Google.Api.Gax
4.x) target the **netstandard2.1** and **net462** [Target
Framework Monikers](https://docs.microsoft.com/en-us/nuget/schema/target-frameworks).
The `netstandard2.1` target is supported by .NET Core 3.1, and .NET 5+.

Please see the [Google Open Source .NET Support Policy]
(https://opensource.devsite.corp.google.com/documentation/policies/dotnet-support)
(which are followed by Google Cloud Libraries for .NET) for details
on how the set of supported platforms changes over time.

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
