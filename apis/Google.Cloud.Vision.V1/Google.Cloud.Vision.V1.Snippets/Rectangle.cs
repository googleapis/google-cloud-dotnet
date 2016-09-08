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

using System;

namespace Google.Cloud.Vision.V1.Snippets
{
    // TODO: Move this to the main project? Is it sufficiently general-purpose?
    public sealed class Rectangle
    {
        public double Left { get; }
        public double Top { get; }
        public double Bottom { get; }
        public double Right { get; }

        public Rectangle(double left, double top, double right, double bottom)
        {
            Left = left;
            Top = top;
            Right = right;
            Bottom = bottom;
        }

        public bool Equals(Rectangle other, double tolerance) =>
            other != null &&
            Math.Abs(other.Left - Left) <= tolerance &&
            Math.Abs(other.Top - Top) <= tolerance &&
            Math.Abs(other.Right - Right) <= tolerance &&
            Math.Abs(other.Bottom - Bottom) <= tolerance;

        /// <summary>
        /// Creates a <see cref="Rectangle"/> from a <see cref="BoundingPoly"/> if the bounding polygon
        /// has exactly four points which describe a rectangle, starting at the top-left and progressing
        /// clockwise. When these conditions are not met, the method returns <c>null</c>.
        /// </summary>
        /// <param name="poly">The polygon to convert.</param>
        /// <returns>A rectangle, or <c>null</c> if <paramref name="poly"/> is null or does
        /// not describe a rectangle starting at the top-left point, clockwise.</returns>
        public static Rectangle FromBoundingPoly(BoundingPoly poly)
        {
            if (poly == null)
            {
                return null;
            }
            var vertices = poly.Vertices;
            if (vertices.Count != 4)
            {
                return null;
            }
            if (vertices[0].Y == vertices[1].Y &&
                vertices[0].X <= vertices[1].X &&
                vertices[1].X == vertices[2].X &&
                vertices[1].Y <= vertices[2].Y &&
                vertices[2].Y == vertices[3].Y &&
                vertices[2].X >= vertices[3].X &&
                vertices[3].X == vertices[0].X &&
                vertices[3].Y >= vertices[0].Y)
            {
                return new Rectangle(vertices[0].X, vertices[0].Y, vertices[2].X, vertices[2].Y);
            }
            return null;
        }

        public override string ToString() => $"Rectangle: ({Left},{Top}) - ({Right},{Bottom})";
    }
}
