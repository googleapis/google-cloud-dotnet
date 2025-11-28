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
using gaesv = Google.Apps.Events.Subscriptions.V1Beta;

namespace Google.Apps.Events.Subscriptions.V1Beta
{
    public partial class DeleteSubscriptionRequest
    {
        /// <summary>
        /// <see cref="gaesv::SubscriptionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaesv::SubscriptionName SubscriptionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaesv::SubscriptionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetSubscriptionRequest
    {
        /// <summary>
        /// <see cref="gaesv::SubscriptionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaesv::SubscriptionName SubscriptionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaesv::SubscriptionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ReactivateSubscriptionRequest
    {
        /// <summary>
        /// <see cref="gaesv::SubscriptionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaesv::SubscriptionName SubscriptionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaesv::SubscriptionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
