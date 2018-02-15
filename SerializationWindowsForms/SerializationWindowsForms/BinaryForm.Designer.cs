namespace SerializationWindowsForms
{
    partial class BinaryForm
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
            this.Serializition_button = new System.Windows.Forms.Button();
            this.DeSerializition_button = new System.Windows.Forms.Button();
            this.input = new System.Windows.Forms.TextBox();
            this.output = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Serializition_button
            // 
            this.Serializition_button.Location = new System.Drawing.Point(199, 98);
            this.Serializition_button.Name = "Serializition_button";
            this.Serializition_button.Size = new System.Drawing.Size(192, 26);
            this.Serializition_button.TabIndex = 0;
            this.Serializition_button.Text = "Serialize";
            this.Serializition_button.UseVisualStyleBackColor = true;
            this.Serializition_button.Click += new System.EventHandler(this.Serializition_button_Click);
            // 
            // DeSerializition_button
            // 
            this.DeSerializition_button.Location = new System.Drawing.Point(199, 267);
            this.DeSerializition_button.Name = "DeSerializition_button";
            this.DeSerializition_button.Size = new System.Drawing.Size(185, 27);
            this.DeSerializition_button.TabIndex = 1;
            this.DeSerializition_button.Text = "DeSerialize";
            this.DeSerializition_button.UseVisualStyleBackColor = true;
            this.DeSerializition_button.Click += new System.EventHandler(this.DeSerializition_button_Click);
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(12, 58);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(546, 22);
            this.input.TabIndex = 2;
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(13, 230);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(541, 22);
            this.output.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Please, enter path for serialization. For example - D:Temp\\A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(388, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Please, enter path for deserialization. For example - D:Temp";
            // 
            // BinaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 309);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.output);
            this.Controls.Add(this.input);
            this.Controls.Add(this.DeSerializition_button);
            this.Controls.Add(this.Serializition_button);
            this.Name = "BinaryForm";
            this.Text = "BinaryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Serializition_button;
        private System.Windows.Forms.Button DeSerializition_button;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}