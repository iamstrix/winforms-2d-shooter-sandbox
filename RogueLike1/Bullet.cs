﻿using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

public class Bullet : Button
{
    private float thisX, thisY;
    private int xTar, yTar, bounce, bounceLimit;
    public int xVel, yVel, bounceDamp = 1;
    public bool updated = false;

    public Bullet(int playerX, int playerY, Panel panel, int xVel, int yVel, int bounceLimit, int xTarget, int yTarget)
    {
        // Sets spawn location of bullet to player's current location
        this.thisX = playerX;
        this.thisY = playerY;
        this.Size = new Size(20, 20);
        this.BackColor = Color.Blue;
        this.Location = new Point((int)this.thisX, (int)this.thisY);
        panel.Controls.Add(this);
        this.xVel = xVel;
        this.yVel = yVel;
        this.bounceLimit = bounceLimit;
        this.xTar = xTarget;
        this.yTar = yTarget;
    }

    public void BulletMove(int panelWidth, int panelHeight, Panel panel, ListBox listbox)
    {
        this.thisX += (xTar + xVel);
        this.thisY += (yTar + yVel);
        this.Location = new Point((int)this.thisX, (int)this.thisY); // Bullet trajectory with float precision

        if (this.updated == false) // Reports where bullet shot
        {
            listbox.Items.Insert(0, "Shot: " + xTar + ", " + yTar);
            this.updated = true;
        }

        if (this.thisX > panelWidth)
        {
            xTar *= -bounceDamp; 
            this.bounce += 1;
        }
        else if (this.thisX < 0)
        {
            xTar *= -bounceDamp;
            this.bounce += 1;
        }

        if (this.thisY > panelHeight)
        {
            yTar *= -bounceDamp;
            this.bounce += 1;
        }
        else if (this.thisY < 0)
        {
            yTar *= -bounceDamp;
            this.bounce += 1;
        }

        if (bounce > this.bounceLimit)
        {
            panel.Controls.Remove(this);
        }
    }
}
