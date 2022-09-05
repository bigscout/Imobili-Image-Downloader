namespace Imobili_Image_Downloader
{
    partial class ImageDownloader
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageDownloader));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssl_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssp_progresso = new System.Windows.Forms.ToolStripProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.trackTransparency = new System.Windows.Forms.TrackBar();
            this.trackSize = new System.Windows.Forms.TrackBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdo_center = new System.Windows.Forms.RadioButton();
            this.rdo_topLeft = new System.Windows.Forms.RadioButton();
            this.rdo_bottomLeft = new System.Windows.Forms.RadioButton();
            this.rdo_middleLeft = new System.Windows.Forms.RadioButton();
            this.pbox_preview = new System.Windows.Forms.PictureBox();
            this.rdo_topRight = new System.Windows.Forms.RadioButton();
            this.rdo_bottomCenter = new System.Windows.Forms.RadioButton();
            this.rdo_bottomRight = new System.Windows.Forms.RadioButton();
            this.rdo_middleRight = new System.Windows.Forms.RadioButton();
            this.rdo_topCenter = new System.Windows.Forms.RadioButton();
            this.chk_addLogo = new System.Windows.Forms.CheckBox();
            this.btn_selectLogo = new System.Windows.Forms.Button();
            this.tbx_logo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_download = new System.Windows.Forms.Button();
            this.tbx_link = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chk_config = new System.Windows.Forms.CheckBox();
            this.numSize = new System.Windows.Forms.NumericUpDown();
            this.numTransparency = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bgw_download = new System.ComponentModel.BackgroundWorker();
            this.label4 = new System.Windows.Forms.Label();
            this.chk_openFolder = new System.Windows.Forms.CheckBox();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackTransparency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSize)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_preview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTransparency)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssl_status,
            this.toolStripStatusLabel2,
            this.tssp_progresso});
            this.statusStrip1.Location = new System.Drawing.Point(0, 565);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(374, 26);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssl_status
            // 
            this.tssl_status.AutoSize = false;
            this.tssl_status.Name = "tssl_status";
            this.tssl_status.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.tssl_status.Size = new System.Drawing.Size(207, 21);
            this.tssl_status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(62, 21);
            this.toolStripStatusLabel2.Text = "Progresso:";
            this.toolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tssp_progresso
            // 
            this.tssp_progresso.Name = "tssp_progresso";
            this.tssp_progresso.Size = new System.Drawing.Size(100, 20);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 41;
            this.label5.Text = "Transparência:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 15);
            this.label6.TabIndex = 40;
            this.label6.Text = "Tamanho da Logo:";
            // 
            // trackTransparency
            // 
            this.trackTransparency.BackColor = System.Drawing.SystemColors.Control;
            this.trackTransparency.LargeChange = 10;
            this.trackTransparency.Location = new System.Drawing.Point(204, 256);
            this.trackTransparency.Maximum = 100;
            this.trackTransparency.Minimum = 10;
            this.trackTransparency.Name = "trackTransparency";
            this.trackTransparency.Size = new System.Drawing.Size(155, 45);
            this.trackTransparency.SmallChange = 5;
            this.trackTransparency.TabIndex = 12;
            this.trackTransparency.TickFrequency = 5;
            this.trackTransparency.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackTransparency.Value = 75;
            this.trackTransparency.ValueChanged += new System.EventHandler(this.trackTransparency_ValueChanged);
            // 
            // trackSize
            // 
            this.trackSize.BackColor = System.Drawing.SystemColors.Control;
            this.trackSize.LargeChange = 10;
            this.trackSize.Location = new System.Drawing.Point(204, 209);
            this.trackSize.Maximum = 50;
            this.trackSize.Minimum = 5;
            this.trackSize.Name = "trackSize";
            this.trackSize.Size = new System.Drawing.Size(155, 45);
            this.trackSize.SmallChange = 5;
            this.trackSize.TabIndex = 10;
            this.trackSize.TickFrequency = 5;
            this.trackSize.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackSize.Value = 10;
            this.trackSize.ValueChanged += new System.EventHandler(this.trackSize_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdo_center);
            this.groupBox2.Controls.Add(this.rdo_topLeft);
            this.groupBox2.Controls.Add(this.rdo_bottomLeft);
            this.groupBox2.Controls.Add(this.rdo_middleLeft);
            this.groupBox2.Controls.Add(this.pbox_preview);
            this.groupBox2.Controls.Add(this.rdo_topRight);
            this.groupBox2.Controls.Add(this.rdo_bottomCenter);
            this.groupBox2.Controls.Add(this.rdo_bottomRight);
            this.groupBox2.Controls.Add(this.rdo_middleRight);
            this.groupBox2.Controls.Add(this.rdo_topCenter);
            this.groupBox2.Location = new System.Drawing.Point(16, 299);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(343, 249);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Posição da Logo:";
            // 
            // rdo_center
            // 
            this.rdo_center.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdo_center.BackColor = System.Drawing.Color.Transparent;
            this.rdo_center.Checked = true;
            this.rdo_center.Location = new System.Drawing.Point(164, 121);
            this.rdo_center.Name = "rdo_center";
            this.rdo_center.Size = new System.Drawing.Size(13, 13);
            this.rdo_center.TabIndex = 17;
            this.rdo_center.TabStop = true;
            this.rdo_center.UseVisualStyleBackColor = false;
            this.rdo_center.CheckedChanged += new System.EventHandler(this.rdo_center_CheckedChanged);
            // 
            // rdo_topLeft
            // 
            this.rdo_topLeft.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdo_topLeft.BackColor = System.Drawing.Color.Transparent;
            this.rdo_topLeft.Location = new System.Drawing.Point(29, 29);
            this.rdo_topLeft.Name = "rdo_topLeft";
            this.rdo_topLeft.Size = new System.Drawing.Size(13, 13);
            this.rdo_topLeft.TabIndex = 13;
            this.rdo_topLeft.UseVisualStyleBackColor = false;
            this.rdo_topLeft.CheckedChanged += new System.EventHandler(this.rdo_topLeft_CheckedChanged);
            // 
            // rdo_bottomLeft
            // 
            this.rdo_bottomLeft.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdo_bottomLeft.BackColor = System.Drawing.Color.Transparent;
            this.rdo_bottomLeft.Location = new System.Drawing.Point(29, 212);
            this.rdo_bottomLeft.Name = "rdo_bottomLeft";
            this.rdo_bottomLeft.Size = new System.Drawing.Size(13, 13);
            this.rdo_bottomLeft.TabIndex = 19;
            this.rdo_bottomLeft.UseVisualStyleBackColor = false;
            this.rdo_bottomLeft.CheckedChanged += new System.EventHandler(this.rdo_bottomLeft_CheckedChanged);
            // 
            // rdo_middleLeft
            // 
            this.rdo_middleLeft.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdo_middleLeft.BackColor = System.Drawing.Color.Transparent;
            this.rdo_middleLeft.Location = new System.Drawing.Point(29, 121);
            this.rdo_middleLeft.Name = "rdo_middleLeft";
            this.rdo_middleLeft.Size = new System.Drawing.Size(13, 13);
            this.rdo_middleLeft.TabIndex = 16;
            this.rdo_middleLeft.UseVisualStyleBackColor = false;
            this.rdo_middleLeft.CheckedChanged += new System.EventHandler(this.rdo_middleLeft_CheckedChanged);
            // 
            // pbox_preview
            // 
            this.pbox_preview.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pbox_preview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbox_preview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbox_preview.InitialImage = global::Imobili_Image_Downloader.Properties.Resources.image_placeholder;
            this.pbox_preview.Location = new System.Drawing.Point(47, 47);
            this.pbox_preview.Name = "pbox_preview";
            this.pbox_preview.Size = new System.Drawing.Size(246, 160);
            this.pbox_preview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox_preview.TabIndex = 6;
            this.pbox_preview.TabStop = false;
            // 
            // rdo_topRight
            // 
            this.rdo_topRight.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdo_topRight.BackColor = System.Drawing.Color.Transparent;
            this.rdo_topRight.Location = new System.Drawing.Point(298, 29);
            this.rdo_topRight.Name = "rdo_topRight";
            this.rdo_topRight.Size = new System.Drawing.Size(13, 13);
            this.rdo_topRight.TabIndex = 15;
            this.rdo_topRight.UseVisualStyleBackColor = false;
            this.rdo_topRight.CheckedChanged += new System.EventHandler(this.rdo_topRight_CheckedChanged);
            // 
            // rdo_bottomCenter
            // 
            this.rdo_bottomCenter.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdo_bottomCenter.BackColor = System.Drawing.Color.Transparent;
            this.rdo_bottomCenter.Location = new System.Drawing.Point(164, 212);
            this.rdo_bottomCenter.Name = "rdo_bottomCenter";
            this.rdo_bottomCenter.Size = new System.Drawing.Size(13, 13);
            this.rdo_bottomCenter.TabIndex = 20;
            this.rdo_bottomCenter.UseVisualStyleBackColor = false;
            this.rdo_bottomCenter.CheckedChanged += new System.EventHandler(this.rdo_bottomCenter_CheckedChanged);
            // 
            // rdo_bottomRight
            // 
            this.rdo_bottomRight.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdo_bottomRight.BackColor = System.Drawing.Color.Transparent;
            this.rdo_bottomRight.Location = new System.Drawing.Point(298, 212);
            this.rdo_bottomRight.Name = "rdo_bottomRight";
            this.rdo_bottomRight.Size = new System.Drawing.Size(13, 13);
            this.rdo_bottomRight.TabIndex = 21;
            this.rdo_bottomRight.UseVisualStyleBackColor = false;
            this.rdo_bottomRight.CheckedChanged += new System.EventHandler(this.rdo_bottomRight_CheckedChanged);
            // 
            // rdo_middleRight
            // 
            this.rdo_middleRight.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdo_middleRight.BackColor = System.Drawing.Color.Transparent;
            this.rdo_middleRight.Location = new System.Drawing.Point(298, 121);
            this.rdo_middleRight.Name = "rdo_middleRight";
            this.rdo_middleRight.Size = new System.Drawing.Size(13, 13);
            this.rdo_middleRight.TabIndex = 18;
            this.rdo_middleRight.UseVisualStyleBackColor = false;
            this.rdo_middleRight.CheckedChanged += new System.EventHandler(this.rdo_middleRight_CheckedChanged);
            // 
            // rdo_topCenter
            // 
            this.rdo_topCenter.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdo_topCenter.BackColor = System.Drawing.Color.Transparent;
            this.rdo_topCenter.Location = new System.Drawing.Point(164, 29);
            this.rdo_topCenter.Name = "rdo_topCenter";
            this.rdo_topCenter.Size = new System.Drawing.Size(13, 13);
            this.rdo_topCenter.TabIndex = 14;
            this.rdo_topCenter.UseVisualStyleBackColor = false;
            this.rdo_topCenter.CheckedChanged += new System.EventHandler(this.rdo_topCenter_CheckedChanged);
            // 
            // chk_addLogo
            // 
            this.chk_addLogo.AutoSize = true;
            this.chk_addLogo.Location = new System.Drawing.Point(18, 167);
            this.chk_addLogo.Name = "chk_addLogo";
            this.chk_addLogo.Size = new System.Drawing.Size(248, 19);
            this.chk_addLogo.TabIndex = 7;
            this.chk_addLogo.Text = "Adicionar logomarca as imagens baixadas";
            this.chk_addLogo.UseVisualStyleBackColor = true;
            this.chk_addLogo.CheckedChanged += new System.EventHandler(this.chk_addLogo_CheckedChanged);
            // 
            // btn_selectLogo
            // 
            this.btn_selectLogo.Location = new System.Drawing.Point(333, 137);
            this.btn_selectLogo.Name = "btn_selectLogo";
            this.btn_selectLogo.Size = new System.Drawing.Size(25, 24);
            this.btn_selectLogo.TabIndex = 6;
            this.btn_selectLogo.Text = "...";
            this.btn_selectLogo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_selectLogo.UseVisualStyleBackColor = true;
            this.btn_selectLogo.Click += new System.EventHandler(this.btn_selectLogo_Click);
            // 
            // tbx_logo
            // 
            this.tbx_logo.Location = new System.Drawing.Point(58, 138);
            this.tbx_logo.Name = "tbx_logo";
            this.tbx_logo.ReadOnly = true;
            this.tbx_logo.Size = new System.Drawing.Size(269, 23);
            this.tbx_logo.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 33;
            this.label7.Text = "Logo:";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(169, 46);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(105, 23);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_download
            // 
            this.btn_download.Location = new System.Drawing.Point(58, 46);
            this.btn_download.Name = "btn_download";
            this.btn_download.Size = new System.Drawing.Size(105, 23);
            this.btn_download.TabIndex = 2;
            this.btn_download.Text = "Baixar Imagens";
            this.btn_download.UseVisualStyleBackColor = true;
            this.btn_download.Click += new System.EventHandler(this.btn_download_Click);
            // 
            // tbx_link
            // 
            this.tbx_link.Location = new System.Drawing.Point(58, 16);
            this.tbx_link.Name = "tbx_link";
            this.tbx_link.Size = new System.Drawing.Size(300, 23);
            this.tbx_link.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 15);
            this.label1.TabIndex = 29;
            this.label1.Text = "Link:";
            // 
            // chk_config
            // 
            this.chk_config.Appearance = System.Windows.Forms.Appearance.Button;
            this.chk_config.Location = new System.Drawing.Point(332, 46);
            this.chk_config.Name = "chk_config";
            this.chk_config.Size = new System.Drawing.Size(26, 23);
            this.chk_config.TabIndex = 4;
            this.chk_config.Text = "";
            this.chk_config.UseVisualStyleBackColor = true;
            this.chk_config.CheckedChanged += new System.EventHandler(this.chk_config_CheckedChanged);
            // 
            // numSize
            // 
            this.numSize.Location = new System.Drawing.Point(128, 220);
            this.numSize.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numSize.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numSize.Name = "numSize";
            this.numSize.Size = new System.Drawing.Size(47, 23);
            this.numSize.TabIndex = 9;
            this.numSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numSize.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numSize.ValueChanged += new System.EventHandler(this.numSize_ValueChanged);
            // 
            // numTransparency
            // 
            this.numTransparency.Location = new System.Drawing.Point(128, 264);
            this.numTransparency.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTransparency.Name = "numTransparency";
            this.numTransparency.Size = new System.Drawing.Size(47, 23);
            this.numTransparency.TabIndex = 11;
            this.numTransparency.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numTransparency.Value = new decimal(new int[] {
            75,
            0,
            0,
            0});
            this.numTransparency.ValueChanged += new System.EventHandler(this.numTransparency_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 15);
            this.label2.TabIndex = 45;
            this.label2.Text = "%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(181, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 15);
            this.label3.TabIndex = 46;
            this.label3.Text = "%";
            // 
            // bgw_download
            // 
            this.bgw_download.WorkerReportsProgress = true;
            this.bgw_download.WorkerSupportsCancellation = true;
            this.bgw_download.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Bgw_download_DoWork);
            this.bgw_download.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.Bgw_download_ProgressChanged);
            this.bgw_download.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.Bgw_download_RunWorkerCompleted);
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(12, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(345, 56);
            this.label4.TabIndex = 47;
            this.label4.Text = "ATENÇÃO: Este programa foi desenvolvido para download de imagens do antigo sistem" +
    "a InGaia (Kenlo), pode não funcionar com sites que utilizem outra plataforma.";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chk_openFolder
            // 
            this.chk_openFolder.AutoSize = true;
            this.chk_openFolder.Location = new System.Drawing.Point(18, 189);
            this.chk_openFolder.Name = "chk_openFolder";
            this.chk_openFolder.Size = new System.Drawing.Size(206, 19);
            this.chk_openFolder.TabIndex = 8;
            this.chk_openFolder.Text = "Abrir pasta ao concluir downloads";
            this.chk_openFolder.UseVisualStyleBackColor = true;
            this.chk_openFolder.CheckedChanged += new System.EventHandler(this.chk_openFolder_CheckedChanged);
            // 
            // ImageDownloader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 591);
            this.Controls.Add(this.chk_openFolder);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numTransparency);
            this.Controls.Add(this.numSize);
            this.Controls.Add(this.chk_config);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.trackTransparency);
            this.Controls.Add(this.trackSize);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.chk_addLogo);
            this.Controls.Add(this.btn_selectLogo);
            this.Controls.Add(this.tbx_logo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_download);
            this.Controls.Add(this.tbx_link);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ImageDownloader";
            this.Text = "Imobili Image Downloader";
            this.Load += new System.EventHandler(this.ImageDownloader_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackTransparency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSize)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_preview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTransparency)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel tssl_status;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private Label label5;
        private Label label6;
        private TrackBar trackTransparency;
        private TrackBar trackSize;
        private GroupBox groupBox2;
        private RadioButton rdo_topLeft;
        private RadioButton rdo_bottomLeft;
        private RadioButton rdo_middleLeft;
        private PictureBox pbox_preview;
        private RadioButton rdo_topRight;
        private RadioButton rdo_bottomCenter;
        private RadioButton rdo_bottomRight;
        private RadioButton rdo_middleRight;
        private RadioButton rdo_topCenter;
        private CheckBox chk_addLogo;
        private Button btn_selectLogo;
        private TextBox tbx_logo;
        private Label label7;
        private Button btn_cancel;
        private Button btn_download;
        private TextBox tbx_link;
        private Label label1;
        private CheckBox chk_config;
        private NumericUpDown numSize;
        private NumericUpDown numTransparency;
        private Label label2;
        private Label label3;
        private RadioButton rdo_center;
        private System.ComponentModel.BackgroundWorker bgw_download;
        private Label label4;
        private CheckBox chk_openFolder;
        private ToolStripProgressBar tssp_progresso;
    }
}