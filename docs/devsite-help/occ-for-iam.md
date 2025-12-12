# Optimistic Concurrency Control (OCC) Loop for IAM

## Introduction to OCC

Optimistic Concurrency Control (OCC) is a strategy used to manage shared resources and prevent "lost updates" or race conditions when multiple users or processes attempt to modify the same resource simultaneously.

In the context of Google Cloud .NET libraries, IAM Policy objects contain an `Etag` property. When calling `SetIamPolicy`, the client library includes this `Etag`. If the server detects that the `Etag` provided does not match the current version on the server, it throws an RPC exception with the status `Aborted` or `FailedPrecondition`.

## Implementing the OCC Loop

The core of the implementation is a `while` loop wrapped in a `try-catch` block handling specific gRPC exceptions.

### **Steps of the Loop**

| Step | Action | C\# Implementation |
| ----- | ----- | ----- |
| **1\. Read** | Fetch the current IAM Policy. | `await client.GetIamPolicyAsync(name)` |
| **2\. Modify** | Apply changes to the `Policy` object. | Modify `policy.Bindings` collection. |
| **3\. Write** | Attempt to set the policy. | `await client.SetIamPolicyAsync(name, policy)` |
| **4\. Retry** | Catch specific `RpcException`. | `catch (RpcException ex) when (ex.StatusCode == StatusCode.Aborted)` |

## Examples

The following example demonstrates how to implement the OCC loop using the `Google.Cloud.ResourceManager.V3` library.

[!code-cs[](../examples/help.OccForIam.txt#OccForIam)]