# Environment for building etc

This repository contains many scripts for builds, releases, continuous
integration, etc. This file describes the environment prerequisites
for those scripts.

## Handy Dockerfile for working on Linux

Installing some of the dependencies can be tricky, particularly on
restricted internal versions of Linux. For that reason, we provide a
[Dockerfile](docker/Dockerfile) to get started with, which has
`bash` as an entry point. The typical procedure would be:

- `git clone --recursive https://github.com/googleapis/google-cloud-dotnet.git`
- `cd google-cloud-dotnet`
- `docker build -t google-cloud-dotnet docker`
- `docker run -v $PWD:/google-cloud-dotnet -it google-cloud-dotnet`

Building the Docker image the first time can be slow, but it should
work without intervention.

The last line will start a Docker container mounting the current
directory in the host system as `/google-cloud-dotnet`. This allows
you to make changes (e.g. generating an API or building a NuGet
package) and then use your regular environment to create a pull
request, upload the package somewhere etc.

### Working with git and Docker

If you're using the Docker container for work that will eventually
involve a pull request, you may run into issues if you try creating
some commits within the container and some outside the container in
your regular environment:

- Once you've created a commit within the container, you may run
  into permissions issues when you try to create a commit outside the
  cnotainer.
- The container doesn't have access to your normal git configuration,
  so won't be able to access your name and email address for the
  commit author.

If you're creating commits manually, we recommend you do this
outside the container, so you can use all the configuration and
tooling you're normally used to. If you're creating a release commit
using `prepare-release.sh commit`, we recommend that you configure
git within the container.

## Operating system

We mostly develop on Windows and Linux. When building on Linux, we
don't test the full desktop .NET framework version, although we
build it using reference assemblies.

On Windows, please run scripts under the version of `bash` that comes
with Git for Windows.

The scripts here should work on OS X as well, but we haven't tried
them. Please file an issue if you run into problems.

## .NET Core SDK

The version of the .NET Core SDK required is specified in
[global.json](global.json).

## Python 3 (3.6+)

This is required for some aspects of API generation
(generateapis.sh). It expected to be available via just `python`,
`py 3` or `python3`.

It's expected that `pip` is also installed.

## Other tools

The following common tools are expected to be available:

- `bash`
- `git`
- `curl`
- `unzip`
