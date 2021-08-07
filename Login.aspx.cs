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

public partial class Login : System.Web.UI.Page
{
    SqlConnection cn;
    SqlCommand cmd;
    SqlDataReader dr;
    protected void Page_Load(object sender, EventArgs e)
    {
        txtUName.Focus(); 
    }
    protected void imgLogin_Click(object sender, ImageClickEventArgs e)
    {
        cn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Mon2\\Desktop\\RealEstate\\YusufEnt.Website\\App_Data\\RealEstate.mdf;Integrated Security=True;Connect Timeout=30");
        //cn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Mon2\\Desktop\\RealEstate\\YusufEnt.Website\\App_Data\\RealEstate.mdf;Integrated Security=True;Connect Timeout=30");
        string unm = txtUName.Text;
        string pwd = txtPwd.Text;
        int flg = 0;
        cn.Open();
        cmd = new SqlCommand("Select * From Member_Master,admin Where User_Id='" + unm + "'", cn);
        dr = cmd.ExecuteReader();
        if (dr.HasRows == true)
        {
            dr.Read();
            Session["memid"] = dr["Member_Id"].ToString();
            Session["uid"] = unm;
            if (dr["Password"].ToString().CompareTo(pwd) != 0)
                flg = 2;
        }
        else
            flg = 1;
        
        dr.Close();
        cn.Close();
        if (flg == 0)
        {
            if (Session["eid"] == null)
                Response.Redirect("default.aspx");
            else
                Response.Redirect("EstateDetail.aspx");
        }
        else if (flg == 1)
        {
            lblInvalid.Text = "Invalid User Name";
            txtUName.Focus();
        }
        else
        {
            lblInvalid.Text = "Invalid Password";
            txtPwd.Focus();
        }
        lblInvalid.ForeColor = System.Drawing.Color.Red;
        Session.Remove("memid");
        Session.Remove("uid");
    }
}
