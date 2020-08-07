namespace week10
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
            this.Tab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.numInvalid = new System.Windows.Forms.Label();
            this.dayInvalid = new System.Windows.Forms.Label();
            this.monthInvalid = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.enterFriend = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pNumInput = new System.Windows.Forms.MaskedTextBox();
            this.pNum = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.bDayInput = new System.Windows.Forms.TextBox();
            this.bDay = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bMonthInput = new System.Windows.Forms.TextBox();
            this.bMonth = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lNameInput = new System.Windows.Forms.TextBox();
            this.lName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fNameInput = new System.Windows.Forms.TextBox();
            this.fName = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.displayEntry = new System.Windows.Forms.ListBox();
            this.exit2 = new System.Windows.Forms.Button();
            this.readBtn = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.displayRemind = new System.Windows.Forms.ListBox();
            this.exit3 = new System.Windows.Forms.Button();
            this.remindBtn = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.searchInput = new System.Windows.Forms.TextBox();
            this.monthSearch = new System.Windows.Forms.Label();
            this.Tab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tab
            // 
            this.Tab.Controls.Add(this.tabPage1);
            this.Tab.Controls.Add(this.tabPage2);
            this.Tab.Controls.Add(this.tabPage3);
            this.Tab.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tab.ItemSize = new System.Drawing.Size(100, 23);
            this.Tab.Location = new System.Drawing.Point(1, 1);
            this.Tab.Name = "Tab";
            this.Tab.SelectedIndex = 0;
            this.Tab.Size = new System.Drawing.Size(800, 600);
            this.Tab.TabIndex = 0;
            this.Tab.Deselected += new System.Windows.Forms.TabControlEventHandler(this.readTab_Deselected);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.numInvalid);
            this.tabPage1.Controls.Add(this.dayInvalid);
            this.tabPage1.Controls.Add(this.monthInvalid);
            this.tabPage1.Controls.Add(this.exit);
            this.tabPage1.Controls.Add(this.enterFriend);
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 569);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Entry";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // numInvalid
            // 
            this.numInvalid.AutoSize = true;
            this.numInvalid.Location = new System.Drawing.Point(457, 336);
            this.numInvalid.Name = "numInvalid";
            this.numInvalid.Size = new System.Drawing.Size(102, 19);
            this.numInvalid.TabIndex = 9;
            this.numInvalid.Text = "Invalid Input";
            // 
            // dayInvalid
            // 
            this.dayInvalid.AutoSize = true;
            this.dayInvalid.Location = new System.Drawing.Point(457, 269);
            this.dayInvalid.Name = "dayInvalid";
            this.dayInvalid.Size = new System.Drawing.Size(0, 19);
            this.dayInvalid.TabIndex = 8;
            // 
            // monthInvalid
            // 
            this.monthInvalid.AutoSize = true;
            this.monthInvalid.Location = new System.Drawing.Point(457, 199);
            this.monthInvalid.Name = "monthInvalid";
            this.monthInvalid.Size = new System.Drawing.Size(0, 19);
            this.monthInvalid.TabIndex = 7;
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(326, 396);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(125, 30);
            this.exit.TabIndex = 6;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // enterFriend
            // 
            this.enterFriend.Location = new System.Drawing.Point(126, 396);
            this.enterFriend.Name = "enterFriend";
            this.enterFriend.Size = new System.Drawing.Size(125, 30);
            this.enterFriend.TabIndex = 5;
            this.enterFriend.Text = "Enter Friend";
            this.enterFriend.UseVisualStyleBackColor = true;
            this.enterFriend.Click += new System.EventHandler(this.enterFriend_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.pNumInput);
            this.groupBox5.Controls.Add(this.pNum);
            this.groupBox5.Location = new System.Drawing.Point(26, 314);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(425, 60);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            // 
            // pNumInput
            // 
            this.pNumInput.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pNumInput.Location = new System.Drawing.Point(166, 18);
            this.pNumInput.Mask = "000-0000";
            this.pNumInput.Name = "pNumInput";
            this.pNumInput.Size = new System.Drawing.Size(250, 26);
            this.pNumInput.TabIndex = 1;
            this.pNumInput.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.pNumInput_MaskInputRejected);
            this.pNumInput.TextChanged += new System.EventHandler(this.pNumInput_TextChanged);
            // 
            // pNum
            // 
            this.pNum.AutoSize = true;
            this.pNum.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pNum.Location = new System.Drawing.Point(12, 22);
            this.pNum.Name = "pNum";
            this.pNum.Size = new System.Drawing.Size(130, 19);
            this.pNum.TabIndex = 0;
            this.pNum.Text = "Phone Number:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.bDayInput);
            this.groupBox4.Controls.Add(this.bDay);
            this.groupBox4.Location = new System.Drawing.Point(26, 244);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(425, 60);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // bDayInput
            // 
            this.bDayInput.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDayInput.Location = new System.Drawing.Point(166, 22);
            this.bDayInput.MaxLength = 2;
            this.bDayInput.Name = "bDayInput";
            this.bDayInput.Size = new System.Drawing.Size(250, 26);
            this.bDayInput.TabIndex = 1;
            this.bDayInput.TextChanged += new System.EventHandler(this.bDayInput_TextChanged);
            // 
            // bDay
            // 
            this.bDay.AutoSize = true;
            this.bDay.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDay.Location = new System.Drawing.Point(12, 26);
            this.bDay.Name = "bDay";
            this.bDay.Size = new System.Drawing.Size(146, 19);
            this.bDay.TabIndex = 0;
            this.bDay.Text = "Birth Day (ex: 15):";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bMonthInput);
            this.groupBox3.Controls.Add(this.bMonth);
            this.groupBox3.Location = new System.Drawing.Point(26, 174);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(425, 60);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // bMonthInput
            // 
            this.bMonthInput.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bMonthInput.Location = new System.Drawing.Point(169, 18);
            this.bMonthInput.MaxLength = 2;
            this.bMonthInput.Name = "bMonthInput";
            this.bMonthInput.Size = new System.Drawing.Size(250, 26);
            this.bMonthInput.TabIndex = 1;
            this.bMonthInput.TextChanged += new System.EventHandler(this.bMonthInput_TextChanged);
            // 
            // bMonth
            // 
            this.bMonth.AutoSize = true;
            this.bMonth.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bMonth.Location = new System.Drawing.Point(12, 22);
            this.bMonth.Name = "bMonth";
            this.bMonth.Size = new System.Drawing.Size(155, 19);
            this.bMonth.TabIndex = 0;
            this.bMonth.Text = "Birth Month (ex: 2):";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lNameInput);
            this.groupBox2.Controls.Add(this.lName);
            this.groupBox2.Location = new System.Drawing.Point(26, 104);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(425, 60);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lNameInput
            // 
            this.lNameInput.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNameInput.Location = new System.Drawing.Point(160, 18);
            this.lNameInput.Name = "lNameInput";
            this.lNameInput.Size = new System.Drawing.Size(250, 26);
            this.lNameInput.TabIndex = 1;
            this.lNameInput.TextChanged += new System.EventHandler(this.lNameInput_TextChanged);
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lName.Location = new System.Drawing.Point(12, 22);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(96, 19);
            this.lName.TabIndex = 0;
            this.lName.Text = "Last Name:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fNameInput);
            this.groupBox1.Controls.Add(this.fName);
            this.groupBox1.Location = new System.Drawing.Point(26, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 60);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // fNameInput
            // 
            this.fNameInput.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fNameInput.Location = new System.Drawing.Point(163, 18);
            this.fNameInput.Name = "fNameInput";
            this.fNameInput.Size = new System.Drawing.Size(250, 26);
            this.fNameInput.TabIndex = 1;
            this.fNameInput.TextChanged += new System.EventHandler(this.fNameInput_TextChanged);
            // 
            // fName
            // 
            this.fName.AutoSize = true;
            this.fName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fName.Location = new System.Drawing.Point(12, 22);
            this.fName.Name = "fName";
            this.fName.Size = new System.Drawing.Size(97, 19);
            this.fName.TabIndex = 0;
            this.fName.Text = "First Name:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.displayEntry);
            this.tabPage2.Controls.Add(this.exit2);
            this.tabPage2.Controls.Add(this.readBtn);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 569);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Read";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // displayEntry
            // 
            this.displayEntry.FormattingEnabled = true;
            this.displayEntry.ItemHeight = 19;
            this.displayEntry.Location = new System.Drawing.Point(80, 98);
            this.displayEntry.Name = "displayEntry";
            this.displayEntry.Size = new System.Drawing.Size(600, 346);
            this.displayEntry.TabIndex = 2;
            // 
            // exit2
            // 
            this.exit2.Location = new System.Drawing.Point(430, 40);
            this.exit2.Name = "exit2";
            this.exit2.Size = new System.Drawing.Size(125, 30);
            this.exit2.TabIndex = 1;
            this.exit2.Text = "Exit";
            this.exit2.UseVisualStyleBackColor = true;
            this.exit2.Click += new System.EventHandler(this.exit2_Click);
            // 
            // readBtn
            // 
            this.readBtn.Location = new System.Drawing.Point(205, 40);
            this.readBtn.Name = "readBtn";
            this.readBtn.Size = new System.Drawing.Size(125, 30);
            this.readBtn.TabIndex = 0;
            this.readBtn.Text = "Read";
            this.readBtn.UseVisualStyleBackColor = true;
            this.readBtn.Click += new System.EventHandler(this.readBtn_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.displayRemind);
            this.tabPage3.Controls.Add(this.exit3);
            this.tabPage3.Controls.Add(this.remindBtn);
            this.tabPage3.Controls.Add(this.groupBox6);
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 569);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Reminder";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // displayRemind
            // 
            this.displayRemind.FormattingEnabled = true;
            this.displayRemind.ItemHeight = 19;
            this.displayRemind.Location = new System.Drawing.Point(130, 195);
            this.displayRemind.Name = "displayRemind";
            this.displayRemind.Size = new System.Drawing.Size(500, 289);
            this.displayRemind.TabIndex = 3;
            // 
            // exit3
            // 
            this.exit3.Location = new System.Drawing.Point(429, 123);
            this.exit3.Name = "exit3";
            this.exit3.Size = new System.Drawing.Size(125, 30);
            this.exit3.TabIndex = 2;
            this.exit3.Text = "Exit";
            this.exit3.UseVisualStyleBackColor = true;
            this.exit3.Click += new System.EventHandler(this.exit3_Click);
            // 
            // remindBtn
            // 
            this.remindBtn.Location = new System.Drawing.Point(255, 124);
            this.remindBtn.Name = "remindBtn";
            this.remindBtn.Size = new System.Drawing.Size(125, 30);
            this.remindBtn.TabIndex = 1;
            this.remindBtn.Text = "Reminder";
            this.remindBtn.UseVisualStyleBackColor = true;
            this.remindBtn.Click += new System.EventHandler(this.remindBtn_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.searchInput);
            this.groupBox6.Controls.Add(this.monthSearch);
            this.groupBox6.Location = new System.Drawing.Point(130, 30);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(500, 60);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            // 
            // searchInput
            // 
            this.searchInput.Location = new System.Drawing.Point(290, 23);
            this.searchInput.MaxLength = 2;
            this.searchInput.Name = "searchInput";
            this.searchInput.Size = new System.Drawing.Size(200, 26);
            this.searchInput.TabIndex = 1;
            this.searchInput.TextChanged += new System.EventHandler(this.searchInput_TextChanged);
            // 
            // monthSearch
            // 
            this.monthSearch.AutoSize = true;
            this.monthSearch.Location = new System.Drawing.Point(25, 26);
            this.monthSearch.Name = "monthSearch";
            this.monthSearch.Size = new System.Drawing.Size(259, 19);
            this.monthSearch.TabIndex = 0;
            this.monthSearch.Text = "Enter Month to search for (ex: 2):";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.Tab);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Friends";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Tab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button enterFriend;
        private System.Windows.Forms.MaskedTextBox pNumInput;
        private System.Windows.Forms.Label pNum;
        private System.Windows.Forms.TextBox bDayInput;
        private System.Windows.Forms.Label bDay;
        private System.Windows.Forms.TextBox bMonthInput;
        private System.Windows.Forms.Label bMonth;
        private System.Windows.Forms.TextBox lNameInput;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.TextBox fNameInput;
        private System.Windows.Forms.Label fName;
        private System.Windows.Forms.ListBox displayEntry;
        private System.Windows.Forms.Button exit2;
        private System.Windows.Forms.Button readBtn;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ListBox displayRemind;
        private System.Windows.Forms.Button exit3;
        private System.Windows.Forms.Button remindBtn;
        private System.Windows.Forms.TextBox searchInput;
        private System.Windows.Forms.Label monthSearch;
        private System.Windows.Forms.Label dayInvalid;
        private System.Windows.Forms.Label monthInvalid;
        private System.Windows.Forms.Label numInvalid;
    }
}

