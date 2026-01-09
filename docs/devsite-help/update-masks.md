# Update Masks

## Optimizing Resource Updates with FieldMask

When updating resources (often corresponding to HTTP PATCH requests) in Google Cloud APIs, you generally use an **Update Mask** (represented by `Google.Protobuf.WellKnownTypes.FieldMask`).

The purpose of the Update Mask is to tell the server exactly which fields you intend to modify, preventing accidental overwrites or resetting of other fields that you did not include in your request object.

By providing a `FieldMask`, you explicitly declare the subset of fields in the resource object that should be updated.

## Constructing and Applying the FieldMask

The `FieldMask` object is part of the `Google.Protobuf` library and contains a collection of strings representing the fields paths to be modified.

**Crucial Point:** The strings in the `FieldMask.Paths` collection **must** correspond to the **original** field names defined in the Protocol Buffer (protobuf) schema, not the C\# property names (which are PascalCase).

# Examples

[!code-cs[](../examples/help.UpdateMask.txt#UpdateMasks)]
