using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server.SystemOperation.SOGrupa
{
    internal class ZapamtiGrupuSO : SystemOperationBase
    {
        private readonly Grupa grupa;

        public ZapamtiGrupuSO(Grupa grupa)
        {
                this.grupa=grupa;
        }

        protected override void ExecuteConcreteOperation()
        {
            int id=broker.AddAndReturnId(grupa);
            grupa.Id = id;
            foreach(Raspored r in grupa.Rasporedi)
            {
                r.Grupa = grupa;
                broker.Add(r);
            }
        }
    }
}
