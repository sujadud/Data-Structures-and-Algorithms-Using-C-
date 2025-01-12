
public class Program
{
    private static void Main(string[] args)
    {
        #region Chapter 1 - INTRODUCTION TO COLLECTIONS, GENERICS, AND TIMING CLASS
            // This chapter introduces a custom-built class, the Timing class, which
            // we will use in several chapters to measure the performance of a data structure
            // and/or algorithm. This class will take the place of Big O analysis, not because
            // Big O analysis isn’t important, but because this book takes a more practical
            // approach to the study of data structures and algorithms.           

            //COLLECTIONS DEFINED
                // A collection is a structured data type that stores data and provides operations
                // for adding data to the collection, removing data from the collection, updating
                // data in the collection, as well as operations for setting and returning the values
                // of different attributes of the collection.

            // Collections can be broken down into two types: linear and nonlinear. 
                // A linear collection is a list of elements where one element follows the previous
                // element. in the computer world (which is also real), an array is
                // designed as a linear collection.

                // Nonlinear collections hold elements that do not have positional order
                // within the collection. In the computer world, trees, heaps, graphs, 
                // and sets are nonlinear collections.

            // COLLECTIONS DESCRIBED
                // Within the two major categories of collections are several subcategories.
                // Linear collections can be either direct access collections or sequential access
                // collections, whereas nonlinear collections can be either hierarchical or
                // grouped. This section describes each of these collection types.



            #region 1. Direct Access Collections
            // 1. Array 2. String 3. struct
            // The most common example of a direct access collection is the array. We define
            // an array as a collection of elements with the same data type that are directly
            // accessed via an integer index.

            // Arrays
            // Arrays can be static so that the number of elements specified when the array
            // is declared is fixed for the length of the program, or they can be dynamic.
            // In C#, arrays are not only a built-in data type, they are also a class. 
            // We can use an array to store a linear collection. Examples of arrays comes leater.

            // String
            // String is an another type of direct access collection. A string is a collection
            // of characters that can be accessed based on their index. C# strings are immutable, 
            // meaning once a string is initialized it cannot be changed. Strings are also 
            // implemented as class objects in C#. 

            // struct
            // The final direct access collection type is the struct.(structures and records called
            // in other languages). A struct is a composite data type that holds data that may 
            // consist of many different data types. A structure is a user-defined data type that 
            // can contain data members and methods.

            // The following code demonstrates a simple use of a structure in C#: a Name structure 
            // that stores a person’s first, middle, and last names.

                #region 1. struct                 
                    // using DSA_C_;

                    // Name myName = new Name("Sujad", "ud", "Doula");
                    // string fullName, inits;
                    // fullName = myName.ToString();
                    // inits = myName.Initials();
                    // System.Console.WriteLine("My name is {0}", fullName);
                    // System.Console.WriteLine("My initials are {0}", inits);

                #endregion

                // The .NET environment are implemented as classes (such as arrays and strings), 
                // several primary elements of the language are implemented as structures, such 
                // as the numeric data types. The Integer data type, for example, is implemented 
                // as the Int32 structure. One of the methods you can use with Int32 is the Parse 
                // method for converting the string representation of a number into an integer.
                // Here’s an example:

                #region 2. Int32                    
                    // int num;
                    // string snum;
                    // Console.WriteLine("Enter a number: ");
                    // snum = Console.ReadLine();
                    // num = Int32.Parse(snum);
                    // Console.WriteLine("The number is {0}", num);
                #endregion
                
                

                #region 3. String

                #endregion
            #endregion
        #endregion
    }    
}