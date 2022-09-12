
namespace Calculator___MenuStrip
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adunare = new System.Windows.Forms.ToolStripMenuItem();
            this.scadere = new System.Windows.Forms.ToolStripMenuItem();
            this.inmultire = new System.Windows.Forms.ToolStripMenuItem();
            this.divizare = new System.Windows.Forms.ToolStripMenuItem();
            this.modulo = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nr1 = new System.Windows.Forms.TextBox();
            this.nr2 = new System.Windows.Forms.TextBox();
            this.rezultat = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adunare,
            this.scadere,
            this.inmultire,
            this.divizare,
            this.modulo});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // adunare
            // 
            this.adunare.Name = "adunare";
            this.adunare.Size = new System.Drawing.Size(99, 24);
            this.adunare.Text = "Adunare[+]";
            this.adunare.Click += new System.EventHandler(this.adunare_Click);
            // 
            // scadere
            // 
            this.scadere.Name = "scadere";
            this.scadere.Size = new System.Drawing.Size(92, 24);
            this.scadere.Text = "Scadere[-]";
            this.scadere.Click += new System.EventHandler(this.scadere_Click);
            // 
            // inmultire
            // 
            this.inmultire.Name = "inmultire";
            this.inmultire.Size = new System.Drawing.Size(98, 24);
            this.inmultire.Text = "Inmultire[*]";
            this.inmultire.Click += new System.EventHandler(this.inmultire_Click);
            // 
            // divizare
            // 
            this.divizare.Name = "divizare";
            this.divizare.Size = new System.Drawing.Size(93, 24);
            this.divizare.Text = "Divizare[/]";
            this.divizare.Click += new System.EventHandler(this.divizare_Click);
            // 
            // modulo
            // 
            this.modulo.Name = "modulo";
            this.modulo.Size = new System.Drawing.Size(97, 24);
            this.modulo.Text = "Modulo[%]";
            this.modulo.Click += new System.EventHandler(this.modulo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Primul numar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Al doilea numar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(427, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Rezultat";
            // 
            // nr1
            // 
            this.nr1.Location = new System.Drawing.Point(187, 103);
            this.nr1.Name = "nr1";
            this.nr1.Size = new System.Drawing.Size(125, 27);
            this.nr1.TabIndex = 4;
            // 
            // nr2
            // 
            this.nr2.Location = new System.Drawing.Point(187, 172);
            this.nr2.Name = "nr2";
            this.nr2.Size = new System.Drawing.Size(125, 27);
            this.nr2.TabIndex = 5;
            // 
            // rezultat
            // 
            this.rezultat.Location = new System.Drawing.Point(499, 129);
            this.rezultat.Name = "rezultat";
            this.rezultat.ReadOnly = true;
            this.rezultat.Size = new System.Drawing.Size(125, 27);
            this.rezultat.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rezultat);
            this.Controls.Add(this.nr2);
            this.Controls.Add(this.nr1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Calculator using MenuStrip";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adunare;
        
        private System.Windows.Forms.ToolStripMenuItem scadere;
        private System.Windows.Forms.ToolStripMenuItem inmultire;
        private System.Windows.Forms.ToolStripMenuItem divizare;
        private System.Windows.Forms.ToolStripMenuItem modulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nr1;
        private System.Windows.Forms.TextBox nr2;
        private System.Windows.Forms.TextBox rezultat;
    }
}

