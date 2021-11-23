// Copyright 2021 Google LLC
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

using System;
using Xunit;
using static Google.Cloud.Compute.V1.ComputeEnumConstants.Address;

namespace Google.Cloud.Compute.V1.Snippets
{
    public class EnumSnippets
    {
        [Fact]
        public void Constants()
        {
            string addressName = "";
            string region = "";
            // Sample: EnumConstants
            Address addressResource = new Address
            {
                Name = addressName,
                Region = region,
                NetworkTier = ComputeEnumConstants.Address.NetworkTier.Premium
            };
            // End sample
            Assert.Equal("PREMIUM", addressResource.NetworkTier);
        }

        [Fact]
        public void FormatEnums()
        {
            string addressName = "";
            string region = "";
            // Sample: EnumHelpersFormat
            // This could be passed into a method as a parameter, for example.
            Address.Types.NetworkTier tier = Address.Types.NetworkTier.Premium;
            Address addressResource = new Address
            {
                Name = addressName,
                Region = region,
                NetworkTier = ComputeEnumHelpers.Format(tier)
            };
            // End sample
            Assert.Equal("PREMIUM", addressResource.NetworkTier);
        }

        [Fact]
        public void TryParseEnums()
        {
            Address addressResource = new Address
            {
                Name = "",
                Region = "",
                NetworkTier = ComputeEnumHelpers.Format(Address.Types.NetworkTier.Premium)
            };
            // Sample: EnumHelpersTryParse
            if (ComputeEnumHelpers.TryParse(addressResource.NetworkTier, out Address.Types.NetworkTier tier))
            {
                // The wire value was recognized, and tier contains the enum value.
                Console.WriteLine($"Network tier: {tier}");
            }
            // End sample
            Assert.Equal(Address.Types.NetworkTier.Premium, tier);
        }
    }
}
