using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services;

namespace Presenrers.Presenters
{
    public class CheckConnection
    {
        public static bool check()
        { 
            return CheckConnectionService.check();
        }
    }
}
