using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Funtametos_do.Models
{
	[Table("Pessoa")]
	public class Pessoa
	{
		[Key]
		public int Id { get; set; }

		[Required, StringLength(100)]
		public string Nome { get; set; }

		[Required, StringLength(15)]
		public string Sexo { get; set;}

		[Required, StringLength(15)]
		public string CPF {  get; set; }

		[Required, StringLength(20)]
        public string Cidade { get; set; }
		
		[Required, StringLength(2)]
		public string UF { get; set; }
	}
}
