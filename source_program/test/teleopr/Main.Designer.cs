namespace teleopr
{
    partial class frmMain
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtBaud = new System.Windows.Forms.TextBox();
            this.txtComport = new System.Windows.Forms.TextBox();
            this.txtPrint = new System.Windows.Forms.TextBox();
            this.tmrRead = new System.Windows.Forms.Timer(this.components);
            this.pnCam = new System.Windows.Forms.Panel();
            this.txtCameraIndex = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCamera = new System.Windows.Forms.Button();
            this.txtSpeed_Wait = new System.Windows.Forms.TextBox();
            this.txtSpeed_Move = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSet = new System.Windows.Forms.Button();
            this.btnTorqOn = new System.Windows.Forms.Button();
            this.btnTorqOff = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.offToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chkLeftHanded = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Baud";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Comport";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(209, 55);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(126, 33);
            this.btnConnect.TabIndex = 9;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtBaud
            // 
            this.txtBaud.Location = new System.Drawing.Point(98, 57);
            this.txtBaud.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBaud.Name = "txtBaud";
            this.txtBaud.Size = new System.Drawing.Size(103, 28);
            this.txtBaud.TabIndex = 7;
            // 
            // txtComport
            // 
            this.txtComport.Location = new System.Drawing.Point(99, 18);
            this.txtComport.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtComport.Name = "txtComport";
            this.txtComport.Size = new System.Drawing.Size(103, 28);
            this.txtComport.TabIndex = 8;
            // 
            // txtPrint
            // 
            this.txtPrint.Location = new System.Drawing.Point(592, 35);
            this.txtPrint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrint.Multiline = true;
            this.txtPrint.Name = "txtPrint";
            this.txtPrint.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtPrint.Size = new System.Drawing.Size(693, 632);
            this.txtPrint.TabIndex = 13;
            this.txtPrint.WordWrap = false;
            // 
            // tmrRead
            // 
            this.tmrRead.Interval = 20;
            this.tmrRead.Tick += new System.EventHandler(this.tmrRead_Tick);
            // 
            // pnCam
            // 
            this.pnCam.Location = new System.Drawing.Point(30, 246);
            this.pnCam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnCam.Name = "pnCam";
            this.pnCam.Size = new System.Drawing.Size(554, 489);
            this.pnCam.TabIndex = 14;
            // 
            // txtCameraIndex
            // 
            this.txtCameraIndex.Location = new System.Drawing.Point(118, 154);
            this.txtCameraIndex.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCameraIndex.Name = "txtCameraIndex";
            this.txtCameraIndex.Size = new System.Drawing.Size(103, 28);
            this.txtCameraIndex.TabIndex = 8;
            this.txtCameraIndex.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 160);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Camera";
            // 
            // btnCamera
            // 
            this.btnCamera.Location = new System.Drawing.Point(42, 189);
            this.btnCamera.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCamera.Name = "btnCamera";
            this.btnCamera.Size = new System.Drawing.Size(179, 34);
            this.btnCamera.TabIndex = 15;
            this.btnCamera.Text = "Start Camera";
            this.btnCamera.UseVisualStyleBackColor = true;
            this.btnCamera.Click += new System.EventHandler(this.btnCamera_Click);
            // 
            // txtSpeed_Wait
            // 
            this.txtSpeed_Wait.Location = new System.Drawing.Point(497, 74);
            this.txtSpeed_Wait.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSpeed_Wait.Name = "txtSpeed_Wait";
            this.txtSpeed_Wait.Size = new System.Drawing.Size(87, 28);
            this.txtSpeed_Wait.TabIndex = 8;
            this.txtSpeed_Wait.Text = "50";
            // 
            // txtSpeed_Move
            // 
            this.txtSpeed_Move.Location = new System.Drawing.Point(497, 108);
            this.txtSpeed_Move.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSpeed_Move.Name = "txtSpeed_Move";
            this.txtSpeed_Move.Size = new System.Drawing.Size(87, 28);
            this.txtSpeed_Move.TabIndex = 7;
            this.txtSpeed_Move.Text = "200";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(361, 77);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Speed(Interval)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(361, 108);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Speed(Moving)";
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(364, 139);
            this.btnSet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(220, 84);
            this.btnSet.TabIndex = 16;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // btnTorqOn
            // 
            this.btnTorqOn.Location = new System.Drawing.Point(906, 674);
            this.btnTorqOn.Name = "btnTorqOn";
            this.btnTorqOn.Size = new System.Drawing.Size(179, 62);
            this.btnTorqOn.TabIndex = 17;
            this.btnTorqOn.Text = "Torq On";
            this.btnTorqOn.UseVisualStyleBackColor = true;
            this.btnTorqOn.Click += new System.EventHandler(this.btnTorqOn_Click);
            // 
            // btnTorqOff
            // 
            this.btnTorqOff.Location = new System.Drawing.Point(1109, 674);
            this.btnTorqOff.Name = "btnTorqOff";
            this.btnTorqOff.Size = new System.Drawing.Size(179, 62);
            this.btnTorqOff.TabIndex = 17;
            this.btnTorqOff.Text = "Torq Off";
            this.btnTorqOff.UseVisualStyleBackColor = true;
            this.btnTorqOff.Click += new System.EventHandler(this.btnTorqOff_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1295, 33);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onToolStripMenuItem,
            this.offToolStripMenuItem});
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.testToolStripMenuItem.Text = "test";
            // 
            // onToolStripMenuItem
            // 
            this.onToolStripMenuItem.Name = "onToolStripMenuItem";
            this.onToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.NumPad1)));
            this.onToolStripMenuItem.Size = new System.Drawing.Size(240, 30);
            this.onToolStripMenuItem.Text = "On";
            // 
            // offToolStripMenuItem
            // 
            this.offToolStripMenuItem.Name = "offToolStripMenuItem";
            this.offToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.NumPad0)));
            this.offToolStripMenuItem.Size = new System.Drawing.Size(240, 30);
            this.offToolStripMenuItem.Text = "Off";
            // 
            // chkLeftHanded
            // 
            this.chkLeftHanded.AutoSize = true;
            this.chkLeftHanded.Location = new System.Drawing.Point(210, 19);
            this.chkLeftHanded.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkLeftHanded.Name = "chkLeftHanded";
            this.chkLeftHanded.Size = new System.Drawing.Size(130, 22);
            this.chkLeftHanded.TabIndex = 19;
            this.chkLeftHanded.Text = "Left Handed";
            this.chkLeftHanded.UseVisualStyleBackColor = true;
            this.chkLeftHanded.CheckedChanged += new System.EventHandler(this.chkLeftHanded_CheckedChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 748);
            this.Controls.Add(this.chkLeftHanded);
            this.Controls.Add(this.btnTorqOff);
            this.Controls.Add(this.btnTorqOn);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.btnCamera);
            this.Controls.Add(this.pnCam);
            this.Controls.Add(this.txtPrint);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtSpeed_Move);
            this.Controls.Add(this.txtBaud);
            this.Controls.Add(this.txtCameraIndex);
            this.Controls.Add(this.txtSpeed_Wait);
            this.Controls.Add(this.txtComport);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMain";
            this.Text = "Teleoperation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtBaud;
        private System.Windows.Forms.TextBox txtComport;
        private System.Windows.Forms.TextBox txtPrint;
        private System.Windows.Forms.Timer tmrRead;
        private System.Windows.Forms.Panel pnCam;
        private System.Windows.Forms.TextBox txtCameraIndex;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCamera;
        private System.Windows.Forms.TextBox txtSpeed_Wait;
        private System.Windows.Forms.TextBox txtSpeed_Move;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Button btnTorqOn;
        private System.Windows.Forms.Button btnTorqOff;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem offToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onToolStripMenuItem;
        private System.Windows.Forms.CheckBox chkLeftHanded;
    }
}

