Google.Common libraries
---

Nothing in this directory is fixed - including the naming, package
structure, or even which repository it will end up in.

The `Google.Common.Embeddable` project is intended to include core
classes which can be embedded directly into other projects using a
dependency with type "build" in `project.json`. As such, it is
possible that multiple copies may end up being loaded in a single
application - the project should remain as small as possible; it
only exists to avoid duplication. The types within this project are
currently all internal.

