namespace youcode_p_2
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.dltBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbIds = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbAdrs = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbVille = new System.Windows.Forms.ComboBox();
            this.cbPays = new System.Windows.Forms.ComboBox();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.cbSp = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpDN = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbTel = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.cbSpF = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lbCount = new System.Windows.Forms.Label();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(12, 282);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(564, 254);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Liste des apprenants";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(552, 229);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(353, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(223, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(353, 46);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(223, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Anuller";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(6, 38);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(211, 23);
            this.editBtn.TabIndex = 4;
            this.editBtn.Text = "Modifier";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // dltBtn
            // 
            this.dltBtn.Location = new System.Drawing.Point(6, 67);
            this.dltBtn.Name = "dltBtn";
            this.dltBtn.Size = new System.Drawing.Size(211, 23);
            this.dltBtn.TabIndex = 5;
            this.dltBtn.Text = "Supprimer";
            this.dltBtn.UseVisualStyleBackColor = true;
            this.dltBtn.Click += new System.EventHandler(this.dltBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Apprenant :";
            // 
            // cbIds
            // 
            this.cbIds.FormattingEnabled = true;
            this.cbIds.Location = new System.Drawing.Point(74, 12);
            this.cbIds.Name = "cbIds";
            this.cbIds.Size = new System.Drawing.Size(143, 21);
            this.cbIds.TabIndex = 7;
            this.cbIds.SelectedIndexChanged += new System.EventHandler(this.cbIds_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbAdrs);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cbVille);
            this.groupBox1.Controls.Add(this.cbPays);
            this.groupBox1.Controls.Add(this.tbMail);
            this.groupBox1.Controls.Add(this.cbSp);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tbNom);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbPrenom);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dtpDN);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tbTel);
            this.groupBox1.Location = new System.Drawing.Point(10, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 264);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Formulaire apprenant";
            // 
            // tbAdrs
            // 
            this.tbAdrs.Location = new System.Drawing.Point(120, 155);
            this.tbAdrs.Name = "tbAdrs";
            this.tbAdrs.Size = new System.Drawing.Size(200, 20);
            this.tbAdrs.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 158);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Adresse :";
            // 
            // cbVille
            // 
            this.cbVille.FormattingEnabled = true;
            this.cbVille.Location = new System.Drawing.Point(120, 207);
            this.cbVille.Name = "cbVille";
            this.cbVille.Size = new System.Drawing.Size(200, 21);
            this.cbVille.TabIndex = 17;
            // 
            // cbPays
            // 
            this.cbPays.FormattingEnabled = true;
            this.cbPays.Location = new System.Drawing.Point(120, 180);
            this.cbPays.Name = "cbPays";
            this.cbPays.Size = new System.Drawing.Size(200, 21);
            this.cbPays.TabIndex = 16;
            this.cbPays.SelectedIndexChanged += new System.EventHandler(this.cbPays_SelectedIndexChanged);
            // 
            // tbMail
            // 
            this.tbMail.Location = new System.Drawing.Point(120, 129);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(200, 20);
            this.tbMail.TabIndex = 9;
            // 
            // cbSp
            // 
            this.cbSp.FormattingEnabled = true;
            this.cbSp.Location = new System.Drawing.Point(120, 235);
            this.cbSp.Name = "cbSp";
            this.cbSp.Size = new System.Drawing.Size(200, 21);
            this.cbSp.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nom :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Spécialités :";
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(120, 25);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(200, 20);
            this.tbNom.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prénom :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Ville :";
            // 
            // tbPrenom
            // 
            this.tbPrenom.Location = new System.Drawing.Point(120, 51);
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.Size = new System.Drawing.Size(200, 20);
            this.tbPrenom.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Date de naissance :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Pays :";
            // 
            // dtpDN
            // 
            this.dtpDN.Location = new System.Drawing.Point(120, 77);
            this.dtpDN.Name = "dtpDN";
            this.dtpDN.Size = new System.Drawing.Size(200, 20);
            this.dtpDN.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Téléphone :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Adresse email :";
            // 
            // tbTel
            // 
            this.tbTel.Location = new System.Drawing.Point(120, 103);
            this.tbTel.Name = "tbTel";
            this.tbTel.Size = new System.Drawing.Size(200, 20);
            this.tbTel.TabIndex = 7;
            // 
            // groupBox3
            // 
            this.groupBox3.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.groupBox3.Controls.Add(this.btnShowAll);
            this.groupBox3.Controls.Add(this.btnFilter);
            this.groupBox3.Controls.Add(this.cbSpF);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.editBtn);
            this.groupBox3.Controls.Add(this.dltBtn);
            this.groupBox3.Controls.Add(this.cbIds);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(353, 75);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(223, 201);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(9, 143);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(208, 23);
            this.btnFilter.TabIndex = 10;
            this.btnFilter.Text = "Filtrer";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // cbSpF
            // 
            this.cbSpF.FormattingEnabled = true;
            this.cbSpF.Location = new System.Drawing.Point(76, 116);
            this.cbSpF.Name = "cbSpF";
            this.cbSpF.Size = new System.Drawing.Size(141, 21);
            this.cbSpF.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 119);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Spécialités :";
            // 
            // lbCount
            // 
            this.lbCount.AutoSize = true;
            this.lbCount.Location = new System.Drawing.Point(12, 541);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(133, 13);
            this.lbCount.TabIndex = 19;
            this.lbCount.Text = "Nombre des apprenants : *";
            this.lbCount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(108, 172);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(109, 23);
            this.btnShowAll.TabIndex = 11;
            this.btnShowAll.Text = "Afficher tout";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 563);
            this.Controls.Add(this.lbCount);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button dltBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbIds;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbAdrs;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbVille;
        private System.Windows.Forms.ComboBox cbPays;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.ComboBox cbSp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbPrenom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpDN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbTel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.ComboBox cbSpF;
        private System.Windows.Forms.Label lbCount;
        private System.Windows.Forms.Button btnShowAll;
    }
}

