using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CamuseHome
{
    public partial class PictureView : Form
    {
        public PictureView(Image image)
        {
            InitializeComponent();

            PictureBox pb = new PictureBox();
            pb.SizeMode = PictureBoxSizeMode.AutoSize;
            pb.Image = image;
            pb.Size = image.Size; ;
            this.Controls.Add(pb);
        }
    }
}
