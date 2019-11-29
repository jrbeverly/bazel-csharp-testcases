load(
    "@d2l_rules_csharp//csharp:defs.bzl",
    "csharp_binary",
    "csharp_library",
)

csharp_binary(
    name = "app",
    srcs = ["app.cs"],
    target_frameworks = ["net472"],
    deps = [":casing"],
)

csharp_library(
    name = "casing",
    srcs = ["casing.cs"],
    target_frameworks = ["net472"],
)
