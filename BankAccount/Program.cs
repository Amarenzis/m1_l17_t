using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Первый аккаунт
            //Внесение данных по первому аккаунту
            BankAccount<string> account1 = new BankAccount<string>();
            string numberAccount1 = "0001А";
            account1.SetNumber(numberAccount1);
            double balanceAccount1 = 153331.05;
            account1.SetBalance(balanceAccount1);
            string nameAccount1 = "Стринг Иван Иванович";
            account1.SetFullName(nameAccount1);

            //Вывод на печать - вывод на консоль?..
            Console.WriteLine("Номер счёта: {0}\nБаланс: {1}\nФИО: {2}", account1.GetNumber(),account1.GetBalance(),account1.GetFullName());
            #endregion
            Console.WriteLine("");

            #region Второй аккаунт
            //Внесение данных по первому аккаунту
            BankAccount<int> account2 = new BankAccount<int>();
            int numberAccount2 = 13024;
            account2.SetNumber(numberAccount2);
            double balanceAccount2 = 88485.5;
            account2.SetBalance(balanceAccount2);
            string nameAccount2 = "Инт Сергей Сергеевич";
            account2.SetFullName(nameAccount2);

            //Вывод на печать
            Console.WriteLine("Номер счёта: {0}\nБаланс: {1}\nФИО: {2}", account2.GetNumber(), account2.GetBalance(), account2.GetFullName());
            #endregion
            Console.WriteLine("");

            #region Третий аккаунт
            //Внесение данных по первому аккаунту
            BankAccount<byte> account3 = new BankAccount<byte>();
            byte numberAccount3 = 132;
            account3.SetNumber(numberAccount3);
            double balanceAccount3 = 78371.05;
            account3.SetBalance(balanceAccount3);
            string nameAccount3 = "Байт Михаил Михайлович";
            account3.SetFullName(nameAccount3);

            //Вывод на печать
            Console.WriteLine("Номер счёта: {0}\nБаланс: {1}\nФИО: {2}", account3.GetNumber(), account3.GetBalance(), account3.GetFullName());
            #endregion


            Console.ReadKey();
        }
    }
    class BankAccount <T>
    {
        //Поля и автосвойства. Карта с ограничением
        private T NumberAccount;
        private double BalanceAccount;
        private string FullName;

        //Запись. Баланс может быть отрицательным
        public void SetNumber(T number)
        {
            NumberAccount = number;
        }
        public void SetBalance(double balance)
        {
            BalanceAccount = balance;
        }
        public void SetFullName(string name)
        {
            FullName = name;
        }


        public T GetNumber ()
        {
            return NumberAccount;
        }
        public double GetBalance()
        {
            return BalanceAccount;
        }
        public string GetFullName()
        {
            return FullName;
        }

    }
}
