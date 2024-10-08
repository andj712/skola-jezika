using Common.Domain;
using DBBroker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation
{
    public class UlogujKorisnikaSO : SystemOperationBase
    {
        public IEntity result { get; set; }

        private readonly Korisnik user;

        public UlogujKorisnikaSO(Korisnik user)
        {
            this.user = user;
        }

        protected override void ExecuteConcreteOperation()
        {
            result = broker.GetById(user);
        }
    }
}
