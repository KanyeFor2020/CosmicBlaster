﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
namespace BlasterMaster
{
    class ClsPlayerMyBullet
    {
        public class clsMyPlayerBullet : clsPlayerBullet
        {

            // Obj refs and instances
            private System.Drawing.Bitmap bullet;
            private ImageAttributes ImagingAtt = new ImageAttributes();

            public clsMyPlayerBullet(int x, int y) : base(x, y)
            {
                //------------------------------------------------------------------------------------------------------------------
                // Purpose: Class constructor  
                //------------------------------------------------------------------------------------------------------------------

                // Load resource image(s) & remove background and thu a sprite is born 
                bullet = BlasterMaster.Properties.Resources.playerBullet;
                bullet.MakeTransparent(Color.White);
            }

            /*public override void moveBullets(Graphics Destination)
            {
                //------------------------------------------------------------------------------------------------------------------
                // Purpose: Method to move the player's bullets by 16 pixels every frame  
                //------------------------------------------------------------------------------------------------------------------

                // Scroll bullets
                base.setY(base.getY() - 15);
                base.setX(base.getX() + 5);

                // Sync collision rect
                base.setRectX(base.getX() + 2);
                base.setRectY(base.getY());
                base.setRectW(base.getW() - 5);
                base.setRectH(base.getH());

                // call to render
                this.Draw(Destination);
            }
            */
            private void Draw(Graphics Destination)
            {
                //------------------------------------------------------------------------------------------------------------------
                // Purpose: Method to render the player's sprite  
                //------------------------------------------------------------------------------------------------------------------

                // Draw sprite
                Destination.DrawImage(bullet, new Rectangle(base.getX(), base.getY(), base.getW(), base.getH()), 0, 0, base.getW(), base.getH(), GraphicsUnit.Pixel, ImagingAtt);
            }
        }
    }
}