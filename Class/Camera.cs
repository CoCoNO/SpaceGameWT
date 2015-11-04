using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
namespace SpaceGame1.Class
{
    class Camera
    {
        Vector2 center;
        Rectangle view;
        float scale;

        public Vector2 Center
        {
            get { return center; }
            set { center = value; }
        }


        public Camera(Vector2 _center, int _width, int _height)
        {

        }
        public Texture2D Render()
        {
            throw new NotImplementedException();
            return null;
        }
    }
}
