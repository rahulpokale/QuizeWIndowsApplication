namespace QuizeWIndowsApplication
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
            this.components = new System.ComponentModel.Container();
            this.headerName_lbl = new System.Windows.Forms.Label();
            this.start_btn = new System.Windows.Forms.Button();
            this.next_btn = new System.Windows.Forms.Button();
            this.question_timer = new System.Windows.Forms.Timer(this.components);
            this.timeTicks_lbl = new System.Windows.Forms.Label();
            this.instructionText = new System.Windows.Forms.Label();
            this.result_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // headerName_lbl
            // 
            this.headerName_lbl.AutoSize = true;
            this.headerName_lbl.BackColor = System.Drawing.SystemColors.Control;
            this.headerName_lbl.Font = new System.Drawing.Font("Sitka Text", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerName_lbl.ForeColor = System.Drawing.Color.SteelBlue;
            this.headerName_lbl.Location = new System.Drawing.Point(377, 9);
            this.headerName_lbl.Name = "headerName_lbl";
            this.headerName_lbl.Size = new System.Drawing.Size(440, 72);
            this.headerName_lbl.TabIndex = 0;
            this.headerName_lbl.Text = "Quiz Application";
            // 
            // start_btn
            // 
            this.start_btn.BackColor = System.Drawing.Color.SeaGreen;
            this.start_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_btn.ForeColor = System.Drawing.Color.MintCream;
            this.start_btn.Location = new System.Drawing.Point(474, 351);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(244, 80);
            this.start_btn.TabIndex = 1;
            this.start_btn.Text = "Start";
            this.start_btn.UseVisualStyleBackColor = false;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // next_btn
            // 
            this.next_btn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.next_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next_btn.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.next_btn.Location = new System.Drawing.Point(519, 437);
            this.next_btn.Name = "next_btn";
            this.next_btn.Size = new System.Drawing.Size(159, 39);
            this.next_btn.TabIndex = 2;
            this.next_btn.Text = "Next";
            this.next_btn.UseVisualStyleBackColor = false;
            this.next_btn.Visible = false;
            this.next_btn.Click += new System.EventHandler(this.next_btn_Click);
            // 
            // question_timer
            // 
            this.question_timer.Interval = 1000;
            this.question_timer.Tick += new System.EventHandler(this.question_timer_Tick);
            // 
            // timeTicks_lbl
            // 
            this.timeTicks_lbl.AutoSize = true;
            this.timeTicks_lbl.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeTicks_lbl.Location = new System.Drawing.Point(902, 36);
            this.timeTicks_lbl.Name = "timeTicks_lbl";
            this.timeTicks_lbl.Size = new System.Drawing.Size(115, 27);
            this.timeTicks_lbl.TabIndex = 3;
            this.timeTicks_lbl.Text = "Time starts";
            this.timeTicks_lbl.Visible = false;
            // 
            // instructionText
            // 
            this.instructionText.AutoSize = true;
            this.instructionText.Font = new System.Drawing.Font("Prestige Elite Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionText.Location = new System.Drawing.Point(232, 148);
            this.instructionText.Name = "instructionText";
            this.instructionText.Size = new System.Drawing.Size(82, 23);
            this.instructionText.TabIndex = 4;
            this.instructionText.Text = "label1";
            // 
            // result_lbl
            // 
            this.result_lbl.AutoSize = true;
            this.result_lbl.Font = new System.Drawing.Font("Palatino Linotype", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result_lbl.ForeColor = System.Drawing.Color.RoyalBlue;
            this.result_lbl.Location = new System.Drawing.Point(80, 229);
            this.result_lbl.Name = "result_lbl";
            this.result_lbl.Size = new System.Drawing.Size(202, 81);
            this.result_lbl.TabIndex = 5;
            this.result_lbl.Text = "label1";
            this.result_lbl.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 586);
            this.Controls.Add(this.result_lbl);
            this.Controls.Add(this.instructionText);
            this.Controls.Add(this.timeTicks_lbl);
            this.Controls.Add(this.next_btn);
            this.Controls.Add(this.start_btn);
            this.Controls.Add(this.headerName_lbl);
            this.Name = "Form1";
            this.Text = "Quiz Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerName_lbl;
        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.Button next_btn;
        private System.Windows.Forms.Timer question_timer;
        private System.Windows.Forms.Label timeTicks_lbl;
        private System.Windows.Forms.Label instructionText;
        private System.Windows.Forms.Label result_lbl;
    }
}

