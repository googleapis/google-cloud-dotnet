Contributing
============

1. **Please sign one of the contributor license agreements below.**
1. Fork the repo, develop and test your code changes, add docs.
1. Make sure that your commit messages clearly describe the changes.
1. Send a pull request.

Contributor License Agreements
------------------------------

Before we can accept your pull requests you'll need to sign a Contributor
License Agreement (CLA):

- **If you are an individual writing original source code** and **you own the intellectual property**,
then you'll need to sign an [individual CLA][individual-cla].
- **If you work for a company that wants to allow you to contribute your work**,
then you'll need to sign a [corporate CLA][corporate-cla].

You can sign these electronically (just scroll to the bottom). After that,
we'll be able to accept your pull requests.

[individual-cla]: https://developers.google.com/open-source/cla/individual
[corporate-cla]: https://developers.google.com/open-source/cla/corporate

Code Layout
===

The source code is divided into subdirectories based on its purpose:

- `src`: the main API code, shipped as NuGet packages
- `test`: tests of the code in `src`, both unit tests and
  integration tests
- `snippets`: small pieces of code used to add examples to the API
  reference and demonstrate the functionality available. These are
  written in the form of integration tests, but are not expected
  to fully test the functionality of the API. Instead, the assertions
  are really present to ensure that the snippets themselves are
  correct.
- `tools`: tools used within this project. These are not shipped
  externally, and not expected to be used by developers who only
  need to access the Google APIs covered in this repository.

Running the tests
---

As noted above, both the `snippets` directory and the `test`
directory contain tests, of different flavours. All tests use
[xUnit.Net](http://xunit.github.io/). Unit tests do not require
any access to Google Cloud Platform, but the integration tests
and snippet tests require a Google Cloud Platform project with
billing enabled.

**Please note that running the tests exercises the real API
against real Google Cloud Platform projects.** The tests are
designed not to require too much in the way of resources, but you
should be aware that there *is* a cost to exercising APIs. In future
we may run tests against emulators where available. We **strongly**
advise you to use a dedicated testing project (rather than a
project relied on by production systems) to avoid any possible data loss.

To run integration tests with your project, you need to perform some
set-up steps:

- Ensure that your project has the corresponding API enabled in
  the [API Manager](https://console.developers.google.com/apis/library)
- Download and install the [https://cloud.google.com/sdk/](Cloud SDK)
- Run `gcloud auth login` to set up default application credentials
- Set the `TEST_PROJECT` environment variable to the name of your project.
  To run the tests from a command line, you can just set them directly
  and run the tests. To run the tests from Visual Studio, you should set
  the environment variable permanently, and restart Visual Studio if
  it's already running.
- Build all the code, either from Visual Studio, or from the command line
  with `dotnet test`

<!---
TODO: Can we just set the environment variable in the
project properties in VS? It looks like it should work, but I
haven't tried...
--->

The tests can be run from Visual Studio's built-in test runner
(under the "Test" menu, select "Run" then "All Tests"), or
third-party test tools such as ReSharper and CodeRush, or from the
command line. To run from the command line, change to the project
directory and simply run

    dotnet test

Snippet extraction
---

Code in the `snippets` directory can be marked up to be used in the
API reference documentation. The
`Google.GCloud.Tools.GenerateSnippetMarkdown` tool (in the `tools`
directory) extract snippets from projects underneath `snippets`. To
add a snippet, simply include a comment on a line on its own at the
start of the snippet, of the form:

    // Snippet: <method-name>
    
or

    // Sample: <sample-name>
    
where *method-name* is the name of the method the snippet should be
attached to as an example. At the end of the snippet, use a closing
comment:

    // End snippet
    
or

    // End sample

The extraction tool assumes certain
conventions:

- The project name is the API name with a suffix of `.Snippets`
- The namespace of the type being documented matches the project name
- The name of the file containing the snippet matches the name of the
  type being documented, with a suffix of `Snippets`.
  


A full example is shown below, which will attach a snippet to the
`StorageClient.ListObjects` documentation. Only the three lines
(including a comment) between the start and end tag comment lines
are present in the documentation. Currently we assume that the user
will know the meaning of `bucketId` (and likewise other resource IDs
or names which are likely to crop up).

```csharp
[Fact]
public void ListObjects()
{
    var bucketId = _fixture.BucketId;

    // Snippet: ListObjects
    var client = StorageClient.Create();
    // List only objects with a name starting with "Hello"
    var objects = client.ListObjects(bucketId, "Hello");
    // End snippet
    var names = objects.Select(obj => obj.Name).ToList();
    Assert.Contains(_fixture.HelloWorldName, names);
}
```

The difference between a snippet and a sample is that a snippet must
match at least one member, and will end up in the API reference
documentation for that member, whereas a sample is designed to be
referenced from other documentation written in Markdown.

See the [tool source
code](tools/Google.GCloud.Tools.GenerateSnippetMarkdown/Program.cs)
for more details.

Generating documentation
---

See [docs/README.md](docs/README.md).

Code Style
==========

Goals
-----

**Provide idiomatic .NET support for a subset of Google Cloud Platform Services**

The approach taken is client-code-first: "if I wanted to perform a particular
task in C# using Google Cloud Services and I could make the implementation do
whatever I want, what would the API look like?"

This extends to making it as simple as humanly possible to accomplish simple
tasks. More complex or unusual tasks may be harder or even impossible, but we're
heavily biased towards common use cases.

The Google Cloud Services are designed around REST and RPC
principles which allow a lot of flexibility for all scenarios, but
aren't necessarily the simplest way of expressing common goals. The
Google Cloud Libraries for .NET are designed to hide this from
callers, sometimes aggregating multiple requests behind a single
method call.

The libraries often supply several different abstraction layers,
depending on client needs. They are designed to allow application
code to fall back from a higher level abstraction to a lower level
one where more fine-grained control is required. This is usually at
the expense of some of the convenience provided by the higher level
abstraction, but can be performed in a piecemeal way: application
code should be able to use the various abstraction layers together
without ever feeling like changing from one to another is falling
off a usability cliff.
