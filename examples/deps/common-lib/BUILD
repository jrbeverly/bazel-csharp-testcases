load(
    "@d2l_rules_csharp//csharp:defs.bzl",
    "csharp_binary",
    "csharp_library",
)

csharp_binary(
    name = "hello",
    srcs = ["hello.cs"],
    target_frameworks = ["net472"],
    deps = [
        ":format",
        ":models",
        ":utilities",
    ],
)

csharp_library(
    name = "utilities",
    srcs = ["utilities.cs"],
    target_frameworks = ["net472"],
    deps = [":format"],
)

csharp_library(
    name = "models",
    srcs = ["model.cs"],
    target_frameworks = ["net472"],
    deps = [":format"],
)

csharp_library(
    name = "format",
    srcs = ["format.cs"],
    target_frameworks = ["net472"],
)
