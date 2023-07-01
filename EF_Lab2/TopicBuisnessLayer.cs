using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Lab2
{
    internal class TopicBuisnessLayer
    {
        public static DataTable GetAll()
        {
            return DatabaseLayer.Select("select * from Topic");
        }
    }
}
