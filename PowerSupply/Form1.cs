using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace PowerSupply
{
    public partial class Form1 : Form
    {
        private TcpClient client;
        private NetworkStream stream;
        private System.Windows.Forms.Timer measurementTimer;
        private BindingList<MeasurementEntry> measurementEntries = new BindingList<MeasurementEntry>();

        private List<double> timeData = new List<double>();
        private List<double> voltageData = new List<double>();
        private double timeCounter = 0;

        public Form1()
        {
            InitializeComponent();

            formsPlot1.Plot.Axes.SetLimitsX(0, 10);
            formsPlot1.Plot.Axes.SetLimitsY(0, 10);
            formsPlot1.Plot.YLabel("Voltage (V)");
            formsPlot1.Plot.XLabel("Time (s)");
            formsPlot1.Visible = true;
            formsPlot1.Refresh();

            InitializeMeasurementTimer();

            dataGridMeasurements.AutoGenerateColumns = true;
            dataGridMeasurements.DataSource = measurementEntries;
        }

        private void InitializeMeasurementTimer()
        {
            measurementTimer = new System.Windows.Forms.Timer();
            measurementTimer.Interval = 10;
            measurementTimer.Tick += MeasurementTimer_Tick;
        }

        private void MeasurementTimer_Tick(object sender, EventArgs e)
        {
            MeasureAndLog();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                string ip = txtIPAddress.Text.Trim();
                if (string.IsNullOrWhiteSpace(ip))
                {
                    MessageBox.Show("Please enter a valid IP address.");
                    return;
                }

                client = new TcpClient();
                client.Connect(ip, 5025);
                stream = client.GetStream();

                MessageBox.Show("Connected successfully!", "Info");

                measurementTimer.Start();
            }
            catch (SocketException ex)
            {
                MessageBox.Show($"Socket Error: {ex.Message}", "Connection Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"General Error: {ex.Message}", "Connection Error");
            }
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            try
            {
                SendCommand($"VOLT {txtVoltage.Text}");
                SendCommand($"CURR {txtCurrent.Text}");
                MessageBox.Show("Voltage and Current Set!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error setting parameters: " + ex.Message);
            }
        }

        private void btnOutputOn_Click(object sender, EventArgs e)
        {
            try
            {
                SendCommand("OUTP ON");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnOutputOff_Click(object sender, EventArgs e)
        {
            try
            {
                SendCommand("OUTP OFF");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void SendCommand(string command)
        {
            if (stream != null && stream.CanWrite)
            {
                byte[] data = Encoding.ASCII.GetBytes(command + "\n");
                stream.Write(data, 0, data.Length);
            }
        }

        private string QueryResponse(string command)
        {
            if (stream != null && stream.CanWrite && stream.CanRead)
            {
                byte[] data = Encoding.ASCII.GetBytes(command + "\n");
                stream.Write(data, 0, data.Length);

                byte[] buffer = new byte[1024];
                int bytes = stream.Read(buffer, 0, buffer.Length);
                return Encoding.ASCII.GetString(buffer, 0, bytes).Trim();
            }
            return string.Empty;
        }

        private void btnMeasure_Click(object sender, EventArgs e)
        {
            MeasureAndLog();
        }

        private void MeasureAndLog()
        {
            try
            {
                string voltageStr = QueryResponse("MEAS:VOLT?");
                string currentStr = QueryResponse("MEAS:CURR?");

                if (double.TryParse(voltageStr, out double voltage) &&
                    double.TryParse(currentStr, out double current))
                {
                    double power = voltage * current;
                    string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                    measurementEntries.Add(new MeasurementEntry
                    {
                        Timestamp = timestamp,
                        Voltage = voltage,
                        Current = current,
                        Power = power
                    });

                    lblOutput.Text = $"Voltage: {voltage:F3} V\nCurrent: {current:F3} A\nPower: {power:F3} W";

                    // ➕ Add to graph
                    timeData.Add(timeCounter);
                    voltageData.Add(voltage);
                    timeCounter += 1;

                    // Scroll window: Keep last 100 points
                    if (timeData.Count > 100)
                    {
                        timeData.RemoveAt(0);
                        voltageData.RemoveAt(0);
                    }

                    formsPlot1.Plot.Clear();
                    formsPlot1.Plot.Add.Scatter(timeData.ToArray(), voltageData.ToArray());
                    formsPlot1.Refresh();
                }
                else
                {
                    lblOutput.Text = "Failed to parse voltage or current.";
                }
            }
            catch (Exception ex)
            {
                measurementTimer.Stop();
                MessageBox.Show("Measurement error: " + ex.Message);
            }
        }

        private void btnSendCommand_Click(object sender, EventArgs e)
        {
            try
            {
                string userCommand = txtCommand.Text.Trim();
                if (!string.IsNullOrWhiteSpace(userCommand))
                {
                    string response = QueryResponse(userCommand);
                    lblOutput.Text = $"SCPI > {userCommand}\nResponse: {response}";
                }
                else
                {
                    MessageBox.Show("Please enter a SCPI command.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnExportLog_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Text files (*.txt)|*.txt";
                    saveFileDialog.Title = "Save Measurement Log";
                    saveFileDialog.FileName = "PowerLog.txt";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        var lines = new List<string> { "Timestamp\tVoltage (V)\tCurrent (A)\tPower (W)" };
                        lines.AddRange(measurementEntries.Select(entry =>
                            $"{entry.Timestamp}\t{entry.Voltage:F3}\t{entry.Current:F3}\t{entry.Power:F3}"));
                        File.WriteAllLines(saveFileDialog.FileName, lines);

                        MessageBox.Show("Log saved successfully.", "Export Log");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving log: " + ex.Message);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            measurementTimer?.Stop();
            stream?.Close();
            client?.Close();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    public class MeasurementEntry
    {
        public string Timestamp { get; set; }
        public double Voltage { get; set; }
        public double Current { get; set; }
        public double Power { get; set; }
    }
}