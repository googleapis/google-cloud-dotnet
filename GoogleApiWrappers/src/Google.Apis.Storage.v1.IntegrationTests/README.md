Integration test prerequisites
====

The integration tests require:

- A project, identified by the `TEST_PROJECT` environment variable
- An authenticated account with read/write access to the project
- A number of storage buckets with canned data in

The last bullet here can be set up using `setup.bat`, and deleted
with `clean.bat`. Running `setup.bat` will automatically run
`clean.bat` first, to ensure a clean working environment. Currently
only batch files are provided, but the equivalent shell scripts
should be trivial to create.

`setup.bat` will show what appear to be errors for any test buckets
which don't have any files in:

> CommandException: No URLS matched

This can be ignored.

The storage buckets used all start with `${TEST_PROJECT}_integrationtests-`.
Some tests may create buckets and objects; test tear down will
attempt to delete them, but if this fails, they may be safely
deleted by running clean/setup or from the storage browser.
