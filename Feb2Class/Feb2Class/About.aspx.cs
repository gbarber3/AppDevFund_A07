using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Feb2Class
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            ltrMessage.Text = TextBox1.Text;
        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            ltrCourse = RadioButtonList1.;
        }
    }
}