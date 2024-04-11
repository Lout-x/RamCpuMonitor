namespace RamCpuMonitor
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.processname = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.realtimememory = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ftime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.processloader = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.timers = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pid = new System.Windows.Forms.CheckBox();
            this.montime = new System.Windows.Forms.Timer(this.components);
            this.stopmon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // processname
            // 
            this.processname.FormattingEnabled = true;
            this.processname.Location = new System.Drawing.Point(12, 29);
            this.processname.Name = "processname";
            this.processname.Size = new System.Drawing.Size(199, 21);
            this.processname.Sorted = true;
            this.processname.TabIndex = 0;
            this.processname.TextChanged += new System.EventHandler(this.processName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Имя процесса";
            // 
            // realtimememory
            // 
            this.realtimememory.Location = new System.Drawing.Point(217, 29);
            this.realtimememory.Name = "realtimememory";
            this.realtimememory.Size = new System.Drawing.Size(125, 20);
            this.realtimememory.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Текущее значение ОЗУ";
            // 
            // ftime
            // 
            this.ftime.Location = new System.Drawing.Point(348, 29);
            this.ftime.Name = "ftime";
            this.ftime.Size = new System.Drawing.Size(121, 20);
            this.ftime.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(348, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Последнее время";
            // 
            // processloader
            // 
            this.processloader.Location = new System.Drawing.Point(12, 56);
            this.processloader.Name = "processloader";
            this.processloader.Size = new System.Drawing.Size(111, 44);
            this.processloader.TabIndex = 6;
            this.processloader.Text = "Загрузить процессы";
            this.processloader.UseVisualStyleBackColor = true;
            this.processloader.Click += new System.EventHandler(this.processLoader_Click);
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(129, 56);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(111, 44);
            this.start.TabIndex = 7;
            this.start.Text = "Запустить мониторинг";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // timers
            // 
            this.timers.FormattingEnabled = true;
            this.timers.Items.AddRange(new object[] {
            "60",
            "40",
            "20",
            "5"});
            this.timers.Location = new System.Drawing.Point(246, 79);
            this.timers.Name = "timers";
            this.timers.Size = new System.Drawing.Size(148, 21);
            this.timers.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(247, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "тайм-аут мониторинга (сек)";
            // 
            // pid
            // 
            this.pid.AutoSize = true;
            this.pid.Location = new System.Drawing.Point(400, 81);
            this.pid.Name = "pid";
            this.pid.Size = new System.Drawing.Size(44, 17);
            this.pid.TabIndex = 10;
            this.pid.Text = "PID";
            this.pid.UseVisualStyleBackColor = true;
            // 
            // montime
            // 
            this.montime.Tick += new System.EventHandler(this.monTime_Tick);
            // 
            // stopmon
            // 
            this.stopmon.Location = new System.Drawing.Point(129, 106);
            this.stopmon.Name = "stopmon";
            this.stopmon.Size = new System.Drawing.Size(111, 44);
            this.stopmon.TabIndex = 11;
            this.stopmon.Text = "Остановить мониторинг";
            this.stopmon.UseVisualStyleBackColor = true;
            this.stopmon.Click += new System.EventHandler(this.stopmon_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 171);
            this.Controls.Add(this.stopmon);
            this.Controls.Add(this.pid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.timers);
            this.Controls.Add(this.start);
            this.Controls.Add(this.processloader);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ftime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.realtimememory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.processname);
            this.Name = "Main";
            this.Text = "Process Operation Memory Monitor - by zombievdk";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox processname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox realtimememory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ftime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button processloader;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.ComboBox timers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox pid;
        private System.Windows.Forms.Timer montime;
        private System.Windows.Forms.Button stopmon;
    }
}

