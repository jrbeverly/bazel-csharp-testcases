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
