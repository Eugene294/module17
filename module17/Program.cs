namespace module17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CommonAccount commonAcc = new CommonAccount(750);    

            Calculator.CalculateInterest(commonAcc);

            Console.WriteLine(commonAcc.Interest);


            SalaryAccount salaryAcc = new SalaryAccount(750);

            Calculator.CalculateInterest(salaryAcc);

            Console.WriteLine(salaryAcc.Interest);
        }
    }
}
