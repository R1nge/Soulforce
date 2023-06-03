using Deck;
using Dice;
using Energy;
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
            builder.RegisterEntryPoint<EnergyController>().AsSelf();
            builder.RegisterEntryPoint<DiceRollController>().AsSelf();
            builder.Register<DeckController>(Lifetime.Singleton).AsSelf();
        }
    }
}