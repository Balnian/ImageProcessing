using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImageProcess;
using System.Drawing.Imaging;
using System.IO;

namespace ImageProcessing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BT_Process_Click(object sender, EventArgs e)
        {
            if (PB_Original.Image != null)
            {
                //PB_Processed.Image = BumpMap.FromColorImage(PB_Original.Image);

                //PB_Processed.Image = GrayScale.Luma(PB_Original.Image);

                PB_Processed.Image = Blur.Mean(PB_Original.Image);





                

            }





        }

        private void BT_FeedBack_Click(object sender, EventArgs e)
        {
            if(PB_Processed.Image!=null)
            {
                PB_Original.Image = (Image)PB_Processed.Image.Clone(); 
            }
        }

        private void BT_Save_Click(object sender, EventArgs e)
        {
            if(PB_Processed.Image!=null)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.DefaultExt=".png";
                sfd.AddExtension=true;
                
                if(sfd.ShowDialog()==System.Windows.Forms.DialogResult.OK)
                {
                    using (Stream strm = sfd.OpenFile())
                    {
                        PB_Processed.Image.Save(strm, ImageFormat.Png);
                    }
                    

                }
                
            }
        }
    }
}
