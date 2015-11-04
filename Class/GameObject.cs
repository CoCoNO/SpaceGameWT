using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


namespace SpaceGame1
{
    abstract class GameObject
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
        public bool checkColition(GameObject otherObject)
        {
            //check if there was a colition
            throw new NotImplementedException();
            return false;//Not implemented so fake

        }
        public virtual void OnLoad()
        {
            //Load some shit
        }
        public virtual void OnColition(GameObject otherObject)
        {
            //What happens when coliding with otherObject
        }
        public virtual void OnUpdate()
        {
            //Update game object
        }
        public virtual void OnDraw()
        {
            //Draw Shit
        }
    }

    class ColisionModel
    {
        //??
    }
}
