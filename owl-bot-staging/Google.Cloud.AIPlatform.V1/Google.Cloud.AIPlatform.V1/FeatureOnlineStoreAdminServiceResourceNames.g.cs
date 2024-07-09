// Copyright 2024 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

#pragma warning disable CS8981
using gagr = Google.Api.Gax.ResourceNames;
using gcav = Google.Cloud.AIPlatform.V1;

namespace Google.Cloud.AIPlatform.V1
{
    public partial class CreateFeatureOnlineStoreRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetFeatureOnlineStoreRequest
    {
        /// <summary>
        /// <see cref="gcav::FeatureOnlineStoreName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::FeatureOnlineStoreName FeatureOnlineStoreName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::FeatureOnlineStoreName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListFeatureOnlineStoresRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteFeatureOnlineStoreRequest
    {
        /// <summary>
        /// <see cref="gcav::FeatureOnlineStoreName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::FeatureOnlineStoreName FeatureOnlineStoreName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::FeatureOnlineStoreName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateFeatureViewRequest
    {
        /// <summary>
        /// <see cref="FeatureOnlineStoreName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public FeatureOnlineStoreName ParentAsFeatureOnlineStoreName
        {
            get => string.IsNullOrEmpty(Parent) ? null : FeatureOnlineStoreName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetFeatureViewRequest
    {
        /// <summary>
        /// <see cref="gcav::FeatureViewName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::FeatureViewName FeatureViewName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::FeatureViewName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListFeatureViewsRequest
    {
        /// <summary>
        /// <see cref="FeatureOnlineStoreName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public FeatureOnlineStoreName ParentAsFeatureOnlineStoreName
        {
            get => string.IsNullOrEmpty(Parent) ? null : FeatureOnlineStoreName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteFeatureViewRequest
    {
        /// <summary>
        /// <see cref="gcav::FeatureViewName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::FeatureViewName FeatureViewName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::FeatureViewName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class SyncFeatureViewRequest
    {
        /// <summary>
        /// <see cref="FeatureViewName"/>-typed view over the <see cref="FeatureView"/> resource name property.
        /// </summary>
        public FeatureViewName FeatureViewAsFeatureViewName
        {
            get => string.IsNullOrEmpty(FeatureView) ? null : FeatureViewName.Parse(FeatureView, allowUnparsed: true);
            set => FeatureView = value?.ToString() ?? "";
        }
    }

    public partial class GetFeatureViewSyncRequest
    {
        /// <summary>
        /// <see cref="gcav::FeatureViewSyncName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::FeatureViewSyncName FeatureViewSyncName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::FeatureViewSyncName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListFeatureViewSyncsRequest
    {
        /// <summary>
        /// <see cref="FeatureViewName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public FeatureViewName ParentAsFeatureViewName
        {
            get => string.IsNullOrEmpty(Parent) ? null : FeatureViewName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }
}
