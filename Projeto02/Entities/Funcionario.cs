﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02.Entities
{
    public class Funcionario : Pessoa
    {

        #region Propriedades

        public string Cpf { get; set; }
        public string Matricula { get; set;}
        public DateTime DataAdmissao { get; set; }


        #endregion

        #region Associacoes

        public Setor Setor { get; set; }


        #endregion
    }
}
