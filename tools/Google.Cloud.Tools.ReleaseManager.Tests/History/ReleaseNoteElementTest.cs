// Copyright 2022 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License").
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at 
//
// https://www.apache.org/licenses/LICENSE-2.0 
//
// Unless required by applicable law or agreed to in writing, software 
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and 
// limitations under the License.

using Xunit;

namespace Google.Cloud.Tools.ReleaseManager.History.Tests;

public class ReleaseNoteElementTest
{
    [Theory]
    [InlineData("feat: This is a feature", ReleaseNoteElementType.Feature, "This is a feature")]
    [InlineData("docs: This is a documentation change", ReleaseNoteElementType.Docs, "This is a documentation change")]
    [InlineData("doc: This is a documentation change", ReleaseNoteElementType.Docs, "This is a documentation change")]
    [InlineData("chore: This is a chore", ReleaseNoteElementType.Chore, "This is a chore")]
    [InlineData("fix: This is a bug fix", ReleaseNoteElementType.Fix, "This is a bug fix")]
    [InlineData("BREAKING CHANGE: This is a breaking change", ReleaseNoteElementType.BreakingChange, "This is a breaking change")]
    [InlineData("build: We don't know what build means", ReleaseNoteElementType.Unknown, "We don't know what build means")]
    [InlineData("regen: Regenerate Google.Cloud.Functions.V2", ReleaseNoteElementType.Placeholder, "Regenerate Google.Cloud.Functions.V2")]
    public void ElementType(string text, ReleaseNoteElementType expectedType, string expectedText)
    {
        var element = ReleaseNoteElement.Parse("hash", text);
        Assert.Equal(expectedType, element.Type);
        Assert.Equal(expectedText, element.Text);
        Assert.False(element.BreakingChange);
        Assert.Equal("hash", element.CommitHash);
    }

    [Fact]
    public void BreakingChangeMarker()
    {
        var element = ReleaseNoteElement.Parse("hash", "fix!: This bug fix is breaking");
        Assert.Equal(ReleaseNoteElementType.Fix, element.Type);
        Assert.Equal("This bug fix is breaking", element.Text);
        Assert.True(element.BreakingChange);
    }

    [Theory]
    [InlineData("feat: This is a feature", false)]
    [InlineData("feat!: This is a feature", true)]
    [InlineData("feat(api): This is a feature", false)]
    [InlineData("feat!(api): This is a feature", true)]
    [InlineData("feat(api)!: This is a feature", true)]
    public void ScopeIsIgnored(string text, bool expectedBreaking)
    {
        var element = ReleaseNoteElement.Parse("hash", text);
        Assert.Equal(ReleaseNoteElementType.Feature, element.Type);
        Assert.Equal("This is a feature", element.Text);
        Assert.Equal(expectedBreaking, element.BreakingChange);
    }

    [Theory]
    [InlineData("This doesn't have a colon at all")]
    [InlineData("")]
    [InlineData("This has a colon after a space: we ignore that")]
    public void IgnoreNonConventionalLines(string text)
    {
        Assert.Null(ReleaseNoteElement.Parse("hash", text));
    }
}
