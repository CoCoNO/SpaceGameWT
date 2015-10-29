using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


namespace SpaceGame1
{
    class DynamicGameObject : GameObject
    {
        private Vector2 velocity;
        private Vector2 acceleration;
        private float mass;


        public Vector2 Acceleration
        {
            get { return acceleration; }
            set { acceleration = value; }
        }

        public Vector2 Velocity
        {
            get { return velocity; }
            set { velocity = value; }
        }

        public float Mass
        {
            get { return mass; }
            set { mass = value; }
        }


        public DynamicGameObject(Vector2 origin, Vector2 valVel ,Vector2 valAcc, float valMass): base(origin)
        {
            velocity = valVel;
            acceleration = valAcc;
            mass = valMass;

        }
    }
}
