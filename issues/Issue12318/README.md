This solution contains a number of projects aimed at reproducing and
diagnosing https://github.com/googleapis/google-cloud-dotnet/issues/12318

This appears to only affect Windows 11, .NET 7+ - and only if
another RPC has been issued on the same channel before the listen
requests are started.

The issue has now been reported in the grpc-dotnet repo:
https://github.com/grpc/grpc-dotnet/issues/2404

... see that issue for any further developments.

The RawGrpcStubs project is probably the most interesting, as it
takes all the GAPIC/GAX aspects out of the picture.
