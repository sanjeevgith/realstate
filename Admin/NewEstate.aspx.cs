using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;

public partial class Admin_NewEstate : System.Web.UI.Page
{
    SqlConnection cn = null;
    SqlCommand cmd = null;
    SqlDataReader dr = null;

    protected void Page_Load(object sender, EventArgs e)
    {
        uplFile.Attributes["onchange"] = "javascript:ctl00_ContentPlaceHolder1_imgPhoto.src=window.event.srcElement.value;";
        ddlArea.Attributes["onchange"] = "OtherSel()";
        cn = new SqlConnection("Data Source=prince;Database=RealEstate;Integrated Security=True;");
        if (!IsPostBack)
        {
            cn.Open();
            cmd = new SqlCommand("Select * From Member_Master Order By Name", cn);
            dr = cmd.ExecuteReader();
            ddlMemId.Items.Add(new ListItem("--Select--", "0"));
            while (dr.Read())
                ddlMemId.Items.Add(new ListItem(dr["Name"].ToString()+"["+dr["User_Id"].ToString()+"]", dr["Member_id"].ToString()));
            dr.Close();
            //Autogenerated Estate Id (Last Estate Id + 1)
            cmd = new SqlCommand("Select Last_Estate_Id From Admin", cn);
            dr = cmd.ExecuteReader();
            dr.Read();
            int eid = int.Parse(dr[0].ToString()) + 1;
            dr.Close();
            cmd = new SqlCommand("Update Admin Set Last_Estate_Id=" + eid, cn);
            cmd.ExecuteNonQuery();
            //
            txtEId.Text = eid.ToString(); 
            cn.Close();
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        int eid = int.Parse(txtEId.Text);
        string flnm = "";
        if (uplFile.FileName.ToString() != "")
        {
            flnm = uplFile.FileName.ToString();
            flnm = "E" + Convert.ToString(10000 + eid) + flnm.Substring(flnm.Length - 4);
            string path = Server.MapPath("../Images/" + flnm);
            uplFile.PostedFile.SaveAs(path);
        }
        int memid = int.Parse(ddlMemId.SelectedValue);
        string area = ddlArea.SelectedValue;
        if (ddlArea.SelectedValue.CompareTo("Other") == 0)
            area = txtOther.Text;
        string addr = txtAddress.Text.Trim();
        string type = ddlType.SelectedValue;
        string cnst = ddlConstruction.SelectedValue;
        int size = int.Parse(txtSize.Text);
        int price = int.Parse(txtPrice.Text);
        string entdt = DateTime.Now.ToShortDateString();

        string status = "N";
        cn.Open();
        cmd = new SqlCommand("Select * From Estate_Master Where Member_Id=" + memid + " And Area='" + area + "' And Address='" + addr + "' And Type='" + type + "' And Construction='" + cnst + "' And Size=" + size, cn);
        dr = cmd.ExecuteReader();
        if (dr.HasRows == true)
        {
            dr.Close();
            cn.Close();
            lblDuplicate.Text = "Estate Entry Already Exist";
            lblDuplicate.ForeColor = System.Drawing.Color.Red;
            ddlArea.Focus();
        }
        else
        {
            dr.Close();
            cmd = new SqlCommand("INSERT INTO Estate_Master (Estate_Id, Member_Id, Area, Address, Type, Construction, Size, Aprox_Price, Entry_Date, Estate_View, Sales_Status) VALUES (" + eid + "," + memid + ",'" + area + "','" + addr + "','" + type + "','" + cnst + "'," + size + "," + price + ",'" + entdt + "','" + flnm + "','" + status + "') ", cn);
            cmd.ExecuteNonQuery();
            cn.Close();
            Response.Redirect("NewEstate.aspx");
        }
    }
}
