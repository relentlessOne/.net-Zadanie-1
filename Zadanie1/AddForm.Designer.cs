namespace Zadanie1
{
    partial class AddForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.atr1 = new System.Windows.Forms.Label();
            this.atr1Text = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.toysTypesComboBox = new System.Windows.Forms.ComboBox();
            this.atr2 = new System.Windows.Forms.Label();
            this.atr2Text = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SansSerif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(13, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = "Toy type:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SansSerif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(13, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 22);
            this.label1.TabIndex = 12;
            this.label1.Text = "Toy name: ";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(131, 86);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(121, 20);
            this.name.TabIndex = 13;
            // 
            // atr1
            // 
            this.atr1.AutoSize = true;
            this.atr1.Font = new System.Drawing.Font("SansSerif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.atr1.ForeColor = System.Drawing.Color.Snow;
            this.atr1.Location = new System.Drawing.Point(13, 121);
            this.atr1.Name = "atr1";
            this.atr1.Size = new System.Drawing.Size(100, 22);
            this.atr1.TabIndex = 14;
            this.atr1.Text = "Attribute: ";
            // 
            // atr1Text
            // 
            this.atr1Text.Location = new System.Drawing.Point(131, 121);
            this.atr1Text.Name = "atr1Text";
            this.atr1Text.Size = new System.Drawing.Size(121, 20);
            this.atr1Text.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(147, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.okOnClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(50, 193);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.cancelOnClick);
            // 
            // toysTypesComboBox
            // 
            this.toysTypesComboBox.FormattingEnabled = true;
            this.toysTypesComboBox.Location = new System.Drawing.Point(131, 52);
            this.toysTypesComboBox.Name = "toysTypesComboBox";
            this.toysTypesComboBox.Size = new System.Drawing.Size(121, 21);
            this.toysTypesComboBox.TabIndex = 0;
            this.toysTypesComboBox.SelectedIndexChanged += new System.EventHandler(this.typeChange);
            // 
            // atr2
            // 
            this.atr2.AutoSize = true;
            this.atr2.Font = new System.Drawing.Font("SansSerif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.atr2.ForeColor = System.Drawing.Color.Snow;
            this.atr2.Location = new System.Drawing.Point(13, 153);
            this.atr2.Name = "atr2";
            this.atr2.Size = new System.Drawing.Size(100, 22);
            this.atr2.TabIndex = 18;
            this.atr2.Text = "Attribute: ";
            // 
            // atr2Text
            // 
            this.atr2Text.Location = new System.Drawing.Point(131, 153);
            this.atr2Text.Name = "atr2Text";
            this.atr2Text.Size = new System.Drawing.Size(121, 20);
            this.atr2Text.TabIndex = 19;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.atr2Text);
            this.Controls.Add(this.atr2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.atr1Text);
            this.Controls.Add(this.atr1);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.toysTypesComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddForm";
            this.Text = "AddForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label atr1;
        private System.Windows.Forms.TextBox atr1Text;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox toysTypesComboBox;
        private System.Windows.Forms.Label atr2;
        private System.Windows.Forms.TextBox atr2Text;
    }
}