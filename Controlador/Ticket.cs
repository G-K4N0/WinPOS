using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Text;
using System.Drawing;
using System.IO;

namespace Controlador
{
    public class Ticket
    {
        private SerialPort _serialPort;

        public Ticket(string portName, int baudRate)
        {
            _serialPort = new SerialPort(portName, baudRate);
            _serialPort.Parity = Parity.None;
            _serialPort.StopBits = StopBits.One;
            _serialPort.DataBits = 8;
            _serialPort.Handshake = Handshake.None;
        }

        public void OpenConnection()
        {
            try
            {
                if (!_serialPort.IsOpen)
                {
                    _serialPort.Open();
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Error al abrir el puerto: {ex.Message}");
                throw;
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine($"Acceso no autorizado al puerto: {ex.Message}");
                throw;
            }
        }


        public void CloseConnection()
        {
            if (_serialPort.IsOpen)
            {
                _serialPort.Close();
            }
        }

        public void PrintTicket(List<Tuple<string, Font>> lines)
        {
            if (_serialPort.IsOpen)
            {
                byte[] alignCenter = { 0x1B, 0x61, 0x01 }; // ESC a 1
                byte[] alignLeft = { 0x1B, 0x61, 0x00 };   // ESC a 0
                byte[] lineFeed = { 0x0A }; // LF
                byte[] cutPaper = { 0x1D, 0x56, 0x00 };  // ESC d 0

                foreach (var line in lines)
                {
                    string text = line.Item1;
                    Font font = line.Item2;

                    // Use a simple mapping for font sizes (adjust as needed)
                    byte[] fontSize = GetFontSize(font);

                    _serialPort.Write(fontSize, 0, fontSize.Length); // Set font size
                    _serialPort.Write(alignLeft, 0, alignLeft.Length); // Left align

                    byte[] textBytes = Encoding.ASCII.GetBytes(text + "\n");
                    _serialPort.Write(textBytes, 0, textBytes.Length);
                    _serialPort.Write(lineFeed, 0, lineFeed.Length); // Line feed
                }

                _serialPort.Write(cutPaper, 0, cutPaper.Length);
            }
            else
            {
                throw new InvalidOperationException("La impresora no está conectada");
            }
        }


        private IEnumerable<string> FormatLine(string line, int maxLength)
        {
            for (int i = 0; i < line.Length; i += maxLength)
            {
                if (i + maxLength > line.Length)
                {
                    yield return line.Substring(i);
                }
                else
                {
                    yield return line.Substring(i, maxLength);
                }
            }
        }
        private byte[] GetFontSize(Font font)
        {
           
            if (font.Size == 7) return new byte[] { 0x1B, 0x21, 0x10 }; // Small font
            if (font.Size == 6) return new byte[] { 0x1B, 0x21, 0x00 }; // Normal font
           
            return new byte[] { 0x1B, 0x21, 0x00 }; 
        }
    }
}
