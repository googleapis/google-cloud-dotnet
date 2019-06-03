# Migration to Google.Cloud.Spanner.Data 2.0

Google.Cloud.Spanner.Data version 2.0 includes a number of breaking
changes compared with version 1.0. We expect that most users will
not be affected by these changes, particularly when default settings
are used. For users who are affected, this document should help you
to migrate your application to the 2.0 version of the libraries.

If you have any problems with the breaking changes and they're not
covered in this document, please [file an
issue](https://github.com/googleapis/google-cloud-dotnet/issues/new)
so we can help you further.

## Configuration changes

- `SpannerOptions` has been removed completely. See the [configuration
  guide](configuration.md) for more details, but for migration
  purposes:
  - `KeepAliveInterval` is replaced by `SessionPoolOptions.IdleSessionRefreshDelay`
  - `MaximumPooledSessions` has no direct equivalent in 2.0; once a session
  is part of the pool, it will be refreshed as necessary until it is evicted.
  - `MaximumActiveSessions` is now only present in `SessionPoolOptions`
  - `MaximumGrpcChannels` is specified in the connection string
  - `LogLevel` is controlled on a per-logger basis; this property on
    `SpannerOptions` was equivalent to changing
    `Logger.DefaultLogger.LogLevel`.
  - `PoolEvictionDelay` is now only present in `SessionPoolOptions`
  - `ResourcesExhaustedBehavior` has moved to `SessionPoolOptions`
  - `Timeout` is specified in the connection string
  - `MaximumConcurrentSessionCreates` is now only present in
    `SessionPoolOptions`
- `ClientPool` has been removed in 2.0. Its functionality has largely
  been replaced by `SessionPoolManager`. It is expected that the
  default session pool manager will be appropriate for most use cases,
  but you can associate a `SessionPoolManager` with the
  `SpannerConnectionStringBuilder` used to build a connection for more
  advanced situations.
- `ResourcesExhaustedBehavior` has moved to Google.Cloud.Spanner.V1,
  as it is now configured in `SessionPoolOptions`.
- Loggers are configured on a `SessionPoolManager` basis

## Breaking changes in connection, command and transaction types

- The `SpannerCommandTextBuilder(string)` constructor has been removed.
  The equivalent functionality is available via the static
  `SpannerCommandTextBuilder.FromCommandText` method.
- `SpannerTransaction.CommitAsync` returns a `Task<DateTime>` rather
  than a `Task<DateTime?>`. The server will always return a commit
  timestamp, so the task's result would never have been null in 1.0
  anyway. Client code should be able to use the resulting
  `Task<DateTime>` more easily in most cases.
- `SpannerConnection` and `SpannerConnectionStringBuilder` no longer
  expose `GetCredentials` method. There is no direct equivalent in 2.0;
  please file an issue if you rely on this functionality.
- `SpannerConnection.ClearPooledResourcesAsync` is replaced by
  `SpannerConnection.ShutdownSessionPoolAsync`. After this is called,
  no further sessions can be created with the associated session pool.
  If you need to control sessions in a more fine-grained way (for
  example, shutting down one session pool but then creating new
  sessions) you can associate a new `SessionPoolManager` instance with the
  `SpannerConnectionStringBuilder` used to build a connection. See
  the [configuration guide](configuration.md) for an example of this.
- `SpannerTransaction.CommitAsync` now accepts a cancellation token.
  This defaults to `CancellationToken.None`, so existing source code
  should still compile, but this is a binary-incompatible change.

## Miscellaneous breaking changes

- `SpannerDbType.StructOf` has been replaced by
  `SpannerDbType.ForStruct`, using the new `SpannerStruct` type.
- .NET Standard 1.5 is no longer supported; only .NET 4.5 and .NET Standard 2.0
  are supported targets.

## Breaking changes in Google.Cloud.Spanner.V1

Users of the ADO.NET implementation in Google.Cloud.Spanner.Data
will rarely need to directly refer to the types in
Google.Cloud.Spanner.V1, but some low-level users may wish to do so.

The previous `Google.Cloud.Spanner.V1.SessionPool` class has been
replaced by a completely new implementation, with a new API and some
changes to the corresponding `SessionPoolOptions` class. The new
`SessionPool` manages transactions as well as sessions, so the
`TransactionPool` class from 1.0 has been removed. `PooledSession`
instances are acquired from the session pool (and must be released
appropriately). These are automatically refreshed (and eventually
evicted) by the session pool.

The `ExecuteSqlStream` and `GetSqlStreamReader` methods on
`SpannerClient` have been removed, along with
`SpannerClientSettings.ExecuteSqlStreamSettings`. The
`SpannerClient.ExecuteStreamingSql` method is responsible for
executing SQL and returning the results in a stream;
the `PooledSession.ExecuteSqlStreamReader` method returns a
`ReliableStreamReader`.

`SpannerSettings.AllowImmediateTimeouts` has been removed; this is
now solely in the ADO.NET provider.

## Changes in Google.Cloud.Spanner.V1.Internal

The Google.Cloud.Spanner.V1 package exposes some types in the
Google.Cloud.Spanner.V1.Internal namespace, for use by
Google.Cloud.Spanner.Data. These types were not intended for
use by third-party code, so this document does not go into detail
around the changes in this namespace.

## Execution-time behavior changes

- Null values are returned as `DBNull.Value` by default rather
  than the CLR default value for the type. Array and struct elements
  use a null value where feasible, but throw `InvalidCastException`
  when requested to be converted to a non-nullable value type. The
  1.0 behavior can be requested using the `UseClrDefaultForNull`
  [connection string option](connection_string.md).
- `Hashtable` is no longer used as a default type for
  struct values. It can still be specified explicitly.
  The new default is `Dictionary<string, object>`.
