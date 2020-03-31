using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Data.SqlClient;
using FSISSystem.GBarb.DAL;
using FSISSystem.GBarb.Entities;


namespace FSISSystem.GBarb.BLL
{
    public class PlayerController
    {
        public List<Player> Player_GetByTeam(int teamID)
        {
            using (var context = new FSISContext())
            {
                IEnumerable<Player> results = context.Database.SqlQuery<Player>("Player_GetByTeam @TeamID", new SqlParameter("TeamID", teamID));
                return results.ToList();
            }
        }
    }
}
