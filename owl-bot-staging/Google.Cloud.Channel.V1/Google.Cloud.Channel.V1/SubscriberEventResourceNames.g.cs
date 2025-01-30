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

namespace Google.Cloud.Channel.V1
{
    public partial class CustomerEvent
    {
        /// <summary>
        /// <see cref="CustomerName"/>-typed view over the <see cref="Customer"/> resource name property.
        /// </summary>
        public CustomerName CustomerAsCustomerName
        {
            get => string.IsNullOrEmpty(Customer) ? null : CustomerName.Parse(Customer, allowUnparsed: true);
            set => Customer = value?.ToString() ?? "";
        }
    }

    public partial class EntitlementEvent
    {
        /// <summary>
        /// <see cref="EntitlementName"/>-typed view over the <see cref="Entitlement"/> resource name property.
        /// </summary>
        public EntitlementName EntitlementAsEntitlementName
        {
            get => string.IsNullOrEmpty(Entitlement) ? null : EntitlementName.Parse(Entitlement, allowUnparsed: true);
            set => Entitlement = value?.ToString() ?? "";
        }
    }
}
