using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderApp {
  public class CustomerService {

    public static void Add(Customer customer) {
      try {
        using (var db = new OrderContext()) {
          db.Customers.Add(customer);
          db.SaveChanges();
        }
      }
      catch (Exception e) {
       
        throw new ApplicationException($"Add wrong!");
      }
    }

    public static List<Customer> GetAll() {
      using (var db = new OrderContext()) {
        return db.Customers.ToList();
      }
    }
  }

}
