using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using PrintExample.Model;
using PrintExample.Service;

namespace PrintExample
{
    using System;
    using System.Drawing;
    using System.Collections;
    using System.ComponentModel;
    using System.Windows.Forms;
    using System.Data;
    using System.IO;

    /// <summary>
    ///    Summary description for Form1.
    /// </summary>
    public class Form1 : System.Windows.Forms.Form
    {
        private IContainer components;
        private System.Windows.Forms.MenuItem HelpAbout;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem PrinterSettingsFile;
        private System.Windows.Forms.MenuItem PreviewFile;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument ThePrintDocument;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.MenuItem ExitFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.MenuItem PrintFile;
        private System.Windows.Forms.MenuItem SaveFile;
        private System.Windows.Forms.MenuItem OpenFile;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.RichTextBox rtxbPrintable;
        private Label label1;
        private Label lblRequestDateTime;
        private Button btnRefresh;
        private RadioButton rbLow;
        private RadioButton rbHigh;
        private StringReader myReader;

        #region MyRegion

        public string BaseUrlService { get; set; }


        #endregion
        public Form1()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();


        }

        /// <summary>
        ///    Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        /// <summary>
        ///    Required method for Designer support - do not modify
        ///    the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.SaveFile = new System.Windows.Forms.MenuItem();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.HelpAbout = new System.Windows.Forms.MenuItem();
            this.ExitFile = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.OpenFile = new System.Windows.Forms.MenuItem();
            this.PrinterSettingsFile = new System.Windows.Forms.MenuItem();
            this.PrintFile = new System.Windows.Forms.MenuItem();
            this.PreviewFile = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.rtxbPrintable = new System.Windows.Forms.RichTextBox();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.ThePrintDocument = new System.Drawing.Printing.PrintDocument();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRequestDateTime = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.rbLow = new System.Windows.Forms.RadioButton();
            this.rbHigh = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // SaveFile
            // 
            this.SaveFile.Index = 1;
            this.SaveFile.Text = "Save...";
            this.SaveFile.Click += new System.EventHandler(this.SaveFile_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(792, 677);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.MaximizeBox = false;
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 1;
            this.menuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.HelpAbout});
            this.menuItem2.Text = "Help";
            // 
            // HelpAbout
            // 
            this.HelpAbout.Index = 0;
            this.HelpAbout.Text = "About...";
            this.HelpAbout.Click += new System.EventHandler(this.HelpAbout_Click);
            // 
            // ExitFile
            // 
            this.ExitFile.Index = 7;
            this.ExitFile.Text = "Exit";
            this.ExitFile.Click += new System.EventHandler(this.ExitFile_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 2;
            this.menuItem3.Text = "-";
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.OpenFile,
            this.SaveFile,
            this.menuItem3,
            this.PrinterSettingsFile,
            this.PrintFile,
            this.PreviewFile,
            this.menuItem5,
            this.ExitFile});
            this.menuItem1.Text = "File";
            // 
            // OpenFile
            // 
            this.OpenFile.Index = 0;
            this.OpenFile.Text = "Open...";
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // PrinterSettingsFile
            // 
            this.PrinterSettingsFile.Index = 3;
            this.PrinterSettingsFile.Text = "Print Settings...";
            this.PrinterSettingsFile.Click += new System.EventHandler(this.PrinterSettingsFile_Click);
            // 
            // PrintFile
            // 
            this.PrintFile.Index = 4;
            this.PrintFile.Text = "Print...";
            this.PrintFile.Click += new System.EventHandler(this.PrintFile_Click);
            // 
            // PreviewFile
            // 
            this.PreviewFile.Index = 5;
            this.PreviewFile.Text = "Print Preview...";
            this.PreviewFile.Click += new System.EventHandler(this.PreviewFile_Click);
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 6;
            this.menuItem5.Text = "-";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "*.txt";
            this.saveFileDialog1.FileName = "myfile.txt";
            this.saveFileDialog1.InitialDirectory = "c:\\";
            this.saveFileDialog1.Title = "Save Text File";
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem2});
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "*.txt";
            this.openFileDialog1.FileName = "myfile.txt";
            this.openFileDialog1.InitialDirectory = "c:\\";
            this.openFileDialog1.Title = "Open a Text File";
            // 
            // rtxbPrintable
            // 
            this.rtxbPrintable.Location = new System.Drawing.Point(29, 12);
            this.rtxbPrintable.Name = "rtxbPrintable";
            this.rtxbPrintable.Size = new System.Drawing.Size(625, 314);
            this.rtxbPrintable.TabIndex = 0;
            this.rtxbPrintable.Text = "";
            // 
            // ThePrintDocument
            // 
            this.ThePrintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.ThePrintDocument_PrintPage);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(698, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Date time of last request:";
            // 
            // lblRequestDateTime
            // 
            this.lblRequestDateTime.AutoSize = true;
            this.lblRequestDateTime.Location = new System.Drawing.Point(698, 69);
            this.lblRequestDateTime.Name = "lblRequestDateTime";
            this.lblRequestDateTime.Size = new System.Drawing.Size(48, 20);
            this.lblRequestDateTime.TabIndex = 2;
            this.lblRequestDateTime.Text = "result";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(690, 281);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(116, 45);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnRefresh_MouseClick);
            // 
            // rbLow
            // 
            this.rbLow.AutoSize = true;
            this.rbLow.Location = new System.Drawing.Point(701, 145);
            this.rbLow.Name = "rbLow";
            this.rbLow.Size = new System.Drawing.Size(57, 24);
            this.rbLow.TabIndex = 4;
            this.rbLow.TabStop = true;
            this.rbLow.Text = "low";
            this.rbLow.UseVisualStyleBackColor = true;
            this.rbLow.CheckedChanged += new System.EventHandler(this.rbLow_CheckedChanged);
            // 
            // rbHigh
            // 
            this.rbHigh.AutoSize = true;
            this.rbHigh.Location = new System.Drawing.Point(702, 174);
            this.rbHigh.Name = "rbHigh";
            this.rbHigh.Size = new System.Drawing.Size(64, 24);
            this.rbHigh.TabIndex = 5;
            this.rbHigh.TabStop = true;
            this.rbHigh.Text = "high";
            this.rbHigh.UseVisualStyleBackColor = true;
            this.rbHigh.CheckedChanged += new System.EventHandler(this.rbHigh_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(8, 19);
            this.ClientSize = new System.Drawing.Size(939, 358);
            this.Controls.Add(this.rbHigh);
            this.Controls.Add(this.rbLow);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblRequestDateTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtxbPrintable);
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Text = "Text Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        protected void HelpAbout_Click(object sender, System.EventArgs e)
        {
            try
            {
                AboutBox myDialog = new AboutBox();
                myDialog.ShowDialog();
                if (myDialog.DialogResult == DialogResult.OK)
                {
                    myDialog.Dispose();
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message.ToString());
            }
        }

        protected void PrinterSettingsFile_Click(object sender, System.EventArgs e)
        {
            this.printDialog1.Document = this.ThePrintDocument;
            printDialog1.ShowDialog();
        }

        protected void Form1_Resize(object sender, System.EventArgs e)
        {

        }

        protected void PreviewFile_Click(object sender, System.EventArgs e)
        {
            try
            {
                string strText = this.rtxbPrintable.Text;
                myReader = new StringReader(strText);
                PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog();
                printPreviewDialog1.Document = this.ThePrintDocument;
                printPreviewDialog1.FormBorderStyle = FormBorderStyle.Fixed3D;
                printPreviewDialog1.ShowDialog();
            }
            catch (Exception exp)
            {
                System.Console.WriteLine(exp.Message.ToString());
            }

        }

        protected void ThePrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs ev)
        {
            float linesPerPage = 0;
            float yPosition = 0;
            int count = 0;
            float leftMargin = ev.MarginBounds.Left;
            float topMargin = ev.MarginBounds.Top;
            string line = null;
            Font printFont = this.rtxbPrintable.Font;
            SolidBrush myBrush = new SolidBrush(Color.Black);

            // Work out the number of lines per page, using the MarginBounds.
            linesPerPage = ev.MarginBounds.Height / printFont.GetHeight(ev.Graphics);

            // Iterate over the string using the StringReader, printing each line.
            while (count < linesPerPage && ((line = myReader.ReadLine()) != null))
            {
                // calculate the next line position based on 
                // the height of the font according to the printing device
                yPosition = topMargin + (count * printFont.GetHeight(ev.Graphics));

                // draw the next line in the rich edit control

                ev.Graphics.DrawString(line, printFont, myBrush, leftMargin, yPosition, new StringFormat());
                count++;
            }

            // If there are more lines, print another page.
            if (line != null)
                ev.HasMorePages = true;
            else
                ev.HasMorePages = false;

            myBrush.Dispose();

        }

        protected void PrintFile_Click(object sender, System.EventArgs e)
        {
            printDialog1.Document = ThePrintDocument;
            string strText = this.rtxbPrintable.Text;
            myReader = new StringReader(strText);
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                this.ThePrintDocument.Print();
            }
        }

        protected void ExitFile_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        protected void SaveFile_Click(object sender, System.EventArgs e)
        {
            try
            {
                // get the file name to save the list view information in from the standard save dialog
                if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    // open a stream for writing and create a StreamWriter to use to implement the stream
                    FileStream fs = new FileStream(@saveFileDialog1.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                    StreamWriter m_streamWriter = new StreamWriter(fs);
                    m_streamWriter.Flush();

                    // Write to the file using StreamWriter class
                    m_streamWriter.BaseStream.Seek(0, SeekOrigin.Begin);

                    // write the rich edit control
                    m_streamWriter.Write(this.rtxbPrintable.Text);

                    // Close the file
                    m_streamWriter.Flush();
                    m_streamWriter.Close();
                }
            }
            catch (Exception em)
            {

            }

        }

        protected void OpenFile_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                    StreamReader m_streamReader = new StreamReader(fs);
                    // Read to the file using StreamReader  class

                    m_streamReader.BaseStream.Seek(0, SeekOrigin.Begin);


                    // Read  each line of the stream and parse until last line is reached
                    this.rtxbPrintable.Text = "";
                    string strLine = m_streamReader.ReadLine();
                    while (strLine != null)
                    {
                        this.rtxbPrintable.Text += strLine + "\n";
                        strLine = m_streamReader.ReadLine();
                    }
                    // Close the stream

                    m_streamReader.Close();
                }
            }
            catch (Exception em)
            {
                System.Console.WriteLine(em.Message.ToString());
            }


        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static void Main(string[] args)
        {
            Application.Run(new Form1());
        }
        // custom properties

        // custom methods and events
        List<RateView> GetTopRates(int numTop, bool orderbyDesc)
        {
            VatClient c = new VatClient();
            var sVat = c.GetData(System.Configuration.ConfigurationSettings.AppSettings["BaseUrl"]);
            List<RateView> ratesByCountry = sVat.Rates.Select(r => new RateView() { CountryName = r.Name, StandardRate = r.Periods.First().Rates.Standard }).ToList();

            if (orderbyDesc)
            {
                return ratesByCountry.OrderByDescending(r => r.StandardRate).Take(numTop).ToList();

            }

            return ratesByCountry.OrderBy(r => r.StandardRate).Take(numTop).ToList();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            rbLow.Checked = true;
            rbHigh.Checked = false;

            InitPrintableArea();
        }

        private void rbLow_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLow.Checked)
            {
                rbHigh.Checked = false;

            }
            else
            {
                rbHigh.Checked = true;
            }
        }

        private void rbHigh_CheckedChanged(object sender, EventArgs e)
        {
            if (rbHigh.Checked)
            {
                rbLow.Checked = false;
            }
            else
            {
                rbLow.Checked = true;
            }
        }

        private void btnRefresh_MouseClick(object sender, MouseEventArgs e)
        {
            InitPrintableArea();
        }

        private void InitPrintableArea()
        {
            try
            {
             

                this.PrinterSettingsFile.Enabled = false;
                this.PrintFile.Enabled = false;
                this.PreviewFile.Enabled = false;

                List<RateView> resList = GetTopRates(3, rbHigh.Checked);
                if (resList.Count > 0)
                {
                    this.PrinterSettingsFile.Enabled = true;
                    this.PrintFile.Enabled = true;
                    this.PreviewFile.Enabled = true;

                    string strResult = String.Empty;
                    foreach (var item in resList)
                    {
                        strResult += "Country: " + item.CountryName + "\t"
                                     + "Standard rate: "
                                     + (String.Format("{0:0.00}", item.StandardRate))
                                     + "\n";
                    }

                    lblRequestDateTime.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"); ;
                    rtxbPrintable.Width = 420;
                    rtxbPrintable.Text = strResult;
                    rtxbPrintable.SelectAll();
                    rtxbPrintable.SelectionTabs = new int[] { 50, 150 };
                    rtxbPrintable.AcceptsTab = true;
                    rtxbPrintable.Select(0, 0);
                }





            }
            catch (Exception ex)
            {
                this.PrinterSettingsFile.Enabled = false;
                this.PrintFile.Enabled = false;
                this.PreviewFile.Enabled = false;

                rtxbPrintable.Text = ex.Message;
            }

        }
    }
}
