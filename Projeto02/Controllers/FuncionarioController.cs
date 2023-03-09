using Projeto02.Entities;
using Projeto02.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02.Controllers
{
    public class FuncionarioController
    {
        public void CadastrarFuncionario() 
        {

            try
            {
                Console.WriteLine("\n *** CADASTRO DE FUNCIONARIO*** \n");

                #region Capturar os dados do funcionario

                var funcionario = new Funcionario();
                funcionario.Id = Guid.NewGuid();

                Console.Write("NOME DO FUNCIONARIO....:");
                funcionario.Nome = Console.ReadLine();

                Console.Write("DATA DE NASCIMENTO....:");
                funcionario.DataNascimento = DateTime.Parse(Console.ReadLine());

                Console.Write("Cpf.....:");
                funcionario.Cpf = Console.ReadLine();

                Console.Write("MATRICULA.....:");
                funcionario.Matricula = Console.ReadLine();

                Console.Write("DATA DE ADMISSAO......:");
                funcionario.DataAdmissao = DateTime.Parse(Console.ReadLine());

                #region Capturar os dados do setor do funcionario

                funcionario.Setor = new Setor();
                funcionario.Setor.Id = Guid.NewGuid();

                Console.Write("SIGLA DO SETOR.....:");
                funcionario.Setor.Sigla = Console.ReadLine();


                Console.Write("DESCRICAO DO SETOR....:");
                funcionario.Setor.Descricao = Console.ReadLine();


                #endregion

                #endregion

                #region exportando os dados para arquivo

                Console.Write("\nINFORME ()1CSV ou (2)TXT:");
                var opcao = int.Parse(Console.ReadLine());

                //criando um objeto da classe abstrata mas sem instancia-la
                FuncionarioRepository funcionarioRepository = null;

                switch(opcao)
                {
                    case 1:
                        //POLIMORFISMO
                        funcionarioRepository = new FuncionarioRepositoryCSV();
                        break;

                    case 2:
                        //POLIMORFISMO
                        funcionarioRepository = new FuncionarioRepositoryTXT();
                        break;

                    default:
                        Console.WriteLine("\nFormato invalido!");
                        break;

                }
                //verificando se o objeto funcionarioRepository nao e null
                if(funcionarioRepository != null)
                {
                    //gravando os dados do funcionario em arquivo
                    funcionarioRepository.ExportarDados(funcionario);

                    Console.WriteLine("\nDados gravados com sucesso!");

                }


                #endregion

            }
            catch (Exception e)
            {
                Console.WriteLine($"\nFalha ao cadastrar:{e.Message}");
            
            
            }
        
        
        
        
        
        
        }

    }
}
