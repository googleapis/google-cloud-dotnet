# Long-running operations

Some API operations can take a relatively long time to complete, such as
rebooting a virtual machine or performing speech recognition on a large file.
Here, a "long time" is generally "anything over about 10 seconds". (It may not
seem a long time in human terms, but it's longer than you want an individual
RPC to last.)

## The long-running operation pattern in APIs

The *long-running operation* pattern is designed to avoid clients having to
worry about having too many pending RPCs, or what happens if a network
connection is dropped while a long-running operation is taking place.

The pattern is simple:

- The client makes an RPC request in the normal way, representing their
  intent ("reboot this VM" or "recognize text from this audio data").
- Assuming the request is valid, the server responds with an `Operation`
  response which contains an operation name.
- The client can *poll* using that operation name, to determine whether the
  long-running operation has completed, whether it's perhaps failed, any
  metadata indicating progress if it's still running, etc.

In many ways, long-running operations are the API equivalent of the
asynchronous `Task<T>` type in .NET.

## .NET library support for long-running operations

The Google Cloud Libraries for .NET are designed to make the pattern easy to
work with from client code. Any RPC which returns a long-running operation is
represented as a method with a return type of `Operation<TResponse, TMetadata>`
with suitable type arguments for `TResponse` (the response type) and
`TMetadata` (the metadata type). The response and metadata types are always
[protobuf messages](protobuf.md).

The `Operation<TResponse, TMetadata>` type has useful members:

- `PollOnce()`/`PollOnceAsync()`: makes an RPC to retrieve the latest state
  of the long-running operation. Note that the fresh state is returned as a new
  `Operation<TResponse, TMetadata>`; these methods do not modify the object
  it is called on.
- `Exception`: the exception represented in the operation, if it has failed.
- `IsCompleted`: indicates if the operation has completed; this will return true
  even if it has failed.
- `IsFaulted`: indicates if the operation has completed with a failure.
- `Metadata`: retrieves the metadata extracted from the underlying operation
  protobuf message.
- `Name`: the resource-name of the operation, which can be persisted and then
  used to retrieve the current state of the operation at another time.
- `Result`: retrieves the result of the underlying operation protobuf message,
  indicating the operation's final result, or throws an exception if the
  operation has not completed or has faulted.
- `PollUntilCompleted()`/`PollUntilCompletedAsync()`: makes multiple RPCs
  to retrieve the long-running operation, until it has completed (either
  successfully or ending in failure). The polling rate and other settings
  can be configured via a parameter of type `PollSettings`. The final state
  is returned as a new `Operation<TResponse, TMetadata>`; these methods do
  not modify the object it is called on.
- `Client`: obtains the `OperationsClient` used to make RPCs relating to
  long-running operations. (Most user code does not need to access this, as
  using the `PollOnce()` and `PollOnceAsync()` methods is typically simpler.)

Sample code for polling:

[!code-cs[](../examples/help.LongRunningOperations.txt#PollUntilCompleted)]
