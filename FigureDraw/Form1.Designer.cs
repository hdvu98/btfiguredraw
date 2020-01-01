namespace FigureDraw
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.drawArea = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdbCairo = new System.Windows.Forms.RadioButton();
            this.rdbGDI = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbEllipse = new System.Windows.Forms.RadioButton();
            this.rdbRectangle = new System.Windows.Forms.RadioButton();
            this.rdbLine = new System.Windows.Forms.RadioButton();
            this.effect = new System.Windows.Forms.GroupBox();
            this.radioDefault = new System.Windows.Forms.RadioButton();
            this.rdbHightlight = new System.Windows.Forms.RadioButton();
            this.rdbShadow = new System.Windows.Forms.RadioButton();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.effect.SuspendLayout();
            this.SuspendLayout();
            // 
            // drawArea
            // 
            this.drawArea.BackColor = System.Drawing.SystemColors.Window;
            this.drawArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.drawArea.Location = new System.Drawing.Point(643, 64);
            this.drawArea.Name = "drawArea";
            this.drawArea.Size = new System.Drawing.Size(361, 374);
            this.drawArea.TabIndex = 0;
            this.drawArea.Paint += new System.Windows.Forms.PaintEventHandler(this.drawArea_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "GDI+ Graphics";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(143, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(494, 426);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(643, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(361, 46);
            this.panel2.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdbCairo);
            this.groupBox3.Controls.Add(this.rdbGDI);
            this.groupBox3.Location = new System.Drawing.Point(9, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(125, 84);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Graphics";
            // 
            // rdbCairo
            // 
            this.rdbCairo.AutoSize = true;
            this.rdbCairo.Location = new System.Drawing.Point(16, 46);
            this.rdbCairo.Name = "rdbCairo";
            this.rdbCairo.Size = new System.Drawing.Size(49, 17);
            this.rdbCairo.TabIndex = 1;
            this.rdbCairo.Text = "Cairo";
            this.rdbCairo.UseVisualStyleBackColor = true;
            this.rdbCairo.CheckedChanged += new System.EventHandler(this.rdbCairo_CheckedChanged);
            // 
            // rdbGDI
            // 
            this.rdbGDI.AutoSize = true;
            this.rdbGDI.Checked = true;
            this.rdbGDI.Location = new System.Drawing.Point(16, 19);
            this.rdbGDI.Name = "rdbGDI";
            this.rdbGDI.Size = new System.Drawing.Size(64, 17);
            this.rdbGDI.TabIndex = 0;
            this.rdbGDI.TabStop = true;
            this.rdbGDI.Text = "GDIPlus";
            this.rdbGDI.UseVisualStyleBackColor = true;
            this.rdbGDI.CheckedChanged += new System.EventHandler(this.rdbGDI_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbEllipse);
            this.groupBox1.Controls.Add(this.rdbRectangle);
            this.groupBox1.Controls.Add(this.rdbLine);
            this.groupBox1.Location = new System.Drawing.Point(9, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(125, 120);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shapes";
            // 
            // rdbEllipse
            // 
            this.rdbEllipse.AutoSize = true;
            this.rdbEllipse.Location = new System.Drawing.Point(16, 89);
            this.rdbEllipse.Name = "rdbEllipse";
            this.rdbEllipse.Size = new System.Drawing.Size(55, 17);
            this.rdbEllipse.TabIndex = 2;
            this.rdbEllipse.Text = "Ellipse";
            this.rdbEllipse.UseVisualStyleBackColor = true;
            this.rdbEllipse.CheckedChanged += new System.EventHandler(this.rdbEllipse_CheckedChanged);
            // 
            // rdbRectangle
            // 
            this.rdbRectangle.AutoSize = true;
            this.rdbRectangle.Location = new System.Drawing.Point(16, 57);
            this.rdbRectangle.Name = "rdbRectangle";
            this.rdbRectangle.Size = new System.Drawing.Size(74, 17);
            this.rdbRectangle.TabIndex = 1;
            this.rdbRectangle.Text = "Rectangle";
            this.rdbRectangle.UseVisualStyleBackColor = true;
            this.rdbRectangle.CheckedChanged += new System.EventHandler(this.rdbRectangle_CheckedChanged);
            // 
            // rdbLine
            // 
            this.rdbLine.AutoSize = true;
            this.rdbLine.Checked = true;
            this.rdbLine.Location = new System.Drawing.Point(16, 26);
            this.rdbLine.Name = "rdbLine";
            this.rdbLine.Size = new System.Drawing.Size(45, 17);
            this.rdbLine.TabIndex = 0;
            this.rdbLine.TabStop = true;
            this.rdbLine.Text = "Line";
            this.rdbLine.UseVisualStyleBackColor = true;
            this.rdbLine.CheckedChanged += new System.EventHandler(this.rdbLine_CheckedChanged);
            // 
            // effect
            // 
            this.effect.Controls.Add(this.radioDefault);
            this.effect.Controls.Add(this.rdbHightlight);
            this.effect.Controls.Add(this.rdbShadow);
            this.effect.Location = new System.Drawing.Point(9, 228);
            this.effect.Name = "effect";
            this.effect.Size = new System.Drawing.Size(125, 131);
            this.effect.TabIndex = 7;
            this.effect.TabStop = false;
            this.effect.Text = "Effect";
            // 
            // radioDefault
            // 
            this.radioDefault.AutoSize = true;
            this.radioDefault.Checked = true;
            this.radioDefault.Location = new System.Drawing.Point(16, 28);
            this.radioDefault.Name = "radioDefault";
            this.radioDefault.Size = new System.Drawing.Size(59, 17);
            this.radioDefault.TabIndex = 2;
            this.radioDefault.TabStop = true;
            this.radioDefault.Text = "Default";
            this.radioDefault.UseVisualStyleBackColor = true;
            this.radioDefault.CheckedChanged += new System.EventHandler(this.radioDefault_CheckedChanged);
            // 
            // rdbHightlight
            // 
            this.rdbHightlight.AutoSize = true;
            this.rdbHightlight.Location = new System.Drawing.Point(16, 96);
            this.rdbHightlight.Name = "rdbHightlight";
            this.rdbHightlight.Size = new System.Drawing.Size(66, 17);
            this.rdbHightlight.TabIndex = 1;
            this.rdbHightlight.Text = "Highlight";
            this.rdbHightlight.UseVisualStyleBackColor = true;
            this.rdbHightlight.CheckedChanged += new System.EventHandler(this.rdbHightlight_CheckedChanged);
            // 
            // rdbShadow
            // 
            this.rdbShadow.AutoSize = true;
            this.rdbShadow.Location = new System.Drawing.Point(16, 63);
            this.rdbShadow.Name = "rdbShadow";
            this.rdbShadow.Size = new System.Drawing.Size(64, 17);
            this.rdbShadow.TabIndex = 0;
            this.rdbShadow.Text = "Shadow";
            this.rdbShadow.UseVisualStyleBackColor = true;
            this.rdbShadow.CheckedChanged += new System.EventHandler(this.rdbShadow_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 450);
            this.Controls.Add(this.effect);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.drawArea);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.effect.ResumeLayout(false);
            this.effect.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel drawArea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdbCairo;
        private System.Windows.Forms.RadioButton rdbGDI;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbEllipse;
        private System.Windows.Forms.RadioButton rdbRectangle;
        private System.Windows.Forms.RadioButton rdbLine;
        private System.Windows.Forms.GroupBox effect;
        private System.Windows.Forms.RadioButton rdbHightlight;
        private System.Windows.Forms.RadioButton rdbShadow;
        private System.Windows.Forms.RadioButton radioDefault;
    }
}

