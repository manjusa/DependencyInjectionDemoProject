using DependencyInjectionDemoProject.Interface;

namespace DependencyInjectionDemoProject.BusinessDomain
{
    public class Duck : IMakeSound<Duck>
    {
        public string makeSound()
        {
            return "quack";
        }
    }
}
