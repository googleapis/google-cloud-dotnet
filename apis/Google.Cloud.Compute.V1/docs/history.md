# Version history

## Version 3.14.0, released 2025-08-28

### New features

- Update Compute Engine v1 API to revision 20250807

## Version 3.13.0, released 2025-08-08

### New features

- Update Compute Engine v1 API to revision 20250729 (#1085)
- Update Compute Engine v1 API to revision 20250728 (#1081)

## Version 3.12.0, released 2025-08-04

### New features

- Update Compute Engine v1 API to revision 20250717 (#1074)

## Version 3.11.0, released 2025-07-22

### New features

- Update Compute Engine v1 API to revision 20250708 (#1073)

## Version 3.10.0, released 2025-07-09

### New features

- Update Compute Engine v1 API to revision 20250626
- Update Compute Engine v1 API to revision 20250511 (#1047)
- Update Compute Engine v1 API to revision 20250601 (#1052)

## Version 3.9.0, released 2025-04-23

### New features

- Update Compute Engine API to revision 20250415 ([commit e91d81f](https://github.com/googleapis/google-cloud-dotnet/commit/e91d81fa071d24323bb24b8eb939e8b0193da2ad))

## Version 3.8.0, released 2025-03-31

### New features

- Update Compute Engine API to revision 20250320 ([commit a14bc1e](https://github.com/googleapis/google-cloud-dotnet/commit/a14bc1ed164e80c0746775ae88ff68e2baeafd59))

## Version 3.7.0, released 2025-03-24

### New features

- Update Compute Engine API to revision 20250302 ([issue 995](https://github.com/googleapis/google-cloud-dotnet/issues/995)) ([commit 6330140](https://github.com/googleapis/google-cloud-dotnet/commit/633014022be4611d3dab03c5f44da62450ee563a))

## Version 3.6.0, released 2025-03-17

### New features

- Update Compute Engine API to revision 20250302 ([issue 987](https://github.com/googleapis/google-cloud-dotnet/issues/987)) ([commit 1d02a02](https://github.com/googleapis/google-cloud-dotnet/commit/1d02a02997a46cad706464fd9e738e8fa8d76f3c))

## Version 3.5.0, released 2025-02-25

### New features

- Update Compute Engine API to revision 20250211 ([commit 9a5de4b](https://github.com/googleapis/google-cloud-dotnet/commit/9a5de4b82c574eba3146d3a629fb70b58398c276))
- Update Compute Engine API to revision 20250126 ([commit c7842e6](https://github.com/googleapis/google-cloud-dotnet/commit/c7842e699a4324d6147d134e8067c7708f15b1f7))

## Version 3.4.0, released 2025-02-03

### New features

- Update Compute Engine API to revision 20250119 ([issue 981](https://github.com/googleapis/google-cloud-dotnet/issues/981)) ([commit 45c3223](https://github.com/googleapis/google-cloud-dotnet/commit/45c322349cb14789bf9318e44974042baa167659))

## Version 3.3.0, released 2025-01-27

### New features

- Update Compute Engine API to revision 20250107 ([issue 975](https://github.com/googleapis/google-cloud-dotnet/issues/975)) ([commit f4f1f81](https://github.com/googleapis/google-cloud-dotnet/commit/f4f1f81c82fb1157a5bdcf28b1c0ee7412c71f11))

## Version 3.2.0, released 2024-12-12

### New features

- Update Compute Engine API to revision 20241201 ([issue 966](https://github.com/googleapis/google-cloud-dotnet/issues/966)) ([commit 7239f50](https://github.com/googleapis/google-cloud-dotnet/commit/7239f50bdec0ada1978fe81799641632dc1084da))

## Version 3.1.0, released 2024-11-18

### New features

- Update Compute Engine API to revision 20241105 ([issue 954](https://github.com/googleapis/google-cloud-dotnet/issues/954)) ([commit 8577e3f](https://github.com/googleapis/google-cloud-dotnet/commit/8577e3fd9f22769db8d740a44efc03dbc07689d8))

## Version 3.0.0, released 2024-11-07

### New features

- Update Compute Engine API to revision 20241015 ([commit dd73c65](https://github.com/googleapis/google-cloud-dotnet/commit/dd73c65b8bb7aa8a5927b5e5f7bb8d5e8372f881))

### Breaking changes

This release removes some IAM-related client library types. These
already had no effect on the service, but due to the wide-ranging
nature of the removal, it's *possible* that customers may have been
relying on the types. We do not expect these types to reappear in
the library; if this removal breaks your code, please check
carefully for what you expected it to do, and raise an issue in
GitHub if you have concerns.

## Version 2.17.0, released 2024-07-25

### Bug fixes

- Fix pagination for optional fields ([issue 13311](https://github.com/googleapis/google-cloud-dotnet/issues/13311))

## Version 2.16.0, released 2024-05-08

### New features

- Update Compute Engine API to revision 20240430 ([issue 900](https://github.com/googleapis/google-cloud-dotnet/issues/900)) ([commit 95da052](https://github.com/googleapis/google-cloud-dotnet/commit/95da0521b6ee7c97fa560544647c3a29e7751c6e))
- Update Compute Engine API to revision 20240421 ([issue 899](https://github.com/googleapis/google-cloud-dotnet/issues/899)) ([commit cc0431c](https://github.com/googleapis/google-cloud-dotnet/commit/cc0431c34f4a8affb8138beb711cd8c9bb5c8da4))
- Update Compute Engine API to revision 20240407 ([issue 890](https://github.com/googleapis/google-cloud-dotnet/issues/890)) ([commit ee6c6f0](https://github.com/googleapis/google-cloud-dotnet/commit/ee6c6f02ddf65283b0919bc01cb65d7e6f2c87b0))
- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 2.15.0, released 2024-03-26

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))

## Version 2.14.0, released 2024-03-04

### New features

- Update Compute Engine API to revision 20240220 ([issue 886](https://github.com/googleapis/google-cloud-dotnet/issues/886)) ([commit eca3b4f](https://github.com/googleapis/google-cloud-dotnet/commit/eca3b4f258bac8d1b67e9b5178d0daf25efa2cef))

## Version 2.13.0, released 2024-02-08

### New features

- Update Compute Engine API to revision 20240130 ([issue 881](https://github.com/googleapis/google-cloud-dotnet/issues/881)) ([commit f265ab6](https://github.com/googleapis/google-cloud-dotnet/commit/f265ab6a4e138a1285a4730288fbbf62f0938730))

## Version 2.12.0, released 2023-12-11

### New features

- Update Compute Engine API to revision 20231110 ([issue 868](https://github.com/googleapis/google-cloud-dotnet/issues/868)) ([commit 8e8bab2](https://github.com/googleapis/google-cloud-dotnet/commit/8e8bab2c81fa30e3a176fc6a71f2abe9acae3646))

## Version 2.11.0, released 2023-08-04

### New features

- Update Compute Engine API to revision 20230711 ([issue 836](https://github.com/googleapis/google-cloud-dotnet/issues/836)) ([commit 95216dc](https://github.com/googleapis/google-cloud-dotnet/commit/95216dcc3d77c9aefcbc4225c389932dde0f578c))

## Version 2.10.0, released 2023-07-13

### New features

- Update Compute Engine API to revision 20230701 ([issue 821](https://github.com/googleapis/google-cloud-dotnet/issues/821)) ([commit 7b34803](https://github.com/googleapis/google-cloud-dotnet/commit/7b348032a29ca68847b80ab0c998586cf5a46c02))
## Version 2.9.0, released 2023-03-27

### New features

- Update Compute Engine API to revision 20230307 ([issue 786](https://github.com/googleapis/google-cloud-dotnet/issues/786)) ([commit 1184e2d](https://github.com/googleapis/google-cloud-dotnet/commit/1184e2db3e775d3b230dcf5bd28584d929d6dfff))

## Version 2.8.0, released 2023-03-20

### New features

- Update Compute Engine API to revision 20230307 ([issue 770](https://github.com/googleapis/google-cloud-dotnet/issues/770)) ([commit 0497f75](https://github.com/googleapis/google-cloud-dotnet/commit/0497f75cb6372e1c72d4302211894c8146335f70))

## Version 2.7.0, released 2023-02-08

### New features

- Update Compute Engine API to revision 20230103 ([issue 769](https://github.com/googleapis/google-cloud-dotnet/issues/769)) ([commit 7a3d11f](https://github.com/googleapis/google-cloud-dotnet/commit/7a3d11f2b1fba724159e9a50df1b439e018c00d3))

## Version 2.6.0, released 2023-01-20

### New features

- Update Compute Engine API to revision 20221224 ([issue 760](https://github.com/googleapis/google-cloud-dotnet/issues/760)) ([commit 5889030](https://github.com/googleapis/google-cloud-dotnet/commit/58890304e5fbda3f09289695aa356a9d3adc27d2))

## Version 2.5.0, released 2022-12-14

### New features

- Update Compute Engine API to revision 20221126 ([issue 757](https://github.com/googleapis/google-cloud-dotnet/issues/757)) ([commit da30e3a](https://github.com/googleapis/google-cloud-dotnet/commit/da30e3a14d3b633ca2b7ed77d6dbd296f4676a6a))

## Version 2.4.0, released 2022-12-01

### New features

- Update Compute Engine API to revision 20221101 ([issue 751](https://github.com/googleapis/google-cloud-dotnet/issues/751)) ([commit 83e6c11](https://github.com/googleapis/google-cloud-dotnet/commit/83e6c115e69a1d802022c6aa3be2eaebe4c09342))

## Version 2.3.0, released 2022-11-02

### New features

- Update Compute Engine API to revision 20221011 ([issue 736](https://github.com/googleapis/google-cloud-dotnet/issues/736)) ([commit 3d53a41](https://github.com/googleapis/google-cloud-dotnet/commit/3d53a41b073b4286f4fa7ab1d33748eb7f0e1147))

## Version 2.2.0, released 2022-09-15

### New features

- Update Compute Engine API to revision 20220831 ([issue 729](https://github.com/googleapis/google-cloud-dotnet/issues/729)) ([commit 8ac5c46](https://github.com/googleapis/google-cloud-dotnet/commit/8ac5c46ed078012742ddd1e19e155ea86d7fa597))

## Version 2.1.0, released 2022-08-04

### New features

- Update Compute Engine API to revision 20220720 ([issue 723](https://github.com/googleapis/google-cloud-dotnet/issues/723)) ([commit 5bdaae8](https://github.com/googleapis/google-cloud-dotnet/commit/5bdaae8eeb7d8081d22329285ce5fc27e3cc8a8d))

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

### New features

- Update Compute Engine API to revision 20220526 ([issue 722](https://github.com/googleapis/google-cloud-dotnet/issues/722)) ([commit 5d75c04](https://github.com/googleapis/google-cloud-dotnet/commit/5d75c04f14b957c75bcb490276470c79dc60c827))
## Version 1.4.0, released 2022-04-21

### Bug fixes

- Revert proto3_optional, required removal on parent_id ([issue 714](https://github.com/googleapis/google-cloud-dotnet/issues/714)) ([commit a6d7f74](https://github.com/googleapis/google-cloud-dotnet/commit/a6d7f74ce3b8d0e15c5965a6afdf64355cb59942))

BREAKING CHANGE: The above change is breaking, in terms of
removing the `HasParentId` and `ClearParentId()` members. We are
releasing as a minor version as these members were only introduced
recently, and the change will definitely be needed long-term.

## Version 1.3.0, released 2022-04-13

### Bug fixes

- Remove proto3_optional from parent_id ([issue 712](https://github.com/googleapis/google-cloud-dotnet/issues/712)) ([commit eabc9ef](https://github.com/googleapis/google-cloud-dotnet/commit/eabc9efd1841d18c0637650905c7276865c8b56a))
- Replace missing REQUIRED for parent_id ([issue 711](https://github.com/googleapis/google-cloud-dotnet/issues/711)) ([commit d2b3623](https://github.com/googleapis/google-cloud-dotnet/commit/d2b362398918387d2586c26c240d5e05b16b4b08))

BREAKING CHANGES: The above changes are breaking, in terms of
removing the `HasParentId` and `ClearParentId()` members. We are
releasing as a minor version as these members were only introduced
less than a week ago, and the change will definitely be needed
long-term.

## Version 1.2.0, released 2022-04-08

### New features

- Update compute API to revision 20220322 ([issue 710](https://github.com/googleapis/google-cloud-dotnet/issues/710)) ([commit 282c421](https://github.com/googleapis/google-cloud-dotnet/commit/282c421c1e5a76ed5734d9e7bf6440610e27db0c))

## Version 1.1.0, released 2022-02-14

### New features

- Update compute API to revision 20220112 ([issue 700](https://github.com/googleapis/google-cloud-dotnet/issues/700)) ([commit ebe518a](https://github.com/googleapis/google-cloud-dotnet/commit/ebe518afb1f06c38fc5162c04ed1f7650e52fd14))
  - The original commit contained breaking changes, but they were reverted in [commit 50ea200](https://github.com/googleapis/google-cloud-dotnet/commit/50ea200dc05ed5001cb7dca99c5f8203eb4ca6c7)

## Version 1.0.0, released 2022-01-11

No API surface changes; just dependency updates for first GA release.

## Version 1.0.0-beta06, released 2021-12-06

- [Commit 25e54fa](https://github.com/googleapis/google-cloud-dotnet/commit/25e54fa): fix!: handle GCP enum name start with uppercase IPProtocol

## Version 1.0.0-beta05, released 2021-12-01

- [Commit 5f323c1](https://github.com/googleapis/google-cloud-dotnet/commit/5f323c1): fix: make parent_id fields required compute move and insert methods ([issue 686](https://github.com/googleapis/google-cloud-dotnet/issues/686))
- [Commit f8f4704](https://github.com/googleapis/google-cloud-dotnet/commit/f8f4704): feat: Add classes with generated constants for enums for Compute
- [Commit 238f43c](https://github.com/googleapis/google-cloud-dotnet/commit/238f43c): feat: Add helper methods for converting Compute enum values
- [Commit 5d969a2](https://github.com/googleapis/google-cloud-dotnet/commit/5d969a2): feat: Switch to string enums for compute ([issue 685](https://github.com/googleapis/google-cloud-dotnet/issues/685))

## Version 1.0.0-beta04, released 2021-11-10

- [Commit 41d3129](https://github.com/googleapis/google-cloud-dotnet/commit/41d3129): fix: Convert HTTP status codes to gRPC status codes when converting LROs

This also updates the GAX dependency to 3.6.0-beta03.
## Version 1.0.0-beta03, released 2021-10-14

- [Commit 77a75b3](https://github.com/googleapis/google-cloud-dotnet/commit/77a75b3): feat!: Generate idiomatic LROs for Google.Cloud.Compute.V1

BREAKING CHANGE: All RPCs representing long running operations
(LROs) are now exposed using the `Operation<,>` type in the
Google.LongRunning package. This allows code using the Compute API
to be equivalent to that of LROs in other packages, even though
behind the scenes they don't follow the exact same pattern.

In particular, this makes it much easier to wait for an operation to
complete without writing any manual polling code. However, it is a
breaking change compared with the previous beta releases.

## Version 1.0.0-beta02, released 2021-08-19

- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs

## Version 1.0.0-beta01, released 2021-08-09

Main changes from 1.0.0-alpha02:

- Automatic pagination is now implemented for all "list" methods. This is a breaking
  change, as the return type has changed. Any code which was
  previously looping over responses manually and handling page
  tokens can be simplified at this point. See https://cloud.google.com/dotnet/docs/reference/help/page-streaming
  for more details.
- Failed RPCs will now contain details of the failure, rather than
  just a status code. Currently this is just the textual
  representation of the original RPC response; in the future this
  text may be parsed automatically.

## Version 1.0.0-alpha02, released 2021-06-16

Regenerated with changes from googleapis-discovery, and GAX
3.5.0-alpha01.

## Version 1.0.0-alpha01, released 2021-05-13

First alpha release. Please note that this library is still in early
testing phases, and is not suitable for production workloads.
