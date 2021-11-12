{{title}}

{{description}}

{{version}}

{{installation}}

{{auth}}

## Getting started

Common operations are exposed via the
[BigtableClient](obj/api/Google.Cloud.Bigtable.V2.BigtableClient.yml)
class.

# Sample code

{{sample:BigtableClient.Overview}}

# Client life-cycle management

By default, clients share an internally managed Grpc.Gcp.GcpCallInvoker to
establish gRPC channels with the Bigtable service using default credentials.
This class allows for multiple channels to be used concurrently and
load-balances requests and streams among them. BigtableClient instances are
intended to be ephermal and will reuse an existing GcpCallInvoker instance
behind the scenes where possible.

Note that this reuse is dependent upon the settings which control the usage of
the GcpCallInvoker instance being identical. Accidentally using different settings
when creating different clients could result in unintended performance degredation
as setting up a new GcpCallInvoker is expensive compared to creating a new
BigtableClient.

{{sample:BigtableServiceApiSettings.CallInvokerSharing}}

# Non-default credentials

If you would like to create clients which share a GcpCallInvoker but do not
use the default credentials, this can easily be done by manually creating a
GcpCallInvoker and using Bigtable's default endpoint and settings.

{{sample:BigtableClient.CustomCallInvoker}}
