# User guide

## Accessing documents and collections

From `FirestoreDb`, you can create a `DocumentReference` or `CollectionReference` directly by
their path from the database root. From a `DocumentReference` you can create a `CollectionReference`
for a child collection, and likewise from a `CollectionReference` you can create a `DocumentReference`
for a child document.

[!code-cs[](obj/snippets/Google.Cloud.Firestore.UserGuide.txt#References)]

## Writing documents

See the [data model](datamodel.md) page for the different representations available. For the rest of
this section, we will use the following attributed class:

[!code-cs[](obj/snippets/Google.Cloud.Firestore.UserGuide.txt#AttributedClass)]

### Creating a document

A specific document can be created using `DocumentReference.CreateAsync`; alternatively,
`CollectionReference.AddAsync` will generate a random document ID within the associated collection.

[!code-cs[](obj/snippets/Google.Cloud.Firestore.UserGuide.txt#AddAsync)]

Once created, a document can be modified in multiple ways.

### Updating specific fields

Specific fields in the document can be modified using `DocumentReference.UpdateAsync`. Currently this
requires a `Dictionary<FieldMask, object>` to be passed in, but we intend to improve this experience.
See [further work items](furtherwork.md) for more discussion over improving this.

A precondition may be specified for the update.

[!code-cs[](obj/snippets/Google.Cloud.Firestore.UserGuide.txt#UpdateAsync)]

### Setting document data with optional merging

The `SetAsync` operation is versatile. By default it replaces all data in the document. For example, this code:

[!code-cs[](obj/snippets/Google.Cloud.Firestore.UserGuide.txt#SetAsyncOverwrite)]

... would end up wiping out setting the `State` field in the document to a null value. (`Capital` would still be `false`,
as that's the default value of the `bool` type.)

To use our class model but specify which fields we want to merge, we can specify an appropriate `SetOptions`.

[!code-cs[](obj/snippets/Google.Cloud.Firestore.UserGuide.txt#SetAsyncMergeSpecific)]

A simpler option in many cases - particularly when your document doesn't deal with nested data - is to use an anonymous
type to specify the fields you want to modify, and specify `SetOptions.MergeAll` so that all the fields you've specified
in the anonymous type are merged, but no others.

[!code-cs[](obj/snippets/Google.Cloud.Firestore.UserGuide.txt#SetAsyncMergeAll)]

### Deleting a document

Deleting a document is simple via `DocumentReference.DeleteAsync`. A precondition can be specified (for example, to only
delete the document if its last-update timestamp matches one you know); otherwise the delete operation is unconditional.

[!code-cs[](obj/snippets/Google.Cloud.Firestore.UserGuide.txt#DeleteAsync)]

All of these operations can also be performed in batches via `WriteBatch`, or within transactions.

## Reading documents

Once your data is in Firestore, you probably want to read it at some point.

### Fetching a document snapshot

`DocumentReference` allows you to fetch a snapshot of a document:

[!code-cs[](obj/snippets/Google.Cloud.Firestore.UserGuide.txt#DocumentSnapshot)]

### Querying

You can also query collections, either directly to retrieve all the data from all the documents in the collection,
or with filtering, projections, ordering etc.

[!code-cs[](obj/snippets/Google.Cloud.Firestore.UserGuide.txt#QuerySnapshot)]

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

[!code-cs[](obj/snippets/Google.Cloud.Firestore.UserGuide.txt#TransactionAsyncCallbackNoResult)]

### Updating the current counter

When we update the current counter, we may well want to know the current value afterwards. That's easily done by
returning it from the callback:

[!code-cs[](obj/snippets/Google.Cloud.Firestore.UserGuide.txt#TransactionAsyncCallbackWithResult)]