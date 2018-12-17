using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VoxData.Shared.Functions;

namespace VoxData.VoxCRM.Service.CRIStatistics
{
    internal class Reader
    {
        private Log log;

        public bool bReading { get; private set; }

        public Reader(Log pLog)
        {
            this.log = pLog;
            this.bReading = false;
        }

        public void InitReader()
        {
            if(CRIService.bStoping || this.bReading)
                return;

            this.bReading = true;



            this.bReading = false;
        }

    }
}
