# Tests for Bazel rules_csharp

A collection of simple C# programs that are compiled using the bazel rules for csharp.

You can see a forked copy of the bazel rules at [jrbeverly/rules_csharp](https://github.com/jrbeverly/rules_csharp)

## Objectives

While working on the bazel csharp rules, I have come up with a couple test cases that don't fit in with the rules_csharp repository (at the moment), so I want to have a separate repository where I can commit and test the usages. Much like how an actual third party would work with the bazel rules.

You can review the requirements for all of these programs [here](docs/criteria.md).

## Getting started

These examples cover the following:

* [core](src/core/): Minimal example to show the usage of the core rules.

* [deps](src/deps/): Dependency trees with the rules.

* [examples](src/examples/): Example usages of simple real applications.

* [resx](src/resx/): Edge cases while working with resx files.


### Docker Development

A bash script exists for testing out the examples in [linux by docker](docker.bash). Be aware that the compiled binaries will not work on linux (unless .NET Core), and will need to be copied out of the symlinked `bazel-*` directories to be used from windows.

For example:

```bash
bazel build //src/core/csharp_binary:all
cp -r bazel-bin/src/core/csharp_binary/bazelout/net472/ bin/
```

Then from your local windows environment, you can run the executable as such:

```powershell
.\bin\hello.exe
```
