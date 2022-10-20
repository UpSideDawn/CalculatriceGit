using Log.Interface;
using Services.Interface;

namespace Services.Services
{
    public class OperationServices : IOperationService
    {

        private ILog _log;

        public OperationServices(ILog log)
        {
            _log = log;
        }


        public double Addition(List<double> lstNombres)
        {
            double res = 0.0;


            /*   foreach (var nombre in lstNombres)
               {
                   res += (double)nombre;

               }
            */

            lstNombres.ForEach(nombre => res+= (double)nombre );      // Fonction fléchée permettant à chaque nombre d'executer le calcul de res + nombre

            res = lstNombres.Sum(nombre => (double)nombre);

            _log.Info("Erreur de Franck Cotty");
            return res;

        }
    }
}
