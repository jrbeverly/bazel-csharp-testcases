# Dependency Chain

Tests to ensure that building a csharp is building successfully.

The chain is linear as such:

```markdown
> Application (hello)
    > Web Services (services)
        > Data Access (data)
            > Models (model)
```

## Usage

You can build it with the following:

```bash
bazel build //src/deps/chain:hello
```

You can then run the application with the following:

```bash
.\bin\hello.exe
Hello, world!
```