using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace Nokia3310AvrHelper
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        Nokia3310Lcd lcd;
        int xBegin = 0;
        int xOffsetBegin = 0;
        int yBegin = 0;
        int yOffsetBegin = 0;

        private void loadButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                lcd.imgpath = openFileDialog1.FileName;
                pathLabelValue.Text = lcd.imgpath;
                lcd.xOffset = 0;
                lcd.yOffset = 0;
            }
            if (!lcd.processFile(serialPort1))
            {
                pathLabelValue.Text = "Error on loading file!";
            }
            else
            {
                updateControlsAfterImgProcess();
            }
        }

        private void reloadButton_Click(object sender, EventArgs e)
        {
            lcd.xOffset = 0;
            lcd.yOffset = 0;

            if (!lcd.processFile(serialPort1))
            {
                pathLabelValue.Text = "Error on reloading file!";
            }
            else
            {
                updateControlsAfterImgProcess();
            }
        }

        private void updateControlsAfterImgProcess()
        {
            Graphics g = imgPanel.CreateGraphics();
            drawImg(g);
            widthLabelValue.Text = lcd.img.Width.ToString();
            heightLabelValue.Text = lcd.img.Height.ToString();
            xOffsetValueLabel.Text = lcd.xOffset.ToString();
            yOffsetValueLabel.Text = lcd.yOffset.ToString();
        }

        private void drawImg( Graphics g )
        {
            if (lcd.img is Bitmap)
            {
                Rectangle src = new Rectangle(0+lcd.xOffset, 0+lcd.yOffset, 84, 48);
                Rectangle dst = new Rectangle(0, 0, 84 * 2 + 4, 48 * 2 + 4 );
                GraphicsUnit unit = GraphicsUnit.Pixel;
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
                g.DrawImage(lcd.img, dst, src, unit);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            portComboBox.SelectedIndex = 0;
            lcd = new Nokia3310Lcd();
            lcd.useSerialPort = liveCheckBox.Checked;
            updateControlsAfterImgProcess();
        }

        private void portComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort1.Close();
            serialPort1.PortName = portComboBox.SelectedItem.ToString();
        }

        private void xOffsetPButton_Click(object sender, EventArgs e)
        {
            if (lcd.img is Bitmap)
            {
                if (lcd.xOffset < (lcd.img.Width - 84))
                {
                    lcd.xOffset++;
                    if (!lcd.processFile(serialPort1))
                    {
                        pathLabelValue.Text = "Error on loading file!";
                    }
                    else
                    {
                        updateControlsAfterImgProcess();
                    }
                }
            }
        }

        private void xOffsetNButton_Click(object sender, EventArgs e)
        {
            if (lcd.img is Bitmap)
            {
                if ((lcd.xOffset < (lcd.img.Width - 48) && (lcd.xOffset > 0 )))
                {
                    lcd.xOffset--;
                    if (!lcd.processFile(serialPort1))
                    {
                        pathLabelValue.Text = "Error on loading file!";
                    }
                    else
                    {
                        updateControlsAfterImgProcess();
                    }
                }
            }
        }

        private void yOffsetPButton_Click(object sender, EventArgs e)
        {
            if (lcd.img is Bitmap)
            {
                if (lcd.yOffset < (lcd.img.Height - 84))
                {
                    lcd.yOffset++;
                    if (!lcd.processFile(serialPort1))
                    {
                        pathLabelValue.Text = "Error on loading file!";
                    }
                    else
                    {
                        updateControlsAfterImgProcess();
                    }
                }
            }
        }

        private void yOffsetNButton_Click(object sender, EventArgs e)
        {
            if (lcd.img is Bitmap)
            {
                if ((lcd.yOffset < (lcd.img.Height - 48) && (lcd.yOffset > 0)))
                {
                    lcd.yOffset--;
                    if (!lcd.processFile(serialPort1))
                    {
                        pathLabelValue.Text = "Error on loading file!";
                    }
                    else
                    {
                        updateControlsAfterImgProcess();
                    }
                }
            }
        }

        private void imgPanel_Paint(object sender, PaintEventArgs e)
        {
            drawImg(e.Graphics);
        }

        private void imgPanel_MouseMove(object sender, MouseEventArgs e)
        {
            int xMoved = xBegin - e.X;
            int yMoved = yBegin - e.Y;
            if (e.Button == MouseButtons.Left)
            {
                if ((xOffsetBegin + xMoved) > 0)
                {
                    if ((xOffsetBegin + xMoved) < (lcd.img.Width - 84))
                    {
                        lcd.xOffset = xOffsetBegin + xMoved;
                        xOffsetValueLabel.Text = lcd.xOffset.ToString();
                    }
                    else
                    {
                        lcd.xOffset = lcd.img.Width - 84;
                    }
                }
                else
                {
                    lcd.xOffset = 0;
                }
                if ((yOffsetBegin + yMoved) > 0)
                {
                    if ((yOffsetBegin + yMoved) < (lcd.img.Height - 48))
                    {
                        lcd.yOffset = yOffsetBegin + yMoved;
                        yOffsetValueLabel.Text = lcd.yOffset.ToString();
                    }
                    else
                    {
                        lcd.yOffset = lcd.img.Height - 48;
                    }
                }
                else
                {
                    lcd.yOffset = 0;
                }

                /*if (!lcd.processFile(serialPort1))
                {
                    pathLabelValue.Text = "Error on reloading file!";
                }
                else
                {*/
                    updateControlsAfterImgProcess();
                //}
            }
        }

        private void imgPanel_MouseDown(object sender, MouseEventArgs e)
        {
            xBegin = e.X;
            xOffsetBegin = lcd.xOffset;
            yBegin = e.Y;
            yOffsetBegin = lcd.yOffset;
        }

        private void imgPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if ((xOffsetBegin != lcd.xOffset) || (yOffsetBegin != lcd.yOffset))
            {
                if (!lcd.processFile(serialPort1))
                {
                    pathLabelValue.Text = "Error on reloading file!";
                }
                else
                {
                    updateControlsAfterImgProcess();
                }
            }
            xBegin = 0;
            xOffsetBegin = 0;
            yBegin = 0;
            yOffsetBegin = 0;
        }

        private void liveCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            lcd.useSerialPort = liveCheckBox.Checked;
            if (!lcd.processFile(serialPort1))
            {
                pathLabelValue.Text = "Error on loading file!";
            }
            else
            {
                updateControlsAfterImgProcess();
            }
        }

        private void savePGMButton_Click(object sender, EventArgs e)
        {
            StreamWriter fileStream;
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                fileStream = new StreamWriter(saveFileDialog1.FileName);
                fileStream.Write(lcd.makePGMCode());
                fileStream.Close();
            }
        }
    }
}
