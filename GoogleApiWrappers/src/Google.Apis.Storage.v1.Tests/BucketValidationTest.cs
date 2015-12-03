// Copyright 2015 Google Inc. All Rights Reserved.
// Licensed under the Apache License Version 2.0.

using Google.Apis.Storage.v1.ClientWrapper;
using System;
using System.Threading.Tasks;
using Xunit;

namespace Google.Apis.Storage.v1.Tests
{
    public class BucketValidationTest
    {
        [Theory]
        [InlineData("justtext")]
        [InlineData("dots.dashes-and_underscores")]
        [InlineData("numbers012346789")]
        public void ValidBucketNames(string bucket)
        {
            StorageClient.ValidateBucket(bucket);
        }

        [Theory]
        [InlineData("")]
        [InlineData("UPPERCASE")]
        [InlineData("spaces in name")]
        [InlineData("invalid-punctuation1!")]
        [InlineData("invalid-punctuation2/")]
        [InlineData("invalid-punctuation3\\")]
        [InlineData("invalid-punctuation4\"")]
        [InlineData("invalid-punctuation5$")]
        [InlineData("invalid-punctuation6%")]
        public void InvalidBucketNames(string bucket)
        {
            var exception = Assert.ThrowsAny<ArgumentException>(() => StorageClient.ValidateBucket(bucket));
            Assert.Equal("bucket", exception.ParamName);
        }
    }
}
