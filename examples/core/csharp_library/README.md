# csharp_library base case

Tests that the rule csharp_library can be successfully included into an executable.

## Usage

You can build it with the following:

```bash
bazel build //examples/core/csharp_library:hello
```

You can then run it using dotnet:

```bash
dotnet bazel-bin/examples/core/csharp_library/bazelout/netcoreapp3.0/hello.exe
```
