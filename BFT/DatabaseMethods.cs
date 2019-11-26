using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFT
{
    class DatabaseMethods
    {
        public string DBConnectionString()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=\\Mac\Home\Documents\UMSL\INFSYS_6805_C_Sharp\Projects\INFSYS3844_BFT\BFT\BFT_DB.mdf;Integrated Security=True";
        }
    }
}
