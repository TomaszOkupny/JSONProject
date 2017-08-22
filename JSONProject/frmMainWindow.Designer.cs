namespace JSONProject
{
    partial class frmMainWindow
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
            this.txtInputJson = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.cmdDeserialise = new System.Windows.Forms.Button();
            this.cmdClear = new System.Windows.Forms.Button();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdGetUrl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInputJson
            // 
            this.txtInputJson.Location = new System.Drawing.Point(12, 117);
            this.txtInputJson.Multiline = true;
            this.txtInputJson.Name = "txtInputJson";
            this.txtInputJson.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInputJson.Size = new System.Drawing.Size(627, 255);
            this.txtInputJson.TabIndex = 0;
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(12, 407);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(627, 293);
            this.txtOutput.TabIndex = 1;
            // 
            // cmdDeserialise
            // 
            this.cmdDeserialise.Location = new System.Drawing.Point(12, 378);
            this.cmdDeserialise.Name = "cmdDeserialise";
            this.cmdDeserialise.Size = new System.Drawing.Size(75, 23);
            this.cmdDeserialise.TabIndex = 2;
            this.cmdDeserialise.Text = "Deserialise";
            this.cmdDeserialise.UseVisualStyleBackColor = true;
            this.cmdDeserialise.Click += new System.EventHandler(this.cmdDeserialise_Click);
            // 
            // cmdClear
            // 
            this.cmdClear.Location = new System.Drawing.Point(94, 378);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(75, 23);
            this.cmdClear.TabIndex = 3;
            this.cmdClear.Text = "Clear";
            this.cmdClear.UseVisualStyleBackColor = true;
            this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(12, 39);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(546, 20);
            this.txtUrl.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "JSON Url";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "JSON String";
            // 
            // cmdGetUrl
            // 
            this.cmdGetUrl.Location = new System.Drawing.Point(564, 39);
            this.cmdGetUrl.Name = "cmdGetUrl";
            this.cmdGetUrl.Size = new System.Drawing.Size(75, 23);
            this.cmdGetUrl.TabIndex = 7;
            this.cmdGetUrl.Text = "Get";
            this.cmdGetUrl.UseVisualStyleBackColor = true;
            this.cmdGetUrl.Click += new System.EventHandler(this.cmdGetUrl_Click);
            // 
            // frmMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 712);
            this.Controls.Add(this.cmdGetUrl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.cmdClear);
            this.Controls.Add(this.cmdDeserialise);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtInputJson);
            this.Name = "frmMainWindow";
            this.Text = "JSON Example";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInputJson;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button cmdDeserialise;
        private System.Windows.Forms.Button cmdClear;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdGetUrl;
    }
}

