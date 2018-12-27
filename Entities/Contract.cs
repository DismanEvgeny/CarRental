using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Contract
    {
        private static int IDCounter = 0;
        public int contractID { get; set; }
        public int clientID { get; set; }
        public int workerID { get; set; }
        public int cardID { get; set; }
        public DateTime dateOfLeasing { get; set; }
        public DateTime dateOfStipulatedReturn { get; set; }
        public DateTime dateOfReturning { get; set; }
        private double summ { get; set; }
        public string comment { get; set; }

        public Contract(int _contractID, int _clientID, int _workerID, int _cardID, DateTime _dateOfLeasing,
            DateTime _dateOfStipulatedReturn, DateTime _dateOfReturning, double _summ, string _comment)
        {
            this.contractID = _contractID;
            this.clientID = _clientID;
            this.workerID = _workerID;
            this.cardID = _cardID;
            this.dateOfLeasing = _dateOfLeasing;
            this.dateOfStipulatedReturn = _dateOfStipulatedReturn;
            this.dateOfReturning = _dateOfReturning;
            this.summ = _summ;
            this.comment = _comment;
        }

    }
}
