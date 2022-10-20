using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interface
{
    public interface IServiceManager
    {
        IOperationBasiqueService OperationBasiqueService { get; }   

        IOperationService OperationService { get; }

        IHeureDecalageService HeureDecalageService { get;  }
    }
}
