#!/bin/bash

echo
echo "+======================"
echo "| START: OpKanban"
echo "+======================"
echo

echo 
echo "LABELSITE: Building webapp"
echo
cd OpKanban
dotnet clean
cd ..

echo 
echo "OpKanban: Building container"
echo
docker build -t graboskyc/opkanban:latest .

echo 
echo "OpKanban: Starting container"
echo

docker stop opkanban
docker rm opkanban
docker run -t -i -d -p 666:80 --name opkanban --restart unless-stopped graboskyc/opkanban:latest

echo
echo "+======================"
echo "| END: OpKanban"
echo "+======================"
echo
