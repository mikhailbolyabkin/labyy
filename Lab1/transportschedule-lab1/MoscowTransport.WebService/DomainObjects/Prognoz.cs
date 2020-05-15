using System;
using System.Collections.Generic;
using System.Text;

namespace Pogoda.DomainObjects
{
    public class Prognoz : DomainObject
    {
        public string Nachalo { get; set; }

        public string Konec { get; set; }

        public string Vipusk { get; set; }
    }
}
