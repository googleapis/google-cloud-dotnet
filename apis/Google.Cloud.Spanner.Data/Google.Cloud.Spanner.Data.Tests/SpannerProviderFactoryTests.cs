// Copyright 2017 Google Inc. All Rights Reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Xunit;

namespace Google.Cloud.Spanner.Data.Tests
{
    public class SpannerProviderFactoryTests
    {
        [Fact]
        public void CreateCommand()
        {
            Assert.IsType<SpannerCommand>(SpannerProviderFactory.Instance.CreateCommand());
        }

        [Fact]
        public void CreateConnection()
        {
            Assert.IsType<SpannerConnection>(SpannerProviderFactory.Instance.CreateConnection());
        }

        [Fact]
        public void CreateConnectionStringBuilder()
        {
            Assert.IsType<SpannerConnectionStringBuilder>(SpannerProviderFactory.Instance.CreateConnectionStringBuilder());
        }

        [Fact]
        public void CreateParameter()
        {
            Assert.IsType<SpannerParameter>(SpannerProviderFactory.Instance.CreateParameter());
        }

#if !NETCOREAPP1_0
        [Fact]
        public void CreateDataAdapter()
        {
            Assert.IsType<SpannerDataAdapter>(SpannerProviderFactory.Instance.CreateDataAdapter());
        }
#endif
    }
}
