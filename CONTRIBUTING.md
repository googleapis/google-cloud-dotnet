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
  with `dnu`/`dnx`.

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

    dnx test

Snippet extraction
---

Code in the `snippets` directory can be marked up to be used in the
API reference documentation. The
`Google.GCloud.Tools.GenerateSnippetMarkdown` tool (in the `tools`
directory) extract snippets from projects underneath `snippets`. To
add a snippet, simply include a comment on a line on its own at the
start of the snippet, of the form:

    // <method-name>
    
where *method-name* is the name of the method the snippet should be
attached to as an example. At the end of the snippet, use a closing
comment:

    // </method-name>

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

    // <ListObjects>
    var client = StorageClient.Create();
    // List only objects with a name starting with "Hello"
    var objects = client.ListObjects(bucketId, "Hello");
    // </ListObjects>
    var names = objects.Select(obj => obj.Name).ToList();
    Assert.Contains(_fixture.HelloWorldName, names);
}
```

TBD: Distinguishing between overloads of methods where necessary.

Generating documentation
---

TBD.

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

The Google Cloud Services are designed around REST and RPC principles which
allow a lot of flexibility for all scenarios, but aren't necessarily the simplest
way of expressing common goals. The `Google.GCloud` library is designed to hide
this from callers, sometimes aggregating multiple requests behind a single
method call.

**Let you test your code**

We hate code that can't be tested. Clearly you can run regression tests against
test instances of *actual* Google Cloud Platform services, but you probably want
to be able to run unit tests locally, too. Each service has a *limited*
[test double](http://en.wikipedia.org/wiki/Test_double) of some kind - where
the implementation faithfulness to the real service may vary significantly.

**Avoid global state**

This goes alongside letting your test your code, really: while some explicit
calls around authentication use environmental state to "do the right thing"
automatically, this is easily extracted from the rest of your code, and no global
state is mutated.

Non-goals
---------

**Provide access to every operation in every service**

`Google.GCloud` is a complementary project to the autogenerated client libraries
and [GRPC](http://grpc.io/) code generation. They can be used together in order
to support common tasks on a simple basis, dropping down to lower-level APIs
for anything else. However, this is a binary choice for any given operation: the
underlying calls are not exposed via `Google.GCloud`, so if the API surface does
not allow you to configure a particular option, it can't be added by providing
(for example) a custom RPC request.

**Provide a fully-compatible local stack for every service**

The aim of the test doubles is purely to allow testing of code using this library.
They do not generally provide the same underlying RPC API, and avoid persisting
any data. They're fine for unit tests, but full system tests should be performed
against real servers.
