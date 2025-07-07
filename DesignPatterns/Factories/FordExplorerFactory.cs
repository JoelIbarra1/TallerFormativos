using DesignPatterns.Factories;
using DesignPatterns.ModelBuilders;
using DesignPatterns.Models;

namespace DisignPatterns.Factories
{
    public class FordExplorerFactory : CarFactory
    {
        public override Vehicle Create()
        {

            return new CarModelBuilder()
                .setModel("Explorer")
                .Build();
        }
    }
}