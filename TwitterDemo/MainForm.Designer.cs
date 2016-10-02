namespace TwitterDemo
{
    partial class MainForm
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
            this.apisGroupBox = new System.Windows.Forms.GroupBox();
            this.queryTextBox = new System.Windows.Forms.TextBox();
            this.slashLabel = new System.Windows.Forms.Label();
            this.responseTextBox = new System.Windows.Forms.TextBox();
            this.callButton = new System.Windows.Forms.Button();
            this.endpointLabel = new System.Windows.Forms.Label();
            this.endpointsComboBox = new System.Windows.Forms.ComboBox();
            this.apisGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // apisGroupBox
            // 
            this.apisGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.apisGroupBox.Controls.Add(this.queryTextBox);
            this.apisGroupBox.Controls.Add(this.slashLabel);
            this.apisGroupBox.Controls.Add(this.responseTextBox);
            this.apisGroupBox.Controls.Add(this.callButton);
            this.apisGroupBox.Controls.Add(this.endpointLabel);
            this.apisGroupBox.Controls.Add(this.endpointsComboBox);
            this.apisGroupBox.Location = new System.Drawing.Point(12, 12);
            this.apisGroupBox.Name = "apisGroupBox";
            this.apisGroupBox.Size = new System.Drawing.Size(1038, 857);
            this.apisGroupBox.TabIndex = 2;
            this.apisGroupBox.TabStop = false;
            this.apisGroupBox.Text = "Twitter APIs";
            // 
            // queryTextBox
            // 
            this.queryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.queryTextBox.Location = new System.Drawing.Point(535, 42);
            this.queryTextBox.Name = "queryTextBox";
            this.queryTextBox.Size = new System.Drawing.Size(319, 31);
            this.queryTextBox.TabIndex = 6;
            // 
            // slashLabel
            // 
            this.slashLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.slashLabel.AutoSize = true;
            this.slashLabel.Location = new System.Drawing.Point(495, 45);
            this.slashLabel.Name = "slashLabel";
            this.slashLabel.Size = new System.Drawing.Size(18, 25);
            this.slashLabel.TabIndex = 5;
            this.slashLabel.Text = "/";
            // 
            // responseTextBox
            // 
            this.responseTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.responseTextBox.Location = new System.Drawing.Point(33, 143);
            this.responseTextBox.Multiline = true;
            this.responseTextBox.Name = "responseTextBox";
            this.responseTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.responseTextBox.Size = new System.Drawing.Size(980, 690);
            this.responseTextBox.TabIndex = 4;
            // 
            // callButton
            // 
            this.callButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.callButton.Location = new System.Drawing.Point(876, 37);
            this.callButton.Name = "callButton";
            this.callButton.Size = new System.Drawing.Size(137, 41);
            this.callButton.TabIndex = 3;
            this.callButton.Text = "&Call";
            this.callButton.UseVisualStyleBackColor = true;
            this.callButton.Click += new System.EventHandler(this.callButton_Click);
            // 
            // endpointLabel
            // 
            this.endpointLabel.AutoSize = true;
            this.endpointLabel.Location = new System.Drawing.Point(28, 45);
            this.endpointLabel.Name = "endpointLabel";
            this.endpointLabel.Size = new System.Drawing.Size(103, 25);
            this.endpointLabel.TabIndex = 2;
            this.endpointLabel.Text = "Endpoint:";
            // 
            // endpointsComboBox
            // 
            this.endpointsComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.endpointsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.endpointsComboBox.FormattingEnabled = true;
            this.endpointsComboBox.Items.AddRange(new object[] {
            "Tweets",
            "Timeline",
            "Search",
            "Friends"});
            this.endpointsComboBox.Location = new System.Drawing.Point(150, 42);
            this.endpointsComboBox.Name = "endpointsComboBox";
            this.endpointsComboBox.Size = new System.Drawing.Size(319, 33);
            this.endpointsComboBox.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 881);
            this.Controls.Add(this.apisGroupBox);
            this.Name = "MainForm";
            this.Text = "Twitter Demo";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.apisGroupBox.ResumeLayout(false);
            this.apisGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox apisGroupBox;
        private System.Windows.Forms.Button callButton;
        private System.Windows.Forms.Label endpointLabel;
        private System.Windows.Forms.ComboBox endpointsComboBox;
        private System.Windows.Forms.TextBox responseTextBox;
        private System.Windows.Forms.Label slashLabel;
        private System.Windows.Forms.TextBox queryTextBox;
    }
}

