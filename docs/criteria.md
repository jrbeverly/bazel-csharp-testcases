# Criteria

All the programs in this repository are expected to obey some rules. This helps when debugging or diagnosing issues with the bazel rules. All the programs under `src/` must follow the guidelines.

- There needs to be a `README.md`
- The program must aim to test a single thing (or build ontop of an existing program)
- The program must be built using `bazel build` (with no additional steps or processes)
- The program cannot have pre-requisites before running
- The program cannot be flakey (it must work the first time)
- The program will be built during CI
- The program must work on all platforms (CI runs on all of them)

If a program is an API/usage design, it can be placed in the `designs/` folder without meeting all of the above criteria.