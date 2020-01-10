load(
    "@d2l_rules_csharp//csharp:defs.bzl",
    "csharp_binary",
    "csharp_library",
)

csharp_binary(
    name = "hello",
    srcs = ["hello.cs"],
    deps = [":lib"],
    target_frameworks = ["netcoreapp3.0"],
)

csharp_library(
    name = "lib",
    srcs = ["lib.cs"],
    target_frameworks = ["netcoreapp3.0"],
)