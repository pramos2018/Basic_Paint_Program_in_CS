using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NS_BasicPaintApp
{
    public partial class BasicPaintApp : Form
    {
        //Project Variables
        Graphics g1, g2;
        Color dColor;
        Pen dPen;
        Brush dBrush;
        Font dFont;
        int size_h, size_w, dsize = 50;
        String selShape = "", selItem = "";
        Point lp1, lp2, p1, p2;
        
        string CurrFile = "";
        Bitmap currBmp;
        Image currImg;
        bool flagImg = false;

        bool flagPaint = false, flagFill = false, flagP1= false;

        public BasicPaintApp()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            start();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }



        //***************** Code *********************************//
        private void start()
        {

            int pw = panel1.Width;
            int ph = panel1.Height;

            currBmp = new Bitmap(pw, ph);
            g1 = Graphics.FromImage(currBmp);
            g2 = panel1.CreateGraphics();

            dsize = 50; size_h = 50; size_w = 50;

            //-----------------------------
            txtSize.Text = dsize.ToString();
            penSize.Value = 2;
            //------------------------------
            
            dColor = Color.Black;
            dBrush = new SolidBrush(dColor);
            dPen = new Pen(dBrush,2);
            flagPaint = false;
            flagFill = false;
            flagP1 = true;
            selShape = "Rectangle";
            createDropDown();
            dFont = txtInput.Font;
            clearScreen();

        }
        private void createDropDown()
        {
            shapDropBox.Items.Clear();
            shapDropBox.Items.Add("Drawing");
            shapDropBox.Items.Add("Rectangle (p1,p2)");
            shapDropBox.Items.Add("Ellipse (p1,p2)");
            shapDropBox.Items.Add("Square");
            shapDropBox.Items.Add("Rectangle (H)");
            shapDropBox.Items.Add("Rectangle (V)");
            shapDropBox.Items.Add("Circle");
            shapDropBox.Items.Add("Line");
            shapDropBox.Items.Add("Text");
            shapDropBox.Items.Add("Erase");
            shapDropBox.Items.Add("Erase Range");
            shapDropBox.SelectedIndex = 0;
            setShape();

        }
        private void setShape()
        {
            selItem = shapDropBox.SelectedItem.ToString();
            //MessageBox.Show(selItem);

            dsize = Convert.ToInt32(txtSize.Text);
            size_w = dsize; size_h = dsize;
            selShape = selItem;
            switch (selItem)
            {
                case "Drawing": selShape = "Drawing"; break;
                case "Square": selShape = "Rectangle"; break;
                case "Rectangle (V)": selShape = "Rectangle"; size_w = dsize; size_h = dsize * 2; break;
                case "Rectangle (H)": selShape = "Rectangle"; size_w = dsize * 2; size_h = dsize; break;
                case "Circle": selShape = "Ellipse"; break;
                case "Line": selShape = "Line"; break;
                default: break;
            }
            flagP1 = true;
            lblStatus.Text = "Selected Shape: " + selShape;
        }

        private void drawAnimation(Graphics g, String shape, Pen pen, Brush sb, int x, int y, int sz_w, int sz_h)
        {
            switch (shape)
            {
                case "Rectangle (p1,p2)":
                    if (flagP1 == false){
                        lp2 = new Point(x, y);
                        if (flagFill == false) g.DrawRectangle(pen, lp1.X, lp1.Y, lp2.X - lp1.X, lp2.Y - lp1.Y);
                        if (flagFill == true) g.FillRectangle(sb, lp1.X, lp1.Y, lp2.X - lp1.X, lp2.Y - lp1.Y);
                    }
                    break;
                case "Ellipse (p1,p2)":
                    if (flagP1 == false){
                        lp2 = new Point(x, y);
                        if (flagFill == false) g.DrawEllipse(pen, lp1.X, lp1.Y, lp2.X - lp1.X, lp2.Y - lp1.Y);
                        if (flagFill == true) g.FillEllipse(sb, lp1.X, lp1.Y, lp2.X - lp1.X, lp2.Y - lp1.Y);
                    }
                    break;

                case "Rectangle":
                    if (flagFill == false) g.DrawRectangle(pen, x, y, sz_w, sz_h);
                    if (flagFill == true) g.FillRectangle(sb, x, y, size_w, size_h);
                    break;
                case "Ellipse":
                    if (flagFill == false) g.DrawEllipse(pen, x, y, sz_w, sz_h);
                    if (flagFill == true) g.FillEllipse(sb, x, y, size_w, size_h);
                    break;
                case "Line":
                    if (flagP1 == false) lp2 = new Point(x, y); g.DrawLine(pen, lp1, lp2);
                    break;
                case "Text":
                    if (txtInput.Text.Length > 0)
                    {
                        Point p2 = new Point(x, y); g.DrawString(txtInput.Text, dFont, sb, p2);
                    }
                    break;
                //********** Edit Events [Copy, Cut, Paste] ***********
                case "Erase":
                    g2.DrawRectangle(new Pen(Color.Blue, 1), x , y, sz_w, sz_h);
                    break;
                case "Erase Range":
                    if (flagP1 == false) 
                    {
                        lp2 = new Point(x, y);
                        g2.DrawRectangle(new Pen(Color.Blue, 1), lp1.X, lp1.Y, lp2.X - lp1.X, lp2.Y - lp1.Y);
                    }
                    break;
                case "Copy Image":
                    if (flagP1 == false) 
                    {
                        lp2 = new Point(x,y);
                        g2.DrawRectangle(new Pen(Color.Blue, 1), lp1.X, lp1.Y, lp2.X - lp1.X, lp2.Y - lp1.Y);
                    }

                    break;
                case "Cut Image":
                    if (flagP1 == false) 
                    {
                        lp2 = new Point(x,y);
                        g2.DrawRectangle(new Pen(Color.Blue, 1), lp1.X, lp1.Y, lp2.X - lp1.X, lp2.Y - lp1.Y);
                    }

                    break;
                case "Paste Image":
                    if (flagImg == true)
                    {
                        lp2 = new Point(x,y);
                        g2.DrawImage(currImg, lp2);
                    }
                    break;

                //******************************************************
                default: break;
            }
            lblStatus.Text = "Selected Shape: " + selShape;
        }
        
        
        private void drawShape(Graphics g, String shape, Pen pen, Brush sb, int x, int y, int sz_w, int sz_h)
        {
                switch (shape) {
                    case "Rectangle (p1,p2)":
                        if (flagP1 == true){
                            lp1 = new Point(x, y); flagP1 = false;
                        } else{
                            lp2 = new Point(x, y); flagP1 = true;
                            if (flagFill == false) g.DrawRectangle(pen, lp1.X, lp1.Y, lp2.X-lp1.X,lp2.Y-lp1.Y);
                            if (flagFill == true) g.FillRectangle(sb, lp1.X, lp1.Y, lp2.X - lp1.X, lp2.Y - lp1.Y);
                        }
                        break;
                    case "Ellipse (p1,p2)":
                        if (flagP1 == true)
                        {
                            lp1 = new Point(x, y); flagP1 = false;
                        }
                        else
                        {
                            lp2 = new Point(x, y); flagP1 = true;
                            if (flagFill == false) g.DrawEllipse(pen, lp1.X, lp1.Y, lp2.X - lp1.X, lp2.Y - lp1.Y);
                            if (flagFill == true) g.FillEllipse(sb, lp1.X, lp1.Y, lp2.X - lp1.X, lp2.Y - lp1.Y);
                        }
                        break;
                    case "Rectangle":
                        if (flagFill == false) g.DrawRectangle(pen, x, y, sz_w, sz_h);
                        if (flagFill == true ) g.FillRectangle(sb, x, y, size_w, size_h);
                        break;
                    case "Ellipse": 
                        if (flagFill == false) g.DrawEllipse(pen, x, y, sz_w, sz_h);
                        if (flagFill == true) g.FillEllipse(sb, x, y, size_w, size_h);
                        break;
                    case "Line":
                        if (flagP1==true){
                            lp1 = new Point(x,y); flagP1 = false;
                        } else {
                            lp2 = new Point(x, y);g.DrawLine(pen, lp1, lp2); flagP1 = true;
                        }
                        break;
                    case "Text":
                        if (txtInput.Text.Length > 0){
                            Point p2 = new Point(x, y); g.DrawString(txtInput.Text, dFont, sb, p2);
                        }
                        break;
                    case "Erase":
                        g.FillRectangle(new SolidBrush(panel1.BackColor), x, y, size_w, size_h);
                        break;
                    case "Erase Range":
                        if (flagP1 == true){lp1 = new Point(x, y); flagP1 = false;
                        }else{
                            lp2 = new Point(x, y); flagP1 = true;
                            g.FillRectangle(new SolidBrush(panel1.BackColor), lp1.X, lp1.Y, lp2.X-lp1.X, lp2.Y-lp1.Y);
                        }
                        break;
                    //********** Edit Events [Copy, Cut, Paste] ***********
                    case "Copy Image":
                        if (flagP1==true){
                            lp1 = new Point(x,y); flagP1 = false;
                        } else {
                            lp2 = new Point(x, y);
                            flagP1 = true; int w1 = lp2.X - lp1.X; int h1 = lp2.Y - lp1.Y;
                            Rectangle r = new Rectangle(lp1.X, lp1.Y, w1, h1);
                            try
                            {
                                Clipboard.SetImage(CopyBitmap(currBmp, r));
                                setPaste(); // Paste After Copy
                            }
                            catch (Exception ex) { }
                        }
                        break;
                    case "Cut Image":
                        if (flagP1==true) {
                            lp1 = new Point(x, y); flagP1 = false;
                        } else {
                            lp2 = new Point(x, y); int w1 = lp2.X - lp1.X; int h1 = lp2.Y - lp1.Y;
                            Rectangle r = new Rectangle(lp1.X, lp1.Y, w1, h1);
                            Clipboard.SetImage(CopyBitmap(currBmp, r));
                            try
                            {
                                sb = new SolidBrush(panel1.BackColor);
                                g.FillRectangle(sb, lp1.X, lp1.Y, lp2.X - lp1.X, lp2.Y - lp1.Y);
                                flagP1 = true;
                                setPaste(); // Paste After Copy
                            }
                            catch (Exception ex) { }

                        }

                        break;
                    case "Paste Image":
                        g.DrawImage(currImg, lp2); setShape();
                        break;
                    //******************************************************
                    default:break;
                }
                lblStatus.Text = "Selected Shape: " + selShape;
        }
        private void clearScreen()
        {
            g1.Clear(panel1.BackColor);
            MoveGraphics();
        }
        private void SaveFile()
        {
            if (CurrFile == "" || CurrFile == null)
            {
                SaveAs();
                return;
            }
            try
            {
                if (currBmp != null)
                {
                    currBmp.Save(CurrFile, System.Drawing.Imaging.ImageFormat.Bmp);
                }
                MessageBox.Show("File '" + CurrFile + "' Saved!", "Save File");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Saving Bitmap to File '" + CurrFile + "\nError: " + ex.Message, "Save File Error");
            }


        }
        private void SaveAs()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = "C:\\temp";
            //sfd.DefaultExt = "Bitmaps | *.bmp | All Files | *.*";
            sfd.FileName = "C:\\temp\\csharp1.bmp";
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                CurrFile = sfd.FileName;
                //FileStatus();
                SaveFile();
            }
        }
        private void OpenFile()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = "C:\\temp";
            ofd.DefaultExt = "Bitmaps | *.bmp | All Files | *.*";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                CurrFile = ofd.FileName;
                try
                {

                    Image tmp = Image.FromFile(CurrFile);
                    int pw = tmp.Width;
                    int ph = tmp.Height;

                    if (panel1.Width > pw)  {pw = panel1.Width; }
                    if (panel1.Height > ph) {ph = panel1.Height; }

                    currBmp = new Bitmap(pw, ph);
                    g1 = Graphics.FromImage(currBmp);
                    g2 = panel1.CreateGraphics();
                    clearScreen();

                    g1.Clear(panel1.BackColor);
                    g1.DrawImage(tmp, new Point(0, 0));
                    MoveGraphics();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Opening the File! \nError: " + ex.Message, "Error");
                    CurrFile = "";
                }

            }
            //FileStatus();
        }

        private void resizePanel()
        {
            try
            {
               Bitmap tmp = currBmp;
               int pw = currBmp.Width;
               int ph = currBmp.Height;

               if (ph < panel1.Height) ph = panel1.Height;
               if (pw < panel1.Width) pw = panel1.Width;

                currBmp = new Bitmap(pw, ph);
                g1 = Graphics.FromImage(currBmp);
                g2 = panel1.CreateGraphics();
                
                clearScreen();
                g1.DrawImage(tmp, new Point(0, 0));
                MoveGraphics();
            }
            catch (Exception ex) { }
            //MessageBox.Show("Window Resized!");
        }
        private Bitmap CopyBitmap(Bitmap srcBitmap, Rectangle section)
        {
                //Routine from MSDN
                // Create the new bitmap and associated graphics object
                Bitmap bmp = new Bitmap(section.Width, section.Height);
                Graphics g3 = Graphics.FromImage(bmp);

                // Draw the specified section of the source bitmap to the new one
                g3.DrawImage(srcBitmap, 0, 0, section, GraphicsUnit.Pixel);

                // Clean up
                g3.Dispose();

                // Return the bitmap
            return bmp;
        }

        private void MoveGraphics()
        {
            g2.DrawImage(currBmp, 0, 0);
        }
        private void setPaste()
        {
            selShape = "Paste Image";
            flagP1 = true;
            lblStatus.Text = "Selected Shape: " + selShape;
            try
            {
                flagImg = true;
                currImg = Clipboard.GetImage();
            }
            catch (Exception ex)
            {
                flagImg = false;
            };
        }


        //*********************[Panel Events]*********************//
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (selShape == "Drawing")
            {
                flagPaint = true;
            }
            p1 = new Point(e.X, e.Y);
        }
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (selShape == "Drawing") flagP1 = true;
            flagPaint = false;

        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            drawShape(g1, selShape, dPen, dBrush, e.X, e.Y, size_w, size_h);
            MoveGraphics();// g1 - BitMap, g2 - Panel
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (flagPaint == true && selShape == "Drawing")
            {
                p2 = new Point(e.X, e.Y);
                g1.DrawLine(dPen, p1, p2);
                p1 = p2;
                MoveGraphics();// g1 - BitMap, g2 - Panel
            }
            if (selShape != "Drawing") {//Animation
                MoveGraphics();// g1 - BitMap, g2 - Panel
                drawAnimation(g2, selShape, dPen, dBrush, e.X, e.Y, size_w, size_h);
            }
        }
        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            MoveGraphics();
        }

        //**************** Graphical User Interface **************//

        private void shapDropBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            setShape();
        }

        private void ckBoxFill_CheckedChanged(object sender, EventArgs e)
        {
            if (ckBoxFill.Checked == true)
            {
                flagFill = true;
            }
            else
            {
                flagFill = false;
            }
        }

        private void clearScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearScreen();
        }

        private void penSize_ValueChanged(object sender, EventArgs e)
        {
            int ps = Convert.ToInt32(penSize.Value);
            dPen = new Pen(dColor, ps);
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                dColor = cd.Color;
                int ps = Convert.ToInt32(penSize.Value);
                dPen = new Pen(dColor, ps);
                dBrush = new SolidBrush(dColor);
                btnColor.ForeColor = cd.Color;
            }

        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                dFont = fd.Font;
                txtInput.Font= fd.Font;
                txtInput.Font = new Font(txtInput.Font.FontFamily, 10);
            }
        }

        private void newFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrFile = "";
            clearScreen();
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void saveFileAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAs();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void btnCut_Click(object sender, EventArgs e)
        {
            selShape = "Cut Image";
            flagP1 = true;
            lblStatus.Text = "Selected Shape: " + selShape;
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            selShape = "Copy Image";
            flagP1 = true;
            lblStatus.Text = "Selected Shape: " + selShape;
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            setPaste();
        }

        private void menuHelp_Click(object sender, EventArgs e)
        {
            String msg = "";
            msg = msg + "Basic Paint Program \n";
            msg = msg + "Made as Part of a Training Program \n";
            msg = msg + "By Paulo Ramos @ Jul/2016 \n";
            MessageBox.Show(msg, "Basic Paint Program");
        }

        private void txtSize_MouseLeave(object sender, EventArgs e)
        {
            setShape();
        }

        private void Form5_ResizeEnd(object sender, EventArgs e)
        {
        }

        private void panel1_Resize(object sender, EventArgs e)
        {
            resizePanel();
        }

        //********************************************************//


    }
}
