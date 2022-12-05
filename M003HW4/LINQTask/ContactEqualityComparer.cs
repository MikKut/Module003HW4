using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace M003HW4.LINQTask
{
    internal class ContactEqualityComparer : IEqualityComparer<IContact>
    {
        public bool Equals(IContact? x, IContact? y)
        {
            return x.Equals(y);
        }

        public int GetHashCode([DisallowNull] IContact obj)
        {
            return (obj.PhoneNumber, obj.Age, obj.Name).GetHashCode();
        }
    }
}
