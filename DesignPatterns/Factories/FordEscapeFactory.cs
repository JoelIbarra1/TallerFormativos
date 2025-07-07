using DesignPatterns.Factories;
using DesignPatterns.ModelBuilders;
using DesignPatterns.Models;

namespace DisignPatterns.Factories
{
    public class FordEscapeFactory : CarFactory
    {
       public override Vehicle Create()
        {
            
            return new CarModelBuilder()
                .setModel("Escape")
                .Build();
        }
    }
}