namespace MultiTargetLookupGenerator
{
    partial class MultiTargetLookupGeneratorControl
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MultiTargetLookupGeneratorControl));
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.tsb_Close = new System.Windows.Forms.ToolStripButton();
            this.tssSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.label1 = new System.Windows.Forms.Label();
            this.box_Entity = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Create = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.box_Solution = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.box_Requirement = new System.Windows.Forms.ComboBox();
            this.txt_Label = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lst_Format = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lst_Targets = new System.Windows.Forms.CheckedListBox();
            this.btn_Publish = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tsb_LoadEntities = new System.Windows.Forms.ToolStripButton();
            this.toolStripMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_Close,
            this.tssSeparator1,
            this.tsb_LoadEntities});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStripMenu.Size = new System.Drawing.Size(1689, 34);
            this.toolStripMenu.TabIndex = 4;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // tsb_Close
            // 
            this.tsb_Close.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_Close.Name = "tsb_Close";
            this.tsb_Close.Size = new System.Drawing.Size(59, 33);
            this.tsb_Close.Text = "Close";
            this.tsb_Close.Click += new System.EventHandler(this.tsb_Close_Click);
            // 
            // tssSeparator1
            // 
            this.tssSeparator1.Name = "tssSeparator1";
            this.tssSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(357, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Entity";
            // 
            // box_Entity
            // 
            this.box_Entity.Enabled = false;
            this.box_Entity.FormattingEnabled = true;
            this.box_Entity.Location = new System.Drawing.Point(362, 77);
            this.box_Entity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.box_Entity.Name = "box_Entity";
            this.box_Entity.Size = new System.Drawing.Size(314, 28);
            this.box_Entity.TabIndex = 9;
            this.box_Entity.SelectedIndexChanged += new System.EventHandler(this.box_Entity_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 288);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Targets";
            // 
            // btn_Create
            // 
            this.btn_Create.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Create.Enabled = false;
            this.btn_Create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Create.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_Create.Location = new System.Drawing.Point(362, 312);
            this.btn_Create.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(318, 35);
            this.btn_Create.TabIndex = 13;
            this.btn_Create.Text = "Create Lookup";
            this.btn_Create.UseVisualStyleBackColor = true;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 20);
            this.label11.TabIndex = 26;
            this.label11.Text = "Solution";
            // 
            // box_Solution
            // 
            this.box_Solution.Enabled = false;
            this.box_Solution.FormattingEnabled = true;
            this.box_Solution.Location = new System.Drawing.Point(18, 75);
            this.box_Solution.Name = "box_Solution";
            this.box_Solution.Size = new System.Drawing.Size(314, 28);
            this.box_Solution.TabIndex = 25;
            this.box_Solution.SelectedIndexChanged += new System.EventHandler(this.box_Solution_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(357, 114);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(101, 20);
            this.label14.TabIndex = 28;
            this.label14.Text = "Requirement";
            // 
            // box_Requirement
            // 
            this.box_Requirement.Enabled = false;
            this.box_Requirement.FormattingEnabled = true;
            this.box_Requirement.Items.AddRange(new object[] {
            "Optional",
            "Required",
            "Recommended"});
            this.box_Requirement.Location = new System.Drawing.Point(362, 135);
            this.box_Requirement.Name = "box_Requirement";
            this.box_Requirement.Size = new System.Drawing.Size(314, 28);
            this.box_Requirement.TabIndex = 29;
            this.box_Requirement.Text = "Optional";
            this.box_Requirement.SelectedIndexChanged += new System.EventHandler(this.box_Requirement_SelectedIndexChanged);
            // 
            // txt_Label
            // 
            this.txt_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Label.Enabled = false;
            this.txt_Label.Location = new System.Drawing.Point(18, 134);
            this.txt_Label.MaxLength = 30;
            this.txt_Label.Name = "txt_Label";
            this.txt_Label.Size = new System.Drawing.Size(316, 26);
            this.txt_Label.TabIndex = 27;
            this.txt_Label.TextChanged += new System.EventHandler(this.txt_Label_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "Label";
            // 
            // lst_Format
            // 
            this.lst_Format.Enabled = false;
            this.lst_Format.FormattingEnabled = true;
            this.lst_Format.ItemHeight = 20;
            this.lst_Format.Items.AddRange(new object[] {
            "camelCase",
            "lowercase",
            "PascalCase",
            "UPPERCASE"});
            this.lst_Format.Location = new System.Drawing.Point(18, 191);
            this.lst_Format.Name = "lst_Format";
            this.lst_Format.Size = new System.Drawing.Size(658, 84);
            this.lst_Format.TabIndex = 30;
            this.lst_Format.SelectedIndexChanged += new System.EventHandler(this.lst_Format_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "Schema Format";
            // 
            // lst_Targets
            // 
            this.lst_Targets.CheckOnClick = true;
            this.lst_Targets.Enabled = false;
            this.lst_Targets.FormattingEnabled = true;
            this.lst_Targets.Location = new System.Drawing.Point(18, 312);
            this.lst_Targets.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lst_Targets.Name = "lst_Targets";
            this.lst_Targets.Size = new System.Drawing.Size(314, 602);
            this.lst_Targets.TabIndex = 33;
            this.lst_Targets.SelectedIndexChanged += new System.EventHandler(this.lst_Targets_SelectedIndexChanged);
            // 
            // btn_Publish
            // 
            this.btn_Publish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Publish.Enabled = false;
            this.btn_Publish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Publish.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_Publish.Location = new System.Drawing.Point(362, 357);
            this.btn_Publish.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Publish.Name = "btn_Publish";
            this.btn_Publish.Size = new System.Drawing.Size(318, 35);
            this.btn_Publish.TabIndex = 34;
            this.btn_Publish.Text = "Publish Customizations";
            this.btn_Publish.UseVisualStyleBackColor = true;
            this.btn_Publish.Click += new System.EventHandler(this.btn_Publish_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = global::MultiTargetLookupGenerator.Properties.Resources.sagemodeicon;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(827, 191);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(512, 512);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // tsb_LoadEntities
            // 
            this.tsb_LoadEntities.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_LoadEntities.Image = ((System.Drawing.Image)(resources.GetObject("tsb_LoadEntities.Image")));
            this.tsb_LoadEntities.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_LoadEntities.Name = "tsb_LoadEntities";
            this.tsb_LoadEntities.Size = new System.Drawing.Size(116, 29);
            this.tsb_LoadEntities.Text = "Load Entities";
            this.tsb_LoadEntities.Click += new System.EventHandler(this.tsb_LoadEntities_Click);
            // 
            // MultiTargetLookupGeneratorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Publish);
            this.Controls.Add(this.lst_Targets);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.box_Requirement);
            this.Controls.Add(this.txt_Label);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lst_Format);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.box_Solution);
            this.Controls.Add(this.btn_Create);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.box_Entity);
            this.Controls.Add(this.toolStripMenu);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MultiTargetLookupGeneratorControl";
            this.Size = new System.Drawing.Size(1689, 943);
            this.Load += new System.EventHandler(this.MultiTargetLookupGeneratorControl_Load);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton tsb_Close;
        private System.Windows.Forms.ToolStripSeparator tssSeparator1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox box_Entity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Create;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox box_Solution;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox box_Requirement;
        private System.Windows.Forms.TextBox txt_Label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lst_Format;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox lst_Targets;
        private System.Windows.Forms.Button btn_Publish;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripButton tsb_LoadEntities;
    }
}
