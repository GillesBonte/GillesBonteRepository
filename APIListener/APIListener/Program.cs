
//usings
using APIListener.Models;
using System.Net.Http.Json;

// lus toon menu (zolang er niet gestopt werd)
while (!ToonMenu())
{

}
// anders: exit
Environment.Exit(0);

//Menu
bool ToonMenu()
{
    bool stop = false;
    Console.WriteLine("Maak uw Keuze");
    Console.WriteLine("1. IP-adres");
    Console.WriteLine("2. Publieke APIS");
    Console.WriteLine("3. Catbreeds");
    Console.WriteLine("4. POST");
    Console.WriteLine("5. DELETE");
    Console.WriteLine("9. Exit");
    string? keuze = Console.ReadLine();
    switch (keuze)
    {
       case "1":
            ToonIP();
            break;
        case "2":
            ToonPubliekeAPIS();
            break;
        case "3":
            ToonCatBreeds();
            break;
        case "4":
            TestPost();
            break;
        case "5":
            TestDelete();
            break;
        case "9":
            stop = true; 
            break;
        default:
            Console.WriteLine("Ongeldig");
            break;
    }

    if (!stop)
    {
        Console.WriteLine("Press the anykey");
        Console.ReadKey();
        Console.Clear();
    }


    return stop;
}
//Test Delete
void TestDelete()
{
    HttpClient client = new HttpClient();
    client.BaseAddress = new Uri("https://httpbin.org/");

    // Specify the endpoint to delete
    string endpointToDelete = "delete";

    // Perform the DELETE request
    Task<HttpResponseMessage> httpResponse = client.DeleteAsync("delete?id=5");
    httpResponse.Wait();

    // Check if the request was successful
    var response = httpResponse.Result;
    if (response.StatusCode == System.Net.HttpStatusCode.OK)
    {
        // Read and print the response content
        Task<string> content = response.Content.ReadAsStringAsync();
        Console.WriteLine(content.Result);
    }
    else
    {
        Console.WriteLine("Error: " + response.StatusCode);
    }
}

//Test Post
void TestPost()
{
    HttpClient client = new HttpClient();
    client.BaseAddress = new Uri("https://httpbin.org/");
    string dataToSend = "{ \" Waarde \" : \" Hello World! \" }";
    //string content is een string geprepareerd voor http -> we geven ook de encoding mee --> we geven ook het feit mee dat het een json is
    StringContent mijnData = new StringContent(dataToSend, System.Text.Encoding.UTF8, "application/json");
    Task<HttpResponseMessage> httpResponse = client.PostAsync("post", mijnData);
    httpResponse.Wait();
    var x = httpResponse.Result;
    if (x.StatusCode == System.Net.HttpStatusCode.OK)
    {
        Task<string> inhoud = x.Content.ReadAsStringAsync();
        Console.WriteLine(inhoud.Result.ToString());
    }

}
//Toon IP
async void ToonIP()
{
    //httpclient voor het opvragen van api's
    HttpClient client = new HttpClient();
    //task want httpclients zijn altijd async
    Task<string> opgehaaldeWaarde = client.GetStringAsync("https://api.ipify.org/?format=json");
    //wacht tot de async task is uitgevoerd
    opgehaaldeWaarde.Wait();
    //toon de RESULT van de TASK: opgelet: het type is geen string maar een TASK<string>
    Console.WriteLine(opgehaaldeWaarde.Result);
  
    //json waarde in model steken en weergeven
    IPModel? ip = new IPModel();
    ip = System.Text.Json.JsonSerializer.Deserialize<IPModel>(opgehaaldeWaarde.Result);
    Console.WriteLine(ip.ip);
}

//Toon Publieke APIS
async void ToonPubliekeAPIS()
{
    HttpClient client = new HttpClient();

    Task<string> opgehaaldeWaarde = client.GetStringAsync("https://api.publicapis.org/entries");

    opgehaaldeWaarde.Wait();

    APIList apilist = System.Text.Json.JsonSerializer.Deserialize<APIList>(opgehaaldeWaarde.Result);

    foreach (var item in apilist.entries)
    {
        Console.WriteLine($"Api: {item.API}\nDescription: {item.Description}\nAuth: {item.Auth}\nHTTPS: {item.HTTPS.ToString()}\nCors: {item.Cors}\nLink: {item.Link}\nCategory: {item.Category}\n\n");
    }
}

//Toon Kat-rassen
async void ToonCatBreeds()
{
    HttpClient client = new HttpClient();
    client.BaseAddress = new Uri("https://catfact.ninja/");
    //get async neemt het volledige protocol (dus ook de protocol error codes)
    Task<ListCatBreed> catBreed;
    int i = 1;
    //normaal doen we hier nog een https-statuscode-check etc. SAFETY FIRST, DAZEKER SAFETY FIRST
    do
    {
        Task<HttpResponseMessage> breedResponse = client.GetAsync("breeds?page=" + i);
        breedResponse.Wait();
        var res = breedResponse.Result;
        catBreed = res.Content.ReadFromJsonAsync<ListCatBreed>();
        foreach (var item in catBreed.Result.data)
        {
            Console.WriteLine($"Breed - {item.breed}\nCountry - {item.country}\nOrigin - {item.origin}\nCoat - {item.coat}\n");
        }
        i++;    
    } while (i <= catBreed.Result.last_page);
}


