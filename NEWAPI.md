Adding a new API
================

While this process will usually be performed by Googlers, there's
nothing confidential about it, and it may be of interest to third
parties.

Prerequisites:

- A Linux machine with git and Java 8+ installed
- A Windows machine with Git for Windows and Visual Studio 2017
  (including .NET Core tools) installed

Note that Git for Windows includes bash, and that's what our scripts
have all been written to use. Do not try to use the Linux subsystem
for Windows to run the scripts - at least not yet.

Relevant repositories:

- [googleapis](https://github.com/googleapis/googleapis): API definitions
- [toolkit](https://github.com/googleapis/toolkit): Code generator, also known as GAPIC
- [google-cloud-dotnet](https://github.com/GoogleCloudPlatform/google-cloud-dotnet): This
  repository, where code will end up

This list of instructions looks daunting, but it's not as bad as it
seems: it aims to be pretty comprehensive, although it assumes you
know how to use `git` appropriately.

Step 1: Fork google-cloud-dotnet on github
------------------------------------------

Our process is to merge from user-owned forks, so first fork this repo.

Step 2: Check the API is correct in googleapis
----------------------------------------------

The API should be present in the googleapis repo, including:

- Protos describing the service (e.g. [datastore v1](https://github.com/googleapis/googleapis/tree/master/google/datastore/v1)
- A YAML file (e.g. [datastore.yaml](https://github.com/googleapis/googleapis/blob/master/google/datastore/datastore.yaml)) containing
  more general service metadata
- A GAPIC YAML file (e.g. [datastore_gapic.yaml](https://github.com/googleapis/googleapis/blob/master/google/datastore/v1/datastore_gapic.yaml)
  containing more semantic information required by the code generator, such as how resources are organized and named

Check that these files all exist, and check that the C# namespace is
appropriate. The protos should contain `csharp_namespace` options
unless the default capitalization produces the correct result. The
same namespace should be specified in the GAPIC YAML file under
`language_settings > csharp > package_name`.

If anything doesn't match your expectations, please file an issue in
this repo and we'll get it sorted. (There are complexities here around internal processes.)

Step 3: Clone your fork on the Linux machine
--------------------------------------------

If you're going to do this regularly, you may wish to add remotes
for both your fork and this one, so you can easily get up-to-date.

My personal preference is to then create a branch in the clone,
rather than making the change in master, but it doesn't matter too much.

Step 4: Add the API to generateapis.sh
--------------------------------------

Adding an API will usually be as simple as adding a line like this
to the section at the bottom of `generateapis.sh` in the root
directory:

```text
generate_api Google.Cloud.Datastore.V1 google/datastore/v1 datastore.yaml
```

The first argument to the `generate_api` function is the API
namespace (our tooling is too primitive to work it out from the
files, at the moment). The second argument is the directory within
the `googleapis` repo. The third argument is the name of the general
YAML file for the service. (It's assumed there will only be one file
ending with `_gapic.yaml`.)

Please keep the list of `generate_api` calls in alphabetical order.

Step 5: Run generateapis.sh
---------------------------

This will clone both the `googleapis` and `toolkit` repos as
subdirectories, or pull them if they already exist.

This may take a while, and will spew a lot of output. If it fails
with a Java exception, that's probably due to a configuration issue
somewhere. You can try to fix it yourself, but it's probably worth
reaching out at that point.

Step 6: Commit just the changes for your API
--------------------------------------------

You may see changes for other APIs, and right now (August 2017)
you'll also see some new files to do with the Natural Language beta
API. Ignore those. Create a commit containing:

- Your `generateapis.sh` change
- The new directory under `apis`

Push this change up to your fork on github. Don't create a PR yet.

Step 7: Pull your change on Windows
-----------------------------------

Clone your fork on Windows if you haven't already, and pull your
change. (I find `git fetch --all` handy here, then just checkout
your new branch.)

Step 8: Modify the API catalog
------------------------------

Edit `apis/apis.json`. Again, this is in alphabetical order - please keep it that way.
You'll typically want JSON like this:

```json
{
  "id": "FIXME",
  "productName": "FIXME",
  "productUrl": "FIXME",
  "version": "1.0.0-alpha00",
  "type": "grpc",
  "description": "FIXME",
  "tags": [ "FIXME_1", "FIXME_2" ],
}
```

Fix everything with "FIXME". There's no set number of tags, but these are used for the NuGet package,
so consider what users will search for.

The version number of "1.0.0-alpha00" is used to indicate that there
hasn't been a release of this API yet. It will be incremented to
`1.0.0-alpha01` as part of the first release.

If your project uses the IAM or long-running operations APIs, you'll need to add dependencies for those, e.g.

```json
"dependencies": {
  "Google.LongRunning": "project",
  "Google.Cloud.Iam.V1": "project"
}
```

Look at other APIs for example values.

Step 9: Generate files
----------------------

Run `generateprojects.sh`. This should create:

- A solution file
- Project files for the production project and the snippets
- A stub documentation file

Open the solution file in Visual Studio, to check that everything
builds.

Step 10: Commit changes
-----------------------

Commit the change to `apis.json` and the generated files.

Step 11: Create at least one snippet
------------------------------------

In the Snippets project, add a new test class for the main client class,
e.g. `FooClientSnippets.cs`. Add a snippet to test at least one API
method. This has two benefits:

- It checks the API works
- It provides the first piece of concrete documentation

You may choose to add a fixture class and write a whole bunch of
snippets as integration tests now, but at least create a snippet to
include in the documentation. See
[SpeechClientSnippets.cs](https://github.com/GoogleCloudPlatform/google-cloud-dotnet/blob/master/apis/Google.Cloud.Speech.V1/Google.Cloud.Speech.V1.Snippets/SpeechClientSnippets.cs)
for an example.

Step 12: Edit documentation
---------------------------

In step 9, a `docs/index.md` file will have been generated. Edit it
now:

- Give a link to the client classes
- Include the snippet you wrote in step 11

See the [Speech
docs](https://raw.githubusercontent.com/GoogleCloudPlatform/google-cloud-dotnet/master/apis/Google.Cloud.Speech.V1/docs/index.md)
for an example.

Note that the template-like `{{title}}` lines can be left as they
are - they will be filled in by the documentation process
automatically.

Step 13: Commit changes
-----------------------

Commit the new snippet and documentation changes.

Step 14: Push and create a PR
-----------------------------

Push your extra commits back to github, then create a PR to merge into the master branch of `google-cloud-dotnet`.
You should have three commits - it's handy to preserve those for clarity:

- Modification of `generateapis.sh` and the generated code
- Modification of `apis.json` and the generate project files
- First snippet and documentation changes
