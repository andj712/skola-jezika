using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation
{
    internal class ZapamtiKorisnikaSO : SystemOperationBase
    {
        private readonly Korisnik user;

        public ZapamtiKorisnikaSO(Korisnik user)
        {
            this.user = user;
        }
        protected override void ExecuteConcreteOperation()
        {
            broker.Add(user);
        }
    }
}
