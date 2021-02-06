using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerManagement
{
    //inheritance
    class IndividualCustomer:Customer
    {
        

        public string IdCardNo { get; set; }

        public string CustomerName { get; set; }

        public string CustomerSurname { get; set; }
    }
}
