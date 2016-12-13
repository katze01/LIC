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

                string input = Console.ReadLine();
                while (input != null)
                {
                    Console.WriteLine(myAssignment.IsPalindromeOrAnagramOfPalindrome(input) ? "true" : "false");
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
