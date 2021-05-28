using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProFlowersObserver
{
    public class Bouquet : IBouquet
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
        
        
        List<Client> clients = new List<Client>();
      

        public Bouquet(string name, double price)
        {
            this.Name = name;
            this.Price = price;           
        }

        public void Notify()
        {
            foreach (Client client in clients)
            {
                client.Update(this);
            }
        }

        public void Subscribe(Client client)
        {
            clients.Add(client);
            Notify();
        }

        public void Unsubsribe(Client client)
        {
            clients.Remove(client);
        }
       
    }
}
