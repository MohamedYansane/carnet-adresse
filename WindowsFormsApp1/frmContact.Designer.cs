
namespace WindowsFormsApp1
{
    partial class frmContact
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContact));
            this.dgContact = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSexe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVille = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.btnSelectionner = new System.Windows.Forms.Button();
            this.cbbSexe = new System.Windows.Forms.ComboBox();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.txtVille = new System.Windows.Forms.TextBox();
            this.lblVille = new System.Windows.Forms.Label();
            this.txtCsp = new System.Windows.Forms.TextBox();
            this.lblCsp = new System.Windows.Forms.Label();
            this.lblSexe = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblAdresseBook = new System.Windows.Forms.Label();
            this.pbook = new System.Windows.Forms.PictureBox();
            this.panelTop = new System.Windows.Forms.Panel();
            this.pQuitter = new System.Windows.Forms.PictureBox();
            this.lblNbreRepertorie = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblHeure = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.AffichageHeure = new System.Windows.Forms.Timer(this.components);
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnImprimer = new System.Windows.Forms.Button();
            this.btnAjoutTel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgContact)).BeginInit();
            this.gunaShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbook)).BeginInit();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pQuitter)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgContact
            // 
            this.dgContact.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgContact.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgContact.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgContact.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgContact.ColumnHeadersHeight = 24;
            this.dgContact.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colNom,
            this.colPrenom,
            this.colCSP,
            this.colSexe,
            this.colVille});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgContact.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgContact.EnableHeadersVisualStyles = false;
            this.dgContact.Location = new System.Drawing.Point(327, 99);
            this.dgContact.Name = "dgContact";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgContact.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgContact.Size = new System.Drawing.Size(622, 402);
            this.dgContact.TabIndex = 0;
            this.dgContact.SelectionChanged += new System.EventHandler(this.dgContact_SelectionChanged);
            // 
            // colID
            // 
            this.colID.DataPropertyName = "idContact";
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.Width = 50;
            // 
            // colNom
            // 
            this.colNom.DataPropertyName = "nom";
            this.colNom.HeaderText = "Nom";
            this.colNom.Name = "colNom";
            // 
            // colPrenom
            // 
            this.colPrenom.DataPropertyName = "prenom";
            this.colPrenom.HeaderText = "Prenom";
            this.colPrenom.Name = "colPrenom";
            // 
            // colCSP
            // 
            this.colCSP.DataPropertyName = "csp";
            this.colCSP.HeaderText = "CSP";
            this.colCSP.Name = "colCSP";
            // 
            // colSexe
            // 
            this.colSexe.DataPropertyName = "sexe";
            this.colSexe.HeaderText = "Sexe";
            this.colSexe.Name = "colSexe";
            // 
            // colVille
            // 
            this.colVille.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colVille.DataPropertyName = "ville";
            this.colVille.HeaderText = "Ville";
            this.colVille.Name = "colVille";
            // 
            // gunaShadowPanel1
            // 
            this.gunaShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.BaseColor = System.Drawing.Color.White;
            this.gunaShadowPanel1.Controls.Add(this.btnSelectionner);
            this.gunaShadowPanel1.Controls.Add(this.cbbSexe);
            this.gunaShadowPanel1.Controls.Add(this.panelBottom);
            this.gunaShadowPanel1.Controls.Add(this.btnQuitter);
            this.gunaShadowPanel1.Controls.Add(this.btnDelete);
            this.gunaShadowPanel1.Controls.Add(this.btnModifier);
            this.gunaShadowPanel1.Controls.Add(this.btnAjouter);
            this.gunaShadowPanel1.Controls.Add(this.txtVille);
            this.gunaShadowPanel1.Controls.Add(this.lblVille);
            this.gunaShadowPanel1.Controls.Add(this.txtCsp);
            this.gunaShadowPanel1.Controls.Add(this.lblCsp);
            this.gunaShadowPanel1.Controls.Add(this.lblSexe);
            this.gunaShadowPanel1.Controls.Add(this.txtPrenom);
            this.gunaShadowPanel1.Controls.Add(this.lblPrenom);
            this.gunaShadowPanel1.Controls.Add(this.txtNom);
            this.gunaShadowPanel1.Controls.Add(this.lblNom);
            this.gunaShadowPanel1.Controls.Add(this.lblAdresseBook);
            this.gunaShadowPanel1.Controls.Add(this.pbook);
            this.gunaShadowPanel1.Location = new System.Drawing.Point(12, 61);
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.gunaShadowPanel1.Size = new System.Drawing.Size(309, 493);
            this.gunaShadowPanel1.TabIndex = 1;
            // 
            // btnSelectionner
            // 
            this.btnSelectionner.BackColor = System.Drawing.Color.Black;
            this.btnSelectionner.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnSelectionner.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnSelectionner.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectionner.ForeColor = System.Drawing.Color.White;
            this.btnSelectionner.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelectionner.Location = new System.Drawing.Point(66, 446);
            this.btnSelectionner.Name = "btnSelectionner";
            this.btnSelectionner.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSelectionner.Size = new System.Drawing.Size(211, 44);
            this.btnSelectionner.TabIndex = 18;
            this.btnSelectionner.Text = "Selectionner";
            this.btnSelectionner.UseVisualStyleBackColor = false;
            this.btnSelectionner.Click += new System.EventHandler(this.btnSelectionner_Click);
            // 
            // cbbSexe
            // 
            this.cbbSexe.FormattingEnabled = true;
            this.cbbSexe.Items.AddRange(new object[] {
            "Masculin",
            "Féminin"});
            this.cbbSexe.Location = new System.Drawing.Point(91, 223);
            this.cbbSexe.Name = "cbbSexe";
            this.cbbSexe.Size = new System.Drawing.Size(196, 21);
            this.cbbSexe.TabIndex = 17;
            // 
            // panelBottom
            // 
            this.panelBottom.Location = new System.Drawing.Point(304, 516);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(330, 37);
            this.panelBottom.TabIndex = 3;
            // 
            // btnQuitter
            // 
            this.btnQuitter.BackColor = System.Drawing.Color.Black;
            this.btnQuitter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnQuitter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnQuitter.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.ForeColor = System.Drawing.Color.White;
            this.btnQuitter.Image = ((System.Drawing.Image)(resources.GetObject("btnQuitter.Image")));
            this.btnQuitter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuitter.Location = new System.Drawing.Point(187, 396);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Padding = new System.Windows.Forms.Padding(10, 0, 5, 0);
            this.btnQuitter.Size = new System.Drawing.Size(100, 44);
            this.btnQuitter.TabIndex = 16;
            this.btnQuitter.Text = "&Quitter";
            this.btnQuitter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuitter.UseVisualStyleBackColor = false;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Black;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(34, 396);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDelete.Size = new System.Drawing.Size(97, 44);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "&Supprimer";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.Color.Black;
            this.btnModifier.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnModifier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnModifier.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.ForeColor = System.Drawing.Color.White;
            this.btnModifier.Image = ((System.Drawing.Image)(resources.GetObject("btnModifier.Image")));
            this.btnModifier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModifier.Location = new System.Drawing.Point(187, 334);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Padding = new System.Windows.Forms.Padding(10, 0, 5, 0);
            this.btnModifier.Size = new System.Drawing.Size(100, 44);
            this.btnModifier.TabIndex = 14;
            this.btnModifier.Text = "&Modifier";
            this.btnModifier.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.Black;
            this.btnAjouter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnAjouter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnAjouter.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.ForeColor = System.Drawing.Color.White;
            this.btnAjouter.Image = ((System.Drawing.Image)(resources.GetObject("btnAjouter.Image")));
            this.btnAjouter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAjouter.Location = new System.Drawing.Point(34, 334);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAjouter.Size = new System.Drawing.Size(97, 44);
            this.btnAjouter.TabIndex = 13;
            this.btnAjouter.Text = "&Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // txtVille
            // 
            this.txtVille.Location = new System.Drawing.Point(91, 296);
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(196, 20);
            this.txtVille.TabIndex = 11;
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVille.Location = new System.Drawing.Point(31, 296);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(28, 16);
            this.lblVille.TabIndex = 10;
            this.lblVille.Text = "Ville";
            // 
            // txtCsp
            // 
            this.txtCsp.Location = new System.Drawing.Point(91, 256);
            this.txtCsp.Name = "txtCsp";
            this.txtCsp.Size = new System.Drawing.Size(196, 20);
            this.txtCsp.TabIndex = 9;
            this.txtCsp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCsp_KeyDown);
            // 
            // lblCsp
            // 
            this.lblCsp.AutoSize = true;
            this.lblCsp.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCsp.Location = new System.Drawing.Point(31, 260);
            this.lblCsp.Name = "lblCsp";
            this.lblCsp.Size = new System.Drawing.Size(30, 16);
            this.lblCsp.TabIndex = 8;
            this.lblCsp.Text = "CSP";
            // 
            // lblSexe
            // 
            this.lblSexe.AutoSize = true;
            this.lblSexe.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexe.Location = new System.Drawing.Point(31, 224);
            this.lblSexe.Name = "lblSexe";
            this.lblSexe.Size = new System.Drawing.Size(34, 16);
            this.lblSexe.TabIndex = 6;
            this.lblSexe.Text = "Sexe";
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(91, 187);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(196, 20);
            this.txtPrenom.TabIndex = 5;
            this.txtPrenom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPrenom_KeyDown);
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenom.Location = new System.Drawing.Point(31, 188);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(49, 16);
            this.lblPrenom.TabIndex = 4;
            this.lblPrenom.Text = "Prenom";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(91, 152);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(196, 20);
            this.txtNom.TabIndex = 3;
            this.txtNom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNom_KeyDown);
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(31, 152);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(33, 16);
            this.lblNom.TabIndex = 2;
            this.lblNom.Text = "Nom";
            // 
            // lblAdresseBook
            // 
            this.lblAdresseBook.AutoSize = true;
            this.lblAdresseBook.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdresseBook.Location = new System.Drawing.Point(62, 108);
            this.lblAdresseBook.Name = "lblAdresseBook";
            this.lblAdresseBook.Size = new System.Drawing.Size(215, 22);
            this.lblAdresseBook.TabIndex = 1;
            this.lblAdresseBook.Text = "Mon Carnet d\'Adresse";
            // 
            // pbook
            // 
            this.pbook.Image = ((System.Drawing.Image)(resources.GetObject("pbook.Image")));
            this.pbook.Location = new System.Drawing.Point(109, 26);
            this.pbook.Name = "pbook";
            this.pbook.Size = new System.Drawing.Size(100, 70);
            this.pbook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbook.TabIndex = 0;
            this.pbook.TabStop = false;
            this.pbook.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Black;
            this.panelTop.Controls.Add(this.pQuitter);
            this.panelTop.Controls.Add(this.lblNbreRepertorie);
            this.panelTop.Controls.Add(this.lblTotal);
            this.panelTop.Controls.Add(this.lblHeure);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1044, 55);
            this.panelTop.TabIndex = 2;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            // 
            // pQuitter
            // 
            this.pQuitter.Image = ((System.Drawing.Image)(resources.GetObject("pQuitter.Image")));
            this.pQuitter.Location = new System.Drawing.Point(1027, 0);
            this.pQuitter.Name = "pQuitter";
            this.pQuitter.Size = new System.Drawing.Size(14, 19);
            this.pQuitter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pQuitter.TabIndex = 4;
            this.pQuitter.TabStop = false;
            this.pQuitter.Click += new System.EventHandler(this.pQuitter_Click);
            // 
            // lblNbreRepertorie
            // 
            this.lblNbreRepertorie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNbreRepertorie.AutoSize = true;
            this.lblNbreRepertorie.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbreRepertorie.ForeColor = System.Drawing.Color.White;
            this.lblNbreRepertorie.Location = new System.Drawing.Point(148, 18);
            this.lblNbreRepertorie.Name = "lblNbreRepertorie";
            this.lblNbreRepertorie.Size = new System.Drawing.Size(32, 22);
            this.lblNbreRepertorie.TabIndex = 3;
            this.lblNbreRepertorie.Text = "42";
            this.lblNbreRepertorie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(84, 18);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(58, 22);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Total:";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHeure
            // 
            this.lblHeure.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeure.AutoSize = true;
            this.lblHeure.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeure.ForeColor = System.Drawing.Color.White;
            this.lblHeure.Location = new System.Drawing.Point(935, 18);
            this.lblHeure.Name = "lblHeure";
            this.lblHeure.Size = new System.Drawing.Size(86, 22);
            this.lblHeure.TabIndex = 1;
            this.lblHeure.Text = "10:57:00";
            this.lblHeure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(425, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "PROJET CARNET D\'ADRESSE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.lblCopyright);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 560);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1044, 58);
            this.panel2.TabIndex = 4;
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyright.ForeColor = System.Drawing.Color.White;
            this.lblCopyright.Location = new System.Drawing.Point(397, 17);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(201, 17);
            this.lblCopyright.TabIndex = 0;
            this.lblCopyright.Text = "Copyright Mohamed Yansane";
            this.lblCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AffichageHeure
            // 
            this.AffichageHeure.Enabled = true;
            this.AffichageHeure.Tick += new System.EventHandler(this.AffichageHeure_Tick);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSearch.BackColor = System.Drawing.Color.Black;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(570, 63);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSearch.Size = new System.Drawing.Size(170, 32);
            this.btnSearch.TabIndex = 19;
            this.btnSearch.Text = "&Rechercher Nom Prenom";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackColor = System.Drawing.Color.Black;
            this.btnRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnRefresh.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(829, 63);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnRefresh.Size = new System.Drawing.Size(120, 32);
            this.btnRefresh.TabIndex = 21;
            this.btnRefresh.Text = "Rafraichir";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnImprimer
            // 
            this.btnImprimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimer.BackColor = System.Drawing.Color.Black;
            this.btnImprimer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnImprimer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnImprimer.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimer.ForeColor = System.Drawing.Color.White;
            this.btnImprimer.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimer.Image")));
            this.btnImprimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimer.Location = new System.Drawing.Point(802, 506);
            this.btnImprimer.Name = "btnImprimer";
            this.btnImprimer.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnImprimer.Size = new System.Drawing.Size(147, 47);
            this.btnImprimer.TabIndex = 22;
            this.btnImprimer.Text = "&Imprimer";
            this.btnImprimer.UseVisualStyleBackColor = false;
            // 
            // btnAjoutTel
            // 
            this.btnAjoutTel.BackColor = System.Drawing.Color.Black;
            this.btnAjoutTel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnAjoutTel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnAjoutTel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjoutTel.ForeColor = System.Drawing.Color.White;
            this.btnAjoutTel.Image = ((System.Drawing.Image)(resources.GetObject("btnAjoutTel.Image")));
            this.btnAjoutTel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAjoutTel.Location = new System.Drawing.Point(327, 62);
            this.btnAjoutTel.Name = "btnAjoutTel";
            this.btnAjoutTel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAjoutTel.Size = new System.Drawing.Size(161, 36);
            this.btnAjoutTel.TabIndex = 19;
            this.btnAjoutTel.Text = "AjouterNumTel";
            this.btnAjoutTel.UseVisualStyleBackColor = false;
            this.btnAjoutTel.Click += new System.EventHandler(this.btnAjoutTel_Click);
            // 
            // frmContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 618);
            this.Controls.Add(this.btnAjoutTel);
            this.Controls.Add(this.btnImprimer);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.gunaShadowPanel1);
            this.Controls.Add(this.dgContact);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmContact";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmContact";
            this.Load += new System.EventHandler(this.frmContact_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgContact)).EndInit();
            this.gunaShadowPanel1.ResumeLayout(false);
            this.gunaShadowPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbook)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pQuitter)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgContact;
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        private System.Windows.Forms.PictureBox pbook;
        private System.Windows.Forms.Label lblAdresseBook;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.TextBox txtVille;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.TextBox txtCsp;
        private System.Windows.Forms.Label lblCsp;
        private System.Windows.Forms.Label lblSexe;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.Label lblHeure;
        private System.Windows.Forms.Timer AffichageHeure;
        private System.Windows.Forms.Label lblNbreRepertorie;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.PictureBox pQuitter;
        private System.Windows.Forms.Button btnSelectionner;
        private System.Windows.Forms.ComboBox cbbSexe;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnImprimer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSexe;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVille;
        private System.Windows.Forms.Button btnAjoutTel;
    }
}