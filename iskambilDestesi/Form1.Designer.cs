namespace iskambilDestesi
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
            desteListbox = new ListBox();
            olusturButton = new Button();
            SuspendLayout();
            // 
            // desteListbox
            // 
            desteListbox.FormattingEnabled = true;
            desteListbox.ItemHeight = 21;
            desteListbox.Location = new Point(71, 78);
            desteListbox.Margin = new Padding(4, 4, 4, 4);
            desteListbox.Name = "desteListbox";
            desteListbox.Size = new Size(294, 319);
            desteListbox.TabIndex = 0;
            // 
            // olusturButton
            // 
            olusturButton.Location = new Point(71, 428);
            olusturButton.Name = "olusturButton";
            olusturButton.Size = new Size(294, 33);
            olusturButton.TabIndex = 1;
            olusturButton.Text = "Deste Oluştur";
            olusturButton.UseVisualStyleBackColor = true;
            olusturButton.Click += olusturButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 614);
            Controls.Add(olusturButton);
            Controls.Add(desteListbox);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox desteListbox;
        private Button olusturButton;
    }
}