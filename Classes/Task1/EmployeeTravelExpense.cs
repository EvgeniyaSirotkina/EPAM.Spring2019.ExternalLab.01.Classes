using System;
using System.Reflection;

namespace Task1
{
    public class EmployeeTravelExpense
    {
        private const decimal Rate = 7m;

        private string account;

        private decimal transport;

        private int days;

        public EmployeeTravelExpense()
        {
            Account = default;
            Transport = default;
            Days = default;
        }

        public EmployeeTravelExpense(string account, decimal transport, int days)
        {
            Account = account;
            Transport = transport;
            Days = days;
        }

        public string Account
        {
            get => account;
            set { account = value; }
        }

        public decimal Transport
        {
            get => transport;
            set { transport = value; }
        }

        public int Days
        {
            get => days;
            set { days = value; }
        }

        public decimal GetTotal() => Transport + Rate * Days;

        private FieldInfo[] getFieldsInfo()
        {
            var type = GetType();

            return type.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
        }

        public void Show()
        {
            var fieldInfo = getFieldsInfo();

            foreach (var item in fieldInfo)
            {
                Console.WriteLine($"{item.Name} = {item.GetValue(this)}");
            }

            Console.WriteLine($"total = {GetTotal()}\n");
        }

        public override string ToString() => $"{Rate};{Account};{Transport};{Days}";
    }
}
