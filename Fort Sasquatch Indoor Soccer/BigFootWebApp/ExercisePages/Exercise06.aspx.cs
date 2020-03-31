using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using FSISSystem.GBarb.BLL;
using FSISSystem.GBarb.Entities;

namespace BigFootWebApp.ExercisePages
{
    public partial class Exercise06 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MessageLabel.Text = "";
            if (!Page.IsPostBack)
            {
                BindTeamList();
            }
        }

        protected void BindTeamList()
        {
            try
            {
                TeamController sysmgr = new TeamController();
                List<Team> info = null;
                info = sysmgr.Team_List();
                info.Sort((x, y) => x.TeamName.CompareTo(y.TeamName));
                TeamList.DataSource = info;
                TeamList.DataTextField = nameof(Team.TeamName);
                TeamList.DataValueField = nameof(Team.TeamID);
                TeamList.DataBind();
                TeamList.Items.Insert(0, "select...");

            }
            catch (Exception ex)
            {
                MessageLabel.Text = ex.Message;
            }
        }

        protected void Search_Click(object sender, EventArgs e)
        {
            if (TeamList.SelectedIndex == 0)
            {
                MessageLabel.Text = "Select a team to view its details";
            }
            else
            {
                int teamID = 0;
                if (int.TryParse(TeamList.Text, out teamID))
                {
                    try
                    {
                        TeamController sysmgr = new TeamController();
                        Team info = sysmgr.Team_Find(teamID);

                        CoachName.Text = info.Coach.ToString();
                        AssistCoach.Text = info.AssistantCoach.ToString();
                        WinLabel.Text = info.Wins.ToString();
                        if (info.Wins == null)
                        {
                            WinLabel.Text = "0";
                        }
                        LossLabel.Text = info.Losses.ToString();
                        if (info.Losses == null)
                        {
                            LossLabel.Text = "0";
                        }


                    }
                    catch (Exception ex)
                    {
                        MessageLabel.Text = ex.Message;
                    }
                    
                    try
                    {
                        PlayerController sysmgr = new PlayerController();
                        List<Player> info = null;
                        info = sysmgr.Player_GetByTeam(int.Parse(TeamList.Text));
                        info.Sort((x, y) => x.LastName.CompareTo(y.LastName));

                        TeamRoster.DataSource = info;
                        TeamRoster.DataBind();

                    }
                    catch (Exception ex)
                    {
                        MessageLabel.Text = ex.Message;
                    }
                    
                }
                else
                {
                    MessageLabel.Text = "Team id must be a number.";
                }
            }
        }


        protected void TeamRoster_SelectedIndexChanging(object sender, GridViewPageEventArgs e)
        {
            TeamRoster.PageIndex = e.NewPageIndex;

            Search_Click(sender, new EventArgs());
        }
    }
}