using System.IO;

namespace BFT
{
    class DatabaseMethods
    {
        public string DBConnectionString()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Directory.GetCurrentDirectory() + @"\BFT_DB.mdf;Integrated Security=True";
        }
    }
}
