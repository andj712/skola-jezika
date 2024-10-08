using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation.SOJezik
{
    internal class UcitajListuJezikaSO : SystemOperationBase
    {
        public List<IEntity> result { get; set; }


       
        protected override void ExecuteConcreteOperation()
        {
            result=broker.GetAll(new Jezik());
        }
    }
}
