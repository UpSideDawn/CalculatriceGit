
using Services.Interface;
using Log.Interface;



namespace Services.Services
{
    public class HeureDecalageService : IHeureDecalageService
    {

        private ILog _log;

        public HeureDecalageService(ILog log)
        {

            _log = log;
        }
        public string HeureParis()
        {
            return DateTime.UtcNow.AddHours(2).ToString();

            _log.Info("A Paris, il est actuellement " + DateTime.UtcNow.AddHours(2).ToString());
            
        }

        public string HeureBresil()
        {
            return (DateTime.UtcNow.AddHours(-3).ToString());

            _log.Info("A Paris, il est actuellement " + DateTime.UtcNow.AddHours(-3).ToString());
        }
        public string HeureJapon()
        {
            return DateTime.UtcNow.AddHours(9).ToString();

            _log.Info("A Paris, il est actuellement " + DateTime.UtcNow.AddHours(9).ToString());
        }

        public string HeureCustom(int heureDecalage)
        {
            return DateTime.UtcNow.AddHours(heureDecalage + 2).ToString();

            _log.Info("Dans un pays customisé, (par rapport à l'heure en France) il est actuellement " + DateTime.UtcNow.AddHours(heureDecalage + 2).ToString());
        }
    }
}
