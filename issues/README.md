# Issues repro code

This directory contains code used to reproduce (or *attempt* to
reproduce, potentially including "here's the fix") issues.

This code is *not* built by CI, and dependencies aren't updated by
Renovate.

Broad guidelines:

- Unless a UI is required, console apps are preferred for brevity.
- Each issue should be in its own directory, each Issue12345
- Where only a single project is needed, that's simpler than
  creating a solution with subdirectories. If multiple projects
  are needed later, it's best to move each project to a subdirectory
  at that point. (It's fine to create a solution file in the same
  directory as the project while there's still a single project.
  That avoids VS prompting when closing it.)
- Every file must have copyright statements as normal
- Where project IDs, resource names etc are required, these should
  be command line parameters (or taken from environment variables)
  rather than hard-coded.
- Sometimes project references are useful (e.g. to step in when
  debugging, or test a change); other times it's fine to use NuGet
  package references.
