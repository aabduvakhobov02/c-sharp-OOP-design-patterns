using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProFlowersObserver
{
    public class Client : IClient
    {
        public string name;
        public Client(string name)
        {
            this.name = name;
        }
        public void Update(Bouquet bouquet)
        {
            Console.WriteLine("{0}: {1} is now available. Price: {2} soums", this.name, bouquet.Name, bouquet.Price);
        }
    }
}
