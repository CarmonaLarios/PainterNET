namespace AcesCEM.Forms
{
    partial class frmEdicaoCroqui
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEdicaoCroqui));
            this.pnlDesenhoPrincipal = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlDesenhoPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDesenhoPrincipal
            // 
            this.pnlDesenhoPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDesenhoPrincipal.AutoScroll = true;
            this.pnlDesenhoPrincipal.AutoSize = true;
            this.pnlDesenhoPrincipal.BackColor = System.Drawing.Color.LightGray;
            this.pnlDesenhoPrincipal.Controls.Add(this.pictureBox1);
            this.pnlDesenhoPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnlDesenhoPrincipal.Margin = new System.Windows.Forms.Padding(2);
            this.pnlDesenhoPrincipal.Name = "pnlDesenhoPrincipal";
            this.pnlDesenhoPrincipal.Size = new System.Drawing.Size(881, 545);
            this.pnlDesenhoPrincipal.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(620, 545);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.SizeChanged += new System.EventHandler(this.pictureBox1_SizeChanged);
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint_1);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter_1);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // frmEdicaoCroqui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(882, 548);
            this.Controls.Add(this.pnlDesenhoPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEdicaoCroqui";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Edição desenho";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEdicaoCroqui_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmEdicaoCroqui_FormClosed);
            this.Load += new System.EventHandler(this.frmEdicaoCroqui_Load);
            this.Shown += new System.EventHandler(this.frmEdicaoCroqui_Shown);
            this.ResizeBegin += new System.EventHandler(this.frmEdicaoCroqui_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.frmEdicaoCroqui_ResizeEnd);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmEdicaoCroqui_KeyUp);
            this.pnlDesenhoPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlDesenhoPrincipal;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}