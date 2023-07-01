using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Lab2
{
    internal class CourseBuisnessLayer
    {
        //get all
        public static DataTable GetAll()
        {
            return DatabaseLayer.Select("select * from Course");
        }

        //get by id
        public static DataTable GetById(int id)
        {
            return DatabaseLayer.Select($"select * from Course where Crs_Id = {id}");
        }

        //add
        public static int Add(int id, string name,int duration,int topic)
        {
            return DatabaseLayer.DMLCommands($"insert into Course values({id},'{name}',{duration},{topic})");
        }

        //edit
        public static int Edit(int id, string name, int duration, int topic)
        {
            return DatabaseLayer.DMLCommands($"update Course set Crs_Name = '{name}',Crs_Duration={duration},Top_Id={topic} where Crs_Id = {id}");
        }

        //delete
        public static int Delete(int id)
        {
            return DatabaseLayer.DMLCommands($"delete from Course where Crs_Id = {id}");
        }
    }
}
