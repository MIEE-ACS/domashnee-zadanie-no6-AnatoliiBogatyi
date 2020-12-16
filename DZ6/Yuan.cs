using System;
using System.Collections.Generic;
using System.Text;

namespace DZ6
{
    class Yuan : Currency
    {
        private decimal amount;
        internal override decimal Amount 
        {
            get { return amount; }
            private protected set
            {
                if (value > 0)
                    amount = value;
                else
                    throw new Exception($"Exception: 'Amount' = {value}, 'Amount' should be > 0");
            }
        }

        private static decimal toRubExchangeRate = 11;
        internal static decimal ToRubExchangeRate
        {
            get { return toRubExchangeRate; }
            set
            {
                if (value > 0)
                    toRubExchangeRate = value;
                else
                    throw new Exception($"Exception: 'ToRubExchangeRate' = {value}, 'ToRubExchangeRate' should be > 0");
            }
        }

        internal override decimal ToRub() => amount * toRubExchangeRate;

        private static readonly List<Yuan> bills = new List<Yuan>();
        internal Yuan(decimal amount)
        {
            Amount = amount;
            bills.Add(this);
        }

        public override bool Equals(object obj) => (obj is Yuan) && GetHashCode().Equals(obj.GetHashCode());

        public static bool operator ==(Yuan obj1, object obj2) => obj1.Equals(obj2);

        public static bool operator !=(Yuan obj1, object obj2) => !obj1.Equals(obj2);

        public override int GetHashCode() => amount.GetHashCode();

        public override string ToString() =>
                "==========================\nAmount (CNY):\t" + amount.ToString() +
                "\nAmount (RUB):\t" + ToRub().ToString() +
                "\n==========================\n\n";

        internal static string ToList()
        {
            StringBuilder sb = new StringBuilder("LIST OF 'YUAN' OBJECTS\n\n");
            foreach (var item in bills)
                sb.Append(item.ToString());
            return sb.ToString();
        }

        internal static void Destroy(ref Yuan bill)
        {
            if (bills.Remove(bill))
                bill = null;
        }
    }
}
