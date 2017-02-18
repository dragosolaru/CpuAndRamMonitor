namespace CpuAndRamMonitor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pRam = new System.Diagnostics.PerformanceCounter();
            this.pCPU = new System.Diagnostics.PerformanceCounter();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.progressBarCPU = new System.Windows.Forms.ProgressBar();
            this.progressBarRAM = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.IbiCPU = new System.Windows.Forms.Label();
            this.IbiRAM = new System.Windows.Forms.Label();
            this.circularProgressBarRam = new CircularProgressBar.CircularProgressBar();
            this.circularProgressBarCPU = new CircularProgressBar.CircularProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pRam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).BeginInit();
            this.SuspendLayout();
            // 
            // pRam
            // 
            this.pRam.CategoryName = "Memory";
            this.pRam.CounterName = "% Committed Bytes In Use";
            // 
            // pCPU
            // 
            this.pCPU.CategoryName = "Processor";
            this.pCPU.CounterName = "% Processor Time";
            this.pCPU.InstanceName = "_Total";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(13, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "CPU";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // progressBarCPU
            // 
            this.progressBarCPU.Location = new System.Drawing.Point(75, 188);
            this.progressBarCPU.Name = "progressBarCPU";
            this.progressBarCPU.Size = new System.Drawing.Size(346, 23);
            this.progressBarCPU.TabIndex = 1;
            // 
            // progressBarRAM
            // 
            this.progressBarRAM.Location = new System.Drawing.Point(75, 331);
            this.progressBarRAM.Name = "progressBarRAM";
            this.progressBarRAM.Size = new System.Drawing.Size(346, 23);
            this.progressBarRAM.TabIndex = 3;
            this.progressBarRAM.Click += new System.EventHandler(this.progressBar2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(13, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "RAM";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // IbiCPU
            // 
            this.IbiCPU.AutoSize = true;
            this.IbiCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IbiCPU.Location = new System.Drawing.Point(441, 188);
            this.IbiCPU.Name = "IbiCPU";
            this.IbiCPU.Size = new System.Drawing.Size(43, 25);
            this.IbiCPU.TabIndex = 4;
            this.IbiCPU.Text = "0%";
            // 
            // IbiRAM
            // 
            this.IbiRAM.AutoSize = true;
            this.IbiRAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IbiRAM.Location = new System.Drawing.Point(441, 327);
            this.IbiRAM.Name = "IbiRAM";
            this.IbiRAM.Size = new System.Drawing.Size(43, 25);
            this.IbiRAM.TabIndex = 5;
            this.IbiRAM.Text = "0%";
            // 
            // circularProgressBarRam
            // 
            this.circularProgressBarRam.AnimationFunction = ((WinFormAnimation.AnimationFunctions.Function)(resources.GetObject("circularProgressBarRam.AnimationFunction")));
            this.circularProgressBarRam.AnimationSpeed = 500;
            this.circularProgressBarRam.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBarRam.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.circularProgressBarRam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBarRam.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBarRam.InnerMargin = 2;
            this.circularProgressBarRam.InnerWidth = -1;
            this.circularProgressBarRam.Location = new System.Drawing.Point(586, 231);
            this.circularProgressBarRam.MarqueeAnimationSpeed = 2000;
            this.circularProgressBarRam.Name = "circularProgressBarRam";
            this.circularProgressBarRam.OuterColor = System.Drawing.Color.Gray;
            this.circularProgressBarRam.OuterMargin = -25;
            this.circularProgressBarRam.OuterWidth = 26;
            this.circularProgressBarRam.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.circularProgressBarRam.ProgressWidth = 25;
            this.circularProgressBarRam.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBarRam.Size = new System.Drawing.Size(135, 121);
            this.circularProgressBarRam.StartAngle = 270;
            this.circularProgressBarRam.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBarRam.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBarRam.SubscriptText = ".23";
            this.circularProgressBarRam.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBarRam.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBarRam.SuperscriptText = "°C";
            this.circularProgressBarRam.TabIndex = 6;
            this.circularProgressBarRam.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            // 
            // circularProgressBarCPU
            // 
            this.circularProgressBarCPU.AnimationFunction = ((WinFormAnimation.AnimationFunctions.Function)(resources.GetObject("circularProgressBarCPU.AnimationFunction")));
            this.circularProgressBarCPU.AnimationSpeed = 500;
            this.circularProgressBarCPU.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBarCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.circularProgressBarCPU.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBarCPU.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBarCPU.InnerMargin = 2;
            this.circularProgressBarCPU.InnerWidth = -1;
            this.circularProgressBarCPU.Location = new System.Drawing.Point(586, 90);
            this.circularProgressBarCPU.MarqueeAnimationSpeed = 2000;
            this.circularProgressBarCPU.Name = "circularProgressBarCPU";
            this.circularProgressBarCPU.OuterColor = System.Drawing.Color.Gray;
            this.circularProgressBarCPU.OuterMargin = -25;
            this.circularProgressBarCPU.OuterWidth = 26;
            this.circularProgressBarCPU.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.circularProgressBarCPU.ProgressWidth = 25;
            this.circularProgressBarCPU.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBarCPU.Size = new System.Drawing.Size(135, 121);
            this.circularProgressBarCPU.StartAngle = 270;
            this.circularProgressBarCPU.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBarCPU.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBarCPU.SubscriptText = ".23";
            this.circularProgressBarCPU.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBarCPU.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBarCPU.SuperscriptText = "°C";
            this.circularProgressBarCPU.TabIndex = 7;
            this.circularProgressBarCPU.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBarCPU.Click += new System.EventHandler(this.circularProgressBar1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(659, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 405);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.circularProgressBarCPU);
            this.Controls.Add(this.circularProgressBarRam);
            this.Controls.Add(this.IbiRAM);
            this.Controls.Add(this.IbiCPU);
            this.Controls.Add(this.progressBarRAM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBarCPU);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Ram&&Cpu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pRam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Diagnostics.PerformanceCounter pRam;
        private System.Diagnostics.PerformanceCounter pCPU;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBarCPU;
        private System.Windows.Forms.ProgressBar progressBarRAM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label IbiCPU;
        private System.Windows.Forms.Label IbiRAM;
        private CircularProgressBar.CircularProgressBar circularProgressBarRam;
        private CircularProgressBar.CircularProgressBar circularProgressBarCPU;
        private System.Windows.Forms.Button button1;
    }
}

