using Microsoft.AspNetCore.Mvc;
using Services.Interface;


namespace Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HeureController : ControllerBase
    {
        private IServiceManager _serviceManager;

        public HeureController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }
        [HttpGet("paris")]
        public ActionResult<string> GetHeureParis()
        {
            //          return Ok(_services.Addition(doubles));
            return Ok("En France, il est actuellement : " + _serviceManager.HeureDecalageService.HeureParis() + " \n\n(Regarde l'heure en bas à droite de ton écran au lieu de faire des requêtes HTTP...)");

        }
        [HttpGet("bresil")]
        public ActionResult<string> GetHeureBresil()     //Requete HTTP appliquant le fuseau horaire du Bresil
        {
            //          return Ok(_services.Addition(doubles));
            return Ok("Au Brésil, il est actuellement : " + _serviceManager.HeureDecalageService.HeureBresil() + " \n\n(La coupe du monde au Brésil est déja passée ...)");

        }
        [HttpGet("japon")]
        public ActionResult<string> GetHeureJapon()
        {
            //          return Ok(_services.Addition(doubles));
            return Ok("Au Japon, il est actuellement : " + _serviceManager.HeureDecalageService.HeureJapon() + " \n\n(Il est pas un peu tard pour regarder Naruto ?)");

        }
        [HttpGet("custom")]
        public ActionResult<string> GetHeureCustom(int heureDecalage)    // Permet d'avoir une requete avec Valeur (Pour ne pas avoir que des requetes sans paramètres)
        {
            //          return Ok(_services.Addition(doubles));
            return Ok("Au pays des rêves,(par rapport à l'heure en France) il est actuellement : " + _serviceManager.HeureDecalageService.HeureCustom(heureDecalage) + " \n\n(Il est presque l'heure de récolter des gousses de Vanille !)");

        }


    }
}
