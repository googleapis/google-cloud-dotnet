# Version history

## Version 1.3.0, released 2025-07-09

### New features

- Add isolation support to prevent cross-region overflow by adding a new field "isolation_config" to message "ServiceLbPolicy"

## Version 1.2.0, released 2025-06-25

### New features

- Add support for WasmPlugin resource in NetworkServices API

### Documentation improvements

- A comment for enum `LoadBalancingScheme` is changed
- A comment for field `authority` in message `.google.cloud.networkservices.v1.ExtensionChain` is changed
- A comment for field `service` in message `.google.cloud.networkservices.v1.ExtensionChain` is changed
- A comment for field `supported_events` in message `.google.cloud.networkservices.v1.ExtensionChain` is changed
- A comment for field `timeout` in message `.google.cloud.networkservices.v1.ExtensionChain` is changed
- A comment for field `extensions` in message `.google.cloud.networkservices.v1.ExtensionChain` is changed
- A comment for field `forwarding_rules` in message `.google.cloud.networkservices.v1.LbTrafficExtension` is changed
- A comment for field `load_balancing_scheme` in message `.google.cloud.networkservices.v1.LbTrafficExtension` is changed
- A comment for field `metadata` in message `.google.cloud.networkservices.v1.LbTrafficExtension` is changed
- A comment for field `parent` in message `.google.cloud.networkservices.v1.ListLbTrafficExtensionsRequest` is changed
- A comment for field `order_by` in message `.google.cloud.networkservices.v1.ListLbTrafficExtensionsRequest` is changed
- A comment for field `request_id` in message `.google.cloud.networkservices.v1.CreateLbTrafficExtensionRequest` is changed
- A comment for field `update_mask` in message `.google.cloud.networkservices.v1.UpdateLbTrafficExtensionRequest` is changed
- A comment for field `request_id` in message `.google.cloud.networkservices.v1.UpdateLbTrafficExtensionRequest` is changed
- A comment for field `request_id` in message `.google.cloud.networkservices.v1.DeleteLbTrafficExtensionRequest` is changed
- A comment for field `forwarding_rules` in message `.google.cloud.networkservices.v1.LbRouteExtension` is changed
- A comment for field `load_balancing_scheme` in message `.google.cloud.networkservices.v1.LbRouteExtension` is changed
- A comment for field `metadata` in message `.google.cloud.networkservices.v1.LbRouteExtension` is changed
- A comment for field `parent` in message `.google.cloud.networkservices.v1.ListLbRouteExtensionsRequest` is changed
- A comment for field `order_by` in message `.google.cloud.networkservices.v1.ListLbRouteExtensionsRequest` is changed
- A comment for field `request_id` in message `.google.cloud.networkservices.v1.CreateLbRouteExtensionRequest` is changed
- A comment for field `update_mask` in message `.google.cloud.networkservices.v1.UpdateLbRouteExtensionRequest` is changed
- A comment for field `request_id` in message `.google.cloud.networkservices.v1.UpdateLbRouteExtensionRequest` is changed
- A comment for field `request_id` in message `.google.cloud.networkservices.v1.DeleteLbRouteExtensionRequest` is changed

## Version 1.1.0, released 2025-06-13

### New features

- Update NetworkServices protos

### Documentation improvements

- A comment for field `metadata_label_match_criteria` in message `.google.cloud.networkservices.v1.EndpointMatcher` is changed
- A comment for field `name` in message `.google.cloud.networkservices.v1.EndpointPolicy` is changed
- A comment for field `name` in message `.google.cloud.networkservices.v1.Gateway` is changed
- A comment for field `ports` in message `.google.cloud.networkservices.v1.Gateway` is changed
- A comment for field `scope` in message `.google.cloud.networkservices.v1.Gateway` is changed
- A comment for message `GrpcRoute` is changed
- A comment for field `fault_injection_policy` in message `.google.cloud.networkservices.v1.GrpcRoute` is changed
- A comment for field `name` in message `.google.cloud.networkservices.v1.GrpcRoute` is changed
- A comment for message `HttpRoute` is changed
- A comment for field `name` in message `.google.cloud.networkservices.v1.HttpRoute` is changed
- A comment for field `name` in message `.google.cloud.networkservices.v1.Mesh` is changed
- A comment for message `ServiceBinding` is changed
- A comment for field `name` in message `.google.cloud.networkservices.v1.ServiceBinding` is changed
- A comment for field `service` in message `.google.cloud.networkservices.v1.ServiceBinding` is changed
- A comment for field `parent` in message `.google.cloud.networkservices.v1.ListServiceBindingsRequest` is changed
- A comment for field `name` in message `.google.cloud.networkservices.v1.GetServiceBindingRequest` is changed
- A comment for field `parent` in message `.google.cloud.networkservices.v1.CreateServiceBindingRequest` is changed
- A comment for field `name` in message `.google.cloud.networkservices.v1.DeleteServiceBindingRequest` is changed
- A comment for field `address` in message `.google.cloud.networkservices.v1.TcpRoute` is changed
- A comment for field `name` in message `.google.cloud.networkservices.v1.TcpRoute` is changed
- A comment for message `TlsRoute` is changed
- A comment for field `matches` in message `.google.cloud.networkservices.v1.TlsRoute` is changed
- A comment for field `sni_host` in message `.google.cloud.networkservices.v1.TlsRoute` is changed
- A comment for field `weight` in message `.google.cloud.networkservices.v1.TlsRoute` is changed
- A comment for field `name` in message `.google.cloud.networkservices.v1.TlsRoute` is changed

## Version 1.0.0, released 2024-12-05

No API surface changes; just dependency updates and promotion to GA.

## Version 1.0.0-beta01, released 2024-06-19

Initial release.
