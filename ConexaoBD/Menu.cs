using System;
namespace ConexaoBD
{
    class Menu
    {
        
        public static void MenuPrincipal()
        {

            Appstart appstart = new Appstart();
            int op = 3;
            while (op != 0)
            {
                
                Console.Clear();
                Console.WriteLine("------------------------------------");
                Console.WriteLine("|  Qual Listaguem Deseja Fazer?    |");
                Console.WriteLine("|  Listar Câmeras  OP = 01         |");
                Console.WriteLine("|  Listar Usuarios OP = 02         |");
                Console.WriteLine("|  Sair___________ OP = 00         |");
                Console.WriteLine("------------------------------------");
                Console.Write("OP: ===> : ");
                
                try
                {
                    int str = int.Parse(Console.ReadLine());
                    if (str == 1) { appstart.CM(); }
                    else if (str == 2) { appstart.Qcurso(); }
                    else if (str == 0) { op = 0; }
                    else { Console.WriteLine("Opção Invalida!!!"); Console.ReadKey(); }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.GetType().FullName);
                    Console.ReadKey();
                    Console.WriteLine(ex.Message);
                    Console.ReadKey();
                    MenuPrincipal();
                    Console.Clear();
                    
                }
                



            }


        }

    }
}
