namespace DatabaseDAL.Config
{
    public class DatabaseConfig
    {
        public static string GetHost()
        {
            return "mongodb://localhost:27017";
        }

        public static string GetDbName()
        {
            return "population";
        }
        
    }
}
