using System.Drawing;
using System.Windows.Forms;

namespace AutoDrawerer
{
    public partial class Form2 : Form
    {
        Bitmap imagePreview = Form1.imagePreview;

        public Form2()
        {
            InitializeComponent();
            if (imagePreview.Width < 220)
            {
                pictureBox1.Anchor = AnchorStyles.None;
                CenterPictureBox(pictureBox1, imagePreview);
                this.Opacity = 0.5;

            }
            else
            {
                pictureBox1.Image = imagePreview;
                this.Opacity = 0.5;
            }
        }

        private void CenterPictureBox(PictureBox picBox, Bitmap picImage)
        {
            picBox.Image = picImage;
            picBox.Location = new Point((picBox.Parent.ClientSize.Width / 2) - (picImage.Width / 2),
                                        (picBox.Parent.ClientSize.Height / 2) - (picImage.Height / 2));
            picBox.Refresh();
        }

        private void label1_Click(object sender, System.EventArgs e)
        {

        }
    }
}
