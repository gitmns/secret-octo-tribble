using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Here is the once-per-application setup information
[assembly: log4net.Config.XmlConfigurator(ConfigFile = "MyStandardLog4Net.config", Watch = true)]

namespace Log4NetExe
{
    class Program
    {
        //Here is the once-per-class call to initialize the log object
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        static void Main(string[] args)
        {

            try
            {
                throw new System.IO.FileNotFoundException();
            }

            catch (Exception ex)
            {
                log.Error("Error error logging", ex);
            }
        }
    }
}
