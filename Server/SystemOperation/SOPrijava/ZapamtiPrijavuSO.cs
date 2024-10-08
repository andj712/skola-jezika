using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation.SOPrijava
{
    internal class ZapamtiPrijavuSO : SystemOperationBase
    {
        private readonly Prijava prijava;

        public IEntity result { get; set; }

        public ZapamtiPrijavuSO(Prijava prijava)
        {
            this.prijava = prijava;
        }
        protected override void ExecuteConcreteOperation()
        {
            broker.Add(prijava);
        }
    }
}
