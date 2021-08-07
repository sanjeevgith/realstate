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

public partial class ChnagePwd : System.Web.UI.Page
{
    SqlConnection cn;
    SqlCommand cmd;
    SqlDataReader dr;
    protected void Page_Load(object sender, EventArgs e)
    {
        txtOPwd.Focus(); 
    }
    protected void btnChange_Click(object sender, EventArgs e)
    {
        cn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Mon2\\Desktop\\RealEstate\\YusufEnt.Website\\App_Data\\RealEstate.mdf;Integrated Security=True;Connect Timeout=30");
        //cn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Mon2\\Desktop\\RealEstate\\YusufEnt.Website\\App_Data\\RealEstate.mdf;Integrated Security=True;Connect Timeout=30");
        string opwd = txtOPwd.Text;
        string npwd = txtNPwd.Text;
        string unm = Session["uid"].ToString();
        cn.Open();
        cmd = new SqlCommand("Select * From Member_Master Where User_Id='" + unm + "' And Password='" + opwd + "'", cn);
        dr = cmd.ExecuteReader();
        if (dr.HasRows == false)
        {
            dr.Close();
            cn.Close();
            lblInvalid.Text = "Invalid Old Password";
            lblInvalid.ForeColor = System.Drawing.Color.Red;
            txtOPwd.Focus();
        }
        else
        {
            dr.Close();
            cmd = new SqlCommand("Update Member_Master Set Password='" + npwd + "' Where User_Id='" + unm + "'", cn);
            cmd.ExecuteNonQuery();
            cn.Close();
            Response.Redirect("Default.aspx");
        }
    }
}
