namespace ad_sem2_week13_ca_tentangDataBase
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
            this.textBoxPlayerName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelTeamNumber = new System.Windows.Forms.Label();
            this.textBoxTeamNumber = new System.Windows.Forms.TextBox();
            this.labelNationality = new System.Windows.Forms.Label();
            this.labelPosition = new System.Windows.Forms.Label();
            this.labelHeight = new System.Windows.Forms.Label();
            this.labelWeight = new System.Windows.Forms.Label();
            this.labelBirthDate = new System.Windows.Forms.Label();
            this.labelTeamName = new System.Windows.Forms.Label();
            this.labelPlayerID = new System.Windows.Forms.Label();
            this.buttonAddPlayer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPosition = new System.Windows.Forms.TextBox();
            this.comboBoxNationality = new System.Windows.Forms.ComboBox();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.textBoxPlayerID = new System.Windows.Forms.TextBox();
            this.comboBoxTeamName = new System.Windows.Forms.ComboBox();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.dgv2 = new System.Windows.Forms.DataGridView();
            this.dgv3 = new System.Windows.Forms.DataGridView();
            this.comboBoxTeamNameKanan = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.buttonChange = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelDeletePlayer = new System.Windows.Forms.Label();
            this.comboBoxTeamNamePlayerData = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv3)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxPlayerName
            // 
            this.textBoxPlayerName.Location = new System.Drawing.Point(162, 79);
            this.textBoxPlayerName.Name = "textBoxPlayerName";
            this.textBoxPlayerName.Size = new System.Drawing.Size(215, 22);
            this.textBoxPlayerName.TabIndex = 0;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(31, 82);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(44, 16);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name";
            // 
            // labelTeamNumber
            // 
            this.labelTeamNumber.AutoSize = true;
            this.labelTeamNumber.Location = new System.Drawing.Point(31, 120);
            this.labelTeamNumber.Name = "labelTeamNumber";
            this.labelTeamNumber.Size = new System.Drawing.Size(94, 16);
            this.labelTeamNumber.TabIndex = 2;
            this.labelTeamNumber.Text = "Team Number";
            // 
            // textBoxTeamNumber
            // 
            this.textBoxTeamNumber.Location = new System.Drawing.Point(162, 117);
            this.textBoxTeamNumber.Name = "textBoxTeamNumber";
            this.textBoxTeamNumber.Size = new System.Drawing.Size(215, 22);
            this.textBoxTeamNumber.TabIndex = 3;
            // 
            // labelNationality
            // 
            this.labelNationality.AutoSize = true;
            this.labelNationality.Location = new System.Drawing.Point(31, 156);
            this.labelNationality.Name = "labelNationality";
            this.labelNationality.Size = new System.Drawing.Size(70, 16);
            this.labelNationality.TabIndex = 4;
            this.labelNationality.Text = "Nationality";
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Location = new System.Drawing.Point(31, 192);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(55, 16);
            this.labelPosition.TabIndex = 5;
            this.labelPosition.Text = "Position";
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(31, 229);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(46, 16);
            this.labelHeight.TabIndex = 6;
            this.labelHeight.Tag = "Height";
            this.labelHeight.Text = "Height";
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(31, 262);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(49, 16);
            this.labelWeight.TabIndex = 7;
            this.labelWeight.Text = "Weight";
            // 
            // labelBirthDate
            // 
            this.labelBirthDate.AutoSize = true;
            this.labelBirthDate.Location = new System.Drawing.Point(31, 296);
            this.labelBirthDate.Name = "labelBirthDate";
            this.labelBirthDate.Size = new System.Drawing.Size(60, 16);
            this.labelBirthDate.TabIndex = 8;
            this.labelBirthDate.Text = "Birthdate";
            // 
            // labelTeamName
            // 
            this.labelTeamName.AutoSize = true;
            this.labelTeamName.Location = new System.Drawing.Point(31, 329);
            this.labelTeamName.Name = "labelTeamName";
            this.labelTeamName.Size = new System.Drawing.Size(83, 16);
            this.labelTeamName.TabIndex = 9;
            this.labelTeamName.Text = "Team Name";
            // 
            // labelPlayerID
            // 
            this.labelPlayerID.AutoSize = true;
            this.labelPlayerID.Location = new System.Drawing.Point(31, 361);
            this.labelPlayerID.Name = "labelPlayerID";
            this.labelPlayerID.Size = new System.Drawing.Size(62, 16);
            this.labelPlayerID.TabIndex = 10;
            this.labelPlayerID.Text = "Player ID";
            // 
            // buttonAddPlayer
            // 
            this.buttonAddPlayer.Location = new System.Drawing.Point(34, 401);
            this.buttonAddPlayer.Name = "buttonAddPlayer";
            this.buttonAddPlayer.Size = new System.Drawing.Size(94, 33);
            this.buttonAddPlayer.TabIndex = 11;
            this.buttonAddPlayer.Text = "Add Player";
            this.buttonAddPlayer.UseVisualStyleBackColor = true;
            this.buttonAddPlayer.Click += new System.EventHandler(this.buttonAddPlayer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 32);
            this.label1.TabIndex = 12;
            this.label1.Text = "PLAYER DATA";
            // 
            // textBoxPosition
            // 
            this.textBoxPosition.Location = new System.Drawing.Point(162, 192);
            this.textBoxPosition.Name = "textBoxPosition";
            this.textBoxPosition.Size = new System.Drawing.Size(215, 22);
            this.textBoxPosition.TabIndex = 13;
            // 
            // comboBoxNationality
            // 
            this.comboBoxNationality.FormattingEnabled = true;
            this.comboBoxNationality.Location = new System.Drawing.Point(162, 156);
            this.comboBoxNationality.Name = "comboBoxNationality";
            this.comboBoxNationality.Size = new System.Drawing.Size(215, 24);
            this.comboBoxNationality.TabIndex = 14;
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Location = new System.Drawing.Point(162, 226);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(215, 22);
            this.textBoxHeight.TabIndex = 15;
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Location = new System.Drawing.Point(162, 260);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(215, 22);
            this.textBoxWeight.TabIndex = 16;
            // 
            // textBoxPlayerID
            // 
            this.textBoxPlayerID.Location = new System.Drawing.Point(162, 360);
            this.textBoxPlayerID.Name = "textBoxPlayerID";
            this.textBoxPlayerID.Size = new System.Drawing.Size(215, 22);
            this.textBoxPlayerID.TabIndex = 19;
            // 
            // comboBoxTeamName
            // 
            this.comboBoxTeamName.FormattingEnabled = true;
            this.comboBoxTeamName.Location = new System.Drawing.Point(433, 75);
            this.comboBoxTeamName.Name = "comboBoxTeamName";
            this.comboBoxTeamName.Size = new System.Drawing.Size(179, 24);
            this.comboBoxTeamName.TabIndex = 20;
            this.comboBoxTeamName.SelectedIndexChanged += new System.EventHandler(this.comboBoxTeamName_SelectedIndexChanged);
            this.comboBoxTeamName.SelectionChangeCommitted += new System.EventHandler(this.comboBoxTeamName_SelectionChangeCommitted);
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(433, 121);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowHeadersWidth = 51;
            this.dgv1.RowTemplate.Height = 24;
            this.dgv1.Size = new System.Drawing.Size(179, 107);
            this.dgv1.TabIndex = 21;
            // 
            // dgv2
            // 
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.Location = new System.Drawing.Point(433, 234);
            this.dgv2.Name = "dgv2";
            this.dgv2.RowHeadersWidth = 51;
            this.dgv2.RowTemplate.Height = 24;
            this.dgv2.Size = new System.Drawing.Size(179, 236);
            this.dgv2.TabIndex = 22;
            this.dgv2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv2_CellClick);
            this.dgv2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv2_CellContentClick);
            // 
            // dgv3
            // 
            this.dgv3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv3.Location = new System.Drawing.Point(640, 121);
            this.dgv3.Name = "dgv3";
            this.dgv3.RowHeadersWidth = 51;
            this.dgv3.RowTemplate.Height = 24;
            this.dgv3.Size = new System.Drawing.Size(260, 349);
            this.dgv3.TabIndex = 23;
            this.dgv3.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv3_CellClick);
            // 
            // comboBoxTeamNameKanan
            // 
            this.comboBoxTeamNameKanan.FormattingEnabled = true;
            this.comboBoxTeamNameKanan.Location = new System.Drawing.Point(640, 75);
            this.comboBoxTeamNameKanan.Name = "comboBoxTeamNameKanan";
            this.comboBoxTeamNameKanan.Size = new System.Drawing.Size(260, 24);
            this.comboBoxTeamNameKanan.TabIndex = 24;
            this.comboBoxTeamNameKanan.SelectedIndexChanged += new System.EventHandler(this.comboBoxTeamNameKanan_SelectedIndexChanged);
            this.comboBoxTeamNameKanan.SelectionChangeCommitted += new System.EventHandler(this.comboBoxTeamNameKanan_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(428, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "MANAGER DATA";
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Location = new System.Drawing.Point(162, 296);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(215, 22);
            this.dtpBirthDate.TabIndex = 26;
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(433, 489);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(94, 33);
            this.buttonChange.TabIndex = 27;
            this.buttonChange.Text = "Change";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(640, 489);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(94, 33);
            this.buttonDelete.TabIndex = 28;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // labelDeletePlayer
            // 
            this.labelDeletePlayer.AutoSize = true;
            this.labelDeletePlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeletePlayer.Location = new System.Drawing.Point(635, 29);
            this.labelDeletePlayer.Name = "labelDeletePlayer";
            this.labelDeletePlayer.Size = new System.Drawing.Size(184, 25);
            this.labelDeletePlayer.TabIndex = 29;
            this.labelDeletePlayer.Text = "DELETE PLAYER";
            // 
            // comboBoxTeamNamePlayerData
            // 
            this.comboBoxTeamNamePlayerData.FormattingEnabled = true;
            this.comboBoxTeamNamePlayerData.Location = new System.Drawing.Point(162, 326);
            this.comboBoxTeamNamePlayerData.Name = "comboBoxTeamNamePlayerData";
            this.comboBoxTeamNamePlayerData.Size = new System.Drawing.Size(215, 24);
            this.comboBoxTeamNamePlayerData.TabIndex = 30;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 549);
            this.Controls.Add(this.comboBoxTeamNamePlayerData);
            this.Controls.Add(this.labelDeletePlayer);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.dtpBirthDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxTeamNameKanan);
            this.Controls.Add(this.dgv3);
            this.Controls.Add(this.dgv2);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.comboBoxTeamName);
            this.Controls.Add(this.textBoxPlayerID);
            this.Controls.Add(this.textBoxWeight);
            this.Controls.Add(this.textBoxHeight);
            this.Controls.Add(this.comboBoxNationality);
            this.Controls.Add(this.textBoxPosition);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAddPlayer);
            this.Controls.Add(this.labelPlayerID);
            this.Controls.Add(this.labelTeamName);
            this.Controls.Add(this.labelBirthDate);
            this.Controls.Add(this.labelWeight);
            this.Controls.Add(this.labelHeight);
            this.Controls.Add(this.labelPosition);
            this.Controls.Add(this.labelNationality);
            this.Controls.Add(this.textBoxTeamNumber);
            this.Controls.Add(this.labelTeamNumber);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxPlayerName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPlayerName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelTeamNumber;
        private System.Windows.Forms.TextBox textBoxTeamNumber;
        private System.Windows.Forms.Label labelNationality;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.Label labelBirthDate;
        private System.Windows.Forms.Label labelTeamName;
        private System.Windows.Forms.Label labelPlayerID;
        private System.Windows.Forms.Button buttonAddPlayer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPosition;
        private System.Windows.Forms.ComboBox comboBoxNationality;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.TextBox textBoxPlayerID;
        private System.Windows.Forms.ComboBox comboBoxTeamName;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.DataGridView dgv2;
        private System.Windows.Forms.DataGridView dgv3;
        private System.Windows.Forms.ComboBox comboBoxTeamNameKanan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label labelDeletePlayer;
        private System.Windows.Forms.ComboBox comboBoxTeamNamePlayerData;
    }
}

