using System;
using StringProcess;
using Autofac;

namespace ConsoleApplication
{
    class Program
    {
        private static IContainer _container { get; set; }

        static void Main(string[] args)
        {
            Configuration();
            using (var scope = _container.BeginLifetimeScope())
            {
                IAssignment myAssignment = scope.Resolve<IAssignment>();

                Console.WriteLine("Please enter a string to check whether it is a palindrome or an anagram of a palindrome. Enter CTRL+Z to exit: ");
                string input = Console.ReadLine();

                //exit loop when ctrl+z 
                while (input != null)
                {
                    Console.WriteLine(myAssignment.IsPalindromeOrAnagramOfPalindrome(input).ToString());
                    input = Console.ReadLine();
                }
            }
        }

        /// <summary>
        /// Autofac Registeration
        /// </summary>
        static void Configuration()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<Assignment>().As<IAssignment>();
            builder.RegisterType<StringService>().As<IStringService>();
            _container =  builder.Build();
        }
    }
}
