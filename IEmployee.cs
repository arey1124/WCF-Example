using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IEmployee" in both code and config file together.
    [ServiceContract]
    public interface IEmployee
    {
        [OperationContract]
        void DoWork();

        [OperationContract]
        List<UserAuth> getEmployees();

        [OperationContract]
        UserAuth getEmployeeRowById(string id);

        [OperationContract]
        string getEmployeeNameById(string id);

        [OperationContract]
        bool updateEmployee(string id, string uname, string password);

        [OperationContract]
        bool deleteEmployee(string id);

        [OperationContract]
        bool insertEmployee(string id, string uname, string password);
    }

}
