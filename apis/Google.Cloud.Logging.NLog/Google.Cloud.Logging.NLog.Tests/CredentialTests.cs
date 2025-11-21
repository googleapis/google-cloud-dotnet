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

using Newtonsoft.Json;
using NLog;
using System;
using System.IO;
using Xunit;

namespace Google.Cloud.Logging.NLog.Tests;

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
        InitializeNLog(GetXml($"credentialFile='{tempCredFile.Path}'"));
    }

    [Fact]
    public void LoadCredentialFromJson_Succeeds() =>  InitializeNLog(GetXml($"credentialJson='{FakeServiceAccountCredential}'"));

    [Fact]
    public void LoadCredentialFromFile_BadFormat_Fails()
    {
        using var tempCredFile = new TempFile("bad json");
        var exception = Record.Exception(() => InitializeNLog(GetXml($"credentialFile='{tempCredFile.Path}'")));
        Assert.IsType<InvalidOperationException>(exception);
        Assert.IsType<JsonReaderException>(exception.InnerException);
    }

    [Fact]
    public void LoadCredentialFromJson_BadFormat_Fails()
    {
        var exception = Record.Exception(() => InitializeNLog(GetXml("credentialJson='terrible json'")));
        Assert.IsType<InvalidOperationException>(exception);
        Assert.IsType<JsonReaderException>(exception.InnerException);
    }

    [Fact]
    public void LoadCredentialFromFile_FileDoesNotExist_Fails() =>
        Assert.Throws<FileNotFoundException>(() => InitializeNLog(GetXml("credentialFile='non-existent-file'")));


    [Fact]
    public void LoadCredential_MultipleCredentials_Fails()
    {
        using var tempCredFile = new TempFile(FakeServiceAccountCredential);
        var exception = Assert.Throws<InvalidOperationException>(() =>
                InitializeNLog(GetXml($"credentialFile='{tempCredFile.Path}' credentialJson='{FakeServiceAccountCredential}'")));
        Assert.IsType<InvalidOperationException>(exception);
        Assert.Contains("CredentialFile", exception.Message);
        Assert.Contains("CredentialJson", exception.Message);
    }

    [Fact]
    public void LoadUserCredentialFromJson_WithCredentialType_Succeeds() =>
        InitializeNLog(GetXml($"credentialJson='{FakeUserCredential}' credentialType='authorized_user'"));

    [Fact]
    public void LoadUserCredentialFromJson_WithWrongCredentialType_Fails() =>
        Assert.Throws<InvalidOperationException>(() => InitializeNLog(GetXml($"credentialJson='{FakeServiceAccountCredential}' credentialType='authorized_user'")));

    private static string GetXml(string attributes) =>
        "<nlog xmlns='http://www.nlog-project.org/schemas/NLog.xsd' xmlns:xsi='http://www.w3.org/2001/XMLSchema-instance'>" +
        "<extensions><add assembly='Google.Cloud.Logging.NLog'/></extensions>" +
        "<targets>" +
        $"<target name='stackdriver' xsi:type='GoogleStackdriver' projectId='test-project-id' {attributes} />" +
        "</targets>" +
        "</nlog>";

    private static void InitializeNLog(string config)
    {
        using var tempConfigFile = new TempFile(config);
        using var logFactory = new LogFactory();
        logFactory.ThrowExceptions = true;
        logFactory.Setup().LoadConfigurationFromFile(tempConfigFile.Path);
        Assert.NotNull(logFactory.Configuration);
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