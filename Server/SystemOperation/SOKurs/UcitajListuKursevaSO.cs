using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server.SystemOperation.SOKurs
{
    internal class UcitajListuKursevaSO : SystemOperationBase
    {

        public List<IEntity> result { get; set; }

        private readonly string Search;

        public UcitajListuKursevaSO()
        {
                
        }
        public UcitajListuKursevaSO(string search)
        {
            Search = search;
        }
        protected override void ExecuteConcreteOperation()
        {
          
                result = broker.GetAll(new Kurs(),Search);

           
            
        }
    }
}
