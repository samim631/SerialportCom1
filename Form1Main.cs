using System;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;

namespace SerialportCom1
{
    public partial class serialPort1 : Form
    {
        public object SerialportCom { get; private set; }
        public static bool IsOpen { get; private set; }
        public object TextBoxtFile { get; private set; }

        public serialPort1()
        {
            InitializeComponent();
        }
        /*
        private void serialPort1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            comboBoxIport.Items.AddRange(ports);
        }
        */
        string dataOUT;

        string receicedConfig = "C38IT001;0.0;500.O;40;440";
        string[] insturmentConfigs;
        private object timerserialReceive;
        private string[] insturmentconfig;

        //List<MeasurmentPoint> allMeausredPoint = new List<measurementPoint>();

        double chartXValue = 0.0;
        double chartYValue = 0.0;
        private TextBox textBoxTagname;
        private MeasurmentPoint measuredPoin;
        private static readonly int BytesToRead;

        private void buttonReceive_Click(object sender, EventArgs e)
        {
            if (radioButtonConnect.Checked)
            {

                textBoxRececive.Text = Serialport.ReadExisting();
            }


        }

        private void serialPort1_Load(object sender, EventArgs e)
        {
            comboBoxIport.Items.Clear();
            string[] comPorts = SerialPort.GetPortNames();
            foreach (string ports in comPorts)
            {
                comboBoxIport.Items.Add(ports);



            }


        }

        private void buttonResult_Click_1(object sender, EventArgs e)
        {
            try

            {
                int tmInteger = int.Parse(textBoxInput1.Text);
                textBoxInput2.Text = tmInteger.ToString();

            }
            catch (FormatException)

            {
                MessageBox.Show("Successful!");

            }

            finally
            {

                textBoxInput1.Clear();
                textBoxInput1.Focus();
            }

            if (checkBox1.Checked)
            {
                textBoxResult.AppendText("" + textBoxInput1.Text.IndexOf(textBoxInput2.Text) + "\r\n");


            }
            else
            {
                textBoxResult.AppendText("" + textBoxInput1.Text.ToLower().IndexOf(textBoxInput2.Text.ToLower()) + "\r\n");
            }
            string[] splitInput = textBoxInput1.Text.Split(';');

            for (int i = 0; i < splitInput.Length; i++)
            {
                textBoxResult.AppendText(string.Format("string no{0} is :{1}\r\n", i, splitInput[i]));

            }

        }

        private void buttonConnect_Click_1(object sender, EventArgs e)
        {
            if (comboBoxIport.SelectedIndex > -1)
            {
                Serialport.PortName = comboBoxIport.Items[comboBoxIport.SelectedIndex].ToString();
                if (comboBoxbaud.SelectedIndex > -1)
                {
                    Serialport.BaudRate = Convert.ToInt32(comboBoxbaud.Items[comboBoxbaud.SelectedIndex]);
                    try
                    {
                        Serialport.Open();
                        radioButtonConnect.Checked = true;



                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Unable to conncet");
                        radioButtonConnect.Checked = false;

                    }



                }
            }
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (textBoxRececive.Text.Length > 0)
            {
                Serialport.WriteLine(textBoxRececive.Text);
            }
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            Serialport.Close();
            radioButtonConnect.Checked = false;
            timerSerialReceicve.Enabled = false;

        }

        private void radioButtonConnect_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string fileName = "";
            string[] textFileCon = { "Hello", "World" };
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileName = saveFileDialog1.FileName;
                File.WriteAllLines(fileName, textFileCon);

