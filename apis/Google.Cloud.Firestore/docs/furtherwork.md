# Further work and decisions

The library is currently at a reasonably early stage. This page provides a list of further work that needs doing and
public API options to consider. This is a subset of the "TODO" comments found in the code.

## Expose cleaner ways of performing update operations

We need to think about this before implementing, as it affects `DocumentReference`, `Transaction` and `WriteBatch`.

A few possible options (leaving off the preconditions and any cancellation token):

- `Update(DocumentReference documentReference, object documentData)`  
  Used with anonymous types or dictionaries, this could be great for top-level
  fields: `Update(doc, new { Score = 20 })`. It gets harder when thinking about
  nested maps.
- `Update(DocumentReference documentReference, string field, object value)` and
  potentially multiple overloads for more fields (alternating field, value, field, value).
  This could be nice, but will be limited.
- `Update(DocumentReference documentReference, params (string path, object value)[] updates)`  
  Required users to be aware of C# 7 tuples, but then it's pretty nice. (It also adds a dependency
  on `System.ValueTuple`, but that shouldn't be a big deal.)

## Do we need synchronous operations?

Currently everything that interacts with the server uses asynchrony.
I'm tempted to keep it that way, but we could provide synchronous operations if necessary.
It's slightly awkward to wrap the streaming calls in synchronous operations though.

## Serialization

### Performance

Currently we use a lot of reflection all the time. We should be able to use expression trees to build
up complete serializers and deserializers once per target type, if we're careful. This is a lot of effort,
but should improve client-side performance a lot. It should be fairly easy to benchmark, and can be optimized without
affecting the public API.

### Data type support

Should we try to support `Guid`, `decimal`, anything similar? Other collection types?

We currently implicitly support `ExpandoObject` for serialization, but we could deserialize to that as well
(defaulting all nested maps to that too), if accessing data via dynamic types is useful.

## Options for attributed classes

We can provide a lot of tweaking of the behavior of attributed classes. For example:

- Specify the default naming convention for all properties in the class, e.g. convert `FooBar` to `foo_bar` automatically if that's the specified convention
- Specify what should happen to fields that are being deserialized and don't have a matching property
- Specify whether *all* properties should be considered by the serializer/deserializer, or only those with `[FirestoreProperty]`

## Options for asynchrony in transactions

We use `ConfigureAwait(false)` everywhere in the library when awaiting asynchronous operations.
Normally that's fine, but if a user attempts to perform any context-sensitive work in a transaction callback,
they may be surprised that the callback is not operating in the calling context. Should this be configurable? If so, how?

## Transactions

### Snapshot handling

Are the names of `GetQuerySnapshotAsync` and `GetDocumentSnapshotAsync` appropriate? `Query` and `DocumentReference` have just `SnapshotAsync`,
but we don't want to be ambiguous in the naming within `Transaction`. Perhaps `SnapshotQueryAsync` and `SnapshotDocumentAsync`?

### Retries

The semantics of transaction retry probably need to be tweaked, including the "per-transaction" retry of the `Commit` operation.

## Query options

- Should we *attempt* to fake actual LINQ support? It would be very limited.
- Are we happy with `Query.Where(string field, QueryOperatior op, object value)`? We could have extra methods (`WhereEqual` etc)

## Testing

How can we make it easy for users to test their client code? Possible options:

- Make common interaction points virtual, to allow for mocking. (Could be awkard - while `FirestoreDb` is a natural 
  service-like class, `DocumentReference` and `CollectionReference` are less so, but interact with the service.)
- Provide a C# in-process emulator
- Provide a local server emulator

## Database selection

Currently the library assumes that the limitation on database ID to "(default)" will be lifted soon enough for it to
be worth the library having the flexibility of allowing a database ID to be specified. (All our tests do this.) If the
"single-database" limitation is going to be longer-lasting, we should force "(default)" instead.
