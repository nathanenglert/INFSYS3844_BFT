using System.IO;

namespace BFT
{
    class DatabaseMethods
    {
        public string DBConnectionString()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=\\Mac\Home\Documents\UMSL\INFSYS_6805_C_Sharp\Projects\INFSYS3844_BFT\BFT\BFT_DB.mdf;Integrated Security=True";
            //return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Directory.GetCurrentDirectory() + @"\BFT_DB.mdf;Integrated Security=True";
        }
    }
}
