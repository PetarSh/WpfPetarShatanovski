using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfPetarShatanovski.Infrastructure
{
    public enum AddressType
    {
        Default = 1,
        Type1 = 1,
        Type2 = 2,
        Type3 = 3,
        Other = 4
    }

    public class MessageEventArgs:EventArgs
    {
        public string Message { get; set; }
    }
}
