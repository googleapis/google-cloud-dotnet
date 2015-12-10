// Copyright 2015 Google Inc. All Rights Reserved.
// Licensed under the Apache License Version 2.0.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;

namespace Google.Apis.Storage.v1.IntegrationTests
{
    internal static class TestHelpers
    {
        /// <summary>
        /// Generates an object name which can reasonably be expected to be unique.
        /// </summary>
        internal static string GenerateName()
        {
            return Guid.NewGuid().ToString();
        }

        /// <summary>
        /// Generates a read-only stream of random data of the given size. The
        /// returned stream is positioned at the start of the data.
        /// </summary>
        internal static MemoryStream GenerateData(int size)
        {
            var rng = RandomNumberGenerator.Create();
            byte[] data = new byte[size];
            rng.GetBytes(data);
            return new MemoryStream(data);
        }

        /// <summary>
        /// Helper method for MemberDataAttribute, which required that the member is compatible
        /// with IEnumerable{object[]}, unhelpfully :(
        /// </summary>
        internal static IEnumerable<object[]> CreateTestData<T>(params T[] values)
        {
            return values.Select(x => new object[] { x });
        }
    }
}
