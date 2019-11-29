using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace CSAc4yObjectGetGuidCAP
{
    public class Ac4yGetGuid
    {

        private SqlConnection Connection { get; set; }

        public Ac4yGetGuid() { }

        public Ac4yGetGuid(SqlConnection connection)
        {
            Connection = connection;
        }

        public List<string> GetGuidByTemplateGuid()
        {
            int i = 0;
            List<string> guidList = new List<string>();
            using (SqlCommand command = new SqlCommand("SELECT GUID FROM ac4yObject WHERE templateGuid = '16042E6C-EF12-4F86-BC86-C213B27B78A9'", Connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine(reader.FieldCount);
                        guidList.Add(reader.GetValue(0).ToString());
                    }
                }
            }
            return guidList;
        }
    }
}
