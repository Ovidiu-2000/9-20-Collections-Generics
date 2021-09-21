using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedListInDescendingOrder
{
    public class DescendingComparerByInternAge<Tkey> : IComparer<Intern>
    {
        public int Compare(Intern x, Intern y)
        {
            return y.Age.CompareTo(x.Age);
        }
    }
}
