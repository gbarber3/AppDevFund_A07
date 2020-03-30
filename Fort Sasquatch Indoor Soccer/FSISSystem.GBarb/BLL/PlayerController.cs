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
    class PlayerController
    {
        public Player Player_GetByTeam(int teamID)
        {
            using (var context = new FSISContext())
            {
                return context.Players.Find(teamID);
            }
        }
    }
}
