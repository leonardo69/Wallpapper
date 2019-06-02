using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using Wallpapper.Domain;

namespace Wallpapper.UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            LoadImages();
        }

        private void LoadImages()
        {
            const string directoryPath = @"E:\Обои";
            var imagePaths = Loader.LoadFromDirectory(directoryPath);

            foreach (var imagePath in imagePaths)
            {
                var item = new ListViewDataItem
                {
                    Image = Image.FromFile(imagePath),
                    Tag = imagePath,
                    Text = Path.GetFileName(imagePath),
                    ImageAlignment = ContentAlignment.TopCenter,
                    
                    TextAlignment = ContentAlignment.MiddleCenter
                };

                imageViewer.Items.Add(item);
            }
       
        }

        private void imageViewer_VisualItemFormatting(object sender, ListViewVisualItemEventArgs e)
        {
            BaseListViewVisualItem item = new BaseListViewVisualItem();
            //item.Image.
        }

        private void imageViewer_SelectedItemChanged(object sender, System.EventArgs e)
        {
            var item = imageViewer.SelectedItem;
            if (item != null)
            {
                var imageName = item.Text;
                var imagePath = item.Tag?.ToString();
                Changer.SetWallpaper(imagePath);
            }
        }
    }
}
