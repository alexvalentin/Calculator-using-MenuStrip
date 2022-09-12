
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
            this.additionTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.substractionTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.multiplicationTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.divisionTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.moduloTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.firstNumberLabel = new System.Windows.Forms.Label();
            this.secondNumberLabel = new System.Windows.Forms.Label();
            this.finalResultLabel = new System.Windows.Forms.Label();
            this.firstNumberTB = new System.Windows.Forms.TextBox();
            this.secondNumberTB = new System.Windows.Forms.TextBox();
            this.finalResultTB = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.additionTSM,
            this.substractionTSM,
            this.multiplicationTSM,
            this.divisionTSM,
            this.moduloTSM});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // additionTSM
            // 
            this.additionTSM.Name = "additionTSM";
            this.additionTSM.Size = new System.Drawing.Size(105, 24);
            this.additionTSM.Text = "Addition [+]";
            this.additionTSM.Click += new System.EventHandler(this.adunare_Click);
            // 
            // substractionTSM
            // 
            this.substractionTSM.Name = "substractionTSM";
            this.substractionTSM.Size = new System.Drawing.Size(125, 24);
            this.substractionTSM.Text = "Substraction [-]";
            this.substractionTSM.Click += new System.EventHandler(this.scadere_Click);
            // 
            // multiplicationTSM
            // 
            this.multiplicationTSM.Name = "multiplicationTSM";
            this.multiplicationTSM.Size = new System.Drawing.Size(135, 24);
            this.multiplicationTSM.Text = "Multiplication [*]";
            this.multiplicationTSM.Click += new System.EventHandler(this.inmultire_Click);
            // 
            // divisionTSM
            // 
            this.divisionTSM.Name = "divisionTSM";
            this.divisionTSM.Size = new System.Drawing.Size(96, 24);
            this.divisionTSM.Text = "Division [/]";
            this.divisionTSM.Click += new System.EventHandler(this.divizare_Click);
            // 
            // moduloTSM
            // 
            this.moduloTSM.Name = "moduloTSM";
            this.moduloTSM.Size = new System.Drawing.Size(101, 24);
            this.moduloTSM.Text = "Modulo [%]";
            this.moduloTSM.Click += new System.EventHandler(this.modulo_Click);
            // 
            // firstNumberLabel
            // 
            this.firstNumberLabel.AutoSize = true;
            this.firstNumberLabel.Location = new System.Drawing.Point(66, 103);
            this.firstNumberLabel.Name = "firstNumberLabel";
            this.firstNumberLabel.Size = new System.Drawing.Size(91, 20);
            this.firstNumberLabel.TabIndex = 1;
            this.firstNumberLabel.Text = "First number";
            // 
            // secondNumberLabel
            // 
            this.secondNumberLabel.AutoSize = true;
            this.secondNumberLabel.Location = new System.Drawing.Point(66, 172);
            this.secondNumberLabel.Name = "secondNumberLabel";
            this.secondNumberLabel.Size = new System.Drawing.Size(113, 20);
            this.secondNumberLabel.TabIndex = 2;
            this.secondNumberLabel.Text = "Second number";
            // 
            // finalResultLabel
            // 
            this.finalResultLabel.AutoSize = true;
            this.finalResultLabel.Location = new System.Drawing.Point(427, 132);
            this.finalResultLabel.Name = "finalResultLabel";
            this.finalResultLabel.Size = new System.Drawing.Size(80, 20);
            this.finalResultLabel.TabIndex = 3;
            this.finalResultLabel.Text = "Final result";
            // 
            // firstNumberTB
            // 
            this.firstNumberTB.Location = new System.Drawing.Point(187, 103);
            this.firstNumberTB.Name = "firstNumberTB";
            this.firstNumberTB.Size = new System.Drawing.Size(125, 27);
            this.firstNumberTB.TabIndex = 4;
            // 
            // secondNumberTB
            // 
            this.secondNumberTB.Location = new System.Drawing.Point(187, 172);
            this.secondNumberTB.Name = "secondNumberTB";
            this.secondNumberTB.Size = new System.Drawing.Size(125, 27);
            this.secondNumberTB.TabIndex = 5;
            // 
            // finalResultTB
            // 
            this.finalResultTB.Location = new System.Drawing.Point(529, 129);
            this.finalResultTB.Name = "finalResultTB";
            this.finalResultTB.ReadOnly = true;
            this.finalResultTB.Size = new System.Drawing.Size(125, 27);
            this.finalResultTB.TabIndex = 6;
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.clearButton.Location = new System.Drawing.Point(537, 210);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(94, 29);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.finalResultTB);
            this.Controls.Add(this.secondNumberTB);
            this.Controls.Add(this.firstNumberTB);
            this.Controls.Add(this.finalResultLabel);
            this.Controls.Add(this.secondNumberLabel);
            this.Controls.Add(this.firstNumberLabel);
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
        private System.Windows.Forms.ToolStripMenuItem additionTSM;
        
        private System.Windows.Forms.ToolStripMenuItem substractionTSM;
        private System.Windows.Forms.ToolStripMenuItem multiplicationTSM;
        private System.Windows.Forms.ToolStripMenuItem divisionTSM;
        private System.Windows.Forms.ToolStripMenuItem moduloTSM;
        private System.Windows.Forms.Label firstNumberLabel;
        private System.Windows.Forms.Label secondNumberLabel;
        private System.Windows.Forms.Label finalResultLabel;
        private System.Windows.Forms.TextBox firstNumberTB;
        private System.Windows.Forms.TextBox secondNumberTB;
        private System.Windows.Forms.TextBox finalResultTB;
        private System.Windows.Forms.Button clearButton;
    }
}

