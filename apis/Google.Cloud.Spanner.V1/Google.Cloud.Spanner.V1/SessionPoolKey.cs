using Google.Api.Gax.Grpc;
using Google.Apis.Auth.OAuth2;

namespace Google.Cloud.Spanner.V1
{
    /// <summary>
    /// Holds a key that we use to look up cached sessions.
    /// </summary>
    internal struct SessionPoolKey
    {
        public ITokenAccess Credential { get; set; }
        public ServiceEndpoint ServiceEndpoint { get; set; }
        public string Project { get; set; }
        public string Instance { get; set; }
        public string Database { get; set; }
    }
}