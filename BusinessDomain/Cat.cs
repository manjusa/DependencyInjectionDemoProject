
using DependencyInjectionDemoProject.Interface;

namespace DependencyInjectionDemoProject.BusinessDomain
{
    public class Cat:IMakeSound<Cat>
    {      

        public string makeSound()
        {
            return "meow";
        }
    }
}
