using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GameHelperLibrary;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace Helicopter_Hysteria.States
{
    public abstract partial class BaseGameState : GameState
    {
        protected Game1 gameRef;
        protected ContentManager content;

        public BaseGameState(Game game, GameStateManager manager)
            : base(game, manager)
        {
            gameRef = (Game1)game;
        }

        protected override void LoadContent()
        {
            base.LoadContent();

            content = gameRef.Content;
        }

        protected void SwitchState(GameState targetState)
        {
            StateManager.TargetState = targetState;
            IsExiting = true;
        }
    }
}
