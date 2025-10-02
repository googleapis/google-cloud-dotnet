# Data model

The Firestore data model revolves around *documents* and *collections*.

Collections contain documents, which can contain more collections. The document data itself doesn't contain subcollections,
although it can contain nested data.

The Firestore library for .NET provides multiple options for working with Firestore data.
It aims to make it simple for you to work with the data, whether you're creating, updating or querying it.

This page is primarily aimed at explaining how document data can be used with the .NET library. See
the [user guide](userguide.md) for more details around the relationship between documents and collections.

## Data types

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
      <td><code>double</code>, <code>float</code>, integer types listed below</td>
      <td><code>double</code></td>
      <td>64-bit double precision, IEEE 754. Floating point values are permitted to be deserialized      
      as integer values for compatibility with platforms which do not distinguish between
      floating point values and integer values.</td>
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
      <td>Any integer type (<code>byte</code>, <code>short</code>, <code>ushort</code>, <code>int</code>, <code>long</code> etc) or enum type; <code>float</code> and <code>double</code></td>
      <td><code>long</code></td>
      <td>Signed 64-bit integer. When deserializing from server data, if the value is outside the range of the target type,
      	<code>OverflowException</code> is thrown. Similarly, an <code>OverflowException</code> will
        be thrown if a <code>ulong</code> value outside the range of <code>long</code> is serialized.
        Integer values are permitted to be deserialized as <code>float</code> and <code>double</code>
        values for compatibility with platforms which do not distinguish between floating point
        values and integer values.</td>
  	</tr>
  	<tr>
      <td>Map</td>
      <td>Any <code>IDictionary&lt;string, TValue&gt;</code>, anonymous type or attributed-class (see later)</td>
      <td><code>Dictionary&lt;string, object&gt;</code></td>
      <td>Represents an object embedded within a document. When indexed, you can query on subfields. If you exclude this value from indexing, then all subfields are also excluded from indexing.
      C# 7 value tuples are also supported in a limited set of contexts. See <a href="#value-tuples">the section below</a> for more details.</td>
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
one by default if no other constructors are specified.) The properties in the map must each have an attributed instance property with a setter,
and the type of the property must be suitable for the value in the map. If the attributed class doesn't have a suitable property for an element of the map,
an exception is thrown.

Four additional attributes are also available for attributed
classes. The attributed properties play no part in serializing data
when writing to Firestore, but are automatically populated when
deserializing a document snapshot.

- [FirestoreDocumentId](obj/api/Google.Cloud.Firestore.FirestoreDocumentIdAttribute.yml)
- [FirestoreDocumentCreateTimestamp](obj/api/Google.Cloud.Firestore.FirestoreDocumentCreateTimestampAttribute.yml)
- [FirestoreDocumentUpdateTimestamp](obj/api/Google.Cloud.Firestore.FirestoreDocumentUpdateTimestampAttribute.yml)
- [FirestoreDocumentReadTimestamp](obj/api/Google.Cloud.Firestore.FirestoreDocumentReadTimestampAttribute.yml)

`FirestoreDocumentId` must be placed on a property of type `string`
or `DocumentReference`. If the property is of type `string`, it is
populated with the document ID. If the property is of type
`DocumentReference`, it is populated with the complete reference to
the document.

Each timestamp attribute must be placed on a `DateTime`,
`DateTimeOffset`, `Google.Cloud.Firestore.Timestamp` or
`Google.Protobuf.WellKnownTypes.Timestamp` property. (Properties of
nullable types are also permitted.)

For example, consider the following data model:

{{sample:DataModel.SnapshotAttributes}}

The following code creates a document for a chat room, then later fetches it.

{{sample:DataModel.SnapshotAttributesUsage}}

Without the attributes, the document reference and timestamps would
still be available to the code that deserializes the snapshot, but
other code using the `ChatRoom` object later wouldn't have access to
them without extra code to populate it. The attributes just allows
you to populate this information in your model without any additional code.

