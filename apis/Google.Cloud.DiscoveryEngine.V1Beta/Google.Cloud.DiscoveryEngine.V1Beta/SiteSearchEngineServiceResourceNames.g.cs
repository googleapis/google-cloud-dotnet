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
using gcdv = Google.Cloud.DiscoveryEngine.V1Beta;

namespace Google.Cloud.DiscoveryEngine.V1Beta
{
    public partial class GetSiteSearchEngineRequest
    {
        /// <summary>
        /// <see cref="gcdv::SiteSearchEngineName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::SiteSearchEngineName SiteSearchEngineName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::SiteSearchEngineName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateTargetSiteRequest
    {
        /// <summary>
        /// <see cref="SiteSearchEngineName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public SiteSearchEngineName ParentAsSiteSearchEngineName
        {
            get => string.IsNullOrEmpty(Parent) ? null : SiteSearchEngineName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class BatchCreateTargetSitesRequest
    {
        /// <summary>
        /// <see cref="SiteSearchEngineName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public SiteSearchEngineName ParentAsSiteSearchEngineName
        {
            get => string.IsNullOrEmpty(Parent) ? null : SiteSearchEngineName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetTargetSiteRequest
    {
        /// <summary>
        /// <see cref="gcdv::TargetSiteName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::TargetSiteName TargetSiteName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::TargetSiteName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteTargetSiteRequest
    {
        /// <summary>
        /// <see cref="gcdv::TargetSiteName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::TargetSiteName TargetSiteName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::TargetSiteName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListTargetSitesRequest
    {
        /// <summary>
        /// <see cref="SiteSearchEngineName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public SiteSearchEngineName ParentAsSiteSearchEngineName
        {
            get => string.IsNullOrEmpty(Parent) ? null : SiteSearchEngineName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class CreateSitemapRequest
    {
        /// <summary>
        /// <see cref="SiteSearchEngineName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public SiteSearchEngineName ParentAsSiteSearchEngineName
        {
            get => string.IsNullOrEmpty(Parent) ? null : SiteSearchEngineName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteSitemapRequest
    {
        /// <summary>
        /// <see cref="gcdv::SitemapName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::SitemapName SitemapName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::SitemapName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class FetchSitemapsRequest
    {
        /// <summary>
        /// <see cref="SiteSearchEngineName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public SiteSearchEngineName ParentAsSiteSearchEngineName
        {
            get => string.IsNullOrEmpty(Parent) ? null : SiteSearchEngineName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class EnableAdvancedSiteSearchRequest
    {
        /// <summary>
        /// <see cref="SiteSearchEngineName"/>-typed view over the <see cref="SiteSearchEngine"/> resource name
        /// property.
        /// </summary>
        public SiteSearchEngineName SiteSearchEngineAsSiteSearchEngineName
        {
            get => string.IsNullOrEmpty(SiteSearchEngine) ? null : SiteSearchEngineName.Parse(SiteSearchEngine, allowUnparsed: true);
            set => SiteSearchEngine = value?.ToString() ?? "";
        }
    }

    public partial class DisableAdvancedSiteSearchRequest
    {
        /// <summary>
        /// <see cref="SiteSearchEngineName"/>-typed view over the <see cref="SiteSearchEngine"/> resource name
        /// property.
        /// </summary>
        public SiteSearchEngineName SiteSearchEngineAsSiteSearchEngineName
        {
            get => string.IsNullOrEmpty(SiteSearchEngine) ? null : SiteSearchEngineName.Parse(SiteSearchEngine, allowUnparsed: true);
            set => SiteSearchEngine = value?.ToString() ?? "";
        }
    }

    public partial class RecrawlUrisRequest
    {
        /// <summary>
        /// <see cref="SiteSearchEngineName"/>-typed view over the <see cref="SiteSearchEngine"/> resource name
        /// property.
        /// </summary>
        public SiteSearchEngineName SiteSearchEngineAsSiteSearchEngineName
        {
            get => string.IsNullOrEmpty(SiteSearchEngine) ? null : SiteSearchEngineName.Parse(SiteSearchEngine, allowUnparsed: true);
            set => SiteSearchEngine = value?.ToString() ?? "";
        }
    }

    public partial class BatchVerifyTargetSitesRequest
    {
        /// <summary>
        /// <see cref="SiteSearchEngineName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public SiteSearchEngineName ParentAsSiteSearchEngineName
        {
            get => string.IsNullOrEmpty(Parent) ? null : SiteSearchEngineName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class FetchDomainVerificationStatusRequest
    {
        /// <summary>
        /// <see cref="SiteSearchEngineName"/>-typed view over the <see cref="SiteSearchEngine"/> resource name
        /// property.
        /// </summary>
        public SiteSearchEngineName SiteSearchEngineAsSiteSearchEngineName
        {
            get => string.IsNullOrEmpty(SiteSearchEngine) ? null : SiteSearchEngineName.Parse(SiteSearchEngine, allowUnparsed: true);
            set => SiteSearchEngine = value?.ToString() ?? "";
        }
    }
}
