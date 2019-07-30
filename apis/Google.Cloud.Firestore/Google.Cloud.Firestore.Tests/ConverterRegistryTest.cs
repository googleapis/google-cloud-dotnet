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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;
using static Google.Cloud.Firestore.Tests.SerializationTestData;

namespace Google.Cloud.Firestore.Tests
{
    public class ConverterRegistryTest
    {
        [Fact]
        public void ToConverterDictionary()
        {
            var registry = new ConverterRegistry
            {
                new GuidConverter(),
                new EmailConverter()
            };
            var dictionary = registry.ToConverterDictionary();
            registry.Add(new CustomPlayerConverter());

            // We shouldn't have CustomPlayer in the dictionary, but we should have the other two.
            Assert.Equal(new[] { typeof(Email), typeof(Guid) }, dictionary.Keys.OrderBy(t => t.FullName));
        }

        [Fact]
        public void DuplicateKey()
        {
            var registry = new ConverterRegistry { new GuidConverter() };
            Assert.Throws<ArgumentException>(() => registry.Add(new AnotherGuidConverter()));
        }

        [Fact]
        public void IEnumerableImplementation()
        {
            var guidConverter = new GuidConverter();
            var emailConverter = new EmailConverter();
            var registry = new ConverterRegistry
            {
                guidConverter,
                emailConverter
            };
            Assert.Equal(new object[] { guidConverter, emailConverter }, registry.Cast<object>().ToList());
        }

        private class AnotherGuidConverter : IFirestoreConverter<Guid>
        {
            public Guid FromFirestore(object value) => Guid.NewGuid();

            public object ToFirestore(Guid value) => "ignored";
        }
    }
}
