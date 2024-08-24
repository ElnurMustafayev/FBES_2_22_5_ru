docker build -f postgres.Dockerfile -t mypostgres .
docker run -d --rm -p 5432:5432 --name mypostgresdb --network=mynetwork -v mypostgresdb_data:/var/lib/postgresql/data mypostgres

docker build -f app.Dockerfile -t mywebapi .
docker run -d --rm -p 5000:8080 --name mywebapiapp --network=mynetwork mywebapi

docker exec -it mypostgresdb bash
docker exec -it mywebapiapp bash

apt update
apt install -y dnsutils