// Copyright 2022 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License").
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at 
//
// https://www.apache.org/licenses/LICENSE-2.0 
//
// Unless required by applicable law or agreed to in writing, software 
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and 
// limitations under the License.

using Google.Apis.Bigquery.v2.Data;

namespace Google.Cloud.BigQuery.V2;

/// <summary>
/// Options for the <c>SetTableIamPolicy</c> operations.
/// </summary>
public sealed class SetTableIamPolicyOptions
{
    /// <summary>
    /// A FieldMask specifying which fields of the policy to modify.
    /// Only the fields in the mask will be modified.
    /// If no mask is provided, the following default mask is used:
    /// <c>paths: "bindings, etag"</c>.
    /// You can read more about the FieldMaks format here:
    /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#google.protobuf.FieldMask
    /// </summary>
    public string UpdateMask { get; set; }

    internal void ModifyRequest(SetIamPolicyRequest body)
    {
        if (UpdateMask is string)
        {
            body.UpdateMask = UpdateMask;
        }
    }
}
