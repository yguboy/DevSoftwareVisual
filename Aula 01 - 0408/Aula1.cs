using System;
using System.Collections.Generic;

namespace GerenciamentoClientes
{
    class Program
    {
        static List<Customer> customers = new List<Customer>();
        static int nextId = 1;

        static void Main(string[] args)
        {
            bool quit = false;

            while (!quit)
            {
                Console.WriteLine("== Gerenciamento de Clientes da Loja ==");
                Console.WriteLine("1. Adicionar Cliente");
                Console.WriteLine("2. Listar Clientes");
                Console.WriteLine("3. Atualizar Cliente");
                Console.WriteLine("4. Remover Cliente");
                Console.WriteLine("5. Sair");
                Console.Write("Escolha uma opção: ");
                
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddCustomer();
                        break;
                    case 2:
                        ListCustomers();
                        break;
                    case 3:
                        UpdateCustomer();
                        break;
                    case 4:
                        RemoveCustomer();
                        break;
                    case 5:
                        quit = true;
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }

        static void AddCustomer()
        {
            Console.Write("Digite o nome do cliente: ");
            string name = Console.ReadLine();
            Console.Write("Digite o e-mail do cliente: ");
            string email = Console.ReadLine();
            Console.Write("Digite o telefone do cliente: ");
            string phone = Console.ReadLine();

            Customer customer = new Customer
            {
                Id = nextId,
                Name = name,
                Email = email,
                Phone = phone
            };

            customers.Add(customer);
            nextId++;
            Console.WriteLine("Cliente adicionado com sucesso!");
        }

        static void ListCustomers()
        {
            Console.WriteLine("== Lista de Clientes da Loja ==");
            foreach (var customer in customers)
            {
                Console.WriteLine($"ID: {customer.Id}, Nome: {customer.Name}, E-mail: {customer.Email}, Telefone: {customer.Phone}");
            }
        }

        static void UpdateCustomer()
        {
            Console.Write("Digite o ID do cliente a ser atualizado: ");
            int id = int.Parse(Console.ReadLine());
            Customer customerToUpdate = customers.Find(c => c.Id == id);

            if (customerToUpdate != null)
            {
                Console.Write("Digite o novo nome do cliente: ");
                string newName = Console.ReadLine();
                Console.Write("Digite o novo e-mail do cliente: ");
                string newEmail = Console.ReadLine();
                Console.Write("Digite o novo telefone do cliente: ");
                string newPhone = Console.ReadLine();

                customerToUpdate.Name = newName;
                customerToUpdate.Email = newEmail;
                customerToUpdate.Phone = newPhone;
                Console.WriteLine("Cliente atualizado com sucesso!");
            }
            else
            {
                Console.WriteLine("Cliente não encontrado.");
            }
        }

        static void RemoveCustomer()
        {
            Console.Write("Digite o ID do cliente a ser removido: ");
            int id = int.Parse(Console.ReadLine());
            Customer customerToRemove = customers.Find(c => c.Id == id);

            if (customerToRemove != null)
            {
                customers.Remove(customerToRemove);
                Console.WriteLine("Cliente removido com sucesso!");
            }
            else
            {
                Console.WriteLine("Cliente não encontrado.");
            }
        }
    }
}
