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
using gcbbv = Google.Cloud.Billing.Budgets.V1Beta1;

namespace Google.Cloud.Billing.Budgets.V1Beta1
{
    public partial class CreateBudgetRequest
    {
        /// <summary>
        /// <see cref="gagr::BillingAccountName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::BillingAccountName ParentAsBillingAccountName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::BillingAccountName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetBudgetRequest
    {
        /// <summary>
        /// <see cref="gcbbv::BudgetName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbbv::BudgetName BudgetName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbbv::BudgetName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListBudgetsRequest
    {
        /// <summary>
        /// <see cref="gagr::BillingAccountName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::BillingAccountName ParentAsBillingAccountName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::BillingAccountName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteBudgetRequest
    {
        /// <summary>
        /// <see cref="gcbbv::BudgetName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbbv::BudgetName BudgetName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbbv::BudgetName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
