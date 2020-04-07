using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using FSISSystem.GBarb.DAL;
using FSISSystem.GBarb.Entities;
using System.ComponentModel;

namespace FSISSystem.GBarb.BLL
{
    [DataObject]
    public class TeamController
    {
        [DataObjectMethod(DataObjectMethodType.Select, false)]
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
