# csharp_binary base case

Tests to ensure that building a csharp is building successfully.

Idea of a dependency that everything relies on a single file. You might see this in an application that relies on Newtonsoft.Json (or utility function used by this). (Also logging / base models)

## Usage

You can build it with the following:

```bash
bazel build //src/deps/fundamental:hello
```

You can then run the application with the following:

```bash
.\bin\hello.exe
Hello, world!
```