using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation.SOGrupa
{
    internal class UcitajListuGrupaSo : SystemOperationBase
    {
        private readonly Grupa grupa;
        public List<IEntity> result { get; set; }

        public UcitajListuGrupaSo(Grupa grupa)
        {
            this.grupa = grupa;
        }
        protected override void ExecuteConcreteOperation()
        {
            result=broker.GetAll(grupa);
        }
    }
}
