namespace PlcTestApp
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
            this.txtBoxWrite = new System.Windows.Forms.TextBox();
            this.txtBoxRead = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSpeed = new System.Windows.Forms.Button();
            this.btnLength = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnInit = new System.Windows.Forms.Button();
            this.txtSpeed = new System.Windows.Forms.TextBox();
            this.txtBoxLength = new System.Windows.Forms.TextBox();
            this.txtBoxStop = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btnGood = new System.Windows.Forms.Button();
            this.btnBead = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAck = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnApplay = new System.Windows.Forms.Button();
            this.txtPortName = new System.Windows.Forms.TextBox();
            this.txtPortSpeed = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBoxWrite
            // 
            this.txtBoxWrite.Location = new System.Drawing.Point(12, 38);
            this.txtBoxWrite.Multiline = true;
            this.txtBoxWrite.Name = "txtBoxWrite";
            this.txtBoxWrite.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxWrite.Size = new System.Drawing.Size(709, 170);
            this.txtBoxWrite.TabIndex = 0;
            // 
            // txtBoxRead
            // 
            this.txtBoxRead.Location = new System.Drawing.Point(12, 241);
            this.txtBoxRead.Multiline = true;
            this.txtBoxRead.Name = "txtBoxRead";
            this.txtBoxRead.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxRead.Size = new System.Drawing.Size(709, 175);
            this.txtBoxRead.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(212, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = " Write Package";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(214, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Read Package";
            // 
            // btnSpeed
            // 
            this.btnSpeed.Location = new System.Drawing.Point(871, 35);
            this.btnSpeed.Name = "btnSpeed";
            this.btnSpeed.Size = new System.Drawing.Size(103, 23);
            this.btnSpeed.TabIndex = 4;
            this.btnSpeed.Text = "Write FEED";
            this.btnSpeed.UseVisualStyleBackColor = true;
            this.btnSpeed.Click += new System.EventHandler(this.btnSpeed_Click);
            // 
            // btnLength
            // 
            this.btnLength.Location = new System.Drawing.Point(871, 74);
            this.btnLength.Name = "btnLength";
            this.btnLength.Size = new System.Drawing.Size(103, 23);
            this.btnLength.TabIndex = 4;
            this.btnLength.Text = "Write  LENGTH";
            this.btnLength.UseVisualStyleBackColor = true;
            this.btnLength.Click += new System.EventHandler(this.btnLength_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(871, 115);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(103, 23);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "Write STOP";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnInit
            // 
            this.btnInit.Location = new System.Drawing.Point(334, 6);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(103, 23);
            this.btnInit.TabIndex = 4;
            this.btnInit.Text = "Write INIT";
            this.btnInit.UseVisualStyleBackColor = true;
            this.btnInit.Click += new System.EventHandler(this.btnInit_Click);
            // 
            // txtSpeed
            // 
            this.txtSpeed.Location = new System.Drawing.Point(738, 38);
            this.txtSpeed.Name = "txtSpeed";
            this.txtSpeed.Size = new System.Drawing.Size(107, 20);
            this.txtSpeed.TabIndex = 5;
            // 
            // txtBoxLength
            // 
            this.txtBoxLength.Location = new System.Drawing.Point(738, 77);
            this.txtBoxLength.Name = "txtBoxLength";
            this.txtBoxLength.Size = new System.Drawing.Size(107, 20);
            this.txtBoxLength.TabIndex = 5;
            // 
            // txtBoxStop
            // 
            this.txtBoxStop.Location = new System.Drawing.Point(738, 118);
            this.txtBoxStop.Name = "txtBoxStop";
            this.txtBoxStop.Size = new System.Drawing.Size(107, 20);
            this.txtBoxStop.TabIndex = 5;
            // 
            // serialPort1
            // 
            this.serialPort1.ReadTimeout = 1000;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // btnGood
            // 
            this.btnGood.Location = new System.Drawing.Point(738, 185);
            this.btnGood.Name = "btnGood";
            this.btnGood.Size = new System.Drawing.Size(107, 23);
            this.btnGood.TabIndex = 6;
            this.btnGood.Text = "Good";
            this.btnGood.UseVisualStyleBackColor = true;
            this.btnGood.Click += new System.EventHandler(this.btnGood_Click);
            // 
            // btnBead
            // 
            this.btnBead.Location = new System.Drawing.Point(871, 185);
            this.btnBead.Name = "btnBead";
            this.btnBead.Size = new System.Drawing.Size(103, 23);
            this.btnBead.TabIndex = 6;
            this.btnBead.Text = "Bad";
            this.btnBead.UseVisualStyleBackColor = true;
            this.btnBead.Click += new System.EventHandler(this.btnBead_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(492, 432);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "InitAck";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnAuto_Click);
            // 
            // btnAck
            // 
            this.btnAck.Location = new System.Drawing.Point(618, 432);
            this.btnAck.Name = "btnAck";
            this.btnAck.Size = new System.Drawing.Size(103, 23);
            this.btnAck.TabIndex = 6;
            this.btnAck.Text = "ACK";
            this.btnAck.UseVisualStyleBackColor = true;
            this.btnAck.Click += new System.EventHandler(this.btnAck_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnApplay);
            this.groupBox1.Controls.Add(this.txtPortName);
            this.groupBox1.Controls.Add(this.txtPortSpeed);
            this.groupBox1.Location = new System.Drawing.Point(738, 241);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(123, 173);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COM-port";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "port";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "speed";
            // 
            // btnApplay
            // 
            this.btnApplay.Location = new System.Drawing.Point(21, 135);
            this.btnApplay.Name = "btnApplay";
            this.btnApplay.Size = new System.Drawing.Size(83, 23);
            this.btnApplay.TabIndex = 6;
            this.btnApplay.Text = "Apply";
            this.btnApplay.UseVisualStyleBackColor = true;
            this.btnApplay.Click += new System.EventHandler(this.btnApplay_Click);
            // 
            // txtPortName
            // 
            this.txtPortName.Location = new System.Drawing.Point(10, 39);
            this.txtPortName.Name = "txtPortName";
            this.txtPortName.Size = new System.Drawing.Size(107, 20);
            this.txtPortName.TabIndex = 5;
            this.txtPortName.Text = "COM1";
            // 
            // txtPortSpeed
            // 
            this.txtPortSpeed.Location = new System.Drawing.Point(10, 97);
            this.txtPortSpeed.Name = "txtPortSpeed";
            this.txtPortSpeed.Size = new System.Drawing.Size(107, 20);
            this.txtPortSpeed.TabIndex = 5;
            this.txtPortSpeed.Text = "115200";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 467);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAck);
            this.Controls.Add(this.btnBead);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGood);
            this.Controls.Add(this.txtBoxStop);
            this.Controls.Add(this.txtBoxLength);
            this.Controls.Add(this.txtSpeed);
            this.Controls.Add(this.btnInit);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnLength);
            this.Controls.Add(this.btnSpeed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxRead);
            this.Controls.Add(this.txtBoxWrite);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "TestPlc";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxWrite;
        private System.Windows.Forms.TextBox txtBoxRead;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSpeed;
        private System.Windows.Forms.Button btnLength;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnInit;
        private System.Windows.Forms.TextBox txtSpeed;
        private System.Windows.Forms.TextBox txtBoxLength;
        private System.Windows.Forms.TextBox txtBoxStop;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btnGood;
        private System.Windows.Forms.Button btnBead;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAck;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnApplay;
        private System.Windows.Forms.TextBox txtPortName;
        private System.Windows.Forms.TextBox txtPortSpeed;
    }
}

