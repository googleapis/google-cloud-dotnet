// Copyright 2019, Google LLC
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

using Google.Cloud.Firestore.Converters;
using Google.Cloud.Firestore.V1;
using System;
using System.Collections.Generic;
using BclType = System.Type;

namespace Google.Cloud.Firestore
{
    /// <summary>
    /// Provides context for serialization operations. This allows different converters to be used for different
    /// databases, etc. Currently only used for custom converters (so FirestoreDb-wide) but could potentially
    /// have more information later.
    /// </summary>
    internal sealed class SerializationContext
    {
        // Important note: if this class ever contains more state than just the converters,
        // e.g. a reference to the Database, then WithWarningLogger will need to be adjusted accordingly.

        internal static SerializationContext Default { get; } = new SerializationContext(null);

        private readonly IReadOnlyDictionary<BclType, IFirestoreInternalConverter> _customConverters;
        private readonly IReadOnlyDictionary<BclType, Func<IDictionary<string, Value>, BclType>> _typeDiscriminators;

        internal SerializationContext(ConverterRegistry converterRegistry)
        {
            _customConverters = converterRegistry?.ToConverterDictionary();
            _typeDiscriminators = converterRegistry?.ToTypeDiscriminatorDictionary();
        }

        internal IFirestoreInternalConverter GetConverter(BclType targetType)
        {
            IFirestoreInternalConverter customConverter = null;
            _customConverters?.TryGetValue(targetType, out customConverter);
            return customConverter ?? ConverterCache.GetConverter(targetType);
        }

        internal IFirestoreInternalConverter GetDeserializationConverter(BclType targetType, Value value) =>
            GetDeserializationConverter(targetType, value?.MapValue?.Fields);

        internal IFirestoreInternalConverter GetDeserializationConverter(BclType targetType, IDictionary<string, Value> map)
        {
            if (map is not null && _typeDiscriminators?.TryGetValue(targetType, out var discriminator) == true)
            {
                var newTargetType = discriminator.Invoke(map);
                if (newTargetType is null || !targetType.IsAssignableFrom(newTargetType))
                {
                    throw new InvalidOperationException($"Type discriminator returned an inappropriate type: {newTargetType}");
                }
                targetType = newTargetType;
            }

            return GetConverter(targetType);
        }
    }
}
