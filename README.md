# **OneCloudNet**
.Net client for 1cloud.ru service REST API.

.NET wrapper for the Firebase REST API.

####Installation (NuGet)
```csharp
Install-Package OneCloudNet
```
### Usage
[OneCloudNetClient](https://github.com/partyz0ne/OneCloudNet/blob/master/OneCloudNet/Client/Client.cs) uses [RestSharp](https://github.com/restsharp/RestSharp).

#### API token
------------------------------

1cloud.ru service requires uinique user API token for authorization, which is added to each request.

```csharp
String token = "75bb9805c018b1267b2cf599a38b95a3a811e2ef7ad9ca5ed838ea4c6bafaf50";
IOneCloudNetClient client = new OneCloudNetClient(token);
```
So far, supported methods are realized in two ways:
Asynchronious calls:
```csharp
void GetImages(Action<List<Image>> success, Action<OneCloudException> failure);
void GetServers(Action<List<Server>> success, Action<OneCloudException> failure);
void GetServer(Int32 serverID, Action<Server> success, Action<OneCloudException> failure);
void CreateServer(String name, Int32 cpu, Int32 ram, Int32 hdd, String imageID, Action<Server> success, Action<OneCloudException> failure);
void ChangeServer(Int32 serverID, Int32 cpu, Int32 ram, Int32 hdd, Action<Action> success, Action<OneCloudException> failure);
void DeleteServer(Int32 serverID, Action<IRestResponse> success, Action<OneCloudException> failure);
void PowerServer(Int32 serverID, Power type, Action<Action> success, Action<OneCloudException> failure);
void GetActions(Int32 serverID, Action<List<Action>> success, Action<OneCloudException> failure);
void GetAction(Int32 serverID, Int32 actionID, Action<Action> success, Action<OneCloudException> failure);
```
and synchronious calls:
```csharp
IEnumerable<Image> GetImages();
IEnumerable<Server> GetServers();
Server GetServer(Int32 serverID);
Server CreateServer(String name, Int32 cpu, Int32 ram, Int32 hdd, String imageID);
Action ChangeServer(Int32 serverID, Int32 cpu, Int32 ram, Int32 hdd);
Boolean DeleteServer(Int32 serverID);
Action PowerServer(Int32 serverID, Power type);
IEnumerable<Action> GetActions(Int32 serverID);
Action GetAction(Int32 serverID, Int32 actionID);

More features and documentation are coming soon.

More information about 1cloud.ru service and API is available at the
[official website](http://www.1cloud.ru/).


## License
Code and documentation are available according to the *Apache* License (see [LICENSE](https://github.com/partyz0ne/OneCloudNet/blob/master/LICENSE)).