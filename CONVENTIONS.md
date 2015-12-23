General Coding Conventions
====

Many of these are guidelines more than strict rules, but think
carefully before going against them.

- Code should be formatted as per the [Roslyn codeformatter project](https://github.com/dotnet/codeformatter)
- Accessibility should be explicit
- Classes should be sealed where possible. (Design for inheritance
  or prohibit it.)
- Structs should be immutable.
- All static members should be thread-safe. (Ideally, make shared
  data immutable, but protect it with a lock if it has to be mutable.)

Asynchrony
---

Follow [TAP (Task-based Asynchronous
Pattern)](https://msdn.microsoft.com/en-us/library/hh873175(v=vs.110).aspx)
for asynchronous operations, but using optional parameters to reduce
the number of overloads. For example:

```csharp
public Task<string> FooAsync(string normalParameter, CancellationToken cancellationToken = default(CancellationToken))
```

Or:

```csharp
public Task<string> FooAsync(
    string normalParameter,
    CancellationToken cancellationToken = default(CancellationToken),
    IProgress<int> progress = null)
```

This can be expanded when there is an "extra options" parameter, as
described later:

```csharp
public Task<string> FooAsync(string normalParameter,
    FooOptions options = null,
    CancellationToken cancellationToken = default(CancellationToken),
    IProgress<int> progress = null)
```

Member order
---

*In general*, prefer an order of:

- Compile-time constants (`const` members)
- Static fields
- Static constructor
- Instance fields
- Properties
- Events
- Constructors
- Static factory methods
- Other methods

If a particular static field is only used in a single method,
*consider* declaring it directly before that method. This does not
apply to instance fields, as it's useful to see everything that
constitutes the state of an object in one place. This is also why
properties should appear alongside instance fields.

Optional parameters
---

Optional parameters are discouraged, except in cases where these
conventions specifically recommend their use. The default value for
default arguments must be the default value for the parameter type
(e.g. `default(T)`, `null` or `0`).

Note that changing any aspect of a parameter can be a breaking
change. Making a parameter optional may not be a breaking change if
there are no overloads, but it requires significant care. Changing
the name of a parameter, changing an optional parameter's default
argument, or changing an optional parameter to be a required parameter
is always a breaking change.

API Coding Patterns
====

Each operation should be implemented both synchronously and
asynchronously. Many operations have options, which should be
encapsulated in a mutable class used by both the synchronous and
asynchronous members. Each member in the option class should be
nullable - either a reference type, or a nullable value type. The
options set to non-null values can then be applied to a request at
the appropriate time.

Extra options
---

Options should always be provided after all regular parameters. The option
parameter should be optional with a default argument of `null` to allow
the caller not to specify any options, and the caller should be able to
explicitly use `null` to indicate that they don't want any special options.

The wrapper library should never modify the options object itself
(unless it creates one for some reason). This allows calling code to
construct an appropriate options object and reuse it for multiple
calls.

TBD: Should the options be cloneable? See issue #20 for discussion.

For example:

```csharp
public string Foo(string normalParameter, FooOptions options = null)
public Task<string> FooAsync(
    string normalParameter,
    FooOptions options = null,
    CancellationToken cancellationToken = default(CancellationToken))
```

List operations
---

Operations which list a resource will typically fetch a page at a
time. The synchronous form of this operation should always be lazy,
yielding results as they are fetched. There should be two
asynchronous forms: one which returns a `Task<IList<T>>` such that
when the task completes, all the resources are present, and one 
which returns an `IAsyncEnumerable<T>`. The first of these can be
implemented using the second by just calling the `ToList()` method
from Ix-Async. These two asynchronous operations are distinguished
by `All` appearing in the name of the method that only returns results
when all resources have been fetched. A typical set of signatures would therefore be:

```csharp
public IEnumerable<Book> ListBooks(string normalParameter, ListBooksOptions options = null)
public Task<IList<Book>> ListAllBooksAsync(
    string normalParameter,
    ListBooksOptions options = null,
    CancellationToken cancellationToken = default(CancellationToken))
public IAsyncEnumerable<Book> ListBooksAsync(string normalParameter)
public IAsyncEnumerable<Book> ListBooksAsync(string normalParameter, ListBooksOptions options = null)
```

Note how `ListBooksAsync` does not take a cancellation token;
cancellation is specified when iterating over the result.
