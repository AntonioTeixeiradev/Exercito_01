
using Exercito.Funcionario.Oficiais;
using Exercito.Funcionario.Pracas;
using Exercito.Funcionario.Sargentos;
using Exercito.SistemaDeSeguranca;
using Exercito.UsuarioExterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exercito
{
    public class Program
    {
        static void Main(string[] args)
        {

            SistemaInternoSeg sietma = new SistemaInternoSeg();
            Console.WriteLine("Validando entradas ao sistema de seguranca...");

            

            //Cadastros Usuarios Externos
            DesenvolvedorInterno bruno = new DesenvolvedorInterno();
            bruno.Senha = "5821";

            DesenvolvedorExterno camila = new DesenvolvedorExterno();
            camila.Senha = "9632";

            SetorInteligencia inteligencia = new SetorInteligencia();
            inteligencia.Senha = "9658";


            //Cadastros Oficiais
            SoldadoCadete marques = new SoldadoCadete("8752");
            marques.Nome = "Joana Marques";
            marques.Nif = "548.258.369";

            Aspirante fontes = new Aspirante("4583");
            fontes.Nome = "Amanda Fontes";
            fontes.Nif = "963.125.354";

            Capitao silva = new Capitao("9648");
            silva.Nome = "Eduardo Silva";
            silva.Nif = "658.369.147";
            silva.Senha = "7412";

            Alferes souto = new Alferes("5821");
            souto.Nome = "Maria Souto";
            souto.Nif = "548.369.214";

            Tenente goncalves = new Tenente("6598");
            goncalves.Nome = "Pedro Goncalves";
            goncalves.Nif = "658.329.146";
            goncalves.Senha = "8956";


            //Cadastros Sargentos
            SoldadoInstruendo oliveira = new SoldadoInstruendo("6931");
            oliveira.Nome = "Mario Oliveira";
            oliveira.Nif = "563.214.369";

            SegundoFurriel fagundes = new SegundoFurriel("6589");
            fagundes.Nome = "Jose Fagundes";
            fagundes.Nif = "548.325.369";

            Furriel leite = new Furriel("5487");
            leite.Nome = "Manuel Leite";
            leite.Nif = "547.256.325";

            SegundoSargento fernandes = new SegundoSargento("9871");
            fernandes.Nome = "Carla Fernandes";
            fernandes.Nif = "659.254.230";

            PrimeiroSargento costa = new PrimeiroSargento("7825");
            costa.Nome = "Jose Costa";
            costa.Nif = "487.325.369";
            costa.Senha = "5632";


            //Cadastros Pracas
            SoldadoRecruta antunes = new SoldadoRecruta("6598");
            antunes.Nome = "Carlos Antunes";
            antunes.Nif = "852.369.157";

            Soldado maia = new Soldado("4521");
            maia.Nome = "Mateus Maia";
            maia.Nif = "583.325.987";

            SegundoCabo mendes = new SegundoCabo("8743");
            mendes.Nome = "Junior Mendes";
            mendes.Nif = "463.379.641";

            PrimeiroCabo santana = new PrimeiroCabo("5831");
            santana.Nome = "Fabio Santana";
            santana.Nif = "741.315.986";

            CaboAdjunto souza = new CaboAdjunto("863.214.369");
            souza.Nome = "Marcos Souza";
            souza.Nif = "655.236.658";
            souza.Senha = "5896";

            Console.WriteLine("Total de funcionarios cadastrados : " + Funcionario.Funcionario.ContadorMilitar);

            Console.ReadLine();
        }     
    }
}
