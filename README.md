A simple .NET 7 console app using PowerDNS.client library

To run the project build the provided .Dockerfile and tag the image 

shell
```
docker build --tag pdns . 
docker run –rm –it –p 8081:8081 pdns
```

