// Copyright 2018, Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System.Collections.Generic;
using System;

namespace Google.Cloud.Firestore
{
    /// <summary>
    /// Custom converter used during serialization and deserialization.
    /// </summary>
    /// <remarks>
    /// <para>
    /// This can be specified using <see cref="FirestoreDataAttribute.ConverterType"/> to use
    /// the custom converter for all values of the attributed type, or using <see cref="FirestorePropertyAttribute.ConverterType"/>
    /// to use the custom converter for a single property. The latter approach can also be used to
    /// allow for conversion of types you don't control (e.g. to serialize <see cref="System.Guid"/> properties
    /// as strings).
    /// </para>
    /// <para>
    /// This interface is never passed a null value and should never return a null value. Null values are transparently
    /// handled by the serialization framework; if a document contains a null value, that will always be deserialized
    /// to a null reference (or null value of a nullable value type).
    /// </para>
    /// <para>
    /// Converters express their conversions in terms of regular .NET types: strings, integers, lists, dictionaries and so
    /// on. The result of serializing an object of type <typeparamref name="T"/> is then processed by the default serialization
    /// handling into the Firestore protocol buffer representation. Deserialization works the same way: first the Firestore
    /// protocol buffer representation is converted into .NET types in the default manner for this library, and the result is
    /// passed to the converter. Note that this means there can be asymmetry between serialization and deserialization: if the
    /// <see cref="ToFirestore(T)"/> method returns an <see cref="Int32"/>, deserializing the result will involve
    /// the <see cref="FromFirestore(object)"/> method receiving an <see cref="Int64"/> value as that's the default
    /// .NET representation of a Firestore integer.
    /// </para>
    /// <para>
    /// Converters that intend to convert objects into top-level documents should return a string-keyed dictionary of values
    /// from <see cref="ToFirestore(T)"/>. On deserialization, <see cref="FromFirestore(object)"/> will be passed a value
    /// implementing <see cref="IDictionary{TKey,TValue}"/> with a key type of <see cref="string"/> and a value type
    /// of <see cref="object"/>.
    /// </para>
    /// </remarks>
    /// <typeparam name="T">The type of object to convert.</typeparam>
    public interface IFirestoreConverter<T>
    {
        /// <summary>
        /// Converts a value to its Firestore representation.
        /// </summary>
        /// <param name="value">The value to convert. When called by Google.Cloud.Firestore,
        /// this will never be null.</param>
        /// <returns>The converted value. Must not be null.</returns>
        object ToFirestore(T value);

        /// <summary>
        /// Converts a value from its Firestore representation.
        /// </summary>
        /// <param name="value">The value to convert. When called by Google.Cloud.Firestore,
        /// this will never be null.</param>
        /// <returns>The converted value. Must not be null.</returns>
        T FromFirestore(object value);
    }
}
