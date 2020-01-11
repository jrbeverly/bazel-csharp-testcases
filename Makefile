.DEFAULT_GOAL:=help

DIR := $(dir $(realpath $(firstword $(MAKEFILE_LIST))))

.PHONY: help
help: ## This help text.
	@awk 'BEGIN {FS = ":.*##"; printf "Usage: make \033[36m<target>\033[0m\n"} /^[a-zA-Z_-]+:.*?##/ { printf "  \033[36m%-10s\033[0m %s\n", $$1, $$2 } /^##@/ { printf "\n\033[1m%s\033[0m\n", substr($$0, 5) } ' $(MAKEFILE_LIST)

##@ Bazel

.PHONY: build
build: ## Build the dotnet bazel docker image
	@bazel build //examples/...

.PHONY: clean
clean: ## Cleans the docker environment
	@bazel clean

##@ Docker

.PHONY: docker
docker: ## Build the dotnet bazel docker image
	@docker build \
		-t bazel-csharp \
		-f .github/environments/dotnet-bazel/Dockerfile \
		.github/environments/dotnet-bazel/.

.PHONY: exec
exec: ## Run an interactive docker session
	@docker run --rm -it \
		-v "/${PWD}":/workspace \
		--workdir=//workspace \
		bazel-csharp bash