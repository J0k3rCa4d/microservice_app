#!/bin/bash

docker-compose up -d

sleep 60s

echo "Restarting app"
docker-compose restart api