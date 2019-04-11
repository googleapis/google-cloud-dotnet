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
      <td>Any integer type (<code>byte</code>, <code>short</code>, <code>ushort</code>, <code>int</code>, <code>long</code> etc) or enum type; <code>double</code> for deserialization</td>
      <td><code>long</code></td>
      <td>Signed 64-bit integer. When deserializing from server data, if the value is outside the range of the target type,
      	<code>OverflowException</code> is thrown. Similarly, an <code>OverflowException</code> will
        be thrown if a <code>ulong</code> value outside the range of <code>long</code> is serialized.
        Integer values are permitted to be deserialized as <code>double</code> values for compatibility
        with platforms which treat any whole number as an integer, even if it's intended to be a
        floating-point value.</td>
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

{{sample:DataModel.DictionaryUsage}}

## Mapping with anonymous types

Anonymous types can be used for serialization, but not deserialization. They are particularly useful to specify partial updates, or
to populate data which isn't then read within the same codebase.

{{sample:DataModel.AnonymousTypeUsage}}

## Custom converters

If the built-in conversions aren't flexible enough for your needs,
you can create a custom converter implementing
`IFirestoreConverter<T>`:

```csharp
public interface IFirestoreConverter<T>
{
    object ToFirestore(T value);
    T FromFirestore(object value);
}
```

The `ToFirestore` method should convert the `T` value into a
suitable format to be stored. This can use any of the conversions
described above. For example, if the method returns an `int`, the
value will be stored as a 64-bit integer in the same way as an `int`
property in an attributed type, or an `int` value within a dictionary.

The `FromFirestore` method receives the deserialized value using the
default mapping, as shown in the earlier table.

### Applying a converter to a type

Once you've created a converter, you can either apply it to a type
or an individual attributed property. In each case, the
`ConverterType` property is specified in the attribute.

For example, suppose you wish to create several ID classes or
structs, each containing a string of the underlying ID. This is a
technique sometimes used to effectively make type-safe identifiers.
You could create a converter for each class, and apply the
`[FirestoreData]` attribute to each class, specifying the
corresponding converter. This would allow each ID to be stored as
just the string, rather than as a map containing a single element with
a string value. The following example demonstrates this with a
`PlayerId` class. If another attributed class (e.g. a `Game`) had a
`PlayerId` property, the converter would be used automatically.

{{sample:DataModel.CustomConverterType}}

### Applying a converter to a property

Sometimes you may want to perform custom conversions for types that
you can't apply attributes to, or you may want different conversions
in different situations. In that case, you can implement the
converter in the same way, but apply it selectively using the
`ConverterType` property on the `[FirestoreProperty]` attribute
instead.

As an example, you may want to use the .NET `Guid` struct within
your data model. You could store each `Guid` property as a string,
using the following sample code.

{{sample:DataModel.CustomConverterProperty}}

### Document converters

If you wish a .NET type to be stored as a complete document after
custom conversion, the converter must return a value which would be
serialized as a map. This could be a dictionary, an anonymous type,
or even a separate attributed type. When deserializing, the
converter will receive an `IDictionary<string, object>` which it
should use to extract the original data.

{{sample:DataModel.ComplexConverter}}

### Null values and custom converters

Note that the conversion methods never receive null references, nor should
they return null values. While it would be possible to deserialize
null values to non-null .NET values, the conversion used in
serialization is usually determined based on the actual type of the
value being serialized. The approach used for null values ensures
consistency.

As a side-effect of this decision, it is advisable for the type
argument of `IFirestoreConverter` to be a class or a non-nullable
value type. For example, implement `IFirestoreConverter<Guid>`
rather than `IFirestoreConverter<Guid?>`. If a converter is supplied
for a non-nullable value type, the converter will automatically be
used for the corresponding nullable value type too, with null values
being handled transparently.

# Sentinel values

So far all the values we've looked at have been known by the C# code. There are two *sentinel values* available which behave slightly differently.

## Server-side timestamp

When you update a document using the server-side timestamp sentinel value, the actual timestamp that's recorded is the commit time
according to the Firestore server.

For attributed classes, you can specify `SentinelValue = SentinelValue.ServerTimestamp` in the attribute declaration. Usually
this will be on a property of type `Timestamp` (or `DateTime` or `DateTimeOffset`) so that you can retrieve the timestamp later.

{{sample:DataModel.SentinelAttribute}}

For dictionaries and anonymous types, you can use `SentinelValue.ServerTimestamp` as the value itself. For example,
to update just the `Score` and `Timestamp` fields of a `HighScore` document, you could use an anonymous type instead of
the attributed model

{{sample:DataModel.AnonymousTypeSentinel}}

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
