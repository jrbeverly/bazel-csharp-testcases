# Common Lib Dependency

Tests a scenario where every library depends on a single common base library. You could see this library being for logging, serialization, or any cross-cutting concern really.

The dependency tree looks something like this:

```markdown
> Application (hello)
    > Formatting (format)
    > Utilities (services)
        > Formatting (format)
    > Models (data)
        > Formatting (format)
```

## Usage

You can build it with the following:

```bash
bazel build //examples/deps/common-lib:hello
```
