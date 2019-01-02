using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework{
    public interface DatabaseConnection{
        SqlDataReader readData();
        int addMore(Object obj);
        int update(Object obj);
        int delete(Object obj);
        List<String> getField();
    }
}
