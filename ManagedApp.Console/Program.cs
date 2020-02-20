using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagedApp.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("NativeToManageWithPInvoke");
            using (ManagedWorker worker = new ManagedWorker())
            {
                var result = int.TryParse(args[0], out int value);
                System.Console.WriteLine("Starting");
                System.Console.WriteLine($"Result Compute: {worker.Compute(value)}");
            }
        }
    }
}
