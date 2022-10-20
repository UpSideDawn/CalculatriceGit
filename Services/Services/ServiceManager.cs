using Log.Interface;
using Services.Interface;

namespace Services.Services
{

    public class ServiceManager : IServiceManager
    {
        private readonly Lazy<IOperationService> _lazyOperationService;

        private readonly Lazy<IOperationBasiqueService> _lazyOperationBasiqueService;

        private readonly Lazy<IHeureDecalageService> _lazyHeureDecalageService;

        public ServiceManager(ILog log)
        {
            _lazyOperationBasiqueService = new Lazy<IOperationBasiqueService>(() => new OperationBasiqueService(log));

            _lazyOperationService = new Lazy<IOperationService>(() => new OperationServices(log));

            _lazyHeureDecalageService = new Lazy<IHeureDecalageService>(() => new HeureDecalageService(log));

        }
        public IOperationService OperationService => _lazyOperationService.Value;

        public IOperationBasiqueService OperationBasiqueService => _lazyOperationBasiqueService.Value;

        public IHeureDecalageService HeureDecalageService => _lazyHeureDecalageService.Value;
    }
}
