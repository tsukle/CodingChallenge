namespace Challenge
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFloorDepth = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFloorWidth = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nudWindowAmount = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtWindowHeight = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtWindowWidth = new System.Windows.Forms.TextBox();
            this.nudDoorAmount = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nudWallAmount = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtWallHeight = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtWallWidth = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtRoomDepth = new System.Windows.Forms.TextBox();
            this.txtRoomHeight = new System.Windows.Forms.TextBox();
            this.txtRoomWidth = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblVolumeTotal = new System.Windows.Forms.Label();
            this.lblPaintTotal = new System.Windows.Forms.Label();
            this.lblFloorTotal = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWindowAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDoorAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWallAmount)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(339, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Paint = 10m² per every litre used.";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtFloorDepth);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtFloorWidth);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 79);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Floor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Depth of floor: ";
            // 
            // txtFloorDepth
            // 
            this.txtFloorDepth.Location = new System.Drawing.Point(107, 48);
            this.txtFloorDepth.Name = "txtFloorDepth";
            this.txtFloorDepth.Size = new System.Drawing.Size(100, 20);
            this.txtFloorDepth.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Width of floor: ";
            // 
            // txtFloorWidth
            // 
            this.txtFloorWidth.Location = new System.Drawing.Point(107, 22);
            this.txtFloorWidth.Name = "txtFloorWidth";
            this.txtFloorWidth.Size = new System.Drawing.Size(100, 20);
            this.txtFloorWidth.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox2.Controls.Add(this.nudWindowAmount);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtWindowHeight);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtWindowWidth);
            this.groupBox2.Controls.Add(this.nudDoorAmount);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.nudWallAmount);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtWallHeight);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtWallWidth);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(12, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(560, 164);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Paint Calculations";
            // 
            // nudWindowAmount
            // 
            this.nudWindowAmount.Location = new System.Drawing.Point(427, 105);
            this.nudWindowAmount.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nudWindowAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudWindowAmount.Name = "nudWindowAmount";
            this.nudWindowAmount.Size = new System.Drawing.Size(120, 20);
            this.nudWindowAmount.TabIndex = 17;
            this.nudWindowAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Height of window: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(262, 107);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Amount of windows:";
            // 
            // txtWindowHeight
            // 
            this.txtWindowHeight.Location = new System.Drawing.Point(107, 128);
            this.txtWindowHeight.Name = "txtWindowHeight";
            this.txtWindowHeight.Size = new System.Drawing.Size(100, 20);
            this.txtWindowHeight.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Width of window: ";
            // 
            // txtWindowWidth
            // 
            this.txtWindowWidth.Location = new System.Drawing.Point(107, 102);
            this.txtWindowWidth.Name = "txtWindowWidth";
            this.txtWindowWidth.Size = new System.Drawing.Size(100, 20);
            this.txtWindowWidth.TabIndex = 12;
            // 
            // nudDoorAmount
            // 
            this.nudDoorAmount.Location = new System.Drawing.Point(427, 79);
            this.nudDoorAmount.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nudDoorAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDoorAmount.Name = "nudDoorAmount";
            this.nudDoorAmount.Size = new System.Drawing.Size(120, 20);
            this.nudDoorAmount.TabIndex = 11;
            this.nudDoorAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(262, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Amount of doors(standard size):";
            // 
            // nudWallAmount
            // 
            this.nudWallAmount.Location = new System.Drawing.Point(427, 53);
            this.nudWallAmount.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nudWallAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudWallAmount.Name = "nudWallAmount";
            this.nudWallAmount.Size = new System.Drawing.Size(120, 20);
            this.nudWallAmount.TabIndex = 9;
            this.nudWallAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(262, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Amount of walls to paint:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Height of wall: ";
            // 
            // txtWallHeight
            // 
            this.txtWallHeight.Location = new System.Drawing.Point(107, 58);
            this.txtWallHeight.Name = "txtWallHeight";
            this.txtWallHeight.Size = new System.Drawing.Size(100, 20);
            this.txtWallHeight.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Width of wall: ";
            // 
            // txtWallWidth
            // 
            this.txtWallWidth.Location = new System.Drawing.Point(107, 32);
            this.txtWallWidth.Name = "txtWallWidth";
            this.txtWallWidth.Size = new System.Drawing.Size(100, 20);
            this.txtWallWidth.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox3.Controls.Add(this.txtRoomDepth);
            this.groupBox3.Controls.Add(this.txtRoomHeight);
            this.groupBox3.Controls.Add(this.txtRoomWidth);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Location = new System.Drawing.Point(12, 267);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(229, 110);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Room Volume";
            // 
            // txtRoomDepth
            // 
            this.txtRoomDepth.Location = new System.Drawing.Point(107, 75);
            this.txtRoomDepth.Name = "txtRoomDepth";
            this.txtRoomDepth.Size = new System.Drawing.Size(100, 20);
            this.txtRoomDepth.TabIndex = 5;
            // 
            // txtRoomHeight
            // 
            this.txtRoomHeight.Location = new System.Drawing.Point(107, 50);
            this.txtRoomHeight.Name = "txtRoomHeight";
            this.txtRoomHeight.Size = new System.Drawing.Size(100, 20);
            this.txtRoomHeight.TabIndex = 4;
            // 
            // txtRoomWidth
            // 
            this.txtRoomWidth.Location = new System.Drawing.Point(107, 26);
            this.txtRoomWidth.Name = "txtRoomWidth";
            this.txtRoomWidth.Size = new System.Drawing.Size(100, 20);
            this.txtRoomWidth.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 78);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Depth of room: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Height of room: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Width of room: ";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(455, 416);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(117, 34);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox4.Controls.Add(this.lblVolumeTotal);
            this.groupBox4.Controls.Add(this.lblPaintTotal);
            this.groupBox4.Controls.Add(this.lblFloorTotal);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Location = new System.Drawing.Point(247, 267);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(325, 143);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Results";
            // 
            // lblVolumeTotal
            // 
            this.lblVolumeTotal.AutoSize = true;
            this.lblVolumeTotal.Location = new System.Drawing.Point(112, 106);
            this.lblVolumeTotal.Name = "lblVolumeTotal";
            this.lblVolumeTotal.Size = new System.Drawing.Size(10, 13);
            this.lblVolumeTotal.TabIndex = 5;
            this.lblVolumeTotal.Text = "-";
            // 
            // lblPaintTotal
            // 
            this.lblPaintTotal.AutoSize = true;
            this.lblPaintTotal.Location = new System.Drawing.Point(112, 65);
            this.lblPaintTotal.Name = "lblPaintTotal";
            this.lblPaintTotal.Size = new System.Drawing.Size(10, 13);
            this.lblPaintTotal.TabIndex = 4;
            this.lblPaintTotal.Text = "-";
            // 
            // lblFloorTotal
            // 
            this.lblFloorTotal.AutoSize = true;
            this.lblFloorTotal.Location = new System.Drawing.Point(112, 29);
            this.lblFloorTotal.Name = "lblFloorTotal";
            this.lblFloorTotal.Size = new System.Drawing.Size(10, 13);
            this.lblFloorTotal.TabIndex = 3;
            this.lblFloorTotal.Text = "-";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(11, 106);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(79, 13);
            this.label16.TabIndex = 2;
            this.label16.Text = "Room Volume: ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(11, 65);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "Paint Needed: ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(11, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Area of floor: ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label17.Location = new System.Drawing.Point(9, 440);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(150, 13);
            this.label17.TabIndex = 6;
            this.label17.Text = "Created by Emilis Tobulevicius";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 462);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Challenge";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWindowAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDoorAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWallAmount)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFloorDepth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFloorWidth;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nudWallAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtWallHeight;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtWallWidth;
        private System.Windows.Forms.NumericUpDown nudDoorAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown nudWindowAmount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtWindowHeight;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtWindowWidth;
        private System.Windows.Forms.TextBox txtRoomDepth;
        private System.Windows.Forms.TextBox txtRoomHeight;
        private System.Windows.Forms.TextBox txtRoomWidth;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblVolumeTotal;
        private System.Windows.Forms.Label lblPaintTotal;
        private System.Windows.Forms.Label lblFloorTotal;
        private System.Windows.Forms.Label label17;
    }
}

