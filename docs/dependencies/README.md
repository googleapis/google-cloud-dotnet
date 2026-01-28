# docfx dependencies

These are the xrefmaps used in docfx generation where necessary.
(They're only required during HTML generation, but that's relevant
for *some* packages, particularly those hosted on googleapis.dev.)

To update after running the Kokoro job which calls
`generate-devsite-utilities.sh`, use `gcloud storage` with an account that
has access to `docs-staging-v2`. Include the version you have just
generated in the object name. Sample commands:

```sh
gcloud storage cp gs://docs-staging-v2/xrefs/dotnet-Google.Protobuf-3.27.1.tar.gz.yml Google.Protobuf.xrefmap.yml
gcloud storage cp gs://docs-staging-v2/xrefs/dotnet-Google.Apis-1.68.0.tar.gz.yml Google.Apis.xrefmap.yml
gcloud storage cp gs://docs-staging-v2/xrefs/dotnet-Google.Api.CommonProtos-2.15.0.tar.gz.yml Google.Api.CommonProtos.xrefmap.yml
gcloud storage cp gs://docs-staging-v2/xrefs/dotnet-Grpc.Core-2.63.0.tar.gz.yml Grpc.Core.xrefmap.yml
gcloud storage cp gs://docs-staging-v2/xrefs/dotnet-Google.Api.Gax-4.8.0.tar.gz.yml Google.Api.Gax.xrefmap.yml
```

The REST library xrefmaps can be fetched from googleapis.dev:

```sh
curl -sSL https://googleapis.dev/dotnet/Google.Apis.Storage.v1/latest/xrefmap.yml -o Google.Apis.Storage.v1.xrefmap.yml
curl -sSL https://googleapis.dev/dotnet/Google.Apis.Bigquery.v2/latest/xrefmap.yml -o Google.Apis.Bigquery.v2.xrefmap.yml
```
