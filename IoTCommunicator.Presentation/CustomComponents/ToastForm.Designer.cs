namespace IoTCommunicator.Presentation.CustomComponents
{
    partial class ToastForm
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
            components = new System.ComponentModel.Container();
            panel_ToastColor = new Panel();
            pictureBox_Toast = new PictureBox();
            label_ToastType = new Label();
            label_ToastMessage = new Label();
            timer_Toast = new System.Windows.Forms.Timer(components);
            timer_ToastHide = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox_Toast).BeginInit();
            SuspendLayout();
            // 
            // panel_ToastColor
            // 
            panel_ToastColor.BackColor = Color.White;
            panel_ToastColor.Location = new Point(-10, -3);
            panel_ToastColor.Name = "panel_ToastColor";
            panel_ToastColor.Size = new Size(19, 62);
            panel_ToastColor.TabIndex = 0;
            // 
            // pictureBox_Toast
            // 
            pictureBox_Toast.Location = new Point(22, 17);
            pictureBox_Toast.Name = "pictureBox_Toast";
            pictureBox_Toast.Size = new Size(25, 25);
            pictureBox_Toast.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_Toast.TabIndex = 1;
            pictureBox_Toast.TabStop = false;
            // 
            // label_ToastType
            // 
            label_ToastType.AutoSize = true;
            label_ToastType.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label_ToastType.Location = new Point(60, 9);
            label_ToastType.Name = "label_ToastType";
            label_ToastType.Size = new Size(42, 20);
            label_ToastType.TabIndex = 2;
            label_ToastType.Text = "Type";
            // 
            // label_ToastMessage
            // 
            label_ToastMessage.AutoSize = true;
            label_ToastMessage.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label_ToastMessage.Location = new Point(62, 31);
            label_ToastMessage.Name = "label_ToastMessage";
            label_ToastMessage.Size = new Size(96, 17);
            label_ToastMessage.TabIndex = 3;
            label_ToastMessage.Text = "Toast Message";
            // 
            // timer_Toast
            // 
            timer_Toast.Enabled = true;
            timer_Toast.Interval = 10;
            timer_Toast.Tick += timer_Toast_Tick;
            // 
            // timer_ToastHide
            // 
            timer_ToastHide.Interval = 15;
            timer_ToastHide.Tick += timer_ToastHide_Tick;
            // 
            // ToastForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 59);
            Controls.Add(label_ToastMessage);
            Controls.Add(label_ToastType);
            Controls.Add(pictureBox_Toast);
            Controls.Add(panel_ToastColor);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ToastForm";
            Text = "ToastForm";
            Load += ToastForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox_Toast).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel_ToastColor;
        private PictureBox pictureBox_Toast;
        private Label label_ToastType;
        private Label label_ToastMessage;
        private System.Windows.Forms.Timer timer_Toast;
        private System.Windows.Forms.Timer timer_ToastHide;
    }
}