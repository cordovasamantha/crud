using System.Data.SqlClient;

namespace crud.Datos
{
    public class conexion
    {
        private string cadenaSQL = string.Empty;

        public conexion()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();

            cadenaSQL = builder.GetSection("ConnectionStrings:cadenaSQL").Value;

        }

        public string getcadenaSQL() { 
                return cadenaSQL;
        }
    }
}
