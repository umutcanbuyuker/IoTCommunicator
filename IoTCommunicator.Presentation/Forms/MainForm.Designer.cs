namespace IoTCommunicator.Presentation.Forms
{
    partial class MainForm
    {


        private System.Windows.Forms.Timer timerStatus;
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
            components = new System.ComponentModel.Container();
            timerStatus = new System.Windows.Forms.Timer(components);
            btn_getAiData = new Button();
            btn_getDiData = new Button();
            lbl_DoorStatusText = new Label();
            panel1 = new Panel();
            panel5 = new Panel();
            lbl_PageText = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            listInputValues = new ListBox();
            panel4 = new Panel();
            panel7 = new Panel();
            pictureBox_SwitchOn = new PictureBox();
            pictureBox_SwitchOff = new PictureBox();
            lbl_SwitchStatusText = new Label();
            panel6 = new Panel();
            pictureBox_DoorOn = new PictureBox();
            pictureBox_DoorOff = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_SwitchOn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_SwitchOff).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_DoorOn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_DoorOff).BeginInit();
            SuspendLayout();
            // 
            // timerStatus
            // 
            timerStatus.Interval = 5000;
            timerStatus.Tick += timerStatus_Tick;
            // 
            // btn_getAiData
            // 
            btn_getAiData.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_getAiData.Location = new Point(28, 12);
            btn_getAiData.Margin = new Padding(3, 4, 3, 4);
            btn_getAiData.Name = "btn_getAiData";
            btn_getAiData.Size = new Size(103, 40);
            btn_getAiData.TabIndex = 0;
            btn_getAiData.Text = "Tako Veri Getir";
            btn_getAiData.UseVisualStyleBackColor = true;
            btn_getAiData.Click += btnFetchAiData_Click;
            // 
            // btn_getDiData
            // 
            btn_getDiData.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_getDiData.Location = new Point(28, 59);
            btn_getDiData.Name = "btn_getDiData";
            btn_getDiData.Size = new Size(103, 41);
            btn_getDiData.TabIndex = 3;
            btn_getDiData.Text = "Switch Veri Getir";
            btn_getDiData.UseVisualStyleBackColor = true;
            btn_getDiData.Click += getDiData_Click;
            // 
            // lbl_DoorStatusText
            // 
            lbl_DoorStatusText.AutoSize = true;
            lbl_DoorStatusText.Location = new Point(9, 14);
            lbl_DoorStatusText.Name = "lbl_DoorStatusText";
            lbl_DoorStatusText.Size = new Size(103, 20);
            lbl_DoorStatusText.TabIndex = 4;
            lbl_DoorStatusText.Text = "Kapı Durumu: ";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(40, 86, 182);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(lbl_PageText);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1149, 63);
            panel1.TabIndex = 7;
            // 
            // panel5
            // 
            panel5.Location = new Point(3, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(8, 8);
            panel5.TabIndex = 0;
            // 
            // lbl_PageText
            // 
            lbl_PageText.AutoSize = true;
            lbl_PageText.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lbl_PageText.ForeColor = Color.White;
            lbl_PageText.Location = new Point(68, 12);
            lbl_PageText.Name = "lbl_PageText";
            lbl_PageText.Size = new Size(138, 27);
            lbl_PageText.TabIndex = 8;
            lbl_PageText.Text = "Dashboard";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.full_m2i8i8A0K9A0H7b1;
            pictureBox1.Location = new Point(21, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 27);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(235, 239, 241);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 63);
            panel2.Name = "panel2";
            panel2.Size = new Size(206, 559);
            panel2.TabIndex = 9;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(235, 239, 241);
            panel3.Controls.Add(listInputValues);
            panel3.Controls.Add(btn_getAiData);
            panel3.Controls.Add(btn_getDiData);
            panel3.Location = new Point(229, 93);
            panel3.Name = "panel3";
            panel3.Size = new Size(333, 191);
            panel3.TabIndex = 10;
            // 
            // listInputValues
            // 
            listInputValues.FormattingEnabled = true;
            listInputValues.Location = new Point(151, 13);
            listInputValues.Name = "listInputValues";
            listInputValues.Size = new Size(164, 164);
            listInputValues.TabIndex = 11;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(235, 239, 241);
            panel4.Controls.Add(panel7);
            panel4.Controls.Add(panel6);
            panel4.Location = new Point(569, 93);
            panel4.Name = "panel4";
            panel4.Size = new Size(333, 191);
            panel4.TabIndex = 11;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Controls.Add(pictureBox_SwitchOn);
            panel7.Controls.Add(pictureBox_SwitchOff);
            panel7.Controls.Add(lbl_SwitchStatusText);
            panel7.Location = new Point(51, 59);
            panel7.Name = "panel7";
            panel7.Size = new Size(230, 45);
            panel7.TabIndex = 15;
            // 
            // pictureBox_SwitchOn
            // 
            pictureBox_SwitchOn.Image = Properties.Resources.switch_on;
            pictureBox_SwitchOn.Location = new Point(135, -3);
            pictureBox_SwitchOn.Name = "pictureBox_SwitchOn";
            pictureBox_SwitchOn.Size = new Size(66, 53);
            pictureBox_SwitchOn.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_SwitchOn.TabIndex = 13;
            pictureBox_SwitchOn.TabStop = false;
            // 
            // pictureBox_SwitchOff
            // 
            pictureBox_SwitchOff.Image = Properties.Resources.switch_off;
            pictureBox_SwitchOff.Location = new Point(135, -3);
            pictureBox_SwitchOff.Name = "pictureBox_SwitchOff";
            pictureBox_SwitchOff.Size = new Size(66, 53);
            pictureBox_SwitchOff.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_SwitchOff.TabIndex = 13;
            pictureBox_SwitchOff.TabStop = false;
            // 
            // lbl_SwitchStatusText
            // 
            lbl_SwitchStatusText.AutoSize = true;
            lbl_SwitchStatusText.Location = new Point(3, 13);
            lbl_SwitchStatusText.Name = "lbl_SwitchStatusText";
            lbl_SwitchStatusText.Size = new Size(112, 20);
            lbl_SwitchStatusText.TabIndex = 12;
            lbl_SwitchStatusText.Text = "Switch Durumu:";
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(pictureBox_DoorOff);
            panel6.Controls.Add(pictureBox_DoorOn);
            panel6.Controls.Add(lbl_DoorStatusText);
            panel6.Location = new Point(51, 8);
            panel6.Name = "panel6";
            panel6.Size = new Size(230, 45);
            panel6.TabIndex = 14;
            // 
            // pictureBox_DoorOn
            // 
            pictureBox_DoorOn.Image = Properties.Resources.switch_on;
            pictureBox_DoorOn.Location = new Point(135, -5);
            pictureBox_DoorOn.Name = "pictureBox_DoorOn";
            pictureBox_DoorOn.Size = new Size(66, 53);
            pictureBox_DoorOn.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_DoorOn.TabIndex = 13;
            pictureBox_DoorOn.TabStop = false;
            // 
            // pictureBox_DoorOff
            // 
            pictureBox_DoorOff.Image = Properties.Resources.switch_off;
            pictureBox_DoorOff.Location = new Point(135, -5);
            pictureBox_DoorOff.Name = "pictureBox_DoorOff";
            pictureBox_DoorOff.Size = new Size(66, 53);
            pictureBox_DoorOff.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_DoorOff.TabIndex = 13;
            pictureBox_DoorOff.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1149, 622);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TrainInfo System";
            WindowState = FormWindowState.Maximized;
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_SwitchOn).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_SwitchOff).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_DoorOn).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_DoorOff).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_getAiData;
        private ListBox listAiValues;
        private ListBox listDiValues;
        private Button btn_getDiData;
        private Label lbl_DoorStatusText;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label lbl_PageText;
        private Panel panel2;
        private Panel panel3;
        private ListBox listInputValues;
        private Panel panel4;
        private Label lbl_SwitchStatusText;
        private Panel panel5;
        private Panel panel7;
        private Panel panel6;
        private PictureBox pictureBox_SwitchOn;
        private PictureBox pictureBox_SwitchOff;
        private PictureBox pictureBox_DoorOff;
        private PictureBox pictureBox_DoorOn;
    }
}