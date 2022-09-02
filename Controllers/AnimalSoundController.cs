using DependencyInjectionDemoProject.BusinessDomain;
using DependencyInjectionDemoProject.Interface;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjectionDemoProject.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class AnimalSoundController : ControllerBase
    {
        private readonly IMakeSound<Cat> _catSound;
        private readonly IMakeSound<Dog> _dogSound;
        private readonly IMakeSound<Duck> _duckSound;

        public AnimalSoundController(IMakeSound<Cat> catSound, IMakeSound<Dog> dogSound, IMakeSound<Duck> duckSound)
        {
            this._catSound = catSound;
            this._dogSound = dogSound;
            this._duckSound = duckSound;
        }


        [HttpGet]
        public string CatMakeNoise()
        {
            
            return _catSound.makeSound();

        }
        [HttpGet]
        public string DogMakeNoise()
        {

            return _dogSound.makeSound();

        }
        [HttpGet]
        public string DuckMakeNoise()
        {

            return _duckSound.makeSound();

        }

    }
}