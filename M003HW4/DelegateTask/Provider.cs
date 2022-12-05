using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M003HW4.DelegateTask
{
    internal static class Provider
    {
        public static int Sum(SumEventArgs args)
            => args.X + args.Y;
    }
}
