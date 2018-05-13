namespace ClientToArduino_ExamProject_ChristianLynge
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
            this.textboxInput = new System.Windows.Forms.TextBox();
            this.sendbtn = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEStop1 = new System.Windows.Forms.Button();
            this.btnSound1 = new System.Windows.Forms.Button();
            this.btn2ndHorn1 = new System.Windows.Forms.Button();
            this.btn1stHorn1 = new System.Windows.Forms.Button();
            this.btnBell1 = new System.Windows.Forms.Button();
            this.btnLights1 = new System.Windows.Forms.Button();
            this.lblSpeed1 = new System.Windows.Forms.Label();
            this.btnFaster1 = new System.Windows.Forms.Button();
            this.btnSlower1 = new System.Windows.Forms.Button();
            this.btnDirection1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTrainAddress1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEStop2 = new System.Windows.Forms.Button();
            this.btnSound2 = new System.Windows.Forms.Button();
            this.btn2ndHorn2 = new System.Windows.Forms.Button();
            this.btn1stHorn2 = new System.Windows.Forms.Button();
            this.btnBell2 = new System.Windows.Forms.Button();
            this.btnLights2 = new System.Windows.Forms.Button();
            this.lblSpeed2 = new System.Windows.Forms.Label();
            this.btnFaster2 = new System.Windows.Forms.Button();
            this.btnSlower2 = new System.Windows.Forms.Button();
            this.btnDirection2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTrainAddress2 = new System.Windows.Forms.TextBox();
            this.txtAcc1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSwitchAcc1 = new System.Windows.Forms.Button();
            this.btnSwitchAcc2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAcc2 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textboxInput
            // 
            this.textboxInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textboxInput.Location = new System.Drawing.Point(107, 335);
            this.textboxInput.Margin = new System.Windows.Forms.Padding(2);
            this.textboxInput.Name = "textboxInput";
            this.textboxInput.Size = new System.Drawing.Size(336, 20);
            this.textboxInput.TabIndex = 0;
            this.textboxInput.Text = "testRequest param1 param2 param3";
            this.textboxInput.TextChanged += new System.EventHandler(this.textboxInput_TextChanged);
            // 
            // sendbtn
            // 
            this.sendbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sendbtn.Location = new System.Drawing.Point(447, 335);
            this.sendbtn.Margin = new System.Windows.Forms.Padding(2);
            this.sendbtn.Name = "sendbtn";
            this.sendbtn.Size = new System.Drawing.Size(56, 20);
            this.sendbtn.TabIndex = 1;
            this.sendbtn.Text = "send";
            this.sendbtn.UseVisualStyleBackColor = true;
            this.sendbtn.Click += new System.EventHandler(this.sendbtn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(68, 6);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(92, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnEStop1);
            this.panel1.Controls.Add(this.btnSound1);
            this.panel1.Controls.Add(this.btn2ndHorn1);
            this.panel1.Controls.Add(this.btn1stHorn1);
            this.panel1.Controls.Add(this.btnBell1);
            this.panel1.Controls.Add(this.btnLights1);
            this.panel1.Controls.Add(this.lblSpeed1);
            this.panel1.Controls.Add(this.btnFaster1);
            this.panel1.Controls.Add(this.btnSlower1);
            this.panel1.Controls.Add(this.btnDirection1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtTrainAddress1);
            this.panel1.Location = new System.Drawing.Point(12, 43);
            this.panel1.MinimumSize = new System.Drawing.Size(223, 134);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 134);
            this.panel1.TabIndex = 3;
            // 
            // btnEStop1
            // 
            this.btnEStop1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEStop1.Location = new System.Drawing.Point(73, 81);
            this.btnEStop1.Name = "btnEStop1";
            this.btnEStop1.Size = new System.Drawing.Size(75, 23);
            this.btnEStop1.TabIndex = 11;
            this.btnEStop1.Text = "STOP!!";
            this.btnEStop1.UseVisualStyleBackColor = true;
            this.btnEStop1.Click += new System.EventHandler(this.btnEStop1_Click);
            // 
            // btnSound1
            // 
            this.btnSound1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSound1.Location = new System.Drawing.Point(148, 81);
            this.btnSound1.Name = "btnSound1";
            this.btnSound1.Size = new System.Drawing.Size(75, 23);
            this.btnSound1.TabIndex = 10;
            this.btnSound1.Text = "Sound: off";
            this.btnSound1.UseVisualStyleBackColor = true;
            this.btnSound1.Click += new System.EventHandler(this.btnSound1_Click);
            // 
            // btn2ndHorn1
            // 
            this.btn2ndHorn1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn2ndHorn1.Location = new System.Drawing.Point(147, 110);
            this.btn2ndHorn1.Name = "btn2ndHorn1";
            this.btn2ndHorn1.Size = new System.Drawing.Size(75, 23);
            this.btn2ndHorn1.TabIndex = 9;
            this.btn2ndHorn1.Text = "Horn2: off";
            this.btn2ndHorn1.UseVisualStyleBackColor = true;
            this.btn2ndHorn1.Click += new System.EventHandler(this.btn2ndHorn1_Click);
            // 
            // btn1stHorn1
            // 
            this.btn1stHorn1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn1stHorn1.Location = new System.Drawing.Point(73, 110);
            this.btn1stHorn1.Name = "btn1stHorn1";
            this.btn1stHorn1.Size = new System.Drawing.Size(75, 23);
            this.btn1stHorn1.TabIndex = 8;
            this.btn1stHorn1.Text = "Horn1: off";
            this.btn1stHorn1.UseVisualStyleBackColor = true;
            this.btn1stHorn1.Click += new System.EventHandler(this.btn1stHorn1_Click);
            // 
            // btnBell1
            // 
            this.btnBell1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBell1.Location = new System.Drawing.Point(0, 110);
            this.btnBell1.Name = "btnBell1";
            this.btnBell1.Size = new System.Drawing.Size(75, 23);
            this.btnBell1.TabIndex = 7;
            this.btnBell1.Text = "Bell: off";
            this.btnBell1.UseVisualStyleBackColor = true;
            this.btnBell1.Click += new System.EventHandler(this.btnBell1_Click);
            // 
            // btnLights1
            // 
            this.btnLights1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLights1.Location = new System.Drawing.Point(-1, 81);
            this.btnLights1.Name = "btnLights1";
            this.btnLights1.Size = new System.Drawing.Size(75, 23);
            this.btnLights1.TabIndex = 6;
            this.btnLights1.Text = "Lights: off";
            this.btnLights1.UseVisualStyleBackColor = true;
            this.btnLights1.Click += new System.EventHandler(this.btnLights1_Click);
            // 
            // lblSpeed1
            // 
            this.lblSpeed1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSpeed1.AutoSize = true;
            this.lblSpeed1.Location = new System.Drawing.Point(104, 48);
            this.lblSpeed1.Name = "lblSpeed1";
            this.lblSpeed1.Size = new System.Drawing.Size(13, 13);
            this.lblSpeed1.TabIndex = 5;
            this.lblSpeed1.Text = "0";
            this.lblSpeed1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnFaster1
            // 
            this.btnFaster1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFaster1.Location = new System.Drawing.Point(147, 43);
            this.btnFaster1.Name = "btnFaster1";
            this.btnFaster1.Size = new System.Drawing.Size(75, 23);
            this.btnFaster1.TabIndex = 4;
            this.btnFaster1.Text = ">>>";
            this.btnFaster1.UseVisualStyleBackColor = true;
            this.btnFaster1.Click += new System.EventHandler(this.btnFaster1_Click);
            // 
            // btnSlower1
            // 
            this.btnSlower1.Location = new System.Drawing.Point(0, 43);
            this.btnSlower1.Name = "btnSlower1";
            this.btnSlower1.Size = new System.Drawing.Size(75, 23);
            this.btnSlower1.TabIndex = 3;
            this.btnSlower1.Text = "<<<";
            this.btnSlower1.UseVisualStyleBackColor = true;
            this.btnSlower1.Click += new System.EventHandler(this.btnSlower1_Click);
            // 
            // btnDirection1
            // 
            this.btnDirection1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDirection1.Location = new System.Drawing.Point(148, 13);
            this.btnDirection1.Name = "btnDirection1";
            this.btnDirection1.Size = new System.Drawing.Size(75, 23);
            this.btnDirection1.TabIndex = 2;
            this.btnDirection1.Text = "dir: forward";
            this.btnDirection1.UseVisualStyleBackColor = true;
            this.btnDirection1.Click += new System.EventHandler(this.btnDirection1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Train1 address";
            // 
            // txtTrainAddress1
            // 
            this.txtTrainAddress1.Location = new System.Drawing.Point(0, 16);
            this.txtTrainAddress1.Name = "txtTrainAddress1";
            this.txtTrainAddress1.Size = new System.Drawing.Size(106, 20);
            this.txtTrainAddress1.TabIndex = 0;
            this.txtTrainAddress1.Text = "9";
            this.txtTrainAddress1.TextChanged += new System.EventHandler(this.txtTrainAddress1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "COM-port:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Custom message:";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btnEStop2);
            this.panel2.Controls.Add(this.btnSound2);
            this.panel2.Controls.Add(this.btn2ndHorn2);
            this.panel2.Controls.Add(this.btn1stHorn2);
            this.panel2.Controls.Add(this.btnBell2);
            this.panel2.Controls.Add(this.btnLights2);
            this.panel2.Controls.Add(this.lblSpeed2);
            this.panel2.Controls.Add(this.btnFaster2);
            this.panel2.Controls.Add(this.btnSlower2);
            this.panel2.Controls.Add(this.btnDirection2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtTrainAddress2);
            this.panel2.Location = new System.Drawing.Point(279, 43);
            this.panel2.MinimumSize = new System.Drawing.Size(223, 134);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(223, 134);
            this.panel2.TabIndex = 11;
            // 
            // btnEStop2
            // 
            this.btnEStop2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEStop2.Location = new System.Drawing.Point(73, 81);
            this.btnEStop2.Name = "btnEStop2";
            this.btnEStop2.Size = new System.Drawing.Size(75, 23);
            this.btnEStop2.TabIndex = 12;
            this.btnEStop2.Text = "STOP!!";
            this.btnEStop2.UseVisualStyleBackColor = true;
            this.btnEStop2.Click += new System.EventHandler(this.btnEStop2_Click);
            // 
            // btnSound2
            // 
            this.btnSound2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSound2.Location = new System.Drawing.Point(147, 81);
            this.btnSound2.Name = "btnSound2";
            this.btnSound2.Size = new System.Drawing.Size(75, 23);
            this.btnSound2.TabIndex = 10;
            this.btnSound2.Text = "Sound: off";
            this.btnSound2.UseVisualStyleBackColor = true;
            this.btnSound2.Click += new System.EventHandler(this.btnSound2_Click);
            // 
            // btn2ndHorn2
            // 
            this.btn2ndHorn2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn2ndHorn2.Location = new System.Drawing.Point(147, 110);
            this.btn2ndHorn2.Name = "btn2ndHorn2";
            this.btn2ndHorn2.Size = new System.Drawing.Size(75, 23);
            this.btn2ndHorn2.TabIndex = 9;
            this.btn2ndHorn2.Text = "Horn2: off";
            this.btn2ndHorn2.UseVisualStyleBackColor = true;
            this.btn2ndHorn2.Click += new System.EventHandler(this.btn2ndHorn2_Click);
            // 
            // btn1stHorn2
            // 
            this.btn1stHorn2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn1stHorn2.Location = new System.Drawing.Point(73, 110);
            this.btn1stHorn2.Name = "btn1stHorn2";
            this.btn1stHorn2.Size = new System.Drawing.Size(75, 23);
            this.btn1stHorn2.TabIndex = 8;
            this.btn1stHorn2.Text = "Horn1: off";
            this.btn1stHorn2.UseVisualStyleBackColor = true;
            this.btn1stHorn2.Click += new System.EventHandler(this.btn1stHorn2_Click);
            // 
            // btnBell2
            // 
            this.btnBell2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBell2.Location = new System.Drawing.Point(0, 110);
            this.btnBell2.Name = "btnBell2";
            this.btnBell2.Size = new System.Drawing.Size(75, 23);
            this.btnBell2.TabIndex = 7;
            this.btnBell2.Text = "Bell: off";
            this.btnBell2.UseVisualStyleBackColor = true;
            this.btnBell2.Click += new System.EventHandler(this.btnBell2_Click);
            // 
            // btnLights2
            // 
            this.btnLights2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLights2.Location = new System.Drawing.Point(0, 81);
            this.btnLights2.Name = "btnLights2";
            this.btnLights2.Size = new System.Drawing.Size(75, 23);
            this.btnLights2.TabIndex = 6;
            this.btnLights2.Text = "Lights: off";
            this.btnLights2.UseVisualStyleBackColor = true;
            this.btnLights2.Click += new System.EventHandler(this.btnLights2_Click);
            // 
            // lblSpeed2
            // 
            this.lblSpeed2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSpeed2.AutoSize = true;
            this.lblSpeed2.Location = new System.Drawing.Point(104, 48);
            this.lblSpeed2.Name = "lblSpeed2";
            this.lblSpeed2.Size = new System.Drawing.Size(13, 13);
            this.lblSpeed2.TabIndex = 5;
            this.lblSpeed2.Text = "0";
            this.lblSpeed2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnFaster2
            // 
            this.btnFaster2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFaster2.Location = new System.Drawing.Point(147, 43);
            this.btnFaster2.Name = "btnFaster2";
            this.btnFaster2.Size = new System.Drawing.Size(75, 23);
            this.btnFaster2.TabIndex = 4;
            this.btnFaster2.Text = ">>>";
            this.btnFaster2.UseVisualStyleBackColor = true;
            this.btnFaster2.Click += new System.EventHandler(this.btnFaster2_Click);
            // 
            // btnSlower2
            // 
            this.btnSlower2.Location = new System.Drawing.Point(0, 43);
            this.btnSlower2.Name = "btnSlower2";
            this.btnSlower2.Size = new System.Drawing.Size(75, 23);
            this.btnSlower2.TabIndex = 3;
            this.btnSlower2.Text = "<<<";
            this.btnSlower2.UseVisualStyleBackColor = true;
            this.btnSlower2.Click += new System.EventHandler(this.btnSlower2_Click);
            // 
            // btnDirection2
            // 
            this.btnDirection2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDirection2.Location = new System.Drawing.Point(148, 13);
            this.btnDirection2.Name = "btnDirection2";
            this.btnDirection2.Size = new System.Drawing.Size(75, 23);
            this.btnDirection2.TabIndex = 2;
            this.btnDirection2.Text = "dir: forward";
            this.btnDirection2.UseVisualStyleBackColor = true;
            this.btnDirection2.Click += new System.EventHandler(this.btnDirection2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Train2 address";
            // 
            // txtTrainAddress2
            // 
            this.txtTrainAddress2.Location = new System.Drawing.Point(0, 16);
            this.txtTrainAddress2.Name = "txtTrainAddress2";
            this.txtTrainAddress2.Size = new System.Drawing.Size(106, 20);
            this.txtTrainAddress2.TabIndex = 0;
            this.txtTrainAddress2.Text = "40";
            this.txtTrainAddress2.TextChanged += new System.EventHandler(this.txtTrainAddress2_TextChanged);
            // 
            // txtAcc1
            // 
            this.txtAcc1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtAcc1.Location = new System.Drawing.Point(10, 236);
            this.txtAcc1.Name = "txtAcc1";
            this.txtAcc1.Size = new System.Drawing.Size(107, 20);
            this.txtAcc1.TabIndex = 12;
            this.txtAcc1.Text = "101";
            this.txtAcc1.TextChanged += new System.EventHandler(this.txtAcc1_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Accessory1 ID";
            // 
            // btnSwitchAcc1
            // 
            this.btnSwitchAcc1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSwitchAcc1.Location = new System.Drawing.Point(10, 262);
            this.btnSwitchAcc1.Name = "btnSwitchAcc1";
            this.btnSwitchAcc1.Size = new System.Drawing.Size(75, 23);
            this.btnSwitchAcc1.TabIndex = 14;
            this.btnSwitchAcc1.Text = "Switch";
            this.btnSwitchAcc1.UseVisualStyleBackColor = true;
            this.btnSwitchAcc1.Click += new System.EventHandler(this.btnSwitchAcc1_Click);
            // 
            // btnSwitchAcc2
            // 
            this.btnSwitchAcc2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSwitchAcc2.Location = new System.Drawing.Point(426, 262);
            this.btnSwitchAcc2.Name = "btnSwitchAcc2";
            this.btnSwitchAcc2.Size = new System.Drawing.Size(75, 23);
            this.btnSwitchAcc2.TabIndex = 17;
            this.btnSwitchAcc2.Text = "Switch";
            this.btnSwitchAcc2.UseVisualStyleBackColor = true;
            this.btnSwitchAcc2.Click += new System.EventHandler(this.btnSwitchAcc2_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(425, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Accessory2 ID";
            // 
            // txtAcc2
            // 
            this.txtAcc2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAcc2.Location = new System.Drawing.Point(394, 236);
            this.txtAcc2.Name = "txtAcc2";
            this.txtAcc2.Size = new System.Drawing.Size(107, 20);
            this.txtAcc2.TabIndex = 15;
            this.txtAcc2.Text = "102";
            this.txtAcc2.TextChanged += new System.EventHandler(this.txtAcc2_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 366);
            this.Controls.Add(this.btnSwitchAcc2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAcc2);
            this.Controls.Add(this.btnSwitchAcc1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAcc1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.sendbtn);
            this.Controls.Add(this.textboxInput);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(530, 400);
            this.Name = "Form1";
            this.Text = "Train controller";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textboxInput;
        private System.Windows.Forms.Button sendbtn;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTrainAddress1;
        private System.Windows.Forms.Label lblSpeed1;
        private System.Windows.Forms.Button btnFaster1;
        private System.Windows.Forms.Button btnSlower1;
        private System.Windows.Forms.Button btnDirection1;
        private System.Windows.Forms.Button btnSound1;
        private System.Windows.Forms.Button btn2ndHorn1;
        private System.Windows.Forms.Button btn1stHorn1;
        private System.Windows.Forms.Button btnBell1;
        private System.Windows.Forms.Button btnLights1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSound2;
        private System.Windows.Forms.Button btn2ndHorn2;
        private System.Windows.Forms.Button btn1stHorn2;
        private System.Windows.Forms.Button btnBell2;
        private System.Windows.Forms.Button btnLights2;
        private System.Windows.Forms.Label lblSpeed2;
        private System.Windows.Forms.Button btnFaster2;
        private System.Windows.Forms.Button btnSlower2;
        private System.Windows.Forms.Button btnDirection2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTrainAddress2;
        private System.Windows.Forms.Button btnEStop1;
        private System.Windows.Forms.Button btnEStop2;
        private System.Windows.Forms.TextBox txtAcc1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSwitchAcc1;
        private System.Windows.Forms.Button btnSwitchAcc2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAcc2;
    }
}