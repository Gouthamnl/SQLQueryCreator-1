using SqlQueryCreator.Operations;
using QueryBuilder.Services;

namespace SqlQueryCreator
{
    class Program
    {
        private static readonly QueryBuilderService query = new QueryBuilderService();
        private static readonly QueryGenerator generate = new QueryGenerator();

        static void Main(string[] args)        
        {
            var option = ReadOptions();
            GenerateQuery(option);
            Console.ReadKey();
        }
        
        private static int ReadOptions()
        {
            Console.WriteLine("select Options 1.Where Clause 2.Join Clause");
            int option = Convert.ToInt32(Console.ReadLine().ToString());
            return option;
        }

        /// <summary>
        /// Generate query based on user choosen option from console
        /// </summary>
        /// <param name="queryType"></param>
        private static void GenerateQuery(int queryType)
        {            
            if (queryType == 1)
            {
                generate.WhereQuery(query);                
            }
            else
            {
                generate.JoinQuery(query);
            }
        }
        
    }
}
