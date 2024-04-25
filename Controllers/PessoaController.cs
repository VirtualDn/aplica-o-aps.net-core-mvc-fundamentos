using Funtametos_do.Models;
using Funtametos_do.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Funtametos_do.Controllers
{
    public class PessoaController : Controller
    {

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Listar()
        {

            Pessoa model = new Pessoa();
            List<PessoaViewModel> pessoalViewModel = new List<PessoaViewModel>();
            using (Conecxao db = new Conecxao())
            {

                List<Pessoa> list = db.Pessoa.ToList();
                foreach (Pessoa item in list)
                {
                    PessoaViewModel pvm = new();
                    pvm.Cidade = item.Cidade;
                    pvm.Nome = item.Nome;
                    pvm.UF = item.UF;
                    pvm.CPF = item.CPF;
                    pvm.Sexo = item.Sexo;
                    pessoalViewModel.Add(pvm);
                }

            }
            return View(pessoalViewModel);
        }

        [HttpPost]
        public IActionResult Cadastro(PessoaViewModel dados)
        {

            dados.Validar();

            Pessoa model = new Pessoa();
            model.Cidade = dados.Cidade;
            model.UF = dados.UF;
            model.CPF = dados.CPF;
            model.Sexo = dados.Sexo;
            model.Nome = dados.Nome;

            using (Conecxao db = new Conecxao())
            {
                db.Pessoa.Add(model);
                db.SaveChanges();
            }

            return RedirectToAction("Cadastrar");
        }

    }
}
