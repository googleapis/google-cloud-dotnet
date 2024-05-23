This directory contains configuration files for the batch-release
command. For example, a common command to run from the root directory
is:

```sh
./prepare-release.sh batch-release tools/BatchReleaseConfigurations/release-stale.json
```

If you need to change the configuration at all before running it,
copy it to a local directory *not* in the repository (e.g. the
parent of the repository) first, as releasing will fail if there are
local changes.
