# Protocol buffers in Google Cloud Libraries for .NET

[Protocol buffers](https://protobuf.dev) - also known as *protobuf* for short - are Google's language-neutral, platform-neutral, extensible mechanism for serializing structured data.

Almost all the Google Cloud Libraries are generated from API
definitions using protobuf, in the
[GitHub googleapis/googleapis repository](https://github.com/googleapis/googleapis).

Most protobuf messages in the APIs are simply generated with `protoc`
(the Protocol Buffer Compiler) using the vanilla C# plugin. However,
the generated partial classes are augmented in some libraries:

- [Pagination](page-streaming.md) requires request/response types
  to implement specific interfaces from GAX.
- [Resource names](resource-names.md) add resource-name-typed properties
  as strongly-typed "views" over string fields declared in the messages.
- In some libraries, classes are augmented to provide simpler ways of
  creating instances, such as via the `Filter` class in Datastore.

For the most part, protobuf objects can be treated like normal mutable
data transfer objects which happen to have well-defined binary and JSON
formats. The sections below provide more information in areas which have
previously caused some confusion.

## Repeated fields and map fields

The generated C# code for protobuf messages makes simple properties
read/write, but repeated fields and map fields are read-only. That
doesn't stop you from populating them, though; it just means you
can't change the property to refer to a *different* list or map.

Typically you'll populate this using a *collection initializer*
nested within an *object initializer*. As an example, let's look at
how we might create a `BatchAnnotateImagesRequest` message in the
Vision API. (This is just an easy-to-understand example; the
Google.Cloud.Vision.V1 package provides helper methods to avoid you
having to create batches yourself in most cases.)

The protobuf description looks like this:

```proto
// Multiple image annotation requests are batched into a single service call.
message BatchAnnotateImagesRequest {
  // Individual image annotation requests for this batch.
  repeated AnnotateImageRequest requests = 1;
}
```

In the generated C# code, the `Requests` property of
`BatchAnnotateImagesRequest` is read-only, but you can populate it
with a collection initializer:

[!code-cs[](../examples/help.Protobuf.txt#ProtoRepeatedField1)]

You don't *have* to use a collection initializer though, and
sometimes it would be inconvenient to do so. It's perfectly valid to
add to the repeated field after other initialization:

[!code-cs[](../examples/help.Protobuf.txt#ProtoRepeatedField2)]

Finally, it's worth being aware that `RepeatedField<T>` has an `Add`
overload accepting an `IEnumerable<T>`. This allows you to use a
collection initializer to copy items out of another collection, or a
LINQ query result:

[!code-cs[](../examples/help.Protobuf.txt#ProtoRepeatedField3)]

Likewise for map fields (which are significantly less common) you
can use collection initializers, or (from C# 6 onwards) the indexer
syntax within an object initializer. As an example of this, let's
consider the Scheduler V1 API, which contains a message like this:

```proto
message HttpTarget {
  // Other fields omitted

  // The user can specify HTTP request headers to send with the job's
  // HTTP request. (Further documentation omitted here.)
  map<string, string> headers = 3;
}
```

Again, the `Headers` property in the generated message is read-only,
but you can populate it with a collection initializer:

[!code-cs[](../examples/help.Protobuf.txt#ProtoMap1)]

Or an indexer in an object initializer:

[!code-cs[](../examples/help.Protobuf.txt#ProtoMap2)]

Or modify it after other initialization steps:

[!code-cs[](../examples/help.Protobuf.txt#ProtoMap3)]

## JSON parsing and formatting

Protobuf messages have a JSON format as well as the natural binary wire format.
The Google.Protobuf library makes it easy to parse JSON into messages using
`JsonParser` or format messages as JSON using `JsonFormatter`.

**Do not use regular .NET JSON libraries such as Newtonsoft.Json or
System.Text.Json to convert between JSON and protobuf messages. The protobuf
library is aware of protobuf conventions, some custom representations for well-known
types etc.**

Sample formatting code:

[!code-cs[](../examples/help.Protobuf.txt#JsonFormatting)]

Sample parsing code:

[!code-cs[](../examples/help.Protobuf.txt#JsonParsing)]

## Value and Struct

Some APIs use the *well-known types* of `google.protobuf.Value`
and `google.protobuf.Struct` which are represented by the .NET types
`Google.Protobuf.WellKnownTypes.Value` and `Google.Protobuf.WellKnownTypes.Struct`.

The `Value` message represents any JSON value (string, number,
Boolean, null, list, object), and `Struct` represents any JSON object.

`Google.Protobuf.WellKnownTypes.Value` has static factory methods
to create instances:

- `Value ForString(string value)`
- `Value ForNumber(double value)`
- `Value ForBool(bool value)`
- `Value ForNull()`
- `Value ForList(params Value[] values)`
- `Value ForStruct(Struct value)`

There are currently no built-in helper methods to create `Struct` instances,
but the common cases of wanting to convert a message to a struct or vice versa
can be handled by converting to JSON and back:

[!code-cs[](../examples/help.Protobuf.txt#StructConversions)]

(Note that these assume the JSON representation of the message is a
JSON object; that's the case for all "normal messages", but some
well-known types such as `Duration` have simple string representations in JSON.)
