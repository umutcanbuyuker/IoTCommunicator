namespace IoTCommunicator.Presentation.Forms
{
    partial class MainForm
    {


        private System.Windows.Forms.Timer timerDoorStatus;
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
            timerDoorStatus = new System.Windows.Forms.Timer(components);
            btn_getAiData = new Button();
            listAiValues = new ListBox();
            listDiValues = new ListBox();
            btn_getDiData = new Button();
            lbl_DoorStatus = new Label();
            panel_DoorStatus = new Panel();
            SuspendLayout();
            // 
            // timerDoorStatus
            // 
            timerDoorStatus.Interval = 5000;
            timerDoorStatus.Tick += timerDoorStatus_Tick;
            // 
            // btn_getAiData
            // 
            btn_getAiData.Location = new Point(12, 13);
            btn_getAiData.Margin = new Padding(3, 4, 3, 4);
            btn_getAiData.Name = "btn_getAiData";
            btn_getAiData.Size = new Size(125, 31);
            btn_getAiData.TabIndex = 0;
            btn_getAiData.Text = "Tako Veri Getir";
            btn_getAiData.UseVisualStyleBackColor = true;
            btn_getAiData.Click += btnFetchAiData_Click;
            // 
            // listAiValues
            // 
            listAiValues.FormattingEnabled = true;
            listAiValues.Location = new Point(12, 51);
            listAiValues.Name = "listAiValues";
            listAiValues.Size = new Size(150, 124);
            listAiValues.TabIndex = 1;
            // 
            // listDiValues
            // 
            listDiValues.FormattingEnabled = true;
            listDiValues.Location = new Point(179, 50);
            listDiValues.Name = "listDiValues";
            listDiValues.Size = new Size(150, 124);
            listDiValues.TabIndex = 2;
            // 
            // btn_getDiData
            // 
            btn_getDiData.Location = new Point(179, 15);
            btn_getDiData.Name = "btn_getDiData";
            btn_getDiData.Size = new Size(150, 29);
            btn_getDiData.TabIndex = 3;
            btn_getDiData.Text = "Switch Veri Getir";
            btn_getDiData.UseVisualStyleBackColor = true;
            btn_getDiData.Click += getDiData_Click;
            // 
            // lbl_DoorStatus
            // 
            lbl_DoorStatus.AutoSize = true;
            lbl_DoorStatus.Location = new Point(359, 19);
            lbl_DoorStatus.Name = "lbl_DoorStatus";
            lbl_DoorStatus.Size = new Size(0, 20);
            lbl_DoorStatus.TabIndex = 4;
            // 
            // panel_DoorStatus
            // 
            panel_DoorStatus.Location = new Point(359, 51);
            panel_DoorStatus.Name = "panel_DoorStatus";
            panel_DoorStatus.Size = new Size(250, 123);
            panel_DoorStatus.TabIndex = 5;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(panel_DoorStatus);
            Controls.Add(lbl_DoorStatus);
            Controls.Add(btn_getDiData);
            Controls.Add(listDiValues);
            Controls.Add(listAiValues);
            Controls.Add(btn_getAiData);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_getAiData;
        private ListBox listAiValues;
        private ListBox listDiValues;
        private Button btn_getDiData;
        private Label lbl_DoorStatus;
        private Panel panel_DoorStatus;
    }
}