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
    class TeamController
    { 
        public List<Team> Team_List()
        {
            using (var context = new FSISContext())
            {
               return context.Teams.ToList();
            }
        }
        public Team Team_Find(int teamID)
        {
            using (var context = new FSISContext())
            {
                return context.Teams.Find(teamID);
            }
        }
    }
}
