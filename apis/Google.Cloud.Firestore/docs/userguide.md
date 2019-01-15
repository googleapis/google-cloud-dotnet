# User guide

## Accessing documents and collections

From `FirestoreDb`, you can create a `DocumentReference` or `CollectionReference` directly by
their path from the database root. From a `DocumentReference` you can create a `CollectionReference`
for a child collection, and likewise from a `CollectionReference` you can create a `DocumentReference`
for a child document.

{{sample:UserGuide.References}}

## Writing documents

See the [data model](datamodel.md) page for the different representations available. For the rest of
this section, we will use the following attributed class:

{{sample:UserGuide.AttributedClass}}

### Creating a document

A specific document can be created using `DocumentReference.CreateAsync`; alternatively,
`CollectionReference.AddAsync` will generate a random document ID within the associated collection.

{{sample:UserGuide.AddAsync}}

Once created, a document can be modified in multiple ways.

### Updating specific fields

Specific fields in the document can be modified using
`DocumentReference.UpdateAsync`. Single fields can be updated by
passing in the field name and the new value; to update multiple
fields, pass in a dictionary mapping each field name to its new value.

A precondition may be specified for the update.

{{sample:UserGuide.UpdateAsync}}

### Setting document data with optional merging

The `SetAsync` operation is versatile. By default it replaces all data in the document. For example, this code:

{{sample:UserGuide.SetAsyncOverwrite}}

... would end up wiping out setting the `State` field in the document to a null value. (`Capital` would still be `false`,
as that's the default value of the `bool` type.)

To use our class model but specify which fields we want to merge, we can specify an appropriate `SetOptions`.

{{sample:UserGuide.SetAsyncMergeSpecific}}

A simpler option in many cases - particularly when your document doesn't deal with nested data - is to use an anonymous
type to specify the fields you want to modify, and specify `SetOptions.MergeAll` so that all the fields you've specified
in the anonymous type are merged, but no others.

{{sample:UserGuide.SetAsyncMergeAll}}

### Deleting a document

Deleting a document is simple via `DocumentReference.DeleteAsync`. A precondition can be specified (for example, to only
delete the document if its last-update timestamp matches one you know); otherwise the delete operation is unconditional.

{{sample:UserGuide.DeleteAsync}}

All of these operations can also be performed in batches via `WriteBatch`, or within transactions.

## Reading documents

Once your data is in Firestore, you probably want to read it at some point.

### Fetching a document snapshot

`DocumentReference` allows you to fetch a snapshot of a document:

{{sample:UserGuide.DocumentSnapshot}}

### Querying

You can also query collections, either directly to retrieve all the data from all the documents in the collection,
or with filtering, projections, ordering etc.

{{sample:UserGuide.QuerySnapshot}}

## Transactions

Transactions accept a callback of user code, which is then passed a `Transaction` object
to work with.

The callback can return optionally a value.

The callback will be executed multiple times if the transaction needs to be retried due to conflicting
modifications.

In this section, we'll deal with a simple document that just has a single counter. We want to keep an up-to-date counter,
and periodically (once per day, for example) we'll update another counter to match the current value. For more
details of counters, see the [main Firestore user guide](https://firebase.google.com/docs/firestore/solutions/counters).

### Updating the daily counter from the current one

Once a day, we want to atomically fetch the current counter, and update the daily one.

{{sample:UserGuide.TransactionAsyncCallbackNoResult}}

### Updating the current counter

When we update the current counter, we may well want to know the current value afterwards. That's easily done by
returning it from the callback:

{{sample:UserGuide.TransactionAsyncCallbackWithResult}}

## Listening for changes

Firestore allows you to listen for changes to either a single
document or the results of a query. You provide a callback which is
executed each time a change occurs.

First we'll see an example of each, then go into details.

### Listening for changes on a document

This example starts listening for changes on a document that doesn't
exist yet, then creates the document, updates it, deletes it, and recreates it.
Each of these changes is logged by the callback.
After stopping the listening operation, the document is updated one
final time - which doesn't produce any output.

{{sample:UserGuide.ListenDocument}}

### Listening for changes in a query

This example listens for changes in a query of "documents with a
score greater than 5, in descending score order". Each document has
two fields: "Name" and "Score".

When the listener is set up, the test makes the following data changes:

- Add a document for Sophie, with score 7
- Add a document for James, with score 10
- Update the score for Sophie to 11 (changing its order within the query)
- Update the score for Sophie to 12 (no change in order, but the document is updated)
- Update the score for James to 4 (no longer matches the query)
- Delete the document for Sophie

{{sample:UserGuide.ListenQuery}}

### Listener threading

Each listener you start runs independently. It effectively loops
through three steps:

- Wait for the server to provide changes
- Update its internal model
- Report any changes via the callback

The listener waits for the callback to complete before continuing.
The callbacks can be provided as either a synchronous action or an
asynchronous function that returns a task. For asynchronous
callbacks, the listener waits for the returned task to complete.
This allows you to use async/await within a callback without
worrying about the callback executing multiple times concurrently
for a single listener.

Each listener acts independently without any synchronization, so if
you use the same callback for multiple listeners, the callback could
be called multiple times concurrently, one for each listener.

Although each listener "logically" operates in a single-threaded
fashion, it uses asynchronous operations and so the actual thread
used can change between callbacks. We strongly recommend against
using thread-local storage; ideally, make no assumptions about the
thread that will run your callback.

### Stopping listeners

When you start listening for changes, the method returns a
`FirestoreChangeListener`. This has two important members:

- The `ListenerTask` property returns a task representing the
  ongoing listen operation.
- The `StopAsync` method allows you to stop the listener. For
  convenience, this returns the same task as `ListenerTask`.

The `StopAsync` method will allow any currently executing callback
to complete before the listener shuts down. However, both the
original `Listen` calls and the `StopAsync` methods accept an optional
`CancellationToken`. If this cancellation token is cancelled, not
only will the listener stop, but the cancellation token passed to
any asynchronous callback will also be cancelled. This allows you to
perform asynchronous operations within the callback but still be
able to cancel the whole listener quickly.

In the "graceful" shutdown case, nothing is cancelled: you call
`StopAsync`, any current callback completes, and then the listener
task completes. If this is all you need, you never need to provide a
cancellation token to the methods to start or stop listening.
The cancellation token functionality has been provided for two
specific scenarios:

- The listen operation is being executed as part of another
  cancellable operation. In this case you'd provide the cancellation
  token when you start listening.

- The listen operation is long-running, but you need to shut it down
  as part of shutting down some larger system (such as a web
  server). Typically this shutdown procedure provides a cancellation
  token: if the graceful shutdown doesn't complete within a certain
  time, the cancellation token is cancelled. The signature of
  `StopAsync` allows you to integrate Firestore into this pattern
  easily.

The final status of the listener task will be:

- `RanToCompletion` if shutdown completed gracefully.
- `Faulted` if either the listener encountered a permanent error, or
  the callback threw an exception.
- `Canceled` if shutdown was either caused by the "start" cancellation
  token being canceled, or if the "stop" cancellation token was
  canceled.
