# csharp_binary base case

Tests that the rule csharp_binary can successfully build the 'Hello, World!' program.

## Usage

You can build it with the following:

```bash
bazel build //examples/core/csharp_binary:hello
```

If you wish to run the example, you will need to manually call the executable with `dotnet`:

```bash
dotnet bazel-bin/examples/core/csharp_binary/bazelout/netcoreapp3.0/hello.exe
```
