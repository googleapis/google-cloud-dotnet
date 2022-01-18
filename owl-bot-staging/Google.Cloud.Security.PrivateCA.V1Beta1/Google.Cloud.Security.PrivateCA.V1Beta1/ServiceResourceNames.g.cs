// Copyright 2022 Google LLC
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

using gagr = Google.Api.Gax.ResourceNames;
using gcspv = Google.Cloud.Security.PrivateCA.V1Beta1;

namespace Google.Cloud.Security.PrivateCA.V1Beta1
{
    public partial class CreateCertificateRequest
    {
        /// <summary>
        /// <see cref="CertificateAuthorityName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public CertificateAuthorityName ParentAsCertificateAuthorityName
        {
            get => string.IsNullOrEmpty(Parent) ? null : CertificateAuthorityName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetCertificateRequest
    {
        /// <summary>
        /// <see cref="gcspv::CertificateName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcspv::CertificateName CertificateName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcspv::CertificateName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListCertificatesRequest
    {
        /// <summary>
        /// <see cref="CertificateAuthorityName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public CertificateAuthorityName ParentAsCertificateAuthorityName
        {
            get => string.IsNullOrEmpty(Parent) ? null : CertificateAuthorityName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class RevokeCertificateRequest
    {
        /// <summary>
        /// <see cref="gcspv::CertificateName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcspv::CertificateName CertificateName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcspv::CertificateName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ActivateCertificateAuthorityRequest
    {
        /// <summary>
        /// <see cref="gcspv::CertificateAuthorityName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcspv::CertificateAuthorityName CertificateAuthorityName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcspv::CertificateAuthorityName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateCertificateAuthorityRequest
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

    public partial class DisableCertificateAuthorityRequest
    {
        /// <summary>
        /// <see cref="gcspv::CertificateAuthorityName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcspv::CertificateAuthorityName CertificateAuthorityName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcspv::CertificateAuthorityName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class EnableCertificateAuthorityRequest
    {
        /// <summary>
        /// <see cref="gcspv::CertificateAuthorityName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcspv::CertificateAuthorityName CertificateAuthorityName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcspv::CertificateAuthorityName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class FetchCertificateAuthorityCsrRequest
    {
        /// <summary>
        /// <see cref="gcspv::CertificateAuthorityName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcspv::CertificateAuthorityName CertificateAuthorityName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcspv::CertificateAuthorityName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetCertificateAuthorityRequest
    {
        /// <summary>
        /// <see cref="gcspv::CertificateAuthorityName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcspv::CertificateAuthorityName CertificateAuthorityName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcspv::CertificateAuthorityName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListCertificateAuthoritiesRequest
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

    public partial class RestoreCertificateAuthorityRequest
    {
        /// <summary>
        /// <see cref="gcspv::CertificateAuthorityName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcspv::CertificateAuthorityName CertificateAuthorityName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcspv::CertificateAuthorityName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ScheduleDeleteCertificateAuthorityRequest
    {
        /// <summary>
        /// <see cref="gcspv::CertificateAuthorityName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcspv::CertificateAuthorityName CertificateAuthorityName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcspv::CertificateAuthorityName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetCertificateRevocationListRequest
    {
        /// <summary>
        /// <see cref="gcspv::CertificateRevocationListName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcspv::CertificateRevocationListName CertificateRevocationListName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcspv::CertificateRevocationListName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListCertificateRevocationListsRequest
    {
        /// <summary>
        /// <see cref="CertificateAuthorityName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public CertificateAuthorityName ParentAsCertificateAuthorityName
        {
            get => string.IsNullOrEmpty(Parent) ? null : CertificateAuthorityName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetReusableConfigRequest
    {
        /// <summary>
        /// <see cref="gcspv::ReusableConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcspv::ReusableConfigName ReusableConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcspv::ReusableConfigName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListReusableConfigsRequest
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
