using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace onedimensionalarray10282395
{
    public partial class from2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLookup_Click(object sender, EventArgs e)
        {
            
        }

        protected void btnLookup_Click1(object sender, EventArgs e)
        {

        }

        protected void btnLookup_Click2(object sender, EventArgs e)
        {
            //Declare a new array.
            String[] strCategoryArray = new String[5];
            strCategoryArray = Session["strCategoryArray"] as String[];
            Int32 i32Index = Convert.ToInt32(txtIndex.Text);
            lblres.Text = strCategoryArray[i32Index];
        }
    }
}