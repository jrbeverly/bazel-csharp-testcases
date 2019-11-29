load(
    "@d2l_rules_csharp//csharp:defs.bzl",
    "csharp_binary",
    "csharp_library",
)

csharp_binary(
    name = "app",
    srcs = ["chatapp.cs"],
    target_frameworks = ["net472"],
    deps = [
        ":messaging",
        ":servers",
    ],
)

csharp_library(
    name = "servers",
    srcs = ["servers.cs"],
    target_frameworks = ["net472"],
    deps = [":auth"],
)

csharp_library(
    name = "messaging",
    srcs = ["message.cs"],
    target_frameworks = ["net472"],
    deps = [":auth"],
)

csharp_library(
    name = "auth",
    srcs = ["auth.cs"],
    target_frameworks = ["net472"],
)
