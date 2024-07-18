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
            panel3 = new Panel();
            listInputValues = new ListBox();
            panel4 = new Panel();
            panel9 = new Panel();
            pictureBox_TakoLine = new PictureBox();
            pictureBox_TakoPeak = new PictureBox();
            label3 = new Label();
            panel8 = new Panel();
            textBox_TakoValue = new TextBox();
            label2 = new Label();
            panel7 = new Panel();
            pictureBox_SwitchOn = new PictureBox();
            pictureBox_SwitchOff = new PictureBox();
            lbl_SwitchStatusText = new Label();
            panel6 = new Panel();
            pictureBox_DoorOff = new PictureBox();
            pictureBox_DoorOn = new PictureBox();
            sideBarContainer = new FlowLayoutPanel();
            panel2 = new Panel();
            label1 = new Label();
            menuButton = new PictureBox();
            panel1 = new Panel();
            button_Home = new Button();
            panel5 = new Panel();
            button2 = new Button();
            sideBarTimer = new System.Windows.Forms.Timer(components);
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_TakoLine).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_TakoPeak).BeginInit();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_SwitchOn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_SwitchOff).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_DoorOff).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_DoorOn).BeginInit();
            sideBarContainer.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menuButton).BeginInit();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // timerStatus
            // 
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
            btn_getAiData.Click += getAiData_Click;
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
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(50, 55, 60);
            panel3.Controls.Add(listInputValues);
            panel3.Controls.Add(btn_getAiData);
            panel3.Controls.Add(btn_getDiData);
            panel3.Location = new Point(239, 82);
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
            panel4.BackColor = Color.FromArgb(50, 55, 60);
            panel4.Controls.Add(panel9);
            panel4.Controls.Add(panel8);
            panel4.Controls.Add(panel7);
            panel4.Controls.Add(panel6);
            panel4.Location = new Point(593, 82);
            panel4.Name = "panel4";
            panel4.Size = new Size(333, 216);
            panel4.TabIndex = 11;
            // 
            // panel9
            // 
            panel9.BackColor = Color.White;
            panel9.Controls.Add(pictureBox_TakoLine);
            panel9.Controls.Add(pictureBox_TakoPeak);
            panel9.Controls.Add(label3);
            panel9.Location = new Point(51, 161);
            panel9.Name = "panel9";
            panel9.Size = new Size(230, 45);
            panel9.TabIndex = 15;
            // 
            // pictureBox_TakoLine
            // 
            pictureBox_TakoLine.Image = Properties.Resources.icons8_line_251;
            pictureBox_TakoLine.Location = new Point(135, 0);
            pictureBox_TakoLine.Name = "pictureBox_TakoLine";
            pictureBox_TakoLine.Size = new Size(66, 45);
            pictureBox_TakoLine.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_TakoLine.TabIndex = 13;
            pictureBox_TakoLine.TabStop = false;
            // 
            // pictureBox_TakoPeak
            // 
            pictureBox_TakoPeak.Image = Properties.Resources.icons8_bounce_up_25;
            pictureBox_TakoPeak.Location = new Point(135, 0);
            pictureBox_TakoPeak.Name = "pictureBox_TakoPeak";
            pictureBox_TakoPeak.Size = new Size(66, 45);
            pictureBox_TakoPeak.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_TakoPeak.TabIndex = 13;
            pictureBox_TakoPeak.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 13);
            label3.Name = "label3";
            label3.Size = new Size(91, 20);
            label3.TabIndex = 12;
            label3.Text = "Tako Digital:";
            // 
            // panel8
            // 
            panel8.BackColor = Color.White;
            panel8.Controls.Add(textBox_TakoValue);
            panel8.Controls.Add(label2);
            panel8.Location = new Point(51, 110);
            panel8.Name = "panel8";
            panel8.Size = new Size(230, 45);
            panel8.TabIndex = 15;
            // 
            // textBox_TakoValue
            // 
            textBox_TakoValue.Location = new Point(135, 10);
            textBox_TakoValue.Name = "textBox_TakoValue";
            textBox_TakoValue.Size = new Size(66, 27);
            textBox_TakoValue.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 13);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 12;
            label2.Text = "Tako:";
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
            lbl_SwitchStatusText.Location = new Point(9, 13);
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
            // sideBarContainer
            // 
            sideBarContainer.BackColor = Color.FromArgb(35, 40, 45);
            sideBarContainer.Controls.Add(panel2);
            sideBarContainer.Controls.Add(panel1);
            sideBarContainer.Controls.Add(panel5);
            sideBarContainer.Dock = DockStyle.Left;
            sideBarContainer.Location = new Point(0, 0);
            sideBarContainer.MaximumSize = new Size(223, 622);
            sideBarContainer.MinimumSize = new Size(60, 622);
            sideBarContainer.Name = "sideBarContainer";
            sideBarContainer.Size = new Size(223, 622);
            sideBarContainer.TabIndex = 12;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(menuButton);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 80);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(57, 29);
            label1.Name = "label1";
            label1.Size = new Size(62, 28);
            label1.TabIndex = 15;
            label1.Text = "Menu";
            // 
            // menuButton
            // 
            menuButton.Cursor = Cursors.Hand;
            menuButton.Image = Properties.Resources.full_m2i8i8A0K9A0H7b1;
            menuButton.Location = new Point(14, 29);
            menuButton.Name = "menuButton";
            menuButton.Size = new Size(25, 25);
            menuButton.SizeMode = PictureBoxSizeMode.StretchImage;
            menuButton.TabIndex = 14;
            menuButton.TabStop = false;
            menuButton.Click += menuButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(button_Home);
            panel1.Location = new Point(3, 89);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 57);
            panel1.TabIndex = 14;
            // 
            // button_Home
            // 
            button_Home.BackColor = Color.FromArgb(35, 40, 45);
            button_Home.Cursor = Cursors.Hand;
            button_Home.FlatStyle = FlatStyle.Flat;
            button_Home.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button_Home.ForeColor = Color.White;
            button_Home.Image = Properties.Resources.icons8_dashboard_24;
            button_Home.ImageAlign = ContentAlignment.MiddleLeft;
            button_Home.Location = new Point(-4, -7);
            button_Home.Name = "button_Home";
            button_Home.Padding = new Padding(13, 0, 0, 0);
            button_Home.Size = new Size(234, 74);
            button_Home.TabIndex = 13;
            button_Home.Text = "         Anasayfa";
            button_Home.TextAlign = ContentAlignment.MiddleLeft;
            button_Home.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Gray;
            panel5.Controls.Add(button2);
            panel5.ForeColor = SystemColors.ControlText;
            panel5.Location = new Point(3, 152);
            panel5.Name = "panel5";
            panel5.Size = new Size(230, 64);
            panel5.TabIndex = 14;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(35, 40, 45);
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button2.ForeColor = Color.White;
            button2.Image = Properties.Resources.icons8_settings_25__1_;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(-4, -8);
            button2.Name = "button2";
            button2.Padding = new Padding(13, 0, 0, 0);
            button2.Size = new Size(231, 82);
            button2.TabIndex = 13;
            button2.Text = "         Ayarlar";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            // 
            // sideBarTimer
            // 
            sideBarTimer.Interval = 10;
            sideBarTimer.Tick += sideBarTimer_Tick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1149, 622);
            Controls.Add(sideBarContainer);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TrainInfo System";
            Load += MainForm_Load;
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_TakoLine).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_TakoPeak).EndInit();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_SwitchOn).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_SwitchOff).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_DoorOff).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_DoorOn).EndInit();
            sideBarContainer.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)menuButton).EndInit();
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btn_getAiData;
        private ListBox listAiValues;
        private ListBox listDiValues;
        private Button btn_getDiData;
        private Label lbl_DoorStatusText;
        private Panel panel3;
        private ListBox listInputValues;
        private Panel panel4;
        private Label lbl_SwitchStatusText;
        private Panel panel7;
        private Panel panel6;
        private PictureBox pictureBox_SwitchOn;
        private PictureBox pictureBox_SwitchOff;
        private PictureBox pictureBox_DoorOff;
        private PictureBox pictureBox_DoorOn;
        private CheckedListBox checkedListBox1;
        private FlowLayoutPanel sideBarContainer;
        private Panel panel2;
        private Panel panel1;
        private Button button2;
        private PictureBox menuButton;
        private Label label1;
        private System.Windows.Forms.Timer sideBarTimer;
        private Panel panel5;
        private Panel panel8;
        private Label label2;
        private Button button_Home;
        private TextBox textBox_TakoValue;
        private Panel panel9;
        private Label label3;
        private PictureBox pictureBox_TakoPeak;
        private PictureBox pictureBox_TakoLine;
    }
}