using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DBLib.DAL;
using DBLib.entities;

namespace FinalWebApp_SungjinYoon
{
    public partial class SearchCar : System.Web.UI.Page
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
                btnSearch.Enabled = false;
                btnAddGarage.Visible = false;

            }



        }


        protected void btnSearch_Click1(object sender, EventArgs e)
        {
            CarDAL carDAL = new CarDAL();
            // gvCar.DataSource = carDAL.ReadByMakeId(Convert.ToInt16(ddMake.SelectedItem.Value));
            int makeId = 0, modelId = 0;

            if (ddMake.SelectedItem.Value!="")
                makeId = Convert.ToInt16(ddMake.SelectedItem.Value);


            if (ddModel.SelectedItem.Value!="")
                modelId = Convert.ToInt16(ddModel.SelectedItem.Value);

            if (makeId > 0)
            {
                
                gvCar.DataSource = carDAL.ReadByMakeId(Convert.ToInt16(ddMake.SelectedItem.Value));
            }
            if (modelId > 0 && makeId > 0)
            {
                gvCar.DataSource = carDAL.SearchCar(makeId, modelId);

            }
            gvCar.DataBind();
            btnAddGarage.Visible = true;

        }

        protected void ddModel_SelectedIndexChanged(object sender, EventArgs e)
        {
                
        }

        protected void ddMake_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSearch.Enabled = true;
            ddModel.Items.Clear();
            ddModel.Items.Add(new ListItem("--Select Model--", ""));

            ddModel.AppendDataBoundItems = true;
            ModelDAL modelDAL = new ModelDAL();
            List<Model> models;
            if (ddMake.SelectedItem.Value != null)
            {
                models = modelDAL.GetModel(Convert.ToInt16(ddMake.SelectedItem.Value));  //to check the value

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


        protected void btnAddGarage_Click(object sender, EventArgs e)
        {
            foreach (GridViewRow row in gvCar.Rows)
            {
                CheckBox cb = (CheckBox)row.FindControl("chkSel");
                if (cb.Checked)
                {
                    GarageDAL garageDAL = new GarageDAL();
                    CarDAL carkDAL = new CarDAL();


                    int makeID = Convert.ToInt16(row.Cells[0].Text);
                    int modelID = Convert.ToInt16(row.Cells[1].Text);


                    int carId = garageDAL.GetCarId(makeID, modelID);
                    garageDAL.AddToGarage(Convert.ToInt16(Session["MemberId"]), carId);  //@TODO add userID
                    lblStatus.Text = "Added to Garage Successfully";


                }
            }

        }
    }
}