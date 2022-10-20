using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Services.Interface
{
    public interface IHeureDecalageService
    {
        public string HeureParis();

        public string HeureBresil();

        public string HeureJapon();

        public string HeureCustom(int heureDecalage);

    }
}
