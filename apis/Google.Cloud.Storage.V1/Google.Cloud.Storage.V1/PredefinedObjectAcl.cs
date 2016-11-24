// Copyright 2016 Google Inc. All Rights Reserved.
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

namespace Google.Cloud.Storage.V1
{
    /// <summary>
    /// Predefined access control lists (ACLs) that can be specified when creating or updating objects.
    /// </summary>
    public enum PredefinedObjectAcl
    {
        /// <summary>Object owner gets owner access, and all authenticated users get reader access.</summary>
        AuthenticatedRead,
        /// <summary>Object owner gets owner access, and project team owners get owner access.</summary>
        BucketOwnerFullControl,
        /// <summary>Object owner gets owner access, and project team owners get reader access.</summary>
        BucketOwnerRead,
        /// <summary>Object owner gets owner access.</summary>
        Private,
        /// <summary>Object owner gets owner access, and project team members get access according to their roles.</summary>
        ProjectPrivate,
        /// <summary>Object owner gets owner access, and all users get reader access.</summary>
        PublicRead
    }
}
