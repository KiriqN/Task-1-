
namespace Jared_Laubscher_6112_Task_1
{
    partial class Form1
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
            this.PlayerStats = new System.Windows.Forms.Label();
            this.Up = new System.Windows.Forms.Button();
            this.Right = new System.Windows.Forms.Button();
            this.Down = new System.Windows.Forms.Button();
            this.Left = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.field = new System.Windows.Forms.Label();
            this.EnemyStats = new System.Windows.Forms.Label();
            this.Battleinfo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Attack = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // PlayerStats
            // 
            this.PlayerStats.AutoSize = true;
            this.PlayerStats.Location = new System.Drawing.Point(111, 426);
            this.PlayerStats.Name = "PlayerStats";
            this.PlayerStats.Size = new System.Drawing.Size(81, 20);
            this.PlayerStats.TabIndex = 1;
            this.PlayerStats.Text = "PlayerStats";
            // 
            // Up
            // 
            this.Up.Location = new System.Drawing.Point(147, 181);
            this.Up.Name = "Up";
            this.Up.Size = new System.Drawing.Size(94, 29);
            this.Up.TabIndex = 5;
            this.Up.Text = "Up";
            this.Up.UseVisualStyleBackColor = true;
            this.Up.Click += new System.EventHandler(this.Up_Click);
            // 
            // Right
            // 
            this.Right.Location = new System.Drawing.Point(248, 232);
            this.Right.Name = "Right";
            this.Right.Size = new System.Drawing.Size(94, 29);
            this.Right.TabIndex = 6;
            this.Right.Text = "Right";
            this.Right.UseVisualStyleBackColor = true;
            this.Right.Click += new System.EventHandler(this.Right_Click);
            // 
            // Down
            // 
            this.Down.Location = new System.Drawing.Point(147, 280);
            this.Down.Name = "Down";
            this.Down.Size = new System.Drawing.Size(94, 29);
            this.Down.TabIndex = 7;
            this.Down.Text = "Down";
            this.Down.UseVisualStyleBackColor = true;
            this.Down.Click += new System.EventHandler(this.button3_Click);
            // 
            // Left
            // 
            this.Left.Location = new System.Drawing.Point(44, 232);
            this.Left.Name = "Left";
            this.Left.Size = new System.Drawing.Size(94, 29);
            this.Left.TabIndex = 8;
            this.Left.Text = "Left";
            this.Left.UseVisualStyleBackColor = true;
            this.Left.Click += new System.EventHandler(this.Left_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 395);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Player Info:";
            // 
            // field
            // 
            this.field.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.field.Location = new System.Drawing.Point(625, 129);
            this.field.Name = "field";
            this.field.Size = new System.Drawing.Size(355, 273);
            this.field.TabIndex = 3;
            this.field.Text = "this is a test";
            this.field.Click += new System.EventHandler(this.field_Click);
            // 
            // EnemyStats
            // 
            this.EnemyStats.AutoSize = true;
            this.EnemyStats.Location = new System.Drawing.Point(1164, 426);
            this.EnemyStats.Name = "EnemyStats";
            this.EnemyStats.Size = new System.Drawing.Size(86, 20);
            this.EnemyStats.TabIndex = 10;
            this.EnemyStats.Text = "Enemy Info:";
            // 
            // Battleinfo
            // 
            this.Battleinfo.AutoSize = true;
            this.Battleinfo.Location = new System.Drawing.Point(1168, 395);
            this.Battleinfo.Name = "Battleinfo";
            this.Battleinfo.Size = new System.Drawing.Size(81, 20);
            this.Battleinfo.TabIndex = 11;
            this.Battleinfo.Text = "Battle Info:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1169, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Attacking Controls";
            // 
            // Attack
            // 
            this.Attack.Location = new System.Drawing.Point(1188, 257);
            this.Attack.Name = "Attack";
            this.Attack.Size = new System.Drawing.Size(94, 29);
            this.Attack.TabIndex = 13;
            this.Attack.Text = "Attack";
            this.Attack.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1164, 223);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1349, 569);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Attack);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Battleinfo);
            this.Controls.Add(this.EnemyStats);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Left);
            this.Controls.Add(this.Down);
            this.Controls.Add(this.Right);
            this.Controls.Add(this.Up);
            this.Controls.Add(this.field);
            this.Controls.Add(this.PlayerStats);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PlayerStats;
        private System.Windows.Forms.Button Up;
        private System.Windows.Forms.Button Right;
        private System.Windows.Forms.Button Down;
        private System.Windows.Forms.Button Left;
        private System.Windows.Forms.Label field;
        private System.Windows.Forms.Label EnemyStats;
        private System.Windows.Forms.Label Battleinfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Attack;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

