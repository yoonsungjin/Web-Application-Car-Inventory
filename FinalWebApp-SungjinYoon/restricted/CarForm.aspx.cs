using DBLib.DAL;
using DBLib.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalWebApp_SungjinYoon.restricted
{
    public partial class CarForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddMake.AppendDataBoundItems = true;
                MakeDAL makeDAL = new MakeDAL();
                List<Make> makes = makeDAL.GetAll();
                ddMake.DataSource = makes;
                ddMake.DataTextField = "Name";
                ddMake.DataValueField = "Id";
                ddMake.DataBind();
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            int make = Convert.ToInt16(ddMake.SelectedItem.Value);
            int model = Convert.ToInt16(ddModel.SelectedItem.Value);
            int year = Convert.ToInt32(txtYear.Text);
            double price = Convert.ToDouble(txtPrice.Text);
            double mileage = Convert.ToDouble(txtMileage.Text);
            string photoUrl = "";  

            if (FileUpload1.HasFile)
                FileUpload1.SaveAs(MapPath("../images") + @"\" + FileUpload1.FileName);
            photoUrl = FileUpload1.FileName.ToString();

            Car car = new Car(make, model, year, price, mileage, "images/" + photoUrl);
            CarDAL carDAL = new CarDAL();
            carDAL.Add(car);

            lblStatus.Text = "Saved";

        }

        protected void ddMake_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddModel.Items.Clear();
            ddModel.Items.Add(new ListItem("--Select Model--", ""));

            ddModel.AppendDataBoundItems = true;
            ModelDAL modelDAL = new ModelDAL();
            List<Model> models = modelDAL.GetModel(Convert.ToInt16(ddMake.SelectedItem.Value));  //to check the value
            ddModel.DataSource = models;
            ddModel.DataTextField = "Name";
            ddModel.DataValueField = "Id";
            ddModel.DataBind();
            if (ddModel.Items.Count > 1)
                ddModel.Enabled = true;
            else
                ddModel.Enabled = false;
        }


    }
}