using System;
using System.Data.SqlClient;
using ConexaoBD;

namespace ConexaoBD
{
    class Appstart
    {
                
        public void Qcurso()
        {
            ConexaoBD conexao = new ConexaoBD();
            conexao.Qcurso.Open();

            Console.WriteLine("-------------<   Controle de Usuario    >----------- ");
            Console.WriteLine("-------------< Escolha as Opções abaixo >----------- ");
            Console.WriteLine("| Opção 01 - Lista de Usuarios                      |");
            Console.WriteLine("| Opção 02 - Alterar  Usuarios                      |");
            Console.WriteLine("| Opção 03 - Deletar  Usuarios                      |");
            Console.WriteLine("| Opção 04 - Inserir  Usuarios                      |");
            Console.WriteLine("| Opção 05 - Sair Para O Menu Principal             |");

            Console.Write("Opção: ==>  ");
            int op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1 :
                    SelectView();
                    break;
                case 2:
                    Updade();
                    break;

                case 3:
                    Delete();
                    break;
                case 4:
                    Insert();
                    break;
                case 5:
                    Menu menu = new Menu();
                    Menu.MenuPrincipal();
                    break;
                default:
                    Console.WriteLine("Opção Inválida! ");
                    Qcurso();
                    break;
            }


            void Insert()
            {
                Console.Write("Nome: ");
                string Nome = Console.ReadLine();
                Console.Write("Cargo: ");
                string Cargo = Console.ReadLine();
                Console.Write("Data: ");
                DateTime Data = DateTime.Parse(Console.ReadLine());
                
                string updade = $"INSERT INTO  tb_Usuario (Nome,Cargo,Data) Values ('{Nome}','{Cargo}','{Data}')  ";
                SqlCommand cmd = new SqlCommand(updade, conexao.Qcurso);
                SqlDataReader modificar = cmd.ExecuteReader();



                while (modificar.Read())
                {
                    System.Console.WriteLine("UsuarioID {0} | Nome {1} | Cargo {2} | Data {3}\n", modificar["UsuarioId"], modificar["Nome"], modificar["Cargo"], modificar["Data"]);
                }
            }




            void SelectView()
            {
                string Select = "SELECT * FROM tb_Usuario";
                SqlCommand cmdSelect = new SqlCommand(Select, conexao.Qcurso);
                SqlDataReader view = cmdSelect.ExecuteReader();

                while (view.Read())
                {
                    System.Console.WriteLine("UsuarioID {0} | Nome {1} | Cargo {2} | Data {3}\n", view["UsuarioId"], view["Nome"], view["Cargo"], view["Data"]);
                }

                Console.ReadKey();
                

            }

            void SelectView_ID(int id)
            {
                string Select = $"SELECT UsuarioId, Nome, Cargo, Data" +
                    $"  FROM tb_Usuario Where UsuarioId = {id}";
                SqlCommand cmdSelect = new SqlCommand(Select, conexao.Qcurso);
                SqlDataReader view = cmdSelect.ExecuteReader();
                
                while (view.Read())
                {
                    System.Console.WriteLine("UsuarioID {0} | Nome {1} | Cargo {2} | Data {3}\n", view["UsuarioId"], view["Nome"], view["Cargo"], view["Data"]);
                }

                view.Close();
            }


            void Updade()
            {
                Console.WriteLine("Infome Id do  Nome que Desenha Alterar");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("---------------------------------------");
                SelectView_ID(id);
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("Entra com o Novo Nome");
                string altnew = Console.ReadLine();

                string updade = $"UPDATE  tb_Usuario SET Nome = '{altnew}' Where UsuarioId = {id}  ";
                SqlCommand cmd = new SqlCommand(updade, conexao.Qcurso);
                SqlDataReader modificar = cmd.ExecuteReader();

                
                
                while (modificar.Read())
                {
                    System.Console.WriteLine("UsuarioID {0} | Nome {1} | Cargo {2} | Data {3}\n", modificar["UsuarioId"], modificar["Nome"], modificar["Cargo"], modificar["Data"]);
                }
            }

            void Delete()
            {
                Console.WriteLine("Infome Id do  Nome que Desenha Deletar");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("---------------------------------------");
                SelectView_ID(id);
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("Confirme o ID para Exluir");
                int altnew = int.Parse(Console.ReadLine());

                string delete = $"DELETE FROM tb_Usuario Where UsuarioId = {altnew}  ";
                SqlCommand cmd = new SqlCommand(delete, conexao.Qcurso);
                SqlDataReader modificar = cmd.ExecuteReader();



                while (modificar.Read())
                {
                    System.Console.WriteLine("UsuarioID {0} | Nome {1} | Cargo {2} | Data {3}\n", modificar["UsuarioId"], modificar["Nome"], modificar["Cargo"], modificar["Data"]);
                }
            }



        }









        // MOdelo de Teste de Câmeras. com BancoSQL
        public void CM()
        {

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
            Console.ReadKey();
        }

    }

}

 

