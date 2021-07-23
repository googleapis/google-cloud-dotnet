Adding a package for a new API
==============================

While this process will usually be performed by Googlers, there's
nothing confidential about it, and it may be of interest to third
parties.

Prerequisites:

- `git`
- `bash` (on Windows, the version that comes with Git for Windows)
- `wget`
- Python 3 on the path as `python`
- .NET Core SDK, suitable for the version specified in `global.json`

*Almost* all of the generation process works fine on Linux and
should work on OSX too (untested). Bigtable has a post-generation
step that currently requires Windows, but that's skipped on
non-Windows platforms so should only affect Bigtable developers.

Relevant repositories:

- [googleapis](https://github.com/googleapis/googleapis): API definitions
- [gapic-generator-csharp](https://github.com/googleapis/gapic-generator-csharp): C# microgenerator
- [google-cloud-dotnet](https://github.com/googleapis/google-cloud-dotnet): This repository, where code will end up

This list of instructions looks daunting, but it's not as bad as it
seems: it aims to be pretty comprehensive, although it assumes you
know how to use `git` appropriately.

Step 1: Fork google-cloud-dotnet on github
------------------------------------------

Our process is to merge from user-owned forks, so first fork this
repo and clone it locally, using an https URL (rather than SSH).

When you clone, use the `--recursive` flag to ensure that you initialize the submodules too.

We tend to use named branches on the forks, although that's not
*strictly* necessary. So for example, you might run:

```sh
git clone https://github.com/YOUR-GITHUB-USERNAME/google-cloud-dotnet.git --recursive
cd google-cloud-dotnet
git checkout -b add-new-api-package
```

Step 2: Clone googleapis within your google-cloud-dotnet
--------------------------------------------------------

Currently, the tooling for adding an API expects to find a clone of
the googleapis repo directly under the root of the
google-cloud-dotnet repo, but doesn't perform the clone for you.

The simplest way of achieving this is just to generate an existing
API, e.g.

```sh
./generateapis.sh Google.Cloud.Speech.V1
```

The generation tooling *does* clone the repo for you. This will also
validate that your environment is working, as well as fetching and
building the C# microgenerator. By generating an existing API, you
can isolate any possible problems with the new API from any possible
environmental issues.

Note that the first run can take a few minutes, due to cloning
repositories, restoring packages and building the microgenerator.
Subsequent runs should be significantly quicker.

That command should end with:

```text
Generating Google.Cloud.Speech.V1
```

Reset your google-cloud-dotnet clone afterwards (which won't touch googleapis)

```sh
git reset --hard
```

Step 3: Check the API is correct in googleapis
----------------------------------------------

For the rest of the process, you'll need to know the package name
you're trying to generate, which is in Pascal-case. Examples include:

- Google.Cloud.Speech.V1
- Google.Cloud.AssuredWorkloads.V1Beta1
- Google.Cloud.BigQuery.V2

Note how the "B" of "V1Beta1" is capitalized, as are the "W" of
"Workloads" and "Q" of "Query". If you have any doubts about the
desired package name, raise an issue rather than creating a package
with the wrong casing.

Likewise, Cloud APIs should be generated with "Google.Cloud" as the
start of the package name, even if they're not under a
`google.cloud` package in googleapis. Again, raise an issue if you
have any concerns.

The API should be present in the googleapis repo, including:

- Protos describing the service (e.g. [datastore v1](https://github.com/googleapis/googleapis/tree/master/google/datastore/v1)
- A JSON file with gRPC configuration (e.g. [datastore v1](https://github.com/googleapis/googleapis/blob/master/google/datastore/v1/datastore_grpc_service_config.json))

Check that these files all exist, and check that the C# namespace is
appropriate. The protos should contain `csharp_namespace` options
unless the default capitalization produces the correct result, which
it usually does so long as every package segment is a single word.
In general, you can try step 4, and if `./prepare-release.sh add`
works with your expected package ID, it's fine.

If anything doesn't match your expectations, please file an issue in
this repo and we'll get it sorted. (There are complexities here around internal processes.)

Step 4: Modify the API catalog
------------------------------

The "release manager" tooling can add a new package, if its API is present and
correct in googleapis. This is run via the `prepare-release.sh`
script. Use the "add" subcommand, with the package name. For
example, if you wanted to add the Google.Cloud.Dialogflow.Cx.V3
package, you'd run:

```sh
./prepare-release.sh add Google.Cloud.Dialogflow.Cx.V3
```

This will modify the API catalog (`apis/apis.json`) and show you the
entry it's added. Note that currently there are two aspects which
are not automatically populated:

- Tags (which are associated with the NuGet packages for discoverability;
  "Google" and "Cloud" are included automatically, so just add any words
  that are particularly relevant to the API)
- The product URL (for documentation)

These should be edited into apis.json by hand at some point before
the first release. Note that the tooling sets the version to
"1.0.0-beta00" by default, which is effectively "the version before
the first beta release".

Once you're happy with the change, commit it with an explanatory
message, e.g.

```sh
git commit -a -m "Add Google.Cloud.Dialogflow.Cx.V3 to the API catalog"
```

**Note:** If you're using the Dockerfile described in
[ENVIRONMENT.md](ENVIRONMENT.md), please read the notes there around
commiting to git "inside" vs "outside" the container.

Step 5: Generate and build the source code and projects
-------------------------------------------------------

There are two generation steps here: generating the C# files, and
then generating the project files to go along with them.

First, run `generateapis.sh`, specifying the ID of the package:

```sh
./generateapis.sh Google.Cloud.Dialogflow.Cx.V3
```

If all goes well, this should just write (after a few seconds):

```text
Generating Google.Cloud.Dialogflow.Cx.V3
```

That step generates just the C# source code. Next, generate the
project files:

```sh
./generateprojects.sh
```

(Note that you don't need to specify the package name here - it
regenerates *all* the projects - as well as a few other files, if
necessary.)

Use `git status` to check that a new directory has been created
(`apis/Google.Cloud.Dialogflow.Cx.V3` in this example).

Now we can build the package and run the unit tests:

```sh
./build.sh Google.Cloud.Dialogflow.Cx.V3
```

If anything fails here, it's likely to be either an API
configuration problem, or a generator problem. Either way, raise a
GitHub issue - unless you're feeling particularly patient, it's
probably worth waiting for someone on the team to look at it.

If all has gone well, however (which it will do 90+% of the time),
you can now commit everything:

```sh
git add --all
git commit -m "Generate Google.Cloud.Dialogflow.Cx.V3"
```

Step 6: Add smoke tests (where suitable)
----------------------------------------

It's useful to be able to check that the service is actually alive
and listening for requests. Release manager is able to detect good
candidates for non-destructive smoke tests. Run it with the
`suggest-smoke-tests` command, specifying the package ID:

```sh
./prepare-release.sh suggest-smoke-tests Google.Cloud.Dialogflow.Cx.V3
```

For some APIs, there are no suitable (detected) methods. If that's
the case, you'll see output ending in:

```text
Number of smoke tests suggested: 0
```

That's okay - it's not ideal, but it's not a blocker.

If smoke tests *are* suggested, the output will end with a block of
JSON and then a line saying that the JSON has been written to
a `smoketests.json` file (within the `apis/your-package-id`
directory).

**Please review smoke tests before running or committing them.**
In particular, if the RPC sounds like it might be "dangerous" based
on the name (such as the Vision API's `PurgeProducts` method),
you'll want to look really, really carefully.

Once you've reviewed the smoke tests, enable the API in the
[Cloud Console API
dashboard](https://console.cloud.google.com/apis/dashboard) and then
run them with release manager. To run the smoke tests, use the
`smoke-test` command, specifying the package ID. This uses the
`TEST_PROJECT` environment variable, in the same way as the other
integration tests, so set that environment variable first if it's
not already set.

```sh
$ export TEST_PROJECT=your-project-id
$ ./prepare-release.sh smoke-test Google.Cloud.Dialogflow.Cx.V3
```

Note that this assumes you have application default credentials
configured for the test project.

If the smoke test fails first time, it's worth looking into. In
particular, if it's an RPC with a *location* path segment, we
default to putting "us-east1" as the location, for want of anything
better. Look at the documentation of the API to see if there's a
list of valid locations, or another call you can make to find valid
locations. You might also try "global" as the location segment, if
you can't find a specific location. Simply edit the
`smoketests.json` file that was written out by the tool, edit the
argument accordingly, then rerun the smoke tests.

Assuming the smoke tests pass, add and commit them:

```sh
git add --all
git commit -m "Add smoke tests for Google.Cloud.Dialogflow.Cx.V3"
```

If you have enabled the API in your own project for the smoke tests,
please also enable it in our continuous integration project. Details
of this project are in the internal playbook.

Step 7: Create a pull request
-----------------------------

Push your branch to your GitHub fork, and create a pull request in
the normal way. Note that this will *not* publish a package when
merged.

Step 8 (Optional): Release the first package for the API
---------------------------------------------------------

Follow the [releasing process](PROCESSES.md) to push a package to
nuget.org.