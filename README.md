A simple .NET 7 console app using PowerDNS.client library

To run the project build the provided .Dockerfile and tag the image 

shell
```
docker build --tag pdns . 
docker run -d -p 53:53/udp -p 53:53/tcp -p 8081:8081 --restart unless-stopped --name=pdns01 pdns
```

