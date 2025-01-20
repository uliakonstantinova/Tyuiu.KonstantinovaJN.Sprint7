
namespace Tyuiu.KonstantinovaJN.Sprint7.Project.V9
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            pictureBoxAvatar_KJN = new PictureBox();
            labelInfo_KJN = new Label();
            buttonOk_KJN = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_KJN).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxAvatar_KJN
            // 
            pictureBoxAvatar_KJN.BackgroundImage = (Image)resources.GetObject("pictureBoxAvatar_KJN.BackgroundImage");
            pictureBoxAvatar_KJN.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxAvatar_KJN.Location = new Point(12, 12);
            pictureBoxAvatar_KJN.Name = "pictureBoxAvatar_KJN";
            pictureBoxAvatar_KJN.Size = new Size(158, 196);
            pictureBoxAvatar_KJN.TabIndex = 0;
            pictureBoxAvatar_KJN.TabStop = false;
            pictureBoxAvatar_KJN.Click += pictureBoxAvatar_Click;
            // 
            // labelInfo_KJN
            // 
            labelInfo_KJN.AutoSize = true;
            labelInfo_KJN.Location = new Point(176, 12);
            labelInfo_KJN.Name = "labelInfo_KJN";
            labelInfo_KJN.Size = new Size(395, 180);
            labelInfo_KJN.TabIndex = 1;
            labelInfo_KJN.Text = resources.GetString("labelInfo_KJN.Text");
            // 
            // buttonOk_KJN
            // 
            buttonOk_KJN.BackColor = SystemColors.ButtonFace;
            buttonOk_KJN.FlatStyle = FlatStyle.Flat;
            buttonOk_KJN.Location = new Point(464, 201);
            buttonOk_KJN.Name = "buttonOk_KJN";
            buttonOk_KJN.Size = new Size(89, 29);
            buttonOk_KJN.TabIndex = 2;
            buttonOk_KJN.Text = "Ок";
            buttonOk_KJN.UseVisualStyleBackColor = false;
            buttonOk_KJN.Click += buttonOk_KJN_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 242);
            Controls.Add(buttonOk_KJN);
            Controls.Add(labelInfo_KJN);
            Controls.Add(pictureBoxAvatar_KJN);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_KJN).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void pictureBoxAvatar_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private PictureBox pictureBoxAvatar_KJN;
        private Label labelInfo_KJN;
        private Button buttonOk_KJN;
    }
}