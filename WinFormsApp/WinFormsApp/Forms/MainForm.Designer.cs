namespace WinFormsApp.Forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            btnCounter = new Button();
            lblCounter = new Label();
            SuspendLayout();
            // 
            // btnCounter
            // 
            btnCounter.Location = new Point(12, 91);
            btnCounter.Name = "btnCounter";
            btnCounter.Size = new Size(179, 71);
            btnCounter.TabIndex = 0;
            btnCounter.Text = "button1";
            btnCounter.UseVisualStyleBackColor = true;
            btnCounter.Click += btnCounter_Click;
            // 
            // lblCounter
            // 
            lblCounter.AutoSize = true;
            lblCounter.Location = new Point(12, 57);
            lblCounter.Name = "lblCounter";
            lblCounter.Size = new Size(38, 15);
            lblCounter.TabIndex = 1;
            lblCounter.Text = "label1";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblCounter);
            Controls.Add(btnCounter);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Главное окно приложения";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCounter;
        private Label lblCounter;
    }
}