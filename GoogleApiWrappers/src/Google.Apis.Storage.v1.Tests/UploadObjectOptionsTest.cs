// Copyright 2015 Google Inc. All Rights Reserved.
// Licensed under the Apache License Version 2.0.

using Google.Apis.Storage.v1.ClientWrapper;
using System;
using Xunit;

namespace Google.Apis.Storage.v1.Tests
{
    public class UploadObjectOptionsTest
    {
        [Theory]
        [InlineData(UploadObjectOptions.MinimumChunkSize)]
        [InlineData(UploadObjectOptions.MinimumChunkSize * 2)]
        [InlineData(UploadObjectOptions.MinimumChunkSize * 1000)]
        public void ValidChunkSize(int chunkSize)
        {
            // ToString call used as a constructor call isn't a statement expression
            new UploadObjectOptions { ChunkSize = chunkSize }.ToString();
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-UploadObjectOptions.MinimumChunkSize)]
        [InlineData(UploadObjectOptions.MinimumChunkSize / 2)]
        public void InvalidChunkSize(int chunkSize)
        {
            // ToString call used as a constructor call isn't a statement expression
            Assert.Throws<ArgumentException>(() => new UploadObjectOptions { ChunkSize = chunkSize }.ToString());
        }
    }
}
