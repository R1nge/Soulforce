using Dice;
using TurnFlow;
using VContainer;
using VContainer.Unity;

namespace Scopes
{
    public class GameScope : LifetimeScope
    {
        protected override void Configure(IContainerBuilder builder)
        {
            builder.Register<TurnController>(Lifetime.Singleton);
            builder.RegisterEntryPoint<DiceRollController>().AsSelf();
        }
    }
}