using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using WEB_API_ADVANCE_ASSIGNMENT.Model;

namespace WEB_API_ADVANCE_ASSIGNMENT.Data
{
    public interface IEmployee_Interface 
    {
        DataSet GetData(); 
        DataSet GetDataId(int id);
        bool InsertData(Employees employee); 
        bool UpdateData(int id,Employees employee);
        bool DeleteData(int id,Employees employee); 
    } 
}
