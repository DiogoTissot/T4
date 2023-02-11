using System.Net.Http.Json;


var path = Directory.GetCurrentDirectory() + "id-post-diogo.txt";

var id = 2;
if (File.Exists(path))
{
    id = int.Parse(File.ReadAllText(path).FirstOrDefault().ToString()) + 1;
}

File.WriteAllText(path, id.ToString());

var httpClient = new HttpClient();
var json = new { id = id, nome = "diogo", data = DateTime.Now.ToString("MM/yy") };
Console.WriteLine(json);

var response = await httpClient.PostAsJsonAsync("https://t42023-d2ff8-default-rtdb.firebaseio.com/dadostrabalho.json", json);
if (response.IsSuccessStatusCode)
{
    Console.WriteLine(response);
}
else
{
    Console.WriteLine("Não foi possível inserir os dados");
}