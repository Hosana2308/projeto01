//localozacao da classe doentro do projeto
using Projeto02.Controllers;

namespace projeto02 
{
    //definicao da classe
    public class Program 
    {
     
        //metodo para executar o conteudo da classe 
        //ponto de inicializacao do projeto
        public static void Main(string[] args) 
        {
            //instanciando a classe de controle
            var funcionarioController = new FuncionarioController();

            //executando o metodo para cadastrar funcionario
            funcionarioController.CadastrarFuncionario();

            //pausar o prompt
            Console.ReadKey();
        
        }
    
    }

}
