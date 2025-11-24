using System.Numerics;
using System.Security.Policy;
using System.Windows.Forms;

namespace RogueLike1
{
    public partial class RogueLike : Form
    {
        public static List<Player> players = new List<Player>();
        public static List<Enemy> enemies = new List<Enemy>();
        public static List<Bullet> bullets = new List<Bullet>();
        public static List<Rectangle> rectangles = new List<Rectangle>();
        public int mouseX, mouseY, lastMouseX, lastMouseY, playerX, playerY, xVel = 0, yVel = 0, bounceLimit = 0, bulletCount = 1, tarX = 0, tarY = 0;

        public RogueLike()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Player player = new Player(panel1.Width, panel1.Height);
            panel1.Controls.Add(player);
            players.Add(player);

            Enemy enemy = new Enemy(panel1.Width, panel1.Height);
            panel1.Controls.Add(enemy);
            enemies.Add(enemy);

            // Initialize labels
            label1.Text = "Mouse coordinates: " + mouseX + ", " + mouseY;
            label2.Text = "Player coordinates: " + playerX + ", " + playerY;
            label3.Text = "Panel clicked at: " + mouseX + ", " + mouseY;
            label4.Text = "Object count: " + panel1.Controls.OfType<Button>().Count().ToString();
            label5.Text = "Velocity: " + xVel + ", " + yVel;
            label6.Text = "Bounce limit: " + bounceLimit;
            label7.Text = "Enemy Count: " + Convert.ToString(enemies.Count);
            label8.Text = "Bullet Count: " + bulletCount;
            label9.Text = "Player-mouse distance: " + (mouseX - playerX) + ", " + (mouseY - playerY);
            label10.Text = "Bullet Count: ";
            label11.Text = "Y.Abs divided by 20: ";
        }

        private void btnAddEnemy_Click(object sender, EventArgs e)
        {
            Enemy enemy = new Enemy(this.Width, this.Height);
            enemy.SetLocation(this.Width, this.Height, enemies);
            enemies.Add(enemy);
            panel1.Controls.Add(enemy);

            label4.Text = "Object count: " + panel1.Controls.OfType<Button>().Count().ToString();
            label7.Text = "Enemy Count: " + Convert.ToString(enemies.Count);
        }

