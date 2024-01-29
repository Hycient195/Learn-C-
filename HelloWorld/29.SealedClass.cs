using System;
namespace HelloWorld
{
    public sealed class DynamoDBConnection : DBConnection
    {
        protected override string ConnectionProtocol { get; set; }

        public DynamoDBConnection(string connectionString)
            : base(connectionString)
        {
            // DynamoDB specific instantiations.
        }

        // If the class is not marked sealed, then classes that inherit from the "DynamoDBConnection" class cannot further override the "ConnectDB()" method.
        public sealed override void OpenConnection()
        {
            Console.WriteLine("Connected to Dynamo DB");
        }

        public override void CloseConnection()
        {
            Console.WriteLine("Conection to DynamoDB has been closed.");
        }
    }

    // Cannot inherit from the "DynameDBConnection" class, as it is marked sealed
    //public class SomethingElse: DynamoDBConnection
    //{
        
    //}
}

/* The "sealed" keyword makes classes marked with it, to be unable to be inherited
 * 
   When the "sealed" keyword is marked on a method or property, it makes it impossible for that
   method or property to be further overriden by a derived class (if the child class is not marked
   sealed). It is good to note that the "sealed" keyword can only be used together
   with the "override" keyword, as child methods or properties that do not override parent class
   methods or properties are already sealed by default and cannot be overriden.

   It is used with the "override" keyword to override a base implementation, without allowing
   itself to be overriden by a chid class derivative.

   Using the "sealed" keyword has some slightly performance improvement
   when being used, though this performance boost is negligible.
*/