**Note**: The `FirestoreData` attribute can be applied to a struct
as well, but this only makes sense for mutable structs - which are
generally discouraged. The struct will be boxed as part of
serialization and deserialization, so there's no memory advantage
in that sense. However, this is supported for the sake of code which
wishes to use mutable structs for other reasons elsewhere.
To support immutable structs (which are generally prefered), write
a [custom converter](#custom-converters) in the same way as you
would for a class.

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
default mapping, as shown in the earlier table. However, if the
`[FirestoreDeserializationConfigurationAttribute]` attribute is
applied to the method, and if the value received is a dictionary
(such as for the top-level document deserialization) then additional
keys may be populated in the dictionary, representing the document
ID or create/update/read timestamps. This attribute provides the
equivalent functionality to the `[FirestoreDocumentId]`,
`[FirestoreDocumentCreateTimestamp]`,
`[FirestoreDocumentUpdateTimestamp]` and `[FirestoreDocumentReadTimestamp]`
attributes, but for custom converters.

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

### Converter registries

In some cases, you may wish to apply custom conversions without any
ability to add attributes to types or properties. In this situation,
you can build a `FirestoreDb` with a converter registry to specify
which custom converters you want to be applied by default. This
can be done via `FirestoreDbBuilder`, which has a `ConverterRegistry`
property.

For example, instead of specifying the converter on the
`PlayerWithGuidId.Id` property in the sample above, the converter could
be registered in the `FirestoreDb` instead:

{{sample:DataModel.ConverterRegistry}}

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

### Type discriminators

If you have a data model with an abstract class or an interface,
you may want to deserialize to that type rather than having to know
at compile time which concrete class will be used. This can be
done using a *type discriminator* which forms part of the data that
is serialized, and an implementation of `IFirestoreTypeDiscriminator<T>`,
which has a single method:

```csharp
public interface IFirestoreTypeDiscriminator<T>
{
    System.Type GetConcreteType(IDictionary<string, Value> map);
}
```

Once the discriminator is added to the `ConverterRegistry`, its
`GetConcreteType` method is invoked when an attempt is made to
deserialize an object to the specified type `T`. The method can
look at the data (in its raw Firestore format) and return the correct
concrete type to deserialize. The rest of the machinery for deserialization
then continues as normal.

As an example, consider the following type hierarchy and type discriminator:

{{sample:DataModel.DiscriminatedType}}

We can now serialize instances of any `Shape` as document data, and
deserialize to just `Shape`, with the correct type being determined
by the type discriminator:

{{sample:DataModel.DiscriminatedTypeUse}}

Two points to note about this example:

- For simplicity, this uses a string field with a value which is just the
  short name of the class ("Circle" etc), but the discriminator can be
  any type, and the logic within the implementation of
  `IFirestoreTypeDiscriminator<T>` can use the value however it wants.
- In this example, the object is the whole of the data for each document,
  but type discriminators are automatically used throughout deserialization.
  For example, you could have another annotated type with a property of type
  `Shape`, and that would be handled automatically with no need for a custom
  converter.

## Enum conversions

By default, C# enum values are converted to their underlying integer
values. The Google.Cloud.Firestore package includes a custom converter
that can be specified in the same way as any other custom converter, in
order to convert between enum values and their names instead.

The example below applies the converter on the enum itself, effectively
changing the default serialization model for that enum. The converter
could equally be applied on a property or registered in the converter
registry for the `FirestoreDb` used to create and retrieve documents.

{{sample:DataModel.EnumSerializeByName}}

## Value tuples

C# 7 introduced a feature around the `System.ValueTuple` generic structs which are part of
the framework. When using [attributed properties](#mapping-with-attributed-classes), the built-in
converters will serialize tuples as if they were a dictionary from the tuple element names to their values.

Consider the following class:

{{sample:DataModel.ValueTuple}}

A document representing a `Company` will be serialized as a top-level map with `Name` and `Location` fields;
the `Location` field will itself be a map with `city`, `state` and `country` fields.

There are some limitations on this feature:

- The feature only applies to attributed properties, not types in dictionaries,
  anonymous types etc.
- All tuple elements must be named. A tuple type of `(string name, int)` would be invalid, for example.
- The property type must be either the tuple type or the nullable equivalent. For example, a property
  with a type of `List<(string name, int value)>` would not be valid.
- Only tuples with up to 7 elements are supported.

These restrictions primarily exist for simplicity of the implementation, and the feature may be expanded
later to lift some of them.

## Sentinel values

So far all the values we've looked at have been known by the C# code. There are additional *sentinel values* available which behave slightly differently.

## Server-side timestamp

When you update a document using the server-side timestamp sentinel value, the actual timestamp that's recorded is the commit time
according to the Firestore server.

For attributed classes, you can specify `ServerTimestamp` in the attribute declaration for the property. Usually
this will be on a property of type `Timestamp` (or `DateTime` or `DateTimeOffset`) so that you can retrieve the timestamp later.

{{sample:DataModel.SentinelAttribute}}

For dictionaries and anonymous types, you can use `FieldValue.ServerTimestamp` as the value itself. For example,
to update just the `Score` and `Timestamp` fields of a `HighScore` document, you could use an anonymous type instead of
the attributed model

{{sample:DataModel.AnonymousTypeSentinel}}

Note that each document automatically keeps track of when it was last updated anyway, but you may wish to be more fine-grained;
if a document may change in several ways, you may want a timestamp for when a specific field was last modified.

## Deleted fields

It can be useful to indicate that a field needs to be deleted from a document, particularly using anonymous types. For example,
to delete a single field in a document, you can use:

```csharp
await doc.Set(new { Score = FieldValue.Delete }, SetOptions.MergeAll);
```

You *can* specify `SentinelValue = SentinelValue.Delete` in a property attribute, but this would be highly unusual. It could be useful
as part of a schema migration strategy, for example. It's mostly supported for the sake of consistency.

## Array union and removal

When updating a document that contains array fields, it can sometimes be inconvenient to update the whole field if you
simply want to either ensure that a specific value is present in the array, or remove it.

The `FieldValue.ArrayUnion` and `FieldValue.ArrayRemove` methods allow values to be created (usually as part of anonymous types
for `UpdateAsync` operations) which express these requirements simply and without a complete "read-modify-write" cycle.

## Numeric increment

It's common to need to modify an existing document numeric value by incrementing it by a given amount. While this can be done
with a "read-modify-write" cycle in a transaction, the `FieldValue.Increment` methods allow values to be created which
perform this increment operation server-side, removing the need for a transaction.
