﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace onedimensionalarray10282395
{
    public partial class onedimensionalarray : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void btnCreateArray_Click(object sender, EventArgs e)
        {
            // Declare and load the array
            String[] strCategoryArray = new string[5];
            strCategoryArray[0] = "Footwear - Men  's' ";
            strCategoryArray[1] = "Clothing - Men  's' ";
            strCategoryArray[2] = "Racquets - Women 's' ";
            strCategoryArray[3] = "Footwear - Women 's' ";
            strCategoryArray[4] = " Clothing - Women 's' ";

            Session["strCategoryArray"] = strCategoryArray;


            Response.Redirect("from2.aspx");
        }

    }
}

