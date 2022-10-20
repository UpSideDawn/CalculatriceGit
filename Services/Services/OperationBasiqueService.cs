using Log.Interface;
using Services.Interface;

namespace Services.Services
{
    
    public class OperationBasiqueService : IOperationBasiqueService
    {

        private ILog _log;

        public OperationBasiqueService(ILog log)
        {

            _log = log;
        }

        public double Addition(double a, double b)
        {
            _log.Info("Calcul du prix d'un gousse de Vanille Marque Repère de qualité supérieure (Sans Sel Ajouté) \n");
            return a + b;

        }
        public double Soustraction(double a, double b)
        {
            _log.Info("Soustraction du prix d'un gousse de Vanille Marque Repère de qualité supérieure à mon compte en banque \n");
            return a - b;
        }
        public double Division(double a, double b)
        {
            _log.Info("Division du prix de la gousse de Vanille lors de promotions (jamais) \n");
            return a / b;
        }
        public double Multiplication(double a, double b)
        {
            _log.Info("Calcul du prix d'une gousse de vanille après inflation (*40 chaque année) \n");
            return a * b;
        }
    }
}
