# Tests for Bazel rules_csharp

A collection of simple C# programs that are compiled using the bazel rules for csharp.

You can see a forked copy of the bazel rules at [jrbeverly/rules_csharp](https://github.com/jrbeverly/rules_csharp)

## Objectives

While working on the bazel csharp rules, I have come up with a couple test cases that don't fit in with the rules_csharp repository (at the moment), so I want to have a separate repository where I can commit and test the usages. Much like how an actual third party would work with the bazel rules.

## Criteria

All the programs in this repository are expected to obey some rules. This helps when debugging or diagnosing issues with the bazel rules. All the programs under `src/` must follow the guidelines.

- There needs to be a `README.md`
- The program must aim to test a single thing (or build ontop of an existing program)
- The program must be built using `bazel build` (with no additional steps or processes)
- The program cannot have pre-requisites before running
- The program cannot be flakey (it must work the first time)
- The program will be built during CI
- The program must work on all platforms (CI runs on all of them)

If a program is an API/usage design, it can be placed in the `designs/` folder without meeting all of the above criteria.
