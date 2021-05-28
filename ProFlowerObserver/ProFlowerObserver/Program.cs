
using ProFlowerObserver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProFlowersObserver
{
    class Program
    {
        static void Main(string[] args)
        {
            Bouquet bouquet = new Bouquet("The New Year Bouquet", 150000);
            Client client1 = new Client("Nargiza Akramova");
            Client client2 = new Client("Dimitriy Pochitaev");
            bouquet.Subscribe(client1);
            bouquet.Subscribe(client2);

            
            Bouquet bouquet2 = new Bouquet("Navruz Bouquet", 200000);
            Client client3 = new Client("Said Abduvaliyev");
            bouquet2.Subscribe(client3);
            Console.WriteLine();
            Console.WriteLine("Naive:");
            StandardSubscribe();
            Console.ReadKey();
        }

        static void StandardSubscribe()
        {
            StandardBouquet standard = new StandardBouquet("Rose Bouquet", 125500);
            standard.StandardNotify();
        }
    }
}
