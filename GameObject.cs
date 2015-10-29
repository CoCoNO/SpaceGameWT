using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


namespace SpaceGame1
{
    class GameObject
    {
        private Vector2 position; //maybe protected

        public Vector2 Position
        {
            get { return position; }
            set {position = value; }
        }
    
        public GameObject(Vector2 valPos)
        {
            position = valPos;
        }
    }
}
