using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary
{
    class TransactionModel
    {
        public int Id { get; set; }
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public string Color { get; set; }
        public DateTime OnLot { get; set; }
        public string Reason { get; set; }
        public int Title { get; set; }
        public DateTime Released { get; set; }
        public string HowReleased { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public decimal AmountDue { get; set; }
        public decimal AmountPaid { get; set; }

    }
}
