# Google Cloud Libraries for .NET
.NET idiomatic client libraries for [Google Cloud Platform][cloud-platform] services.

[![Build Status](https://travis-ci.org/GoogleCloudPlatform/google-cloud-dotnet.svg?branch=master)](https://travis-ci.org/GoogleCloudPlatform/google-cloud-dotnet)

* [Homepage][language-landing-dotnet]
* [API Documentation][api-reference-dotnet]

The Google Cloud Libraries for .NET support the following Google Cloud Platform services:

* [Google BigQuery](#google-bigquery)
* [Google Cloud Datastore](#google-cloud-datastore)
* [Google Cloud Logging](#google-cloud-logging)
* [Google Cloud Pub/Sub](#google-cloud-pubsub)
* [Google Cloud Storage](#google-cloud-storage)

> Note: This client is a work-in-progress, and may occasionally
> make backwards-incompatible changes. The layout of the repository
> is likely to change, and names (of everything - assemblies,
> namespaces, types, members...) should be regarded as provisional.

If you need support for other Google APIs, check out the [Google .NET API Client library][google-api-dotnet-client].

## Example Applications

* [getting-started-dotnet] - A [quickstart and tutorial][language-landing-dotnet] that demonstrates how to build a complete web application using Cloud Datastore, Cloud Storage, and Cloud Pub/Sub and deploy it to Google Compute Engine.

## Requirements

In order to build the code in this repository, you will need
to [install DNVM][dnvm]. You do not need DNVM to use the code,
which is provided as NuGet packages.

## Specifying a Project ID

Most Google Cloud Libraries for .NET require a project ID. If you don't remember yours (or haven't created a project yet), navigate to the [Google Developers Console][google-developers-console] to view your project ID (or create a new project and then get the ID). Once done, record the value and make sure to pass it as a parameter to the methods that require it.

## Authentication
Every API call needs to be authenticated. In order to successfully make a call, first ensure that the necessary [Google Cloud APIs][cloud-api-enablement] are enabled for your project and that you've downloaded the right set of keys (if it applies to you) as explained in the [authentication document][cloud-common-authentication].

Next, choose a method for authenticating API requests from within your project:

1. When using `google-cloud-dotnet` libraries from within Compute/App Engine, no additional authentication steps are necessary.
2. When using `google-cloud-dotnet` libraries elsewhere, you can do one of the following:
    * Define the environment variable GOOGLE_APPLICATION_CREDENTIALS to be the location of the key.  For example:

      ```
      set GOOGLE_APPLICATION_CREDENTIALS=/path/to/my/key.json
      ``` 
    * If running locally for development/testing, you can authenticate using the [Google Cloud SDK][google-cloud-sdk].  Download the SDK if you haven't already, then login by running the following in the command line:

      ```
      gcloud auth login
      ```

## Google BigQuery

- [API Reference][cloud-bigquery-ref]
- [API Overview][cloud-bigquery-docs]

The BigQuery client library is in pre-release state and is more likely to have significant surface changes over time. Still, if you would like to experiment with it, we would welcome your feedback.

#### Installation
The package is available on [NuGet](https://www.nuget.org/packages/Google.Bigquery.V2) and can be installed in the following manner:

```sh
PM> Install-Package Google.Bigquery.V2 -Prerelease
```

#### Example

```c#
using Google.Bigquery.V2;
...

var client = BigqueryClient.Create(projectId);

// Create the dataset if it doesn't exist.
var dataset = client.GetOrCreateDataset("mydata");

// Create the table if it doesn't exist.
var table = dataset.GetOrCreateTable("scores", new SchemaBuilder
{
    { "player", SchemaFieldType.String },
    { "gameStarted", SchemaFieldType.Timestamp },
    { "score", SchemaFieldType.Integer }
}.Build());

// Insert a single row. There are many other ways of inserting
// data into a table.
table.InsertRow(new Dictionary<string, object>
{
    { "player", "Bob" },
    { "score", 85 },
    { "gameStarted", new DateTime(2000, 1, 14, 10, 30, 0, DateTimeKind.Utc) }
});
```

## Google Cloud Datastore

- [API Reference][cloud-datastore-ref]
- [API Overview][cloud-datastore-docs]

#### Installation
The package is available on [NuGet](https://www.nuget.org/packages/Google.Datastore.V1Beta3) and can be installed in the following manner:

```sh
PM> Install-Package Google.Datastore.V1Beta3 -Prerelease
```

#### Examples

Inserting data:

```c#
using Google.Datastore.V1Beta3;
...

var db = DatastoreDb.Create(projectId, namespaceId);

var keyFactory = db.CreateKeyFactory("message");
var entity = new Entity
{
    Key = keyFactory.CreateIncompleteKey(),
    ["created"] = DateTime.UtcNow,
    ["text"] = "Text of the message"
};
using (var transaction = db.BeginTransaction())
{
    transaction.Insert(entity);
    var commitResponse = transaction.Commit();
    var insertedKey = commitResponse.MutationResults[0].Key;
}
```

Querying data:

```c#
using Google.Datastore.V1Beta3;
...

DatastoreDb db = DatastoreDb.Create(projectId, namespaceId);

// Print the messages created in the last 5 minutes, most recent first
DateTime cutoff = DateTime.UtcNow.AddMinutes(-5);
Query query = new Query("message")
{
    Filter = Filter.GreaterThanOrEqual("created", cutoff),
    Order = { { "created", Direction.Descending } }
};
foreach (Entity entity in db.RunQuery(query))
{
    DateTime created = (DateTime)entity["created"];
    string text = (string)entity["text"];
    Console.WriteLine($"{created:yyyy-MM-dd'T'HH:mm:ss}: {text}");
}
```

## Google Cloud Logging

- [API Reference][cloud-logging-ref]
- [API Overview][cloud-logging-docs]

#### Installation

The package is available on [NuGet](https://www.nuget.org/packages/Google.Logging.V2) and can be installed in the following manner:

```sh
PM> Install-Package Google.Logging.V2 -Prerelease
```

#### Example

```c#
using Google.Logging.V2;
...

Code coming soon
```

## Google Cloud Pub/Sub

- [API Reference][cloud-pubsub-ref]
- [API Overview][cloud-pubsub-docs]

#### Installation

The package is available on [NuGet](https://www.nuget.org/packages/Google.Pubsub.V1) and can be installed in the following manner:

```sh
PM> Install-Package Google.Pubsub.V1 -Prerelease
```

#### Example

```c#
using Google.Pubsub.V1;
...

// First create a topic.
PublisherClient publisher = PublisherClient.Create();
string topicName = PublisherClient.FormatTopicName(projectId, topicId);
publisher.CreateTopic(topicName);

// Subscribe to the topic.
SubscriberClient subscriber = SubscriberClient.Create();
string subscriptionName = SubscriberClient.FormatSubscriptionName(projectId, subscriptionId);
subscriber.CreateSubscription(subscriptionName, topicName, pushConfig: null, ackDeadlineSeconds: 60);

// Publish a message to the topic.
PubsubMessage message = new PubsubMessage
{
    // The data is any arbitrary ByteString. Here, we're using text.
    Data = ByteString.CopyFromUtf8("Hello, Pubsub"),
    // The attributes provide metadata in a string-to-string dictionary.
    Attributes =
    {
        { "description", "Simple text message" }
    }
};
publisher.Publish(topicName, new[] { message });

// Pull messages from the subscription. We're returning immediately, whether or not there
// are messages; in other cases you'll want to allow the call to wait until a message arrives.
PullResponse response = subscriber.Pull(subscriptionName, returnImmediately: true, maxMessages: 10);
foreach (ReceivedMessage received in response.ReceivedMessages)
{
    PubsubMessage msg = received.Message;
    Console.WriteLine($"Received message {msg.MessageId} published at {msg.PublishTime.ToDateTime()}");
    Console.WriteLine($"Text: '{msg.Data.ToStringUtf8()}'");
}

// Acknowledge that we've received the messages. If we don't do this within 60 seconds (as specified
// when we created the subscription) we'll receive the messages again when we next pull.
subscriber.Acknowledge(subscriptionName, response.ReceivedMessages.Select(m => m.AckId));

// Tidy up by deleting the subscription and the topic.
subscriber.DeleteSubscription(subscriptionName);
publisher.DeleteTopic(topicName);
```

## Google Cloud Storage

- [API Reference][cloud-storage-ref]
- [API Overview][cloud-storage-docs]

#### Installation
The package is available on [NuGet](https://www.nuget.org/packages/Google.Storage.V1) and can be installed in the following manner:

```sh
PM> Install-Package Google.Storage.V1 -Prerelease
```

#### Example

```c#
using Google.Storage.V1;
...

var client = StorageClient.Create();

// Create a bucket
var bucketName = Guid.NewGuid().ToString(); // must be globally unique
var bucket = client.CreateBucket(projectId, bucketName);

// Upload some files
var content = Encoding.UTF8.GetBytes("hello, world");
var obj1 = client.UploadObject(bucketName, "file1.txt", "text/plain", new MemoryStream(content));
var obj2 = client.UploadObject(bucketName, "folder1/file2.txt", "text/plain", new MemoryStream(content));

// List objects
foreach (var obj in client.ListObjects(bucketName, ""))
{
    Console.WriteLine(obj.Name);
}

// Download file
using (var stream = File.OpenWrite("file1.txt"))
{
    client.DownloadObject(bucketName, "file1.txt", stream);
}
```

## Contributing

Contributions to this library are always welcome and highly encouraged.

See [CONTRIBUTING] for more information on how to get started.

## Versioning

The Google Cloud Client Libraries for .NET follow [Semantic Versioning](http://semver.org/).

Anything with a major version of zero (`0.y.z`) should not be
considered stable - anything may change at any time.

Anything with a suffix after the three numbers (such as `1.0.0-beta01`) is expected to work,
but further API changes may occur before the next stable release.

## License

Apache 2.0 - See [LICENSE] for more information.


[CONTRIBUTING]: ./CONTRIBUTING.md
[LICENSE]: ./LICENSE
[cloud-platform]: https://cloud.google.com/
[language-landing-dotnet]: https://cloud.google.com/dotnet/
[api-reference-dotnet]: http://googlecloudplatform.github.io/google-cloud-dotnet/
[google-api-dotnet-client]: https://github.com/google/google-api-dotnet-client
[getting-started-dotnet]: https://github.com/GoogleCloudPlatform/getting-started-dotnet/
[cloud-api-enablement]:  https://console.developers.google.com/apis/library/
[cloud-common-authentication]: https://github.com/GoogleCloudPlatform/gcloud-common/blob/master/authentication/readme.md#authentication
[google-developers-console]: https://console.developers.google.com/project
[google-cloud-sdk]: https://cloud.google.com/sdk/
[google-download-sdk]: https://cloud.google.com/sdk/docs/
[google-myget-feed]: https://www.myget.org/gallery/google-dotnet-public/
[cloud-bigquery-ref]: http://googlecloudplatform.github.io/google-cloud-dotnet/api/Google.Bigquery.V2.html
[cloud-datastore-ref]: http://googlecloudplatform.github.io/google-cloud-dotnet/api/Google.Datastore.V1Beta3.html
[cloud-logging-ref]: http://googlecloudplatform.github.io/google-cloud-dotnet/api/Google.Logging.V2.html
[cloud-pubsub-ref]: http://googlecloudplatform.github.io/google-cloud-dotnet/api/Google.Pubsub.V1.html
[cloud-storage-ref]: http://googlecloudplatform.github.io/google-cloud-dotnet/api/Google.Storage.V1.html
[cloud-bigquery-docs]: https://cloud.google.com/bigquery/
[cloud-datastore-docs]: https://cloud.google.com/datastore/
[cloud-logging-docs]: https://cloud.google.com/logging/
[cloud-pubsub-docs]: https://cloud.google.com/pubsub/
[cloud-storage-docs]: https://cloud.google.com/storage/
[dnvm]: http://docs.asp.net/en/latest/getting-started/index.html
[gRPC]: http://grpc.io
