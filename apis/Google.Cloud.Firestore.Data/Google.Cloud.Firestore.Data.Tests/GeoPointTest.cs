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
// limitations under the License.

using Google.Type;
using System;
using System.Globalization;
using Xunit;

namespace Google.Cloud.Firestore.Data.Tests
{
    public class GeoPointTest
    {
        [Fact]
        public void ToProto()
        {
            var point = new GeoPoint(15, 10);
            var expected = new LatLng { Latitude = 15, Longitude = 10 };
            Assert.Equal(expected, point.ToProto());
        }

        [Fact]
        public void FromProto()
        {
            var proto = new LatLng { Latitude = 15, Longitude = 10 };
            var expected = new GeoPoint(15, 10);
            Assert.Equal(expected, GeoPoint.FromProto(proto));
        }

        [Theory]
        [InlineData(-90.1, 0)]
        [InlineData(90.1, 0)]
        [InlineData(0, -180.1)]
        [InlineData(0, 180.1)]
        public void Construction_Invalid(double latitude, double longitude)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new GeoPoint(latitude, longitude));
        }

        [Theory]
        [InlineData(-90, -180)]
        [InlineData(90, 180)]
        [InlineData(1.5, 2.5)]
        public void Construction_Valid(double latitude, double longitude)
        {
            var point = new GeoPoint(latitude, longitude);
            Assert.Equal(latitude, point.Latitude);
            Assert.Equal(longitude, point.Longitude);
        }

        [Fact]
        public void Equality()
        {
            GeoPoint g1 = new GeoPoint(1.5, 2.5);
            // Equal
            GeoPoint g2 = new GeoPoint(1.5, 2.5);
            // Difference in latitude
            GeoPoint g3 = new GeoPoint(2.5, 2.5);
            // Difference in longitude
            GeoPoint g4 = new GeoPoint(1.5, 3.5);

            // Equals(GeoPoint)
            Assert.True(g1.Equals(g2));
            Assert.False(g1.Equals(g3));
            Assert.False(g1.Equals(g4));

            // Equals(object)
            Assert.True(g1.Equals((object) g2));
            Assert.False(g1.Equals((object) g3));
            Assert.False(g1.Equals((object) g4));

            Assert.True(g1 == g2);
            Assert.False(g1 == g3);
            Assert.False(g1 == g4);
            Assert.False(g1 == null);

            Assert.False(g1 != g2);
            Assert.True(g1 != g3);
            Assert.True(g1 != g4);
            Assert.True(g1 != null);

            Assert.Equal(g1.GetHashCode(), g2.GetHashCode());
            Assert.NotEqual(g1.GetHashCode(), g3.GetHashCode());
            Assert.NotEqual(g1.GetHashCode(), g4.GetHashCode());
        }

        [Fact]
        public void DefaultValueIsOrigin()
        {
            GeoPoint point = default;
            Assert.Equal(0, point.Latitude);
            Assert.Equal(0, point.Longitude);
        }

        [Fact]
        public void Formatting()
        {
            var point = new GeoPoint(3.5, -12.25);
            CultureInfo savedCulture = CultureInfo.CurrentCulture;
            try
            {
                CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.InvariantCulture;
                Assert.Equal("GeoPoint: Latitude=3.5; Longitude=-12.25", point.ToString());
            }
            finally
            {
                CultureInfo.DefaultThreadCurrentUICulture = savedCulture;
            }

        }
    }
}
