using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M003HW4.LINQTask
{
    internal interface IContact : IEquatable<IContact>
    {
        public string Name { get; }
        public string PhoneNumber { get; }
        public int Age { get; }
    }
}
