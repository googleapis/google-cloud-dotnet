# Batch release documentation

Batch releasing is a relatively advanced feature, and should normally be undertaken by the .NET client libraries team.
This documentation is primarily aimed at the team.

## Running a batch release command

- Create a batch release config JSON file (described below). This can be anywhere.
  (You may want to create a directory outside your repo to store "old" configs to be
  amended each time, for example.)
- From the repo root directory, run `./prepare-release.sh batch-release <path-to-config-file>`

Note that currently batch releasing does not support packages that have to be released in a group
(e.g. Spanner, Diagnostics). Currently this is *not* detected automatically: releasing will simply
fail.

Batch releasing always performs a minor version bump for GA versions (e.g. 1.2.1 => 1.3.0),
and increments the prerelease counter for prerelease versions (e.g. 1.1.0-beta03 => 1.1.0-beta04).

## Batch release configuration

The ultimate source of truth for this is [BatchReleaseConfig.cs](BatchReleaseConfig.cs).

The file contains some general configuration, and a number of *criteria* options.
Exactly one criterion must be specified: this determines what releases are proposed.

### General options

The following JSON shows the general options, with their default values.

```jsonc
{
  // When true, each release (and history) is confirmed manually at the console.
  "ConfirmRelease": true,

  // When true, indicates which libraries would be released and what the history update would
  // look like, but doesn't make any changes or release anything.
  "DryRun": true,

  // When true, display the new history text (both in dry-run mode and "do it" mode).
  "ShowHistory": true,
}
```

### Criteria available (specify exactly one)

**Specified APIs**

The `SpecifiedApis` option simply lists the API IDs to release. Example:

```json
{
  "SpecifiedApis": [ "Google.Cloud.Speech.V1", "Google.Cloud.Vision.V1" ]
}
```

**Known commits**

The `KnownCommits` option will release any API whose changes since the previous
release are *exactly* the set of commit hashes specified in the configuration. The new history
section can optionally be overridden with fixed text. Example:

```json
{
  "KnownCommits": {
    "Commits": [ "51b50d0", "b3c1df4" ],
    "HistoryOverride": "This was triggered by a batch release.\nThis would be the second line in the history."
  }
}
```
