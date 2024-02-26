
namespace ArduinoController
{
    partial class Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.bt_exit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.bt_Connect = new System.Windows.Forms.Button();
            this.bt_Disconnect = new System.Windows.Forms.Button();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.outputBox = new System.Windows.Forms.Label();
            this.lb_input = new System.Windows.Forms.Label();
            this.portList = new System.Windows.Forms.ComboBox();
            this.lb_portSelect = new System.Windows.Forms.Label();
            this.autoPort = new System.Windows.Forms.CheckBox();
            this.reloadPorts = new System.Windows.Forms.ImageList(this.components);
            this.bt_reloadPorts = new System.Windows.Forms.Button();
            this.pb_image = new System.Windows.Forms.PictureBox();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_image)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_exit
            // 
            this.bt_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.bt_exit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bt_exit.FlatAppearance.BorderSize = 0;
            this.bt_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_exit.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_exit.ForeColor = System.Drawing.Color.White;
            this.bt_exit.Location = new System.Drawing.Point(622, 385);
            this.bt_exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(128, 46);
            this.bt_exit.TabIndex = 7;
            this.bt_exit.Text = "EXIT";
            this.bt_exit.UseVisualStyleBackColor = false;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(318, 40);
            this.label3.TabIndex = 8;
            this.label3.Text = "Arduino Zapperator";
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.label3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.label3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Controls.Add(this.label3);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(786, 45);
            this.panelTop.TabIndex = 9;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.panelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.panelTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(335, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "V0.5";
            // 
            // bt_Connect
            // 
            this.bt_Connect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.bt_Connect.FlatAppearance.BorderSize = 0;
            this.bt_Connect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Connect.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Connect.ForeColor = System.Drawing.Color.White;
            this.bt_Connect.Location = new System.Drawing.Point(454, 67);
            this.bt_Connect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Connect.Name = "bt_Connect";
            this.bt_Connect.Size = new System.Drawing.Size(145, 39);
            this.bt_Connect.TabIndex = 10;
            this.bt_Connect.Text = "Connect";
            this.bt_Connect.UseVisualStyleBackColor = false;
            this.bt_Connect.Click += new System.EventHandler(this.bt_connect_Click);
            // 
            // bt_Disconnect
            // 
            this.bt_Disconnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.bt_Disconnect.FlatAppearance.BorderSize = 0;
            this.bt_Disconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Disconnect.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Disconnect.ForeColor = System.Drawing.Color.White;
            this.bt_Disconnect.Location = new System.Drawing.Point(605, 68);
            this.bt_Disconnect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Disconnect.Name = "bt_Disconnect";
            this.bt_Disconnect.Size = new System.Drawing.Size(145, 39);
            this.bt_Disconnect.TabIndex = 10;
            this.bt_Disconnect.Text = "Disconnect";
            this.bt_Disconnect.UseVisualStyleBackColor = false;
            this.bt_Disconnect.Click += new System.EventHandler(this.bt_disconnect_Click);
            // 
            // inputBox
            // 
            this.inputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputBox.Location = new System.Drawing.Point(132, 68);
            this.inputBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputBox.MaxLength = 10;
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(192, 38);
            this.inputBox.TabIndex = 11;
            this.inputBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sendMessage);
            // 
            // outputBox
            // 
            this.outputBox.AutoSize = true;
            this.outputBox.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputBox.ForeColor = System.Drawing.Color.White;
            this.outputBox.Location = new System.Drawing.Point(19, 119);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(305, 35);
            this.outputBox.TabIndex = 12;
            this.outputBox.Text = "Waiting for response...";
            // 
            // lb_input
            // 
            this.lb_input.AutoSize = true;
            this.lb_input.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_input.ForeColor = System.Drawing.Color.White;
            this.lb_input.Location = new System.Drawing.Point(19, 68);
            this.lb_input.Name = "lb_input";
            this.lb_input.Size = new System.Drawing.Size(97, 36);
            this.lb_input.TabIndex = 13;
            this.lb_input.Text = "Input:";
            // 
            // portList
            // 
            this.portList.BackColor = System.Drawing.Color.White;
            this.portList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.portList.ForeColor = System.Drawing.Color.Black;
            this.portList.FormattingEnabled = true;
            this.portList.Location = new System.Drawing.Point(605, 130);
            this.portList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.portList.Name = "portList";
            this.portList.Size = new System.Drawing.Size(112, 24);
            this.portList.TabIndex = 14;
            // 
            // lb_portSelect
            // 
            this.lb_portSelect.AutoSize = true;
            this.lb_portSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_portSelect.ForeColor = System.Drawing.Color.White;
            this.lb_portSelect.Location = new System.Drawing.Point(449, 129);
            this.lb_portSelect.Name = "lb_portSelect";
            this.lb_portSelect.Size = new System.Drawing.Size(113, 25);
            this.lb_portSelect.TabIndex = 15;
            this.lb_portSelect.Text = "Select Port:";
            // 
            // autoPort
            // 
            this.autoPort.AutoSize = true;
            this.autoPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoPort.ForeColor = System.Drawing.Color.White;
            this.autoPort.Location = new System.Drawing.Point(453, 160);
            this.autoPort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.autoPort.Name = "autoPort";
            this.autoPort.Size = new System.Drawing.Size(137, 29);
            this.autoPort.TabIndex = 16;
            this.autoPort.Text = "Auto-Select";
            this.autoPort.UseVisualStyleBackColor = true;
            this.autoPort.CheckedChanged += new System.EventHandler(this.autoPort_CheckedChanged);
            // 
            // reloadPorts
            // 
            this.reloadPorts.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("reloadPorts.ImageStream")));
            this.reloadPorts.TransparentColor = System.Drawing.Color.Transparent;
            this.reloadPorts.Images.SetKeyName(0, "Steve-Zondicons-Reload.512.png");
            // 
            // bt_reloadPorts
            // 
            this.bt_reloadPorts.ImageIndex = 0;
            this.bt_reloadPorts.ImageList = this.reloadPorts;
            this.bt_reloadPorts.Location = new System.Drawing.Point(723, 129);
            this.bt_reloadPorts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_reloadPorts.Name = "bt_reloadPorts";
            this.bt_reloadPorts.Size = new System.Drawing.Size(27, 24);
            this.bt_reloadPorts.TabIndex = 17;
            this.bt_reloadPorts.UseVisualStyleBackColor = true;
            this.bt_reloadPorts.Click += new System.EventHandler(this.bt_reloadPorts_click);
            // 
            // pb_image
            // 
            this.pb_image.BackColor = System.Drawing.Color.Black;
            this.pb_image.Location = new System.Drawing.Point(25, 175);
            this.pb_image.Name = "pb_image";
            this.pb_image.Size = new System.Drawing.Size(256, 234);
            this.pb_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_image.TabIndex = 18;
            this.pb_image.TabStop = false;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(786, 463);
            this.ControlBox = false;
            this.Controls.Add(this.pb_image);
            this.Controls.Add(this.bt_reloadPorts);
            this.Controls.Add(this.autoPort);
            this.Controls.Add(this.lb_portSelect);
            this.Controls.Add(this.portList);
            this.Controls.Add(this.lb_input);
            this.Controls.Add(this.bt_exit);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.bt_Disconnect);
            this.Controls.Add(this.bt_Connect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ArduinoController v.0.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sendMessage);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bt_exit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelTop;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button bt_Connect;
        private System.Windows.Forms.Button bt_Disconnect;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Label outputBox;
        private System.Windows.Forms.Label lb_input;
        private System.Windows.Forms.ComboBox portList;
        private System.Windows.Forms.Label lb_portSelect;
        private System.Windows.Forms.CheckBox autoPort;
        private System.Windows.Forms.ImageList reloadPorts;
        private System.Windows.Forms.Button bt_reloadPorts;
        private System.Windows.Forms.PictureBox pb_image;
        private System.Windows.Forms.Label label1;
    }
}

