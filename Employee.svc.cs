using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Employee" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Employee.svc or Employee.svc.cs at the Solution Explorer and start debugging.
    public class Employee : IEmployee
    {
        StockDBEntities db = new StockDBEntities();
        List<UserAuth> userData;
        public void DoWork()
        {
        }

        
        public List<UserAuth> getEmployees()
        {
            userData = db.UserAuths.ToList();
            return userData;
        }


        public UserAuth getEmployeeRowById(string id)
        {
            return db.UserAuths.FirstOrDefault(x => x.id == id);
        }

        public string getEmployeeNameById(string id)
        {
            UserAuth a = db.UserAuths.FirstOrDefault(x => x.id == id);
            return a.uname;
        }

        public bool updateEmployee(string id,string uname,string password)
        {
            UserAuth s = db.UserAuths.SingleOrDefault(x => x.id == id);
            if (s == null) return false;
            s.uname = uname;
            s.password = password;
            db.SaveChanges();
            return true;
        }

        public bool deleteEmployee(string id)
        {
            UserAuth s = db.UserAuths.SingleOrDefault(x => x.id == id);
            if (s == null) return false;
            db.UserAuths.Remove(s);
            db.SaveChanges();

            return true;
        }

        public bool insertEmployee(string id,string uname , string password)
        {
            UserAuth s =new UserAuth();
            s.id = id;
            s.uname = uname;
            s.password = password;
            db.UserAuths.Add(s);
            db.SaveChanges();
            return true;
        }

    }
}
