namespace FileMenu
{
    partial class FormFiles
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
            this.fileNameTextBox = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.transactionTextBox = new System.Windows.Forms.TextBox();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.createNewRadioButton = new System.Windows.Forms.RadioButton();
            this.openRadioButton = new System.Windows.Forms.RadioButton();
            this.createOpenButton = new System.Windows.Forms.Button();
            this.sinTextBox = new System.Windows.Forms.TextBox();
            this.purchasedTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.qtyTextBox = new System.Windows.Forms.TextBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.writeRecordButton = new System.Windows.Forms.Button();
            this.displayDataButton = new System.Windows.Forms.Button();
            this.mdLabel = new System.Windows.Forms.Label();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.fileLabel = new System.Windows.Forms.Label();
            this.transactiontLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.serialLabel = new System.Windows.Forms.Label();
            this.purchasedLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.qtyLabel = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.displayLabel = new System.Windows.Forms.Label();
            this.messageDisplayLabel = new System.Windows.Forms.Label();
            this.dataDisplayLabel = new System.Windows.Forms.RichTextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.closeFile = new System.Windows.Forms.Button();
            this.deleteAllButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fileNameTextBox
            // 
            this.fileNameTextBox.Location = new System.Drawing.Point(97, 36);
            this.fileNameTextBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.fileNameTextBox.Name = "fileNameTextBox";
            this.fileNameTextBox.Size = new System.Drawing.Size(286, 23);
            this.fileNameTextBox.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // transactionTextBox
            // 
            this.transactionTextBox.Location = new System.Drawing.Point(97, 111);
            this.transactionTextBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.transactionTextBox.Name = "transactionTextBox";
            this.transactionTextBox.Size = new System.Drawing.Size(136, 23);
            this.transactionTextBox.TabIndex = 1;
            // 
            // dateTextBox
            // 
            this.dateTextBox.Location = new System.Drawing.Point(246, 111);
            this.dateTextBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(164, 23);
            this.dateTextBox.TabIndex = 2;
            // 
            // createNewRadioButton
            // 
            this.createNewRadioButton.AutoSize = true;
            this.createNewRadioButton.Checked = true;
            this.createNewRadioButton.Location = new System.Drawing.Point(424, 39);
            this.createNewRadioButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.createNewRadioButton.Name = "createNewRadioButton";
            this.createNewRadioButton.Size = new System.Drawing.Size(109, 21);
            this.createNewRadioButton.TabIndex = 3;
            this.createNewRadioButton.TabStop = true;
            this.createNewRadioButton.Text = "Create New";
            this.createNewRadioButton.UseVisualStyleBackColor = true;
            // 
            // openRadioButton
            // 
            this.openRadioButton.AutoSize = true;
            this.openRadioButton.Location = new System.Drawing.Point(593, 39);
            this.openRadioButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.openRadioButton.Name = "openRadioButton";
            this.openRadioButton.Size = new System.Drawing.Size(126, 21);
            this.openRadioButton.TabIndex = 4;
            this.openRadioButton.Text = "Open Existing";
            this.openRadioButton.UseVisualStyleBackColor = true;
            // 
            // createOpenButton
            // 
            this.createOpenButton.Location = new System.Drawing.Point(791, 19);
            this.createOpenButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.createOpenButton.Name = "createOpenButton";
            this.createOpenButton.Size = new System.Drawing.Size(188, 55);
            this.createOpenButton.TabIndex = 5;
            this.createOpenButton.Text = "Create / Open File";
            this.createOpenButton.UseVisualStyleBackColor = true;
            this.createOpenButton.Click += new System.EventHandler(this.createOpenButton_Click);
            // 
            // sinTextBox
            // 
            this.sinTextBox.Location = new System.Drawing.Point(424, 111);
            this.sinTextBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.sinTextBox.Name = "sinTextBox";
            this.sinTextBox.Size = new System.Drawing.Size(154, 23);
            this.sinTextBox.TabIndex = 6;
            // 
            // purchasedTextBox
            // 
            this.purchasedTextBox.Location = new System.Drawing.Point(593, 111);
            this.purchasedTextBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.purchasedTextBox.Name = "purchasedTextBox";
            this.purchasedTextBox.Size = new System.Drawing.Size(286, 23);
            this.purchasedTextBox.TabIndex = 7;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(894, 111);
            this.priceTextBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(165, 23);
            this.priceTextBox.TabIndex = 8;
            // 
            // qtyTextBox
            // 
            this.qtyTextBox.Location = new System.Drawing.Point(1073, 111);
            this.qtyTextBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.qtyTextBox.Name = "qtyTextBox";
            this.qtyTextBox.Size = new System.Drawing.Size(104, 23);
            this.qtyTextBox.TabIndex = 9;
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(1192, 111);
            this.amountTextBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(140, 23);
            this.amountTextBox.TabIndex = 10;
            // 
            // writeRecordButton
            // 
            this.writeRecordButton.Location = new System.Drawing.Point(97, 169);
            this.writeRecordButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.writeRecordButton.Name = "writeRecordButton";
            this.writeRecordButton.Size = new System.Drawing.Size(318, 35);
            this.writeRecordButton.TabIndex = 11;
            this.writeRecordButton.Text = "Write Record";
            this.writeRecordButton.UseVisualStyleBackColor = true;
            this.writeRecordButton.Click += new System.EventHandler(this.writeRecordButton_Click);
            // 
            // displayDataButton
            // 
            this.displayDataButton.Location = new System.Drawing.Point(97, 547);
            this.displayDataButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.displayDataButton.Name = "displayDataButton";
            this.displayDataButton.Size = new System.Drawing.Size(158, 39);
            this.displayDataButton.TabIndex = 15;
            this.displayDataButton.Text = "Display Data";
            this.displayDataButton.UseVisualStyleBackColor = true;
            this.displayDataButton.Click += new System.EventHandler(this.displayDataButton_Click);
            // 
            // mdLabel
            // 
            this.mdLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mdLabel.Location = new System.Drawing.Point(97, 646);
            this.mdLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.mdLabel.Name = "mdLabel";
            this.mdLabel.Size = new System.Drawing.Size(1235, 145);
            this.mdLabel.TabIndex = 18;
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.Location = new System.Drawing.Point(97, 6);
            this.fileNameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(122, 17);
            this.fileNameLabel.TabIndex = 19;
            this.fileNameLabel.Text = "Enter Filename:";
            // 
            // fileLabel
            // 
            this.fileLabel.AutoSize = true;
            this.fileLabel.Location = new System.Drawing.Point(418, 6);
            this.fileLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.fileLabel.Name = "fileLabel";
            this.fileLabel.Size = new System.Drawing.Size(34, 17);
            this.fileLabel.TabIndex = 20;
            this.fileLabel.Text = "File";
            // 
            // transactiontLabel
            // 
            this.transactiontLabel.AutoSize = true;
            this.transactiontLabel.Location = new System.Drawing.Point(97, 86);
            this.transactiontLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.transactiontLabel.Name = "transactiontLabel";
            this.transactiontLabel.Size = new System.Drawing.Size(108, 17);
            this.transactiontLabel.TabIndex = 21;
            this.transactiontLabel.Text = "Transaction #";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(242, 86);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(42, 17);
            this.dateLabel.TabIndex = 22;
            this.dateLabel.Text = "Date";
            // 
            // serialLabel
            // 
            this.serialLabel.AutoSize = true;
            this.serialLabel.Location = new System.Drawing.Point(427, 86);
            this.serialLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.serialLabel.Name = "serialLabel";
            this.serialLabel.Size = new System.Drawing.Size(111, 17);
            this.serialLabel.TabIndex = 23;
            this.serialLabel.Text = "Serial Number";
            // 
            // purchasedLabel
            // 
            this.purchasedLabel.AutoSize = true;
            this.purchasedLabel.Location = new System.Drawing.Point(588, 86);
            this.purchasedLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.purchasedLabel.Name = "purchasedLabel";
            this.purchasedLabel.Size = new System.Drawing.Size(122, 17);
            this.purchasedLabel.TabIndex = 24;
            this.purchasedLabel.Text = "Tool Purchased";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(889, 86);
            this.priceLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(45, 17);
            this.priceLabel.TabIndex = 25;
            this.priceLabel.Text = "Price";
            // 
            // qtyLabel
            // 
            this.qtyLabel.AutoSize = true;
            this.qtyLabel.Location = new System.Drawing.Point(1067, 86);
            this.qtyLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.qtyLabel.Name = "qtyLabel";
            this.qtyLabel.Size = new System.Drawing.Size(40, 17);
            this.qtyLabel.TabIndex = 26;
            this.qtyLabel.Text = "QTY";
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(1187, 86);
            this.amountLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(62, 17);
            this.amountLabel.TabIndex = 27;
            this.amountLabel.Text = "Amount";
            // 
            // displayLabel
            // 
            this.displayLabel.AutoSize = true;
            this.displayLabel.Location = new System.Drawing.Point(97, 229);
            this.displayLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.displayLabel.Name = "displayLabel";
            this.displayLabel.Size = new System.Drawing.Size(105, 17);
            this.displayLabel.TabIndex = 28;
            this.displayLabel.Text = "Data Display:";
            // 
            // messageDisplayLabel
            // 
            this.messageDisplayLabel.AutoSize = true;
            this.messageDisplayLabel.Location = new System.Drawing.Point(102, 611);
            this.messageDisplayLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.messageDisplayLabel.Name = "messageDisplayLabel";
            this.messageDisplayLabel.Size = new System.Drawing.Size(130, 17);
            this.messageDisplayLabel.TabIndex = 29;
            this.messageDisplayLabel.Text = "Message Display";
            // 
            // dataDisplayLabel
            // 
            this.dataDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataDisplayLabel.Location = new System.Drawing.Point(97, 253);
            this.dataDisplayLabel.Margin = new System.Windows.Forms.Padding(4);
            this.dataDisplayLabel.Name = "dataDisplayLabel";
            this.dataDisplayLabel.Size = new System.Drawing.Size(1235, 285);
            this.dataDisplayLabel.TabIndex = 30;
            this.dataDisplayLabel.Text = "";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(431, 169);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(318, 35);
            this.deleteButton.TabIndex = 31;
            this.deleteButton.Text = "Delete a record by transaction #";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // closeFile
            // 
            this.closeFile.Location = new System.Drawing.Point(267, 547);
            this.closeFile.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.closeFile.Name = "closeFile";
            this.closeFile.Size = new System.Drawing.Size(158, 39);
            this.closeFile.TabIndex = 33;
            this.closeFile.Text = "Close File";
            this.closeFile.UseVisualStyleBackColor = true;
            this.closeFile.Click += new System.EventHandler(this.closeFile_Click);
            // 
            // deleteAllButton
            // 
            this.deleteAllButton.Location = new System.Drawing.Point(437, 547);
            this.deleteAllButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.deleteAllButton.Name = "deleteAllButton";
            this.deleteAllButton.Size = new System.Drawing.Size(158, 39);
            this.deleteAllButton.TabIndex = 34;
            this.deleteAllButton.Text = "Delete File";
            this.deleteAllButton.UseVisualStyleBackColor = true;
            this.deleteAllButton.Click += new System.EventHandler(this.deleteAllButton_Click_1);
            // 
            // FormFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1396, 870);
            this.Controls.Add(this.deleteAllButton);
            this.Controls.Add(this.closeFile);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.dataDisplayLabel);
            this.Controls.Add(this.messageDisplayLabel);
            this.Controls.Add(this.displayLabel);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.qtyLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.purchasedLabel);
            this.Controls.Add(this.serialLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.transactiontLabel);
            this.Controls.Add(this.fileLabel);
            this.Controls.Add(this.fileNameLabel);
            this.Controls.Add(this.mdLabel);
            this.Controls.Add(this.displayDataButton);
            this.Controls.Add(this.writeRecordButton);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.qtyTextBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.purchasedTextBox);
            this.Controls.Add(this.sinTextBox);
            this.Controls.Add(this.createOpenButton);
            this.Controls.Add(this.openRadioButton);
            this.Controls.Add(this.createNewRadioButton);
            this.Controls.Add(this.dateTextBox);
            this.Controls.Add(this.transactionTextBox);
            this.Controls.Add(this.fileNameTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FormFiles";
            this.Text = "Price Logs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fileNameTextBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox transactionTextBox;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.RadioButton createNewRadioButton;
        private System.Windows.Forms.RadioButton openRadioButton;
        private System.Windows.Forms.Button createOpenButton;
        private System.Windows.Forms.TextBox sinTextBox;
        private System.Windows.Forms.TextBox purchasedTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox qtyTextBox;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.Button writeRecordButton;
        private System.Windows.Forms.Button displayDataButton;
        private System.Windows.Forms.Label mdLabel;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.Label fileLabel;
        private System.Windows.Forms.Label transactiontLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label serialLabel;
        private System.Windows.Forms.Label purchasedLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label qtyLabel;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label displayLabel;
        private System.Windows.Forms.Label messageDisplayLabel;
        private System.Windows.Forms.RichTextBox dataDisplayLabel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button closeFile;
        private System.Windows.Forms.Button deleteAllButton;
    }
}

