# csharp_resx base case

Tests that the rule csharp_resx can successfully include a resource file into an executable.

## Usage

You can build it with the following:

```bash
bazel build //examples/core/csharp_resx:hello
```

You can then run it using dotnet:

```bash
dotnet bazel-bin/examples/core/csharp_resx/bazelout/netcoreapp3.0/hello.exe
```
