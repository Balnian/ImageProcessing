namespace ImageProcessing
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PB_Original = new System.Windows.Forms.PictureBox();
            this.PB_Processed = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BT_Process = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.BT_FeedBack = new System.Windows.Forms.Button();
            this.BT_Save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Original)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Processed)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PB_Original
            // 
            this.PB_Original.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PB_Original.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PB_Original.Image = ((System.Drawing.Image)(resources.GetObject("PB_Original.Image")));
            this.PB_Original.Location = new System.Drawing.Point(3, 3);
            this.PB_Original.Name = "PB_Original";
            this.PB_Original.Size = new System.Drawing.Size(444, 500);
            this.PB_Original.TabIndex = 0;
            this.PB_Original.TabStop = false;
            // 
            // PB_Processed
            // 
            this.PB_Processed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PB_Processed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PB_Processed.Location = new System.Drawing.Point(453, 3);
            this.PB_Processed.Name = "PB_Processed";
            this.PB_Processed.Size = new System.Drawing.Size(445, 500);
            this.PB_Processed.TabIndex = 1;
            this.PB_Processed.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BT_Save);
            this.panel1.Controls.Add(this.BT_FeedBack);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.BT_Process);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(901, 95);
            this.panel1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.PB_Processed, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.PB_Original, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 95);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(901, 506);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // BT_Process
            // 
            this.BT_Process.Location = new System.Drawing.Point(404, 27);
            this.BT_Process.Name = "BT_Process";
            this.BT_Process.Size = new System.Drawing.Size(75, 23);
            this.BT_Process.TabIndex = 0;
            this.BT_Process.Text = "Process";
            this.BT_Process.UseVisualStyleBackColor = true;
            this.BT_Process.Click += new System.EventHandler(this.BT_Process_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(901, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BT_FeedBack
            // 
            this.BT_FeedBack.Location = new System.Drawing.Point(404, 66);
            this.BT_FeedBack.Name = "BT_FeedBack";
            this.BT_FeedBack.Size = new System.Drawing.Size(75, 23);
            this.BT_FeedBack.TabIndex = 3;
            this.BT_FeedBack.Text = "Feed Back";
            this.BT_FeedBack.UseVisualStyleBackColor = true;
            this.BT_FeedBack.Click += new System.EventHandler(this.BT_FeedBack_Click);
            // 
            // BT_Save
            // 
            this.BT_Save.Location = new System.Drawing.Point(691, 65);
            this.BT_Save.Name = "BT_Save";
            this.BT_Save.Size = new System.Drawing.Size(75, 23);
            this.BT_Save.TabIndex = 4;
            this.BT_Save.Text = "Save";
            this.BT_Save.UseVisualStyleBackColor = true;
            this.BT_Save.Click += new System.EventHandler(this.BT_Save_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 601);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PB_Original)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Processed)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PB_Original;
        private System.Windows.Forms.PictureBox PB_Processed;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BT_Process;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button BT_FeedBack;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.Button BT_Save;
    }
}

