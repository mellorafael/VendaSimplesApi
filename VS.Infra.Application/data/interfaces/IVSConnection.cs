using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace VS.Infra.Application.data.interfaces
{
    public interface IVSConnection
    {
        public IDbConnection Conn { get; set; }
    }
}
