using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Google.Api.Gax.ResourceNames;
using Google.Cloud.ClientTesting;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Threading;
using Xunit;

namespace Google.Cloud.Storage.V2.IntegrationTests;
/// <summary>
/// Fixture which is set up at the start of the test run, and torn down at the end.
/// This creates new buckets with test data, and deletes them at the end of the test.
/// The Google Cloud Project name is fetched from the TEST_PROJECT environment variable.
/// </summary>

[CollectionDefinition(nameof(StorageFixture))]
[FileLoggerBeforeAfterTest]
public sealed class StorageFixture : CloudProjectFixtureBase, ICollectionFixture<StorageFixture>
{
    // The prefix to apply when generating the run-specific prefix. This must be allow-listed.
    // If the environment variable isn't set, or is empty, all tests will be skipped.
    private static string GlobalBucketPrefix { get; } = Environment.GetEnvironmentVariable("STORAGE_V2_TEST_BUCKET_PREFIX");

    private readonly List<BucketName> _bucketsToDelete = new();
    public string BucketPrefix { get; }
    public BucketName ReadWriteBucket => new BucketName(ProjectId, BucketPrefix + "readwrite");
    public ProjectName ProjectName => new ProjectName(ProjectId);
    public ProjectName GlobalProjectName { get; } = new ProjectName("_");

    public StorageClient Client { get; }
    public V1.StorageClient V1Client { get; }
    public bool Enabled => !string.IsNullOrEmpty(GlobalBucketPrefix);

    public StorageFixture()
    {
        // We don't want to fail tests if we don't haven't set the environment variable.
        if (!Enabled)
        {
            return;
        }

        // TODO: Work out why this has a retry...
        var settings = new StorageSettings
        {
            WriteObjectSettings = CallSettings.FromExpiration(Expiration.FromTimeout(TimeSpan.FromMilliseconds(60000)))
        };
        Client = new StorageClientBuilder { Settings = settings }.Build();
        V1Client = V1.StorageClient.Create();
        BucketPrefix = IdGenerator.FromDateTime(prefix: GlobalBucketPrefix + "-", suffix: "-"); 
        CreateBucket(ReadWriteBucket.BucketId);
    }

    internal Bucket CreateBucket(string bucketId)
    {
        var bucket = Client.CreateBucket(GlobalProjectName, new Bucket { ProjectAsProjectName = ProjectName }, bucketId);
        SleepAfterBucketCreateDelete();
        RegisterBucketToDelete(bucket.BucketName);
        return bucket;
    }

    internal string GenerateObjectName() => IdGenerator.FromGuid();

    internal string GenerateBucketName() => IdGenerator.FromGuid(prefix: BucketPrefix, separator: "", maxLength: 63);

    /// <summary>
    /// Bucket creation/deletion is rate-limited. To avoid making the tests flaky, we sleep after each operation.
    /// </summary>
    internal static void SleepAfterBucketCreateDelete() => Thread.Sleep(2000);

    internal void RegisterBucketToDelete(BucketName bucket) => _bucketsToDelete.Add(bucket);

    public override void Dispose()
    {
        var client = StorageClient.Create();
        foreach (var bucket in _bucketsToDelete)
        {
            DeleteBucket(client, bucket);
        }
    }

    private void DeleteBucket(StorageClient client, BucketName bucket)
    {
        try
        {
            foreach (var obj in client.ListObjects(bucket))
            {
                client.DeleteObject(bucket, obj.Name);
            }
            client.DeleteBucket(bucket);
        }
        catch (RpcException)
        {
            // Some tests fail to delete buckets due to object retention locks etc.
            // They can be cleaned up later.
        }
        SleepAfterBucketCreateDelete();
    }
}
