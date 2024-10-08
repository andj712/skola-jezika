using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation.SOGrupa
{
    internal class UcitajListuRasporedaSO : SystemOperationBase
    {
        private readonly Raspored raspored;
        public List<IEntity> result { get; set; }

        public UcitajListuRasporedaSO(Raspored raspored)
        {
            this.raspored = raspored;
        }
        protected override void ExecuteConcreteOperation()
        {
            result = broker.GetAll(raspored);
        }
       
    }
}
