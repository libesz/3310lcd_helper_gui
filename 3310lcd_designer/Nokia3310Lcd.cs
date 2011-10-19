using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.IO.Ports;
using System.Windows.Forms;
using System.Drawing;

namespace Nokia3310AvrHelper
{
    public class Nokia3310Lcd
    {
        public string imgpath = "";
        public Bitmap img;
        public int xOffset = 0;
        public int yOffset = 0;
        public bool useSerialPort = false;

        public Nokia3310Lcd()
        {
            img = new Bitmap(84,48);
        }

        public bool processFile( SerialPort serialPort )
        {
            if (!File.Exists(imgpath))
            {
                return false;
            }

            StreamReader imgfile = new StreamReader(imgpath);

            byte[] buffer = renderData(imgfile.BaseStream);
            if (useSerialPort)
            {
                sendData(buffer, serialPort);
            }
            return true;
        }

        public string makePGMCode()
        {
            string code = "";
            int buffer_index = 0;
            if (!File.Exists(imgpath))
            {
                return "";
            }

            StreamReader imgfile = new StreamReader(imgpath);

            byte[] buffer = renderData(imgfile.BaseStream);
            code = "unsigned char PROGMEM splash [514] = {";
            for (buffer_index = 0; buffer_index < 513; buffer_index++)
            {
                if( ( buffer_index % 10 ) == 0 )
                {
                    code += "\n   ";
                }
                code += buffer[buffer_index].ToString();
                code += ", ";
            }
            code += buffer[buffer_index].ToString();
            code += "\n};\n";
            return code;
        }

        public byte[] renderData(Stream fileStream)
        {
            byte[] buffer = new byte[514];
            try
            {
                img = new Bitmap(fileStream);
            }
            catch
            {
                MessageBox.Show("Not valid image");
                fileStream.Close();
                return buffer;
            }
            fileStream.Close();

            int buffer_index = 0;

            if ((img.Height >= 48) && (img.Width >= 84))
            {
                for (int y = yOffset; y < (48 + yOffset); y += 8)
                {
                    for (int x = xOffset; x < (84 + xOffset); x++)
                    {
                        for (byte y_temp = 0; y_temp < 8; y_temp++)
                        {
                            Color temp_color = img.GetPixel(x, y + y_temp);
                            if (128 > temp_color.R)
                            {
                                buffer[buffer_index] |= (byte)(1 << y_temp);
                            }
                        }
                        buffer_index++;
                    }
                }
            }
            return buffer;
        }

        private void sendData( byte[] buffer, SerialPort serialPort )
        {
            if (!serialPort.IsOpen)
            {
                try
                {
                    serialPort.Open();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return;
                }
            }

            byte[] startsign = new byte[1];
            startsign[0] = 0x55;

            serialPort.Write(startsign, 0, 1);
            serialPort.Write(buffer, 0, 514);
            serialPort.Close();
        }
    }
}
