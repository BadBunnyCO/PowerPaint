﻿using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;



namespace PowerPaint
{
    public partial class MainWin : Form
    {
        // Цвета палитры
        Color FirsColor = Color.Black;
        Color SecondColor = Color.White;
        // Диалоговое окно палитры
        ColorDialog MyDialog;

        Bitmap picture;
        Bitmap repicture;
        
        PanelChangeSize PicSize;

        ObjectList objectlist;

        MyPicture temp;
        // объект для копирования
        Figure copypust;

        // Номер выбранного объекта
        int numselobj = -1;
        // Статус нажатия левой кнопки мыши
        bool leftmousepress = false;
        // Статус нажатия правой кнопки мыши
        bool rightmousepress = false;


        int ax, ay, bx, by, ex, ey;

        public MainWin()
        {
            InitializeComponent();

            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";

            // авторазмер
            Size = this.Size;
            groupBox2.Size = new Size(Size.Width - 43, Size.Height - 161);
            groupBox2.Refresh();
            //

            // цвет 
            button1.BackColor = FirsColor;
            button2.BackColor = SecondColor;
            // диалоговое окно цвета
            MyDialog = new ColorDialog();

            // класс для изменения размера области рисования
            PicSize = new PanelChangeSize(ResizePanel, PicPanel);

            // битмапы
            picture = new Bitmap(PicPanel.Width, PicPanel.Height);
            repicture = new Bitmap(PicPanel.Width, PicPanel.Height);

            PicPanel.ContextMenuStrip = contextMenuStrip1;
            
            
            // лист со всеми объектами
            //objectlist.list = new List<Figure>();
            objectlist = new ObjectList();


            // двойная буфферизация, для лучшей отрисовки
            this.DoubleBuffered = true;

            ///////////////////
            objectlist.list.Add(new MyRectangle(15, 36, 50, 50));
            objectlist.list.Add(new MyRectangle(215, 116, 50, 50));
            objectlist.list.Add(new MyTriangle(65, 86, 50, 50));


            Size = this.Size;
            groupBox2.Size = new Size(Size.Width - 43, Size.Height - 161);
            groupBox2.Refresh();            

        }


        // Выход
        private void выходToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.Clear(BackColor);
            PicSize.draw(g);
        }

        // Фукция изменения размера элементов при изминении размера окна
        private void MainWin_Resize(object sender, EventArgs e) 
        {
            Size = this.Size;
            groupBox2.Size = new Size(Size.Width - 43, Size.Height - 161);
            groupBox2.Refresh();
        }

        // Фукция изменения размера зоны рисования
        private void ResizePanel_MouseMove(object sender, MouseEventArgs e)
        {
            
            if (e.Button == MouseButtons.Left)
            {
                label1.Text = e.X.ToString() + "  " + e.Y.ToString();

                PicSize.Resize(e.X, e.Y);
            }
            else
            {
                PicSize.hitiff();
            }
        }

        

