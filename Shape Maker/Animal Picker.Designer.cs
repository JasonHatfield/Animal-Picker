namespace Shape_Maker
{
    partial class shapeMaker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(shapeMaker));
            this.animalsListBox = new System.Windows.Forms.ListBox();
            this.locationGroupBox = new System.Windows.Forms.GroupBox();
            this.outsideRadioButton = new System.Windows.Forms.RadioButton();
            this.insideRadioButton = new System.Windows.Forms.RadioButton();
            this.detailsGroupBox = new System.Windows.Forms.GroupBox();
            this.ageCheckBox = new System.Windows.Forms.CheckBox();
            this.nameCheckBox = new System.Windows.Forms.CheckBox();
            this.selectButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.selectLabel = new System.Windows.Forms.Label();
            this.outputNameLabel = new System.Windows.Forms.Label();
            this.outputAgeLabel = new System.Windows.Forms.Label();
            this.cowOutPictureBox = new System.Windows.Forms.PictureBox();
            this.cowInPictureBox = new System.Windows.Forms.PictureBox();
            this.chickenOutPictureBox = new System.Windows.Forms.PictureBox();
            this.chickenInPictureBox = new System.Windows.Forms.PictureBox();
            this.horseOutPictureBox = new System.Windows.Forms.PictureBox();
            this.horseInPictureBox = new System.Windows.Forms.PictureBox();
            this.dogOutPictureBox = new System.Windows.Forms.PictureBox();
            this.dogInPictureBox = new System.Windows.Forms.PictureBox();
            this.catOutPictureBox = new System.Windows.Forms.PictureBox();
            this.catInPictureBox = new System.Windows.Forms.PictureBox();
            this.locationGroupBox.SuspendLayout();
            this.detailsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cowOutPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cowInPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chickenOutPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chickenInPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horseOutPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horseInPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogOutPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogInPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catOutPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catInPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // animalsListBox
            // 
            this.animalsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.4F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.animalsListBox.FormattingEnabled = true;
            this.animalsListBox.ItemHeight = 16;
            this.animalsListBox.Items.AddRange(new object[] {
            "Dog",
            "Cat",
            "Horse",
            "Chicken",
            "Cow",
            ""});
            this.animalsListBox.Location = new System.Drawing.Point(12, 28);
            this.animalsListBox.Name = "animalsListBox";
            this.animalsListBox.Size = new System.Drawing.Size(127, 100);
            this.animalsListBox.TabIndex = 0;
            // 
            // locationGroupBox
            // 
            this.locationGroupBox.Controls.Add(this.outsideRadioButton);
            this.locationGroupBox.Controls.Add(this.insideRadioButton);
            this.locationGroupBox.Location = new System.Drawing.Point(12, 140);
            this.locationGroupBox.Name = "locationGroupBox";
            this.locationGroupBox.Size = new System.Drawing.Size(127, 67);
            this.locationGroupBox.TabIndex = 1;
            this.locationGroupBox.TabStop = false;
            this.locationGroupBox.Text = "Select location";
            // 
            // outsideRadioButton
            // 
            this.outsideRadioButton.AutoSize = true;
            this.outsideRadioButton.Location = new System.Drawing.Point(9, 45);
            this.outsideRadioButton.Name = "outsideRadioButton";
            this.outsideRadioButton.Size = new System.Drawing.Size(61, 17);
            this.outsideRadioButton.TabIndex = 1;
            this.outsideRadioButton.TabStop = true;
            this.outsideRadioButton.Text = "Outside";
            this.outsideRadioButton.UseVisualStyleBackColor = true;
            // 
            // insideRadioButton
            // 
            this.insideRadioButton.AutoSize = true;
            this.insideRadioButton.Location = new System.Drawing.Point(9, 22);
            this.insideRadioButton.Name = "insideRadioButton";
            this.insideRadioButton.Size = new System.Drawing.Size(53, 17);
            this.insideRadioButton.TabIndex = 0;
            this.insideRadioButton.TabStop = true;
            this.insideRadioButton.Text = "Inside";
            this.insideRadioButton.UseVisualStyleBackColor = true;
            // 
            // detailsGroupBox
            // 
            this.detailsGroupBox.Controls.Add(this.ageCheckBox);
            this.detailsGroupBox.Controls.Add(this.nameCheckBox);
            this.detailsGroupBox.Location = new System.Drawing.Point(12, 224);
            this.detailsGroupBox.Name = "detailsGroupBox";
            this.detailsGroupBox.Size = new System.Drawing.Size(127, 73);
            this.detailsGroupBox.TabIndex = 0;
            this.detailsGroupBox.TabStop = false;
            this.detailsGroupBox.Text = "Select details to show";
            // 
            // ageCheckBox
            // 
            this.ageCheckBox.AutoSize = true;
            this.ageCheckBox.Location = new System.Drawing.Point(9, 45);
            this.ageCheckBox.Name = "ageCheckBox";
            this.ageCheckBox.Size = new System.Drawing.Size(45, 17);
            this.ageCheckBox.TabIndex = 1;
            this.ageCheckBox.Text = "Age";
            this.ageCheckBox.UseVisualStyleBackColor = true;
            // 
            // nameCheckBox
            // 
            this.nameCheckBox.AutoSize = true;
            this.nameCheckBox.Location = new System.Drawing.Point(9, 22);
            this.nameCheckBox.Name = "nameCheckBox";
            this.nameCheckBox.Size = new System.Drawing.Size(54, 17);
            this.nameCheckBox.TabIndex = 0;
            this.nameCheckBox.Text = "Name";
            this.nameCheckBox.UseVisualStyleBackColor = true;
            // 
            // selectButton
            // 
            this.selectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.selectButton.Location = new System.Drawing.Point(162, 240);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(75, 23);
            this.selectButton.TabIndex = 2;
            this.selectButton.Text = "Select";
            this.selectButton.UseVisualStyleBackColor = false;
            this.selectButton.Click += new System.EventHandler(this.drawButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.clearButton.Location = new System.Drawing.Point(244, 240);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // selectLabel
            // 
            this.selectLabel.AutoSize = true;
            this.selectLabel.Location = new System.Drawing.Point(12, 9);
            this.selectLabel.Name = "selectLabel";
            this.selectLabel.Size = new System.Drawing.Size(85, 13);
            this.selectLabel.TabIndex = 4;
            this.selectLabel.Text = "Select an animal";
            // 
            // outputNameLabel
            // 
            this.outputNameLabel.AutoSize = true;
            this.outputNameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.outputNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputNameLabel.Location = new System.Drawing.Point(163, 189);
            this.outputNameLabel.Name = "outputNameLabel";
            this.outputNameLabel.Size = new System.Drawing.Size(0, 16);
            this.outputNameLabel.TabIndex = 5;
            this.outputNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // outputAgeLabel
            // 
            this.outputAgeLabel.AutoSize = true;
            this.outputAgeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.outputAgeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputAgeLabel.Location = new System.Drawing.Point(163, 208);
            this.outputAgeLabel.Name = "outputAgeLabel";
            this.outputAgeLabel.Size = new System.Drawing.Size(0, 16);
            this.outputAgeLabel.TabIndex = 6;
            this.outputAgeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cowOutPictureBox
            // 
            this.cowOutPictureBox.Image = global::Shape_Maker.Properties.Resources.Cow___Outside;
            this.cowOutPictureBox.Location = new System.Drawing.Point(163, 28);
            this.cowOutPictureBox.Name = "cowOutPictureBox";
            this.cowOutPictureBox.Size = new System.Drawing.Size(156, 156);
            this.cowOutPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cowOutPictureBox.TabIndex = 15;
            this.cowOutPictureBox.TabStop = false;
            this.cowOutPictureBox.Visible = false;
            // 
            // cowInPictureBox
            // 
            this.cowInPictureBox.Image = global::Shape_Maker.Properties.Resources.Cow___Inside;
            this.cowInPictureBox.Location = new System.Drawing.Point(163, 28);
            this.cowInPictureBox.Name = "cowInPictureBox";
            this.cowInPictureBox.Size = new System.Drawing.Size(156, 156);
            this.cowInPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cowInPictureBox.TabIndex = 14;
            this.cowInPictureBox.TabStop = false;
            this.cowInPictureBox.Visible = false;
            // 
            // chickenOutPictureBox
            // 
            this.chickenOutPictureBox.Image = global::Shape_Maker.Properties.Resources.Chicken___Outside;
            this.chickenOutPictureBox.Location = new System.Drawing.Point(163, 28);
            this.chickenOutPictureBox.Name = "chickenOutPictureBox";
            this.chickenOutPictureBox.Size = new System.Drawing.Size(156, 156);
            this.chickenOutPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.chickenOutPictureBox.TabIndex = 13;
            this.chickenOutPictureBox.TabStop = false;
            this.chickenOutPictureBox.Visible = false;
            // 
            // chickenInPictureBox
            // 
            this.chickenInPictureBox.Image = global::Shape_Maker.Properties.Resources.Chicken___Inside;
            this.chickenInPictureBox.Location = new System.Drawing.Point(163, 28);
            this.chickenInPictureBox.Name = "chickenInPictureBox";
            this.chickenInPictureBox.Size = new System.Drawing.Size(156, 156);
            this.chickenInPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.chickenInPictureBox.TabIndex = 12;
            this.chickenInPictureBox.TabStop = false;
            this.chickenInPictureBox.Visible = false;
            // 
            // horseOutPictureBox
            // 
            this.horseOutPictureBox.Image = global::Shape_Maker.Properties.Resources.Horse___Outside;
            this.horseOutPictureBox.Location = new System.Drawing.Point(163, 28);
            this.horseOutPictureBox.Name = "horseOutPictureBox";
            this.horseOutPictureBox.Size = new System.Drawing.Size(156, 156);
            this.horseOutPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.horseOutPictureBox.TabIndex = 11;
            this.horseOutPictureBox.TabStop = false;
            this.horseOutPictureBox.Visible = false;
            // 
            // horseInPictureBox
            // 
            this.horseInPictureBox.Image = global::Shape_Maker.Properties.Resources.Horse___Inside;
            this.horseInPictureBox.Location = new System.Drawing.Point(163, 28);
            this.horseInPictureBox.Name = "horseInPictureBox";
            this.horseInPictureBox.Size = new System.Drawing.Size(156, 156);
            this.horseInPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.horseInPictureBox.TabIndex = 10;
            this.horseInPictureBox.TabStop = false;
            this.horseInPictureBox.Visible = false;
            // 
            // dogOutPictureBox
            // 
            this.dogOutPictureBox.Image = global::Shape_Maker.Properties.Resources.Dog___Outside;
            this.dogOutPictureBox.Location = new System.Drawing.Point(163, 28);
            this.dogOutPictureBox.Name = "dogOutPictureBox";
            this.dogOutPictureBox.Size = new System.Drawing.Size(156, 156);
            this.dogOutPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dogOutPictureBox.TabIndex = 9;
            this.dogOutPictureBox.TabStop = false;
            this.dogOutPictureBox.Visible = false;
            // 
            // dogInPictureBox
            // 
            this.dogInPictureBox.Image = global::Shape_Maker.Properties.Resources.Dog___Inside;
            this.dogInPictureBox.Location = new System.Drawing.Point(163, 28);
            this.dogInPictureBox.Name = "dogInPictureBox";
            this.dogInPictureBox.Size = new System.Drawing.Size(156, 156);
            this.dogInPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dogInPictureBox.TabIndex = 8;
            this.dogInPictureBox.TabStop = false;
            this.dogInPictureBox.Visible = false;
            // 
            // catOutPictureBox
            // 
            this.catOutPictureBox.Image = global::Shape_Maker.Properties.Resources.Cat___Outside;
            this.catOutPictureBox.Location = new System.Drawing.Point(163, 28);
            this.catOutPictureBox.Name = "catOutPictureBox";
            this.catOutPictureBox.Size = new System.Drawing.Size(156, 156);
            this.catOutPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.catOutPictureBox.TabIndex = 7;
            this.catOutPictureBox.TabStop = false;
            this.catOutPictureBox.Visible = false;
            // 
            // catInPictureBox
            // 
            this.catInPictureBox.Image = global::Shape_Maker.Properties.Resources.Cat___Inside;
            this.catInPictureBox.Location = new System.Drawing.Point(163, 28);
            this.catInPictureBox.Name = "catInPictureBox";
            this.catInPictureBox.Size = new System.Drawing.Size(156, 156);
            this.catInPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.catInPictureBox.TabIndex = 0;
            this.catInPictureBox.TabStop = false;
            this.catInPictureBox.Visible = false;
            // 
            // shapeMaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(343, 303);
            this.Controls.Add(this.cowOutPictureBox);
            this.Controls.Add(this.cowInPictureBox);
            this.Controls.Add(this.chickenOutPictureBox);
            this.Controls.Add(this.chickenInPictureBox);
            this.Controls.Add(this.horseOutPictureBox);
            this.Controls.Add(this.horseInPictureBox);
            this.Controls.Add(this.dogOutPictureBox);
            this.Controls.Add(this.dogInPictureBox);
            this.Controls.Add(this.catOutPictureBox);
            this.Controls.Add(this.outputAgeLabel);
            this.Controls.Add(this.outputNameLabel);
            this.Controls.Add(this.selectLabel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.catInPictureBox);
            this.Controls.Add(this.detailsGroupBox);
            this.Controls.Add(this.locationGroupBox);
            this.Controls.Add(this.animalsListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "shapeMaker";
            this.Text = "Animal Picker";
            this.locationGroupBox.ResumeLayout(false);
            this.locationGroupBox.PerformLayout();
            this.detailsGroupBox.ResumeLayout(false);
            this.detailsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cowOutPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cowInPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chickenOutPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chickenInPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horseOutPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horseInPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogOutPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogInPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catOutPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catInPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox animalsListBox;
        private System.Windows.Forms.GroupBox locationGroupBox;
        private System.Windows.Forms.RadioButton outsideRadioButton;
        private System.Windows.Forms.RadioButton insideRadioButton;
        private System.Windows.Forms.GroupBox detailsGroupBox;
        private System.Windows.Forms.CheckBox ageCheckBox;
        private System.Windows.Forms.CheckBox nameCheckBox;
        private System.Windows.Forms.PictureBox catInPictureBox;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label selectLabel;
        private System.Windows.Forms.Label outputNameLabel;
        private System.Windows.Forms.Label outputAgeLabel;
        private System.Windows.Forms.PictureBox catOutPictureBox;
        private System.Windows.Forms.PictureBox dogInPictureBox;
        private System.Windows.Forms.PictureBox dogOutPictureBox;
        private System.Windows.Forms.PictureBox horseInPictureBox;
        private System.Windows.Forms.PictureBox horseOutPictureBox;
        private System.Windows.Forms.PictureBox chickenInPictureBox;
        private System.Windows.Forms.PictureBox chickenOutPictureBox;
        private System.Windows.Forms.PictureBox cowInPictureBox;
        private System.Windows.Forms.PictureBox cowOutPictureBox;
    }
}

