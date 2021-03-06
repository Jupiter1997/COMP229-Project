﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Page_PreInit(object sender, EventArgs e)
    {

        string theme;
        theme = (string)Session["theme"];
        if ((theme != null) && (theme.Length != 0))
        {
            Page.Theme = theme;
         //   ddlTheme.Text = theme;            
        }
        else
        {
            Page.Theme = "Dark";
        }
    }

    protected void ddlTheme_SelectedIndexChanged(object sender, EventArgs e)
    {
        Session["theme"] = ddlTheme.SelectedItem.Value;
        Server.Transfer(Request.FilePath);
    }
}