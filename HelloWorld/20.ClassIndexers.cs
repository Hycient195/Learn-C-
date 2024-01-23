using System;
public class HttpCookie
{
    // Declaration and initialization, without a constructor.
    private readonly Dictionary<string, string> _dictionary = new Dictionary<string, string>();
    public DateTime Expiry { get; set; }

    public string this[string key]
    {
        get { return _dictionary[key]; }
        set { _dictionary[key] = value; }
    }
}

/* A class indexer is a "class property" used to access elements in a class that represents a list
 * list of values. This list of value might be numerically indexable like an array
 * or list, or indexed by a string as in the case of a dictionary, built upon a 
 * hash table
 * 
 * It is a mechanishm used by an instance of a class to access values
 * or other class members as seen in an array or dictionary 
 */
