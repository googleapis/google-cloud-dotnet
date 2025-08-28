# Version history

## Version 1.0.0-alpha06, released 2025-08-28

### New features

- Added RequestOrderDateChange RPC - allows Customers to request date changes
- Added CancelOrder RPC - allows Customers to request cancellation
- Exposed Order-level output-only fields for transparency

### Documentation improvements

- `fulfillment_time` marked as deprecated

## Version 1.0.0-alpha05, released 2025-04-23

### New features

- Accept status updates in the SignalZoneState method ([commit 7e53181](https://github.com/googleapis/google-cloud-dotnet/commit/7e5318134552ebc36ee215f64aabe7b3804a8c1e))
- Expose the allowed hardware count for each SKU ([commit 7e53181](https://github.com/googleapis/google-cloud-dotnet/commit/7e5318134552ebc36ee215f64aabe7b3804a8c1e))
- Add deployment type and installation dates to orders ([commit 7e53181](https://github.com/googleapis/google-cloud-dotnet/commit/7e5318134552ebc36ee215f64aabe7b3804a8c1e))

### Documentation improvements

- Make billing_id an output-only field ([commit 7e53181](https://github.com/googleapis/google-cloud-dotnet/commit/7e5318134552ebc36ee215f64aabe7b3804a8c1e))

## Version 1.0.0-alpha04, released 2024-11-18

### New features

- Add DNS address, Kubernetes primary VLAN ID, and provisioning state to the Zone resource ([commit 9180676](https://github.com/googleapis/google-cloud-dotnet/commit/918067697f16a57916593566858e5bac33709c10))
- Add MAC address-associated IP address to the Hardware resource ([commit 9180676](https://github.com/googleapis/google-cloud-dotnet/commit/918067697f16a57916593566858e5bac33709c10))
- Add provisioning_state_signal field in SignalZoneState method request ([commit 9180676](https://github.com/googleapis/google-cloud-dotnet/commit/918067697f16a57916593566858e5bac33709c10))

### Documentation improvements

- Change state_signal field in SignalZoneState method request as optional ([commit 9180676](https://github.com/googleapis/google-cloud-dotnet/commit/918067697f16a57916593566858e5bac33709c10))

## Version 1.0.0-alpha03, released 2024-10-29

### New features

- Add a DeleteSite method ([commit 546e30b](https://github.com/googleapis/google-cloud-dotnet/commit/546e30b7a257eea06f08b9abcadd62117ad6d304))
- Add MAC address and disk info to the Hardware resource ([commit 546e30b](https://github.com/googleapis/google-cloud-dotnet/commit/546e30b7a257eea06f08b9abcadd62117ad6d304))

### Documentation improvements

- Annotate rack_location field as required; this was always enforced ([commit 546e30b](https://github.com/googleapis/google-cloud-dotnet/commit/546e30b7a257eea06f08b9abcadd62117ad6d304))

## Version 1.0.0-alpha02, released 2024-09-26

### New features

- Add an order type field to distinguish a fulfillment request from a sales inquiry ([commit 0a66c68](https://github.com/googleapis/google-cloud-dotnet/commit/0a66c68ce14f9baaba295bfc06a624be78729bc7))
- Add support to mark comments as read or unread ([commit 0a66c68](https://github.com/googleapis/google-cloud-dotnet/commit/0a66c68ce14f9baaba295bfc06a624be78729bc7))
- Rename zone state signal READY_FOR_SITE_TURNUP to FACTORY_TURNUP_CHECKS_PASSED ([commit 0a66c68](https://github.com/googleapis/google-cloud-dotnet/commit/0a66c68ce14f9baaba295bfc06a624be78729bc7))

### Documentation improvements

- Clarify how access_times are used ([commit 0a66c68](https://github.com/googleapis/google-cloud-dotnet/commit/0a66c68ce14f9baaba295bfc06a624be78729bc7))

## Version 1.0.0-alpha01, released 2024-06-26

Initial release.


