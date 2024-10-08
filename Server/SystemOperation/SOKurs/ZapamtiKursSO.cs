using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation.SOKurs
{
    internal class ZapamtiKursSO : SystemOperationBase
    {
        private readonly Kurs kurs;

        public ZapamtiKursSO(Kurs kurs)
        {
                this.kurs = kurs;
        }
        protected override void ExecuteConcreteOperation()
        {
            broker.Add(kurs);
        }
    }
}
