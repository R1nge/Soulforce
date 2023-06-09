﻿using Deck;
using Dice;
using Energy;
using GameFlow;
using Units;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace Scopes
{
    public class GameScope : LifetimeScope
    {
        [SerializeField] private PlayerUnit player;

        protected override void Configure(IContainerBuilder builder)
        {
            builder.RegisterEntryPoint<GameStateController>().AsSelf();
            builder.RegisterEntryPoint<EnergyController>().AsSelf();
            builder.RegisterEntryPoint<DiceRollController>().AsSelf();
            builder.Register<DeckController>(Lifetime.Singleton).AsSelf();
            builder.RegisterComponent(player);
        }
    }
}