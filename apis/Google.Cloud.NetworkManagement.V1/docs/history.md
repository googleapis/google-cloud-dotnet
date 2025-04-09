# Version history

## Version 2.14.0, released 2025-04-09

### New features

- add messages and fields related to Direct VPC Egress
- add messages and fields related to Serverless External
- add messages and fields related to Route
- add enum types related to Firewall
- add enum types related to Google Service
- add enum types related to Abort
- add enum types related to Drop

### Documentation improvements

- update outdated comments
- Update comments for Connectivity Test

## Version 2.13.0, released 2025-01-13

### New features

- Expose the new v1 vpcflowlogs api proto ([commit 31f0b69](https://github.com/googleapis/google-cloud-dotnet/commit/31f0b691ec321fafc065d17e5b69b6b9a64d004e))

## Version 2.12.0, released 2024-11-18

### New features

- Add round-trip mode ([commit 7f285c1](https://github.com/googleapis/google-cloud-dotnet/commit/7f285c165cb943640033385786f9e8f02476e2a9))
- Add DNS endpoint of Google Kubernetes Engine cluster control plane ([commit 14d1507](https://github.com/googleapis/google-cloud-dotnet/commit/14d150726ba94347602efaa9db115f1da1228aa2))
- Add more detailed drop causes to corresponding enum ([commit 14d1507](https://github.com/googleapis/google-cloud-dotnet/commit/14d150726ba94347602efaa9db115f1da1228aa2))

### Documentation improvements

- Update outdated comments ([commit 14d1507](https://github.com/googleapis/google-cloud-dotnet/commit/14d150726ba94347602efaa9db115f1da1228aa2))

## Version 2.11.0, released 2024-10-21

### New features

- Add messages and fields related to Redis Instances ([commit 7cef758](https://github.com/googleapis/google-cloud-dotnet/commit/7cef758e38e4dea06b85110575bb6f4e6707be18))
- Add messages and fields related to Redis Clusters ([commit 7cef758](https://github.com/googleapis/google-cloud-dotnet/commit/7cef758e38e4dea06b85110575bb6f4e6707be18))
- Add PSC network attachment URI to the InstanceInfo proto ([commit 7cef758](https://github.com/googleapis/google-cloud-dotnet/commit/7cef758e38e4dea06b85110575bb6f4e6707be18))
- Add subnet URI and region name to the NetworkInfo proto ([commit 7cef758](https://github.com/googleapis/google-cloud-dotnet/commit/7cef758e38e4dea06b85110575bb6f4e6707be18))
- Add firewall policy URI to the FirewallInfo proto ([commit 7cef758](https://github.com/googleapis/google-cloud-dotnet/commit/7cef758e38e4dea06b85110575bb6f4e6707be18))
- Add fields related to advertised routes to the RouteInfo proto ([commit 7cef758](https://github.com/googleapis/google-cloud-dotnet/commit/7cef758e38e4dea06b85110575bb6f4e6707be18))
- Add region name field to the RouteInfo proto ([commit 7cef758](https://github.com/googleapis/google-cloud-dotnet/commit/7cef758e38e4dea06b85110575bb6f4e6707be18))
- Add region name to the ForwardingRuleInfo proto ([commit 7cef758](https://github.com/googleapis/google-cloud-dotnet/commit/7cef758e38e4dea06b85110575bb6f4e6707be18))
- Add load balancer name to the ForwardingRuleInfo proto ([commit 7cef758](https://github.com/googleapis/google-cloud-dotnet/commit/7cef758e38e4dea06b85110575bb6f4e6707be18))
- Add PSC target fields to the ForwardingRuleInfo proto ([commit 7cef758](https://github.com/googleapis/google-cloud-dotnet/commit/7cef758e38e4dea06b85110575bb6f4e6707be18))
- Add more detailed abort and drop causes to corresponding enums ([commit 7cef758](https://github.com/googleapis/google-cloud-dotnet/commit/7cef758e38e4dea06b85110575bb6f4e6707be18))

### Documentation improvements

- Update outdated comments in the FirewallInfo proto ([commit 7cef758](https://github.com/googleapis/google-cloud-dotnet/commit/7cef758e38e4dea06b85110575bb6f4e6707be18))

## Version 2.10.0, released 2024-05-14

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 2.9.0, released 2024-03-28

### New features

- Add an "unsupported" type of firewall policy rule ([commit d388abc](https://github.com/googleapis/google-cloud-dotnet/commit/d388abcac50e05f4baba9c436cedb0e11879ebcf))

### Documentation improvements

- Update possible firewall rule actions comment ([commit 1538880](https://github.com/googleapis/google-cloud-dotnet/commit/15388808e4c683b6fbe0c201e92562221cfae219))

## Version 2.8.0, released 2024-03-26

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))
- Add new fields and enum values related to round-trip ([commit 9570290](https://github.com/googleapis/google-cloud-dotnet/commit/95702900d2f99bbfb4ebf393f2e54b6b99054563))

### Documentation improvements

- Update a few outdated comments ([commit 9570290](https://github.com/googleapis/google-cloud-dotnet/commit/95702900d2f99bbfb4ebf393f2e54b6b99054563))
- Update comments for fields related to load balancing ([commit 0172996](https://github.com/googleapis/google-cloud-dotnet/commit/017299691b681ee74da40ad277492c6cab41fbd8))

## Version 2.7.0, released 2024-03-21

### New features

- Add new enum values related to Google services ([commit b0981d5](https://github.com/googleapis/google-cloud-dotnet/commit/b0981d53d5e43a1c16f391bf175981a2478fe05d))
- Add new final state fields to Network Management API version v1 ([commit ce12129](https://github.com/googleapis/google-cloud-dotnet/commit/ce121296f5c2a5691ed39cb354f3f5ffd22b62e8))
- Add Location & IAM mixins ([commit 7ae5fe0](https://github.com/googleapis/google-cloud-dotnet/commit/7ae5fe0175b0bfbae93d81039d3de0e6674a767f))
- Add new NAT fields to Network Management API definition ([commit 3066235](https://github.com/googleapis/google-cloud-dotnet/commit/3066235b3cd11c24bbdaf6f99cc5b73197e01067))
- Add new load balancer fields to public API ([commit 9bb5f5a](https://github.com/googleapis/google-cloud-dotnet/commit/9bb5f5aebfe99dbdcfc837ea49239c1fd20eff7e))

### Documentation improvements

- Update final state comments in Network Management API version v1 ([commit ce12129](https://github.com/googleapis/google-cloud-dotnet/commit/ce121296f5c2a5691ed39cb354f3f5ffd22b62e8))
## Version 2.6.0, released 2024-02-28

No API surface changes; just dependency updates.

## Version 2.5.0, released 2023-08-16

### New features

- Add new enum values for network firewall policies to API ([commit afe1ef0](https://github.com/googleapis/google-cloud-dotnet/commit/afe1ef01835f2cf1013235530e6bdb17f1a50cc7))
- Add fields related to Google services to API ([commit d9335c6](https://github.com/googleapis/google-cloud-dotnet/commit/d9335c6b61c775c2a02f5fbd198a65a3d2466f4e))
- Add fields related to PBR and NCC routes to API ([commit 6aeae60](https://github.com/googleapis/google-cloud-dotnet/commit/6aeae60337721dcd53545c3a03ba884d2cb3e25e))
- Add new abort and drop causes to API ([commit 193519f](https://github.com/googleapis/google-cloud-dotnet/commit/193519f300eb174a6e6ba10a3581e0752c29d7d3))
- Add fields related to load balancers to API ([commit 41b656d](https://github.com/googleapis/google-cloud-dotnet/commit/41b656d83ed1fee5688871111bb6e7b828552f4b))
- Add dynamic probing fields to v1 API ([commit a9b44ac](https://github.com/googleapis/google-cloud-dotnet/commit/a9b44acc0e99e478e601a754ebffef4036697c3a))
## Version 2.4.0, released 2023-06-27

### New features

- Add forwarding_rule field to Connectivity Test Endpoint proto ([commit 73e23cb](https://github.com/googleapis/google-cloud-dotnet/commit/73e23cbd9816fb4b1f1d4ede8d011f9393974225))

### Documentation improvements

- Update comments in Connectivity Test protos ([commit 874831c](https://github.com/googleapis/google-cloud-dotnet/commit/874831c081fd3f713e108d9ec3835f9f5dfa7cf9))

## Version 2.3.0, released 2023-01-18

### New features

- Enable REST transport in C# ([commit 0f8560c](https://github.com/googleapis/google-cloud-dotnet/commit/0f8560c840725bf41bc060c8beecafc7d99f38eb))

## Version 2.2.0, released 2022-07-25

### New features

- Add new abort cause and new route next hop type ([commit 315900f](https://github.com/googleapis/google-cloud-dotnet/commit/315900f5725c85be5c1279cc6f40e6f28d8d3297))

## Version 2.1.0, released 2022-07-11

### New features

- Introduce a projects_missing_permissions field in the AbortInfo structure ([commit 6f1a4bd](https://github.com/googleapis/google-cloud-dotnet/commit/6f1a4bdf27f364ce96cb71954926e5ce0dc01e00))

## Version 2.0.0, released 2022-06-08

This is the first version of this package to depend on GAX v4.

There are some breaking changes, both in GAX v4 and in the generated
code. The changes that aren't specific to any given API are [described in the Google Cloud
documentation](https://cloud.google.com/dotnet/docs/reference/help/breaking-gax4).
We don't anticipate any changes to most customer code, but please [file a
GitHub issue](https://github.com/googleapis/google-cloud-dotnet/issues/new/choose)
if you run into problems.

The most important change in this release is the use of the Grpc.Net.Client package
for gRPC communication, instead of Grpc.Core. When using .NET Core 3.1 or .NET 5.0+
this should lead to a smaller installation footprint and greater compatibility (e.g.
with Apple M1 chips). Any significant change in a core component comes with the risk
of incompatibility, however - so again, please let us know if you encounter any
issues.


## Version 1.1.0, released 2021-08-31

- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs

## Version 1.0.0, released 2021-08-05

No API surface changes; just promotion to GA.

## Version 1.0.0-beta01, released 2021-07-05

Initial release.
