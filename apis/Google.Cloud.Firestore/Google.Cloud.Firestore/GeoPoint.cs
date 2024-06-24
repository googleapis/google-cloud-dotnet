// Copyright 2017, Google Inc. All rights reserved.
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
// limitations under the License.using System;

using Google.Api.Gax;
using Google.Type;
using System;
using System.Runtime.InteropServices;

namespace Google.Cloud.Firestore
{
    // Note: the explicit struct layout is due to a JIT bug in .NET Core 1.x on Linux.
    // See https://codeblog.jonskeet.uk/2017/10/08/diagnosing-a-linux-only-unit-test-failure/
    // for details.

    /// <summary>
    /// Immutable struct representing a geographic location in Firestore.
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public struct GeoPoint : IEquatable<GeoPoint>
    {
        // Specify field offsets explicitly to work around .NET Core 1.0 bug.
        // (Trying to find a reference issue to make sure the fix is okay,
        // and isn't needed elsewhere.)
        // We can't currently apply a field attribute to an automatically
        // implemented property, so it's all explicit now.
        [field: FieldOffset(0)]
        private readonly double _latitude;
        [field: FieldOffset(8)]
        private readonly double _longitude;

        /// <summary>
        /// The latitude, in degrees, in the range -90 to 90 inclusive.
        /// </summary>
        public double Latitude => _latitude;
        /// <summary>
        /// The longitude, in degrees, in the range -180 to 180 inclusive.
        /// </summary>
        public double Longitude => _longitude;

        /// <summary>
        /// Creates a new value using the provided latitude and longitude values.
        /// </summary>
        /// <param name="latitude">The latitude of the point in degrees, between -90 and 90 inclusive.</param>
        /// <param name="longitude">The longitude of the point in degrees, between -180 and 180 inclusive.</param>
        public GeoPoint(double latitude, double longitude)
        {
            _latitude = GaxPreconditions.CheckArgumentRange(latitude, nameof(latitude), -90d, 90d);
            _longitude = GaxPreconditions.CheckArgumentRange(longitude, nameof(longitude), -180d, 180d);
        }

        /// <summary>
        /// Creates a Protobuf <see cref="LatLng"/> representation of this
        /// point. Modifications to the returned message will not be reflected in this object.
        /// </summary>
        /// <returns>A Protobuf location representation.</returns>
        public LatLng ToProto() => new LatLng { Latitude = Latitude, Longitude = Longitude };

        /// <summary>
        /// Creates an instance from a Protobuf <see cref="LatLng"/> representation.
        /// Later modifications to the Protobuf representation will not affect the returned object.
        /// </summary>
        /// <param name="proto">A Protobuf location representation.</param>
        /// <returns>A new <see cref="GeoPoint"/> value.</returns>
        public static GeoPoint FromProto(LatLng proto)
        {
            GaxPreconditions.CheckNotNull(proto, nameof(proto));
            return new GeoPoint(proto.Latitude, proto.Longitude);
        }

        /// <inheritdoc />
        public override bool Equals(object obj) => obj is GeoPoint gp && Equals(gp);

        /// <inheritdoc />
        public override int GetHashCode() => GaxEqualityHelpers.CombineHashCodes(Latitude.GetHashCode(), Longitude.GetHashCode());

        /// <inheritdoc />
        public bool Equals(GeoPoint other) => Latitude == other.Latitude && Longitude == other.Longitude;

        /// <summary>
        /// Operator overload to compare two GeoPoint values for equality.
        /// </summary>
        /// <param name="lhs">Left value to compare</param>
        /// <param name="rhs">Right value to compare</param>
        /// <returns>true if <paramref name="lhs"/> is equal to <paramref name="rhs"/>; otherwise false.</returns>
        public static bool operator ==(GeoPoint lhs, GeoPoint rhs) => lhs.Equals(rhs);

        /// <summary>
        /// Operator overload to compare two GeoPoint values for inequality.
        /// </summary>
        /// <param name="lhs">Left value to compare</param>
        /// <param name="rhs">Right value to compare</param>
        /// <returns>false if <paramref name="lhs"/> is equal to <paramref name="rhs"/>; otherwise true.</returns>
        public static bool operator !=(GeoPoint lhs, GeoPoint rhs) => !lhs.Equals(rhs);

        /// <inheritdoc />
        public override string ToString() => $"GeoPoint: Latitude={Latitude}; Longitude={Longitude}";
    }
}
