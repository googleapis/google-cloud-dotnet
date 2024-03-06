// Copyright 2024 Google LLC
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

using Google.Api.Gax;
using System;
using static Google.Apis.Storage.v1.ObjectsResource;
using static Google.Apis.Storage.v1.ObjectsResource.RestoreRequest;

namespace Google.Cloud.Storage.V1;

/// <summary>
/// Options for RestoreObject operations.
/// </summary>
public sealed class RestoreObjectOptions
{
    /// <summary>
    /// If true, the source object's access controls will be copied to the restored object,
    /// unless the bucket has UBLA enabled, in which case the restore operation will fail.
    /// Otherwise, the bucket's default object ACL will be used.
    /// </summary>
    public bool? CopySourceAcl { get; set; }

    /// <summary>
    /// The projection of the restored object to return. Note the whole object will be restored,
    /// except for the object's access controls, see <see cref="CopySourceAcl"/> for that. This only affects
    /// what information is returned when restoration is successful.
    /// </summary>
    public Projection? Projection { get; set; }

    /// <summary>
    /// Makes the operation conditional on whether the object's current generation
    /// matches the given value. Setting to 0 makes the operation succeed only if
    /// there are no live versions of the object.
    /// </summary>
    /// <remarks>
    /// Note that the generation value passed to the restore operations (a) specifies the exact generation
    /// that should be restored, whereas this value (b) is a constraint on the current generation of the object
    /// for the operation to succeed. Effectively, this means restore version (a) if current generation is (b).
    /// </remarks>
    public long? IfGenerationMatch { get; set; }

    /// <summary>
    /// Makes the operation conditional on whether the object's live generation
    /// does not match the given value. If no live object exists, the precondition
    /// fails. Setting to 0 makes the operation succeed only if there is a live
    /// version of the object.
    /// </summary>
    /// <remarks>
    /// Note that the generation value passed to the restore operations (a) specifies the exact generation
    /// that should be restored, whereas this value (b) is a constraint on the current generation of the object
    /// for the operation to succeed. Effectively, this means restore version (a) if current generation is not (b).
    /// </remarks>
    public long? IfGenerationNotMatch { get; set; }

    /// <summary>
    /// Makes the operation conditional on whether the object's current
    /// metageneration matches the given value.
    /// </summary>
    /// <remarks>
    /// Note that the generation value passed to the restore operations (a) specifies the exact generation
    /// that should be restored, whereas this value (b) is a constraint on the current metageneration of the object
    /// for the operation to succeed. Effectively, this means restore version (a) if current metageneration is (b).
    /// </remarks>
    public long? IfMetagenerationMatch { get; set; }

    /// <summary>
    /// Makes the operation conditional on whether the object's current
    /// metageneration does not match the given value.
    /// </summary>
    /// <remarks>
    /// Note that the generation value passed to the restore operations (a) specifies the exact generation
    /// that should be restored, whereas this value (b) is a constraint on the current metageneration of the object
    /// for the operation to succeed. Effectively, this means restore version (a) if current metageneration is (b).
    /// </remarks>
    public long? IfMetagenerationNotMatch { get; set; }

    /// <summary>
    /// The encryption key to use for this operation. If this property is null, the <see cref="StorageClient.EncryptionKey"/>
    /// will be used instead. Use <see cref="EncryptionKey.None"/> to remove encryption headers from this request.
    /// </summary>
    public EncryptionKey EncryptionKey { get; set; }

    /// <summary>
    /// If set, this is the ID of the project which will be billed for the request.
    /// The caller must have suitable permissions for the project being billed.
    /// </summary>
    public string UserProject { get; set; }

    /// <summary>
    /// Options to pass custom retry configuration for each API request.
    /// </summary>
    public RetryOptions RetryOptions { get; set; }

    internal void ModifyRequest(RestoreRequest request)
    {
        // Note the use of ArgumentException here, as this will basically be the result of invalid
        // options being passed to a public method.
        if (IfGenerationMatch != null && IfGenerationNotMatch != null)
        {
            throw new ArgumentException($"Cannot specify {nameof(IfGenerationMatch)} and {nameof(IfGenerationNotMatch)} in the same options", "options");
        }
        if (IfMetagenerationMatch != null && IfMetagenerationNotMatch != null)
        {
            throw new ArgumentException($"Cannot specify {nameof(IfMetagenerationMatch)} and {nameof(IfMetagenerationNotMatch)} in the same options", "options");
        }

        if (IfGenerationMatch != null)
        {
            request.IfGenerationMatch = IfGenerationMatch;
        }
        if (IfGenerationNotMatch != null)
        {
            request.IfGenerationNotMatch = IfGenerationNotMatch;
        }
        if (IfMetagenerationMatch != null)
        {
            request.IfMetagenerationMatch = IfMetagenerationMatch;
        }
        if (IfMetagenerationNotMatch != null)
        {
            request.IfMetagenerationNotMatch = IfMetagenerationNotMatch;
        }
        if (CopySourceAcl.HasValue)
        {
            request.CopySourceAcl = CopySourceAcl.Value;
        }
        if (Projection != null)
        {
            request.Projection = GaxPreconditions.CheckEnumValue((ProjectionEnum) Projection, nameof(Projection));
        }
        if (UserProject != null)
        {
            request.UserProject = UserProject;
        }
    }
}
