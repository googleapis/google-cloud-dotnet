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

using Xunit;

namespace Google.Cloud.Firestore.Tests;

public class ExplainOptionsTest
{
    [Fact]
    public void FromProto()
    {
        var proto = new V1.ExplainOptions { Analyze = true };
        var wrapper = ExplainOptions.FromProto(proto);
        Assert.True(wrapper.Analyze);
        proto.Analyze = false;
        Assert.True(wrapper.Analyze);
    }

    [Fact]
    public void ToProto()
    {
        var wrapper = ExplainOptions.PlanAndExecute;
        var proto = wrapper.ToProto();
        Assert.True(wrapper.Analyze);
        Assert.True(proto.Analyze);
        proto.Analyze = false;
        Assert.True(wrapper.Analyze);
    }
}
