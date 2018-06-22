Benchmarks for Google.Cloud.BigQuery.V2
---

Note: the benchmarks end up creating long directory names, and will
fail if the benchmark root directory is already a reasonably long
name. Create a junction or symlink at a higher directory level to
avoid this.

Symptom: all benchmarks fail, with an error such as:

> An assembly specified in the application dependencies manifest (*guid*.deps.json) was not found

Running
===

To run with an interactive menu, run with no arguments (just the
framework for `dotnet run`):

```text
dotnet run -c Release -f netcoreapp2.0
```

To run all the benchmarks, specify `*` as a command line argument:

```text
dotnet run -c Release -f netcoreapp2.0 -- '*'
```

To run a single benchmark class, use `--class=`:

```text
dotnet run -c Release -f netcoreapp2.0 -- --class=BigQueryNumericBenchmark
```

To run a single method, use `--method=`:

```text
dotnet run -c Release -f netcoreapp2.0 -- --method=Parse_Huge
```

Results
===

The results are generated in `BenchmarkDotNet.Artifacts/results`,
with one file per test class, per exporter.
