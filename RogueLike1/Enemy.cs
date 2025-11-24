using System;

public class Enemy : Button
{
	Random r = new Random();
	public int health = 10;
    private string enemyType;
    private int width, height, xVel, yVel;
    public Enemy(int formWidth, int formHeight)
	{
		switch (r.Next(0, 11))
		{
            case 3:
                this.health = 100;
                this.Size = new Size(250, 250);
                this.width = 250;
                this.height = 250;
                this.BackColor = Color.Orange;
                this.Location = new Point(r.Next(0, formWidth - 250), r.Next(0, formHeight - 250));
                this.ForeColor = Color.White;
                this.Text = "Boss\nHealth: " + this.health;
                this.enemyType = "Boss";

                switch (r.Next(0, 5))
                {
                    case 3:
                        this.health = 500;
                        this.Size = new Size(500, 500);
                        this.width = 500;
                        this.height = 500;
                        this.BackColor = Color.Red;
                        // this.Image = Image.FromFile("C:\\Users\\joseg\\source\\repos\\RogueLike1\\RogueLike1\\pictures\\mothership.jpg");
                        this.Location = new Point(r.Next(0, formWidth - 500), r.Next(0, formHeight - 500));
                        this.ForeColor = Color.White;
                        this.Text = "Superboss\nHealth: " + this.health;
                        this.enemyType = "Superboss";
                        break;
                }
                break;
            default:
                this.Size = new Size(100, 100);
                this.width = 100;
                this.height = 100;
                this.BackColor = Color.Purple;
                this.Location = new Point(r.Next(0, formWidth - 100), r.Next(0, formHeight - 100));
                this.ForeColor = Color.White;
                this.Text = "Enemy\nHealth: " + this.health;
                this.enemyType = "Enemy";
                break;
        }
        while (this.xVel == 0 || this.yVel == 0)
        {
            this.xVel = r.Next(-3, 4); // Random enemy movement
            this.yVel = r.Next(-3, 4);
        }
    }

    
	public void SetLocation(int formWidth, int formHeight, List<Enemy> enemyList)
	{
        switch (this.enemyType)
        {
            case "Enemy":
                this.Location = new Point(r.Next(0, formWidth - this.width), r.Next(0, formHeight - this.height));
                break;
            case "Boss":
                this.Location = new Point(r.Next(0, formWidth - this.width), r.Next(0, formHeight - this.height));
                break;
            case "Superboss":
                this.Location = new Point(r.Next(0, formWidth - this.width), r.Next(0, formHeight - this.height));
                break;
            default:
                break;
        }
        this.Text += "\n" + Convert.ToString(enemyList.Count);
    }
    
	public void ReduceHealth()
	{
		this.health -= 1;

        if (this.BackColor == Color.Red)
        {
            this.Text = "Superboss\nHealth: " + this.health;
        }
        else if (this.BackColor == Color.Orange)
        {
            this.Text = "Boss\nHealth: " + this.health;
        }
        else
            this.Text = "Enemy\nHealth: " + this.health;
    }
    
    public void EnemyMove()
    {
        this.Location = new Point(this.Location.X + xVel, this.Location.Y + yVel);
    }
}
