using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagement_System
{
    public static class TenantList
    {
        public static List<Tenant> TenantL = new List<Tenant>();

        public static void AddTenant(Tenant tenant)
        {
            TenantL.Add(tenant);
        }

        public static List<Tenant> SearchTenant(string search)
        {
            List<Tenant> resultL = new List<Tenant>();

            foreach (var tenant in TenantL)
            {
                if (tenant.phone == search)
                {
                    resultL.Add(tenant);
                }
            }
            return resultL;
        }
    }
}
