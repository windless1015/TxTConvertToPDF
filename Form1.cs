using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using iTextSharp.text;
using iTextSharp.text.pdf;

namespace TXTConvertPDF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string fileAbsolutePath = "";


        private void button_convert_Click(object sender, EventArgs e)
        {
            if (!File.Exists(fileAbsolutePath))
                return;
            string[] lines = System.IO.File.ReadAllLines(fileAbsolutePath, Encoding.GetEncoding("gb2312"));
            //iTextSharp.text.PageSize.A4    自定义页面大小
            Document document = new Document(PageSize.A4, 50, 50, 50, 50);
            //构造生成的地址
            string generatePDFFullPath = fileAbsolutePath.Remove(fileAbsolutePath.Length - 4) + ".pdf";
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(generatePDFFullPath, FileMode.Create));
            document.Open();
            BaseFont baseFont = BaseFont.CreateFont(@"c:\\windows\\fonts\\msyh.ttc,1", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font font = new iTextSharp.text.Font(baseFont, 11, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

            Paragraph paragraph;
            foreach (string line in lines)
            {
                paragraph = new Paragraph(line, font);
                document.Add(paragraph);
            }
            document.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "C:\\Users\\st\\Desktop\\";
            openFileDialog.Filter = "文本文件|*.txt|所有文件|*.*";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileAbsolutePath = System.IO.Path.GetFullPath(openFileDialog.FileName);
            }
            else
                return;

            StringBuilder sbuilder = new StringBuilder();
            using (FileStream fs = new FileStream(fileAbsolutePath, FileMode.Open))
            {
                using (StreamReader sr = new StreamReader(fs, System.Text.Encoding.Default))
                {
                    while (!sr.EndOfStream)
                    {
                        string sLine = sr.ReadLine();
                        if (sLine.Length < 1)
                        {
                            continue;
                        }
                        sbuilder.AppendLine(sLine);
                    }
                }
            }

            textBox_txt.Text = sbuilder.ToString();
        }
    }
}
