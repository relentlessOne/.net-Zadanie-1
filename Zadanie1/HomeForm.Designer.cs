namespace Zadanie1
{
    partial class HomeForm
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
            this.toy = new System.Windows.Forms.ComboBox();
            this.toyLabel = new System.Windows.Forms.Label();
            this.atr1Label = new System.Windows.Forms.Label();
            this.toyInfo = new System.Windows.Forms.Label();
            this.atr1Info = new System.Windows.Forms.Label();
            this.edit = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.typeLabel = new System.Windows.Forms.Label();
            this.typeInfo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.atr2Label = new System.Windows.Forms.Label();
            this.atr2Info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // toy
            // 
            this.toy.FormattingEnabled = true;
            this.toy.Location = new System.Drawing.Point(30, 63);
            this.toy.Name = "toy";
            this.toy.Size = new System.Drawing.Size(222, 21);
            this.toy.TabIndex = 0;
            this.toy.SelectedIndexChanged += new System.EventHandler(this.toy_SelectedIndexChanged);
            // 
            // toyLabel
            // 
            this.toyLabel.AutoSize = true;
            this.toyLabel.Font = new System.Drawing.Font("SansSerif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.toyLabel.ForeColor = System.Drawing.Color.Snow;
            this.toyLabel.Location = new System.Drawing.Point(26, 131);
            this.toyLabel.Name = "toyLabel";
            this.toyLabel.Size = new System.Drawing.Size(112, 22);
            this.toyLabel.TabIndex = 1;
            this.toyLabel.Text = "Toy name: ";
            // 
            // atr1Label
            // 
            this.atr1Label.AutoSize = true;
            this.atr1Label.Font = new System.Drawing.Font("SansSerif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.atr1Label.ForeColor = System.Drawing.Color.Snow;
            this.atr1Label.Location = new System.Drawing.Point(26, 161);
            this.atr1Label.Name = "atr1Label";
            this.atr1Label.Size = new System.Drawing.Size(100, 22);
            this.atr1Label.TabIndex = 3;
            this.atr1Label.Text = "Attribute: ";
            // 
            // toyInfo
            // 
            this.toyInfo.AutoSize = true;
            this.toyInfo.Font = new System.Drawing.Font("SansSerif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.toyInfo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.toyInfo.Location = new System.Drawing.Point(144, 128);
            this.toyInfo.Name = "toyInfo";
            this.toyInfo.Size = new System.Drawing.Size(63, 25);
            this.toyInfo.TabIndex = 4;
            this.toyInfo.Text = "none";
            // 
            // atr1Info
            // 
            this.atr1Info.AutoSize = true;
            this.atr1Info.Font = new System.Drawing.Font("SansSerif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.atr1Info.ForeColor = System.Drawing.SystemColors.Highlight;
            this.atr1Info.Location = new System.Drawing.Point(144, 159);
            this.atr1Info.Name = "atr1Info";
            this.atr1Info.Size = new System.Drawing.Size(63, 25);
            this.atr1Info.TabIndex = 5;
            this.atr1Info.Text = "none";
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(21, 226);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(75, 23);
            this.edit.TabIndex = 7;
            this.edit.Text = "Edit";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.editOnClick);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(102, 226);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 8;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.deleteOnClick);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(183, 226);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 9;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.addOnClick);
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("SansSerif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.typeLabel.ForeColor = System.Drawing.Color.Snow;
            this.typeLabel.Location = new System.Drawing.Point(26, 102);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(96, 22);
            this.typeLabel.TabIndex = 10;
            this.typeLabel.Text = "Toy type:";
            // 
            // typeInfo
            // 
            this.typeInfo.AutoSize = true;
            this.typeInfo.Font = new System.Drawing.Font("SansSerif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.typeInfo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.typeInfo.Location = new System.Drawing.Point(144, 99);
            this.typeInfo.Name = "typeInfo";
            this.typeInfo.Size = new System.Drawing.Size(63, 25);
            this.typeInfo.TabIndex = 11;
            this.typeInfo.Text = "none";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("SansSerif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label5.ForeColor = System.Drawing.Color.Snow;
            this.label5.Location = new System.Drawing.Point(76, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "Toys Manager";
            // 
            // atr2Label
            // 
            this.atr2Label.AutoSize = true;
            this.atr2Label.Font = new System.Drawing.Font("SansSerif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.atr2Label.ForeColor = System.Drawing.Color.Snow;
            this.atr2Label.Location = new System.Drawing.Point(26, 187);
            this.atr2Label.Name = "atr2Label";
            this.atr2Label.Size = new System.Drawing.Size(100, 22);
            this.atr2Label.TabIndex = 13;
            this.atr2Label.Text = "Attribute: ";
            // 
            // atr2Info
            // 
            this.atr2Info.AutoSize = true;
            this.atr2Info.Font = new System.Drawing.Font("SansSerif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.atr2Info.ForeColor = System.Drawing.SystemColors.Highlight;
            this.atr2Info.Location = new System.Drawing.Point(144, 184);
            this.atr2Info.Name = "atr2Info";
            this.atr2Info.Size = new System.Drawing.Size(63, 25);
            this.atr2Info.TabIndex = 14;
            this.atr2Info.Text = "none";
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.atr2Info);
            this.Controls.Add(this.atr2Label);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.typeInfo);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.add);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.atr1Info);
            this.Controls.Add(this.toyInfo);
            this.Controls.Add(this.atr1Label);
            this.Controls.Add(this.toyLabel);
            this.Controls.Add(this.toy);
            this.Name = "HomeForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox toy;
        private System.Windows.Forms.Label toyLabel;
        private System.Windows.Forms.Label atr1Label;
        private System.Windows.Forms.Label toyInfo;
        private System.Windows.Forms.Label atr1Info;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label typeInfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label atr2Label;
        private System.Windows.Forms.Label atr2Info;
    }
}

