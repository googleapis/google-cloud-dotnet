# Breaking changes (June 2022)

Prior to June 2022, all API client libraries targeted GAX
(Google.Api.Gax and related packages) version 3.x (or older).

[GAX v4.0.0](https://github.com/googleapis/gax-dotnet/releases/tag/Google.Api.Gax-4.0.0)
was released on June 6th 2022, with various breaking changes.
Most of these are *theoretical* breaking changes in that they won't
affect most users; they're changes to API surfaces which are usually only
referenced by generated code. (The generators have been changed to take this into
account, of course.)

That said, there are *some* breaking changes to be aware of that are more likely
to affect users, as described below. If you encounter an issue which isn't
covered below or in the library-specific version history, please
[file a GitHub issue](https://github.com/googleapis/google-cloud-dotnet/issues/new/choose).

## Platform support

GAX v4 targets .NET Standard 2.1 and .NET 4.6.2.
(For reference, GAX v3 supported .NET Standard 2.0 and .NET 4.6.1.)

This means that if you want to use the API libraries targeting GAX
v3, you need to be using .NET Core 3.1 or .NET 4.6.2, or a higher
version of either of these.

## Obsolete members

Obsolete members of libraries have been removed, unless they are part of the API
surface the library exposes.

## IAM methods

Some libraries (e.g. PubSub) included IAM methods directly within the client surface.
These are now exposed via a separate client, accessed via the `IAMPolicyClient` property
of the "main" API client. For example, a previous call of `client.GetIamPolicy(name)`
should be changed to `client.IAMPolicyClient.GetIamPolicy(name)`.
