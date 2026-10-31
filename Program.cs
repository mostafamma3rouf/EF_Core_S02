using EF_Core_S02.AppDbContexts;

namespace EF_Core_S02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using EventHubDbContext context = new EventHubDbContext();
        }
    }
}
