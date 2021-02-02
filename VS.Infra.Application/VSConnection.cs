using System;
using System.Data;
using VS.Infra.Application.data.interfaces;

namespace VS.Infra.Application
{
    public class VSConnection : IVSConnection
    {
        public IDbConnection Conn { get; set; }
        public VSConnection(string ConnetionString)
        {
            Conn = new System.Data.SqlClient.SqlConnection(ConnetionString);
        }
    }
}
