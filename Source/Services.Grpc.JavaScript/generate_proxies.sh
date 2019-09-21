#!/bin/bash
find . -type f -iname '*.ts' ! -iname "index.*" -not -path './node_modules/*' -delete
find . -type f -iname '*.js' ! -iname "index.*" -not -path './node_modules/*' -delete

npx protoc -I./ \
            -I../ \
            --js_out=import_style=commonjs,binary:./ \
            --ts_out=service=grpc-node:./ \
            --grpc_out=./ \
            --plugin=protoc-gen-grpc=./node_modules/.bin/grpc_tools_node_protoc_plugin \
            --plugin=protoc-gen-ts=./node_modules/.bin/protoc-gen-ts \
            ../Services/**/*.proto \
            ../system/*.proto
            