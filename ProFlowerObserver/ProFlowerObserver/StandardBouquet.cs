using ProFlowersObserver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProFlowerObserver
{

    public class StandardBouquet
    {
        public string Name { get; set; }
        private double _price;
        public double Price
        {
            get
            {
                return _price;
            }

            set
            {
                _price = value;
            }
        }

        List<Client> StandardClients = new List<Client>();
        



        public StandardBouquet(string name, double price)
        {
            this.Name = name;
            this.Price = price;

            Client client1 = new Client("To'htaniyoz ota");
            Client client2 = new Client("Qunduz amaki");

            StandardClients.Add(client1);
            StandardClients.Add(client2);
        }
        public void StandardNotify()
        {
            foreach (Client client in StandardClients)
            {
                Console.WriteLine($"{client.name}: {Name} is now available. Price: {Price} soums");
            }
        }
    }

    public class StandardClientList
    {
        List<Client> clients = new List<Client>();

        public List<Client> clientList()
        {
            return clients;
        }
    }
}
