﻿namespace ImageEdgeDetectionTool
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
            this.loadImage = new System.Windows.Forms.Button();
            this.saveImage = new System.Windows.Forms.Button();
            this.ImagePreview = new System.Windows.Forms.PictureBox();
            this.EdgeDetectionList = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePreview)).BeginInit();
            this.SuspendLayout();
            // 
            // loadImage
            // 
            this.loadImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadImage.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.loadImage.Location = new System.Drawing.Point(1054, 15);
            this.loadImage.Margin = new System.Windows.Forms.Padding(6);
            this.loadImage.Name = "loadImage";
            this.loadImage.Size = new System.Drawing.Size(271, 105);
            this.loadImage.TabIndex = 0;
            this.loadImage.Text = "Load Image";
            this.loadImage.UseVisualStyleBackColor = true;
            this.loadImage.Click += new System.EventHandler(this.loadImage_Click);
            // 
            // saveImage
            // 
            this.saveImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveImage.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.saveImage.Location = new System.Drawing.Point(1054, 674);
            this.saveImage.Margin = new System.Windows.Forms.Padding(6);
            this.saveImage.Name = "saveImage";
            this.saveImage.Size = new System.Drawing.Size(271, 105);
            this.saveImage.TabIndex = 1;
            this.saveImage.Text = "Save Image";
            this.saveImage.UseVisualStyleBackColor = true;
            this.saveImage.Click += new System.EventHandler(this.saveImage_Click);
            // 
            // ImagePreview
            // 
            this.ImagePreview.Location = new System.Drawing.Point(28, 15);
            this.ImagePreview.Margin = new System.Windows.Forms.Padding(6);
            this.ImagePreview.Name = "ImagePreview";
            this.ImagePreview.Size = new System.Drawing.Size(1012, 762);
            this.ImagePreview.TabIndex = 2;
            this.ImagePreview.TabStop = false;
            // 
            // EdgeDetectionList
            // 
            this.EdgeDetectionList.FormattingEnabled = true;
            this.EdgeDetectionList.ItemHeight = 24;
            this.EdgeDetectionList.Items.AddRange(new object[] {
            "-Original-",
            "Zen filter",
            "Some filter"});
            this.EdgeDetectionList.Location = new System.Drawing.Point(1054, 177);
            this.EdgeDetectionList.Margin = new System.Windows.Forms.Padding(6);
            this.EdgeDetectionList.Name = "EdgeDetectionList";
            this.EdgeDetectionList.Size = new System.Drawing.Size(268, 436);
            this.EdgeDetectionList.TabIndex = 4;
            this.EdgeDetectionList.SelectedIndexChanged += new System.EventHandler(this.EdgeDetectionList_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 798);
            this.Controls.Add(this.EdgeDetectionList);
            this.Controls.Add(this.ImagePreview);
            this.Controls.Add(this.saveImage);
            this.Controls.Add(this.loadImage);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainForm";
            this.Text = "Image Edge Detection";
            ((System.ComponentModel.ISupportInitialize)(this.ImagePreview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button loadImage;
        private System.Windows.Forms.Button saveImage;
        private System.Windows.Forms.PictureBox ImagePreview;
        private System.Windows.Forms.ListBox EdgeDetectionList;
    }
}

