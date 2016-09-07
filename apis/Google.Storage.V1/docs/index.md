# Google.Storage.V1

`Google.Storage.V1` is a .NET client library for [Google
Cloud Storage](https://cloud.google.com/storage/). It wraps the
`Google.Apis.Storage.v1` generated library, providing a
higher-level API to make it easier to use.

# Installation

Install the `Google.Storage.V1` package from NuGet. Add it to
your project in the normal way (for example by right-clicking on the
project in Visual Studio and choosing "Manage NuGet Packages...").
Please ensure you enable pre-release packages (for example, in the
Visual Studio NuGet user interface, check the "Include prerelease"
box).

# Authentication

To authenticate all your API calls, first install and setup the
[Google Cloud SDK](https://cloud.google.com/sdk/). After that is
installed, run the following command in a Google Cloud SDK Shell:

```sh
> gcloud auth login
```

# Getting started

Common operations are exposed via the
[StorageClient](obj/api/Google.Storage.V1.StorageClient.yml) class.

# Sample code

[!code-cs[](obj/snippets/Google.Storage.V1.StorageClient.txt#Overview)]