        private void Update_Tick(object sender, EventArgs e)
        {
            mouseX = this.PointToClient(MousePosition).X;
            mouseY = this.PointToClient(MousePosition).Y;
            players[0].GetLocation(out playerX, out playerY);

            label1.Text = "Mouse coordinates: " + mouseX + ", " + mouseY;
            label2.Text = "Player coordinates: " + playerX + ", " + playerY;
            label5.Text = "Velocity: " + xVel + ", " + yVel;
            label9.Text = "Player-mouse distance: " + (mouseX - playerX) + ", " + (mouseY - playerY);
            try
            {
                label11.Text = "Bullet speed (divided by Y.Abs): " + (mouseX - playerX) / 50 + ", " + (mouseY - playerY) / 50;
            }
            catch (Exception ex)
            {
                bulletHistory.Items.Insert(0, ex);
            }

            foreach (Bullet bullet in panel1.Controls.OfType<Bullet>())
            {
                bullets.Add(bullet);
                bullet.BulletMove(panel1.Width, panel1.Height, panel1, bulletHistory);

                foreach (Enemy enemy in enemies) // Sample: 2 enemies - continuous checking
                {
                    if (bullet.Bounds.IntersectsWith(enemy.Bounds)) // If bullet collides with any enemy in the list
                    {
                        enemy.ReduceHealth(); // Reduce health of that enemy
                        // panel1.Controls.Remove(bullet); // Remove bullet upon collision
                        // bullet.EnemyCollision(enemy, panel1);
                        bullet.Dispose();
                        panel1.Controls.Remove(bullet);

                        if (enemy.health <= 0) // If the health of any enemy in the list falls to 0 or below
                        {
                            panel1.Controls.Remove(enemy); // Remove the enemy from the panel, not yet from the list
                            enemies.Remove(enemy); // Remove the enemy from the list
                            label4.Text = "Object count: " + panel1.Controls.OfType<Button>().Count().ToString();
                            label7.Text = "Enemy Count: " + Convert.ToString(enemies.Count); // Update enemy count label
                            break; // Breaks the inner foreach loop so it doesn't try to check for 2 enemies, when one has already been removed
                        }
                    }
                }
            }

            foreach (Enemy enemy in enemies)
            {
                enemy.EnemyMove();

                if (enemy.Location.X > panel1.Width || enemy.Location.X < -enemy.Width || enemy.Location.Y > panel1.Height || enemy.Location.Y < -enemy.Height)
                {
                    enemy.Dispose();
                    enemies.Remove(enemy);
                    this.Controls.Remove(enemy);
                    label4.Text = "Object count: " + panel1.Controls.OfType<Button>().Count().ToString();
                    label7.Text = "Enemy Count: " + Convert.ToString(enemies.Count);
                    break;
                }
            }

            foreach (Player player in players)
            {
                switch (e) {
                    
                }
            }
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            lastMouseX = mouseX;
            lastMouseY = mouseY;

            label3.Text = "Panel clicked at: " + mouseX + ", " + mouseY;

            foreach (Player player in players)
            {
                for (int i = 0; i < bulletCount; i++)
                {
                    // Method to assign velocity for each bullet based on xVel, yVel values
                    player.AssignVelocity(xVel, yVel);
                    player.CalculateTarget(mouseX, mouseY);
                    player.ShootBullet(playerX + 25, playerY + 25, panel1, bounceLimit);

                    if (bulletHistory.Items.Count > 50)
                    {
                        bulletHistory.Items.Remove(49);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            xVel++;
        }

        private void btnAddY_Click(object sender, EventArgs e)
        {
            yVel++;
        }

        private void btnSubtractX_Click(object sender, EventArgs e)
        {
            xVel--;
        }

        private void btnSubtractY_Click(object sender, EventArgs e)
        {
            yVel--;
        }

        private void btnBounceLimitAdd_Click(object sender, EventArgs e)
        {
            bounceLimit++;
            label6.Text = "Bounce limit: " + bounceLimit;
        }

        private void btnBounceLimitSubtract_Click(object sender, EventArgs e)
        {
            bounceLimit--;
            label6.Text = "Bounce limit: " + bounceLimit;
        }

        private void btnBulletCount_Click(object sender, EventArgs e)
        {
            bulletCount++;
            label8.Text = "Bullet Count: " + bulletCount;
        }

        private void btnBulletCountMinus_Click(object sender, EventArgs e)
        {
            bulletCount--;
            label8.Text = "Bullet Count: " + bulletCount;
        }

        private void btnRemoveEnemies_Click(object sender, EventArgs e)
        {
            for (int i = enemies.Count - 1; i > -1; i--)
            {
                enemies[i].Dispose();
                panel1.Controls.Remove(enemies[i]);
                enemies.Remove(enemies[i]);
            }
            label7.Text = "Enemy Count: " + enemies.Count;
            label4.Text = "Object count: " + panel1.Controls.OfType<Button>().Count().ToString();
        }

        private void btnRemoveBullets_Click(object sender, EventArgs e)
        {
            for (int i = bullets.Count - 1; i > -1; i--)
            {
                bullets[i].Dispose();
                panel1.Controls.Remove(bullets[i]);
                bullets.Remove(bullets[i]);
            }
            label10.Text = "Bullet Count: " + panel1.Controls.OfType<Bullet>().Count().ToString();
        }

        private void button1_Click_1(object sender, EventArgs e) // Relocate player
        {
            foreach (var player in players)
            {
                player.Relocate(lastMouseX, lastMouseY);
            }
        }
    }
}
