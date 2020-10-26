using System;
using System.Data;
using System.Data.SqlClient;

namespace ProjectConstruction
{
    internal class SqlParamete
    {
        private string v;
        private SqlDbType @int;

        public SqlParamete(string v, SqlDbType @int)
        {
            this.v = v;
            this.@int = @int;
        }

        public static implicit operator SqlParameter(SqlParamete v)
        {
            throw new NotImplementedException();
        }
    }
}