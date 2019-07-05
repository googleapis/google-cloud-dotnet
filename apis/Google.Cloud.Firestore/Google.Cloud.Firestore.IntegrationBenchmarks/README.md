# Firestore latency testing

This program was created to help diagnose [issue
3182](https://github.com/googleapis/google-cloud-dotnet/issues/3182), but may be useful
in the future too. It uploads many batches of documents, timing how
long it takes to commit each batch.

To run the program, simply provide a configuration file in JSON
format, with the following properties:

- `description`: A plain-text description of the run. This isn't
  used anywhere in the code, but it's stored with the run results.
- `projectId`: The ID of the Firestore project
- `collectionPrefix`: The prefix to use for the collection within Firestore.
  A run-specific date/time-based suffix is appended to this so each run has its own collection.
- `taskCount`: The number of batch-writing tasks to run
  concurrently. This isn't quite synonymous with a thread count,
  as a single thread may end up serving multiple tasks, but it *is*
  the intended degree of parallelism.
- `targetQps`: How many batch commits we try to execute per second.
- `batches`: The number of batches to write.
- `batchSize`: The number of documents in each batch.
- `dataSize`: The size of the `Data` property within each document,
  in bytes.
- `poolSize`: The number of `FirestoreDb` instances to create. These
  are used in a round-robin fashion.
- `storageBucket`: If specified as a non-null value, the test results
  are uploaded here as well as being stored locally. This can be
  useful if you want to look at a histogram as a graph but can't use
  a browser on the machine which executed the run.

When the program runs, it creates and commits one batch per
`FirestoreDb` instance (as a warm-up cycle), then starts the real
test, creating and committing batches in a number of tasks,
throttled to a target QPS. Progress is reported (in terms of the
number of batches still to be created) each second.

At the end of the run:

- Summary information is written to the console
- Run information (configuration, start/end time, actual QPS) and
  results (as a histogram) are written to local files.
- If a storage bucket is specified in the configuration, upload
  the same files there.

The histogram files are created by
[HdtHistogram.NET](https://github.com/HdrHistogram/HdrHistogram.NET),
and can be uploaded to an [online
tool](http://hdrhistogram.github.io/HdrHistogram/plotFiles.html) to
plot a graph.
