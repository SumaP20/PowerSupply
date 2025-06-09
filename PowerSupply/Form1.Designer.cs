namespace PowerSupply
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
            this.txtIPAddress = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVoltage = new System.Windows.Forms.TextBox();
            this.txtCurrent = new System.Windows.Forms.TextBox();
            this.btnSet = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnOutputOn = new System.Windows.Forms.Button();
            this.lblVoltage = new System.Windows.Forms.Label();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.btnOutputOff = new System.Windows.Forms.Button();
            this.btnMeasure = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.txtCommand = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSendCommand = new System.Windows.Forms.Button();
            this.btnExportLog = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.formsPlot1 = new ScottPlot.WinForms.FormsPlot();
            this.dataGridMeasurements = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMeasurements)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIPAddress
            // 
            this.txtIPAddress.Location = new System.Drawing.Point(145, 18);
            this.txtIPAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIPAddress.Name = "txtIPAddress";
            this.txtIPAddress.Size = new System.Drawing.Size(132, 22);
            this.txtIPAddress.TabIndex = 1;
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(336, 15);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(125, 28);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP Address :";
            // 
            // txtVoltage
            // 
            this.txtVoltage.Location = new System.Drawing.Point(177, 58);
            this.txtVoltage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtVoltage.Name = "txtVoltage";
            this.txtVoltage.Size = new System.Drawing.Size(132, 22);
            this.txtVoltage.TabIndex = 4;
            this.txtVoltage.Text = "0";
            // 
            // txtCurrent
            // 
            this.txtCurrent.Location = new System.Drawing.Point(177, 90);
            this.txtCurrent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCurrent.Name = "txtCurrent";
            this.txtCurrent.Size = new System.Drawing.Size(132, 22);
            this.txtCurrent.TabIndex = 7;
            this.txtCurrent.Text = "0";
            // 
            // btnSet
            // 
            this.btnSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSet.Location = new System.Drawing.Point(336, 81);
            this.btnSet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(71, 28);
            this.btnSet.TabIndex = 8;
            this.btnSet.Text = "Set Voltage/Current";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            // 
            // btnOutputOn
            // 
            this.btnOutputOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOutputOn.Location = new System.Drawing.Point(437, 58);
            this.btnOutputOn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOutputOn.Name = "btnOutputOn";
            this.btnOutputOn.Size = new System.Drawing.Size(125, 28);
            this.btnOutputOn.TabIndex = 9;
            this.btnOutputOn.Text = "Output ON";
            this.btnOutputOn.UseVisualStyleBackColor = true;
            this.btnOutputOn.Click += new System.EventHandler(this.btnOutputOn_Click);
            // 
            // lblVoltage
            // 
            this.lblVoltage.AutoSize = true;
            this.lblVoltage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVoltage.Location = new System.Drawing.Point(15, 58);
            this.lblVoltage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVoltage.Name = "lblVoltage";
            this.lblVoltage.Size = new System.Drawing.Size(116, 16);
            this.lblVoltage.TabIndex = 10;
            this.lblVoltage.Text = "Set Voltage(V) :";
            // 
            // lblCurrent
            // 
            this.lblCurrent.AutoSize = true;
            this.lblCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrent.Location = new System.Drawing.Point(16, 90);
            this.lblCurrent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(115, 16);
            this.lblCurrent.TabIndex = 11;
            this.lblCurrent.Text = "Set Current (A) :";
            // 
            // btnOutputOff
            // 
            this.btnOutputOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOutputOff.Location = new System.Drawing.Point(437, 94);
            this.btnOutputOff.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOutputOff.Name = "btnOutputOff";
            this.btnOutputOff.Size = new System.Drawing.Size(125, 28);
            this.btnOutputOff.TabIndex = 12;
            this.btnOutputOff.Text = "Output OFF";
            this.btnOutputOff.UseVisualStyleBackColor = true;
            this.btnOutputOff.Click += new System.EventHandler(this.btnOutputOff_Click);
            // 
            // btnMeasure
            // 
            this.btnMeasure.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMeasure.Location = new System.Drawing.Point(336, 129);
            this.btnMeasure.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMeasure.Name = "btnMeasure";
            this.btnMeasure.Size = new System.Drawing.Size(125, 28);
            this.btnMeasure.TabIndex = 13;
            this.btnMeasure.Text = "Measure";
            this.btnMeasure.UseVisualStyleBackColor = true;
            this.btnMeasure.Click += new System.EventHandler(this.btnMeasure_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(20, 207);
            this.lblOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblOutput.Size = new System.Drawing.Size(671, 189);
            this.lblOutput.TabIndex = 14;
            // 
            // txtCommand
            // 
            this.txtCommand.Location = new System.Drawing.Point(199, 174);
            this.txtCommand.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.Size = new System.Drawing.Size(276, 22);
            this.txtCommand.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 175);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Enter Command :";
            // 
            // btnSendCommand
            // 
            this.btnSendCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendCommand.Location = new System.Drawing.Point(484, 175);
            this.btnSendCommand.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSendCommand.Name = "btnSendCommand";
            this.btnSendCommand.Size = new System.Drawing.Size(79, 28);
            this.btnSendCommand.TabIndex = 17;
            this.btnSendCommand.Text = "Send";
            this.btnSendCommand.UseVisualStyleBackColor = true;
            this.btnSendCommand.Click += new System.EventHandler(this.btnSendCommand_Click);
            // 
            // btnExportLog
            // 
            this.btnExportLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportLog.Location = new System.Drawing.Point(816, 15);
            this.btnExportLog.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExportLog.Name = "btnExportLog";
            this.btnExportLog.Size = new System.Drawing.Size(79, 42);
            this.btnExportLog.TabIndex = 18;
            this.btnExportLog.Text = "Log";
            this.btnExportLog.UseVisualStyleBackColor = true;
            this.btnExportLog.Click += new System.EventHandler(this.btnExportLog_Click);
            // 
            // formsPlot1
            // 
            this.formsPlot1.DisplayScale = 0F;
            this.formsPlot1.Location = new System.Drawing.Point(16, 431);
            this.formsPlot1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.formsPlot1.Name = "formsPlot1";
            this.formsPlot1.Size = new System.Drawing.Size(524, 235);
            this.formsPlot1.TabIndex = 20;
            // 
            // dataGridMeasurements
            // 
            this.dataGridMeasurements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMeasurements.Location = new System.Drawing.Point(799, 81);
            this.dataGridMeasurements.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridMeasurements.Name = "dataGridMeasurements";
            this.dataGridMeasurements.RowHeadersWidth = 51;
            this.dataGridMeasurements.Size = new System.Drawing.Size(499, 585);
            this.dataGridMeasurements.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 704);
            this.Controls.Add(this.dataGridMeasurements);
            this.Controls.Add(this.formsPlot1);
            this.Controls.Add(this.btnExportLog);
            this.Controls.Add(this.btnSendCommand);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCommand);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnMeasure);
            this.Controls.Add(this.btnOutputOff);
            this.Controls.Add(this.lblCurrent);
            this.Controls.Add(this.lblVoltage);
            this.Controls.Add(this.btnOutputOn);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.txtCurrent);
            this.Controls.Add(this.txtVoltage);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtIPAddress);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMeasurements)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtIPAddress;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVoltage;
        private System.Windows.Forms.TextBox txtCurrent;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnOutputOn;
        private System.Windows.Forms.Label lblVoltage;
        private System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.Button btnOutputOff;
        private System.Windows.Forms.Button btnMeasure;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.TextBox txtCommand;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSendCommand;
        private System.Windows.Forms.Button btnExportLog;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private ScottPlot.WinForms.FormsPlot formsPlot1;
        private System.Windows.Forms.DataGridView dataGridMeasurements;
    }
}

