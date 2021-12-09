using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class EnterpriceObserver : Enterprice, IObserver
    {
        public Boolean isTimeToSendRecs { get; set; } = false;
        public void Update()
        {
            isTimeToSendRecs = true;
        }
    }
}
