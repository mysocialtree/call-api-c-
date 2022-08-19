Console.WriteLine("Satrting ...");

// url https://mstree.de/api/get.php + ? + api=token
string url = "https://mstree.de/api/get.php?api=token";

// get data from Server
System.Net.WebClient wc = new System.Net.WebClient();
byte[] raw = wc.DownloadData(url);

// encode data
string webData = System.Text.Encoding.UTF8.GetString(raw);
Console.WriteLine(webData);

    //parse it
    var yourObject = System.Text.Json.JsonDocument.Parse(webData);
    //retrieve the value
    var id = yourObject.RootElement
                      .GetProperty("id");

    Console.WriteLine(id);
