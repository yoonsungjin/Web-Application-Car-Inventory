using DBLib.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalWebApp_SungjinYoon.restricted
{
    public partial class Dashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GarageDAL garageDAL = new GarageDAL();
                gvCar.DataSource = garageDAL.GetCarByMemberId(Convert.ToInt16(Session["MemberId"]));
                gvCar.DataBind();
            }
        }

    }
}