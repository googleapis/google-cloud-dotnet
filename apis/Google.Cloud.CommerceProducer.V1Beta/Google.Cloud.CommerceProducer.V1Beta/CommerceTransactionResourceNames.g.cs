// Copyright 2026 Google LLC
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
using gccv = Google.Cloud.CommerceProducer.V1Beta;

namespace Google.Cloud.CommerceProducer.V1Beta
{
    public partial class ListPrivateOffersRequest
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

    public partial class GetPrivateOfferRequest
    {
        /// <summary>
        /// <see cref="gccv::PrivateOfferName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::PrivateOfferName PrivateOfferName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::PrivateOfferName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ResolveAmendmentTargetRequest
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
        /// <see cref="gagr::BillingAccountName"/>-typed view over the <see cref="TargetBillingAccount"/> resource name
        /// property.
        /// </summary>
        public gagr::BillingAccountName TargetBillingAccountAsBillingAccountName
        {
            get => string.IsNullOrEmpty(TargetBillingAccount) ? null : gagr::BillingAccountName.Parse(TargetBillingAccount, allowUnparsed: true);
            set => TargetBillingAccount = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="StandardOfferName"/>-typed view over the <see cref="BaseStandardOffer"/> resource name property.
        /// </summary>
        public StandardOfferName BaseStandardOfferAsStandardOfferName
        {
            get => string.IsNullOrEmpty(BaseStandardOffer) ? null : StandardOfferName.Parse(BaseStandardOffer, allowUnparsed: true);
            set => BaseStandardOffer = value?.ToString() ?? "";
        }
    }

    public partial class ResolveAmendmentTargetResponse
    {
        /// <summary>
        /// <see cref="PrivateOfferName"/>-typed view over the <see cref="RequiredPrivateOffer"/> resource name
        /// property.
        /// </summary>
        public PrivateOfferName RequiredPrivateOfferAsPrivateOfferName
        {
            get => string.IsNullOrEmpty(RequiredPrivateOffer) ? null : PrivateOfferName.Parse(RequiredPrivateOffer, allowUnparsed: true);
            set => RequiredPrivateOffer = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="StandardOfferName"/>-typed view over the <see cref="RequiredStandardOffer"/> resource name
        /// property.
        /// </summary>
        public StandardOfferName RequiredStandardOfferAsStandardOfferName
        {
            get => string.IsNullOrEmpty(RequiredStandardOffer) ? null : StandardOfferName.Parse(RequiredStandardOffer, allowUnparsed: true);
            set => RequiredStandardOffer = value?.ToString() ?? "";
        }

        public partial class Types
        {
            public partial class OptionalOffers
            {
                /// <summary>
                /// <see cref="PrivateOfferName"/>-typed view over the <see cref="PrivateOffers"/> resource name
                /// property.
                /// </summary>
                public gax::ResourceNameList<PrivateOfferName> PrivateOffersAsPrivateOfferNames
                {
                    get => new gax::ResourceNameList<PrivateOfferName>(PrivateOffers, s => string.IsNullOrEmpty(s) ? null : PrivateOfferName.Parse(s, allowUnparsed: true));
                }
            }
        }
    }

    public partial class CreatePrivateOfferRequest
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

    public partial class PublishPrivateOfferRequest
    {
        /// <summary>
        /// <see cref="gccv::PrivateOfferName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::PrivateOfferName PrivateOfferName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::PrivateOfferName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CancelPrivateOfferRequest
    {
        /// <summary>
        /// <see cref="gccv::PrivateOfferName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::PrivateOfferName PrivateOfferName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::PrivateOfferName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeletePrivateOfferRequest
    {
        /// <summary>
        /// <see cref="gccv::PrivateOfferName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::PrivateOfferName PrivateOfferName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::PrivateOfferName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListPrivateOfferDocumentsRequest
    {
        /// <summary>
        /// <see cref="PrivateOfferName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public PrivateOfferName ParentAsPrivateOfferName
        {
            get => string.IsNullOrEmpty(Parent) ? null : PrivateOfferName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetPrivateOfferDocumentRequest
    {
        /// <summary>
        /// <see cref="gccv::PrivateOfferDocumentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::PrivateOfferDocumentName PrivateOfferDocumentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::PrivateOfferDocumentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreatePrivateOfferDocumentRequest
    {
        /// <summary>
        /// <see cref="PrivateOfferName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public PrivateOfferName ParentAsPrivateOfferName
        {
            get => string.IsNullOrEmpty(Parent) ? null : PrivateOfferName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeletePrivateOfferDocumentRequest
    {
        /// <summary>
        /// <see cref="gccv::PrivateOfferDocumentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::PrivateOfferDocumentName PrivateOfferDocumentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::PrivateOfferDocumentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListServicesRequest
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

    public partial class GetServiceRequest
    {
        /// <summary>
        /// <see cref="gccv::ServiceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::ServiceName ServiceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::ServiceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListStandardOffersRequest
    {
        /// <summary>
        /// <see cref="ServiceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ServiceName ParentAsServiceName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ServiceName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetStandardOfferRequest
    {
        /// <summary>
        /// <see cref="gccv::StandardOfferName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::StandardOfferName StandardOfferName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::StandardOfferName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListSkusRequest
    {
        /// <summary>
        /// <see cref="ServiceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ServiceName ParentAsServiceName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ServiceName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetSkuRequest
    {
        /// <summary>
        /// <see cref="gccv::SkuName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::SkuName SkuName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::SkuName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetSkuGroupRequest
    {
        /// <summary>
        /// <see cref="gccv::SkuGroupName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::SkuGroupName SkuGroupName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::SkuGroupName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListSkuGroupsRequest
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
}
