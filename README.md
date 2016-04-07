[![Build Status](https://travis-ci.org/GoogleCloudPlatform/gcloud-dotnet.svg?branch=master)](https://travis-ci.org/GoogleCloudPlatform/gcloud-dotnet)

Google Cloud .NET Client
========================

.NET client libraries for [Google Cloud Platform][cloud-platform] services.

> Note: This client is a work-in-progress, and may occasionally
> make backwards-incompatible changes. The layout of the repository
> is likely to change, and names (of everything - assemblies,
> namespaces, types, members...) should be regarded as provisional.

Requirements
------

In order to build the code in this repository, you will need
to [install DNVM][dnvm]. You do not need DNVM to use the code,
provided as NuGet packages.

Most projects in this repository require [gRPC], which has a
component written in native code. Using that component from DNX
currently [requires a workaround][grpc-workaround]; on Windows please run `fix_dnx_grpc.bat`
before running any gRPC code.

Documentation
-------------

- [C# API reference](http://googlecloudplatform.github.io/gcloud-dotnet/)
- [Google Cloud Platform](https://cloud.google.com/docs/)

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
