using System;

namespace ProjectConstruction
{
    internal class MySqlConnection
    {
        private object databaseconnectionString;

        public MySqlConnection(object databaseconnectionString)
        {
            this.databaseconnectionString = databaseconnectionString;
        }

        internal void Open()
        {
            throw new NotImplementedException();
        }
    }
}