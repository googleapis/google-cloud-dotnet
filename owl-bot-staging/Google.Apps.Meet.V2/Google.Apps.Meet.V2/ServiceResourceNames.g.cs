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
using gamv = Google.Apps.Meet.V2;

namespace Google.Apps.Meet.V2
{
    public partial class GetSpaceRequest
    {
        /// <summary>
        /// <see cref="gamv::SpaceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gamv::SpaceName SpaceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gamv::SpaceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class EndActiveConferenceRequest
    {
        /// <summary>
        /// <see cref="gamv::SpaceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gamv::SpaceName SpaceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gamv::SpaceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetConferenceRecordRequest
    {
        /// <summary>
        /// <see cref="gamv::ConferenceRecordName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gamv::ConferenceRecordName ConferenceRecordName
        {
            get => string.IsNullOrEmpty(Name) ? null : gamv::ConferenceRecordName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetParticipantRequest
    {
        /// <summary>
        /// <see cref="gamv::ParticipantName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gamv::ParticipantName ParticipantName
        {
            get => string.IsNullOrEmpty(Name) ? null : gamv::ParticipantName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListParticipantsRequest
    {
        /// <summary>
        /// <see cref="ConferenceRecordName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ConferenceRecordName ParentAsConferenceRecordName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ConferenceRecordName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetParticipantSessionRequest
    {
        /// <summary>
        /// <see cref="gamv::ParticipantSessionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gamv::ParticipantSessionName ParticipantSessionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gamv::ParticipantSessionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListParticipantSessionsRequest
    {
        /// <summary>
        /// <see cref="ParticipantName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ParticipantName ParentAsParticipantName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ParticipantName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetRecordingRequest
    {
        /// <summary>
        /// <see cref="gamv::RecordingName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gamv::RecordingName RecordingName
        {
            get => string.IsNullOrEmpty(Name) ? null : gamv::RecordingName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListRecordingsRequest
    {
        /// <summary>
        /// <see cref="ConferenceRecordName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ConferenceRecordName ParentAsConferenceRecordName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ConferenceRecordName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetTranscriptRequest
    {
        /// <summary>
        /// <see cref="gamv::TranscriptName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gamv::TranscriptName TranscriptName
        {
            get => string.IsNullOrEmpty(Name) ? null : gamv::TranscriptName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListTranscriptsRequest
    {
        /// <summary>
        /// <see cref="ConferenceRecordName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ConferenceRecordName ParentAsConferenceRecordName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ConferenceRecordName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetTranscriptEntryRequest
    {
        /// <summary>
        /// <see cref="gamv::TranscriptEntryName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gamv::TranscriptEntryName TranscriptEntryName
        {
            get => string.IsNullOrEmpty(Name) ? null : gamv::TranscriptEntryName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListTranscriptEntriesRequest
    {
        /// <summary>
        /// <see cref="TranscriptName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public TranscriptName ParentAsTranscriptName
        {
            get => string.IsNullOrEmpty(Parent) ? null : TranscriptName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }
}
