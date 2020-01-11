load(
    "@d2l_rules_csharp//csharp:defs.bzl",
    "csharp_binary",
    "csharp_resx",
)

csharp_binary(
    name = "hello",
    srcs = glob(["*.cs"]),
    resources = [":Hello.Strings"],
    target_frameworks = ["netcoreapp3.0"],
    deps = ["@net//:System.Linq"],
)

csharp_resx(
    name = "Hello.Strings",
    src = "Strings.resx",
)
