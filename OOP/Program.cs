namespace OOP
{

    //we define classes here 
    //syntax
    // class classname{    }
    // classes saves information in a single space
    //primitive data types: int , string (multiple data types saved in a class)
    // memory is allocated for the class when it is created 
    //memory is where the program stores data while it is running
    // types of memory: stack and heap 
    //stack: stores local value types (int, float, bool, char), short-lived, automatically managed, faster access
    //heap: stores reference types (string, class, array) //dynamically allocated, long-lived, manually managed, slower access

    class Person
    {
        //fields (variables)
        //access modifier 
        public string name;
        public int age;
        public string gender;

    }
        internal class Program
    {
        static void Main(string[] args)
        {
            //create an object of the class Person 
            Person person1 = new Person(); //declare an object of the class Person
                                           //object is an instance of a class
                                           //Person is a reference type, so person1 is a reference to the object in memory

            person1.name = "Test"; //add name 
            person1.age = 5;
            person1.gender = "female";

            //printing person1 details
            Console.WriteLine(person1.name);
            Console.WriteLine(person1.age);
            Console.WriteLine(person1.gender);


        }


    }
}
