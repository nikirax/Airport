using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airport.View
{
    public partial class AddPassengers : Form
    {
        public AddPassengers()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mistakes m = new Mistakes();
            if (m.mistakes(textBox1.Text) ||
                m.mistakes(textBox2.Text))
            {
                MessageBox.Show("Чувак тут чет не то");
            }
            else
            {
                string path = @"C:\Users\nikit\source\repos\Airport\Airport\Resource\Passengers.xlsx";
                FileInfo filePath = new FileInfo(path);//добаляем наш файл
                using (var excelPack = new ExcelPackage(filePath))//в новом потоке записываем новые значения
                {
                    var ws = excelPack.Workbook.Worksheets.FirstOrDefault();//рабочий лист
                    int j = Convert.ToInt32(ws.Cells[1, 6].Value);//кастыль он тут нужен
                    ws.Cells[j, 1].Value = j;//ID
                    ws.Cells[j, 2].Value = textBox1.Text;//Name
                    ws.Cells[j, 3].Value = textBox2.Text;//LastName
                    ws.Cells[j, 4].Value = numericUpDown1.Value;//NumberPassport
                    ws.Cells[j, 5].Value = numericUpDown2.Value;//Number Reis
                    j++;
                    ws.Cells[1, 6].Value = j;//записываем кастыль
                    excelPack.Save();//не забываем сохранить
                }
            }
        }

        private void AddPassengers_FormClosed(object sender, FormClosedEventArgs e)
        {
            // вызываем главную форму приложения, которая открыла текущую форму Form2, главная форма всегда = 0
            Form ifrm = Application.OpenForms[0];
            ifrm.Show();
        }
    }
}
