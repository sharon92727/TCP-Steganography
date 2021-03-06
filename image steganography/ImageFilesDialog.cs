using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace PictureKey
{
	/// <summary>
	/// Zusammendfassende Beschreibung f�r ImagesDialog.
	/// </summary>
	public class ImageFilesDialog : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ListView lvImages;
		private System.Windows.Forms.ColumnHeader clmPixels;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.Splitter splitter2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.GroupBox grpAddImage;
		private System.Windows.Forms.TextBox txtImageFile;
		private System.Windows.Forms.Button btnImageFile;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.PictureBox picSelectedImage;
		private System.Windows.Forms.TextBox txtDstFile;
		private System.Windows.Forms.Button btnDstFile;
		private System.Windows.Forms.ColumnHeader clmSrcFileName;
		private System.Windows.Forms.ColumnHeader clmDstFileName;
		private System.Windows.Forms.ColumnHeader clmGrayscale;
		private System.Windows.Forms.Label lblDstFile;
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		private bool showSaveAsFields;

		public ImageFilesDialog(CarrierImage[] initialImages, bool showSaveAsFields){
			//
			// Erforderlich f�r die Windows Form-Designerunterst�tzung
			//
			InitializeComponent();

			//adapt ListView
			this.showSaveAsFields = showSaveAsFields;
			if( ! showSaveAsFields){
				lvImages.Columns.Remove(clmDstFileName);
				lvImages.Columns.Remove(clmPixels);
				lvImages.Columns.Remove(clmGrayscale);
				lvImages.CheckBoxes = false;
				clmSrcFileName.Width = lvImages.Width - 10;
				lblDstFile.Enabled = txtDstFile.Enabled = btnDstFile.Enabled = false;
			}

			//list initial items
			ListViewItem item;
			foreach(CarrierImage file in initialImages){
				if(showSaveAsFields){
					item = new ListViewItem(
						new String[4]{ String.Empty, file.sourceFileName, file.resultFileName, file.countPixels.ToString() }
						);
					item.Checked = file.useGrayscale;
				}else{
					item = new ListViewItem(
						new String[1]{ file.sourceFileName }
						);
				}
				item.Tag = file;
				lvImages.Items.Add(item);
			}

		}

		/// <summary>
		/// Die verwendeten Ressourcen bereinigen.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Erforderliche Methode f�r die Designerunterst�tzung. 
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor ge�ndert werden.
		/// </summary>
		private void InitializeComponent()
		{
            this.lvImages = new System.Windows.Forms.ListView();
            this.clmGrayscale = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmSrcFileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmDstFileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmPixels = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpAddImage = new System.Windows.Forms.GroupBox();
            this.txtDstFile = new System.Windows.Forms.TextBox();
            this.btnDstFile = new System.Windows.Forms.Button();
            this.lblDstFile = new System.Windows.Forms.Label();
            this.txtImageFile = new System.Windows.Forms.TextBox();
            this.btnImageFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.picSelectedImage = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.grpAddImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSelectedImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lvImages
            // 
            this.lvImages.CheckBoxes = true;
            this.lvImages.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmGrayscale,
            this.clmSrcFileName,
            this.clmDstFileName,
            this.clmPixels});
            this.lvImages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvImages.FullRowSelect = true;
            this.lvImages.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvImages.Location = new System.Drawing.Point(0, 0);
            this.lvImages.MultiSelect = false;
            this.lvImages.Name = "lvImages";
            this.lvImages.Size = new System.Drawing.Size(639, 294);
            this.lvImages.TabIndex = 0;
            this.lvImages.UseCompatibleStateImageBehavior = false;
            this.lvImages.View = System.Windows.Forms.View.Details;
            this.lvImages.SelectedIndexChanged += new System.EventHandler(this.lvImages_SelectedIndexChanged);
            this.lvImages.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvImages_KeyDown);
            // 
            // clmGrayscale
            // 
            this.clmGrayscale.Text = "Grayscale noise";
            this.clmGrayscale.Width = 120;
            // 
            // clmSrcFileName
            // 
            this.clmSrcFileName.Text = "Image file";
            this.clmSrcFileName.Width = 200;
            // 
            // clmDstFileName
            // 
            this.clmDstFileName.Text = "Save result as";
            this.clmDstFileName.Width = 200;
            // 
            // clmPixels
            // 
            this.clmPixels.Text = "Pixels";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnOk);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.grpAddImage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 297);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(912, 166);
            this.panel1.TabIndex = 1;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(607, 139);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(66, 20);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "OK";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(680, 139);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(67, 20);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // grpAddImage
            // 
            this.grpAddImage.Controls.Add(this.txtDstFile);
            this.grpAddImage.Controls.Add(this.btnDstFile);
            this.grpAddImage.Controls.Add(this.lblDstFile);
            this.grpAddImage.Controls.Add(this.txtImageFile);
            this.grpAddImage.Controls.Add(this.btnImageFile);
            this.grpAddImage.Controls.Add(this.label1);
            this.grpAddImage.Controls.Add(this.btnAdd);
            this.grpAddImage.Location = new System.Drawing.Point(13, 14);
            this.grpAddImage.Name = "grpAddImage";
            this.grpAddImage.Size = new System.Drawing.Size(734, 111);
            this.grpAddImage.TabIndex = 6;
            this.grpAddImage.TabStop = false;
            this.grpAddImage.Text = "Add Image";
            // 
            // txtDstFile
            // 
            this.txtDstFile.Location = new System.Drawing.Point(93, 55);
            this.txtDstFile.Name = "txtDstFile";
            this.txtDstFile.Size = new System.Drawing.Size(427, 20);
            this.txtDstFile.TabIndex = 2;
            // 
            // btnDstFile
            // 
            this.btnDstFile.Location = new System.Drawing.Point(520, 55);
            this.btnDstFile.Name = "btnDstFile";
            this.btnDstFile.Size = new System.Drawing.Size(62, 20);
            this.btnDstFile.TabIndex = 3;
            this.btnDstFile.Text = "Browse...";
            this.btnDstFile.Click += new System.EventHandler(this.btnDstFile_Click);
            // 
            // lblDstFile
            // 
            this.lblDstFile.Location = new System.Drawing.Point(13, 55);
            this.lblDstFile.Name = "lblDstFile";
            this.lblDstFile.Size = new System.Drawing.Size(80, 20);
            this.lblDstFile.TabIndex = 6;
            this.lblDstFile.Text = "Save result as";
            // 
            // txtImageFile
            // 
            this.txtImageFile.Location = new System.Drawing.Point(93, 28);
            this.txtImageFile.Name = "txtImageFile";
            this.txtImageFile.Size = new System.Drawing.Size(427, 20);
            this.txtImageFile.TabIndex = 0;
            // 
            // btnImageFile
            // 
            this.btnImageFile.Location = new System.Drawing.Point(520, 28);
            this.btnImageFile.Name = "btnImageFile";
            this.btnImageFile.Size = new System.Drawing.Size(62, 20);
            this.btnImageFile.TabIndex = 1;
            this.btnImageFile.Text = "Browse...";
            this.btnImageFile.Click += new System.EventHandler(this.btnImageFile_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Source file";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(420, 83);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(160, 20);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add to image files";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 294);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(912, 3);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter2.Location = new System.Drawing.Point(636, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 294);
            this.splitter2.TabIndex = 3;
            this.splitter2.TabStop = false;
            // 
            // picSelectedImage
            // 
            this.picSelectedImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picSelectedImage.Dock = System.Windows.Forms.DockStyle.Right;
            this.picSelectedImage.Location = new System.Drawing.Point(639, 0);
            this.picSelectedImage.Name = "picSelectedImage";
            this.picSelectedImage.Size = new System.Drawing.Size(273, 294);
            this.picSelectedImage.TabIndex = 4;
            this.picSelectedImage.TabStop = false;
            // 
            // ImageFilesDialog
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(912, 463);
            this.ControlBox = false;
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.lvImages);
            this.Controls.Add(this.picSelectedImage);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel1);
            this.Name = "ImageFilesDialog";
            this.Text = "Manage Carrier Images";
            this.panel1.ResumeLayout(false);
            this.grpAddImage.ResumeLayout(false);
            this.grpAddImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSelectedImage)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		public CarrierImage[] GetImages(){
			CarrierImage[] result = new CarrierImage[lvImages.Items.Count];
			for(int n=0; n<lvImages.Items.Count; n++){
				result[n] = (CarrierImage)lvImages.Items[n].Tag;
				result[n].useGrayscale = lvImages.Items[n].Checked;
			}
			return result;
		}
		
		private long DisplayBitmap(String fileName){
			Bitmap bmp = new Bitmap(fileName);
			long countPixels = bmp.Width * bmp.Height;
			picSelectedImage.Image = new Bitmap(bmp);
			bmp.Dispose();
			return countPixels;
		}

		private void btnAdd_Click(object sender, System.EventArgs e) {
			if(txtImageFile.Text.Length > 0){
				if( System.IO.File.Exists(txtImageFile.Text) ){

					//Check the files are already listed
					bool isOkay = true;
					CarrierImage ci;
					foreach(ListViewItem existingItem in lvImages.Items){
						ci = (CarrierImage)existingItem.Tag;
						if((ci.sourceFileName==txtImageFile.Text) || (ci.resultFileName ==txtImageFile.Text)){
							MessageBox.Show("The source file is already in use.");
							isOkay = false;
							existingItem.Selected = true;
							break;
						}else if((txtDstFile.Text.Length > 0)&&(ci.resultFileName==txtDstFile.Text)){
							MessageBox.Show("The destination file is already in use.");
							isOkay = false;
							existingItem.Selected = true;
							break;
						}
					}

					if(isOkay){
						long countPixels = DisplayBitmap(txtImageFile.Text);
						ListViewItem item;
						if(showSaveAsFields){
							//Manage empty carrier images, configure result file names
							item = new ListViewItem(
								new String[4]{ String.Empty, txtImageFile.Text, txtDstFile.Text, countPixels.ToString() }
								);
						}else{
							//Manage carrier images for extraction, there are no results to save, count of pixels is not interesting
							item = new ListViewItem(
								new String[1]{ txtImageFile.Text }
								);
						}
						item.Tag = new CarrierImage(txtImageFile.Text, txtDstFile.Text, countPixels, true);
						item.Checked = true;
						lvImages.Items.Add(item);
					}

				}else{
					MessageBox.Show("File "+txtImageFile.Text+" not found");
				}
			}	
		}

		private void lvImages_SelectedIndexChanged(object sender, System.EventArgs e) {
			if(lvImages.SelectedItems.Count > 0){
				int itemIndex = (showSaveAsFields) ? 1 : 0;
				DisplayBitmap(lvImages.SelectedItems[0].SubItems[itemIndex].Text);
			}
		}

		private void btnOk_Click(object sender, System.EventArgs e) {
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		private void btnCancel_Click(object sender, System.EventArgs e) {
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		private void btnImageFile_Click(object sender, System.EventArgs e) {
			OpenFileDialog dlg = new OpenFileDialog();
			dlg.Filter = "Bitmaps (*.bmp)|*.bmp|Tagged Image File Format(*.tif)|*.tif|PNG-24(*.png)|*.png";
			dlg.Multiselect = false;
			if( dlg.ShowDialog(this) != DialogResult.Cancel){
				txtImageFile.Text = dlg.FileName;
			}
		}

		private void btnDstFile_Click(object sender, System.EventArgs e) {
			SaveFileDialog dlg = new SaveFileDialog();
			dlg.Filter = "Bitmaps (*.bmp)|*.bmp|Tagged Image File Format(*.tif)|*.tif|PNG-24(*.png)|*.png";
			if( dlg.ShowDialog() == DialogResult.OK ){
				txtDstFile.Text = dlg.FileName;
			}
		}

		private void lvImages_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e) {
			if((e.KeyCode == Keys.Delete)&&(lvImages.SelectedItems.Count==1)){
				lvImages.Items.Remove(lvImages.SelectedItems[0]);
			}
		}
	}
}
