using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DataAcessLayer
    {
        static string connstring = "Data Source = localhost; Initial Catalog = PropertyDB; Integrated Security = True;";
        SqlConnection dbConn = new SqlConnection(connstring);
        SqlCommand dbComm;
        DataTable dt;
        SqlDataAdapter dbAdapter;



        //Stored Procedures for From 1 "Login/Home"



        public DataTable GetLoginAgent(string Email, string Password)
        {
            dbComm = new SqlCommand("sp_GetLoginAgent", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@Email", Email);
            dbComm.Parameters.AddWithValue("@Password", Password);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;

        }

        public DataTable GetAdminLogin(string AdminEmail, string AdminPassword)
        {
            dbComm = new SqlCommand("sp_GetAdminLogin", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@AdminEmail", AdminEmail);
            dbComm.Parameters.AddWithValue("@AdminPassword", AdminPassword);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;

        }

        public DataTable GetTenantLogin(string Email, string Password)
        {
            dbComm = new SqlCommand("sp_GetTenantLogin", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@Email", Email);
            dbComm.Parameters.AddWithValue("@Password", Password);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;

        }

        public DataTable GetLoggedTenant(int TenantID)
        {
            dbComm = new SqlCommand("sp_GetLoggedTenant", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@TenantID", TenantID);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;

        }

        public int UpdateLoggedTenant(Tenant tenant)
        {
            dbConn.Open();

            dbComm = new SqlCommand("sp_UpdateLoggedTenant", dbConn);

            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@Email", tenant.TenantEmail);
            dbComm.Parameters.AddWithValue("@Password", tenant.TenantPassword);
            dbComm.Parameters.AddWithValue("@Phone", tenant.TenantPhone);
            dbComm.Parameters.AddWithValue("@Status", tenant.TenantStatus);

            int x = dbComm.ExecuteNonQuery();

            dbConn.Close();
            return x;
        }




        //Stored Procdues for Form 2 "PropertyType"



        public int InsertPropertyType(PropertyType propertyType)
        {
            dbConn.Open();

            dbComm = new SqlCommand("sp_InsertPropertyType", dbConn);

            dbComm.CommandType = CommandType.StoredProcedure;
            
            dbComm.Parameters.AddWithValue("@PropertyTypeDescription", propertyType.PropertyTypeDescription);

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;

        }
        public DataTable GetPropertyType()
        {
            dbConn.Open();

            dbComm = new SqlCommand("sp_GetPropertyType", dbConn);

            dt = new DataTable();

            dbAdapter = new SqlDataAdapter(dbComm);

            dbAdapter.Fill(dt);

            dbConn.Close();
            return dt;
        }



        //Stored Procedures for Form 3 "Properties"



        public int InsertProperty(Property property)
        {
            dbConn.Open();

            dbComm = new SqlCommand("sp_InsertProperty", dbConn);

            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@Description", property.PropertyDescription);
            dbComm.Parameters.AddWithValue("@Picture", property.Picture);
            dbComm.Parameters.AddWithValue("@Price", property.PropertyPrice);
            dbComm.Parameters.AddWithValue("@PropertyTypeID", property.PropertyTypeID);
            dbComm.Parameters.AddWithValue("@Status", property.PropertyStatus);
            dbComm.Parameters.AddWithValue("@SuburbID", property.SuburbID);

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public int UpdateProperty(Property property)
        {
            dbConn.Open();

            dbComm = new SqlCommand("sp_UpdateProperty", dbConn);

            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@Price", property.PropertyPrice);
            dbComm.Parameters.AddWithValue("@PropertyID", property.PropertyTypeID);
            dbComm.Parameters.AddWithValue("@Status", property.PropertyStatus);

            int x = dbComm.ExecuteNonQuery();

            dbConn.Close();
            return x;
        }
        public int DeleteProperty(Property property)
        {
            dbConn.Open();

            dbComm = new SqlCommand("sp_DeleteProperty", dbConn);

            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@PropertyID", property.PropertyID);

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public DataTable GetProperty()
        {
            dbConn.Open();

            dbComm = new SqlCommand("sp_GetProperty", dbConn);

            dt = new DataTable();

            dbAdapter = new SqlDataAdapter(dbComm);

            dbAdapter.Fill(dt);

            dbConn.Close();
            return dt;
        }



        //Stored Procedures for Form 4 "Provinces"



        public int InsertProvince(Province province)
        {
            dbConn.Open();

            dbComm = new SqlCommand("sp_InsertProvince", dbConn);

            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@ProvinceDescription", province.ProvinceDescription);

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
       
        public DataTable GetProvince()
        {
            dbConn.Open();

            dbComm = new SqlCommand("sp_GetProvince", dbConn);

            dt = new DataTable();

            dbAdapter = new SqlDataAdapter(dbComm);

            dbAdapter.Fill(dt);

            dbConn.Close();
            return dt;
        }



        //Stored Procedures for Form 5 "Cities"



        public int InsertCity(Cities cities)
        {
            dbConn.Open();

            dbComm = new SqlCommand("sp_InsertCity", dbConn);

            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@CityDescription", cities.CityDescription);
            dbComm.Parameters.AddWithValue("@ProvinceID", cities.ProvinceID);

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public DataTable GetCity()
        {
            dbConn.Open();

            dbComm = new SqlCommand("sp_GetCity", dbConn);

            dt = new DataTable();

            dbAdapter = new SqlDataAdapter(dbComm);

            dbAdapter.Fill(dt);

            dbConn.Close();
            return dt;
        }



        // Stored Procedures for Form 6 "Suburbs"


        public int InsertSuburb(Suburbs suburbs)
        {
            dbConn.Open();

            dbComm = new SqlCommand("sp_InsertSuburb", dbConn);

            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@SuburbDescription", suburbs.SuburbDescription);
            dbComm.Parameters.AddWithValue("@PostalCode", suburbs.PostalCode);
            dbComm.Parameters.AddWithValue("@CityID", suburbs.CityID);

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public DataTable GetSuburb()
        {
            dbConn.Open();

            dbComm = new SqlCommand("sp_GetSuburb", dbConn);

            dt = new DataTable();

            dbAdapter = new SqlDataAdapter(dbComm);

            dbAdapter.Fill(dt);

            dbConn.Close();
            return dt;
        }



        //Stord Procedure for Form 7 "Agencies"


        public int InsertAgency(Agencies agencies)
        {
            dbConn.Open();

            dbComm = new SqlCommand("sp_InsertAgency", dbConn);

            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@AgencyName", agencies.AgencyName);
            dbComm.Parameters.AddWithValue("@SuburbID", agencies.SuburbID);

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }

        public int DeleteAgency(Agencies agencies)
        {
            dbConn.Open();

            dbComm = new SqlCommand("sp_DeleteAgency", dbConn);

            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@AgencyID", agencies.AgencyID);
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public DataTable GetAgency()
        {
            dbConn.Open();

            dbComm = new SqlCommand("sp_GetAgency", dbConn);

            dt = new DataTable();

            dbAdapter = new SqlDataAdapter(dbComm);

            dbAdapter.Fill(dt);

            dbConn.Close();
            return dt;
        }



        //Stored Procedure for Form 8 "Agents"
        


        public int InsertAgent(Agents agents)
        {
            dbConn.Open();

            dbComm = new SqlCommand("sp_InsertAgent", dbConn);

            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@Name", agents.Name);
            dbComm.Parameters.AddWithValue("@Surname", agents.Surname);
            dbComm.Parameters.AddWithValue("@Email", agents.Email);
            dbComm.Parameters.AddWithValue("@Password", agents.Password);
            dbComm.Parameters.AddWithValue("@Phone", agents.Phone);
            dbComm.Parameters.AddWithValue("@Status", agents.Status);
            dbComm.Parameters.AddWithValue("@AgencyID", agents.AgencyID);

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public int UpdateAgent(Agents agents)
        {
            dbConn.Open();

            dbComm = new SqlCommand("sp_UpdateAgent", dbConn);

            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@Email", agents.Email);
            dbComm.Parameters.AddWithValue("@Phone", agents.Phone);
            dbComm.Parameters.AddWithValue("@Status", agents.Status);
            dbComm.Parameters.AddWithValue("@AgentID", agents.AgentID);

            int x = dbComm.ExecuteNonQuery();

            dbConn.Close();
            return x;
        }
        public int DeleteAgent(Agents agents)
        {
            dbConn.Open();

            dbComm = new SqlCommand("sp_DeleteAgent", dbConn);

            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@AgentID", agents.AgentID);

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public DataTable GetAgent()
        {
            dbConn.Open();

            dbComm = new SqlCommand("sp_GetAgent", dbConn);

            dt = new DataTable();

            dbAdapter = new SqlDataAdapter(dbComm);

            dbAdapter.Fill(dt);

            dbConn.Close();
            return dt;
        }



        //Storted Procedures for Form 9 


        public int InsertTenant(Tenant tenant)
        {
            dbConn.Open();

            dbComm = new SqlCommand("sp_InsertTenant", dbConn);

            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@Name", tenant.TenantName);
            dbComm.Parameters.AddWithValue("@Surname", tenant.TenantSurname);
            dbComm.Parameters.AddWithValue("@Email", tenant.TenantEmail);
            dbComm.Parameters.AddWithValue("@Password", tenant.TenantPassword);
            dbComm.Parameters.AddWithValue("@Phone", tenant.TenantPhone);
            dbComm.Parameters.AddWithValue("@Status", tenant.TenantStatus);

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public int UpdateTenant(Tenant tenant)
        {
            dbConn.Open();

            dbComm = new SqlCommand("sp_UpdateTenant", dbConn);

            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@Email", tenant.TenantEmail);
            dbComm.Parameters.AddWithValue("@Phone", tenant.TenantPhone);
            dbComm.Parameters.AddWithValue("@Status", tenant.TenantStatus);
            dbComm.Parameters.AddWithValue("@TenantID", tenant.TenantID);

            int x = dbComm.ExecuteNonQuery();

            dbConn.Close();
            return x;
        }
        public int DeleteTenant(Tenant tenant)
        {
            dbConn.Open();

            dbComm = new SqlCommand("sp_DeleteTenant", dbConn);

            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@TenantID", tenant.TenantID);

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public DataTable GetTenant()
        {
            dbConn.Open();

            dbComm = new SqlCommand("sp_GetTenant", dbConn);

            dt = new DataTable();

            dbAdapter = new SqlDataAdapter(dbComm);

            dbAdapter.Fill(dt);

            dbConn.Close();
            return dt;
        }



        // Stored Procedure for Form 10 "PropertyAgent"


        public int InsertPropertyAgent(PropertyAgent propertyAgent)
        {
            dbConn.Open();

            dbComm = new SqlCommand("sp_InsertPropertyAgent", dbConn);

            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@PropertyID", propertyAgent.PropertyID);
            dbComm.Parameters.AddWithValue("@AgentID", propertyAgent.AgentID);
            dbComm.Parameters.AddWithValue("@Date", propertyAgent.Date);


            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public int UpdatePropertyAgent(PropertyAgent propertyAgent)
        {
            dbConn.Open();

            dbComm = new SqlCommand("sp_UpdatePropertyAgent", dbConn);

            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@PropertyID", propertyAgent.PropertyID);
            dbComm.Parameters.AddWithValue("@AgentID", propertyAgent.AgentID);
            dbComm.Parameters.AddWithValue("@Date", propertyAgent.Date);
            dbComm.Parameters.AddWithValue("@PropertyAgentID", propertyAgent.PropertyAgentID);

            int x = dbComm.ExecuteNonQuery();

            dbConn.Close();
            return x;
        }
        public DataTable GetPropertyAgent()
        {
            dbConn.Open();

            dbComm = new SqlCommand("sp_GetPropertyAgent", dbConn);

            dt = new DataTable();

            dbAdapter = new SqlDataAdapter(dbComm);

            dbAdapter.Fill(dt);

            dbConn.Close();
            return dt;
        }


        //Stored Procedures for Form 11 "Rentals"


        public int InsertRental(Rentals rentals)
        {
            dbConn.Open();

            dbComm = new SqlCommand("sp_InsertRental", dbConn);

            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@PropertyAgentID", rentals.PropertyAgentID);
            dbComm.Parameters.AddWithValue("@TenantID", rentals.TenantID);
            dbComm.Parameters.AddWithValue("@StartDate", rentals.StartDate);
            dbComm.Parameters.AddWithValue("@EndDate", rentals.EndDate);


            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public int UpdateRental (Rentals rentals)
        {
            dbConn.Open();

            dbComm = new SqlCommand("sp_UpdateRental", dbConn);

            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@StartDate", rentals.StartDate);
            dbComm.Parameters.AddWithValue("@EndDate", rentals.EndDate);
            dbComm.Parameters.AddWithValue("@RentalID", rentals.RentalID);

            int x = dbComm.ExecuteNonQuery();

            dbConn.Close();
            return x;
        }
        public DataTable GetRental()
        {
            dbConn.Open();

            dbComm = new SqlCommand("sp_GetRental", dbConn);

            dt = new DataTable();

            dbAdapter = new SqlDataAdapter(dbComm);

            dbAdapter.Fill(dt);

            dbConn.Close();
            return dt;
        }


        //DAl for Reports


        public DataTable GetReport1()
        {
            dbConn.Open();

            dbComm = new SqlCommand("sp_GetReport1", dbConn);

            dt = new DataTable();

            dbAdapter = new SqlDataAdapter(dbComm);

            dbAdapter.Fill(dt);

            dbConn.Close();
            return dt;
        }
        public DataTable GetReport2()
        {
            dbConn.Open();

            dbComm = new SqlCommand("sp_GetReport2", dbConn);

            dt = new DataTable();

            dbAdapter = new SqlDataAdapter(dbComm);

            dbAdapter.Fill(dt);

            dbConn.Close();
            return dt;
        }
        public DataTable GetReport3()
        {
            dbConn.Open();

            dbComm = new SqlCommand("sp_GetReport3", dbConn);

            dt = new DataTable();

            dbAdapter = new SqlDataAdapter(dbComm);

            dbAdapter.Fill(dt);

            dbConn.Close();
            return dt;
        }
        public DataTable GetReport4()
        {
            dbConn.Open();

            dbComm = new SqlCommand("sp_GetReport4", dbConn);

            dt = new DataTable();

            dbAdapter = new SqlDataAdapter(dbComm);

            dbAdapter.Fill(dt);

            dbConn.Close();
            return dt;
        }

        public DataTable GetReport5()
        {
            dbConn.Open();

            dbComm = new SqlCommand("sp_GetReport5", dbConn);

            dt = new DataTable();

            dbAdapter = new SqlDataAdapter(dbComm);

            dbAdapter.Fill(dt);

            dbConn.Close();
            return dt;
        }



        public DataTable GetReport6()
        {
            dbConn.Open();

            dbComm = new SqlCommand("sp_GetReport6", dbConn);

            dt = new DataTable();

            dbAdapter = new SqlDataAdapter(dbComm);

            dbAdapter.Fill(dt);

            dbConn.Close();
            return dt;
        }

    }
}
