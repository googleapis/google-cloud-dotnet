Integration or snippet test prerequisites
====

The integration tests require:

- A project, identified by the `TEST_PROJECT` environment variable
- A Bigtable instance, preferably of type Development, created within the
projet and identified by the `BIGTABLE_TEST_INSTANCE` environment variable.
- An authenticated account with read/write access to the project, including the
IAM permissions in the Bigtable Administrator role.

Alternatively, the integration tests can be run against the emulator:

- A running emulator on the local machine, started by using the
`gcloud beta emulators bigtable start` command.
- The `BIGTABLE_EMULATOR_HOST` environment variable set to `localhost:8086`.

Currently there are no runnable snippets, but when they are added, they will
have the same requirements.
