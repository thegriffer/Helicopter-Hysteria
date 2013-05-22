using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GameHelperLibrary;
using Microsoft.Xna.Framework;

namespace Helicopter_Hysteria.States
{
    public abstract partial class BaseGameState : GameState
    {
        protected Game1 gameRef;

        public BaseGameState(Game game, GameStateManager manager)
            : base(game, manager) { gameRef = (Game1)game; }

        public override void Initialize()
        {
            base.Initialize();
        }

        protected override void LoadContent()
        {
            base.LoadContent();
        }

        public override void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);
        }

        protected void SwitchState(GameState targetState)
        {
            StateManager.TargetState = targetState;
            IsExiting = true;
        }
    }
}
