
namespace Abdallah_Amir_s_Project
{
    partial class Musicly
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Musicly));
            this.musicList = new System.Windows.Forms.ListBox();
            this.WDM = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.devWord = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.minButton = new System.Windows.Forms.Button();
            this.logoBox = new System.Windows.Forms.PictureBox();
            this.selectButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.previousButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.WDM)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // musicList
            // 
            this.musicList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(29)))), ((int)(((byte)(37)))));
            this.musicList.Font = new System.Drawing.Font("Novecento Book", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.musicList.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.musicList.FormattingEnabled = true;
            this.musicList.ItemHeight = 15;
            this.musicList.Location = new System.Drawing.Point(200, 44);
            this.musicList.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.musicList.Name = "musicList";
            this.musicList.Size = new System.Drawing.Size(400, 244);
            this.musicList.TabIndex = 0;
            this.musicList.SelectedIndexChanged += new System.EventHandler(this.musicList_SelectedIndexChanged);
            // 
            // WDM
            // 
            this.WDM.Enabled = true;
            this.WDM.Location = new System.Drawing.Point(200, 294);
            this.WDM.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.WDM.Name = "WDM";
            this.WDM.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WDM.OcxState")));
            this.WDM.Size = new System.Drawing.Size(400, 45);
            this.WDM.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(20)))), ((int)(((byte)(25)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.selectButton);
            this.panel1.Controls.Add(this.devWord);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 367);
            this.panel1.TabIndex = 3;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Novecento Bold", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(24, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 11);
            this.label2.TabIndex = 3;
            this.label2.Text = "all rights reserved © 2022";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(20)))), ((int)(((byte)(25)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.logoBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 144);
            this.panel2.TabIndex = 0;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Mont ExtraLight DEMO", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(41, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Musicly";
            // 
            // devWord
            // 
            this.devWord.AutoSize = true;
            this.devWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.devWord.Font = new System.Drawing.Font("Novecento Bold", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.devWord.ForeColor = System.Drawing.SystemColors.Control;
            this.devWord.Location = new System.Drawing.Point(11, 325);
            this.devWord.Name = "devWord";
            this.devWord.Size = new System.Drawing.Size(164, 13);
            this.devWord.TabIndex = 2;
            this.devWord.Text = "Developed by: Abdallah Amir";
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.SystemColors.Control;
            this.exitButton.Location = new System.Drawing.Point(572, 6);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(30, 30);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "x";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            this.exitButton.MouseHover += new System.EventHandler(this.exitButton_MouseHover);
            // 
            // minButton
            // 
            this.minButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minButton.FlatAppearance.BorderSize = 0;
            this.minButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minButton.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.minButton.ForeColor = System.Drawing.SystemColors.Control;
            this.minButton.Location = new System.Drawing.Point(536, 6);
            this.minButton.Name = "minButton";
            this.minButton.Size = new System.Drawing.Size(30, 30);
            this.minButton.TabIndex = 5;
            this.minButton.Text = "_";
            this.minButton.UseVisualStyleBackColor = true;
            this.minButton.Click += new System.EventHandler(this.minButton_Click);
            this.minButton.MouseHover += new System.EventHandler(this.minButton_MouseHover);
            // 
            // logoBox
            // 
            this.logoBox.Image = global::Abdallah_Amir_s_Project.Properties.Resources.pngtree_vector_music_notes_icon_png_image_9563712;
            this.logoBox.Location = new System.Drawing.Point(40, 12);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(105, 104);
            this.logoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoBox.TabIndex = 0;
            this.logoBox.TabStop = false;
            // 
            // selectButton
            // 
            this.selectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectButton.Font = new System.Drawing.Font("Novecento Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectButton.ForeColor = System.Drawing.SystemColors.Control;
            this.selectButton.Location = new System.Drawing.Point(11, 154);
            this.selectButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(164, 48);
            this.selectButton.TabIndex = 1;
            this.selectButton.Text = "Select Songs";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.nextButton.FlatAppearance.BorderSize = 0;
            this.nextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.Location = new System.Drawing.Point(559, 305);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(30, 30);
            this.nextButton.TabIndex = 6;
            this.nextButton.Text = "⏭️";
            this.nextButton.UseVisualStyleBackColor = false;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // previousButton
            // 
            this.previousButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.previousButton.FlatAppearance.BorderSize = 0;
            this.previousButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.previousButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previousButton.Location = new System.Drawing.Point(523, 305);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(30, 30);
            this.previousButton.TabIndex = 7;
            this.previousButton.Text = "⏮️";
            this.previousButton.UseVisualStyleBackColor = false;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // Musicly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(29)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(617, 367);
            this.Controls.Add(this.previousButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.minButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.WDM);
            this.Controls.Add(this.musicList);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "Musicly";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Musicly";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Musicly_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.WDM)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox musicList;
        private AxWMPLib.AxWindowsMediaPlayer WDM;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox logoBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button minButton;
        private System.Windows.Forms.Label devWord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button previousButton;
    }
}

