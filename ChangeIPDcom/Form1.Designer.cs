namespace ChangeIPDcom
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btn_GetDevice = new Button();
            btn_ChangeIP = new Button();
            cb_ListDevice = new ComboBox();
            data_ListDevice = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)data_ListDevice).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(127, 22);
            label1.Name = "label1";
            label1.Size = new Size(89, 21);
            label1.TabIndex = 0;
            label1.Text = "IP Changer";
            // 
            // btn_GetDevice
            // 
            btn_GetDevice.Location = new Point(21, 66);
            btn_GetDevice.Name = "btn_GetDevice";
            btn_GetDevice.Size = new Size(75, 23);
            btn_GetDevice.TabIndex = 1;
            btn_GetDevice.Text = "Get Device";
            btn_GetDevice.UseVisualStyleBackColor = true;
            btn_GetDevice.Click += btn_GetDevice_Click;
            // 
            // btn_ChangeIP
            // 
            btn_ChangeIP.Location = new Point(255, 66);
            btn_ChangeIP.Name = "btn_ChangeIP";
            btn_ChangeIP.Size = new Size(75, 23);
            btn_ChangeIP.TabIndex = 2;
            btn_ChangeIP.Text = "ChangeIP";
            btn_ChangeIP.UseVisualStyleBackColor = true;
            btn_ChangeIP.Click += btn_ChangeIP_Click;
            // 
            // cb_ListDevice
            // 
            cb_ListDevice.FormattingEnabled = true;
            cb_ListDevice.Location = new Point(21, 121);
            cb_ListDevice.Name = "cb_ListDevice";
            cb_ListDevice.Size = new Size(309, 23);
            cb_ListDevice.TabIndex = 3;
            // 
            // data_ListDevice
            // 
            data_ListDevice.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_ListDevice.Location = new Point(21, 165);
            data_ListDevice.Name = "data_ListDevice";
            data_ListDevice.RowTemplate.Height = 25;
            data_ListDevice.Size = new Size(309, 150);
            data_ListDevice.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(355, 352);
            Controls.Add(data_ListDevice);
            Controls.Add(cb_ListDevice);
            Controls.Add(btn_ChangeIP);
            Controls.Add(btn_GetDevice);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "IP Changer";
            ((System.ComponentModel.ISupportInitialize)data_ListDevice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_GetDevice;
        private Button btn_ChangeIP;
        private ComboBox cb_ListDevice;
        private DataGridView data_ListDevice;
    }
}