// See https://aka.ms/new-console-template for more information

/* Enumerations (Enums for short) */

/*
 * Enums are used to group related constants. They are mapped
 * by default to number, or can also be explicitly mapped to numbers.
 * 
 * For best practice, it is best you map them to a number in order to
 * ensure consistency in future, (especially when working with databases)
 * 
 * It is also good to note that since under the hood, enums are integers,
 * they can also be efficiently casted to intergers using type casting.
 * 
 * Numeric values of enums can be casted back into the Enums. This can be
 * used to retrieve an enum value from a supplied numeric value.
 * 
 * Strings can also be typecased to values existing in enums, by first
 * parsing them by the type of the enum, and them casting them to the
 * relevant value in the enum. This is useful for mapping a value from an
 * external source (eg. Database) to a corresponding value in the application
 * with the use of a certain predefined enumeration (enum)
*/

public enum ColorStatus
{
    Rejected = 1,
    Accepted = 2,
    Pending = 3,
    UnderInvestigation = 4
}

