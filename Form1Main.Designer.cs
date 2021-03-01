
namespace SerialportCom1
{
    partial class serialPort1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageString = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.textBoxInput2 = new System.Windows.Forms.TextBox();
            this.textBoxInput1 = new System.Windows.Forms.TextBox();
            this.buttonResult = new System.Windows.Forms.Button();
            this.tabPageLoop = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBoxVa = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPageList = new System.Windows.Forms.TabPage();
            this.buttonSaveFileConfig = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBoxResult2 = new System.Windows.Forms.TextBox();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.SaveDialog1 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tabPageSerial = new System.Windows.Forms.TabPage();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.BaudRate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxRececive = new System.Windows.Forms.TextBox();
            this.buttonReceive = new System.Windows.Forms.Button();
            this.buttonSend = new System.Windows.Forms.Button();
            this.radioButtonDisconncet = new System.Windows.Forms.RadioButton();
            this.radioButtonConnect = new System.Windows.Forms.RadioButton();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.comboBoxbaud = new System.Windows.Forms.ComboBox();
            this.comboBoxIport = new System.Windows.Forms.ComboBox();
            this.Serialport = new System.IO.Ports.SerialPort(this.components);
            this.timerSerialReceicve = new System.Windows.Forms.Timer(this.components);
            this.timerChartAdd = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.savFileDialogConfig = new System.Windows.Forms.SaveFileDialog();
            this.tabControlMain.SuspendLayout();
            this.tabPageString.SuspendLayout();
            this.tabPageLoop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabPageList.SuspendLayout();
            this.tabPageSerial.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageString);
            this.tabControlMain.Controls.Add(this.tabPageLoop);
            this.tabControlMain.Controls.Add(this.tabPageList);
            this.tabControlMain.Controls.Add(this.tabPageSerial);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(800, 450);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPageString
            // 
            this.tabPageString.Controls.Add(this.button4);
            this.tabPageString.Controls.Add(this.label10);
            this.tabPageString.Controls.Add(this.label9);
            this.tabPageString.Controls.Add(this.textBox5);
            this.tabPageString.Controls.Add(this.textBox4);
            this.tabPageString.Controls.Add(this.label3);
            this.tabPageString.Controls.Add(this.label4);
            this.tabPageString.Controls.Add(this.checkBox1);
            this.tabPageString.Controls.Add(this.textBoxResult);
            this.tabPageString.Controls.Add(this.textBoxInput2);
            this.tabPageString.Controls.Add(this.textBoxInput1);
            this.tabPageString.Controls.Add(this.buttonResult);
            this.tabPageString.Location = new System.Drawing.Point(4, 22);
            this.tabPageString.Name = "tabPageString";
            this.tabPageString.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageString.Size = new System.Drawing.Size(792, 424);
            this.tabPageString.TabIndex = 0;
            this.tabPageString.Text = "String";
            this.tabPageString.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(353, 98);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 14;
            this.button4.Text = "Login";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(251, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Password";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(251, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "TagName";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(353, 68);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(166, 20);
            this.textBox5.TabIndex = 11;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(353, 29);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(166, 20);
            this.textBox4.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Input2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Input1";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(61, 98);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(93, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "CaseSensitive";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(61, 184);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(148, 164);
            this.textBoxResult.TabIndex = 9;
            // 
            // textBoxInput2
            // 
            this.textBoxInput2.Location = new System.Drawing.Point(61, 72);
            this.textBoxInput2.Name = "textBoxInput2";
            this.textBoxInput2.Size = new System.Drawing.Size(148, 20);
            this.textBoxInput2.TabIndex = 4;
            // 
            // textBoxInput1
            // 
            this.textBoxInput1.Location = new System.Drawing.Point(61, 29);
            this.textBoxInput1.Name = "textBoxInput1";
            this.textBoxInput1.Size = new System.Drawing.Size(148, 20);
            this.textBoxInput1.TabIndex = 3;
            // 
            // buttonResult
            // 
            this.buttonResult.Location = new System.Drawing.Point(61, 133);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(75, 23);
            this.buttonResult.TabIndex = 6;
            this.buttonResult.Text = "Result1";
            this.buttonResult.UseVisualStyleBackColor = true;
            this.buttonResult.Click += new System.EventHandler(this.buttonResult_Click_1);
            // 
            // tabPageLoop
            // 
            this.tabPageLoop.Controls.Add(this.chart1);
            this.tabPageLoop.Controls.Add(this.button3);
            this.tabPageLoop.Controls.Add(this.button2);
            this.tabPageLoop.Controls.Add(this.label8);
            this.tabPageLoop.Controls.Add(this.label7);
            this.tabPageLoop.Controls.Add(this.label6);
            this.tabPageLoop.Controls.Add(this.listBox3);
            this.tabPageLoop.Controls.Add(this.listBox2);
            this.tabPageLoop.Controls.Add(this.listBoxVa);
            this.tabPageLoop.Controls.Add(this.button1);
            this.tabPageLoop.Controls.Add(this.label5);
            this.tabPageLoop.Controls.Add(this.label2);
            this.tabPageLoop.Controls.Add(this.textBox3);
            this.tabPageLoop.Controls.Add(this.textBox2);
            this.tabPageLoop.Controls.Add(this.textBox1);
            this.tabPageLoop.Location = new System.Drawing.Point(4, 22);
            this.tabPageLoop.Name = "tabPageLoop";
            this.tabPageLoop.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLoop.Size = new System.Drawing.Size(792, 424);
            this.tabPageLoop.TabIndex = 1;
            this.tabPageLoop.Text = "Loop";
            this.tabPageLoop.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.MediumPurple;
            this.chart1.BorderlineColor = System.Drawing.Color.Black;
            this.chart1.BorderlineWidth = 8;
            chartArea3.Name = "ChartArea1";
            chartArea3.ShadowColor = System.Drawing.Color.Maroon;
            this.chart1.ChartAreas.Add(chartArea3);
            this.chart1.Cursor = System.Windows.Forms.Cursors.Arrow;
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(373, 23);
            this.chart1.Margin = new System.Windows.Forms.Padding(5);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series7.LabelForeColor = System.Drawing.Color.OrangeRed;
            series7.Legend = "Legend1";
            series7.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            series7.Name = "SeriesVa";
            series7.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series7.YValuesPerPoint = 2;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series8.Color = System.Drawing.Color.Red;
            series8.LabelForeColor = System.Drawing.Color.Gold;
            series8.Legend = "Legend1";
            series8.Name = "SeriesVb";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series9.Color = System.Drawing.Color.Black;
            series9.Legend = "Legend1";
            series9.Name = "SeriesVab";
            this.chart1.Series.Add(series7);
            this.chart1.Series.Add(series8);
            this.chart1.Series.Add(series9);
            this.chart1.Size = new System.Drawing.Size(409, 300);
            this.chart1.TabIndex = 17;
            this.chart1.Text = "chart1";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(279, 108);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "Auto Stop";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(180, 108);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Auto Start";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(229, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Vab";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(112, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Vb";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Va";
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Items.AddRange(new object[] {
            "SeriesVab"});
            this.listBox3.Location = new System.Drawing.Point(261, 193);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(58, 160);
            this.listBox3.TabIndex = 8;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Items.AddRange(new object[] {
            "SeriesVb"});
            this.listBox2.Location = new System.Drawing.Point(138, 193);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(58, 160);
            this.listBox2.TabIndex = 7;
            // 
            // listBoxVa
            // 
            this.listBoxVa.FormattingEnabled = true;
            this.listBoxVa.Items.AddRange(new object[] {
            "SeriesVa"});
            this.listBoxVa.Location = new System.Drawing.Point(41, 193);
            this.listBoxVa.Name = "listBoxVa";
            this.listBoxVa.Size = new System.Drawing.Size(58, 160);
            this.listBoxVa.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button1.Location = new System.Drawing.Point(57, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Add Point";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Y:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "x:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(172, 11);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(151, 89);
            this.textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(57, 54);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(57, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // tabPageList
            // 
            this.tabPageList.Controls.Add(this.buttonSaveFileConfig);
            this.tabPageList.Controls.Add(this.button5);
            this.tabPageList.Controls.Add(this.textBoxResult2);
            this.tabPageList.Controls.Add(this.buttonLoad);
            this.tabPageList.Controls.Add(this.SaveDialog1);
            this.tabPageList.Controls.Add(this.label15);
            this.tabPageList.Controls.Add(this.textBox10);
            this.tabPageList.Controls.Add(this.label16);
            this.tabPageList.Controls.Add(this.label17);
            this.tabPageList.Controls.Add(this.label18);
            this.tabPageList.Controls.Add(this.textBox11);
            this.tabPageList.Controls.Add(this.textBox12);
            this.tabPageList.Controls.Add(this.textBox13);
            this.tabPageList.Controls.Add(this.buttonLogin);
            this.tabPageList.Controls.Add(this.menuStrip1);
            this.tabPageList.Location = new System.Drawing.Point(4, 22);
            this.tabPageList.Name = "tabPageList";
            this.tabPageList.Size = new System.Drawing.Size(792, 424);
            this.tabPageList.TabIndex = 2;
            this.tabPageList.Text = "Loop";
            this.tabPageList.UseVisualStyleBackColor = true;
            // 
            // buttonSaveFileConfig
            // 
            this.buttonSaveFileConfig.Location = new System.Drawing.Point(202, 221);
            this.buttonSaveFileConfig.Name = "buttonSaveFileConfig";
            this.buttonSaveFileConfig.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveFileConfig.TabIndex = 38;
            this.buttonSaveFileConfig.Text = "SavConfig";
            this.buttonSaveFileConfig.UseVisualStyleBackColor = true;
            this.buttonSaveFileConfig.Click += new System.EventHandler(this.buttonSaveFileConfig_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(490, 241);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 37;
            this.button5.Text = "Result2";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // textBoxResult2
            // 
            this.textBoxResult2.Location = new System.Drawing.Point(476, 65);
            this.textBoxResult2.Multiline = true;
            this.textBoxResult2.Name = "textBoxResult2";
            this.textBoxResult2.Size = new System.Drawing.Size(270, 161);
            this.textBoxResult2.TabIndex = 36;
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(283, 221);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 35;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            // 
            // SaveDialog1
            // 
            this.SaveDialog1.Location = new System.Drawing.Point(651, 241);
            this.SaveDialog1.Name = "SaveDialog1";
            this.SaveDialog1.Size = new System.Drawing.Size(75, 23);
            this.SaveDialog1.TabIndex = 34;
            this.SaveDialog1.Text = "Save";
            this.SaveDialog1.UseVisualStyleBackColor = true;
            this.SaveDialog1.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(24, 176);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 13);
            this.label15.TabIndex = 33;
            this.label15.Text = "Alarm High";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(118, 169);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(240, 20);
            this.textBox10.TabIndex = 32;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(24, 137);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 13);
            this.label16.TabIndex = 31;
            this.label16.Text = "Alarm Low";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(19, 89);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(96, 13);
            this.label17.TabIndex = 30;
            this.label17.Text = "Upper ragne Value";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(19, 50);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(96, 13);
            this.label18.TabIndex = 29;
            this.label18.Text = "Lower range Vaule";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(118, 130);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(240, 20);
            this.textBox11.TabIndex = 28;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(118, 82);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(240, 20);
            this.textBox12.TabIndex = 27;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(118, 50);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(240, 20);
            this.textBox13.TabIndex = 26;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(121, 221);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonLogin.TabIndex = 25;
            this.buttonLogin.Text = "Read";
            this.buttonLogin.UseVisualStyleBackColor = true;
            
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(792, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tabPageSerial
            // 
            this.tabPageSerial.Controls.Add(this.progressBar1);
            this.tabPageSerial.Controls.Add(this.BaudRate);
            this.tabPageSerial.Controls.Add(this.label1);
            this.tabPageSerial.Controls.Add(this.textBoxRececive);
            this.tabPageSerial.Controls.Add(this.buttonReceive);
            this.tabPageSerial.Controls.Add(this.buttonSend);
            this.tabPageSerial.Controls.Add(this.radioButtonDisconncet);
            this.tabPageSerial.Controls.Add(this.radioButtonConnect);
            this.tabPageSerial.Controls.Add(this.buttonDisconnect);
            this.tabPageSerial.Controls.Add(this.buttonConnect);
            this.tabPageSerial.Controls.Add(this.comboBoxbaud);
            this.tabPageSerial.Controls.Add(this.comboBoxIport);
            this.tabPageSerial.Location = new System.Drawing.Point(4, 22);
            this.tabPageSerial.Name = "tabPageSerial";
            this.tabPageSerial.Size = new System.Drawing.Size(792, 424);
            this.tabPageSerial.TabIndex = 3;
            this.tabPageSerial.Text = "Serial";
            this.tabPageSerial.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(68, 252);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(221, 23);
            this.progressBar1.TabIndex = 10;
            // 
            // BaudRate
            // 
            this.BaudRate.AutoSize = true;
            this.BaudRate.Location = new System.Drawing.Point(4, 80);
            this.BaudRate.Name = "BaudRate";
            this.BaudRate.Size = new System.Drawing.Size(58, 13);
            this.BaudRate.TabIndex = 2;
            this.BaudRate.Text = "Baud Rate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Com port";
            // 
            // textBoxRececive
            // 
            this.textBoxRececive.Location = new System.Drawing.Point(295, 35);
            this.textBoxRececive.Multiline = true;
            this.textBoxRececive.Name = "textBoxRececive";
            this.textBoxRececive.ReadOnly = true;
            this.textBoxRececive.Size = new System.Drawing.Size(298, 240);
            this.textBoxRececive.TabIndex = 8;
            this.textBoxRececive.TabStop = false;
            // 
            // buttonReceive
            // 
            this.buttonReceive.Location = new System.Drawing.Point(210, 190);
            this.buttonReceive.Name = "buttonReceive";
            this.buttonReceive.Size = new System.Drawing.Size(75, 23);
            this.buttonReceive.TabIndex = 9;
            this.buttonReceive.Text = "Recive";
            this.buttonReceive.UseVisualStyleBackColor = true;
     
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(210, 138);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 23);
            this.buttonSend.TabIndex = 8;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // radioButtonDisconncet
            // 
            this.radioButtonDisconncet.AutoSize = true;
            this.radioButtonDisconncet.Checked = true;
            this.radioButtonDisconncet.Location = new System.Drawing.Point(172, 200);
            this.radioButtonDisconncet.Name = "radioButtonDisconncet";
            this.radioButtonDisconncet.Size = new System.Drawing.Size(14, 13);
            this.radioButtonDisconncet.TabIndex = 7;
            this.radioButtonDisconncet.TabStop = true;
            this.radioButtonDisconncet.UseVisualStyleBackColor = true;
            // 
            // radioButtonConnect
            // 
            this.radioButtonConnect.AutoSize = true;
            this.radioButtonConnect.Location = new System.Drawing.Point(172, 138);
            this.radioButtonConnect.Name = "radioButtonConnect";
            this.radioButtonConnect.Size = new System.Drawing.Size(14, 13);
            this.radioButtonConnect.TabIndex = 7;
            this.radioButtonConnect.UseVisualStyleBackColor = true;
            this.radioButtonConnect.CheckedChanged += new System.EventHandler(this.radioButtonConnect_CheckedChanged);
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Enabled = false;
            this.buttonDisconnect.Location = new System.Drawing.Point(68, 190);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(75, 23);
            this.buttonDisconnect.TabIndex = 6;
            this.buttonDisconnect.Text = "Disconnect";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(68, 138);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(75, 23);
            this.buttonConnect.TabIndex = 5;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click_1);
            // 
            // comboBoxbaud
            // 
            this.comboBoxbaud.FormattingEnabled = true;
            this.comboBoxbaud.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "19200",
            "38400"});
            this.comboBoxbaud.Location = new System.Drawing.Point(68, 80);
            this.comboBoxbaud.Name = "comboBoxbaud";
            this.comboBoxbaud.Size = new System.Drawing.Size(217, 21);
            this.comboBoxbaud.TabIndex = 4;
            // 
            // comboBoxIport
            // 
            this.comboBoxIport.FormattingEnabled = true;
            this.comboBoxIport.Location = new System.Drawing.Point(68, 35);
            this.comboBoxIport.Name = "comboBoxIport";
            this.comboBoxIport.Size = new System.Drawing.Size(221, 21);
            this.comboBoxIport.TabIndex = 3;
            // 
            // Serialport
            // 
            this.Serialport.PortName = "COM3";
            // 
            // timerChartAdd
            // 
            this.timerChartAdd.Tick += new System.EventHandler(this.timerChartAdd_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.AutoUpgradeEnabled = false;
            this.saveFileDialog1.DefaultExt = "text";
            this.saveFileDialog1.FileName = "SerialConfigurastion";
            this.saveFileDialog1.InitialDirectory = "C:\\source";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // savFileDialogConfig
            // 
            this.savFileDialogConfig.CreatePrompt = true;
            this.savFileDialogConfig.DefaultExt = "ccs";
            this.savFileDialogConfig.FileName = "Insturmentconfig";
            // 
            // serialPort1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlMain);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "serialPort1";
            this.Text = "serial port com";
            this.Load += new System.EventHandler(this.serialPort1_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageString.ResumeLayout(false);
            this.tabPageString.PerformLayout();
            this.tabPageLoop.ResumeLayout(false);
            this.tabPageLoop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabPageList.ResumeLayout(false);
            this.tabPageList.PerformLayout();
            this.tabPageSerial.ResumeLayout(false);
            this.tabPageSerial.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageString;
        private System.Windows.Forms.TabPage tabPageLoop;
        private System.Windows.Forms.TabPage tabPageList;
        private System.Windows.Forms.TabPage tabPageSerial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.TextBox textBoxInput2;
        private System.Windows.Forms.TextBox textBoxInput1;
        private System.Windows.Forms.Button buttonResult;
        private System.Windows.Forms.Label BaudRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxRececive;
        private System.Windows.Forms.Button buttonReceive;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.RadioButton radioButtonDisconncet;
        private System.Windows.Forms.RadioButton radioButtonConnect;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.ComboBox comboBoxbaud;
        private System.Windows.Forms.ComboBox comboBoxIport;
        private System.IO.Ports.SerialPort Serialport;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBoxVa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timerSerialReceicve;
        private System.Windows.Forms.Timer timerChartAdd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button SaveDialog1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBoxResult2;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.SaveFileDialog savFileDialogConfig;
        private System.Windows.Forms.Button buttonSaveFileConfig;
    }
}

