using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation.SOKurs
{
    internal class IzmeniKursSO : SystemOperationBase
    {
        private readonly Kurs kurs;
        public IzmeniKursSO(Kurs kurs)
        {
            this.kurs = kurs;
        }

        protected override void ExecuteConcreteOperation()
        {
            broker.Azuriraj(kurs);
        }
    }
}
