workspace(name = "rules_csharp_examples")

load("@bazel_tools//tools/build_defs/repo:git.bzl", "git_repository")

git_repository(
    name = "d2l_rules_csharp",
    # branch = "develop",
    # Master
    commit = "228ca0f66ef494cc9b5483f6fb2e7cdf3eb3c875",
    remote = "https://github.com/jrbeverly/rules_csharp.git",
    shallow_since = "1578695831 -0500",
)

load(
    "@d2l_rules_csharp//csharp:defs.bzl",
    "csharp_register_toolchains",
    "csharp_repositories",
)

csharp_repositories()

csharp_register_toolchains()
