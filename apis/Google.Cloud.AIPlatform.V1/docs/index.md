{{title}}

{{description}}

{{version}}

{{installation}}

{{auth}}

## Getting started

{{client-classes}}

Clients in this API must be constructed with a regional endpoint.
This can be done easily using the builder for a specific client
(`DatasetServiceClientBuilder` for `DatasetServiceClient` for
example). The following example shows how to list the datasets for a
given project in the `us-central1` region.

{{sample:Readme.Endpoint}}

## Constructing schema values

Various aspects of the API use schemas which are represented using
`Google.Protobuf.WellKnownTypes.Value`, which is a generic
representation of a JSON value in Protocol Buffers.

Protocol Buffer messages are available for these schemas, and they
can be converted to and from `Value` objects using the
`ValueConverter` class, as shown below.

{{sample:Readme.MessageToValue}}
