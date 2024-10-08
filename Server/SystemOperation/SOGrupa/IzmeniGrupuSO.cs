using Common.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation.SOGrupa
{
    internal class IzmeniGrupuSO : SystemOperationBase
    {
        private readonly Grupa grupa;
        public IzmeniGrupuSO(Grupa grupa)
        {
            this.grupa = grupa;
        }
        protected override void ExecuteConcreteOperation()
        {
            broker.Azuriraj(grupa);

            foreach(Raspored r in grupa.Rasporedi)
            {
                if (r.Stanje == Stanje.Dodaj)
                {
                    broker.Add(r);
                }else
                if (r.Stanje == Stanje.Izmenjeno)
                {
                    broker.Azuriraj(r);
                }
                else if (r.Stanje == Stanje.Izbrisano)
                {
                    broker.Izbrisi(r);
                }
            }


            //foreach (Raspored r in grupa.Rasporedi)
            //{
            //    r.Grupa= grupa;
            //    if (grupa.StariRasporedi.Any(x => x == r)){
            //        continue;
            //    }else
            //    if(grupa.StariRasporedi.Any(x => x.Dan== r.Dan))
            //        broker.Azuriraj(r);
            //    else broker.Add(r);
            //}

            //foreach(Raspored r in grupa.StariRasporedi)
            //{

            //    if (!grupa.Rasporedi.Any(x => x.Dan == r.Dan))
            //    {
            //        broker.Izbrisi(r);
            //    }
            //}
        }
    }
}
