namespace Zadanie1
{
    partial class EditForm
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.atr1Text = new System.Windows.Forms.TextBox();
            this.atr1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.Label();
            this.atr2Text = new System.Windows.Forms.TextBox();
            this.atr2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(60, 199);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 25;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.cancelOnClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(157, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.okOnClick);
            // 
            // atr1Text
            // 
            this.atr1Text.Location = new System.Drawing.Point(141, 117);
            this.atr1Text.Name = "atr1Text";
            this.atr1Text.Size = new System.Drawing.Size(121, 20);
            this.atr1Text.TabIndex = 23;
            // 
            // atr1
            // 
            this.atr1.AutoSize = true;
            this.atr1.Font = new System.Drawing.Font("SansSerif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.atr1.ForeColor = System.Drawing.Color.Snow;
            this.atr1.Location = new System.Drawing.Point(23, 117);
            this.atr1.Name = "atr1";
            this.atr1.Size = new System.Drawing.Size(100, 22);
            this.atr1.TabIndex = 22;
            this.atr1.Text = "Attribute: ";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(141, 82);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(121, 20);
            this.name.TabIndex = 21;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("SansSerif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.nameLabel.ForeColor = System.Drawing.Color.Snow;
            this.nameLabel.Location = new System.Drawing.Point(23, 82);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(112, 22);
            this.nameLabel.TabIndex = 20;
            this.nameLabel.Text = "Toy name: ";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("SansSerif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.typeLabel.ForeColor = System.Drawing.Color.Snow;
            this.typeLabel.Location = new System.Drawing.Point(23, 48);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(96, 22);
            this.typeLabel.TabIndex = 19;
            this.typeLabel.Text = "Toy type:";
            // 
            // type
            // 
            this.type.AutoSize = true;
            this.type.Font = new System.Drawing.Font("SansSerif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.type.ForeColor = System.Drawing.SystemColors.Highlight;
            this.type.Location = new System.Drawing.Point(136, 45);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(63, 25);
            this.type.TabIndex = 26;
            this.type.Text = "none";
            // 
            // atr2Text
            // 
            this.atr2Text.Location = new System.Drawing.Point(141, 152);
            this.atr2Text.Name = "atr2Text";
            this.atr2Text.Size = new System.Drawing.Size(121, 20);
            this.atr2Text.TabIndex = 27;
            // 
            // atr2
            // 
            this.atr2.AutoSize = true;
            this.atr2.Font = new System.Drawing.Font("SansSerif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.atr2.ForeColor = System.Drawing.Color.Snow;
            this.atr2.Location = new System.Drawing.Point(23, 152);
            this.atr2.Name = "atr2";
            this.atr2.Size = new System.Drawing.Size(100, 22);
            this.atr2.TabIndex = 28;
            this.atr2.Text = "Attribute: ";
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.atr2);
            this.Controls.Add(this.atr2Text);
            this.Controls.Add(this.type);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.atr1Text);
            this.Controls.Add(this.atr1);
            this.Controls.Add(this.name);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.typeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EditForm";
            this.Text = "EditForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox atr1Text;
        private System.Windows.Forms.Label atr1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label type;
        private System.Windows.Forms.TextBox atr2Text;
        private System.Windows.Forms.Label atr2;
    }
}