using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace webservice2
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        ODMSEntities db=new ODMSEntities();

        [WebMethod]
        public List<Customer> HelloWorld()
        {
            return db.Customers.ToList();
        }

         [WebMethod]
        public string Add(Customer c)
        {
            string msg="-1";

             try 
	           {	        
		         db.Customers.Add(c);
                 db.SaveChanges();
                 msg="Record Added Successfully";
	           }
	        catch (Exception)
	{
		
		msg ="Record Doesnot Added Successfully";
	}
             return msg;
        }
    }
}
