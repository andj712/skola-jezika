using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation.SOKurs
{
    internal class UcitajKursSO : SystemOperationBase
    {
        private readonly Kurs Kurs;
        public IEntity result { get; set; }

        public UcitajKursSO(Kurs kurs)
        {
            Kurs = kurs;
        }
        protected override void ExecuteConcreteOperation()
        {
            result = broker.GetById(Kurs); ;
        }

    }
}
