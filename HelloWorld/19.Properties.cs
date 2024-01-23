using System;
public class Book
{
    /* A property is a class member that encapsulates a field, and only providing
       a setter function for updating its value, and a getter function for obtaining
       its value.

        By convention, fields are supposed to be made private as they are containers
      for storing data, while properties provide a layer of encapsulation over the
      implementation detail of the field, providing controlled access to the field.
        The field used to store value for a property under the hood is refered to as
      a "Backing Field"

       A property is the recommended way for exposing a data contained in a class
    */

    // Below are implementations of "Getter" and "Setter" propertiees of the field "_name".
    // (Fields are declared by convention with camesCase, starting with an underscore.)
    private string _title;

    public string GetName()
    {
        return this._title;
    }

    public void SetName(string name)
    {
        this._title = name;
    }


    /* C# provides a better way for implementing our manual properties written above */
    private string _genre;

    public string Genre
    {
        get { return this._genre;  }
        set { this._genre = value; }
    }


    // Auto-Implemented Properties
    /* If no logic is to be implemented, the above property can further to shrinked 
     * down using its "Auto-implemented property" syntax as seen below 
     
      The auto-implemented property encapsulates the underlying backing field under
      the hood and only exposes the property we can interract with
    */

    public string BookDetails { get; set; }

}



/* The StoryBook class below makes use of the private access modifier to prevent write
 * to the "Title" and "DateOfPublication" auto-implemented properties, and only allow
 * them to be set when an object instance is created from the StoryBook class.
   This is a form of encapsulation to protect them from any further modification. 
   This shows us that we can selectivelyrestrict access to a property by making a
   property readonly or write-only

   Access to a full property like the "AgeOfBook" property can likewise be restricted
   by intentionally ommiting either the getter or setter functions, as in this case,
   ther is no need for a user to enter the age of the book as it is automatically
   calculated from the date of publication.
 */
public class StoryBook
{
    public string Title { get; private set; }
    public DateTime DateOfPublication { get; private set; }

    public StoryBook(string title, DateTime dateOfPublication)
    {
        Title = title;
        DateOfPublication = dateOfPublication;
    }

    public int AgeOfBook
    {
        get
        {
            TimeSpan timespan = DateTime.Now - DateOfPublication;
            int bookAge = timespan.Days / 365;
            return bookAge;
        }
    }
}
