namespace WindowsFormsApp1
{
    partial class foods
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnPopcornMinus = new System.Windows.Forms.Button();
            this.btnPopcornPlus = new System.Windows.Forms.Button();
            this.btnNachosMinus = new System.Windows.Forms.Button();
            this.btnNachosPlus = new System.Windows.Forms.Button();
            this.btnHotdogMinus = new System.Windows.Forms.Button();
            this.btnHotdogPlus = new System.Windows.Forms.Button();
            this.btnSoftdrinkMinus = new System.Windows.Forms.Button();
            this.btnSoftdrinkPlus = new System.Windows.Forms.Button();
            this.txtPopcornQty = new System.Windows.Forms.TextBox();
            this.txtNachosQty = new System.Windows.Forms.TextBox();
            this.txtHotdogQty = new System.Windows.Forms.TextBox();
            this.txtSoftdrinkQty = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuText;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(987, 113);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.Download_Cinema_movie_time_element_illustration_for_free;
            this.pictureBox1.Location = new System.Drawing.Point(45, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(105, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Snacks";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(172, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Popcorn ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(172, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nachos and Cheese";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(172, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 22);
            this.label5.TabIndex = 3;
            this.label5.Text = "Hotdog";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(172, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 22);
            this.label6.TabIndex = 4;
            this.label6.Text = "Softdrinks";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(80, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 22);
            this.label7.TabIndex = 5;
            this.label7.Text = "₱70";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(74, 174);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 22);
            this.label9.TabIndex = 7;
            this.label9.Text = " ₱90";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(80, 246);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 22);
            this.label10.TabIndex = 8;
            this.label10.Text = "₱60";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(80, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 22);
            this.label8.TabIndex = 6;
            this.label8.Text = "₱110";
            // 
            // btnPopcornMinus
            // 
            this.btnPopcornMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPopcornMinus.Location = new System.Drawing.Point(176, 26);
            this.btnPopcornMinus.Name = "btnPopcornMinus";
            this.btnPopcornMinus.Size = new System.Drawing.Size(37, 27);
            this.btnPopcornMinus.TabIndex = 9;
            this.btnPopcornMinus.Text = "-";
            this.btnPopcornMinus.UseVisualStyleBackColor = true;
            this.btnPopcornMinus.Click += new System.EventHandler(this.btnPopcornMinus_Click);
            // 
            // btnPopcornPlus
            // 
            this.btnPopcornPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnPopcornPlus.Location = new System.Drawing.Point(261, 26);
            this.btnPopcornPlus.Name = "btnPopcornPlus";
            this.btnPopcornPlus.Size = new System.Drawing.Size(37, 28);
            this.btnPopcornPlus.TabIndex = 11;
            this.btnPopcornPlus.Text = "+";
            this.btnPopcornPlus.UseVisualStyleBackColor = true;
            this.btnPopcornPlus.Click += new System.EventHandler(this.btnPopcornPlus_Click);
            // 
            // btnNachosMinus
            // 
            this.btnNachosMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnNachosMinus.Location = new System.Drawing.Point(176, 97);
            this.btnNachosMinus.Name = "btnNachosMinus";
            this.btnNachosMinus.Size = new System.Drawing.Size(37, 28);
            this.btnNachosMinus.TabIndex = 12;
            this.btnNachosMinus.Text = "-";
            this.btnNachosMinus.UseVisualStyleBackColor = true;
            this.btnNachosMinus.Click += new System.EventHandler(this.btnNachosMinus_Click);
            // 
            // btnNachosPlus
            // 
            this.btnNachosPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnNachosPlus.Location = new System.Drawing.Point(261, 97);
            this.btnNachosPlus.Name = "btnNachosPlus";
            this.btnNachosPlus.Size = new System.Drawing.Size(37, 28);
            this.btnNachosPlus.TabIndex = 13;
            this.btnNachosPlus.Text = "+";
            this.btnNachosPlus.UseVisualStyleBackColor = true;
            this.btnNachosPlus.Click += new System.EventHandler(this.btnNachosPlus_Click);
            // 
            // btnHotdogMinus
            // 
            this.btnHotdogMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnHotdogMinus.Location = new System.Drawing.Point(176, 177);
            this.btnHotdogMinus.Name = "btnHotdogMinus";
            this.btnHotdogMinus.Size = new System.Drawing.Size(37, 28);
            this.btnHotdogMinus.TabIndex = 14;
            this.btnHotdogMinus.Text = "-";
            this.btnHotdogMinus.UseVisualStyleBackColor = true;
            this.btnHotdogMinus.Click += new System.EventHandler(this.btnHotdogMinus_Click);
            // 
            // btnHotdogPlus
            // 
            this.btnHotdogPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnHotdogPlus.Location = new System.Drawing.Point(261, 177);
            this.btnHotdogPlus.Name = "btnHotdogPlus";
            this.btnHotdogPlus.Size = new System.Drawing.Size(37, 31);
            this.btnHotdogPlus.TabIndex = 15;
            this.btnHotdogPlus.Text = "+";
            this.btnHotdogPlus.UseVisualStyleBackColor = true;
            this.btnHotdogPlus.Click += new System.EventHandler(this.btnHotdogPlus_Click);
            // 
            // btnSoftdrinkMinus
            // 
            this.btnSoftdrinkMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnSoftdrinkMinus.Location = new System.Drawing.Point(176, 246);
            this.btnSoftdrinkMinus.Name = "btnSoftdrinkMinus";
            this.btnSoftdrinkMinus.Size = new System.Drawing.Size(37, 28);
            this.btnSoftdrinkMinus.TabIndex = 16;
            this.btnSoftdrinkMinus.Text = "-";
            this.btnSoftdrinkMinus.UseVisualStyleBackColor = true;
            this.btnSoftdrinkMinus.Click += new System.EventHandler(this.btnSoftdrinkMinus_Click);
            // 
            // btnSoftdrinkPlus
            // 
            this.btnSoftdrinkPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnSoftdrinkPlus.Location = new System.Drawing.Point(261, 246);
            this.btnSoftdrinkPlus.Name = "btnSoftdrinkPlus";
            this.btnSoftdrinkPlus.Size = new System.Drawing.Size(37, 28);
            this.btnSoftdrinkPlus.TabIndex = 17;
            this.btnSoftdrinkPlus.Text = "+";
            this.btnSoftdrinkPlus.UseVisualStyleBackColor = true;
            this.btnSoftdrinkPlus.Click += new System.EventHandler(this.btnSoftdrinkPlus_Click);
            // 
            // txtPopcornQty
            // 
            this.txtPopcornQty.Location = new System.Drawing.Point(219, 31);
            this.txtPopcornQty.Name = "txtPopcornQty";
            this.txtPopcornQty.Size = new System.Drawing.Size(36, 22);
            this.txtPopcornQty.TabIndex = 18;
            this.txtPopcornQty.TextChanged += new System.EventHandler(this.txtPopcornQty_TextChanged);
            // 
            // txtNachosQty
            // 
            this.txtNachosQty.Location = new System.Drawing.Point(219, 103);
            this.txtNachosQty.Name = "txtNachosQty";
            this.txtNachosQty.Size = new System.Drawing.Size(36, 22);
            this.txtNachosQty.TabIndex = 19;
            this.txtNachosQty.TextChanged += new System.EventHandler(this.txtNachosQty_TextChanged);
            // 
            // txtHotdogQty
            // 
            this.txtHotdogQty.Location = new System.Drawing.Point(219, 183);
            this.txtHotdogQty.Name = "txtHotdogQty";
            this.txtHotdogQty.Size = new System.Drawing.Size(36, 22);
            this.txtHotdogQty.TabIndex = 20;
            this.txtHotdogQty.TextChanged += new System.EventHandler(this.txtHotdogQty_TextChanged);
            // 
            // txtSoftdrinkQty
            // 
            this.txtSoftdrinkQty.Location = new System.Drawing.Point(216, 252);
            this.txtSoftdrinkQty.Name = "txtSoftdrinkQty";
            this.txtSoftdrinkQty.Size = new System.Drawing.Size(39, 22);
            this.txtSoftdrinkQty.TabIndex = 21;
            this.txtSoftdrinkQty.TextChanged += new System.EventHandler(this.txtSoftdrinkQty_TextChanged);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::WindowsFormsApp1.Properties.Resources.Cola_in_a_red_striped_cup_with_a_lid_and_a_straw__Cold_drink_with_ice__drops_of_condensate_on_the_cup__beverage__takeaway__fast_food__carbonated__coke__cocktail;
            this.pictureBox5.Location = new System.Drawing.Point(44, 240);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(60, 45);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 25;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::WindowsFormsApp1.Properties.Resources.Cachorro_quente1;
            this.pictureBox4.Location = new System.Drawing.Point(44, 160);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(60, 45);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 24;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WindowsFormsApp1.Properties.Resources.Nachos_stock_vector__Illustration_of_chips__jalapeno__nachos___5560443;
            this.pictureBox3.Location = new System.Drawing.Point(44, 90);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(60, 45);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 23;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.Popcorn_in_una_vasca_a_strisce___Vettore_Premium;
            this.pictureBox2.Location = new System.Drawing.Point(44, 23);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 22);
            this.label2.TabIndex = 26;
            this.label2.Text = "Current Total:";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.Location = new System.Drawing.Point(181, 346);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(62, 22);
            this.lblTotalAmount.TabIndex = 27;
            this.lblTotalAmount.Text = "₱0.00";
            this.lblTotalAmount.Click += new System.EventHandler(this.lblTotalAmount_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(49, 320);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(316, 38);
            this.button9.TabIndex = 28;
            this.button9.Text = "CONFIRM SELECTION";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(44, 399);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(108, 38);
            this.button10.TabIndex = 29;
            this.button10.Text = "SKIP";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.button10);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.lblTotalAmount);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(416, 540);
            this.panel2.TabIndex = 30;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button9);
            this.panel3.Controls.Add(this.btnSoftdrinkPlus);
            this.panel3.Controls.Add(this.txtSoftdrinkQty);
            this.panel3.Controls.Add(this.btnHotdogPlus);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.btnNachosPlus);
            this.panel3.Controls.Add(this.txtHotdogQty);
            this.panel3.Controls.Add(this.btnPopcornPlus);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.txtNachosQty);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.txtPopcornQty);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.btnPopcornMinus);
            this.panel3.Controls.Add(this.btnSoftdrinkMinus);
            this.panel3.Controls.Add(this.btnNachosMinus);
            this.panel3.Controls.Add(this.btnHotdogMinus);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(582, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(405, 540);
            this.panel3.TabIndex = 31;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Location = new System.Drawing.Point(0, 112);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(987, 540);
            this.panel4.TabIndex = 32;
            // 
            // foods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 653);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Name = "foods";
            this.Text = "foods";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnPopcornMinus;
        private System.Windows.Forms.Button btnPopcornPlus;
        private System.Windows.Forms.Button btnNachosMinus;
        private System.Windows.Forms.Button btnNachosPlus;
        private System.Windows.Forms.Button btnHotdogMinus;
        private System.Windows.Forms.Button btnHotdogPlus;
        private System.Windows.Forms.Button btnSoftdrinkMinus;
        private System.Windows.Forms.Button btnSoftdrinkPlus;
        private System.Windows.Forms.TextBox txtPopcornQty;
        private System.Windows.Forms.TextBox txtNachosQty;
        private System.Windows.Forms.TextBox txtHotdogQty;
        private System.Windows.Forms.TextBox txtSoftdrinkQty;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}