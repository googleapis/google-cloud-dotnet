using Google.Cloud.ClientTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Google.Cloud.Logging.NLog.Snippets
{
    [CollectionDefinition(nameof(NLogSnippetFixture))]
    public sealed class NLogSnippetFixture : CloudProjectFixtureBase, ICollectionFixture<NLogSnippetFixture>
    {
        public string LogId { get; } = "NLogTestLog";

        public override void Dispose()
        {
            // TODO
        }
    }
}
