
namespace WebApi.Models
{
    public class ServiceResponse<T>
    {
        public T? Dados { get; set; }
        public string Mensagem { get; set; } = string.Empty;
        public bool Sucesso { get; set; } = true;

        public static implicit operator ServiceResponse<T>(ServiceResponse<FuncionarioModel> v)
        {
            throw new NotImplementedException();
        }

        public static explicit operator ServiceResponse<T>(ServiceResponse<List<FuncionarioModel>> v)
        {
            throw new NotImplementedException();
        }
    }
}
