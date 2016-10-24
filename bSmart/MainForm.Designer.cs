namespace BSmart
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
            this.components = new System.ComponentModel.Container();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.progressBarTime = new System.Windows.Forms.ProgressBar();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnAverage = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPrSo = new System.Windows.Forms.Label();
            this.lblPrevSol = new System.Windows.Forms.Label();
            this.lblSpu = new System.Windows.Forms.Label();
            this.lblIncor = new System.Windows.Forms.Label();
            this.lblCor = new System.Windows.Forms.Label();
            this.pnlSuccessColor = new System.Windows.Forms.Panel();
            this.lblPreviousSolution = new System.Windows.Forms.Label();
            this.lblSpun = new System.Windows.Forms.Label();
            this.lblIncorrect = new System.Windows.Forms.Label();
            this.lblCorrect = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblExercise = new System.Windows.Forms.Label();
            this.tmrDisplay = new System.Windows.Forms.Timer(this.components);
            this.memoTraceView = new System.Windows.Forms.TextBox();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblYourSolution = new System.Windows.Forms.Label();
            this.txtYourSolution = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.comboDuration = new System.Windows.Forms.ComboBox();
            this.lblDurationText = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Location = new System.Drawing.Point(32, 27);
            this.lblDisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(68, 17);
            this.lblDisplay.TabIndex = 0;
            this.lblDisplay.Text = "lblDisplay";
            // 
            // progressBarTime
            // 
            this.progressBarTime.Enabled = false;
            this.progressBarTime.Location = new System.Drawing.Point(36, 59);
            this.progressBarTime.Margin = new System.Windows.Forms.Padding(4);
            this.progressBarTime.Maximum = 60;
            this.progressBarTime.Name = "progressBarTime";
            this.progressBarTime.Size = new System.Drawing.Size(299, 28);
            this.progressBarTime.Step = 1;
            this.progressBarTime.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarTime.TabIndex = 1;
            this.progressBarTime.Value = 60;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStart.Location = new System.Drawing.Point(471, 14);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(92, 37);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.Start_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStop.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStop.Location = new System.Drawing.Point(471, 57);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(92, 37);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // btnAverage
            // 
            this.btnAverage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAverage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAverage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAverage.Location = new System.Drawing.Point(471, 101);
            this.btnAverage.Margin = new System.Windows.Forms.Padding(4);
            this.btnAverage.Name = "btnAverage";
            this.btnAverage.Size = new System.Drawing.Size(92, 37);
            this.btnAverage.TabIndex = 4;
            this.btnAverage.Text = "Average";
            this.btnAverage.UseVisualStyleBackColor = false;
            this.btnAverage.Click += new System.EventHandler(this.BtnAverage_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPrSo);
            this.groupBox1.Controls.Add(this.lblPrevSol);
            this.groupBox1.Controls.Add(this.lblSpu);
            this.groupBox1.Controls.Add(this.lblIncor);
            this.groupBox1.Controls.Add(this.lblCor);
            this.groupBox1.Controls.Add(this.pnlSuccessColor);
            this.groupBox1.Controls.Add(this.lblPreviousSolution);
            this.groupBox1.Controls.Add(this.lblSpun);
            this.groupBox1.Controls.Add(this.lblIncorrect);
            this.groupBox1.Controls.Add(this.lblCorrect);
            this.groupBox1.Location = new System.Drawing.Point(40, 118);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(295, 212);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // lblPrSo
            // 
            this.lblPrSo.AutoSize = true;
            this.lblPrSo.Location = new System.Drawing.Point(21, 178);
            this.lblPrSo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrSo.Name = "lblPrSo";
            this.lblPrSo.Size = new System.Drawing.Size(120, 17);
            this.lblPrSo.TabIndex = 9;
            this.lblPrSo.Text = "Previous solution:";
            // 
            // lblPrevSol
            // 
            this.lblPrevSol.AutoSize = true;
            this.lblPrevSol.Location = new System.Drawing.Point(21, 138);
            this.lblPrevSol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrevSol.Name = "lblPrevSol";
            this.lblPrevSol.Size = new System.Drawing.Size(153, 17);
            this.lblPrevSol.TabIndex = 8;
            this.lblPrevSol.Text = "Your previous solution:";
            // 
            // lblSpu
            // 
            this.lblSpu.AutoSize = true;
            this.lblSpu.Location = new System.Drawing.Point(21, 98);
            this.lblSpu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSpu.Name = "lblSpu";
            this.lblSpu.Size = new System.Drawing.Size(127, 17);
            this.lblSpu.TabIndex = 7;
            this.lblSpu.Text = "# of spun answers:\r\n";
            // 
            // lblIncor
            // 
            this.lblIncor.AutoSize = true;
            this.lblIncor.Location = new System.Drawing.Point(21, 64);
            this.lblIncor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIncor.Name = "lblIncor";
            this.lblIncor.Size = new System.Drawing.Size(151, 17);
            this.lblIncor.TabIndex = 6;
            this.lblIncor.Text = "# of incorrect answers:\r\n";
            // 
            // lblCor
            // 
            this.lblCor.AutoSize = true;
            this.lblCor.Location = new System.Drawing.Point(21, 27);
            this.lblCor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCor.Name = "lblCor";
            this.lblCor.Size = new System.Drawing.Size(140, 17);
            this.lblCor.TabIndex = 5;
            this.lblCor.Text = "# of correct answers:\r\n";
            // 
            // pnlSuccessColor
            // 
            this.pnlSuccessColor.Location = new System.Drawing.Point(223, 138);
            this.pnlSuccessColor.Margin = new System.Windows.Forms.Padding(4);
            this.pnlSuccessColor.Name = "pnlSuccessColor";
            this.pnlSuccessColor.Size = new System.Drawing.Size(47, 26);
            this.pnlSuccessColor.TabIndex = 4;
            // 
            // lblPreviousSolution
            // 
            this.lblPreviousSolution.AutoSize = true;
            this.lblPreviousSolution.Location = new System.Drawing.Point(224, 178);
            this.lblPreviousSolution.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPreviousSolution.Name = "lblPreviousSolution";
            this.lblPreviousSolution.Size = new System.Drawing.Size(128, 17);
            this.lblPreviousSolution.TabIndex = 3;
            this.lblPreviousSolution.Text = "lblPreviousSolution";
            // 
            // lblSpun
            // 
            this.lblSpun.AutoSize = true;
            this.lblSpun.Location = new System.Drawing.Point(224, 98);
            this.lblSpun.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSpun.Name = "lblSpun";
            this.lblSpun.Size = new System.Drawing.Size(55, 17);
            this.lblSpun.TabIndex = 2;
            this.lblSpun.Text = "lblSpun";
            // 
            // lblIncorrect
            // 
            this.lblIncorrect.AutoSize = true;
            this.lblIncorrect.Location = new System.Drawing.Point(224, 64);
            this.lblIncorrect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIncorrect.Name = "lblIncorrect";
            this.lblIncorrect.Size = new System.Drawing.Size(77, 17);
            this.lblIncorrect.TabIndex = 1;
            this.lblIncorrect.Text = "lblIncorrect";
            // 
            // lblCorrect
            // 
            this.lblCorrect.AutoSize = true;
            this.lblCorrect.Location = new System.Drawing.Point(224, 27);
            this.lblCorrect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCorrect.Name = "lblCorrect";
            this.lblCorrect.Size = new System.Drawing.Size(68, 17);
            this.lblCorrect.TabIndex = 0;
            this.lblCorrect.Text = "lblCorrect";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblQuestion);
            this.groupBox2.Controls.Add(this.lblExercise);
            this.groupBox2.Location = new System.Drawing.Point(40, 337);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(295, 73);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(21, 32);
            this.lblQuestion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(69, 17);
            this.lblQuestion.TabIndex = 2;
            this.lblQuestion.Text = "Question:";
            // 
            // lblExercise
            // 
            this.lblExercise.AutoSize = true;
            this.lblExercise.Location = new System.Drawing.Point(152, 32);
            this.lblExercise.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExercise.Name = "lblExercise";
            this.lblExercise.Size = new System.Drawing.Size(75, 17);
            this.lblExercise.TabIndex = 1;
            this.lblExercise.Text = "lblExercise";
            // 
            // tmrDisplay
            // 
            this.tmrDisplay.Interval = 1000;
            this.tmrDisplay.Tick += new System.EventHandler(this.TmrDisplay_Tick);
            // 
            // memoTraceView
            // 
            this.memoTraceView.Location = new System.Drawing.Point(343, 203);
            this.memoTraceView.Margin = new System.Windows.Forms.Padding(4);
            this.memoTraceView.Multiline = true;
            this.memoTraceView.Name = "memoTraceView";
            this.memoTraceView.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.memoTraceView.Size = new System.Drawing.Size(317, 238);
            this.memoTraceView.TabIndex = 9;
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(311, 93);
            this.lblDuration.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(24, 17);
            this.lblDuration.TabIndex = 10;
            this.lblDuration.Text = "60";
            // 
            // lblYourSolution
            // 
            this.lblYourSolution.AutoSize = true;
            this.lblYourSolution.Location = new System.Drawing.Point(61, 421);
            this.lblYourSolution.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYourSolution.Name = "lblYourSolution";
            this.lblYourSolution.Size = new System.Drawing.Size(95, 17);
            this.lblYourSolution.TabIndex = 15;
            this.lblYourSolution.Text = "Your solution:";
            // 
            // txtYourSolution
            // 
            this.txtYourSolution.Location = new System.Drawing.Point(169, 417);
            this.txtYourSolution.Margin = new System.Windows.Forms.Padding(4);
            this.txtYourSolution.Multiline = true;
            this.txtYourSolution.Name = "txtYourSolution";
            this.txtYourSolution.Size = new System.Drawing.Size(97, 24);
            this.txtYourSolution.TabIndex = 14;
            this.txtYourSolution.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtYourSolution_KeyDown);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReset.Location = new System.Drawing.Point(471, 145);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(92, 34);
            this.btnReset.TabIndex = 16;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // comboDuration
            // 
            this.comboDuration.DisplayMember = "60";
            this.comboDuration.FormattingEnabled = true;
            this.comboDuration.Items.AddRange(new object[] {
            "15",
            "30",
            "45",
            "60",
            "90",
            "120"});
            this.comboDuration.Location = new System.Drawing.Point(186, 90);
            this.comboDuration.Name = "comboDuration";
            this.comboDuration.Size = new System.Drawing.Size(55, 24);
            this.comboDuration.TabIndex = 17;
            this.comboDuration.SelectedIndexChanged += new System.EventHandler(this.ComboDuration_SelectedIndexChanged);
            // 
            // lblDurationText
            // 
            this.lblDurationText.AutoSize = true;
            this.lblDurationText.Location = new System.Drawing.Point(40, 95);
            this.lblDurationText.Name = "lblDurationText";
            this.lblDurationText.Size = new System.Drawing.Size(142, 17);
            this.lblDurationText.TabIndex = 18;
            this.lblDurationText.Text = "Game duration (sec):";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(677, 460);
            this.Controls.Add(this.lblDurationText);
            this.Controls.Add(this.comboDuration);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblYourSolution);
            this.Controls.Add(this.txtYourSolution);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.memoTraceView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAverage);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.progressBarTime);
            this.Controls.Add(this.lblDisplay);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "bSmart";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnAverage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel pnlSuccessColor;
        private System.Windows.Forms.Label lblPreviousSolution;
        private System.Windows.Forms.Label lblSpun;
        private System.Windows.Forms.Label lblIncorrect;
        private System.Windows.Forms.Label lblCorrect;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblExercise;
        private System.Windows.Forms.TextBox memoTraceView;
        //public System.Windows.Forms.Timer timer;
        public System.Windows.Forms.Timer tmrDisplay;
        private System.Windows.Forms.ProgressBar progressBarTime;
        private System.Windows.Forms.Label lblPrSo;
        private System.Windows.Forms.Label lblPrevSol;
        private System.Windows.Forms.Label lblSpu;
        private System.Windows.Forms.Label lblIncor;
        private System.Windows.Forms.Label lblCor;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblYourSolution;
        private System.Windows.Forms.TextBox txtYourSolution;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ComboBox comboDuration;
        private System.Windows.Forms.Label lblDurationText;
    }
}

