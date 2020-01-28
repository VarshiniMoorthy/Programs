using System.Data;
using System.Data.SqlClient;
namespace StoredProcedure
{ 
public class StoredProcedureExample{

        SqlParameter parameter;

        public void Connections()

        {

            string connectionString = "Data Source = DESKTOP-ONM3RTQ\\SQLEXPRESS;Initial Catalog = DataCollection;Integrated Security=SSPI";

            string procedure = "StoredProceduress";

            // Create ADO.NET objects.

            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(procedure, connection)
            {

                // Configure command and add input parameters.

                CommandType = CommandType.StoredProcedure
            };

            parameter = command.Parameters.Add("@name", SqlDbType.NVarChar, 50);

            parameter.Value = "John Smith";



           parameter = command.Parameters.Add("@dob", SqlDbType.Date);

            parameter.Value = 12-09-1956;



            parameter = command.Parameters.Add("@doj", SqlDbType.Date);

            parameter.Value = 13-11-1989;


            // Add the output parameter.

            parameter = command.Parameters.Add("@prof1", SqlDbType.VarChar);

            parameter.Value = "c";


            parameter = command.Parameters.Add("@prof1", SqlDbType.VarChar);

            parameter.Value = "c++";


            parameter = command.Parameters.Add("@salary", SqlDbType.Float);

            parameter.Value = 12000.90;

            // Execute the command.

            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();
            
        }

    }

}