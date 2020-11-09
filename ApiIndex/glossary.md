# Glossary for the API Index

Our use of various API-related terms is inconsistent in general. The
API Index attempts to be strongly consistent within itself, and
broadly consistent with common usage as far as possible.
Known inconsistencies are highlighted below.

## API

An API is a collection of services and associated protobuf messages.
Within the API Index, the granularity of an API is "a versioned
proto package", and that package is used as the identifier of the
API.

Examples:

- `google.devtools.cloudtrace.v1` and
`google.devtools.cloudtrace.v2` are separate APIs, because they are
in different versioned packages.
- `google.ads.googleads.v3` is the identifier for the API that
contains `google.ads.googleads.v3.services.AdGroupAdService` and
`google.ads.googleads.v3.resources.AdGroup`, because that identifier
represents the versioned protobuf package.

Note that there are three APIs which are not versioned:

- `google.bytestream`
- `google.cloud.location`
- `google.longrunning`

These are some of the oldest APIs in the index, and are treated as
implicitly being "v1".

Inconsistency note: an API in our terminology is equivalent to a
[`google.api.Service`](https://github.com/googleapis/googleapis/blob/master/google/api/service.proto).

## Service

A service is a collection of methods within an API, represented by a
`service` element within a proto file.

The *short name* of a service is its name within the package of the
proto file it's declared in.

Inconsistency note: a service in our terminology is equivalent to an
[`google.protobuf.Api`](https://github.com/protocolbuffers/protobuf/blob/master/src/google/protobuf/api.proto).

## Method

A method is the target of an RPC within a service, represented by a
`rpc` element within a proto file.

Inconsistency note: protobuf itself is inconsistent here; although
the element in a proto file is called `rpc`, methods are represented
in protobuf metadata using the `MethodDescriptorProto` message. It's
useful to distinguish between methods (the declarations) and RPCs
(the execution-time calls to methods) as described below.

## RPC

An RPC is a call to a method within a service. RPCs don't exist
within the schema itself because they're performed at execution
time. (For example, you might say that an application made 5 RPCs
to the `TranslateText` method within the `TranslationService`
service within the `google.cloud.translation.v3` API.

## Method mode

Protobuf methods can use one of four modes:

- Unary: single request, single response
- Client-streaming: a sequence of requests leading to a single response
- Server-streaming: a single request leading to a sequence of responses
- Bidirectional streaming: a sequence of requests and responses (with no necessary correlation between the two)
