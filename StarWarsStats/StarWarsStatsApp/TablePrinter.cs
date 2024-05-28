using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsStats.StarWarsStatsApp
{
    public class TablePrinter : ITablePrinter
    {
        public void Print(IEnumerable<object> objects)
        {
            foreach (object obj in objects)
            {
                Type type = obj.GetType();
                var properties = type
                    .GetProperties()
                    .Where(p => p.Name != "EqualityContract");
                Console.WriteLine(String.Join("    |    ", properties.Select(p => $"{p.GetValue(obj)}")));
            }
        }

    }
}
