using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProFlowersObserver
{
    public interface IClient
    {
        void Update(Bouquet bouquet);
    }
}
