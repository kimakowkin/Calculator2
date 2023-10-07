using System.Text;
using System.Data;

namespace Calculator2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (Calculate())
            {
                Calculate();
            }
        }

        static bool Calculate()
        {
            Console.WriteLine("Введите операцию: ");
            try
            {
                string operation = Console.ReadLine();
                if (string.IsNullOrEmpty(operation))
                {
                    throw (new Exception("Неверная операция"));
                }
                string value = new DataTable().Compute(operation, null).ToString();
                Console.WriteLine(value);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
                return true;
            }
        }
    }
}