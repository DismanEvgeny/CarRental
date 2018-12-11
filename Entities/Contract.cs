using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    class Contract
    {
        private int contractID { get; set; }
        private int clientID { get; set; }
        private int workerID { get; set; }
        private int cardID { get; set; }
        private DateTime dateOfLeasing { get; set; }
        private DateTime dateOfStipulatedReturn { get; set; }
        private DateTime dateOfReturning { get; set; }
        private double summ { get; set; }

        public Contract()
        {

        }

        protected void setContractID(int _contractID)
        {
            this.contractID = _contractID;
        }

        protected int getContractID()
        {
            return this.contractID;
        }

        protected void setClientID(int _clientID)
        {
            this.clientID = _clientID;
        }

        protected int getClientID()
        {
            return this.clientID;
        }

        protected void setworkerID(int _workerID)
        {
            this.workerID = _workerID;
        }

        protected int getworkerID()
        {
            return this.workerID;
        }

        protected void setCardID(int _cardID)
        {
            this.cardID = _cardID;
        }

        protected int getCardID()
        {
            return this.cardID;
        }

        protected void setDateOfLeasing(DateTime _dateOfLeasing)
        {
            this.dateOfLeasing = _dateOfLeasing;
        }

        protected DateTime getDateOfLeasing()
        {
            return this.dateOfLeasing;
        }

        protected void setDateOfStipulatedReturn(DateTime _dateOfStipulatedReturn)
        {
            this.dateOfStipulatedReturn = _dateOfStipulatedReturn;
        }

        protected DateTime setDateOfStipulatedReturn()
        {
            return this.dateOfStipulatedReturn;
        }

        protected void setDateOfReturning(DateTime _dateOfReturning)
        {
            this.dateOfReturning = _dateOfReturning;
        }

        protected DateTime getDateOfReturning()
        {
            return this.dateOfReturning;
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
