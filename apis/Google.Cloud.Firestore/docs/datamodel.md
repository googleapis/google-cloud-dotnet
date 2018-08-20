# Data model

The Firestore data model revolves around *documents* and *collections*.

Collections contain documents, which can contain more collections. The document data itself doesn't contain subcollections,
although it can contain nested data.

The Firestore library for .NET provides multiple options for working with Firestore data.
It aims to make it simple for you to work with the data, whether you're creating, updating or querying it.

This page is primarily aimed at explaining how document data can be used with the .NET library. See
the [user guide](userguide.md) for more details around the relationship between documents and collections.

# Data types

A document is essentially a map, from field names to field values. Firestore supports multiple types of data for fields.
For interoperability, some Firestore data types map onto multiple .NET types. The table below shows these types, and the default .NET
type that a value will be deserialized as, when no other information is available.

<table>
  <thead>
  	<tr>
  	  <th>Firestore data type</th>
  	  <th>.NET supported types</th>
  	  <th>Default type</th>
  	  <th>Notes</th>
  	</tr>
  </thead>
  <tbody>
  	<tr>
      <td>Array</td>
      <td>Any <code>IEnumerable&lt;T&gt;</code></td>
      <td><code>List&lt;object&gt;</code></td>
      <td>Array elements cannot themselves be arrays</td>
  	</tr>
  	<tr>
      <td>Boolean</td>
      <td><code>bool</code></td>
      <td><code>bool</code></td>
      <td></td>
  	</tr>
  	<tr>
      <td>Bytes</td>
      <td>
        <code>[Google.Cloud.Firestore.Blob](obj/api/Google.Cloud.Firestore.Blob.yml)</code><br />
        <code>byte[]</code><br />
        <code>Google.Protobuf.ByteString</code>
      </td>
      <td><code>Google.Cloud.Firestore.Blob</code></td>
      <td>Up to 1,048,487 bytes (1 MiB - 89 bytes). Only the first 1,500 bytes are considered by queries.</td>
  	</tr>
  	<tr>
      <td>Date and time</td>
      <td>
        <code>[Google.Cloud.Firestore.Timestamp](obj/api/Google.Cloud.Firestore.Timestamp.yml)</code><br />
        <code>System.DateTime</code><br />
        <code>System.DateTimeOffset</code><br />
        <code>Google.Protobuf.WellKnownTypes.Timestamp</code>
      </td>
      <td><code>Google.Cloud.Firestore.Timestamp</code></td>
      <td>When stored in Cloud Firestore, precise only to microseconds; any additional precision is rounded down. <code>DateTime</code>
        values must have a <code>Kind</code> of <code>Utc</code> to be converted; <code>DateTimeOffset</code> values are converted
        to UTC automatically, and the offset information is discarded.</td>
  	</tr>
  	<tr>
      <td>Floating-point number</td>
      <td><code>double</code>, <code>float</code></td>
      <td><code>double</code></td>
      <td>64-bit double precision, IEEE 754.</td>
  	</tr>
  	<tr>
      <td>Geographical point</td>
      <td>
        <code>[Google.Cloud.Firestore.GeoPoint](obj/api/Google.Cloud.Firestore.GeoPoint.yml)</code><br />
        <code>Google.Type.LatLng</code>
      </td>
      <td><code>Google.Cloud.Firestore.GeoPoint</code></td>
      <td></td>
  	</tr>
  	<tr>
      <td>Integer</td>
      <td>Any integer type (<code>byte</code>, <code>short</code>, <code>ushort</code>, <code>int</code>, <code>long</code> etc)</td>
      <td><code>long</code></td>
      <td>Signed 64-bit integer. When deserializing from server data, if the value is outside the range of the target type,
      	<code>OverflowException</code> is thrown. Similarly, an <code>OverflowException</code> will
        be thrown if a <code>ulong</code> value outside the range of <code>long</code> is serialized.</td>
  	</tr>
  	<tr>
      <td>Map</td>
      <td>Any <code>IDictionary&lt;string, TValue&gt;</code>, anonymous type or attributed-class (see later)</td>
      <td><code>Dictionary&lt;string, object&gt;</code></td>
      <td>Represents an object embedded within a document. When indexed, you can query on subfields. If you exclude this value from indexing, then all subfields are also excluded from indexing.</td>
  	</tr>
  	<tr>
      <td>Null</td>
      <td>Null reference</td>
      <td>n/a</td>
      <td></td>
  	</tr>
  	<tr>
      <td>Reference</td>
      <td><code>[Google.Cloud.Firestore.DocumentReference](obj/api/Google.Cloud.Firestore.DocumentReference.yml)</code></td>
      <td><code>Google.Cloud.Firestore.DocumentReference</code></td>
      <td></td>
  	</tr>
  	<tr>
      <td>Text</td>
      <td><code>string</code></td>
      <td><code>string</code></td>
      <td>Sort order is in UTF-8 representation</td>
  	</tr>
  </tbody>
