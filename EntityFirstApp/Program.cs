using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            using (var ctx = new EFDbContext())
            {
                ctx.SaveChanges();
            }
        }
    }
}
