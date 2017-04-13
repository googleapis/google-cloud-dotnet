using Google.Apis.Auth.OAuth2;

namespace Google.Cloud.Spanner.V1
{
    /// <summary>
    /// Holds a key that we use to look up cached sessions.
    /// </summary>
    internal struct SessionPoolKey
    {
        public ITokenAccess Credential { get; set; }
        public string DataSource { get; set; }
    }
}