using CommandLine;

namespace Google.Cloud.Tools.SecretManagerHelper;

public class SecretPathOptions
{
    [Option("project", Required = true, HelpText = "Name of your Google Cloud Project.")]
    public string ProjectName { get; set; } = "";

    [Option("secret", Required = true, HelpText = "Name of the secret to fetch from Secret Manager.")]
    public string SecretId { get; set; } = "";
}
