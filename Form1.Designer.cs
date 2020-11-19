using System.Threading;

namespace matrix123
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.size4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.size5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.size6ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.size7ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Resume";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Suspend";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(35, 22);
            this.toolStripButton3.Text = "Start";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.size4ToolStripMenuItem,
            this.size5ToolStripMenuItem,
            this.size6ToolStripMenuItem,
            this.size7ToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(40, 22);
            this.toolStripDropDownButton1.Text = "Size";
            // 
            // size4ToolStripMenuItem
            // 
            this.size4ToolStripMenuItem.Name = "size4ToolStripMenuItem";
            this.size4ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.size4ToolStripMenuItem.Text = "size4";
            this.size4ToolStripMenuItem.Click += new System.EventHandler(this.size4ToolStripMenuItem_Click);
            // 
            // size5ToolStripMenuItem
            // 
            this.size5ToolStripMenuItem.Name = "size5ToolStripMenuItem";
            this.size5ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.size5ToolStripMenuItem.Text = "size5";
            this.size5ToolStripMenuItem.Click += new System.EventHandler(this.size5ToolStripMenuItem_Click);
            // 
            // size6ToolStripMenuItem
            // 
            this.size6ToolStripMenuItem.Name = "size6ToolStripMenuItem";
            this.size6ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.size6ToolStripMenuItem.Text = "size6";
            this.size6ToolStripMenuItem.Click += new System.EventHandler(this.size6ToolStripMenuItem_Click);
            // 
            // size7ToolStripMenuItem
            // 
            this.size7ToolStripMenuItem.Name = "size7ToolStripMenuItem";
            this.size7ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.size7ToolStripMenuItem.Text = "size7";
            this.size7ToolStripMenuItem.Click += new System.EventHandler(this.size7ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "MatrixForm1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaint);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem size4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem size5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem size6ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem size7ToolStripMenuItem;
        public Thread CounterThread;
        public bool bThreadStatus;
    }
}

