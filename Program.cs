// See https://aka.ms/new-console-template for more information
using PowerDns.Client;
using PowerDns.Client.Models;

var client = new PowerDnsClient(
    uri: new Uri("pdns:8081"), // without /api/v1
    apiKey: "changeme");

var zonesEndpoint = client.Servers["localhost"].Zones;

List<Zone> zones = await zonesEndpoint.ReadAllAsync();

RecordSet recordSet = await zonesEndpoint["example.org"].GetRecordSetAsync("www.example.org");
