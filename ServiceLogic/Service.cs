using System;
using System.Collections;
using System.Collections.Generic;

namespace CourseProject
{
    public class Service : IEnumerable<Client>
    {
        public string Name { get; private set; }
        public string Address { get; private set; }

        private DoublyLinkedList<Client> clients;

        public Service(string name, string address)
        {
            Name = name;
            Address = address;
            clients = new DoublyLinkedList<Client>();
        }

        public void Add(Client client)
        {
            clients.Add(client);
            Console.WriteLine("Клиент " + client.Name + " с номером заказа " + client.Number + " был добавлен в очередь.");
        }

        public Client Buy()
        {
            Client client = clients.RemoveFirst();
            Console.WriteLine("Клиент " + client.Name + " с номером заказа " + client.Number + " получил плэйстейшон 5 за 90к рублей)");
            return client;
        }

        public Client Mistake()
        {
            Client client = clients.RemoveLast();
            Console.WriteLine("Клиент " + client.Name + " с номером заказа " + client.Number + " ошибся магазином и покинул очередь.");
            return client;
        }

        public void GetAway(Client client)
        {
            clients.Remove(client);
            Console.WriteLine("Клиент " + client.Name + " с номером заказа " + client.Number + " был выгнан владельцами конторки за неподобающее поведение.");
        }

        public IEnumerator<Client> GetEnumerator()
        {
            return ((IEnumerable<Client>)clients).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)clients).GetEnumerator();
        }
    }
}
