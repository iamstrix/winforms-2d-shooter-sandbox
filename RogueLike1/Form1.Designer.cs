namespace RogueLike1
{
    partial class RogueLike
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Update = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            panel1 = new Panel();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            bulletHistory = new ListBox();
            btnRemoveBullets = new Button();
            panel2 = new Panel();
            btnRelocate = new Button();
            btnRemoveEnemies = new Button();
            btnBulletCount = new Button();
            btnBulletCountMinus = new Button();
            btnSubtractY = new Button();
            btnAddY = new Button();
            btnAddX = new Button();
            btnBounceLimitAdd = new Button();
            btnBounceLimitSubtract = new Button();
            btnSubtractX = new Button();
            btnAddEnemy = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // Update
            // 
            Update.Enabled = true;
            Update.Interval = 16;
            Update.Tick += Update_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 11);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Desktop;
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.ForeColor = SystemColors.ButtonFace;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1450, 960);
            panel1.TabIndex = 1;
            panel1.Click += panel1_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(14, 211);
            label11.Name = "label11";
            label11.Size = new Size(60, 20);
            label11.TabIndex = 19;
            label11.Text = "label11";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(14, 191);
            label10.Name = "label10";
            label10.Size = new Size(60, 20);
            label10.TabIndex = 18;
            label10.Text = "label10";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(14, 171);
            label9.Name = "label9";
            label9.Size = new Size(51, 20);
            label9.TabIndex = 17;
            label9.Text = "label9";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(14, 151);
            label8.Name = "label8";
            label8.Size = new Size(51, 20);
            label8.TabIndex = 16;
            label8.Text = "label8";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 131);
            label7.Name = "label7";
            label7.Size = new Size(51, 20);
            label7.TabIndex = 15;
            label7.Text = "label7";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 111);
            label6.Name = "label6";
            label6.Size = new Size(51, 20);
            label6.TabIndex = 12;
            label6.Text = "label6";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 91);
            label5.Name = "label5";
            label5.Size = new Size(51, 20);
            label5.TabIndex = 8;
            label5.Text = "label5";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 71);
            label4.Name = "label4";
            label4.Size = new Size(51, 20);
            label4.TabIndex = 3;
            label4.Text = "label4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 51);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 2;
            label3.Text = "label3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 31);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // bulletHistory
            // 
            bulletHistory.FormattingEnabled = true;
            bulletHistory.Location = new Point(249, 3);
            bulletHistory.Name = "bulletHistory";
            bulletHistory.Size = new Size(178, 964);
            bulletHistory.TabIndex = 15;
            // 
            // btnRemoveBullets
            // 
            btnRemoveBullets.Location = new Point(12, 797);
            btnRemoveBullets.Name = "btnRemoveBullets";
            btnRemoveBullets.Size = new Size(100, 100);
            btnRemoveBullets.TabIndex = 16;
            btnRemoveBullets.Text = "remove all bullets";
            btnRemoveBullets.UseVisualStyleBackColor = true;
            btnRemoveBullets.Click += btnRemoveBullets_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(69, 69, 69);
            panel2.Controls.Add(btnRelocate);
            panel2.Controls.Add(btnRemoveEnemies);
            panel2.Controls.Add(btnRemoveBullets);
            panel2.Controls.Add(btnBulletCount);
            panel2.Controls.Add(bulletHistory);
            panel2.Controls.Add(btnBulletCountMinus);
            panel2.Controls.Add(btnSubtractY);
            panel2.Controls.Add(btnAddY);
            panel2.Controls.Add(btnAddX);
            panel2.Controls.Add(btnBounceLimitAdd);
            panel2.Controls.Add(btnBounceLimitSubtract);
            panel2.Controls.Add(btnSubtractX);
            panel2.Controls.Add(btnAddEnemy);
            panel2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel2.Location = new Point(1449, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(430, 960);
            panel2.TabIndex = 17;
            // 
            // btnRelocate
            // 
            btnRelocate.Location = new Point(126, 797);
            btnRelocate.Name = "btnRelocate";
            btnRelocate.Size = new Size(100, 100);
            btnRelocate.TabIndex = 25;
            btnRelocate.Text = "relocate player to last mouseXY";
            btnRelocate.UseVisualStyleBackColor = true;
            btnRelocate.Click += button1_Click_1;
            // 
            // btnRemoveEnemies
            // 
            btnRemoveEnemies.Location = new Point(126, 332);
            btnRemoveEnemies.Name = "btnRemoveEnemies";
            btnRemoveEnemies.Size = new Size(100, 100);
            btnRemoveEnemies.TabIndex = 20;
            btnRemoveEnemies.Text = "remove Enemies";
            btnRemoveEnemies.UseVisualStyleBackColor = true;
            btnRemoveEnemies.Click += btnRemoveEnemies_Click;
            // 
            // btnBulletCount
            // 
            btnBulletCount.Location = new Point(12, 678);
            btnBulletCount.Name = "btnBulletCount";
            btnBulletCount.Size = new Size(100, 100);
            btnBulletCount.TabIndex = 23;
            btnBulletCount.Text = "bullet count +";
            btnBulletCount.UseVisualStyleBackColor = true;
            btnBulletCount.Click += btnBulletCount_Click;
            // 
            // btnBulletCountMinus
            // 
            btnBulletCountMinus.Location = new Point(126, 678);
            btnBulletCountMinus.Name = "btnBulletCountMinus";
            btnBulletCountMinus.Size = new Size(100, 100);
            btnBulletCountMinus.TabIndex = 24;
            btnBulletCountMinus.Text = "bullet count -";
            btnBulletCountMinus.UseVisualStyleBackColor = true;
            btnBulletCountMinus.Click += btnBulletCountMinus_Click;
            // 
            // btnSubtractY
            // 
            btnSubtractY.Location = new Point(74, 10);
            btnSubtractY.Name = "btnSubtractY";
            btnSubtractY.Size = new Size(100, 100);
            btnSubtractY.TabIndex = 17;
            btnSubtractY.Text = "sub Y, Up";
            btnSubtractY.UseVisualStyleBackColor = true;
            // 
            // btnAddY
            // 
            btnAddY.Location = new Point(74, 210);
            btnAddY.Name = "btnAddY";
            btnAddY.Size = new Size(100, 100);
            btnAddY.TabIndex = 16;
            btnAddY.Text = "add Y, Down";
            btnAddY.UseVisualStyleBackColor = true;
            // 
            // btnAddX
            // 
            btnAddX.Location = new Point(126, 110);
            btnAddX.Name = "btnAddX";
            btnAddX.Size = new Size(100, 100);
            btnAddX.TabIndex = 15;
            btnAddX.Text = "add X, Right";
            btnAddX.UseVisualStyleBackColor = true;
            // 
            // btnBounceLimitAdd
            // 
            btnBounceLimitAdd.Location = new Point(12, 561);
            btnBounceLimitAdd.Name = "btnBounceLimitAdd";
            btnBounceLimitAdd.Size = new Size(100, 100);
            btnBounceLimitAdd.TabIndex = 21;
            btnBounceLimitAdd.Text = "bounce limt +";
            btnBounceLimitAdd.UseVisualStyleBackColor = true;
            btnBounceLimitAdd.Click += btnBounceLimitAdd_Click;
            // 
            // btnBounceLimitSubtract
            // 
            btnBounceLimitSubtract.Location = new Point(126, 561);
            btnBounceLimitSubtract.Name = "btnBounceLimitSubtract";
            btnBounceLimitSubtract.Size = new Size(100, 100);
            btnBounceLimitSubtract.TabIndex = 22;
            btnBounceLimitSubtract.Text = "bounce limit -";
            btnBounceLimitSubtract.UseVisualStyleBackColor = true;
            btnBounceLimitSubtract.Click += btnBounceLimitSubtract_Click;
            // 
            // btnSubtractX
            // 
            btnSubtractX.Location = new Point(20, 110);
            btnSubtractX.Name = "btnSubtractX";
            btnSubtractX.Size = new Size(100, 100);
            btnSubtractX.TabIndex = 18;
            btnSubtractX.Text = "sub X, Left";
            btnSubtractX.UseVisualStyleBackColor = true;
            // 
            // btnAddEnemy
            // 
            btnAddEnemy.Location = new Point(12, 332);
            btnAddEnemy.Name = "btnAddEnemy";
            btnAddEnemy.Size = new Size(100, 100);
            btnAddEnemy.TabIndex = 19;
            btnAddEnemy.Text = "add Enemy";
            btnAddEnemy.UseVisualStyleBackColor = true;
            btnAddEnemy.Click += btnAddEnemy_Click;
            // 
            // RogueLike
            // 
            AccessibleName = "";
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1882, 953);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "RogueLike";
            Text = "RogueLike";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer Update;
        private Label label1;
        private Panel panel1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private ListBox bulletHistory;
        private Button btnRemoveBullets;
        private Label label10;
        private Label label11;
        private Panel panel2;
        private Button btnRemoveEnemies;
        private Button btnBulletCount;
        private Button btnBulletCountMinus;
        private Button btnSubtractY;
        private Button btnAddY;
        private Button btnAddX;
        private Button btnBounceLimitAdd;
        private Button btnBounceLimitSubtract;
        private Button btnSubtractX;
        private Button btnAddEnemy;
        private Button btnRelocate;
    }
}
