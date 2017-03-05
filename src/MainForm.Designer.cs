namespace Scheorbi
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnTimbre = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTecla = new System.Windows.Forms.Label();
            this.verVentanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblSegundos = new System.Windows.Forms.Label();
            this.lblTeclaHolder = new System.Windows.Forms.Label();
            this.lblSegundosHolder = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTimbre
            // 
            this.btnTimbre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimbre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimbre.Location = new System.Drawing.Point(12, 66);
            this.btnTimbre.Name = "btnTimbre";
            this.btnTimbre.Size = new System.Drawing.Size(507, 103);
            this.btnTimbre.TabIndex = 0;
            this.btnTimbre.Text = "Abrir Puerta";
            this.btnTimbre.UseVisualStyleBackColor = true;
            this.btnTimbre.Click += new System.EventHandler(this.btnTimbre_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "SCHOERBI";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verVentanaToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(136, 48);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // lblTecla
            // 
            this.lblTecla.AutoSize = true;
            this.lblTecla.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTecla.Location = new System.Drawing.Point(12, 19);
            this.lblTecla.Name = "lblTecla";
            this.lblTecla.Size = new System.Drawing.Size(184, 24);
            this.lblTecla.TabIndex = 2;
            this.lblTecla.Text = "Tecla configurada:";
            // 
            // verVentanaToolStripMenuItem
            // 
            this.verVentanaToolStripMenuItem.Name = "verVentanaToolStripMenuItem";
            this.verVentanaToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.verVentanaToolStripMenuItem.Text = "Ver ventana";
            this.verVentanaToolStripMenuItem.Click += new System.EventHandler(this.verVentanaToolStripMenuItem_Click);
            // 
            // lblSegundos
            // 
            this.lblSegundos.AutoSize = true;
            this.lblSegundos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundos.Location = new System.Drawing.Point(257, 19);
            this.lblSegundos.Name = "lblSegundos";
            this.lblSegundos.Size = new System.Drawing.Size(172, 24);
            this.lblSegundos.TabIndex = 3;
            this.lblSegundos.Text = "Duracion Timbre:";
            // 
            // lblTeclaHolder
            // 
            this.lblTeclaHolder.AutoSize = true;
            this.lblTeclaHolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeclaHolder.ForeColor = System.Drawing.Color.Red;
            this.lblTeclaHolder.Location = new System.Drawing.Point(191, 19);
            this.lblTeclaHolder.Name = "lblTeclaHolder";
            this.lblTeclaHolder.Size = new System.Drawing.Size(45, 24);
            this.lblTeclaHolder.TabIndex = 4;
            this.lblTeclaHolder.Text = "F13";
            // 
            // lblSegundosHolder
            // 
            this.lblSegundosHolder.AutoSize = true;
            this.lblSegundosHolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundosHolder.ForeColor = System.Drawing.Color.Red;
            this.lblSegundosHolder.Location = new System.Drawing.Point(422, 19);
            this.lblSegundosHolder.Name = "lblSegundosHolder";
            this.lblSegundosHolder.Size = new System.Drawing.Size(93, 24);
            this.lblSegundosHolder.TabIndex = 5;
            this.lblSegundosHolder.Text = "777 segs";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 181);
            this.Controls.Add(this.lblSegundosHolder);
            this.Controls.Add(this.lblTeclaHolder);
            this.Controls.Add(this.lblSegundos);
            this.Controls.Add(this.lblTecla);
            this.Controls.Add(this.btnTimbre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowInTaskbar = false;
            this.Text = "SCHOERBI";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTimbre;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lblTecla;
        private System.Windows.Forms.ToolStripMenuItem verVentanaToolStripMenuItem;
        private System.Windows.Forms.Label lblSegundos;
        private System.Windows.Forms.Label lblTeclaHolder;
        private System.Windows.Forms.Label lblSegundosHolder;
    }
}

