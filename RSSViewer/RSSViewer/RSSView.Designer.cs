namespace RSSViewer
{
    partial class RSSView
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
            this.button1 = new System.Windows.Forms.Button();
            this.headlines = new System.Windows.Forms.ListBox();
            this.ArticleView = new System.Windows.Forms.RichTextBox();
            this.WebView = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)(this.WebView)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(579, 413);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "Fetch Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // headlines
            // 
            this.headlines.FormattingEnabled = true;
            this.headlines.Location = new System.Drawing.Point(579, 13);
            this.headlines.Name = "headlines";
            this.headlines.Size = new System.Drawing.Size(208, 394);
            this.headlines.TabIndex = 1;
            this.headlines.SelectedIndexChanged += new System.EventHandler(this.UpdateMainView);
            // 
            // ArticleView
            // 
            this.ArticleView.Location = new System.Drawing.Point(13, 13);
            this.ArticleView.Name = "ArticleView";
            this.ArticleView.ReadOnly = true;
            this.ArticleView.Size = new System.Drawing.Size(560, 83);
            this.ArticleView.TabIndex = 2;
            this.ArticleView.Text = "";
            // 
            // WebView
            // 
            this.WebView.AllowExternalDrop = true;
            this.WebView.CreationProperties = null;
            this.WebView.DefaultBackgroundColor = System.Drawing.Color.White;
            this.WebView.Location = new System.Drawing.Point(13, 103);
            this.WebView.Name = "WebView";
            this.WebView.Size = new System.Drawing.Size(560, 335);
            this.WebView.TabIndex = 3;
            this.WebView.ZoomFactor = 1D;
            // 
            // RSSView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.WebView);
            this.Controls.Add(this.ArticleView);
            this.Controls.Add(this.headlines);
            this.Controls.Add(this.button1);
            this.Name = "RSSView";
            this.Text = "RSSView";
            ((System.ComponentModel.ISupportInitialize)(this.WebView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox headlines;
        private System.Windows.Forms.RichTextBox ArticleView;
        private Microsoft.Web.WebView2.WinForms.WebView2 WebView;
    }
}

