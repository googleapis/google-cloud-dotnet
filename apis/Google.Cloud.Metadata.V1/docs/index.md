{{title}}

{{description}}

{{version}}

{{installation}}

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

{{sample:MetadataClient.GetInstanceMetadata}}

# Getting a custom metadata value

{{sample:MetadataClient.GetCustomInstanceMetadata}}

# Getting the maintenance status

{{sample:MetadataClient.GetMaintenanceStatus}}

# Getting raw metadata values

{{sample:MetadataClient.GetMetadata}}

# Waiting for changes

{{sample:MetadataClient.WaitForChange}}