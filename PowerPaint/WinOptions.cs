using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace PowerPaint
{
    public partial class WinOptions : Form
    {
        int numobject;
        

        
        public WinOptions()
        {
            MainMenu mn = new MainMenu();
            InitializeComponent();
            

        }

        private void WinOptions_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(MainWin.numselobj.ToString());
            numobject = MainWin.numselobj;
            button1.BackColor = MainWin.objectlist.list[numobject].color;
            ReciveDate();
        }


        // Изменение X
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            MainWin.objectlist.list[numobject].x = Convert.ToInt32(numericUpDown1.Value);
        }

        // Изменение Y
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            MainWin.objectlist.list[numobject].y = Convert.ToInt32(numericUpDown2.Value);
        }

        // Изменение W
        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            MainWin.objectlist.list[numobject].height = Convert.ToInt32(numericUpDown3.Value);
        }

        // Изменение H
        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            MainWin.objectlist.list[numobject].width = Convert.ToInt32(numericUpDown4.Value);
        }

        public void ReciveDate()
        {
            if (numobject != -1)
            {
                numericUpDown1.Value = MainWin.objectlist.list[numobject].x;
                numericUpDown2.Value = MainWin.objectlist.list[numobject].y;
                numericUpDown3.Value = MainWin.objectlist.list[numobject].width;
                numericUpDown4.Value = MainWin.objectlist.list[numobject].height;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.AllowFullOpen = true;
            if (MyDialog.ShowDialog() == DialogResult.OK)
            {
                MainWin.objectlist.list[numobject].color = MyDialog.Color;
                button1.BackColor = MyDialog.Color;
            }
        }
    }
}
