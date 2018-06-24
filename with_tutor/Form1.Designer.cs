namespace with_tutor
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Create = new System.Windows.Forms.Button();
            this.Add_layers = new System.Windows.Forms.Button();
            this.layers = new System.Windows.Forms.TextBox();
            this.l_num = new System.Windows.Forms.TextBox();
            this.Confirm = new System.Windows.Forms.Button();
            this.Choose_functions = new System.Windows.Forms.Button();
            this.functions = new System.Windows.Forms.TextBox();
            this.Choose_speeds = new System.Windows.Forms.Button();
            this.speeds = new System.Windows.Forms.TextBox();
            this.X = new System.Windows.Forms.Button();
            this.d = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.error_layers = new System.Windows.Forms.Label();
            this.funcParams = new System.Windows.Forms.TextBox();
            this.error_func = new System.Windows.Forms.Label();
            this.Load_input = new System.Windows.Forms.Button();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.error_speeds = new System.Windows.Forms.Label();
            this.Y_length = new System.Windows.Forms.Label();
            this.Ylen = new System.Windows.Forms.TextBox();
            this.Learn = new System.Windows.Forms.Button();
            this.Finished = new System.Windows.Forms.Label();
            this.Load_weights = new System.Windows.Forms.Button();
            this.openFileDialog3 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog3 = new System.Windows.Forms.FolderBrowserDialog();
            this.Test = new System.Windows.Forms.Button();
            this.Testing = new System.Windows.Forms.Label();
            this.T = new System.Windows.Forms.Button();
            this.dT = new System.Windows.Forms.Button();
            this.Load_test = new System.Windows.Forms.Button();
            this.folderBrowserDialog4 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog5 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog4 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog5 = new System.Windows.Forms.OpenFileDialog();
            this.Trained = new System.Windows.Forms.Label();
            this.Save_Report = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(29, 66);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(75, 23);
            this.Create.TabIndex = 0;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // Add_layers
            // 
            this.Add_layers.Location = new System.Drawing.Point(29, 111);
            this.Add_layers.Name = "Add_layers";
            this.Add_layers.Size = new System.Drawing.Size(75, 35);
            this.Add_layers.TabIndex = 1;
            this.Add_layers.Text = "Add hidden layers";
            this.Add_layers.UseVisualStyleBackColor = true;
            this.Add_layers.Visible = false;
            this.Add_layers.Click += new System.EventHandler(this.Add_layers_Click);
            // 
            // layers
            // 
            this.layers.Location = new System.Drawing.Point(152, 119);
            this.layers.Name = "layers";
            this.layers.Size = new System.Drawing.Size(72, 20);
            this.layers.TabIndex = 2;
            this.layers.Visible = false;
            // 
            // l_num
            // 
            this.l_num.Location = new System.Drawing.Point(110, 119);
            this.l_num.Name = "l_num";
            this.l_num.Size = new System.Drawing.Size(36, 20);
            this.l_num.TabIndex = 3;
            this.l_num.Visible = false;
            this.l_num.TextChanged += new System.EventHandler(this.l_num_TextChanged);
            // 
            // Confirm
            // 
            this.Confirm.Location = new System.Drawing.Point(30, 273);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(75, 23);
            this.Confirm.TabIndex = 4;
            this.Confirm.Text = "Confirm";
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Visible = false;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // Choose_functions
            // 
            this.Choose_functions.Location = new System.Drawing.Point(29, 152);
            this.Choose_functions.Name = "Choose_functions";
            this.Choose_functions.Size = new System.Drawing.Size(75, 35);
            this.Choose_functions.TabIndex = 5;
            this.Choose_functions.Text = "Choose functions";
            this.Choose_functions.UseVisualStyleBackColor = true;
            this.Choose_functions.Visible = false;
            this.Choose_functions.Click += new System.EventHandler(this.Choose_functions_Click);
            // 
            // functions
            // 
            this.functions.Location = new System.Drawing.Point(110, 160);
            this.functions.Name = "functions";
            this.functions.Size = new System.Drawing.Size(72, 20);
            this.functions.TabIndex = 6;
            this.functions.Visible = false;
            this.functions.TextChanged += new System.EventHandler(this.functions_TextChanged);
            // 
            // Choose_speeds
            // 
            this.Choose_speeds.Location = new System.Drawing.Point(29, 193);
            this.Choose_speeds.Name = "Choose_speeds";
            this.Choose_speeds.Size = new System.Drawing.Size(75, 35);
            this.Choose_speeds.TabIndex = 7;
            this.Choose_speeds.Text = "Choose speeds";
            this.Choose_speeds.UseVisualStyleBackColor = true;
            this.Choose_speeds.Visible = false;
            this.Choose_speeds.Click += new System.EventHandler(this.Choose_speeds_Click);
            // 
            // speeds
            // 
            this.speeds.Location = new System.Drawing.Point(110, 201);
            this.speeds.Name = "speeds";
            this.speeds.Size = new System.Drawing.Size(72, 20);
            this.speeds.TabIndex = 8;
            this.speeds.Visible = false;
            this.speeds.TextChanged += new System.EventHandler(this.speeds_TextChanged);
            // 
            // X
            // 
            this.X.Location = new System.Drawing.Point(116, 66);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(30, 23);
            this.X.TabIndex = 9;
            this.X.Text = "X";
            this.X.UseVisualStyleBackColor = true;
            this.X.Visible = false;
            this.X.Click += new System.EventHandler(this.X_Click);
            // 
            // d
            // 
            this.d.Location = new System.Drawing.Point(152, 66);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(30, 23);
            this.d.TabIndex = 10;
            this.d.Text = "d";
            this.d.UseVisualStyleBackColor = true;
            this.d.Visible = false;
            this.d.Click += new System.EventHandler(this.d_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(26, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Creation";
            // 
            // error_layers
            // 
            this.error_layers.AutoSize = true;
            this.error_layers.Location = new System.Drawing.Point(278, 122);
            this.error_layers.Name = "error_layers";
            this.error_layers.Size = new System.Drawing.Size(98, 13);
            this.error_layers.TabIndex = 12;
            this.error_layers.Text = "error=>use standart";
            this.error_layers.Visible = false;
            // 
            // funcParams
            // 
            this.funcParams.Location = new System.Drawing.Point(188, 160);
            this.funcParams.Name = "funcParams";
            this.funcParams.Size = new System.Drawing.Size(72, 20);
            this.funcParams.TabIndex = 13;
            this.funcParams.Visible = false;
            // 
            // error_func
            // 
            this.error_func.AutoSize = true;
            this.error_func.Location = new System.Drawing.Point(278, 163);
            this.error_func.Name = "error_func";
            this.error_func.Size = new System.Drawing.Size(98, 13);
            this.error_func.TabIndex = 14;
            this.error_func.Text = "error=>use standart";
            this.error_func.Visible = false;
            // 
            // Load_input
            // 
            this.Load_input.Location = new System.Drawing.Point(301, 66);
            this.Load_input.Name = "Load_input";
            this.Load_input.Size = new System.Drawing.Size(75, 23);
            this.Load_input.TabIndex = 15;
            this.Load_input.Text = "Load input";
            this.Load_input.UseVisualStyleBackColor = true;
            this.Load_input.Visible = false;
            this.Load_input.Click += new System.EventHandler(this.Load_input_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // error_speeds
            // 
            this.error_speeds.AutoSize = true;
            this.error_speeds.Location = new System.Drawing.Point(278, 204);
            this.error_speeds.Name = "error_speeds";
            this.error_speeds.Size = new System.Drawing.Size(98, 13);
            this.error_speeds.TabIndex = 16;
            this.error_speeds.Text = "error=>use standart";
            this.error_speeds.Visible = false;
            // 
            // Y_length
            // 
            this.Y_length.AutoSize = true;
            this.Y_length.Location = new System.Drawing.Point(188, 71);
            this.Y_length.Name = "Y_length";
            this.Y_length.Size = new System.Drawing.Size(53, 13);
            this.Y_length.TabIndex = 17;
            this.Y_length.Text = "Y.Length:";
            this.Y_length.Visible = false;
            // 
            // Ylen
            // 
            this.Ylen.Location = new System.Drawing.Point(244, 68);
            this.Ylen.Name = "Ylen";
            this.Ylen.Size = new System.Drawing.Size(38, 20);
            this.Ylen.TabIndex = 18;
            this.Ylen.Visible = false;
            // 
            // Learn
            // 
            this.Learn.Location = new System.Drawing.Point(207, 273);
            this.Learn.Name = "Learn";
            this.Learn.Size = new System.Drawing.Size(75, 23);
            this.Learn.TabIndex = 19;
            this.Learn.Text = "Learn";
            this.Learn.UseVisualStyleBackColor = true;
            this.Learn.Visible = false;
            this.Learn.Click += new System.EventHandler(this.Learn_Click);
            // 
            // Finished
            // 
            this.Finished.AutoSize = true;
            this.Finished.Location = new System.Drawing.Point(571, 116);
            this.Finished.Name = "Finished";
            this.Finished.Size = new System.Drawing.Size(46, 13);
            this.Finished.TabIndex = 20;
            this.Finished.Text = "Finished";
            this.Finished.Visible = false;
            // 
            // Load_weights
            // 
            this.Load_weights.Location = new System.Drawing.Point(301, 232);
            this.Load_weights.Name = "Load_weights";
            this.Load_weights.Size = new System.Drawing.Size(75, 35);
            this.Load_weights.TabIndex = 21;
            this.Load_weights.Text = "Load weights";
            this.Load_weights.UseVisualStyleBackColor = true;
            this.Load_weights.Visible = false;
            this.Load_weights.Click += new System.EventHandler(this.Load_weights_Click);
            // 
            // openFileDialog3
            // 
            this.openFileDialog3.FileName = "openFileDialog3";
            // 
            // Test
            // 
            this.Test.Location = new System.Drawing.Point(447, 111);
            this.Test.Name = "Test";
            this.Test.Size = new System.Drawing.Size(75, 23);
            this.Test.TabIndex = 22;
            this.Test.Text = "Test";
            this.Test.UseVisualStyleBackColor = true;
            this.Test.Visible = false;
            this.Test.Click += new System.EventHandler(this.Test_Click);
            // 
            // Testing
            // 
            this.Testing.AutoSize = true;
            this.Testing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Testing.Location = new System.Drawing.Point(445, 23);
            this.Testing.Name = "Testing";
            this.Testing.Size = new System.Drawing.Size(68, 20);
            this.Testing.TabIndex = 23;
            this.Testing.Text = "Testing";
            // 
            // T
            // 
            this.T.Location = new System.Drawing.Point(447, 68);
            this.T.Name = "T";
            this.T.Size = new System.Drawing.Size(28, 23);
            this.T.TabIndex = 24;
            this.T.Text = "T";
            this.T.UseVisualStyleBackColor = true;
            this.T.Visible = false;
            this.T.Click += new System.EventHandler(this.T_Click);
            // 
            // dT
            // 
            this.dT.Location = new System.Drawing.Point(484, 68);
            this.dT.Name = "dT";
            this.dT.Size = new System.Drawing.Size(29, 23);
            this.dT.TabIndex = 25;
            this.dT.Text = "dT";
            this.dT.UseVisualStyleBackColor = true;
            this.dT.Visible = false;
            this.dT.Click += new System.EventHandler(this.dT_Click);
            // 
            // Load_test
            // 
            this.Load_test.Location = new System.Drawing.Point(542, 71);
            this.Load_test.Name = "Load_test";
            this.Load_test.Size = new System.Drawing.Size(75, 23);
            this.Load_test.TabIndex = 26;
            this.Load_test.Text = "Load test";
            this.Load_test.UseVisualStyleBackColor = true;
            this.Load_test.Visible = false;
            this.Load_test.Click += new System.EventHandler(this.Load_test_Click);
            // 
            // openFileDialog4
            // 
            this.openFileDialog4.FileName = "openFileDialog4";
            // 
            // openFileDialog5
            // 
            this.openFileDialog5.FileName = "openFileDialog5";
            // 
            // Trained
            // 
            this.Trained.AutoSize = true;
            this.Trained.Location = new System.Drawing.Point(315, 278);
            this.Trained.Name = "Trained";
            this.Trained.Size = new System.Drawing.Size(43, 13);
            this.Trained.TabIndex = 27;
            this.Trained.Text = "Trained";
            this.Trained.Visible = false;
            // 
            // Save_Report
            // 
            this.Save_Report.Enabled = false;
            this.Save_Report.Location = new System.Drawing.Point(531, 273);
            this.Save_Report.Name = "Save_Report";
            this.Save_Report.Size = new System.Drawing.Size(86, 23);
            this.Save_Report.TabIndex = 28;
            this.Save_Report.Text = "Save Report";
            this.Save_Report.UseVisualStyleBackColor = true;
            this.Save_Report.Click += new System.EventHandler(this.Save_Report_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 318);
            this.Controls.Add(this.Save_Report);
            this.Controls.Add(this.Trained);
            this.Controls.Add(this.Load_test);
            this.Controls.Add(this.dT);
            this.Controls.Add(this.T);
            this.Controls.Add(this.Testing);
            this.Controls.Add(this.Test);
            this.Controls.Add(this.Load_weights);
            this.Controls.Add(this.Finished);
            this.Controls.Add(this.Learn);
            this.Controls.Add(this.Ylen);
            this.Controls.Add(this.Y_length);
            this.Controls.Add(this.error_speeds);
            this.Controls.Add(this.Load_input);
            this.Controls.Add(this.error_func);
            this.Controls.Add(this.funcParams);
            this.Controls.Add(this.error_layers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.d);
            this.Controls.Add(this.X);
            this.Controls.Add(this.speeds);
            this.Controls.Add(this.Choose_speeds);
            this.Controls.Add(this.functions);
            this.Controls.Add(this.Choose_functions);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.l_num);
            this.Controls.Add(this.layers);
            this.Controls.Add(this.Add_layers);
            this.Controls.Add(this.Create);
            this.Name = "Form1";
            this.Text = "Neuronet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Button Add_layers;
        private System.Windows.Forms.TextBox layers;
        private System.Windows.Forms.TextBox l_num;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.Button Choose_functions;
        private System.Windows.Forms.TextBox functions;
        private System.Windows.Forms.Button Choose_speeds;
        private System.Windows.Forms.TextBox speeds;
        private System.Windows.Forms.Button X;
        private System.Windows.Forms.Button d;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label error_layers;
        private System.Windows.Forms.TextBox funcParams;
        private System.Windows.Forms.Label error_func;
        private System.Windows.Forms.Button Load_input;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Label error_speeds;
        private System.Windows.Forms.Label Y_length;
        private System.Windows.Forms.TextBox Ylen;
        private System.Windows.Forms.Button Learn;
        private System.Windows.Forms.Label Finished;
        private System.Windows.Forms.Button Load_weights;
        private System.Windows.Forms.OpenFileDialog openFileDialog3;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog3;
        private System.Windows.Forms.Button Test;
        private System.Windows.Forms.Label Testing;
        private System.Windows.Forms.Button T;
        private System.Windows.Forms.Button dT;
        private System.Windows.Forms.Button Load_test;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog4;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog5;
        private System.Windows.Forms.OpenFileDialog openFileDialog4;
        private System.Windows.Forms.OpenFileDialog openFileDialog5;
        private System.Windows.Forms.Label Trained;
        private System.Windows.Forms.Button Save_Report;
    }
}

