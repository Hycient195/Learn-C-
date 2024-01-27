using System;
namespace HelloWorld
{
	// A class housing an abstract class must also be marked abstract.
	public abstract class DBConnection
	{
		private string _connectionString;
		public TimeSpan Timeout { get; set; }
		protected abstract string ConnectionProtocol { get; set; }

		public DBConnection(string connectionString)
		{
			if (String.IsNullOrEmpty(connectionString))
				throw new NullReferenceException("Connection string");
			_connectionString = connectionString;
		}

		// The "abstract" keyword inidicates that the method has no implementation in the base class, and must be implemented in its children classes.
		public abstract void OpenConnection();
		public abstract void CloseConnection();
	}

	public class SQLConnection: DBConnection
	{
        protected override string ConnectionProtocol { get; set; }

		public SQLConnection(string connectionString)
			: base(connectionString)
		{
			// SQL DB specific instantiation operations
		}

        // Abstract methods must be overriden in inheriting child classes
        public override void OpenConnection()
        {
			ConnectionProtocol = "HTTP";
			Console.WriteLine("Conected to SQL DB database");
        }

        public override void CloseConnection()
        {
			Console.WriteLine("Connection to SQL DB has been closed");
        }
    }

	public class OracleConnection: DBConnection
	{
        protected override string ConnectionProtocol { get; set; }

		public OracleConnection(string connectionString)
			: base (connectionString)
		{
			// Oracle DB specific instantiation operations
		}

        public override void OpenConnection()
        {
			ConnectionProtocol = "HTTPS";
			Console.WriteLine("Connected to Oracle DB Database");
        }

        public override void CloseConnection()
        {
			Console.WriteLine("Connection to Oracle DB DB has been closed");
        }
    }

    public class DBCommand
    {
        private DBConnection _connectionInstance;
        private string _instruction;

        public DBCommand(DBConnection connectionInstance, string instruction)
        {
            if (connectionInstance == null || String.IsNullOrEmpty(instruction))
                throw new NullReferenceException("Nullish instance or instruction provided");
            _connectionInstance = connectionInstance;
            _instruction = instruction;
        }

        public void Execute()
        {
            _connectionInstance.OpenConnection();
            Console.WriteLine(_instruction);
            _connectionInstance.CloseConnection();
        }
    }
}


/* An abstact method is a method that has no implementation in its class, but leaves
 * its implementation to its inheriting child classes. This is a logical design pattern
   as sometimes, a base class might not be able to sufficiently implement the functionalities
   required for a certain method, because of how abstract or bogus the implementatin is
   and thereby had to enforce that all of its inheting child classes must then implement
   this method or behaviour, in the way that best suits that child entity.

     As seen in the example above, the DB connector class may not be able to sufficiently
   implement the "ConnectDB()" method, as it does not know what kind of database is making
   the connection. But when a specific kind of database (eg SQL DB) then inherits from
   the DBConector class it must then compulsorily implement the ConnectDB method, and in
   its instance, it must then do it in a way that is relevant to SQL DB, while other
   databases like Oracle DBQL and MariaDB do same in a way that suits their own features

   It is good to note that any class that contains an abstract class, must also be marked
   abstract

   Also, when a class inherits an abstract class, it must implement "ALL" of its abstract
   members

   A property can also be marked as abstract, but a field cannot be marked abstract.

   Under the hood, the "abstract" keyword still implements the function of the "virtual"
   keyword, by allowing methods marked with this to be overriden, but this time, compulsorily

   It is also good to note that an abstract class cannot be instantiated.
*/