</table>

The "name to value" map can be represented in multiple ways. The following sections demonstrate each approach. Note that map values can be nested,
and you can mix and match approaches. For example, an attributed class can contain a dictionary or vice versa.
Similarly, you can serialize as an anonymous type then deserialize as an attributed class.

## Mapping with attributed classes

If you apply the [FirestoreData](obj/api/Google.Cloud.Firestore.FirestoreDataAttribute.yml) attribute to a class, the Firestore library for .NET can use it for serialization (when sending data to the server)
and deserialization (when retrieving data). All public instance properties with the [FirestoreProperty](obj/api/Google.Cloud.Firestore.FirestorePropertyAttribute.yml) attribute applied are serialized.

For example, to model a city as a document, you might have a class like this:

{{sample:DataModel.AttributedClass}}

Note how the `IsCapital` property specifies the name in the attribute; this is the field name that will be in the stored document.
This allows you to use idiomatic names in your .NET code, but match whatever field name is used in your Firestore database.

You might then use it to create a document and then fetch it like this:

{{sample:DataModel.AttributedClassUsage}}

In order to deserialize a map as an attributed class, the class must have a public parameterless constructor. (The C# compiler provides
one by default if no other constructors are specified.) The properties in the map must each have an attributed, public instance property with a public setter,
and the type of the property must be suitable for the value in the map. If the attributed class doesn't have a suitable property for an element of the map,
an exception is thrown.

## Mapping with dictionaries

A map can be represented as a `Dictionary<string, object>` - or if you're only storing values of a particular type, a `Dictionary<string, int>`, `Dictionary<string, string>` etc.
The key type for the dictionary must always be `string`, as the Firestore field name is used as the key.

Dictionaries can be passed to the various document creation and modification methods to represent the data, and `DocumentSnapshot.ToDictionary` deserializes
document data to a dictionary representation.

The equivalent city code using dictionaries would look like this:

[!code-cs[](obj/snippets/Google.Cloud.Firestore.DataModel.txt#DictionaryUsage)]

## Mapping with anonymous types

Anonymous types can be used for serialization, but not deserialization. They are particularly useful to specify partial updates, or
to populate data which isn't then read within the same codebase.

[!code-cs[](obj/snippets/Google.Cloud.Firestore.DataModel.txt#AnonymousTypeUsage)]

# Sentinel values

So far all the values we've looked at have been known by the C# code. There are two *sentinel values* available which behave slightly differently.

## Server-side timestamp

When you update a document using the server-side timestamp sentinel value, the actual timestamp that's recorded is the commit time
according to the Firestore server.

For attributed classes, you can specify `SentinelValue = SentinelValue.ServerTimestamp` in the attribute declaration. Usually
this will be on a property of type `Timestamp` (or `DateTime` or `DateTimeOffset`) so that you can retrieve the timestamp later.

[!code-cs[](obj/snippets/Google.Cloud.Firestore.DataModel.txt#SentinelAttribute)]

For dictionaries and anonymous types, you can use `SentinelValue.ServerTimestamp` as the value itself. For example,
to update just the `Score` and `Timestamp` fields of a `HighScore` document, you could use an anonymous type instead of
the attributed model

[!code-cs[](obj/snippets/Google.Cloud.Firestore.DataModel.txt#AnonymousTypeSentinel)]

Note that each document automatically keeps track of when it was last updated anyway, but you may wish to be more fine-grained;
if a document may change in several ways, you may want a timestamp for when a specific field was last modified.

## Deleted fields

It can be useful to indicate that a field needs to be deleted from a document, particularly using anonymous types. For example,
to delete a single field in a document, you can use:

```csharp
await doc.Set(new { Score = SentinelValue.Delete }, SetOptions.MergeAll);
```

You *can* specify `SentinelValue = SentinelValue.Delete` in a property attribute, but this would be highly unusual. It could be useful
as part of a schema migration strategy, for example. It's mostly supported for the sake of consistency.
