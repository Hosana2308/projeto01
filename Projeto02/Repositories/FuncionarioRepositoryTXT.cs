using Projeto02.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02.Repositories
{
    public class FuncionarioRepositoryTXT : FuncionarioRepository
    {
        public override void ExportarDados(Funcionario funcionario)
        {
            #region definindo o nome e local do arquivo

            var path = "c:\\temp\\funcionarios.txt";

            #endregion

            #region gravando o conteudo do arquivo

            using (var streamwriter = new StreamWriter(path,true))
            {
                streamwriter.WriteLine($"ID DO FUNCIONARIO.....:{funcionario.Id}");
                streamwriter.WriteLine($"NOME........:{funcionario.Nome}");
                streamwriter.WriteLine($"DATA DE NASCIMENTO.....:{funcionario.DataNascimento.ToString("dd/MM/yyyy")}");
                streamwriter.WriteLine($"CPF....:{funcionario.Cpf}");
                streamwriter.WriteLine($"MATRICULA.....:{funcionario.Matricula}");
                streamwriter.WriteLine($"DATA DE ADMISSAO.....:{funcionario.DataAdmissao.ToString("dd/MM/yyyy")}");
                streamwriter.WriteLine($"ID DO SETOR.......:{funcionario.Setor.Id}");
                streamwriter.WriteLine($" SIGLA DO SETOR.....:{funcionario.Setor.Sigla}");
                streamwriter.WriteLine($" DESCRICAO DO SETOR.....:{funcionario.Setor.Descricao}");
                streamwriter.WriteLine("/n");
            }



            #endregion
        }
    }
}
