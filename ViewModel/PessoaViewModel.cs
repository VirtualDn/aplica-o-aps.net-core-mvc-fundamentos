using Funtametos_do.Models;
using System.ComponentModel.DataAnnotations;

namespace Funtametos_do.ViewModel
{
    public class PessoaViewModel
    {
        public string Nome { get; set; }
     
        public string Sexo { get; set; }
        
        public string CPF { get; set; }
        
        public string Cidade { get; set; }
        
        public string UF { get; set; }


        public void Validar()
        {
            if (string.IsNullOrWhiteSpace(Nome))
                throw new ApplicationException("O nome nao pode ser vazio");
            if (Nome.Length > 200)
                throw new ApplicationException("O nome nao pode ser maior que 200 ");
            
            if (string.IsNullOrWhiteSpace(Sexo))
                throw new ApplicationException("O sexo nao pode ser vazio");
            
            if (string.IsNullOrWhiteSpace(CPF))
                throw new ApplicationException("O CPF nao pode ser vazio");
            if (CPF.Length > 11)
                throw new ApplicationException("O cpf esta invalido");

            if (string.IsNullOrWhiteSpace(Cidade))
                throw new ApplicationException("O Cidade nao pode ser vazio");
            
            if (string.IsNullOrWhiteSpace(UF))
                throw new ApplicationException("O UF nao pode ser vazio");

            using (Conecxao db = new Conecxao())
            {
                if (db.Pessoa.Any(c => c.CPF == CPF))
                {
                throw new ApplicationException("Cpf ja cadastrado");

                }
            }
        }
    }
}
