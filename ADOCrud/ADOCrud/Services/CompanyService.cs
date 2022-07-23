using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using ADOCrud.Models;

namespace ADOCrud.Services
{
    public class CompanyService
    {
        SqlConnection cn;
        public CompanyService()
        {
            cn = new SqlConnection("Data Source=DESKTOP-52IAUQR;Initial Catalog=Company;Integrated Security=True");
        }

        public List<tblemployee> GetEmployees()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from tblemployee", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            List<tblemployee> li = new List<tblemployee>();

            foreach (DataRow item in dt.Rows)
            {
                li.Add(new tblemployee
                {
                    emp_id = Convert.ToInt32(item["emp_id"].ToString()),
                    salary = Convert.ToInt32(item["salary"].ToString()),
                    f_name = item["f_name"].ToString(),
                    mobile = item["mobile"].ToString(),
                    email = item["email"].ToString(),
                    password = item["password"].ToString(),
                    gender = item["gender"].ToString(),
                    address = item["address"].ToString(),
                    dob = item.Field<DateTime?>("dob")
                });
            }

            return li;
        }

        public tblemployee GetEmployeeByID(int id)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from tblemployee where emp_id=" + id, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            tblemployee obj = new tblemployee();
            if (dt.Rows.Count > 0)
            {
                obj.emp_id = Convert.ToInt32(dt.Rows[0]["emp_id"].ToString());
                obj.salary = Convert.ToInt32(dt.Rows[0]["salary"].ToString());
                obj.f_name = dt.Rows[0]["f_name"].ToString();
                obj.mobile = dt.Rows[0]["mobile"].ToString();
                obj.email = dt.Rows[0]["email"].ToString();
                obj.password = dt.Rows[0]["password"].ToString();
                obj.gender = dt.Rows[0]["gender"].ToString();
                obj.address = dt.Rows[0]["address"].ToString();
                obj.dob = dt.Rows[0].Field<DateTime?>("dob");
            }
            return obj;
        }
    }
}