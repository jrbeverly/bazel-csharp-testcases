workspace(name = "csharp_examples")

load("@bazel_tools//tools/build_defs/repo:http.bzl", "http_archive")

http_archive(
    name = "d2l_rules_csharp",
    strip_prefix = "rules_csharp-a31980f706ef71e571bbd4f1e34d9ba8adf3decd",
    urls = [
        "https://github.com/jrbeverly/rules_csharp/archive/a31980f706ef71e571bbd4f1e34d9ba8adf3decd.tar.gz",
    ],
)

load(
    "@d2l_rules_csharp//csharp:defs.bzl",
    "csharp_register_toolchains",
    "csharp_repositories",
)

csharp_repositories()

csharp_register_toolchains()