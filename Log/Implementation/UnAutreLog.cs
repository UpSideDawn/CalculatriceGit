using Log.Interface;
using System.Text;

namespace Log.Implementation
{
    public class UnAutreLog : ILog
    {
        public void Error(string str)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Error/ {0} / : {1}", DateTime.Now, str);
            // flush every 20 seconds as you do it
            File.AppendAllText("~/log.txt", sb.ToString());
            sb.Clear();
        }

        public void Info(string str)
        {

            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Info/ {0} / : {1}", DateTime.Now, str);
            // flush every 20 seconds as you do it
            File.AppendAllText("./log.txt", sb.ToString());
            sb.Clear();
        }

        public void Warn(string str)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Warn/ {0} / : {1}", DateTime.Now, str);
            // flush every 20 seconds as you do it
            File.AppendAllText("~/log.txt", sb.ToString());
            sb.Clear();
        }
    }
}
