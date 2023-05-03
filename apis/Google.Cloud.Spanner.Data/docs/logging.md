# Logging

The Spanner client libraries contain a relatively rudimentary
logging mechanism for diagnostic purposes. It is not intended for
general application use, and most applications will never need to
take any of the steps shown on this page. This page is primarily
intended to make it easier for Google Cloud Platform support
engineers to help you configure your application to add logging if
you encounter an issue.

The exact log entries generated are subject to change, and
applications should not rely on particular messages.

Both the `Logger` and `LogLevel` types decribed below are in the
`Google.Cloud.Spanner.V1.Internal.Logging` namespace.

## Log levels

The `Logger.LogLevel` property determines which log events are
actually recorded. By default, this is `LogLevel.None`, so there is
no output.

If you're happy using the default logger implementation described
below, and just need to change the log level, you can write code
like this:

```csharp
// Adjust for the desired log level
Logger.DefaultLogger.LogLevel = LogLevel.Info;
```

This can be performed at any time, and the default logger will start
using the given log level.

## The default logger implementation

The default logger implementation writes to one of two places based
on the DLL being targeted:

- In the .NET Standard 1.5 DLL, it writes to `Console.Error`
- In the .NET Standard 2.0 and .NET Framework 4.5 DLLs, it calls
  [`Trace.TraceInformation`](https://docs.microsoft.com/en-us/dotnet/api/system.diagnostics.trace.traceinformation?view=netframework-4.7.2),
  regardless of the log level of the event.

The exact DLL being used will depend on multiple factors in your
application's build. As a general rule, if you're using .NET Core
2.0 or above, or any version of the .NET Framework, you'll probably
be using a DLL that uses `Trace.TraceInformation`.

## Writing a custom logger

If you need the log output in some different form, you can create
your own class deriving from `Logger`. You need to implement two
methods:

- `LogPerformanceEntries` to log performance information. If you
  aren't performing performance tests, you can use an empty
  implementation.
- `LogImpl` to log a single message with an optional exception. This
  is only called by `Logger` if the log level equals or exceeds the
  `LogLevel` of the logger, so the implementation can simply write
  the message/exception where it needs to.

Once you have implemented a logger, you'll need to configure the
Spanner library to use it. If you're using the default
`SessionPoolManager`, this is simply a matter of calling:

```csharp
// Replace with whatever your implementation is called, or
// however it is instantiated.
Logger logger = new MyCustomLogger();
Logger.SetDefaultLogger(logger);
```

This must be performed before *any* other Spanner operations, as
otherwise the default `SessionPoolManager` will be created with the
original default logger implementation.

If you are creating a new `SessionPoolManager` instance, simply pass
the logger to the `SessionPoolManager.Create` method:

```csharp
SessionPoolOptions options = new SessionPoolOptions
{
    // Custom options here
};
// Replace with whatever your implementation is called, or
// however it is instantiated.
Logger logger = new MyCustomLogger();

SessionPoolManager poolManager = SessionPoolManager.Create(options, logger);
```
