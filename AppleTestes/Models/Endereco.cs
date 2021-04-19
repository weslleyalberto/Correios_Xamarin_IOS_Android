using AppleTestes.VM;
using System.Text.Json.Serialization;

namespace AppleTestes.Models
{
    public  class  Endereco : BaseVM
    {
        
        private string _cep;
        [JsonPropertyName("cep")]
        public string CEP
        {
            get { return _cep; }
            set { SetProperty(ref _cep , value); }
        }

       
        private string _estado;
        [JsonPropertyName("uf")]
        public string Estado
        {
            get { return _estado; }
            set {SetProperty(ref _estado , value); }
        }

        
        private string _cidade;
        [JsonPropertyName("localidade")]
        public string Cidade
        {
            get { return _cidade; }
            set {SetProperty(ref _cidade , value); }
        }

        
        private string _bairro;
        [JsonPropertyName("bairro")]
        public string Bairro
        {
            get { return _bairro; }
            set {SetProperty(ref _bairro , value); }
        }

       
        private string _logradouro;
        [JsonPropertyName("logradouro")]
        public string Logradouro
        {
            get { return _logradouro; }
            set {SetProperty(ref _logradouro ,value); }
        }


    }
}
