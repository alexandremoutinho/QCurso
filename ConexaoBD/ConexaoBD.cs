using System.Data.SqlClient;

namespace ConexaoBD
{
    class ConexaoBD
    {

        // //Conexão com Banco de Dados de QCursos

      public SqlConnection Qcurso = new SqlConnection(@"Data Source=ACSERVER;Initial Catalog=QCurso;Persist Security Info=True;User ID=sa;Password=apcofo@21");

        //Conexão com Banco de Dados de Cameras
       public  SqlConnection Cameras = new SqlConnection(@"Data Source=ACSERVER;Initial Catalog=GIG_Cameras;Persist Security Info=True;User ID=sa;Password=apcofo@21");

    }
}
