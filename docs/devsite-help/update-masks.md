# Update Masks

## Optimizing Resource Updates with FieldMask

When updating resources (often corresponding to HTTP PATCH requests) in Google Cloud APIs, you generally use an **Update Mask** (represented by `Google.Protobuf.WellKnownTypes.FieldMask`).

The Update Mask (provided via a `FieldMask`) explicitly declares the subset of fields you intend to modify. This ensures the server only updates those specific fields, preventing accidental overwrites or the resetting of data not included in your request.

## Constructing and Applying the FieldMask

The `FieldMask` object is part of the `Google.Protobuf` library and contains a collection of strings representing the field paths to be modified.

**Crucial Point:** The strings in the `FieldMask.Paths` collection **must** correspond to the **original** field names defined in the Protocol Buffer (protobuf) schema, not the C\# property names (which are PascalCase).

## Example

[!code-cs[](../examples/help.UpdateMask.txt#UpdateMasks)]
