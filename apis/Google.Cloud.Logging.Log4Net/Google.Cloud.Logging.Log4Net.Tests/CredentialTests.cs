// Copyright 2025 Google Inc. All Rights Reserved.
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

using log4net;
using log4net.Config;
using System;
using System.IO;
using System.Linq;
using System.Xml;
using Xunit;

namespace Google.Cloud.Logging.Log4Net.Tests;

public class CredentialTests
{
    private const string FakeServiceAccountCredential = @"{
        ""private_key_id"": ""PRIVATE_KEY_ID"",
        ""private_key"": ""-----BEGIN PRIVATE KEY-----
        MIICdgIBADANBgkqhkiG9w0BAQEFAASCAmAwggJcAgEAAoGBAJJM6HT4s6btOsfe
        2x4zrzrwSUtmtR37XTTi0sPARTDF8uzmXy8UnE5RcVJzEH5T2Ssz/ylX4Sl/CI4L
        no1l8j9GiHJb49LSRjWe4Yx936q0Xj9H0R1HTxvjUPqwAsTwy2fKBTog+q1frqc9
        o8s2r6LYivUGDVbhuUzCaMJsf+x3AgMBAAECgYEAi0FTXsu/zRswAUGaViQiHjrL
        uU65BSHXNVjV/2fLNEKnGWGqpli68z1IXY+S2nwbUak7rnGsq9/0F6jtsW+hZbLk
        KXUOuuExpeC5Kd6ngWX/f2jqmhlUabiQijU9cVk7pMq8EHkRtvlosnMTUAEzempu
        QUPwn1PZHhmJkBvZ4lECQQDCErrxl+e3BwUDcS0yVEEmCNSG6xdXs2878b8rzbe7
        3Mmi6SuuOLi3PU92J+j+f/MOdtYrk13mEDdYmd5dhrt5AkEAwPvDEsDT/W4y4h5n
        gv1awGBA5aLFE1JNWM/Gwn4D1cGpEDHKFREaBtxMDCASpHJuw8r7zUywpKhmBZcf
        GS37bwJANdSAKfbafLfjuhqwUJ9yGpykZm/a36aTmerp/bpn1iHdg+RtCzwMcDb/
        TWSwibbvsflgWmHbz657y4WSWhq+8QJAWrpCNN/ZCk2zuGDo80lfUBAwkoVat8G6
        wWU1oZyS+vzIGef+hLb8kHsjeZPej9eIwZ39kcBbT54oELrCkRjwGwJAQ8V2A7lT
        ZUp8AsbVqF6rbLiiUfJMo2btGclQu4DEVyS+ymFA65tXDLUuR9EDqJYdqHNZJ5B8
        4Z5p2prkjWTLcA\u003d\u003d
        -----END PRIVATE KEY-----"",
        ""client_email"": ""CLIENT_EMAIL"",
        ""client_id"": ""CLIENT_ID"",
        ""project_id"": ""PROJECT_ID"",
        ""type"": ""service_account""}";

    private const string FakeUserCredential = @"{
        ""client_id"": ""CLIENT_ID"",
        ""client_secret"": ""CLIENT_SECRET"",
        ""refresh_token"": ""REFRESH_TOKEN"",
        ""type"": ""authorized_user""}";

    [Fact]
    public void LoadCredentialFromFile_Succeeds()
    {
        using var tempCredFile = new TempFile(FakeServiceAccountCredential);
        var appender = InitializeLog4Net(GetXml($"<credentialFile value='{tempCredFile.Path}'/>"));
        AssertActivated(appender);
    }

    [Fact]
    public void LoadCredentialFromJson_Succeeds()
    {
         var appender = InitializeLog4Net(GetXml($"<credentialJson value='{FakeServiceAccountCredential}'/>"));
         AssertActivated(appender);
    }

    [Fact]
    public void LoadCredentialFromFile_BadFormat_Fails()
    {
        using var tempCredFile = new TempFile("bad json");
        var appender = InitializeLog4Net(GetXml($"<credentialFile value='{tempCredFile.Path}'/>"));
        AssertNotActivated(appender);
    }

    [Fact]
    public void LoadCredentialFromJson_BadFormat_Fails()
    {
        var appender = InitializeLog4Net(GetXml($"<credentialJson value='terrible json'/>"));
        AssertNotActivated(appender);
    }

    [Fact]
    public void LoadCredentialFromFile_FileDoesNotExist_Fails()
    {
         var appender = InitializeLog4Net(GetXml($"<credentialFile value='non-existent-file'/>"));
         AssertNotActivated(appender);
    }

    [Fact]
    public void LoadCredential_MultipleCredentials_Fails()
    {
        using var tempCredFile = new TempFile(FakeServiceAccountCredential);
        // Both CredentialFile and CredentialJson
         var appender = InitializeLog4Net(GetXml($"<credentialFile value='{tempCredFile.Path}'/> <credentialJson value='{FakeServiceAccountCredential}'/>"));
        AssertNotActivated(appender);
    }

    [Fact]
    public void LoadUserCredentialFromJson_WithCredentialType_Succeeds()
    {
         var appender = InitializeLog4Net(GetXml($"<credentialJson value='{FakeUserCredential}'/> <credentialType value='authorized_user'/>"));
         AssertActivated(appender);
    }

    [Fact]
    public void LoadUserCredentialFromJson_WithWrongCredentialType_Fails()
    {
         var appender = InitializeLog4Net(GetXml($"<credentialJson value='{FakeServiceAccountCredential}'/> <credentialType value='authorized_user'/>"));
         AssertNotActivated(appender);
    }

    private static string GetXml(string attributes) =>
        "<log4net>" +
        "<appender name='CloudLogger' type='Google.Cloud.Logging.Log4Net.GoogleStackdriverAppender, Google.Cloud.Logging.Log4Net'>" +
        "<projectId value='test-project-id'/>" +
        "<logId value='test-log-id'/>" +
        "<layout type='log4net.Layout.PatternLayout'>" +
        "<conversionPattern value='%-4timestamp [%thread] %-5level %logger - %message' />" +
        "</layout>" +
        attributes +
        "</appender>" +
        "<root>" +
        "<level value='ALL' />" +
        "<appender-ref ref='CloudLogger' />" +
        "</root>" +
        "</log4net>";

    private GoogleStackdriverAppender InitializeLog4Net(string xmlConfig)
    {
        var repoName = "test-repo-" + Guid.NewGuid();
        var repository = LogManager.CreateRepository(repoName);

        var doc = new XmlDocument();
        doc.LoadXml(xmlConfig);

        XmlConfigurator.Configure(repository, doc["log4net"]);

        var appender = repository.GetAppenders().OfType<GoogleStackdriverAppender>().FirstOrDefault();
        return appender;
    }

    private void AssertActivated(GoogleStackdriverAppender appender)
    {
        // When activated the flush will not fail, so we just check an exception is not thrown
        var ex = Record.Exception(() => appender.Flush(TimeSpan.FromMilliseconds(10)));
        Assert.True(ex == null, $"The GoogleStackdriverAppender was not activated, exception encountered: {ex}");
    }

    private void AssertNotActivated(GoogleStackdriverAppender appender)
    {
        // Appender might be null if it failed to load completely
        if (appender == null) return;

        var ex = Assert.Throws<InvalidOperationException>(() => appender.Flush(TimeSpan.FromMilliseconds(10)));
        Assert.Contains("ActivateOptions() must be called", ex.Message);
    }

    private sealed class TempFile : IDisposable
    {
        public string Path { get; }

        public TempFile(string content = null)
        {
            Path = System.IO.Path.GetTempFileName();
            if (content != null)
            {
                File.WriteAllText(Path, content);
            }
        }

        public void Dispose()
        {
            if(File.Exists(Path))
            {
                File.Delete(Path);
            }
        }
    }
}
