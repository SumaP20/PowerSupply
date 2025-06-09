# Power Supply Controller & Logger (C# WinForms)

This is a Windows Forms application written in C# for controlling a programmable power supply over Ethernet using SCPI commands (TCP/IP).  
It supports setting voltage/current, toggling output, real-time measurement logging, voltage plotting over time using ScottPlot, and exporting logs.

---

## Features

- Connect to a power supply device by IP address (default TCP port 5025)
- Set voltage and current limits remotely
- Turn output ON/OFF via SCPI commands
- Query voltage and current measurements periodically (auto or manual)
- Display timestamped measurements in a grid
- Calculate and show power (Voltage × Current)
- Plot voltage vs time graph with scrolling window (last 100 points)
- Export measurement logs to a text or CSV file
- Send manual SCPI commands and view device responses

---

## How to Use

1. Open the project in Visual Studio 2022 and build it.
2. Run the application.
3. Enter the power supply IP address and click **Connect**.
4. Set desired voltage and current, then click **Set**.
5. Use **Output ON** / **Output OFF** buttons to toggle power output.
6. Measurements will be automatically logged and plotted.
7. Use **Export Log** to save measurements.
8. Optionally, enter custom SCPI commands to communicate with the device directly.

---

## Technologies

- C# and WinForms (.NET Framework)
- TCP/IP Sockets (`System.Net.Sockets`)
- ScottPlot for plotting voltage graphs
- Standard SCPI commands for power supply control

---

## Code Overview

- Uses a `TcpClient` to connect and communicate with the power supply on port 5025.
- Commands are sent as ASCII strings terminated by newline.
- Measurements are queried by sending SCPI commands `"MEAS:VOLT?"` and `"MEAS:CURR?"`.
- Measurements are logged in a `BindingList<MeasurementEntry>` bound to a `DataGridView`.
- Voltage data is plotted against time using ScottPlot with auto-scaling and scrolling.
- A timer triggers measurement queries at 10ms intervals (adjustable).

---

## Sample SCPI Commands Used

| Command           | Description                 |
|-------------------|-----------------------------|
| `VOLT <value>`    | Set output voltage          |
| `CURR <value>`    | Set output current limit    |
| `OUTP ON`         | Turn output on              |
| `OUTP OFF`        | Turn output off             |
| `MEAS:VOLT?`      | Query current voltage       |
| `MEAS:CURR?`      | Query current current       |
