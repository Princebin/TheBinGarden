using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autofacTest
{
    public class AddressService : IAddressService
    {
        public string GetAddress(int contactNumber)
        {
            string result = string.Empty;
            if (contactNumber == 123)
                result = "上海浦东";
            return result;
        }
    }
}
