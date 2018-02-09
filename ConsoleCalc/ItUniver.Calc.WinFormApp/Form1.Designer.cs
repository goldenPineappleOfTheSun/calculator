namespace ItUniver.Calc.WinFormApp
{
    partial class Form1
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
            this.gbOperation = new System.Windows.Forms.GroupBox();
            this.cbOperations = new System.Windows.Forms.ComboBox();
            this.gbArgs = new System.Windows.Forms.GroupBox();
            this.tbArgs = new System.Windows.Forms.TextBox();
            this.gbResult = new System.Windows.Forms.GroupBox();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.gbButtons = new System.Windows.Forms.GroupBox();
            this.btnLucky = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.gbHistory = new System.Windows.Forms.GroupBox();
            this.lbHistory = new System.Windows.Forms.ListBox();
            this.ArgsChangedTimer = new System.Windows.Forms.Timer(this.components);
            this.gbOperation.SuspendLayout();
            this.gbArgs.SuspendLayout();
            this.gbResult.SuspendLayout();
            this.gbButtons.SuspendLayout();
            this.gbHistory.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbOperation
            // 
            this.gbOperation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbOperation.Controls.Add(this.cbOperations);
            this.gbOperation.Location = new System.Drawing.Point(12, 14);
            this.gbOperation.Margin = new System.Windows.Forms.Padding(5);
            this.gbOperation.Name = "gbOperation";
            this.gbOperation.Padding = new System.Windows.Forms.Padding(10);
            this.gbOperation.Size = new System.Drawing.Size(639, 66);
            this.gbOperation.TabIndex = 0;
            this.gbOperation.TabStop = false;
            this.gbOperation.Text = "Операция";
            // 
            // cbOperations
            // 
            this.cbOperations.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbOperations.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbOperations.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbOperations.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbOperations.FormattingEnabled = true;
            this.cbOperations.Location = new System.Drawing.Point(14, 27);
            this.cbOperations.Name = "cbOperations";
            this.cbOperations.Size = new System.Drawing.Size(612, 24);
            this.cbOperations.TabIndex = 0;
            this.cbOperations.SelectedIndexChanged += new System.EventHandler(this.cbOperations_SelectedIndexChanged);
            // 
            // gbArgs
            // 
            this.gbArgs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbArgs.Controls.Add(this.tbArgs);
            this.gbArgs.Location = new System.Drawing.Point(12, 88);
            this.gbArgs.Name = "gbArgs";
            this.gbArgs.Size = new System.Drawing.Size(639, 66);
            this.gbArgs.TabIndex = 0;
            this.gbArgs.TabStop = false;
            this.gbArgs.Text = "Аргументы";
            // 
            // tbArgs
            // 
            this.tbArgs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbArgs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbArgs.ForeColor = System.Drawing.Color.Black;
            this.tbArgs.Location = new System.Drawing.Point(14, 29);
            this.tbArgs.Name = "tbArgs";
            this.tbArgs.Size = new System.Drawing.Size(612, 23);
            this.tbArgs.TabIndex = 0;
            this.tbArgs.Text = "123";
            this.tbArgs.TextChanged += new System.EventHandler(this.tbArgs_TextChanged);
            // 
            // gbResult
            // 
            this.gbResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbResult.Controls.Add(this.tbResult);
            this.gbResult.Location = new System.Drawing.Point(12, 160);
            this.gbResult.Name = "gbResult";
            this.gbResult.Size = new System.Drawing.Size(639, 71);
            this.gbResult.TabIndex = 0;
            this.gbResult.TabStop = false;
            this.gbResult.Text = "Результат";
            // 
            // tbResult
            // 
            this.tbResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbResult.CausesValidation = false;
            this.tbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbResult.Location = new System.Drawing.Point(14, 28);
            this.tbResult.Name = "tbResult";
            this.tbResult.ReadOnly = true;
            this.tbResult.Size = new System.Drawing.Size(612, 26);
            this.tbResult.TabIndex = 0;
            this.tbResult.TextChanged += new System.EventHandler(this.tbResult_TextChanged);
            // 
            // gbButtons
            // 
            this.gbButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbButtons.Controls.Add(this.btnLucky);
            this.gbButtons.Controls.Add(this.btnReset);
            this.gbButtons.Controls.Add(this.btnCalc);
            this.gbButtons.Location = new System.Drawing.Point(12, 419);
            this.gbButtons.Name = "gbButtons";
            this.gbButtons.Size = new System.Drawing.Size(639, 67);
            this.gbButtons.TabIndex = 1;
            this.gbButtons.TabStop = false;
            // 
            // btnLucky
            // 
            this.btnLucky.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLucky.Location = new System.Drawing.Point(6, 19);
            this.btnLucky.Name = "btnLucky";
            this.btnLucky.Size = new System.Drawing.Size(118, 32);
            this.btnLucky.TabIndex = 0;
            this.btnLucky.Text = "Мне повезет!";
            this.btnLucky.UseVisualStyleBackColor = true;
            this.btnLucky.Click += new System.EventHandler(this.btnLucky_Click);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.Location = new System.Drawing.Point(384, 19);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(118, 32);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "Очистить";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalc.Location = new System.Drawing.Point(508, 19);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(118, 32);
            this.btnCalc.TabIndex = 0;
            this.btnCalc.Text = "Посчитать";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // gbHistory
            // 
            this.gbHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbHistory.Controls.Add(this.lbHistory);
            this.gbHistory.Location = new System.Drawing.Point(12, 239);
            this.gbHistory.Margin = new System.Windows.Forms.Padding(5);
            this.gbHistory.Name = "gbHistory";
            this.gbHistory.Padding = new System.Windows.Forms.Padding(10);
            this.gbHistory.Size = new System.Drawing.Size(639, 172);
            this.gbHistory.TabIndex = 0;
            this.gbHistory.TabStop = false;
            this.gbHistory.Text = "История";
            this.gbHistory.UseCompatibleTextRendering = true;
            // 
            // lbHistory
            // 
            this.lbHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbHistory.FormattingEnabled = true;
            this.lbHistory.Location = new System.Drawing.Point(14, 27);
            this.lbHistory.Name = "lbHistory";
            this.lbHistory.Size = new System.Drawing.Size(612, 121);
            this.lbHistory.TabIndex = 0;
            // 
            // ArgsChangedTimer
            // 
            this.ArgsChangedTimer.Interval = 1000;
            this.ArgsChangedTimer.Tick += new System.EventHandler(this.ArgsChangedTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 498);
            this.Controls.Add(this.gbButtons);
            this.Controls.Add(this.gbResult);
            this.Controls.Add(this.gbArgs);
            this.Controls.Add(this.gbHistory);
            this.Controls.Add(this.gbOperation);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(428, 351);
            this.Name = "Form1";
            this.Text = "Калькулятор";
            this.gbOperation.ResumeLayout(false);
            this.gbArgs.ResumeLayout(false);
            this.gbArgs.PerformLayout();
            this.gbResult.ResumeLayout(false);
            this.gbResult.PerformLayout();
            this.gbButtons.ResumeLayout(false);
            this.gbHistory.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbOperation;
        private System.Windows.Forms.GroupBox gbArgs;
        private System.Windows.Forms.GroupBox gbResult;
        private System.Windows.Forms.GroupBox gbButtons;
        private System.Windows.Forms.ComboBox cbOperations;
        private System.Windows.Forms.TextBox tbArgs;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Button btnLucky;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.GroupBox gbHistory;
        private System.Windows.Forms.ListBox lbHistory;
        private System.Windows.Forms.Timer ArgsChangedTimer;
    }
}

