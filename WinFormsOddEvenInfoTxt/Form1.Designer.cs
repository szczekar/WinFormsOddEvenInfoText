namespace WinFormsOddEvenInfoTxt
{
    partial class OddEvenInfoText
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.inputNumber = new System.Windows.Forms.TextBox();
            this.buttonTxtInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(327, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Put the number below";
            // 
            // inputNumber
            // 
            this.inputNumber.Location = new System.Drawing.Point(326, 154);
            this.inputNumber.Name = "inputNumber";
            this.inputNumber.Size = new System.Drawing.Size(111, 20);
            this.inputNumber.TabIndex = 1;
            // 
            // buttonTxtInfo
            // 
            this.buttonTxtInfo.Location = new System.Drawing.Point(300, 220);
            this.buttonTxtInfo.Name = "buttonTxtInfo";
            this.buttonTxtInfo.Size = new System.Drawing.Size(168, 23);
            this.buttonTxtInfo.TabIndex = 2;
            this.buttonTxtInfo.Text = "Save answer in file";
            this.buttonTxtInfo.UseVisualStyleBackColor = true;
            this.buttonTxtInfo.Click += new System.EventHandler(this.buttonTxtInfo_Click);
            // 
            // OddEvenInfoText
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonTxtInfo);
            this.Controls.Add(this.inputNumber);
            this.Controls.Add(this.label1);
            this.Name = "OddEvenInfoText";
            this.Text = "OddEvenInfoText";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputNumber;
        private System.Windows.Forms.Button buttonTxtInfo;
    }
}

