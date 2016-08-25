# Frequently Asked Questions

## Why do libraries for gRPC-based APIs fail with dotnet cli?

The beta01 release of the libraries depends on gRPC 0.15. The
C# implementation of gRPC uses native libraries (e.g.
`grpc_csharp_ext.dll`), which are contained in the `Grpc.Core`
NuGet package.

The way in which these native libraries are copied at build time and
discovered at execution time depends on the toolchain used to build
the application, and gRPC 0.15 does not load these libraries correctly
under `dotnet cli`.

We hope to have a fix for this in time for the next beta release.

## How can I use the local emulator for Datastore or Pub/Sub?

Currently the libraries have no knowledge of the local emulators.
However, when creating a client, you can configure the endpoint that the library
connects to. If you set that endpoint to the port of an emulator, your
application should be able to use the emulator with no issues.

We hope to make this simpler to use in a future beta release.

## Why do the libraries not support .NET Core?

Currently some of the dependencies have limited portability, which prevents
us from targeting the `netstandard1.x` framework. We are working to resolve
these restrictions, and hope to support `netstandard1.5` for gRPC-based APIs
and `netstandard1.3` for REST-based APIs in the future. We expect this to be
sufficient for most customers, but please
[let us know](https://github.com/GoogleCloudPlatform/google-cloud-dotnet/issues/new)
if you have specific environments where you need support for lower versions,
and we can see what options are available.

## Why do credentials specified with GOOGLE_APPLICATION_CREDENTIALS fail?

By default, if you don't have the `GOOGLE_APPLICATION_CREDENTIALS`
environment variable set, the credentials will be obtained from the
`gcloud` tool, and will work with no problems. When credentials are
loaded from a file specified by the environment variable, they have
no scopes attached, and our gRPC-based API code didn't attach the
scopes required.

See [issue
294](https://github.com/GoogleCloudPlatform/google-cloud-dotnet/issues/294)
for the details, but the upshot is that it's been fixed, but isn't
in a public beta release yet.

If you need to use credentials in this way, you can use our [public
myget feed](https://www.myget.org/gallery/google-dotnet-public) and
fetch the latest version of the packages from there. (These are our
continuous integration builds.) From CI00174 onwards, the problem
should be fixed.
