using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using MyLibrary;
namespace Payroll
{
    public partial class frmShowImage : Form
    {
        public frmShowImage(Image img)
        {
            InitializeComponent();
            imgShow.Image = img;
        }
        public frmShowImage()
        {
            InitializeComponent();
            
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlHeader_MouseMove(object sender, MouseEventArgs e)
        {
            NSANIMATION.Animations.DragControl(this.Handle);
        }
    }
}