        // палитра 1
        private void button1_Click(object sender, EventArgs e)
        {
            if (MyDialog.ShowDialog() == DialogResult.OK)
                button1.BackColor = MyDialog.Color;
        }
        // 
        // палитра 2
        private void button2_Click(object sender, EventArgs e)
        {
            if (MyDialog.ShowDialog() == DialogResult.OK)
                button2.BackColor = MyDialog.Color;
        }


        
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (numselobj != -1 && objectlist.list[numselobj].selected)
            {
                objectlist.list.RemoveAt(numselobj);
                numselobj = -1;
                PicPanel.Refresh();
                
            }
        }

        private void цветToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (numselobj != -1 && objectlist.list[numselobj].selected)
            {
                if (MyDialog.ShowDialog() == DialogResult.OK)
                objectlist.list[numselobj].ChangeColor(MyDialog.Color);
                PicPanel.Refresh();
            }
        }

        private void новыйФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            objectlist.list.Clear();
            picture = new Bitmap(PicPanel.Width, PicPanel.Height);
            PicPanel.Refresh();
        }


        // Сохранение изображения в Json файл
        private void какФалйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Фильтр расширения файлов
            saveFileDialog1.Filter = "JSON (*.json)|*.json|All files(*.*)|*.*";
            // Вызов диалогового окна выбора файла
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // опция сериализации
                JsonSerializerSettings settings = new JsonSerializerSettings()
                {
                    // настройка сохранения в JSON информации о типах
                    TypeNameHandling = Newtonsoft.Json.TypeNameHandling.All
                };
                // Сериализуем данные в строчку
                string serialized = JsonConvert.SerializeObject(objectlist, settings);
                // Сохраняем в файл
                File.WriteAllText(saveFileDialog1.FileName, serialized);

            }
        }

        // Загрузка изображения в Json файл
        private void какФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Фильтр расширения файлов
            openFileDialog1.Filter = "JSON (*.json)|*.json|All files(*.*)|*.*";
            // Вызов диалогового окна выбора файла
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // опция сериализации
                JsonSerializerSettings settings = new JsonSerializerSettings()
                {
                    // настройка сохранения в JSON информации о типах
                    TypeNameHandling = Newtonsoft.Json.TypeNameHandling.All
                };
                // читаем весь текст из файла
                string serialized = File.ReadAllText(openFileDialog1.FileName);
                // десериализуем текст и запимываем данные в оьъект
                objectlist = JsonConvert.DeserializeObject<ObjectList>(serialized, settings);
                PicPanel.Refresh();
            }
        }

        // Сохранить изображение как Jpeg
        private void какJpegToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap savepic = new Bitmap(PicPanel.Width,PicPanel.Height);
            Graphics g = Graphics.FromImage(savepic);
            g.Clear(Color.White);   
            g.DrawImage(picture, 0, 0, PicPanel.Width, PicPanel.Height);

            foreach (Figure obj in objectlist.list)
            {
                obj.draw(g);
            }

            saveFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|PNG|*.png|EMF|*.emf";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:
                        savepic.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;

                    case 2:
                        savepic.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
                        break;

                    case 3:
                        savepic.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Png);
                        break;
                    case 4:
                        savepic.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Emf);
                        break;
                }
            }
        }

        // Загрузка изображения как Jpeg
        private void какJpegToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|PNG|*.png|EMF|*.emf|All files(*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                picture = new Bitmap(openFileDialog1.FileName);
                PicPanel.Refresh();
            }

        }

        private void PicPanel_Resize(object sender, EventArgs e)
        {
            PicPanel.Refresh();
        }

        private void ResizePanel_Resize(object sender, EventArgs e)
        {
            ResizePanel.Refresh();
        }

        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(numselobj != -1)
            {
                copypust = objectlist.list[numselobj].Clone();
            }
        }

        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (copypust != null)
            {
                copypust.Move(ex, ey);
                objectlist.list.Add(copypust);
                PicPanel.Refresh();
            }

        }

        private void PicPanel_MouseDown(object sender, MouseEventArgs e)
        {
            
            // иструменты рисования

            if (MouseButtons == MouseButtons.Left)
            {
                leftmousepress = true;

                if (radioButton1.Checked)
                {
                    switch (comboBox1.Text)
                    {
                        case "Прямоугольник":
                            objectlist.list.Add(new MyRectangle(ex, ey, 5, 5));
                            objectlist.list[objectlist.list.Count-1].ChangeColor(button1.BackColor);
                            PicPanel.Refresh();
                            break;

                        case "Круг":
                            objectlist.list.Add(new MyCircle(ex, ey, 5, 5));
                            objectlist.list[objectlist.list.Count-1].ChangeColor(button1.BackColor);
                            PicPanel.Refresh();
                            break;

                        case "Треугольник":
                            objectlist.list.Add(new MyTriangle(ex, ey, 5, 5));
                            objectlist.list[objectlist.list.Count - 1].ChangeColor(button1.BackColor);
                            PicPanel.Refresh();
                            break;

                        case "Линия":
                            objectlist.list.Add(new MyLine(ex, ey, 5, 5));
                            objectlist.list[objectlist.list.Count - 1].ChangeColor(button1.BackColor);
                            PicPanel.Refresh();
                            break;

                        case "Текст":
                            objectlist.list.Add(new MyText(ex, ey, 5, 5));
                            objectlist.list[objectlist.list.Count - 1].ChangeColor(button1.BackColor);
                            PicPanel.Refresh();
                            break;

                        case "Картинка":
                            objectlist.list.Add(new MyPicture(ex, ey, 5, 5));
                            objectlist.list[objectlist.list.Count - 1].ChangeColor(button1.BackColor); 
                            PicPanel.Refresh();
                            break;

                    }

                }
                // Курсор
                if (radioButton2.Checked)
                {
                    numselobj = -1;
                    for (int i = 0; i < objectlist.list.Count; i++)
                    {
                        if (objectlist.list[i].Selected(ex, ey))
                        {
                            numselobj = i;
                            ax = objectlist.list[i].x - ex;
                            ay = objectlist.list[i].y - ey;
                        };
                    }
                    PicPanel.Refresh();
                }
            }

            if (MouseButtons == MouseButtons.Right)
            {
                rightmousepress = true;
                foreach (Figure obj in objectlist.list)
                {
                    obj.Selected(ex,ey);
                }
            }
        }

        private void PicPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftmousepress)
            {
                leftmousepress = false;

                if (radioButton1.Checked)
                {
                    switch (comboBox1.Text)
                    {
                        case "Картинка":
                            var temp = objectlist.list[objectlist.list.Count-1];
                            objectlist.list.RemoveAt(objectlist.list.Count-1);
                            MyPicture f = new MyPicture(temp.x,temp.y,temp.width,temp.height);
                            MessageBox.Show(temp.GetType().ToString());
                            openFileDialog1.Filter = "JPEG (*.jpg)|*.jpg|All files(*.*)|*.*";
                            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                            {
                                f.SetPicture(openFileDialog1.FileName);
                                objectlist.list.Add(f);
                            }
                            PicPanel.Refresh();
                            break;

                    }
                }

                    //MessageBox.Show(objectlist.Count.ToString());
                }
            if (rightmousepress)
            {
                leftmousepress = false;
                //MessageBox.Show(objectlist.Count.ToString());
            }

        }

        private void PicPanel_MouseClick(object sender, MouseEventArgs e)
        {
            if(MouseButtons == MouseButtons.Right)
            {
                
            }
        }

        private void PicPanel_MouseMove(object sender, MouseEventArgs e)
        {
            ex = e.X;
            ey = e.Y;

            // действие при зажатой мышке
            if (leftmousepress)
            {
                label1.Text = ex + " " + ey;
                // инструменты
                if (radioButton1.Checked)
                {
                    objectlist.list[objectlist.list.Count-1].ResizeCor(ex, ey);
                    PicPanel.Refresh();
                }
                // курсор
                if (radioButton2.Checked)
                {
                    if (numselobj != -1 && objectlist.list[numselobj].selected)
                    {
                        objectlist.list[numselobj].Move(ex, ey, ax, ay);
                        PicPanel.Refresh();
                    }
                }



            }
            


        }

        
        private void PicPanel_Paint(object sender, PaintEventArgs e)
        {
            //e.Graphics.Clear(Color.White);
            e.Graphics.DrawImage(picture,0 ,0, PicPanel.Width,PicPanel.Height);
            //e.Graphics.DrawImage(picture, Point.Empty);
            foreach (Figure obj in objectlist.list)
            {
                obj.draw(e.Graphics);
            }
        }
    }
}