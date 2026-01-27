# Optimistic Concurrency Control (OCC)

## Introduction to OCC

Optimistic Concurrency Control (OCC) is a strategy used to manage shared resources and prevent "lost updates" or race conditions when multiple users or processes attempt to modify the same resource simultaneously.

Google API resources contain an `Etag` property used by the server to control for optimistic concurrency. If the `Etag` value provided when modifying a resource does not match the current value on the server, it returns an error, usually with status `Aborted` (Check the documentation of the API you are using for specific OCC error codes).

## **OCC Steps** demonstrated with IAM

### Example

The following example demonstrates how to implement OCC with IAM and the `Google.Cloud.ResourceManager.V3` library.

[!code-cs[](../examples/help.OccForIam.txt#OccForIam)]
