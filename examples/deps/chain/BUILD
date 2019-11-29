load(
    "@d2l_rules_csharp//csharp:defs.bzl",
    "csharp_binary",
    "csharp_library",
)

# FRAMEWORK = ["net472"]

csharp_binary(
    name = "hello",
    srcs = ["hello.cs"],
    target_frameworks = ["net472"],
    deps = [":services"],
)

csharp_library(
    name = "services",
    srcs = ["services.cs"],
    target_frameworks = ["net472"],
    deps = [":data"],
)

csharp_library(
    name = "data",
    srcs = ["data.cs"],
    target_frameworks = ["net472"],
    deps = [":models"],
)

csharp_library(
    name = "models",
    srcs = ["model.cs"],
    target_frameworks = ["net472"],
)
