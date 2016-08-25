# BigQuery API design

The `Google.Bigquery.V2` package wraps a lot of the functionality of
the underlying REST API. This document lays out the patterns
involved to help guide further API extensions.

## Status

This package is effectively experimental at this time. Some
functionality is missing, and a lot is likely to change. Big ticket
work items:

- Review query approach, exposing more information and being more
  consistent
- Alternative approaches for providing data and schema, e.g. simple property
  binding. (Note: we're not trying to become an ORM...)
- Async operations. (API design is progressing with sync-only
  operations; asynchrony will be added when we're done with that
  first pass.)

## `BigqueryClient`

Like other API wrappers, `BigqueryClient` is the entry point for
everything. This is an abstract class (to allow for mocking) with
`Create`/`CreateAsync` static methods which construct instances of
`BigqueryClientImpl`. The implementation can be constructed directly
if necessary, e.g. for constructor-based dependency injection.

Methods which need to interact with the service should be declared
and documented in `BigqueryClient`, as virtual methods which throw
`NotImplementedException`. They are then implemented in
`BigqueryClientImpl`.

The canonical way of identifying any of the entities is via a *reference*,
e.g. `DatasetReference`, `JobReference`, `TableReference`,
`ProjectReference`. It is easy to construct a reference either manually or via
`BigqueryClient` or a parent entity (e.g.
`BigqueryDataset.GetTableReference`).

Any operation on `BigqueryClient` must *at least* have a
canonical form accepting a suitable reference. It *may* also have
other overloads to retrieve entities via just component IDs. The
overloads must be virtual to support simple mocking, but should not
be overridden in the implementation. The documentation must be clear
that the overloads simply delegate to the canonical form using a
`*Reference` constructed with a `Get*Reference` method.

The `Get*Reference` methods in `BigqueryClient` are not virtual;
they are not a point of interaction with the service and so do not
require faking for test purposes.

`BigqueryClient` requires a project ID to be specified, as almost
all Bigquery operations require a project ID, and almost all
operations will use the same one. The project ID is typically used
as an invisible default, but it is still possible to query a
dataset/table/job in a different project.

## Datasets, tables and results

All the relevant operations are available on `BigqueryClient`, but
many are more conveniently placed on other classes representing
entities:

- `BigqueryDataset`: a dataset containing tables
- `BigqueryTable`: a table

Additionally, `BigqueryResult` represents the result of a query.

The `Bigquery` prefix here avoids confusion with the underlying
REST-based resources, which are still available.

## Synchronous vs asynchronous C# calls

All API calls potentially involving server interaction come in sync
and async flavours. (Or at least, they will do...)
