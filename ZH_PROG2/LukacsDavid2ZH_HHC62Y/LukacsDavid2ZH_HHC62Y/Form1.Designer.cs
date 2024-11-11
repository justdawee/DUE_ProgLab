namespace LukacsDavid2ZH_HHC62Y
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
            this.trackBar_size = new System.Windows.Forms.TrackBar();
            this.txtBox_numbers = new System.Windows.Forms.TextBox();
            this.lbl_hanyados = new System.Windows.Forms.Label();
            this.lbl_size = new System.Windows.Forms.Label();
            this.lbl_hibas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_size)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBar_size
            // 
            this.trackBar_size.Location = new System.Drawing.Point(12, 331);
            this.trackBar_size.Maximum = 200;
            this.trackBar_size.Minimum = 10;
            this.trackBar_size.Name = "trackBar_size";
            this.trackBar_size.Size = new System.Drawing.Size(427, 45);
            this.trackBar_size.TabIndex = 0;
            this.trackBar_size.Value = 10;
            // 
            // txtBox_numbers
            // 
            this.txtBox_numbers.Location = new System.Drawing.Point(310, 305);
            this.txtBox_numbers.Name = "txtBox_numbers";
            this.txtBox_numbers.Size = new System.Drawing.Size(129, 20);
            this.txtBox_numbers.TabIndex = 1;
            // 
            // lbl_hanyados
            // 
            this.lbl_hanyados.Location = new System.Drawing.Point(160, 303);
            this.lbl_hanyados.Name = "lbl_hanyados";
            this.lbl_hanyados.Size = new System.Drawing.Size(144, 23);
            this.lbl_hanyados.TabIndex = 2;
            this.lbl_hanyados.Text = "Átló hányadosa [0; 1]:";
            this.lbl_hanyados.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_size
            // 
            this.lbl_size.Location = new System.Drawing.Point(12, 356);
            this.lbl_size.Name = "lbl_size";
            this.lbl_size.Size = new System.Drawing.Size(100, 23);
            this.lbl_size.TabIndex = 3;
            this.lbl_size.Text = "Ellipszis nagysága";
            this.lbl_size.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lbl_hibas
            // 
            this.lbl_hibas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hibas.ForeColor = System.Drawing.Color.Red;
            this.lbl_hibas.Location = new System.Drawing.Point(12, 9);
            this.lbl_hibas.Name = "lbl_hibas";
            this.lbl_hibas.Size = new System.Drawing.Size(427, 293);
            this.lbl_hibas.TabIndex = 4;
            this.lbl_hibas.Text = "HIBÁS ÁTLÓ!\r\n\r\nAz átló hányadosának 0 és 1 közötti\r\nszámnak kell legyen!\r\n(Példáu" + "l: 0,5)";
            this.lbl_hibas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_hibas.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 388);
            this.Controls.Add(this.lbl_hibas);
            this.Controls.Add(this.lbl_size);
            this.Controls.Add(this.lbl_hanyados);
            this.Controls.Add(this.txtBox_numbers);
            this.Controls.Add(this.trackBar_size);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Ellipszis";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_size)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lbl_hibas;

        private System.Windows.Forms.Label lbl_size;

        private System.Windows.Forms.Label lbl_hanyados;

        private System.Windows.Forms.TextBox txtBox_numbers;

        private System.Windows.Forms.TrackBar trackBar_size;

        #endregion
    }
}