using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProFlowersObserver
{
    public interface IBouquet
    {
        void Subscribe(Client client);
        void Unsubsribe(Client client);
        void Notify();
    }
}
