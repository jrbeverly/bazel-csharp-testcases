# Usage of the Bazel C# Rules

A minimal example for testing that downloading and building a simple case is working as intended.

## Usage

If you already have `bazel` installed, you can use the following to build the C# application `hello`:

```bash
bazel build //src:all
```

If you would like to experiment with setting up the environment, I recommend using a docker image. You can spin one up using the following:

```bash
docker run --rm -it -v "//${PWD}":/workspace --workdir=//workspace gcr.io/bazel-public/ubuntu1804:java11 bash

# Inside container
bazel build //src:all

# If you are on a windows machine, copy then run
# the symlink for `bazel-*` only works in the container
cp -R bazel-bin/src/bazelout/net472/ bin/

# locally:
./bin/hello.exe
# 'Hello, world!'
```

Or you can use the bash helper script available at the root of the repository ([docker.bash](../docker.bash)). Both of these examples are using a linux based image, so you will need to copy the compiled binaries from the symlinked bazel directories before you can use them on windows.
