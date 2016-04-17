Google Cloud .NET Client
========================

.NET idiomatic client libraries for [Google Cloud Platform][cloud-platform] services.

[![Build Status](https://travis-ci.org/GoogleCloudPlatform/gcloud-dotnet.svg?branch=master)](https://travis-ci.org/GoogleCloudPlatform/gcloud-dotnet)

> Note: This client is a work-in-progress, and may occasionally
> make backwards-incompatible changes. The layout of the repository
> is likely to change, and names (of everything - assemblies,
> namespaces, types, members...) should be regarded as provisional.

- [Client Homepage and API Documentation][Homepage]
- [.NET Developer Hub][devhub]

This client supports the following Google Cloud Platform services:

- Google [Cloud Datastore][cloud-datastore] (beta)
- Google [Cloud Pub/Sub][cloud-pubsub] (alpha)
- Google [Cloud Storage][cloud-storage] (alpha)
- Google [Cloud Logging][cloud-logging] (alpha)

If you need support for other Google APIs, check out the [Google .NET API Client library][api-client-lib].


Build
-----

In order to build the code in this repository, you will need
to [install DNVM][dnvm]. You do not need DNVM to use the code,
provided as NuGet packages.

Most projects in this repository use [gRPC], which has a
component written in native code. Using the native component from DNX
currently [requires a workaround][grpc-workaround]. On Windows, this workaround
can be applied by running `fix_dnx_grpc.bat` before running any gRPC code.

Contributing
------------

Contributions to this library are always welcome and highly encouraged.

See [CONTRIBUTING] for more information on how to get started.

Versioning
----------

These libraries follow [Semantic Versioning](http://semver.org/).

Anything with a major version of zero (``0.y.z``) should not be
considered stable - anything may change at any time.

License
-------

Apache 2.0 - See [LICENSE] for more information.


[CONTRIBUTING]:https://github.com/GoogleCloudPlatform/gcloud-dotnet/blob/master/CONTRIBUTING.md
[LICENSE]: https://github.com/GoogleCloudPlatform/gcloud-dotnet/blob/master/LICENSE
[cloud-platform]: https://cloud.google.com/
[dnvm]: http://docs.asp.net/en/latest/getting-started/index.html
[gRPC]: http://grpc.io
[grpc-workaround]: https://github.com/grpc/grpc/issues/4872
[Homepage]: http://googlecloudplatform.github.io/gcloud-dotnet/
[devhub]: https://cloud.google.com/dotnet/
[cloud-datastore]: http://googlecloudplatform.github.io/gcloud-dotnet/#google-datastore-v1beta3
[cloud-pubsub]: http://googlecloudplatform.github.io/gcloud-dotnet/#google-pubsub-v1
[cloud-storage]: http://googlecloudplatform.github.io/gcloud-dotnet/#google-storage-v1
[cloud-logging]: http://googlecloudplatform.github.io/gcloud-dotnet/#google-logging-v2
[api-client-lib]: https://github.com/google/google-api-dotnet-client