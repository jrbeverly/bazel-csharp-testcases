# Tests for Bazel rules_csharp

A collection of simple C# programs that are compiled using the bazel rules for csharp.

You can see a forked copy of the bazel rules at [jrbeverly/rules_csharp](https://github.com/jrbeverly/rules_csharp)

## Getting started

These examples cover the following:

* [core](core/): Minimal example to test the usage of the core rules.

* [deps](deps/): Dependency trees with the rules.

* [examples](examples/): Example usages of interesting scenarios.

* [resx](resx/): Edge cases while working with resx files.

You can build all of these examples with the following:

```bash
bazel build //examples/...
```

### Docker Development

A bash script exists for testing out the examples in [linux by docker](../docker.bash). Be aware that the compiled binaries will not work on linux (unless .NET Core), and will need to be copied out of the symlinked `bazel-*` directories to be used from windows.

For example:

```bash
bazel build //src/core/csharp_binary:all
cp -r bazel-bin/src/core/csharp_binary/bazelout/net472/ bin/
```

Then from your local windows environment, you can run the executable as such:

```powershell
.\bin\hello.exe
```
