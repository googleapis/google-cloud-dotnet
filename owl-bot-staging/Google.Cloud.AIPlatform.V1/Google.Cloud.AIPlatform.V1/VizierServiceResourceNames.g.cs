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
    public partial class GetStudyRequest
    {
        /// <summary>
        /// <see cref="gcav::StudyName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::StudyName StudyName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::StudyName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateStudyRequest
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

    public partial class ListStudiesRequest
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

    public partial class DeleteStudyRequest
    {
        /// <summary>
        /// <see cref="gcav::StudyName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::StudyName StudyName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::StudyName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class LookupStudyRequest
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

    public partial class SuggestTrialsRequest
    {
        /// <summary><see cref="StudyName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public StudyName ParentAsStudyName
        {
            get => string.IsNullOrEmpty(Parent) ? null : StudyName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class CreateTrialRequest
    {
        /// <summary><see cref="StudyName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public StudyName ParentAsStudyName
        {
            get => string.IsNullOrEmpty(Parent) ? null : StudyName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetTrialRequest
    {
        /// <summary>
        /// <see cref="gcav::TrialName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::TrialName TrialName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::TrialName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListTrialsRequest
    {
        /// <summary><see cref="StudyName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public StudyName ParentAsStudyName
        {
            get => string.IsNullOrEmpty(Parent) ? null : StudyName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class AddTrialMeasurementRequest
    {
        /// <summary>
        /// <see cref="gcav::TrialName"/>-typed view over the <see cref="TrialName"/> resource name property.
        /// </summary>
        public gcav::TrialName TrialNameAsTrialName
        {
            get => string.IsNullOrEmpty(TrialName) ? null : gcav::TrialName.Parse(TrialName, allowUnparsed: true);
            set => TrialName = value?.ToString() ?? "";
        }
    }

    public partial class CompleteTrialRequest
    {
        /// <summary>
        /// <see cref="gcav::TrialName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::TrialName TrialName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::TrialName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteTrialRequest
    {
        /// <summary>
        /// <see cref="gcav::TrialName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::TrialName TrialName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::TrialName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CheckTrialEarlyStoppingStateRequest
    {
        /// <summary>
        /// <see cref="gcav::TrialName"/>-typed view over the <see cref="TrialName"/> resource name property.
        /// </summary>
        public gcav::TrialName TrialNameAsTrialName
        {
            get => string.IsNullOrEmpty(TrialName) ? null : gcav::TrialName.Parse(TrialName, allowUnparsed: true);
            set => TrialName = value?.ToString() ?? "";
        }
    }

    public partial class StopTrialRequest
    {
        /// <summary>
        /// <see cref="gcav::TrialName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::TrialName TrialName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::TrialName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListOptimalTrialsRequest
    {
        /// <summary><see cref="StudyName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public StudyName ParentAsStudyName
        {
            get => string.IsNullOrEmpty(Parent) ? null : StudyName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }
}
