namespace PeepoClicker
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.panelWindowTitle = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            this.siticoneControlBox1 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.CloseBox = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.sliderCPS = new Siticone.Desktop.UI.WinForms.SiticoneTrackBar();
            this.lbCPS = new System.Windows.Forms.Label();
            this.LeftClicker = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.enabledBox = new Siticone.UI.WinForms.SiticoneCheckBox();
            this.Random = new System.Windows.Forms.Timer(this.components);
            this.rbCPS = new System.Windows.Forms.Label();
            this.rightCPS = new Siticone.UI.WinForms.SiticoneTrackBar();
            this.RightClicker = new System.Windows.Forms.Timer(this.components);
            this.panelWindowTitle.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelWindowTitle
            // 
            this.panelWindowTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.panelWindowTitle.Controls.Add(this.Title);
            this.panelWindowTitle.Controls.Add(this.siticoneControlBox1);
            this.panelWindowTitle.Controls.Add(this.CloseBox);
            this.panelWindowTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelWindowTitle.Location = new System.Drawing.Point(0, 0);
            this.panelWindowTitle.Name = "panelWindowTitle";
            this.panelWindowTitle.Size = new System.Drawing.Size(800, 45);
            this.panelWindowTitle.TabIndex = 0;
            this.panelWindowTitle.Paint += new System.Windows.Forms.PaintEventHandler(this.panelWindowTitle_Paint_1);
            this.panelWindowTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelWindowTitle_MouseDown_1);
            this.panelWindowTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelWindowTitle_MouseMove);
            this.panelWindowTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelWindowTitle_MouseUp);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Cursor = System.Windows.Forms.Cursors.Default;
            this.Title.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Title.Location = new System.Drawing.Point(22, 18);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(147, 15);
            this.Title.TabIndex = 3;
            this.Title.Text = "PEEPOCLICKER - 1.0.0";
            this.Title.Click += new System.EventHandler(this.label1_Click);
            // 
            // siticoneControlBox1
            // 
            this.siticoneControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox1.ControlBoxType = Siticone.Desktop.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.siticoneControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.siticoneControlBox1.HoverState.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox1.Location = new System.Drawing.Point(686, 0);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.Size = new System.Drawing.Size(59, 45);
            this.siticoneControlBox1.TabIndex = 2;
            // 
            // CloseBox
            // 
            this.CloseBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.CloseBox.ControlBoxStyle = Siticone.Desktop.UI.WinForms.Enums.ControlBoxStyle.Custom;
            this.CloseBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.CloseBox.HoverState.FillColor = System.Drawing.Color.Red;
            this.CloseBox.HoverState.Parent = this.CloseBox;
            this.CloseBox.IconColor = System.Drawing.Color.White;
            this.CloseBox.Location = new System.Drawing.Point(741, 0);
            this.CloseBox.Name = "CloseBox";
            this.CloseBox.ShadowDecoration.Parent = this.CloseBox;
            this.CloseBox.Size = new System.Drawing.Size(59, 45);
            this.CloseBox.TabIndex = 1;
            // 
            // sliderCPS
            // 
            this.sliderCPS.HoverState.Parent = this.sliderCPS;
            this.sliderCPS.Location = new System.Drawing.Point(445, 141);
            this.sliderCPS.Maximum = 20;
            this.sliderCPS.Minimum = 1;
            this.sliderCPS.Name = "sliderCPS";
            this.sliderCPS.Size = new System.Drawing.Size(300, 23);
            this.sliderCPS.TabIndex = 1;
            this.sliderCPS.ThumbColor = System.Drawing.SystemColors.ActiveCaption;
            this.sliderCPS.Value = 20;
            this.sliderCPS.Scroll += new System.Windows.Forms.ScrollEventHandler(this.sliderCPS_Scroll);
            // 
            // lbCPS
            // 
            this.lbCPS.AutoSize = true;
            this.lbCPS.ForeColor = System.Drawing.Color.Snow;
            this.lbCPS.Location = new System.Drawing.Point(442, 112);
            this.lbCPS.Name = "lbCPS";
            this.lbCPS.Size = new System.Drawing.Size(59, 13);
            this.lbCPS.TabIndex = 2;
            this.lbCPS.Text = "LMB CPS: ";
            this.lbCPS.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // LeftClicker
            // 
            this.LeftClicker.Enabled = true;
            this.LeftClicker.Tick += new System.EventHandler(this.LeftClicker_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.panel1.Controls.Add(this.enabledBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 405);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 45);
            this.panel1.TabIndex = 3;
            // 
            // enabledBox
            // 
            this.enabledBox.AutoSize = true;
            this.enabledBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.enabledBox.CheckedState.BorderRadius = 2;
            this.enabledBox.CheckedState.BorderThickness = 0;
            this.enabledBox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.enabledBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.enabledBox.Location = new System.Drawing.Point(12, 16);
            this.enabledBox.Name = "enabledBox";
            this.enabledBox.Size = new System.Drawing.Size(65, 17);
            this.enabledBox.TabIndex = 4;
            this.enabledBox.Text = "Enabled";
            this.enabledBox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.enabledBox.UncheckedState.BorderRadius = 2;
            this.enabledBox.UncheckedState.BorderThickness = 0;
            this.enabledBox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.enabledBox.UseVisualStyleBackColor = true;
            // 
            // Random
            // 
            this.Random.Enabled = true;
            this.Random.Tick += new System.EventHandler(this.Random_Tick);
            // 
            // rbCPS
            // 
            this.rbCPS.AutoSize = true;
            this.rbCPS.ForeColor = System.Drawing.Color.Snow;
            this.rbCPS.Location = new System.Drawing.Point(445, 240);
            this.rbCPS.Name = "rbCPS";
            this.rbCPS.Size = new System.Drawing.Size(58, 13);
            this.rbCPS.TabIndex = 5;
            this.rbCPS.Text = "RMB CPS:";
            // 
            // rightCPS
            // 
            this.rightCPS.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.rightCPS.HoveredState.Parent = this.rightCPS;
            this.rightCPS.Location = new System.Drawing.Point(448, 278);
            this.rightCPS.Maximum = 20;
            this.rightCPS.Minimum = 1;
            this.rightCPS.Name = "rightCPS";
            this.rightCPS.Size = new System.Drawing.Size(300, 23);
            this.rightCPS.TabIndex = 6;
            this.rightCPS.ThumbColor = System.Drawing.SystemColors.ActiveCaption;
            this.rightCPS.Value = 20;
            this.rightCPS.Scroll += new System.Windows.Forms.ScrollEventHandler(this.rightCPS_Scroll);
            // 
            // RightClicker
            // 
            this.RightClicker.Enabled = true;
            this.RightClicker.Tick += new System.EventHandler(this.RightClicker_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rightCPS);
            this.Controls.Add(this.rbCPS);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbCPS);
            this.Controls.Add(this.sliderCPS);
            this.Controls.Add(this.panelWindowTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PeepoClicker";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panelWindowTitle.ResumeLayout(false);
            this.panelWindowTitle.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelWindowTitle;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox CloseBox;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox1;
        private System.Windows.Forms.Label Title;
        private Siticone.Desktop.UI.WinForms.SiticoneTrackBar sliderCPS;
        private System.Windows.Forms.Label lbCPS;
        private System.Windows.Forms.Timer LeftClicker;
        private System.Windows.Forms.Panel panel1;
        private Siticone.UI.WinForms.SiticoneCheckBox enabledBox;
        private System.Windows.Forms.Timer Random;
        private System.Windows.Forms.Label rbCPS;
        private Siticone.UI.WinForms.SiticoneTrackBar rightCPS;
        private System.Windows.Forms.Timer RightClicker;
    }
}

