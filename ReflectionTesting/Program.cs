using System;
using System.Reflection;

namespace ReflectionTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            string Perm = "SignUps"; 

            AdminRole aRole = new AdminRole();
            Type aType = typeof(AdminRole);
            PropertyInfo fInfo = aType.GetProperty(Perm);
            bool output = (bool)fInfo.GetValue(aRole);
            Console.WriteLine($"SignUps is set to {output}");
        }
    }
}
