
namespace StarWarsStats.StarWarsStatsApp
{
    public interface ITablePrinter
    {
        void Print(IEnumerable<object> objects);
    }
}