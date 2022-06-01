using DependencyInjectionDemoProject.Interface;

namespace DependencyInjectionDemoProject.BusinessDomain
{
    public class Dog : IMakeSound<Dog>
    {
        public string makeSound()
        {
            return "woof";
        }
    }
}
