namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CustomSet set = new CustomSet(4, 2);
                set.ShowSet();
                set.InvokeGenerateAndShowSubsets();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}