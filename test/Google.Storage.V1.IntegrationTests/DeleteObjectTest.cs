// Copyright 2015 Google Inc. All Rights Reserved.
// Licensed under the Apache License Version 2.0.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Object = Google.Apis.Storage.v1.Data.Object;
using static Google.Storage.V1.IntegrationTests.TestHelpers;
using Xunit;
using Google.Storage.V1;
using System.Net;

namespace Google.Storage.V1.IntegrationTests
{
    public class DeleteObjectTest
    {
        private static readonly CloudConfiguration s_config = CloudConfiguration.Instance;

        private static readonly string s_multiVersionBucket = s_config.TempBucketPrefix + "2";
        private static readonly string s_singleVersionBucket = s_config.TempBucketPrefix + "3";

        public static IEnumerable<object[]> BothBuckets => CreateTestData(s_multiVersionBucket, s_singleVersionBucket);

        [Fact]
        public void ImplicitLatestVersion_SingleVersionBucket()
        {
            var bucket = s_singleVersionBucket;
            var name = CreateObjects(bucket, 1)[0].Name;
            s_config.Client.DeleteObject(bucket, name);
            Assert.Empty(ListObjects(bucket, name, true));
        }

        [Fact]
        public void ImplicitLatestVersion_MultiVersionBucket()
        {
            var bucket = s_multiVersionBucket;
            var name = CreateObjects(bucket, 1)[0].Name;
            s_config.Client.DeleteObject(bucket, name);
            // Without asking for versions, we don't get anything
            Assert.Empty(ListObjects(bucket, name, false));
            // If we ask for versions, we get the deleted object
            var allVersions = ListObjects(bucket, name, true);
            Assert.Equal(1, allVersions.Count);
            Assert.NotNull(allVersions[0].TimeDeleted);
        }

        [Theory]
        [MemberData(nameof(BothBuckets))]
        public void SingleVersionObject_DeleteExplicitVersion(string bucket)
        {
            var obj = CreateObjects(bucket, 1)[0];
            s_config.Client.DeleteObject(obj, new DeleteObjectOptions { Generation = obj.Generation });
            Assert.Empty(ListObjects(obj, true));
        }

        [Theory]
        [MemberData(nameof(BothBuckets))]
        public void NonExistentObject(string bucket)
        {
            var exception = Assert.Throws<GoogleApiException>(() => s_config.Client.DeleteObject(bucket, GenerateName()));
            Assert.Equal(HttpStatusCode.NotFound, exception.HttpStatusCode);
        }

        [Theory]
        [MemberData(nameof(BothBuckets))]
        public void WrongGeneration(string bucket)
        {
            var obj = CreateObjects(bucket, 1)[0];
            var options = new DeleteObjectOptions { Generation = obj.Generation.Value + 1 };
            var exception = Assert.Throws<GoogleApiException>(() => s_config.Client.DeleteObject(obj, options));
            Assert.Equal(HttpStatusCode.NotFound, exception.HttpStatusCode);
        }

        [Theory]
        [MemberData(nameof(BothBuckets))]
        public void DeleteSameGenerationTwice(string bucket)
        {
            var obj = CreateObjects(bucket, 1)[0];
            var options = new DeleteObjectOptions { Generation = obj.Generation.Value };
            // First time is fine
            s_config.Client.DeleteObject(obj, options);
            // Second time throws an exception
            var exception = Assert.Throws<GoogleApiException>(() => s_config.Client.DeleteObject(obj, options));
            Assert.Equal(HttpStatusCode.NotFound, exception.HttpStatusCode);
        }

        [Fact]
        public void DeleteImplicitlyThenExplicitly()
        {
            var bucket = s_multiVersionBucket;
            var obj = CreateObjects(bucket, 1)[0];
            s_config.Client.DeleteObject(obj);
            s_config.Client.DeleteObject(obj, new DeleteObjectOptions { Generation = obj.Generation.Value });
            Assert.Empty(ListObjects(obj, true));
        }

        [Fact]
        public void MultipleVersionsCreated_SingleVersionBucket()
        {
            var bucket = s_singleVersionBucket;
            var obj = CreateObjects(bucket, 3)[0];
            s_config.Client.DeleteObject(obj);
            Assert.Empty(ListObjects(obj, true));
        }

        [Fact]
        public void MultipleVersionsCreated_MultiVersionBucket()
        {
            var bucket = s_multiVersionBucket;
            var objects = CreateObjects(bucket, 3);
            for (int i = 0; i < 3; i++)
            {
                var options = new DeleteObjectOptions { Generation = objects[i].Generation };
                s_config.Client.DeleteObject(objects[0], options);
                Assert.Equal(2 - i, ListObjects(objects[0], true).Count);
            }
        }

        private static List<Object> ListObjects(Object obj, bool versions)
        {
            return ListObjects(obj.Bucket, obj.Name, versions);
        }

        private static List<Object> ListObjects(string bucket, string name, bool versions)
        {
            // Use the same prefix as the name - filtering to be certain later.
            return s_config.Client.ListObjects(bucket, name, new ListObjectsOptions { Versions = versions })
                .Where(o => o.Name == name)
                .ToList();
        }

        private static List<Object> CreateObjects(string bucket, int versionCount)
        {
            string name = GenerateName();
            var objects = new List<Object>();
            for (int i = 0; i < versionCount; i++)
            {
                objects.Add(s_config.Client.UploadObject(bucket, name, "", GenerateData(i * 10)));
            }
            return objects;
        }
    }
}
