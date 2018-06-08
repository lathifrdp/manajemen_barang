using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManajemenBarang.Models
{
    public class RegModel
    {
        dbStokEntities dbe = new dbStokEntities();
        public List<GetUsup2_Result> GetUsers()
        {
            return dbe.GetUsup2().ToList<GetUsup2_Result>();
        }
    }
}