Please see [ENVIRONMENT.md](../ENVIRONMENT.md) for details about
this Dockerfile. The short version is:

- It's intended to make it easy to perform builds, tests, releases
  etc under Linux without modifying your local system.
- It has an entry point of `bash` already
- It expects `/google-cloud-dotnet` (in the container) to be a shared volume mount
  using a clone of this repository.
- Run the following commands from the repository root:
  - `docker build -t google-cloud-dotnet docker`
  - `docker run -v $PWD:/google-cloud-dotnet -it google-cloud-dotnet`
