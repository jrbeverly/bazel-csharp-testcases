# Minimal setup of Bazel C# rules

A minimal environment for working with the Bazel C# rules. 

## Usage

If you already have bazel installed, you should be able to perform the following to build the C# binary `hello`:

```bash
bazel build //src:all
```

If you would like to experiment with setting up the environment, I recommend using a docker image. I use the following when working from bash for windows:

```bash
docker run --rm -it -v "//${PWD}":/workspace --workdir=//workspace gcr.io/bazel-public/ubuntu1804:java11 bash

## Inside container
bazel build //src:all
```

This is a linux based image, so if you would like to test the application you will need to copy it out of the symlinked bazel directory (`bazel-bin`).