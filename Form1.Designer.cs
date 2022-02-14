
namespace dig_sat
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timelabel = new System.Windows.Forms.Label();
            this.secondslabel = new System.Windows.Forms.Label();
            this.datelabel = new System.Windows.Forms.Label();
            this.buttonHR = new System.Windows.Forms.Button();
            this.buttonUS = new System.Windows.Forms.Button();
            this.buttonDE = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerHR = new System.Windows.Forms.Timer(this.components);
            this.timerUS = new System.Windows.Forms.Timer(this.components);
            this.timerDE = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.buttonUK = new System.Windows.Forms.Button();
            this.timerUK = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timelabel
            // 
            resources.ApplyResources(this.timelabel, "timelabel");
            this.timelabel.Name = "timelabel";
            // 
            // secondslabel
            // 
            resources.ApplyResources(this.secondslabel, "secondslabel");
            this.secondslabel.Name = "secondslabel";
            // 
            // datelabel
            // 
            resources.ApplyResources(this.datelabel, "datelabel");
            this.datelabel.Name = "datelabel";
            // 
            // buttonHR
            // 
            resources.ApplyResources(this.buttonHR, "buttonHR");
            this.buttonHR.Name = "buttonHR";
            this.buttonHR.UseVisualStyleBackColor = true;
            this.buttonHR.Click += new System.EventHandler(this.buttonHR_Click);
            // 
            // buttonUS
            // 
            resources.ApplyResources(this.buttonUS, "buttonUS");
            this.buttonUS.Name = "buttonUS";
            this.buttonUS.UseVisualStyleBackColor = true;
            this.buttonUS.Click += new System.EventHandler(this.buttonUS_Click);
            // 
            // buttonDE
            // 
            resources.ApplyResources(this.buttonDE, "buttonDE");
            this.buttonDE.Name = "buttonDE";
            this.buttonDE.UseVisualStyleBackColor = true;
            this.buttonDE.Click += new System.EventHandler(this.buttonDE_Click);
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // resetToolStripMenuItem
            // 
            resources.ApplyResources(this.resetToolStripMenuItem, "resetToolStripMenuItem");
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            resources.ApplyResources(this.closeToolStripMenuItem, "closeToolStripMenuItem");
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // timerHR
            // 
            this.timerHR.Tick += new System.EventHandler(this.timerHR_Tick);
            // 
            // timerUS
            // 
            this.timerUS.Tick += new System.EventHandler(this.timerUS_Tick);
            // 
            // timerDE
            // 
            this.timerDE.Tick += new System.EventHandler(this.timerDE_Tick);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // buttonUK
            // 
            resources.ApplyResources(this.buttonUK, "buttonUK");
            this.buttonUK.Name = "buttonUK";
            this.buttonUK.UseVisualStyleBackColor = true;
            this.buttonUK.Click += new System.EventHandler(this.buttonUK_Click);
            // 
            // timerUK
            // 
            this.timerUK.Tick += new System.EventHandler(this.timerUK_Tick);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.buttonUK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDE);
            this.Controls.Add(this.buttonUS);
            this.Controls.Add(this.buttonHR);
            this.Controls.Add(this.datelabel);
            this.Controls.Add(this.secondslabel);
            this.Controls.Add(this.timelabel);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Red;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timelabel;
        private System.Windows.Forms.Label secondslabel;
        private System.Windows.Forms.Label datelabel;
        private System.Windows.Forms.Button buttonHR;
        private System.Windows.Forms.Button buttonUS;
        private System.Windows.Forms.Button buttonDE;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Timer timerHR;
        private System.Windows.Forms.Timer timerUS;
        private System.Windows.Forms.Timer timerDE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonUK;
        private System.Windows.Forms.Timer timerUK;
    }
}

