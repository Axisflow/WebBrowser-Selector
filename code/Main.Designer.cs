namespace WebBrowserSelector
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.list = new System.Windows.Forms.ComboBox();
            this.run = new System.Windows.Forms.Button();
            this.icon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.SuspendLayout();
            // 
            // list
            // 
            this.list.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.list.FormattingEnabled = true;
            this.list.Items.AddRange(new object[] {
            "預設"});
            this.list.Location = new System.Drawing.Point(106, 18);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(347, 27);
            this.list.TabIndex = 0;
            this.list.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_Run);
            // 
            // run
            // 
            this.run.Location = new System.Drawing.Point(363, 67);
            this.run.Name = "run";
            this.run.Size = new System.Drawing.Size(90, 29);
            this.run.TabIndex = 1;
            this.run.Text = "開啟";
            this.run.UseVisualStyleBackColor = true;
            this.run.Click += new System.EventHandler(this.run_Click);
            // 
            // icon
            // 
            this.icon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("icon.BackgroundImage")));
            this.icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.icon.Location = new System.Drawing.Point(12, 15);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(84, 84);
            this.icon.TabIndex = 2;
            this.icon.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(465, 113);
            this.Controls.Add(this.icon);
            this.Controls.Add(this.run);
            this.Controls.Add(this.list);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "選擇要開啟的瀏覽器...";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox list;
        private Button run;
        private PictureBox icon;
    }
}