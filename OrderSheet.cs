using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaProject
{
    public partial class frmOrderSheet : Form
    {
        private  string _TotalPrice;
        
        public frmOrderSheet(string TotalPrice)
        {
            InitializeComponent();

            _TotalPrice = TotalPrice;
        }

        private void frmOrderSheet_Load(object sender, EventArgs e)
        {
            lblPrice.Text = _TotalPrice;

            GenerateSpecialCode();
            
        }

        private void GenerateSpecialCode()
        {
            string Temp = "";
            Random rnd = new Random();

            Temp += Convert.ToString(rnd.Next(1, 9));
            Temp += Convert.ToString(rnd.Next(1, 9));

            lblSpecialCode.Text = Temp +"#" +Convert.ToChar(rnd.Next(65, 90));
        }
    }
}
