namespace DependencyInjectionDemoProject.Interface
{
    public interface IMakeSound<T> where T :class
    {
        public string makeSound();
    }
}
