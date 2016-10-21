# Google.Cloud.Metadata.V1

`Google.Cloud.Metadata.V1` is a .NET client library for the [Google
Compute Engine Metadata Server](https://cloud.google.com/compute/docs/storing-retrieving-metadata).

# Installation

Install the `Google.Cloud.Metadata.V1` package from NuGet. Add it to
your project in the normal way (for example by right-clicking on the
project in Visual Studio and choosing "Manage NuGet Packages...").
Please ensure you enable pre-release packages (for example, in the
Visual Studio NuGet user interface, check the "Include prerelease"
box).

# Authentication

The metadata server is only available locally on a Google Compute
Engine VM instance. The instance automatically has access to the
metadata server API so no authentication is necessary.

# Getting started

All operations are performed through
[MetadataClient](obj/api/Google.Cloud.Metadata.V1.MetadataClient.yml).
This class provides methods and events for retrieving metadata
information about the project or instance. This can also include
custom key/value pairs associated with either the project or
instance. Neither this library nor the metadata server API provide
support for modifying custom metadata. Modifications must be done
via the [Compute Engine API](https://cloud.google.com/compute/docs/reference/latest/)
or the [Google Cloud Console](https://console.cloud.google.com).

# Sample code

# Getting instance metadata

[!code-cs[](obj/snippets/Google.Cloud.Metadata.V1.MetadataClient.txt#GetInstanceMetadata)]

# Getting a custom metadata value

[!code-cs[](obj/snippets/Google.Cloud.Metadata.V1.MetadataClient.txt#GetCustomInstanceMetadata)]

# Getting the maintenance status

[!code-cs[](obj/snippets/Google.Cloud.Metadata.V1.MetadataClient.txt#GetMaintenanceStatus)]

# Waiting for changes

[!code-cs[](obj/snippets/Google.Cloud.Metadata.V1.MetadataClient.txt#WaitForChange)]