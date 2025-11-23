namespace HesapMakineApp
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnKok = new System.Windows.Forms.Button();
            this.btnNokta = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnEsittir = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnBackSpace = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.btnArti = new System.Windows.Forms.Button();
            this.btnEksi = new System.Windows.Forms.Button();
            this.btnCarpi = new System.Windows.Forms.Button();
            this.btnBolu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKok
            // 
            this.btnKok.Location = new System.Drawing.Point(12, 305);
            this.btnKok.Name = "btnKok";
            this.btnKok.Size = new System.Drawing.Size(57, 70);
            this.btnKok.TabIndex = 0;
            this.btnKok.Text = "√";
            this.btnKok.UseVisualStyleBackColor = true;
            this.btnKok.Click += new System.EventHandler(this.btnKok_Click);
            // 
            // btnNokta
            // 
            this.btnNokta.Location = new System.Drawing.Point(75, 305);
            this.btnNokta.Name = "btnNokta";
            this.btnNokta.Size = new System.Drawing.Size(57, 70);
            this.btnNokta.TabIndex = 1;
            this.btnNokta.Text = ".";
            this.btnNokta.UseVisualStyleBackColor = true;
            this.btnNokta.Click += new System.EventHandler(this.btnVirgul_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(138, 305);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(57, 70);
            this.btn0.TabIndex = 2;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.Buttonlar);
            // 
            // btnEsittir
            // 
            this.btnEsittir.Location = new System.Drawing.Point(264, 229);
            this.btnEsittir.Name = "btnEsittir";
            this.btnEsittir.Size = new System.Drawing.Size(57, 146);
            this.btnEsittir.TabIndex = 3;
            this.btnEsittir.Text = "=";
            this.btnEsittir.UseVisualStyleBackColor = true;
            this.btnEsittir.Click += new System.EventHandler(this.btnEsittir_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(138, 229);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(57, 70);
            this.btn3.TabIndex = 5;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.Buttonlar);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(75, 229);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(57, 70);
            this.btn2.TabIndex = 6;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.Buttonlar);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(12, 229);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(57, 70);
            this.btn1.TabIndex = 7;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.Buttonlar);
            // 
            // btnBackSpace
            // 
            this.btnBackSpace.Location = new System.Drawing.Point(264, 153);
            this.btnBackSpace.Name = "btnBackSpace";
            this.btnBackSpace.Size = new System.Drawing.Size(57, 70);
            this.btnBackSpace.TabIndex = 8;
            this.btnBackSpace.Text = "<=";
            this.btnBackSpace.UseVisualStyleBackColor = true;
            this.btnBackSpace.Click += new System.EventHandler(this.btnBackSpace_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(138, 153);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(57, 70);
            this.btn6.TabIndex = 9;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.Buttonlar);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(75, 153);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(57, 70);
            this.btn5.TabIndex = 10;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.Buttonlar);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(12, 153);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(57, 70);
            this.btn4.TabIndex = 11;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.Buttonlar);
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(264, 77);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(57, 70);
            this.btnC.TabIndex = 12;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(138, 77);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(57, 70);
            this.btn9.TabIndex = 13;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.Buttonlar);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(75, 77);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(57, 70);
            this.btn8.TabIndex = 14;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.Buttonlar);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(12, 77);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(57, 70);
            this.btn7.TabIndex = 15;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.Buttonlar);
            // 
            // txtDisplay
            // 
            this.txtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDisplay.Location = new System.Drawing.Point(12, 12);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(309, 49);
            this.txtDisplay.TabIndex = 16;
            this.txtDisplay.Text = "0";
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnArti
            // 
            this.btnArti.Location = new System.Drawing.Point(201, 305);
            this.btnArti.Name = "btnArti";
            this.btnArti.Size = new System.Drawing.Size(57, 70);
            this.btnArti.TabIndex = 17;
            this.btnArti.Text = "+";
            this.btnArti.UseVisualStyleBackColor = true;
            this.btnArti.Click += new System.EventHandler(this.btnArti_Click);
            // 
            // btnEksi
            // 
            this.btnEksi.Location = new System.Drawing.Point(201, 229);
            this.btnEksi.Name = "btnEksi";
            this.btnEksi.Size = new System.Drawing.Size(57, 70);
            this.btnEksi.TabIndex = 18;
            this.btnEksi.Text = "-";
            this.btnEksi.UseVisualStyleBackColor = true;
            this.btnEksi.Click += new System.EventHandler(this.btnEksi_Click);
            // 
            // btnCarpi
            // 
            this.btnCarpi.Location = new System.Drawing.Point(201, 153);
            this.btnCarpi.Name = "btnCarpi";
            this.btnCarpi.Size = new System.Drawing.Size(57, 70);
            this.btnCarpi.TabIndex = 19;
            this.btnCarpi.Text = "*";
            this.btnCarpi.UseVisualStyleBackColor = true;
            this.btnCarpi.Click += new System.EventHandler(this.btnCarpi_Click);
            // 
            // btnBolu
            // 
            this.btnBolu.Location = new System.Drawing.Point(201, 77);
            this.btnBolu.Name = "btnBolu";
            this.btnBolu.Size = new System.Drawing.Size(57, 70);
            this.btnBolu.TabIndex = 20;
            this.btnBolu.Text = "/";
            this.btnBolu.UseVisualStyleBackColor = true;
            this.btnBolu.Click += new System.EventHandler(this.btnBolu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 385);
            this.Controls.Add(this.btnBolu);
            this.Controls.Add(this.btnCarpi);
            this.Controls.Add(this.btnEksi);
            this.Controls.Add(this.btnArti);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btnBackSpace);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btnEsittir);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnNokta);
            this.Controls.Add(this.btnKok);
            this.Name = "Form1";
            this.Text = "Hesap Makinesi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKok;
        private System.Windows.Forms.Button btnNokta;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnEsittir;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnBackSpace;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button btnArti;
        private System.Windows.Forms.Button btnEksi;
        private System.Windows.Forms.Button btnCarpi;
        private System.Windows.Forms.Button btnBolu;
    }
}