                MessageBox.Show(fileName);
            }
        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }


        private void FromMain_Load(object sender, EventArgs e)
        {

            insturmentConfigs = new string[5];
        }


        private void buttonSaveFileConfig_Click(object sender, EventArgs e)
        {

            if (savFileDialogConfig.ShowDialog() == DialogResult.OK)
            {

                // File.WriteAllLines(savFileDialogConfig.FileName, string.Join(";",insturmentsonfigs));


            }
        }

        private void timerChartAdd_Tick(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine("ReadSensor");
                timerSerialReceicve.Enabled = true;
                timerChartAdd.Enabled = false;
            }
        }

        private static void WriteLine(string v)
        {
            throw new NotImplementedException();
        }

        private void buttonReceive_Click_1(object sender, EventArgs e, object measuredPoint)
        {
            if (serialPort1.BytesToRead > 0)
            {
                MeasurmentPoint measurmentPoint;
                string avilableDate = "";
                avilableDate += serialPort1.ReadExisting().ToString();
                string[] analogReadings = avilableDate.Split(';');
                /*
                TextBoxtFile.AppendText(avilableDate);
                if (analogReadings.Length == 3)
                {
                    measuredPoin = new MeasurmentPoint(DateTime.Now.ToLongTimeString(), Convert.ToInt32(analogReadings[0], Convert.ToInt32(analogReadings[1]));

                    chart1.Series[0].Points.AddXY(measuredPoin.Time, measuredPoint.Va);
                    chart1.Series[1].Points.AddXY(measuredPoin.Time, measuredPoint.Vb);
                    chart1.Series[2].Points.AddXY(measuredPoin.Time, measuredPoint.Vab);
                    allMeasuredPoints.Add(measurmentPoint);
                }
                */

                timerChartAdd.Enabled = true;
                timerSerialReceicve.Enabled = false;
            }
        }

        private static object ReadExisting()
        {
            throw new NotImplementedException();
        }

        public class MeasurmentPoint
        {
            internal double Time;

            public string time { get; set; }
            public int Va { get; set; }
            public int Vb { get; set; }
            public int Vab { get; set; }

            public MeasurmentPoint(String time, int Va, int Vb, int Vab)
            {
                this.time = time;
                this.Va = Va;
                this.Vb = Vb;
                this.Vab = Vab;

            }

            public override string ToString()
            {
                //return base.ToString();
                return time + ";" + Va + ";" + ";" + Vab;
            }

        }

        public class Insturment
        {
            private int measurement;

            public Insturment(int measurment)
            {
                this.measurement = measurement;
            }




            public Insturment(string tagname, string unit, double lrv, double urv)
            {

                this.tagname = tagname;
                this.unit = unit;
                this.lrv = lrv;
                this.urv = urv;

            }

            public string tagname


            {

                get { return tagname; }
                set { tagname = value; }

            }

            public String unit { get; set; }
            public double lrv { get; set; }
            public double urv { get; set; }


            public double Scaled()
            {

                return measurement / 10.0;
            }

        }

        private void buttonLogin_Click(object sender, EventArgs e, TextBox textBoxAL)
        {
            insturmentConfigs = receicedConfig.Split(';');
            TextBox textBoxLRV = null;
            TextBox textBoxURV = null;
            TextBox textBoxLH = null;
            TextBox[] textBoxes = {textBoxTagname,
                                   textBoxLRV,
                                   textBoxURV,
                                   textBoxAL,
                                   textBoxLH,


            };


            textBoxes[0].Text = insturmentConfigs[0];
            
            //textBoxTagname.Text = insturmentConfigs[0];
            textBoxesLRV.Text = insturmentConfigs[1];
            textBoxesURV.Text = insturmentConfigs[2];
            textBoxAL.Text = insturmentConfigs[3];
            textBoxAH.Text = insturmentConfigs[4];

        }

        private class textBoxesURV
        {
            public static string Text { get; internal set; }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen)
            {
                dataOUT = textBoxRececive.Text;
                serialPort1.WriteLine(dataOUT);
            }
        }
        /*
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
            string writeString;
            string passwordString = "password1234";
            writeString="writeconf>" + passwordString + ">" + string.Join(";", insturmentconfig);
            textBoxResult.Clear();
            textBoxResult.Text = writeString;
           
        }
        
        */

        private void buttonLogin_Click(object sender, EventArgs e)
        {

            textBoxResult2.Clear();
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {

              /*  foreach(string Line in File.ReadLines(openFileDialog1.FileNames))*/
                    
                      /*(  textBoxResult2.AppendText(Line)*/
            }
           
        }

        private void serialPort1_Load_1(object sender, EventArgs e)
        {

        }
    }

    internal class allMeasuredPoints
    {
    }

    internal class textBoxAH
    {
        internal static string Text;
    }

    internal class textBoxesLRV
    {
        public static string Text { get; internal set; }
    }
}


