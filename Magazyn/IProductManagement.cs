using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazyn
{
    internal interface IProductManagement
    {
        void AddProducts(List<StockedProduct> produkty);
        void ShowProducts(List<StockedProduct> produkty);
    }
}
