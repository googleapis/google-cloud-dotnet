// Copyright 2025 Google Inc. All Rights Reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using static Google.Apis.Storage.v1.ObjectsResource;
using Object = Google.Apis.Storage.v1.Data.Object;

namespace Google.Cloud.Storage.V1;

/// <summary>
/// Options for <c>MoveObject</c> operations.
/// </summary>
public sealed class MoveObjectOptions
{

    /// <summary>
    /// Precondition for moving: the object is only moved if the existing destination object's
    /// generation matches the given value.
    /// </summary>
    public long? IfGenerationMatch { get; set; }

    /// <summary>
    /// Precondition for moving: the object is only moved if the existing destination object's
    /// generation does not match the given value.
    /// </summary>
    public long? IfGenerationNotMatch { get; set; }

    /// <summary>
    /// Precondition for moving: the object is only moved if the existing destination object's
    /// meta-generation matches the given value.
    /// </summary>
    public long? IfMetagenerationMatch { get; set; }

    /// <summary>
    /// Precondition for moving: the object is only moved if the existing destination object's
    /// meta-generation does not match the given value.
    /// </summary>
    public long? IfMetagenerationNotMatch { get; set; }

    /// <summary>
    /// Precondition for moving: the object is only moved if the source object's
    /// generation matches the given value.
    /// </summary>
    public long? IfSourceGenerationMatch { get; set; }

    /// <summary>
    /// Precondition for moving: the object is only moved if the source object's
    /// generation does not match the given value.
    /// </summary>
    public long? IfSourceGenerationNotMatch { get; set; }

    /// <summary>
    /// Precondition for moving: the object is only moved if the source object's
    /// meta-generation matches the given value.
    /// </summary>
    public long? IfSourceMetagenerationMatch { get; set; }

    /// <summary>
    /// Precondition for moving: the object is only moved if the source object's
    /// meta-generation does not match the given value.
    /// </summary>
    public long? IfSourceMetagenerationNotMatch { get; set; }

    /// <summary>
    /// Additional object metadata for the new object. This can be used to specify the storage
    /// class of the new object, the content type etc. If this property is not set, the existing
    /// object metadata will be used unchanged.
    /// </summary>
    public Object ExtraMetadata { get; set; }

    /// <summary>
    /// The encryption key to use for this operation. If this property is null, the <see cref="StorageClient.EncryptionKey"/>
    /// will be used instead. Use <see cref="EncryptionKey.None"/> to remove encryption headers from this request.
    /// </summary>
    public EncryptionKey EncryptionKey { get; set; }

    /// <summary>
    /// The encryption key to use for the source of the copy. If this property is null, the <see cref="StorageClient.EncryptionKey"/>
    /// will be used instead. Use <see cref="EncryptionKey.None"/> if the source is not encrypted.
    /// </summary>
    public EncryptionKey SourceEncryptionKey { get; set; }

    /// <summary>
    /// If set, this is the ID of the project which will be billed for the request.
    /// The caller must have suitable permissions for the project being billed.
    /// </summary>
    public string UserProject { get; set; }

    /// <summary>
    /// Options to pass custom retry configuration for each API request.
    /// </summary>
    public RetryOptions RetryOptions { get; set; }

    internal void ModifyRequest(MoveRequest request)
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
        if (IfSourceGenerationMatch != null && IfSourceGenerationNotMatch != null)
        {
            throw new ArgumentException($"Cannot specify {nameof(IfSourceGenerationMatch)} and {nameof(IfSourceGenerationNotMatch)} in the same options", "options");
        }
        if (IfSourceMetagenerationMatch != null && IfSourceMetagenerationNotMatch != null)
        {
            throw new ArgumentException($"Cannot specify {nameof(IfSourceMetagenerationMatch)} and {nameof(IfSourceMetagenerationNotMatch)} in the same options", "options");
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
        if (IfSourceGenerationMatch != null)
        {
            request.IfSourceGenerationMatch = IfSourceGenerationMatch;
        }
        if (IfSourceGenerationNotMatch != null)
        {
            request.IfSourceGenerationNotMatch = IfSourceGenerationNotMatch;
        }
        if (IfSourceMetagenerationMatch != null)
        {
            request.IfSourceMetagenerationMatch = IfSourceMetagenerationMatch;
        }
        if (IfSourceMetagenerationNotMatch != null)
        {
            request.IfSourceMetagenerationNotMatch = IfSourceMetagenerationNotMatch;
        }
        if (UserProject != null)
        {
            request.UserProject = UserProject;
        }
    }
}
