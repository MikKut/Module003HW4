using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace M003HW4.DelegateTask
{
    internal static class Subscriber
    {
        public delegate int SumHandler(SumEventArgs e);
        public static event SumHandler? Subscribed;
        public static void Subscribe()
        {
            Subscribed += Provider.Sum;
        }
        public static void OnInvoke(SumEventArgs args)
        {
            Console.WriteLine(Subscribed?.Invoke(args));
        }
    }
}
