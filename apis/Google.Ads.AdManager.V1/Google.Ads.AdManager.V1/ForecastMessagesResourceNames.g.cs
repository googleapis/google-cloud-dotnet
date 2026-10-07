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
using gax = Google.Api.Gax;

namespace Google.Ads.AdManager.V1
{
    public partial class AvailabilityForecast
    {
        /// <summary>
        /// <see cref="LineItemName"/>-typed view over the <see cref="LineItem"/> resource name property.
        /// </summary>
        public LineItemName LineItemAsLineItemName
        {
            get => string.IsNullOrEmpty(LineItem) ? null : LineItemName.Parse(LineItem, allowUnparsed: true);
            set => LineItem = value?.ToString() ?? "";
        }

        /// <summary><see cref="OrderName"/>-typed view over the <see cref="Order"/> resource name property.</summary>
        public OrderName OrderAsOrderName
        {
            get => string.IsNullOrEmpty(Order) ? null : OrderName.Parse(Order, allowUnparsed: true);
            set => Order = value?.ToString() ?? "";
        }
    }

    public partial class DeliveryForecastOptions
    {
        /// <summary>
        /// <see cref="LineItemName"/>-typed view over the <see cref="IgnoredLineItems"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<LineItemName> IgnoredLineItemsAsLineItemNames
        {
            get => new gax::ResourceNameList<LineItemName>(IgnoredLineItems, s => string.IsNullOrEmpty(s) ? null : LineItemName.Parse(s, allowUnparsed: true));
        }
    }

    public partial class ContendingLineItem
    {
        /// <summary>
        /// <see cref="LineItemName"/>-typed view over the <see cref="LineItem"/> resource name property.
        /// </summary>
        public LineItemName LineItemAsLineItemName
        {
            get => string.IsNullOrEmpty(LineItem) ? null : LineItemName.Parse(LineItem, allowUnparsed: true);
            set => LineItem = value?.ToString() ?? "";
        }
    }

    public partial class LineItemDeliveryForecast
    {
        /// <summary>
        /// <see cref="LineItemName"/>-typed view over the <see cref="LineItem"/> resource name property.
        /// </summary>
        public LineItemName LineItemAsLineItemName
        {
            get => string.IsNullOrEmpty(LineItem) ? null : LineItemName.Parse(LineItem, allowUnparsed: true);
            set => LineItem = value?.ToString() ?? "";
        }

        /// <summary><see cref="OrderName"/>-typed view over the <see cref="Order"/> resource name property.</summary>
        public OrderName OrderAsOrderName
        {
            get => string.IsNullOrEmpty(Order) ? null : OrderName.Parse(Order, allowUnparsed: true);
            set => Order = value?.ToString() ?? "";
        }
    }

    public partial class ExistingLineItemList
    {
        /// <summary>
        /// <see cref="LineItemName"/>-typed view over the <see cref="LineItems"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<LineItemName> LineItemsAsLineItemNames
        {
            get => new gax::ResourceNameList<LineItemName>(LineItems, s => string.IsNullOrEmpty(s) ? null : LineItemName.Parse(s, allowUnparsed: true));
        }
    }
}
