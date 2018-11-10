using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComandaPattern.Command;

namespace ComandaPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Вставьте карту");

            Client client = new Client("Chentsova Anastasia", "0150457560", 3000, "Ченцова Анастасия");
            BankTerminal bankTerminal;
            ICommand command;
            Console.WriteLine($"Здравствуйте, {client.ClientName}");
            Console.WriteLine("Выберите операцию: \n1 - проверить баланас на карте \n2 - снять деньги с карты \n3 - пополнить баланс на карте \n4 - перевод денег на другую карту");



            while (true)
            {
                int.TryParse(Console.ReadLine(), out int choice);
                switch (choice)
                {
                    case 1:
                        bankTerminal = new BankTerminal();
                        command = new SelectCommand(client.GetDataBase());
                        bankTerminal.BeginTransaction(command);
                        break;
                    case 2:
                        bankTerminal = new BankTerminal();
                        Console.WriteLine("Введите сумму, которую хотите снять");
                        int.TryParse(Console.ReadLine(), out int removeMoney);

                        command = new DeleteCommand(client.GetDataBase(), removeMoney);
                        bankTerminal.BeginTransaction(command);
                        break;
                    case 3:

                        bankTerminal = new BankTerminal();
                        Console.WriteLine("Введите сумму, которую хотите внести");
                        int.TryParse(Console.ReadLine(), out int addMoney);

                        command = new AddCommand(client.GetDataBase(), addMoney);
                        bankTerminal.BeginTransaction(command);
                        break;
                    case 4:
                        bankTerminal = new BankTerminal();
                        Console.WriteLine("Введите номер карты получателя");
                        Client client2 = new Client(Console.ReadLine());
                        Console.WriteLine("Введите сумму, которую хотите перевести");
                        int.TryParse(Console.ReadLine(), out int exchangeMoney);

                        command = new UpdateCommand(client.GetDataBase(), exchangeMoney, client2);
                        bankTerminal.BeginTransaction(command);
                        break;

                    default: break;

                }
            }


            Console.ReadLine();
        }
    }
}
