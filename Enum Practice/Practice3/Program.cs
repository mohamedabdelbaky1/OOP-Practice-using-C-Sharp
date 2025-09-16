using System.ComponentModel;

namespace Practice3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  3-Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum           .
            //  Create Variable from previous Enum to Add and Remove Permission from variable,
            //  check if specific Permission existed inside variable

            Permissions UserPermissions = Permissions.None;

            UserPermissions |= Permissions.Read;  // Add Read Permission
            Console.WriteLine(UserPermissions);

            UserPermissions |= Permissions.Write; // Add Write Permission
            Console.WriteLine(UserPermissions);

            UserPermissions &= ~Permissions.Read; // Remove Read Permission
            Console.WriteLine(UserPermissions);

            if((UserPermissions&Permissions.Write)==Permissions.Write)  // Check if User has Write Permission 
                Console.WriteLine("User Has Write Permission");
        }
    }
}
