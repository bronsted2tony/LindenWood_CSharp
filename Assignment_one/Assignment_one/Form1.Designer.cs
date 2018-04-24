namespace Assignment_one
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
            this.btnHour = new System.Windows.Forms.Button();
            this.btnMinute = new System.Windows.Forms.Button();
            this.btnSecond = new System.Windows.Forms.Button();
            this.btnOn = new System.Windows.Forms.Button();
            this.btnOff = new System.Windows.Forms.Button();
            this.gpbAmPm = new System.Windows.Forms.GroupBox();
            this.btnSnooze = new System.Windows.Forms.Button();
            this.rdbAM = new System.Windows.Forms.RadioButton();
            this.rdbPM = new System.Windows.Forms.RadioButton();
            this.btnTimer = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.gpbAmPm.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHour
            // 
            this.btnHour.Location = new System.Drawing.Point(12, 12);
            this.btnHour.Name = "btnHour";
            this.btnHour.Size = new System.Drawing.Size(75, 23);
            this.btnHour.TabIndex = 0;
            this.btnHour.Text = "Hour";
            this.btnHour.UseVisualStyleBackColor = true;
            // 
            // btnMinute
            // 
            this.btnMinute.Location = new System.Drawing.Point(93, 12);
            this.btnMinute.Name = "btnMinute";
            this.btnMinute.Size = new System.Drawing.Size(75, 23);
            this.btnMinute.TabIndex = 1;
            this.btnMinute.Text = "Minute";
            this.btnMinute.UseVisualStyleBackColor = true;
            // 
            // btnSecond
            // 
            this.btnSecond.Location = new System.Drawing.Point(174, 12);
            this.btnSecond.Name = "btnSecond";
            this.btnSecond.Size = new System.Drawing.Size(75, 23);
            this.btnSecond.TabIndex = 2;
            this.btnSecond.Text = "Second";
            this.btnSecond.UseVisualStyleBackColor = true;
            // 
            // btnOn
            // 
            this.btnOn.Location = new System.Drawing.Point(255, 12);
            this.btnOn.Name = "btnOn";
            this.btnOn.Size = new System.Drawing.Size(75, 23);
            this.btnOn.TabIndex = 3;
            this.btnOn.Text = "On";
            this.btnOn.UseVisualStyleBackColor = true;
            // 
            // btnOff
            // 
            this.btnOff.Location = new System.Drawing.Point(336, 12);
            this.btnOff.Name = "btnOff";
            this.btnOff.Size = new System.Drawing.Size(75, 23);
            this.btnOff.TabIndex = 4;
            this.btnOff.Text = "Off";
            this.btnOff.UseVisualStyleBackColor = true;
            // 
            // gpbAmPm
            // 
            this.gpbAmPm.Controls.Add(this.rdbPM);
            this.gpbAmPm.Controls.Add(this.rdbAM);
            this.gpbAmPm.Location = new System.Drawing.Point(174, 41);
            this.gpbAmPm.Name = "gpbAmPm";
            this.gpbAmPm.Size = new System.Drawing.Size(100, 50);
            this.gpbAmPm.TabIndex = 5;
            this.gpbAmPm.TabStop = false;
            this.gpbAmPm.Text = "AM/PM";
            // 
            // btnSnooze
            // 
            this.btnSnooze.Location = new System.Drawing.Point(12, 97);
            this.btnSnooze.Name = "btnSnooze";
            this.btnSnooze.Size = new System.Drawing.Size(399, 23);
            this.btnSnooze.TabIndex = 6;
            this.btnSnooze.Text = "Snooze";
            this.btnSnooze.UseVisualStyleBackColor = true;
            // 
            // rdbAM
            // 
            this.rdbAM.AutoSize = true;
            this.rdbAM.Location = new System.Drawing.Point(6, 22);
            this.rdbAM.Name = "rdbAM";
            this.rdbAM.Size = new System.Drawing.Size(44, 19);
            this.rdbAM.TabIndex = 0;
            this.rdbAM.TabStop = true;
            this.rdbAM.Text = "AM";
            this.rdbAM.UseVisualStyleBackColor = true;
            // 
            // rdbPM
            // 
            this.rdbPM.AutoSize = true;
            this.rdbPM.Location = new System.Drawing.Point(51, 22);
            this.rdbPM.Name = "rdbPM";
            this.rdbPM.Size = new System.Drawing.Size(43, 19);
            this.rdbPM.TabIndex = 1;
            this.rdbPM.TabStop = true;
            this.rdbPM.Text = "PM";
            this.rdbPM.UseVisualStyleBackColor = true;
            // 
            // btnTimer
            // 
            this.btnTimer.Location = new System.Drawing.Point(335, 59);
            this.btnTimer.Name = "btnTimer";
            this.btnTimer.Size = new System.Drawing.Size(75, 23);
            this.btnTimer.TabIndex = 7;
            this.btnTimer.Text = "Timer";
            this.btnTimer.UseVisualStyleBackColor = true;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Black;
            this.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Silver;
            this.lblTime.Location = new System.Drawing.Point(12, 59);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(74, 23);
            this.lblTime.TabIndex = 8;
            this.lblTime.Text = "00:00:00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 132);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnTimer);
            this.Controls.Add(this.btnSnooze);
            this.Controls.Add(this.gpbAmPm);
            this.Controls.Add(this.btnOff);
            this.Controls.Add(this.btnOn);
            this.Controls.Add(this.btnSecond);
            this.Controls.Add(this.btnMinute);
            this.Controls.Add(this.btnHour);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Alarm Clock";
            this.gpbAmPm.ResumeLayout(false);
            this.gpbAmPm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHour;
        private System.Windows.Forms.Button btnMinute;
        private System.Windows.Forms.Button btnSecond;
        private System.Windows.Forms.Button btnOn;
        private System.Windows.Forms.Button btnOff;
        private System.Windows.Forms.GroupBox gpbAmPm;
        private System.Windows.Forms.Button btnSnooze;
        private System.Windows.Forms.RadioButton rdbPM;
        private System.Windows.Forms.RadioButton rdbAM;
        private System.Windows.Forms.Button btnTimer;
        private System.Windows.Forms.Label lblTime;
    }
}

