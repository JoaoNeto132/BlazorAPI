namespace BlazorAPI.Shared.Features.Cep.Models
{
    public class Endereco
    {
        public string cep { get; set; }
        public string logradouro { get; set; }
        public string complemento { get; set; }
        public string bairro { get; set; }
        public string localidade { get; set; }
        public string uf { get; set; }
        public string ddd { get; set; }
        public bool erro { get; set; }

    }
}
