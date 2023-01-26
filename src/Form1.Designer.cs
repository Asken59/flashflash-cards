namespace FlashFlashCard
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cardNumberLabel = new System.Windows.Forms.Label();
            this.infoBox = new System.Windows.Forms.TextBox();
            this.wrongLabel = new System.Windows.Forms.Label();
            this.rightLabel = new System.Windows.Forms.Label();
            this.side2Side1Button = new System.Windows.Forms.Button();
            this.side1Side2Button = new System.Windows.Forms.Button();
            this.inputButton = new System.Windows.Forms.Button();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.fileInputButton = new System.Windows.Forms.Button();
            this.fileInput = new System.Windows.Forms.TextBox();
            this.fileCheckBoxList = new System.Windows.Forms.CheckedListBox();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(695, 452);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cardNumberLabel);
            this.tabPage1.Controls.Add(this.infoBox);
            this.tabPage1.Controls.Add(this.wrongLabel);
            this.tabPage1.Controls.Add(this.rightLabel);
            this.tabPage1.Controls.Add(this.side2Side1Button);
            this.tabPage1.Controls.Add(this.side1Side2Button);
            this.tabPage1.Controls.Add(this.inputButton);
            this.tabPage1.Controls.Add(this.inputBox);
            this.tabPage1.Controls.Add(this.outputBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(687, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cardNumberLabel
            // 
            this.cardNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cardNumberLabel.AutoSize = true;
            this.cardNumberLabel.Location = new System.Drawing.Point(576, 343);
            this.cardNumberLabel.Name = "cardNumberLabel";
            this.cardNumberLabel.Size = new System.Drawing.Size(102, 15);
            this.cardNumberLabel.TabIndex = 8;
            this.cardNumberLabel.Text = "Cards answered: 0";
            // 
            // infoBox
            // 
            this.infoBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.infoBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.infoBox.Location = new System.Drawing.Point(8, 228);
            this.infoBox.Multiline = true;
            this.infoBox.Name = "infoBox";
            this.infoBox.ReadOnly = true;
            this.infoBox.Size = new System.Drawing.Size(562, 159);
            this.infoBox.TabIndex = 7;
            // 
            // wrongLabel
            // 
            this.wrongLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.wrongLabel.AutoSize = true;
            this.wrongLabel.Location = new System.Drawing.Point(576, 373);
            this.wrongLabel.Name = "wrongLabel";
            this.wrongLabel.Size = new System.Drawing.Size(55, 15);
            this.wrongLabel.TabIndex = 6;
            this.wrongLabel.Text = "Wrong: 0";
            // 
            // rightLabel
            // 
            this.rightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rightLabel.AutoSize = true;
            this.rightLabel.Location = new System.Drawing.Point(576, 358);
            this.rightLabel.Name = "rightLabel";
            this.rightLabel.Size = new System.Drawing.Size(47, 15);
            this.rightLabel.TabIndex = 5;
            this.rightLabel.Text = "Right: 0";
            // 
            // side2Side1Button
            // 
            this.side2Side1Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.side2Side1Button.Location = new System.Drawing.Point(576, 35);
            this.side2Side1Button.Name = "side2Side1Button";
            this.side2Side1Button.Size = new System.Drawing.Size(103, 23);
            this.side2Side1Button.TabIndex = 4;
            this.side2Side1Button.Text = "Side 2 to Side 1";
            this.side2Side1Button.UseVisualStyleBackColor = true;
            this.side2Side1Button.Click += new System.EventHandler(this.side2Side1Button_Click);
            // 
            // side1Side2Button
            // 
            this.side1Side2Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.side1Side2Button.Location = new System.Drawing.Point(576, 6);
            this.side1Side2Button.Name = "side1Side2Button";
            this.side1Side2Button.Size = new System.Drawing.Size(103, 23);
            this.side1Side2Button.TabIndex = 3;
            this.side1Side2Button.Text = "Side 1 to Side 2";
            this.side1Side2Button.UseVisualStyleBackColor = true;
            this.side1Side2Button.Click += new System.EventHandler(this.side1Side2Button_Click);
            // 
            // inputButton
            // 
            this.inputButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.inputButton.Location = new System.Drawing.Point(495, 393);
            this.inputButton.Name = "inputButton";
            this.inputButton.Size = new System.Drawing.Size(75, 23);
            this.inputButton.TabIndex = 2;
            this.inputButton.Text = "Check";
            this.inputButton.UseVisualStyleBackColor = true;
            this.inputButton.Click += new System.EventHandler(this.inputButton_Click);
            // 
            // inputBox
            // 
            this.inputBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputBox.Location = new System.Drawing.Point(8, 394);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(481, 23);
            this.inputBox.TabIndex = 1;
            // 
            // outputBox
            // 
            this.outputBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.outputBox.Location = new System.Drawing.Point(8, 6);
            this.outputBox.Multiline = true;
            this.outputBox.Name = "outputBox";
            this.outputBox.ReadOnly = true;
            this.outputBox.Size = new System.Drawing.Size(562, 216);
            this.outputBox.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.fileInputButton);
            this.tabPage2.Controls.Add(this.fileInput);
            this.tabPage2.Controls.Add(this.fileCheckBoxList);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(687, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // fileInputButton
            // 
            this.fileInputButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fileInputButton.Location = new System.Drawing.Point(495, 395);
            this.fileInputButton.Name = "fileInputButton";
            this.fileInputButton.Size = new System.Drawing.Size(75, 23);
            this.fileInputButton.TabIndex = 2;
            this.fileInputButton.Text = "Load";
            this.fileInputButton.UseVisualStyleBackColor = true;
            this.fileInputButton.Click += new System.EventHandler(this.fileInputButton_Click);
            // 
            // fileInput
            // 
            this.fileInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileInput.Location = new System.Drawing.Point(8, 395);
            this.fileInput.Name = "fileInput";
            this.fileInput.Size = new System.Drawing.Size(481, 23);
            this.fileInput.TabIndex = 1;
            // 
            // fileCheckBoxList
            // 
            this.fileCheckBoxList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileCheckBoxList.FormattingEnabled = true;
            this.fileCheckBoxList.IntegralHeight = false;
            this.fileCheckBoxList.Location = new System.Drawing.Point(8, 6);
            this.fileCheckBoxList.Name = "fileCheckBoxList";
            this.fileCheckBoxList.Size = new System.Drawing.Size(562, 383);
            this.fileCheckBoxList.TabIndex = 0;
            this.fileCheckBoxList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.fileCheckBoxList_ItemCheck);
            // 
            // Form1
            // 
            this.AcceptButton = this.inputButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 452);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.flashFlashCardForm_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl;
        private TabPage tabPage1;
        private TextBox inputBox;
        private TextBox outputBox;
        private TabPage tabPage2;
        private Button inputButton;
        private Button fileInputButton;
        private TextBox fileInput;
        private CheckedListBox fileCheckBoxList;
        private Button side2Side1Button;
        private Button side1Side2Button;
        private Label wrongLabel;
        private Label rightLabel;
        private TextBox infoBox;
        private Label cardNumberLabel;
    }
}