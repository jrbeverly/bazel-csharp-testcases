# Chained Dependencies

Tests a chained dependency. You might see something like this in a web application where each layer builds ontop of the next (models, data access, services, application).

The dependency tree looks something like this:

```markdown
> Application (hello)
    > Web Services (services)
        > Data Access (data)
            > Models (model)
```

## Usage

You can build it with the following:

```bash
bazel build //examples/deps/chain:hello
```
