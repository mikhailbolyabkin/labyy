using System;
using System.Collections.Generic;
using System.Text;

namespace Pogoda.DomainObjects
{
    public class Pogoda : DomainObject
    {

        public string Min { get; set; }

        public string Max { get; set; }

        public Prognoz Prognoz { get; set; }

        public PogodaType PogodaType { get; set; }
    }
}
