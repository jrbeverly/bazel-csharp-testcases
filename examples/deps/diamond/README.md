# Diamond Dependency

Tests a scenario where two dependencies rely on a common sub-dependency. This can happen with any low level library (data access, logging, models). This is assuming that they use the same base version of the dependency.

The dependency tree looks something like this:

```markdown
> Chat Application (hello)
    > Messaging (services)
        > Auth Service (auth)
    > Servers (format)
        > Auth Service (auth)
```

## Usage

You can build it with the following:

```bash
bazel build //examples/deps/diamond:app
```
