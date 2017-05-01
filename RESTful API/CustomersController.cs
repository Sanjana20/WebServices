using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MvcApplication1.Models;

namespace MvcApplication1.Controllers
{
    public class CustomersController : ApiController
    {
        Customer[] customers = new Customer[]
         {
             new Customer { CustomerID = 1, CustomerName = "Customer 1", 
                            Phone = 9999999999 },
             new Customer { CustomerID = 2, CustomerName = "Customer 2", 
                            Phone = 9999999900 },
             new Customer { CustomerID = 3, CustomerName = "Customer 3", 
                            Phone = 9900009999 },
            new Customer { CustomerID = 4, CustomerName = "Customer 4", 
                            Phone = 9999900999 }
         };
        public IEnumerable<Customer> GetCustomers()
        {
            return customers;
        }
    }
}
