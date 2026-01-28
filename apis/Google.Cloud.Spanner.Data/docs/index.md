{{title}}

`Google.Cloud.Spanner.Data` is the ADO.NET provider for Cloud Spanner. It is the recommended
package for regular Cloud Spanner database access from .NET.

{{version}}

The [Google.Cloud.Spanner.Admin.Instance.V1](../../Google.Cloud.Spanner.Admin.Instance.V1/latest) package
should be used for Cloud Spanner instance administration, such as creating or deleting instances.

{{installation}}

{{auth}}

## Getting started

Operations generally follow ADO.NET conventions.
However Cloud Spanner does not support DML (eg. "INSERT INTO ..."). Therefore you should
use the corresponding API on SpannerConnection to create ADO command objects instead
of setting CommandText manually.

## Credentials

Without any other configuration, `Google.Cloud.Spanner.Data` uses
[Application Default Credentials](https://cloud.google.com/docs/authentication#adc).
If you need to provide other credentials, there are three alternatives:

- Specify `CredentialFile` in the [connection string](connection_string.md)
- Pass a `GoogleCredential` into the constructor of `SpannerConnection`
  or `SpannerConnectionStringBuilder`. Scopes will be applied automatically,
  and self-signed JWTs will be used where possible.
- Pass a `ChannelCredentials` into the constructor of `SpannerConnection`
  or `SpannerConnectionStringBuilder`.

## SpannerConnection and Dependency Injection

A `SpannerConnection` can be provided via dependency injection based
on the ConnectionStrings section of the application configuration,
via the `AddSpannerConnection` extension method. For example, 
consider an application configured with `appsettings.json` file like this:

```json
{
  "ConnectionStrings": {
    "SpannerDb": "Data Source=projects/my-project/instances/my-instance"
  }
}
```

The `SpannerConnection` can be configured on the service collection
as shown below:

{{sample:SpannerConnection.DependencyInjection}}

The dependency is registered as a transient dependency (as a new
`SpannerConnection` should be created for each request), and is
automatically disposed by the dependency injection infrastructure.

If the dependency injection container has been configured with
`ChannelCredentials` or `GoogleCredential` values, those are used
automatically by `AddSpannerConnection`. (If both are specified,
`ChannelCredentials` takes priority.) Note that this means any
`CredentialsFile` specified in the connection string is ignored when
the connection is obtained via dependency injection and a
`ChannelCredentials` or `GoogleCredential` is available from the
same container.

## Sample code

Once you have created your Google Cloud Project and Spanner Instance using the web console,
you can start using the ADO.NET provider to create and modify a Cloud Spanner database.

## Creating a Database and Table

> **Note**  
> For convenience `Google.Cloud.Spanner.Data` allows you to use standard `SpannerCommand`s
> for DDL operations. But do take into account that Spanner transactions do not support
> DDL operations, so even if you set `SpannerCommand.Transaction` on a DDL command, the command
> will execute outside the transaction.

{{sample:SpannerConnection.CreateDatabaseAsync}}

## DataAdapter support (.NET 4.5+ only)

Cloud Spanner supports a limited DataAdapter that provides basic CRUD operations on any table.
Create a SpannerDataAdapter with the target table and its primary keys.  You may replace any
commands provided by SpannerDataAdapter with your own custom commands.

{{sample:SpannerConnection.DataAdapter}}

## Modifying data

Cloud Spanner supports two approaches to modifying data: DML, and direct row modifications.

### DML

DML is capable of affecting multiple rows with a single command. For example, you could delete all
rows matching a query, or update rows to set the value of one column equal to another one.

DML can be executed in standard mode using `ExecuteNonQuery` or `ExecuteNonQueryAsync`:

{{sample:SpannerConnection.Dml}}

It is recommended that you execute DML statements within a retriable transaction.
Queries within the same transaction are able to observe the changes already made by DML statements,
and later DML statements can use the values created or updated by earlier ones.
Also, if the transaction is aborted at any point, the whole unit of work will be retried automatically. 
Note that the code executing within a retriable transaction needs to be prepared to be called more
than once.
Please read the [Cloud Spanner user documentation](https://cloud.google.com/spanner/docs/reference/rest/v1/TransactionOptions)
for details on when and why transactions can be aborted.

Some DML statements can be executed in a *partitioned* manner, enabling an efficient
update of large data sets. `ExecutePartitionedUpdate` or `ExecutePartitionedUpdateAsync`:

{{sample:SpannerConnection.PartitionedDml}}

Partitioned DML updates cannot be performed within another transaction, and have "at least once" semantics:
the update can be applied more than once to a row in some cases, and so is best used with idempotent updates.

Not all DML statements can be partitioned. Please read the Cloud Spanner user documentation for details on
the restrictions.

### Batch DML

Batch DML allows you to execute multiple DML commands in one batched operation.

{{sample:SpannerConnection.BatchDml}}

Statements are executed sequentally in the same order they are provided. Changes made by one statement are
visible to all subsequent statements in the batch.

When one of the statemens in the batch fails, execution is halted and all subsequent statements are not
executed. A `SpannerBatchNonQueryException` will be thrown that contains both information about the error
and the number of rows affected by each of the statements that executed before the failed one. If you are executing
the batch DML command inside a non-retriable transaction you can simply commit the transaction when `SpannerBatchNonQueryException`
is thrown if partial success is acceptable in your application.
It is recommended to run Batch DML within a retriable transaction. If the transaction
aborts the whole unit of work will be retried automatically.
Note that the code executing within a retriable transaction needs to be prepared to be called more
than once.
Please read the [Cloud Spanner user documentation](https://cloud.google.com/spanner/docs/reference/rest/v1/TransactionOptions)
for details on when and why transactions can be aborted.

### Direct row modifications

The following operations are supported for direct row modification:

- Insert
- Update
- Delete
- Insert or update (also known as "upsert")

Create a command from the `SpannerConnection`, providing the table name to the appropriate method
(`CreateInsertCommand` and the like), then use the command parameters to specify values for columns.
The command can be reused to perform the same kind of operation for multiple rows.

This sample inserts two rows, then reads them again:

{{sample:SpannerConnection.InsertDataAsync}}

This sample reads three keys using a `SELECT` command, updates a row using an `UPDATE` command, then
deletes a row using a `DELETE` command:

{{sample:SpannerConnection.ReadUpdateDeleteAsync}}

When direct row modifications are performed in a transaction, they are only applied when the transaction is committed.
Queries within the transaction will not observe any changes.
It is recommended to run direct row modifications within a retriable transaction. If the transaction
aborts the whole unit of work will be retried automatically.
Note that the code executing within a retriable transaction needs to be prepared to be called more
than once.
Please read the [Cloud Spanner user documentation](https://cloud.google.com/spanner/docs/reference/rest/v1/TransactionOptions)
for details on when and why transactions can be aborted.

### Automatic retry of single commands

When executing a single write command without specifying a transaction, an exclusive ephemeral transaction will be used 
internally. If the transaction is aborted the command will be retried automatically. This means that, for executing
single commands that don't need to share a transaction, you don't need to use a retriable transaction.

{{sample:SpannerConnection.EphemeralRetry}}

This applies to DML, Batch DML and direct row modifications. It does not apply to partioned DML commands as it is the
Cloud Spanner service the one that handles the transaction lifecycle for partioned DML commands, which are already
automatically retried on aborted.

### Using a commit timestamp

Spanner allows you to write a commit timestamp for insert and update
operations.

When using direct row modifications, the commit timestamp can be set
using `SpannerParameter.CommitTimestamp` as the value for a
parameter, as shown below.

{{sample:SpannerConnection.CommitTimestamp}}

This parameter value cannot be used in DML. Instead, use the
`PENDING_COMMIT_TIMESTAMP()` function in your DML statement.

See the [Cloud Spanner
documentation](https://cloud.google.com/spanner/docs/commit-timestamp)
for more information about commit timestamps.

## Transactions and Fault Handling

Cloud Spanner is fully ACID compliant.

Retries should be implemented at the transaction level (as opposed to individual call level)
because there is a chance in high stress situations that a Cloud Spanner session (transaction)
can be aborted due to causing a deadlock. In this case, the entire transaction should be
retried. The methods `SpannerConnection.RunWithRetriableTransactionAsync(...)` will take care of
automatically retrying the entire callback passed as a paremeter using a fresh transaction
if previous attempts aborted.

- The callback doesn't need to handle the transaction lifecycle.
- The callback needs to set the transaction received on all the commands it creates.
- The callback might be called more than once, so the code should be written bearing this in mind.

Please read the [Cloud Spanner user documentation](https://cloud.google.com/spanner/docs/reference/rest/v1/TransactionOptions)
for details on when and why transactions can be aborted.

{{sample:SpannerConnection.InsertDataAsync}}

## Session pool management

`Google.Cloud.Spanner.Data` manages Spanner sessions for you via a
session pool. The pool has various [configuration
options](configuration.md), but additionally you may wish to take
advantage of additional `SpannerConnection` methods at the start and
end of your application.

To ensure that the session pool is populated with the configured
minimum number of sessions before serving requests from your
application, you may wish to wait for the task returned by
`SpannerConnection.WhenSessionPoolReady()` to complete before
marking your application as "ready to serve".

{{sample:SpannerConnection.WhenSessionPoolReady}}

When your application is shutting down, you may wish to delete the
sessions it has been using from the server. Most applications will
not need to do this: sessions automatically expire after an idle
time of an hour anyway, and the server-enforced session limit is
high. Applications using a large number of sessions may wish to
clean up sessions more actively, however. Again, `SpannerConnection`
provides a simple method to accomplish this:

{{sample:SpannerConnection.ShutdownSessionPoolAsync}}

## Retrieving an RpcException from a SpannerException

The `RpcException` property of `SpannerException` returns the underlying
`RpcException` which caused the `SpannerException`. The returned 
value may be null if the `SpannerException` was not caused by an `RpcException`.

This can in turn be used to [obtain an ErrorInfo](../../../docs/devsite-help/troubleshooting.md#how-can-i-get-errorinfo-from-rpcexception) 
which can provide actionable error details. 

Sample code:

```csharp
using Google.Api.Gax.Grpc;
try
{
    // Code using Spanner. 
}
catch (SpannerException ex)
{
    if (ex.RpcException is RpcException rpcException)
    {
        if (rpcException.GetErrorInfo() is ErrorInfo errorInfo)
        {
            var domain = errorInfo.Domain;
            var reason = errorInfo.Reason;
            var metadata = errorInfo.Metadata;
            // Use the domain, reason and metadata of ErrorInfo, e.g. for logging or taking remedial action.
        }
        else
        {
            // Use RpcException's other properties (e.g. Status and Message) to handle the exception appropriately.
        }
    }
    else
    {
        // Use SpannerException's other properties (e.g. ErrorCode and Message) to handle the exception appropriately.
    }
}
```
