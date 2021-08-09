# Version history

# Version 1.0.0-beta01, released 2021-08-09

Main changes from 1.0.0-alpha02:

- Automatic pagination is now implemented for all "list" methods. This is a breaking
  change, as the return type has changed. Any code which was
  previously looping over responses manually and handling page
  tokens can be simplified at this point. See https://cloud.google.com/dotnet/docs/reference/help/page-streaming
  for more details.
- Failed RPCs will now contain details of the failure, rather than
  just a status code. Currently this is just the textual
  representation of the original RPC response; in the future this
  text may be parsed automatically.

# Version 1.0.0-alpha02, released 2021-06-16

Regenerated with changes from googleapis-discovery, and GAX
3.5.0-alpha01.

# Version 1.0.0-alpha01, released 2021-05-13

First alpha release. Please note that this library is still in early
testing phases, and is not suitable for production workloads.
