// Copyright 2016 Google Inc. All Rights Reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System.Collections.Generic;
using System.Net;
using System.Net.NetworkInformation;

namespace Google.Cloud.Metadata.V1
{
    /// <summary>
    /// Metadata for a network interface in a Google Compute Engine VM instance.
    /// </summary>
    /// <seealso cref="InstanceMetadata.NetworkInterfaces"/>
    public sealed class NetworkInterfaceMetadata
    {
        /// <summary>
        /// Gets the collection of access configurations for the network interface.
        /// </summary>
        public IReadOnlyList<AccessConfigurationMetadata> AccessConfigurations { get; }

        /// <summary>
        /// Gets the collection of external IP addresses served by forwarding rules pointing to this instance.
        /// </summary>
        /// <seealso cref="AccessConfigurationMetadata.ExternalIPAddress"/>
        public IReadOnlyList<IPAddress> ForwardedIPAddresss { get; }

        /// <summary>
        /// Gets the IP address for this instance on the network.
        /// </summary>
        public IPAddress IPAddress { get; }

        // TODO: These are IPv4 ranges in CIDR format. I don't think there's a standard type that represents this. We may want to create one.
        /// <summary>
        /// Gets the alias IP ranges assigned to this instance on the network, in CIDR format.
        /// </summary>
        public IReadOnlyList<string> IPAddressAliases { get; }

        /// <summary>
        /// Gets the MAC address of the instance.
        /// </summary>
        public PhysicalAddress MacAddress { get; }

        /// <summary>
        /// Gets the partial URL of the network resource for this interface.
        /// </summary>
        /// <remarks>
        /// The partial URLs are relative to https://www.googleapis.com/compute/v1/.
        /// An example of a network path is "projects/12345/networks/default".
        /// </remarks>
        public string NetworkPath { get; }
    }
}
