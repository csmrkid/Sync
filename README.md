# Sync

##Description
This is a **Demo** project to show you how to query timezone api and sync up with our Oracle database.

##Basic Requirement
**.Net 4.5.2**

##Important
Before you execute this app,please modify  **add key="clientBase" value="http://localhost:8070/** to our api url in the app.config.

##How

The query url is {clientBase}+'/api/geo/geocoding/query/{location}'", where 

1. **{location}** can be any country,city or specific address, except Mars or Juniper.
2. **{clientBase}** will be read from app.config

##Note
To understand how to query timezone API , you might just need to focus on the comment,"HTTP GET"(C#), instead of downloading entire repo.

**..**.
```C#
using (var client = new HttpClient())
{
                client.BaseAddress = new Uri(clientBase);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // HTTP GET
                HttpResponseMessage response = await client.GetAsync(clientBase+"/api/geo/geocoding/query/" + location);

                if (response.IsSuccessStatusCode)
                {
                    var jsonAsString = await response.Content.ReadAsStringAsync();
                    var g = JsonConvert.DeserializeObject<wrapper>(jsonAsString);
                    Console.WriteLine("{0}\t${1}\t{2}", g.data.day, g.data.displayName, g.data.lat);
                    listBox2.Items.Add(g.data.displayName);
                    listBox1.Items.Add(location);
                    Dwstg d = new Dwstg();
                   var w= d.PORTs.FirstOrDefault(o => o.PORT_NAME == location);
                    w.TZONE_OFFSET = g.data.rawOffset / 60 / 60/1000;
                    w.LATITUDE = g.data.lat;
                    w.LONGITUDE = g.data.lng;
                    w.LAST_MODIFIED_DT = DateTime.Now;
                    await d.SaveChangesAsync();
                }
}
```
**if you are using Play/Java,then check this out **
```
@Override
	public F.Promise<Outcome<JsonNode>> createAsync(JsonNode json){
		
		return ws.url("{API Server realm}"/api/geo/geocoding/query/{location}")
				.setHeader("Content-Type", "application/json")
				.post(json)
				.map((o) -> {
					switch (o.getStatusText()) {
					case "OK":
						JsonNode jn = o.asJson(); 
						
						return Outcome.Success(jn);
					case "Forbidden":
						return Outcome.Error("invalid account or password");
					default:
						return Outcome.Error("server exception");
					}
				});
	}
```
**for angular1/angular2/jquery**

just using **$http.get**...



