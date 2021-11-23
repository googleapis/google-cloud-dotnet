{{title}}

{{description}}

{{version}}

{{installation}}

{{auth}}

## Getting started

{{client-classes}}

{{client-construction}}

## Using wire values for enums

Many fields in the Compute API are effectively enums, representing
one of a fixed set of values.

These are currently represented as string properties in the API
surface, for compatibility reasons. C# enums containing the known
values are generated, but not used directly within the API surface.

As an example, the `Address` resource has a `NetworkTier` property,
of type `string`. The set of valid values is represented by the
`Address.Types.NetworkTier` enum - but these are generated with
C#-idiomatic names, *not* the strings that need to be used for the
`Address.NetworkTier` property.

Two approaches are provided to allow client code to refer to
specific values without hard-coding string literals in an
error-prone way. First, the [ComputeEnumConstants]
(obj/api/Google.Cloud.Compute.V1.ComputeEnumConstants.yml) class
provides all known enum constants via nested classes. For example,
the `NetworkTier` enum used by `Address` is represented in the
`ComputeEnumConstants.Address.NetworkTier` class:

{{sample:Enum.EnumConstants}}

This is simple for cases where client code needs to refer to a
single value known at compile-time. In situations where more
flexibility is required, the wire value corresponding to each enum
value can be obtained using [ComputeEnumHelpers.Format]
(obj/api/Google.Cloud.Compute.V1.ComputeEnumHelpers.yml#Google_Cloud_Compute_V1_ComputeEnumHelpers_Format__1___0_):

{{sample:Enum.EnumHelpersFormat}}

The reverse operation (parsing from a wire value to an enum value)
can be achieved using [ComputeEnumHelpers.TryParse]
(obj/api/Google.Cloud.Compute.V1.ComputeEnumHelpers.yml#Google_Cloud_Compute_V1_ComputeEnumHelpers_TryParse__1_System_String___0__)
and [ComputeEnumHelpers.Parse]
(obj/api/Google.Cloud.Compute.V1.ComputeEnumHelpers.yml#Google_Cloud_Compute_V1_ComputeEnumHelpers_Parse__1_System_String_):

{{sample:Enum.EnumHelpersTryParse}}

(Following .NET conventions, the `Parse` method returns the parsed
enum value directly instead of using an `out` parameter, but throws
an exception if the value is not recognized.)
