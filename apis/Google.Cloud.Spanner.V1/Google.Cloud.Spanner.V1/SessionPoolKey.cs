using System;

namespace Google.Cloud.Spanner.V1
{
    /// <summary>
    /// Holds a key that we use to look up cached sessions.
    /// </summary>
    internal struct SessionPoolKey : IEquatable<SessionPoolKey>
    {
        public SessionPoolKey(SpannerClient client, string project, string instance, string database)
        {
            Client = client;
            Project = project;
            Instance = instance;
            Database = database;
        }

        public SpannerClient Client { get; }
        public string Project { get; }
        public string Instance { get; }
        public string Database { get; }
        public bool Equals(SessionPoolKey other)
        {
            return (other.Client == Client && other.Project == Project && other.Instance == Instance
                    && other.Database == Database);
        }
    }
}