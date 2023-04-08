using MySql.Data.MySqlClient;

namespace CubiculosBiblioteca
{
    internal class BD
    {
        private MySqlConnection conexion;
        private string cadenaConexion = "Database=cubiculoscut; DataSource=localhost; User Id=root; Password=12345678";
        public MySqlConnection getConexion()
        { 
          if (conexion == null)
            {
                conexion = new MySqlConnection(cadenaConexion);
            }
          return conexion;
        }
    }
}
