// Copyright 2025 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License"):
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

using Google.Cloud.Firestore.V1;
using System.Collections.Generic;

namespace Google.Cloud.Firestore;

/// <summary>
/// Type discriminator used during deserialization when a value should be
/// deserialized to one of multiple types sharing a common ancestor (typically
/// an abstract class or an interface) based on the document data for the value.
/// </summary>
/// <remarks>
/// The use of a type discriminator allows deserialization to be customized in a
/// single aspect while still using <see cref="FirestoreDataAttribute"/> etc for
/// the majority of deserialization. The type discriminator needs to be registered
/// in a <see cref="ConverterRegistry"/> using
/// <see cref="ConverterRegistry.Add{T}(IFirestoreTypeDiscriminator{T})"/>
/// when constructing a <see cref="FirestoreDb"/> via a <see cref="FirestoreDbBuilder"/>.
/// The type discriminator will be used automatically when deserializing to type
/// <typeparamref name="T"/>, either directly (e.g. with <see cref="DocumentSnapshot.ConvertTo{T}"/>
/// or <see cref="DocumentSnapshot.GetValue{T}(string)"/>) or indirectly (e.g. when deserializing
/// a property within an attributed type).
/// </remarks>
/// <typeparam name="T">The common ancestor type to be deserialized.</typeparam>
public interface IFirestoreTypeDiscriminator<T>
{
    /// <summary>
    /// Returns the .NET type that a value should be deserialized as.
    /// </summary>
    /// <param name="map">The data associated with the value, as a map
    /// of string to Firestore <see cref="Value"/> objects. When this method is
    /// called during deserialization, the parameter value is not null and no
    /// values within the map are null.</param>
    /// <returns>The concrete type to be deserialized. Must not be null,
    /// and must be either <typeparamref name="T"/> or some type assignable to it.
    /// </returns>
    System.Type GetConcreteType(IDictionary<string, Value> map);
}
