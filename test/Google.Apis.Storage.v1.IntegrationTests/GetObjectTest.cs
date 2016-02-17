// Copyright 2015 Google Inc. All Rights Reserved.
// Licensed under the Apache License Version 2.0.

using Google.Apis.Storage.v1.ClientWrapper;
using System.Linq;
using Xunit;

namespace Google.Apis.Storage.v1.IntegrationTests
{
    public class GetObjectTest
    {
        private static readonly CloudConfiguration s_config = CloudConfiguration.Instance;
        private static readonly string s_bucket = s_config.TempBucketPrefix + "0";
        private const string s_name = "multiversion.txt";

        [Fact]
        public void Simple()
        {
            var obj = s_config.Client.GetObject(s_bucket, s_name);
            Assert.Equal(s_bucket, obj.Bucket);
            Assert.Equal(s_name, obj.Name);
            // Let's not be too sensitive as to exactly how big it is...
            Assert.True(obj.Size > 10);
            // Default doesn't get ACLs
            Assert.Null(obj.Acl);
        }

        [Fact]
        public void FullProjection()
        {
            var obj = s_config.Client.GetObject(s_bucket, s_name,
                new GetObjectOptions { Projection = ObjectsResource.GetRequest.ProjectionEnum.Full });
            Assert.Equal(s_bucket, obj.Bucket);
            Assert.Equal(s_name, obj.Name);
            // Let's not be too sensitive as to exactly how big it is...
            Assert.True(obj.Size > 10);
            Assert.NotEmpty(obj.Acl);
        }

        [Fact]
        public void SpecifyGeneration()
        {
            // Fetch them via the list operation to start with
            var objects = s_config.Client.ListObjects(s_bucket, s_name, new ListObjectsOptions { Versions = true }).ToList();

            Assert.Equal(2, objects.Count);
            // Fetch them by generation, and check that sizes match (but change by generation)
            var o1 = s_config.Client.GetObject(s_bucket, s_name, new GetObjectOptions { Generation = objects[0].Generation });
            var o2 = s_config.Client.GetObject(s_bucket, s_name, new GetObjectOptions { Generation = objects[1].Generation });

            Assert.Equal(objects[0].Size, o1.Size);
            Assert.Equal(objects[1].Size, o2.Size);
            Assert.NotEqual(o1.Size, o2.Size);
        }
    }
}
