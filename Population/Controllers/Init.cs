using log4net;

namespace Population.Controllers
{
    public class Init
    {
        public static void WriteLog(string className, string methodName, string text)
        {
            text = "(" + methodName + ")" + text; 
            ILog log = LogManager.GetLogger(className);
            log.Error(text);
        }
    }
}
