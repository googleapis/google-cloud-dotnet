using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Xunit.Sdk;

namespace Google.Cloud.Spanner.Data.Tests
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
    public class DisableResourceBasedRouting : BeforeAfterTestAttribute
    {
        const string ResourceBasedRouteVariableName = "GOOGLE_CLOUD_ENABLE_RESOURCE_BASED_ROUTING";
        static string ResourceBasedRoutingValue;
        public override void Before(MethodInfo methodUnderTest)
        {
            ResourceBasedRoutingValue = Environment.GetEnvironmentVariable(ResourceBasedRouteVariableName);
            Environment.SetEnvironmentVariable(ResourceBasedRouteVariableName, "false");
        }

        public override void After(MethodInfo methodUnderTest)
        {
            Environment.SetEnvironmentVariable(ResourceBasedRouteVariableName, ResourceBasedRoutingValue);
        }
    }
}
