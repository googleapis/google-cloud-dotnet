// Copyright 2025 Google LLC
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
using gax = Google.Api.Gax;
using gcdv = Google.Cloud.DataCatalog.V1;

namespace Google.Cloud.DataCatalog.V1
{
    public partial class ReplaceTaxonomyRequest
    {
        /// <summary>
        /// <see cref="gcdv::TaxonomyName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::TaxonomyName TaxonomyName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::TaxonomyName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ImportTaxonomiesRequest
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

    public partial class CrossRegionalSource
    {
        /// <summary>
        /// <see cref="TaxonomyName"/>-typed view over the <see cref="Taxonomy"/> resource name property.
        /// </summary>
        public TaxonomyName TaxonomyAsTaxonomyName
        {
            get => string.IsNullOrEmpty(Taxonomy) ? null : TaxonomyName.Parse(Taxonomy, allowUnparsed: true);
            set => Taxonomy = value?.ToString() ?? "";
        }
    }

    public partial class ExportTaxonomiesRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="TaxonomyName"/>-typed view over the <see cref="Taxonomies"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<TaxonomyName> TaxonomiesAsTaxonomyNames
        {
            get => new gax::ResourceNameList<TaxonomyName>(Taxonomies, s => string.IsNullOrEmpty(s) ? null : TaxonomyName.Parse(s, allowUnparsed: true));
        }
    }
}
