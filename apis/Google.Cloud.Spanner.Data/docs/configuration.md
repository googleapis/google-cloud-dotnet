# Configuration

Many applications will only ever need to configure Spanner in terms
of the database to connect via the connection string. (The database
name consists of a project ID, instance ID and database ID.)

Beyond that, configuration is largely for the sake of diagnostics
and performance tuning. There are two main sources for configuration:

- The connection string provided to `SpannerConnection`. Options
  here are also exposed as properties on
  `SpannerConnectionStringBuilder`
- The session pool options, as exposed via
  `Google.Cloud.Spanner.V1.SessionPoolOptions`.

The connection string options are [specified in this
document](connection_string.md). The remaining options relate to the
session pool, which handles acquiring, refreshing and evicting
sessions. Spanner sessions are relatively expensive (in terms of
time) to create, so it's important that they are handled
appropriately.

## Session pool options explained

`SessionPoolOptions` exposes the following properties:

**MaximumActiveSessions**

Default value: 400

The maximum number of sessions that can be active per database. An
active session is one that has been acquired but not yet released
back to the pool. Broadly speaking, this is equivalent to the number
of concurrent Spanner-based operations your application will be able
to perform.

Applications may wish to change this setting if they require high
levels of concurrency.

**MinimumPooledSessions**

Default value: 100

The minimum number of sessions to maintain in the pool of available
sessions, on a per-database basis. If the number of pooled sessions
falls below this number, more sessions are added automatically,
unless that would require more than the configured maximum active
session count. (Setting the minimum pool size to a larger value than
the maximum active session count has no purpose; the size will still
be bounded by the maximum active session count.)

Applications may wish to change this setting if they are likely to
encounter sudden bursts of requests, and don't wish to have to wait
for sessions to be created.

**WriteSessionsFraction**

Default value: 0.2

The session pool maintains sessions in two states:

- Without a transaction
- With a read/write transaction

The value of this setting determines how many sessions to keep in
each state. For example, with the default value of 0.2, roughly 20%
of sessions will be pooled with a read/write transaction.

When a session is acquired, if there is not one already available
with the requested transaction options, a transaction can be
requested. Using a session which was previously associated with a
read/write transaction for operations which don't use that
transaction does not affect the behavior; it just wastes the small
amount of time spent creating the transaction to start with.

Increasing this value will increase the average time taken to release a
session back to the pool, as more read/write transactions will be
acquired as part of that operation. However, acquiring sessions with
read/write transactions from the pool will then be faster.

Applications that are aware of their usage patterns ahead of time
may wish to change this setting to reduce latency. This is
particularly true for applications which only perform read-only
operations (in which case this value should be set to 0) or only
perform operations using read/write transactions (in which case this
value should be set to 1.0).

**IdleSessionRefreshDelay**

Default value: 15 minutes

After this amount of time, a session which has been idle is
refreshed automatically.

Sessions that are unused for long periods of time can be invalidated
by the server. The session pool periodically checks whether pooled
sessions need refreshing. When a session needs refreshing, the pool
just executes a simple query using that session. Sessions are
additionally checked for refresh when they are released back to the
pool. Jitter is applied to the session refresh to avoid large
numbers of sessions all being refreshed at exactly the same time.

Applications rarely need to change this setting.

**PoolEvictionDelay**

Default value: 7 days

Processes that run for extended periods may refresh sessions many
times, and the server will generally permit this indefinitely.
However, that puts a strain on server-side resource management. This
setting controls the time after which sessions are evicted. Like
refresh settings, jitter is applied so that sessions are not evicted
all at once.

Applications rarely need to change this setting.

**WaitOnResourcesExhausted**

Default value: Block

This enum value controls the behavior when an application requests a
new session despite having already acquired the maximum number of
active sessions.

The default value (`Block`) will block the pending
session acquisition operation until a session is available. This
allows an application to continue to function correctly, but with
reduced responsiveness.

The value of `Fail` will cause the pending session acquisition to
throw an exception. This is useful for spotting resource leaks, and
some applications may prefer a swift failure over a delayed response
when the application is heavily loaded.

**Timeout**

Default value: 60 seconds

The total time allowed for a network call to the Cloud Spanner
server, including retries. This setting is applied to calls to
create, refresh and delete sessions, as well as beginning
transactions.

Applications rarely need to change this setting.

**CreateSessionMaximumBatchSize**

Default value: 5

Sessions created are associated to the gRPC channel they are created on, so
all sessions created in a batch are associated to the same gRPC channel.
Batch size should be limited so as not to overload a given channel.
If the sessions needing to be created at any given time are more than this value
then multiple batches of this size or less will be created.

Applications rarely need to change this setting.

**MaximumConcurrentSessionCreates**

Default value: 50

Spanner has limits on the number of sessions that can be created
concurrently without affecting performance. The session pool uses
this setting to throttle the number of concurrent sessions batch creation
operations, across all databases.

Applications rarely need to change this setting.

**SessionLabels**

Default value: empty

`SessionLabels` is a read-only property which returns a mutable
string-to-string dictionary.

When sessions are created, they can have key/value pairs as
*labels*. These can be used diagnostically. For example, if your
applicaiton contains a number of services, each service could use a
different value for a "service" label so you could tell which
services are creating how many sessions. You could additionally have
a separate "service-instance" label for each instance of the service.

## Modifying the default SessionPoolOptions from ADO.NET

When using the ADO.NET implementation (Google.Cloud.Spanner.Data), a
`SessionPoolManager` is used to create `SessionPool` instances based
on the connection string. (Different endpoints would require
different pools, for example.) Each `SessionPoolManager` has a set
of `SessionPoolOptions` that it uses whenever it creates a new
`SessionPool`. It's easy to modify the options used by
the default `SessionPoolManager`. For example, to change the minimum
number of sessions in each session pool:

```csharp
SessionPoolManager.Default.SessionPoolOptions.MinimumPooledSessions = 100;
```

Any changes to the options should be made before the first Spanner
operation is executed. Changes to the options used by a
`SessionPool` after it has become active *may* still take effect,
but that varies by option and may change over time as an
implementation detail.

## Using a non-default SessionPoolManager

An alternative to modifying the options used by the default
`SessionPoolManager` is to create a new manager object with a new
set of options. The `SessionPoolManager` can then be set in
`SpannerConnectionStringBuilder` which is then used to build a
`SpannerConnection`. Typically, a single `SessionPoolManager` can be reused
by connections throughout the application. For example:

{{sample:SpannerConnection.CustomSessionPoolManager}}
