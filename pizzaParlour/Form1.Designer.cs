
namespace pizzaParlour
{
    partial class Form1
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
            this.toppingsLabel = new System.Windows.Forms.Label();
            this.toppingsInput = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.toppingsOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // toppingsLabel
            // 
            this.toppingsLabel.AutoSize = true;
            this.toppingsLabel.Location = new System.Drawing.Point(87, 79);
            this.toppingsLabel.Name = "toppingsLabel";
            this.toppingsLabel.Size = new System.Drawing.Size(152, 20);
            this.toppingsLabel.TabIndex = 0;
            this.toppingsLabel.Text = "Number of Toppings";
            // 
            // toppingsInput
            // 
            this.toppingsInput.Location = new System.Drawing.Point(308, 79);
            this.toppingsInput.Name = "toppingsInput";
            this.toppingsInput.Size = new System.Drawing.Size(168, 26);
            this.toppingsInput.TabIndex = 1;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(171, 185);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(200, 72);
            this.calculateButton.TabIndex = 2;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // toppingsOutput
            // 
            this.toppingsOutput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.toppingsOutput.Location = new System.Drawing.Point(122, 316);
            this.toppingsOutput.Name = "toppingsOutput";
            this.toppingsOutput.Size = new System.Drawing.Size(309, 99);
            this.toppingsOutput.TabIndex = 4;
            this.toppingsOutput.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 475);
            this.Controls.Add(this.toppingsOutput);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.toppingsInput);
            this.Controls.Add(this.toppingsLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label toppingsLabel;
        private System.Windows.Forms.TextBox toppingsInput;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label toppingsOutput;
    }
}

