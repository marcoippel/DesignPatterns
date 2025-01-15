using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Business
{
    public interface IObserver
    {
        void Update(string propertyName, string value);
    }
}
