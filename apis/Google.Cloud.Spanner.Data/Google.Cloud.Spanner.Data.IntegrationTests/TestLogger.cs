using System;
using Google.Cloud.Spanner.V1.Logging;
using Xunit.Abstractions;

namespace Google.Cloud.Spanner.Data.IntegrationTests
{
    internal class TestLogger : DefaultLogger
    {
        private static Lazy<TestLogger> s_Instance = new Lazy<TestLogger>(
            () =>
            {
                var logger = new TestLogger();
                return logger;
            });

        private TestLogger()
        {
        }

        public static void Install()
        {
            SetLogger(s_Instance.Value);
        }

        // ReSharper disable once MemberCanBePrivate.Global
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        public static ITestOutputHelper TestOutputHelper { get; set; }

        protected override void WriteLine(string message)
        {
            TestOutputHelper?.WriteLine(message);
        }
    }
}
