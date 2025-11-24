﻿using Microsoft.VisualBasic.Devices;
using System;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Threading;

public class Player : Button
{
    static Random r = new Random();

    private int playerX, playerY, bulletXVel, bulletYVel;
    private float xTarget, yTarget;


    public Player(int formWidth, int formHeight)
	{
        this.playerX = (formWidth / 2);
        this.playerY = (formHeight / 2);

        this.Size = new Size(50, 50);
        this.Location = new Point(playerX, playerY);
        this.FlatStyle = FlatStyle.Popup;
        this.BackColor = Color.PaleGoldenrod;
    }

    public void GetLocation(out int x, out int y)
    {
        x = this.Location.X;
        y = this.Location.Y;
    }

    public void Relocate(int mouseX, int mouseY)
    {
        this.playerX = mouseX;
        this.playerY = mouseY;

        this.Location = new Point(this.playerX, this.playerY);
    }
    public void AssignVelocity(int xVel, int yVel)
    {
        // Method to assign velocity to bullets when panel1 is clicked
        // Added variance to bullet trajectory

        // this.bulletXVel = xVel + 0; // Linear shots, for bug testing without spread
        // this.bulletYVel = yVel + 0;

        this.bulletXVel = xVel + r.Next(-3, 4); // Spread shots
        this.bulletYVel = yVel + r.Next(-3, 4);
    }

    public void CalculateTarget(int lastClickedX, int lastClickedY)
    {
        // Calculate distance with float precision
        int dx = lastClickedX - this.playerX;
        int dy = lastClickedY - this.playerY;

        // Calculate the magnitude of the vector
        float magnitude = (float)Math.Sqrt(dx * dx + dy * dy);

        // Normalize the vector and scale by a constant factor
        // Using 50 as the scaling factor to maintain similar behavior
        if (magnitude > 0)
        {
            this.xTarget = (dx / magnitude) * 50;
            this.yTarget = (dy / magnitude) * 50;
        }
        else
        {
            this.xTarget = 0;
            this.yTarget = 0;
        }
    }

    public void VelocityCap()
    {
        // this.xTarget = (lastClickedX - this.playerX) / (Math.Abs(playerY) / 20);
        // this.yTarget = (lastClickedY - this.playerY) / (Math.Abs(playerY) / 20);
    }


    public void ShootBullet(int playerX, int playerY, Panel panel, int bounceLimit)
    {
        // Cast float targets to int for the Bullet constructor
        int intXTarget = (int)xTarget;
        int intYTarget = (int)yTarget;
        Bullet bullet = new Bullet(playerX, playerY, panel, this.bulletXVel, this.bulletYVel, bounceLimit, intXTarget, intYTarget);
    }
}
