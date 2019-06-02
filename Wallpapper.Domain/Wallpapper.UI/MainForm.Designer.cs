namespace Wallpapper.UI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.imageViewer = new Telerik.WinControls.UI.RadListView();
            ((System.ComponentModel.ISupportInitialize)(this.imageViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // imageViewer
            // 
            this.imageViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageViewer.EnableKineticScrolling = true;
            this.imageViewer.FullRowSelect = false;
            this.imageViewer.ItemSize = new System.Drawing.Size(300, 300);
            this.imageViewer.KeyboardSearchEnabled = true;
            this.imageViewer.Location = new System.Drawing.Point(0, 0);
            this.imageViewer.Name = "imageViewer";
            this.imageViewer.Size = new System.Drawing.Size(740, 466);
            this.imageViewer.TabIndex = 0;
            this.imageViewer.ViewType = Telerik.WinControls.UI.ListViewType.IconsView;
            this.imageViewer.SelectedItemChanged += new System.EventHandler(this.imageViewer_SelectedItemChanged);
            this.imageViewer.VisualItemFormatting += new Telerik.WinControls.UI.ListViewVisualItemEventHandler(this.imageViewer_VisualItemFormatting);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 466);
            this.Controls.Add(this.imageViewer);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wallpapper";
            ((System.ComponentModel.ISupportInitialize)(this.imageViewer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadListView imageViewer;
    }
}

