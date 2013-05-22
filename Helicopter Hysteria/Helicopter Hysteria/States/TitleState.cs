using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using GameHelperLibrary;

namespace Helicopter_Hysteria.States
{
    public class TitleState : BaseGameState
    {
        Button testChangeStateButton;
        Button testQuitButton;

        public TitleState(Game game, GameStateManager manager)
            : base(game, manager)
        {
        }

        protected override void LoadContent()
        {
            base.LoadContent();

            // Insert content.load stuff here

            // How to create a button.

            // Step 1: initialize the button 
            // Parameter 1: Point that represents the location of the button (new Point(10, 0))
            // Parameter 2: the width of the button (150)
            // Parameter 3: the height of the button (50)
            // Parameter 4: the state that contains the button... (this)
            testChangeStateButton = new Button(new Point(10, 0), 150, 50, this);

            // Step 2: name the button
            testChangeStateButton.Name = "btnTest";

            // Step 3: make a function that happens when the button is clicked
            // This is the syntax.  HappensWhenTheButtonIsClicked is actually 
            // a function, but when assigning events, you don't include parenthesis
            testChangeStateButton.OnClick += HappensWhenTheButtonIsClicked;

            testQuitButton = new Button(new Point(10, testChangeStateButton.Bounds.Y + testChangeStateButton.Bounds.Height + 10),
                150, 50, this);
            testQuitButton.Name = "btnQuit";
            testQuitButton.OnClick += HappensWhenTheButtonIsClicked;
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

            // Insert update code here
            testChangeStateButton.Update(gameTime);
            testQuitButton.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            var spriteBatch = gameRef.spriteBatch;

            spriteBatch.Begin();
            {
                // Insert draw code here
                testChangeStateButton.Draw(spriteBatch, gameTime);
                testQuitButton.Draw(spriteBatch, gameTime);
            }
            spriteBatch.End();

            base.Draw(gameTime);
        }

        /// <summary>
        /// This method is called when a button is clicked... As long as you assign it
        /// after the += operator
        /// </summary>
        /// <param name="sender">The button that is clicked</param>
        /// <param name="e">Leave null for now</param>
        private void HappensWhenTheButtonIsClicked(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            if (btn.Name == "btnTest")
                SwitchState(new GameplayState(gameRef, StateManager));
            else if (btn.Name == "btnQuit")
                gameRef.Exit();
        }
    }
}
