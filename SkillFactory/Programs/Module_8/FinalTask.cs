using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory.Programs.Module_8
{
    public abstract class Account
    {
        public string? Type { get; private set; }
        public double Balance { get; set; }
        public double Interest { get; set; }
        protected Account(string type, double balance, double interest)
        {
            Type = type;
            Balance = balance;
            Interest = interest;
        }
        public abstract void CalculateInterest();
    }

    public class StandardAccount : Account
    {
        public StandardAccount(string type, double balance, double interest) : base(type, balance, interest)
        {

        }

        public override void CalculateInterest()
        {
            Interest *= 0.4;
            if (Balance < 1000)
                Interest -= Balance * 0.2;
            else
                Interest -= Balance * 0.4;
        }
    }

    public class BusinessAccount : Account
    {
        public BusinessAccount(string type, double balance, double interest) : base(type, balance, interest)
        {

        }

        public override void CalculateInterest()
        {
            Interest *= 0.5;
        }
    }

    public class Calculator
    {
        private static Calculator? calcInstance;

        private Calculator()
        {
            calcInstance = new Calculator();
        }

        public static Calculator GetCalculator()
        {
            if (calcInstance == null)
                calcInstance = new Calculator();
            return calcInstance;
        }

        public void CalculateInterest(Account account)
        {
            account.CalculateInterest();
        }
    }

    internal class FinalTask
    {

    }
}
