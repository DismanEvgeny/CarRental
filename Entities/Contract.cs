using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    class Contract
    {
        private static int IDCounter = 0;
        private int contractID { get; set; }
        private int clientID { get; set; }
        private int workerID { get; set; }
        private int cardID { get; set; }
        private DateTime dateOfLeasing { get; set; }
        private DateTime dateOfStipulatedReturn { get; set; }
        private DateTime dateOfReturning { get; set; }
        private double summ { get; set; }

        public Contract(int _contractID, int _clientID, int _workerID, int _cardID, DateTime _dateOfLeasing,
            DateTime _dateOfStipulatedReturn, DateTime _dateOfReturning, double _summ)
        {
            this.contractID = IDCounter++;
            this.clientID = _clientID;
            this.workerID = _workerID;
            this.cardID = _cardID;
            this.dateOfLeasing = _dateOfLeasing;
            this.dateOfStipulatedReturn = _dateOfStipulatedReturn;
            this.dateOfReturning = _dateOfReturning;
            this.summ = _summ;
        }

        public double calculateSumm(DateTime _dateOfStipulatedReturn, DateTime _dateOfReturning)
        {
            if (_dateOfStipulatedReturn.Equals(_dateOfReturning))
                return this.summ;
            //_dateOfReturning.Subtract(_dateOfStipulatedReturn);
           // summ = _dateOfStipulatedReturn - _dateOfReturning;
            return this.summ;
        }
    }
}
