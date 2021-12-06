using Airport.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airport
{
    /// <summary>
    /// Основная форма где можно найти и посмотреть все
    /// </summary>
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Добавляем самолет
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            Form ifrm = new AddAirplains();
            ifrm.Show(); // отображаем 
            this.Hide();
        }
        /// <summary>
        /// Добавляем пассажира
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button7_Click(object sender, EventArgs e)
        {
            Form ifrm = new AddPassengers();
            ifrm.Show(); // отображаем 
            this.Hide();
        }
        /// <summary>
        /// Добавляем рейс
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button8_Click(object sender, EventArgs e)
        {
            Form ifrm = new AddReises();
            ifrm.Show(); // отображаем 
            this.Hide();
        }
    }
}
