{{title}}

`Google.Cloud.BuiltInMetrics` collects built-in metrics from Google Cloud client libraries and exports them
over OTLP to [Cloud Monitoring](https://cloud.google.com/monitoring/docs) (`telemetry.googleapis.com`). It supports
these client libraries:

- `Google.Cloud.Spanner.V1` (including `Google.Cloud.Spanner.Data`, which uses `Google.Cloud.Spanner.V1`)

{{version}}

{{installation}}

{{auth}}

The credential must have permission to write metrics in each project that the client libraries use (for example,
the `roles/monitoring.metricWriter` IAM role). If the credential requires scopes, this library applies the
`https://www.googleapis.com/auth/monitoring.write` scope to it.

## Getting started

Call `BuiltInMetrics.EnableAsync` one time when the application starts, and keep the returned handle.
Dispose the handle when the application shuts down. Disposing the handle exports the final metrics. If the
application exits without disposing the handle, it may lose up to 60 seconds of data.

```csharp
using Google.Cloud.BuiltInMetrics;
...
using (await BuiltInMetrics.EnableAsync())
{
    // Run the application. Spanner clients record built-in metrics, and this library exports them.
}
```

To use a credential other than Application Default Credentials, set `BuiltInMetricsOptions.GoogleCredential`:

```csharp
var options = new BuiltInMetricsOptions { GoogleCredential = credential };
using (await BuiltInMetrics.EnableAsync(options))
{
    // ...
}
```

## Handles

Each call to `EnableAsync` returns a new handle, and all active handles share one export pipeline.
Disposing the last handle stops the pipeline and exports the final metrics.

`EnableAsync` never throws. It returns a no-op handle in these cases:

- The library cannot get a credential (for example, no Application Default Credentials exist).
- The caller cancels the cancellation token.
- A pipeline already runs with a different `GoogleCredential` instance.
- `OTEL_SDK_DISABLED` is `true`.
- `OTEL_DOTNET_EXPERIMENTAL_OTLP_RETRY` has a value that is not valid.

Environment variables for endpoint, headers, compression, temporality, export interval, resource attributes, and
exemplars do not change the built-in metrics pipeline.

## Resource usage

The library makes one OpenTelemetry meter provider for each monitored resource. For Spanner, a monitored
resource is one client (`client_hash`) for each project, instance and location. The `client_hash` label
has 10 bits, so the library keeps at most 1024 meter providers for each project, instance and location.
Each meter provider sends one export request each minute. The library removes a meter provider that
records no data for 2 export intervals.

The internal meters have the names `BuiltInMetrics.Pool#n`. If the application's own OpenTelemetry setup
calls `AddMeter("*")`, it also collects these meters.

## Dependencies

On netstandard2.0 and net462, OpenTelemetry 1.17.0 depends on version 10.0.0 of the
`Microsoft.Extensions.*` packages (for example `Microsoft.Extensions.Logging.Abstractions`). So an
application on .NET Framework, or on a .NET version before .NET 8, also gets version 10.0.0 or later of
these packages.
