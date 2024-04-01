namespace Explorer
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            btnUpperLevel = new Button();
            label1 = new Label();
            textBoxPath = new TextBox();
            btnOpen = new Button();
            imageList = new ImageList(components);
            listView = new ListView();
            SuspendLayout();
            // 
            // btnUpperLevel
            // 
            btnUpperLevel.Location = new Point(23, 12);
            btnUpperLevel.Name = "btnUpperLevel";
            btnUpperLevel.Size = new Size(40, 23);
            btnUpperLevel.TabIndex = 0;
            btnUpperLevel.Text = "...";
            btnUpperLevel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(71, 14);
            label1.Name = "label1";
            label1.Size = new Size(54, 19);
            label1.TabIndex = 2;
            label1.Text = "Path:";
            // 
            // textBoxPath
            // 
            textBoxPath.Location = new Point(131, 12);
            textBoxPath.Name = "textBoxPath";
            textBoxPath.Size = new Size(832, 23);
            textBoxPath.TabIndex = 3;
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(969, 11);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(75, 23);
            btnOpen.TabIndex = 4;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // imageList
            // 
            imageList.ColorDepth = ColorDepth.Depth32Bit;
            imageList.ImageSize = new Size(16, 16);
            imageList.TransparentColor = Color.Transparent;
            // 
            // listView
            // 
            listView.LargeImageList = imageList;
            listView.Location = new Point(23, 41);
            listView.Name = "listView";
            listView.Size = new Size(1021, 492);
            listView.TabIndex = 5;
            listView.UseCompatibleStateImageBehavior = false;
            listView.SelectedIndexChanged += listView_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1065, 545);
            Controls.Add(listView);
            Controls.Add(btnOpen);
            Controls.Add(textBoxPath);
            Controls.Add(label1);
            Controls.Add(btnUpperLevel);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUpperLevel;
        private Label label1;
        private TextBox textBoxPath;
        private Button btnOpen;
        private ImageList imageList;
        private ListView listView;
    }
}