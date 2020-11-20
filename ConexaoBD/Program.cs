using System.Data.SqlClient;
using System;
namespace ConexaoBD
{
    class Program
    {
        static void Main(string[] args)
        {

                      
            
            void Qcurso()
            {
                ConexaoBD conexao = new ConexaoBD();
                
                conexao.Qcurso.Open();
                
                string Select  = "SELECT * FROM tb_Usuario";
                SqlCommand cmdSelect = new SqlCommand(Select, conexao.Qcurso);
                SqlDataReader view = cmdSelect.ExecuteReader();

                while (view.Read())
                {
                    System.Console.WriteLine("UsuarioID {0} | Nome {1} | Cargo {2} | Data {3}\n",                   view["UsuarioId"], view["Nome"],view["Cargo"],view["Data"]);
                }

            }

            
            void CM(){

                ConexaoBD conexao = new ConexaoBD();

                conexao.Cameras.Open();

                string Select = "SELECT * FROM  vw_Cameras ";
                SqlCommand cmdSelect = new SqlCommand(Select, conexao.Cameras);
                SqlDataReader view = cmdSelect.ExecuteReader();


                while (view.Read())
                {
                    System.Console.WriteLine("IdCM {0} | HostName {1} | IP {2} | Fabricande {3} | Local {4} ",
                        view["idCM"], view["HostName"], view["IP"], view["DescrFabr"], view["DescrLocal"]);
                }
            }

            System.Console.WriteLine("Qual Listaguem Deseja Fazer?");
            Console.WriteLine("Listar Câmeras  OP = 01");
            Console.WriteLine("Listar Usuarios OP = 02");
            string text = Console.ReadLine();
            if (text == "1") { CM(); }
            else if (text == "2") {Qcurso(); } else { Console.WriteLine("Opção Invalida!!!"); }



        }
    }
}
