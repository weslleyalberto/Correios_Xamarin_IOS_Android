using AppleTestes.Models;
using System.Threading.Tasks;

namespace AppleTestes.Interfaces
{
    public interface IServiceLocalizaEndereco<T>  where T:Endereco
    {
        Task<T> BuscarEnderecoAsync(string cep);
    }
}
