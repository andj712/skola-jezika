using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation.SOKurs
{
    internal class ObrisiKursSO : SystemOperationBase
    {
        private readonly Kurs kurs;

        public ObrisiKursSO(Kurs kurs)
        {
            this.kurs = kurs;
        }
        protected override void ExecuteConcreteOperation()
        {
            broker.Izbrisi(kurs);        }
    }
}
