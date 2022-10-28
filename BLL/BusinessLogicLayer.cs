using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    public class BusinessLogicLayer
    {
        DataAcessLayer dal = new DataAcessLayer();



        //DAL for Form 1 "Login/Home"



        public DataTable GetLoginAgent(string Email, string Password)
        {

            return dal.GetLoginAgent(Email, Password);

        }

        public DataTable GetAdminLogin(string AdminEmail, string AdminPassword)
        {

            return dal.GetAdminLogin(AdminEmail, AdminPassword);

        }

        public DataTable getTenantLogin(string Email, string Password)
        {

            return dal.GetTenantLogin(Email, Password);

        }

        public DataTable getLoggedTenant(int TenantID)
        {

            return dal.GetLoggedTenant(TenantID);

        }
        public int UpdateLoggedTenant(Tenant tenant)
        {

            return dal.UpdateLoggedTenant(tenant);
        }



        // DAL for Form 2 "PropertyType"



        public int InsertPropertyType(PropertyType propertyType)
        {
            return dal.InsertPropertyType(propertyType);
        }

        public DataTable GetPropertyType()
        {
            return dal.GetPropertyType();
        }



        //DAL for form 3 "Properties"



        public int InsertProperty(Property property)
        {

            return dal.InsertProperty(property);

        }

        public int UpdateProperty(Property property)
        {

            return dal.UpdateProperty(property);

        }

        public int DeleteProperty(Property property)
        {

            return dal.UpdateProperty(property);

        }

        public DataTable GetProperty()
        {

            return dal.GetProperty();

        }



        //DAL for Form 4 "Provinces"



        public int InsertProvince(Province province)
        {

            return dal.InsertProvince(province);

        }
        public DataTable GetProvince()
        {

            return dal.GetProvince();

        }




        //DAL for Form 5 "Cities"



        public int InsertCity(Cities cities)
        {

            return dal.InsertCity(cities);

        }
        public DataTable GetCity()
        {

            return dal.GetCity();

        }



        //DAL for Form 6 "Suburbs"


        public int InsertSuburb(Suburbs suburbs)
        {

            return dal.InsertSuburb(suburbs);

        }
        public DataTable GetSuburb()
        {

            return dal.GetSuburb();

        }



        // DAL for Form 7 "Agencies"


        public int InsertAgency(Agencies agencies)
        {

            return dal.InsertAgency(agencies);

        }

        public int DeleteAgency(Agencies agencies)
        {

            return dal.DeleteAgency(agencies);

        }

        public DataTable GetAgency()
        {

            return dal.GetAgency();

        }



        //DAL for Form 8 "Agents"


        public int InsertAgent(Agents agents)
        {

            return dal.InsertAgent(agents);

        }

        public int UpdateAgent(Agents agents)
        {

            return dal.UpdateAgent(agents);

        }

        public int DeleteAgent(Agents agents)
        {

            return dal.DeleteAgent(agents);

        }

        public DataTable GetAgent()
        {

            return dal.GetAgent();

        }


        // DAL for Form 9 



        public int InsertTenant(Tenant tenant)
        {

            return dal.InsertTenant(tenant);

        }

        public int UpdateTenant(Tenant tenant)
        {

            return dal.UpdateTenant(tenant);

        }

        public int DeleteTenant(Tenant tenant)
        {

            return dal.DeleteTenant(tenant);

        }

        public DataTable GetTenant()
        {

            return dal.GetTenant();

        }



        // DAL for Form 10 "PropertyTenant"



        public int InsertPropertyAgent(PropertyAgent propertyAgent)
        {

            return dal.InsertPropertyAgent(propertyAgent);

        }

        public int UpdatePropertyAgent(PropertyAgent propertyAgent)
        {

            return dal.UpdatePropertyAgent(propertyAgent);

        }

        public DataTable GetPropertyAgent()
        {

            return dal.GetPropertyAgent();

        }



        //DAl for Form 11 "Rentals"

        public int InsertRental(Rentals rentals)
        {

            return dal.InsertRental(rentals);

        }

        public int UpdateRental(Rentals rentals)
        {

            return dal.UpdateRental(rentals);

        }

        public DataTable GetRental()
        {

            return dal.GetRental();

        }


        //BLL for Reports


        public DataTable GetReport1()
        {

            return dal.GetReport1();

        }

        public DataTable GetReport2()
        {

            return dal.GetReport2();

        }
        public DataTable GetReport3()
        {

            return dal.GetReport3();

        }
        public DataTable GetReport4()
        {

            return dal.GetReport4();

        }
        public DataTable GetReport5()
        {

            return dal.GetReport5();

        }

        public DataTable GetReport6()
        {

            return dal.GetReport6();

        }
    }
}
