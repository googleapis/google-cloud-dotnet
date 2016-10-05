This directory contains repo-wide documentation and build scripts
for documentation. It also contains templates for API-specific
documentation.

The documentation is hosted on GitHub pages, and built using docfx.

There are two kinds of documentation:

- General, API-agnostic documentation such as how resource names work,
  how we exposed paged lists of resources, etc.
- API-specific documentation, including getting started guides,
  introductory snippets, an API reference documentation.
  
The `gh-pages` branch has the following layout, using
`Google.Pubsub.V1` as an example of an API.

(This is all currently under "docs" - there's a branded index.html
at the very top level, which may change.)

- index.html: Landing page listing all APIs and general articles
- resource-names.html: General documentation page
- api/ (API reference docs for GAX and other API-neutral libraries)
- Google.Pubsub.V1
  - index.html: Pub/Sub landing page, with:
    - Authentication
    - Getting started
    - Links to API-specific articles (e.g. push.html)
    - Links to general articles (e.g. resource-names.html)
  - push.html: More details on Pub/Sub push notifications
  - api/ (API reference documentation)
    - index.html (table of contents)
    - Google.Pubsub.V1.PublisherClient.html
    - ...
    
The API reference documentation for each library should be complete
in terms of direct dependencies. For example, gRPC-based APIs should
include the gRPC API documentation, GAX etc.

Each API has its own specific documentation (if any) in a `docs`
directory within `apis/Google.*`. If there is no specific
documentation, it is auto-generated from the templates here.

Build process for general documentation
===

- Run docfx in this directory. There's no metadata; it's just
articles.
- Copy the output into the `gh-pages` branch

Build process for per-API documentation
===

- Determine which projects are shipped. For example, for logging
  we want to document Google.Logging.Type, Google.Logging.V2 and
  Google.Logging.Log4Net. In general, if the project.json file
  has a version number, it's a shipped package.
- Examine project.json to find dependencies
- Fetch those dependencies (hand-waving around versioning...)
- Create a docfx.json to include all the dependencies and project
  source
- Run `docfx metadata -f` to generate all the metadata
- Run our snippet extraction tool to generate snippets from the
  `*.Snippets` projects
- Apply the templates from this directory to the API-specific landing
  page documentation (so we always get a consistent introductory step)
- Run `docfx build`
- Copy result into a directory for the API in `gh-pages`
    
Open questions
===

- How long can we survive with no versioning?
- Where does this get automated?
- Do we really need a landing page and a separate docfx-generated
  index.html? 
- How do we clean up deleted general articles from the gh-pages branch? Or
  does that never happen?
- How does the per-API-landing-page template work?
