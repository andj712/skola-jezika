using Common.Domain;
using DBBroker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation.SOGrupa
{
    internal class UcitajGrupuSO:SystemOperationBase
    {
        private readonly Grupa grupa;
        public IEntity result { get; set; }

        public UcitajGrupuSO(Grupa grupa)
        {
            this.grupa = grupa;
        }
        protected override void ExecuteConcreteOperation()
        {
            result = broker.GetById(grupa); ;
        }
    }
}
