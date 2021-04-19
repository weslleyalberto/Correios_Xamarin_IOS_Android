using AppleTestes.Interfaces;
using AppleTestes.Models;
using AppleTestes.Service;
using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
[assembly: Xamarin.Forms.Dependency(typeof(ServiceLocalizaEndereco))]
namespace AppleTestes.Service
{
    public  class ServiceLocalizaEndereco : IServiceLocalizaEndereco<Endereco>
    {
        public async Task<Endereco> BuscarEnderecoAsync(string cep)
        {
            Uri baseUrl = new Uri($"https://viacep.com.br/ws/{cep}/json/");

            using(HttpClient http = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await http.GetAsync(baseUrl);
                    response.EnsureSuccessStatusCode();
                    return JsonSerializer.Deserialize<Endereco>(await response.Content.ReadAsStringAsync());
                }
                catch(Exception ex)
                {
                    throw new Exception(message: $"Não foi possível conectar, tente novamente mais tarde. erro: {ex.Message}");
                }
               
              
                
            }
        }

      
    }
}
