using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication01StoreProcedure17Sep2023
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public static SqlConnection con;
        public static SqlCommand cmd;

        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection();
            cmd = new SqlCommand();

            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\23MSIT059\EmpDB.mdf;Integrated Security=True;Connect Timeout=30";

            cmd.Connection = con;
            cmd.CommandText = "EmpProcedure";

            cmd.CommandType = System.Data.CommandType.StoredProcedure;


            //FillGrid();
        }

        //private void FillGrid()
        //{
        //    try
        //    {
        //        cmd.Parameters.AddWithValue("@op", 4);

        //        SqlDataReader r;
        //        con.Open();
        //        r = cmd.ExecuteReader();

        //        gridvEmp.DataSource = r;
        //        gridvEmp.DataBind();
        //        con.Close();
        //    }
        //    catch (SqlException sqlex)
        //    {
        //        Response.Write(sqlex.Message);
        //    }
        //    catch (Exception ex)
        //    {
        //        Response.Write(ex.Message);
        //    }
        //}

        protected void tbnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.Parameters.AddWithValue("@eid", txtEmpID.Text);
                cmd.Parameters.AddWithValue("@ename", txtEmpName.Text);
                cmd.Parameters.AddWithValue("@ecity", txtEmpCity.Text);
                cmd.Parameters.AddWithValue("@esal", txtEmpSal.Text);
                cmd.Parameters.AddWithValue("@op", 1);

                con.Open();
                int i = cmd.ExecuteNonQuery();
                con.Close();

                if (i > 0)
                {
                    Response.Write("Record Inserted.");

                    //FillGrid();
                }

                else
                {
                    Response.Write("Something Went Wrong.");
                }

                txtEmpID.Text = "";
                txtEmpName.Text = "";
                txtEmpCity.Text = "";
                txtEmpSal.Text = "";
            }

            catch (SqlException Sqlex) 
            {
                Response.Write(Sqlex.Message);
            }

            catch (Exception Ex)
            {
                Response.Write(Ex.Message);
            }
            
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.Parameters.AddWithValue("@eid", txtEmpID.Text);
                cmd.Parameters.AddWithValue("@ename", txtEmpName.Text);
                cmd.Parameters.AddWithValue("@ecity", txtEmpCity.Text);
                cmd.Parameters.AddWithValue("@esal", txtEmpSal.Text);
                cmd.Parameters.AddWithValue("@op", 2);

                con.Open();
                int i = cmd.ExecuteNonQuery();
                con.Close();

                if (i > 0)
                {
                    Response.Write("Record Updated.");

                    //FillGrid();
                }

                else
                {
                    Response.Write("Something Went Wrong.");
                }

                txtEmpID.Text = "";
                txtEmpName.Text = "";
                txtEmpCity.Text = "";
                txtEmpSal.Text = "";
            }

            catch (SqlException Sqlex)
            {
                Response.Write(Sqlex.Message);
            }

            catch (Exception Ex)
            {
                Response.Write(Ex.Message);
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.Parameters.AddWithValue("@eid", txtEmpID.Text);
                cmd.Parameters.AddWithValue("@op", 3);

                con.Open();
                int i = cmd.ExecuteNonQuery();
                con.Close();

                if (i > 0)
                {
                    Response.Write("Record Deleted.");

                    //FillGrid();
                }

                else
                {
                    Response.Write("Something Went Wrong.");
                }

                txtEmpID.Text = "";
            }

            catch (SqlException Sqlex)
            {
                Response.Write(Sqlex.Message);
            }

            catch (Exception Ex)
            {
                Response.Write(Ex.Message);
            }
        }

        protected void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.Parameters.AddWithValue("@op", 4);

                SqlDataReader r;
                con.Open();
                r = cmd.ExecuteReader();

                gridvEmp.DataSource = r;
                gridvEmp.DataBind();
                con.Close();
            }
            catch (SqlException sqlex)
            {
                Response.Write(sqlex.Message);
            }

            catch (Exception Ex)
            {
                Response.Write(Ex.Message);
            }
        }
    }
}