# Configuring Retries and Timeouts

In the Google Cloud C\# Client Libraries, configuring retry logic is managed by setting properties on the client configuration object or by explicitly passing `CallSettings` to the RPC method.

## **Global Client Configuration**

You can configure the default retry behavior for an entire client instance by modifying the client's internal configuration object during creation. This is useful for uniformly applying a specific policy across all calls made by that client.

The retry settings control the exponential backoff strategy, which determines how long the client waits between retry attempts after a recoverable failure.

[!code-cs[](../examples/help.Retries.txt#ServiceSettingsRetries)]

## **Per-Call Configuration (Recommended)**

For most use cases, it is recommended to override settings for specific, high-contention, or time-sensitive calls using `CallSettings`. This avoids changing the default behavior of the entire client.

You pass the `CallSettings` object as an optional final argument to the asynchronous method.

[!code-cs[](../examples/help.Retries.txt#CallSettingsRetries)]

## **Key RetrySettings Properties**

When constructing `RetrySettings.FromBackoff`, you can use the following parameters to fine-tune the exponential backoff strategy:

| Parameter | Type | Description |
| ----- | ----- | ----- |
| `maxAttempts` | `int` | The maximum number of retry attempts. |
| `initialDelay` | `TimeSpan` | Wait time before the first retry. |
| `delayMultiplier` | `double` | Multiplier applied to the delay after each failure (e.g., 2.0). |
| `maxDelay` | `TimeSpan` | The maximum wait time between any two retries. |
| `totalTimeout` | `TimeSpan` | Total time allowed for the request (including all retries) before giving up. |

