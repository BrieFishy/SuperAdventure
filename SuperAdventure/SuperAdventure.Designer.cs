namespace SuperAdventure
{
    partial class SuperAdventure
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblHitPoints = new System.Windows.Forms.Label();
            this.lblGold = new System.Windows.Forms.Label();
            this.lblExperience = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.cboWeapons = new System.Windows.Forms.ComboBox();
            this.cboPotions = new System.Windows.Forms.ComboBox();
            this.btnUseWeapon = new System.Windows.Forms.Button();
            this.btnUsePotion = new System.Windows.Forms.Button();
            this.btnNorth = new System.Windows.Forms.Button();
            this.btnEast = new System.Windows.Forms.Button();
            this.btnSouth = new System.Windows.Forms.Button();
            this.btnWest = new System.Windows.Forms.Button();
            this.rtbLocation = new System.Windows.Forms.RichTextBox();
            this.rtbMessages = new System.Windows.Forms.RichTextBox();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.dgvQuests = new System.Windows.Forms.DataGridView();
            this.btnBuyItem = new System.Windows.Forms.Button();
            this.cboShopItems = new System.Windows.Forms.ComboBox();
            this.btnSellItem = new System.Windows.Forms.Button();
            this.cboSellInventory = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblArmorStrength = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblEquippedHelmet = new System.Windows.Forms.Label();
            this.lblEquippedBreastplate = new System.Windows.Forms.Label();
            this.lblEquippedShield = new System.Windows.Forms.Label();
            this.lblEquippedPants = new System.Windows.Forms.Label();
            this.cboArmor = new System.Windows.Forms.ComboBox();
            this.btnArmorEquip = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuests)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hit Points:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gold:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Experience:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Level:";
            // 
            // lblHitPoints
            // 
            this.lblHitPoints.AutoSize = true;
            this.lblHitPoints.Location = new System.Drawing.Point(110, 7);
            this.lblHitPoints.MaximumSize = new System.Drawing.Size(90, 0);
            this.lblHitPoints.Name = "lblHitPoints";
            this.lblHitPoints.Size = new System.Drawing.Size(0, 17);
            this.lblHitPoints.TabIndex = 4;
            // 
            // lblGold
            // 
            this.lblGold.AutoSize = true;
            this.lblGold.Location = new System.Drawing.Point(110, 27);
            this.lblGold.MaximumSize = new System.Drawing.Size(90, 0);
            this.lblGold.Name = "lblGold";
            this.lblGold.Size = new System.Drawing.Size(0, 17);
            this.lblGold.TabIndex = 5;
            // 
            // lblExperience
            // 
            this.lblExperience.AutoSize = true;
            this.lblExperience.Location = new System.Drawing.Point(110, 49);
            this.lblExperience.MaximumSize = new System.Drawing.Size(90, 0);
            this.lblExperience.Name = "lblExperience";
            this.lblExperience.Size = new System.Drawing.Size(0, 17);
            this.lblExperience.TabIndex = 6;
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(110, 69);
            this.lblLevel.MaximumSize = new System.Drawing.Size(90, 0);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(0, 17);
            this.lblLevel.TabIndex = 7;
            // 
            // cboWeapons
            // 
            this.cboWeapons.FormattingEnabled = true;
            this.cboWeapons.Location = new System.Drawing.Point(369, 575);
            this.cboWeapons.Name = "cboWeapons";
            this.cboWeapons.Size = new System.Drawing.Size(121, 24);
            this.cboWeapons.TabIndex = 9;
            // 
            // cboPotions
            // 
            this.cboPotions.FormattingEnabled = true;
            this.cboPotions.Location = new System.Drawing.Point(369, 609);
            this.cboPotions.Name = "cboPotions";
            this.cboPotions.Size = new System.Drawing.Size(121, 24);
            this.cboPotions.TabIndex = 10;
            // 
            // btnUseWeapon
            // 
            this.btnUseWeapon.Location = new System.Drawing.Point(632, 576);
            this.btnUseWeapon.Name = "btnUseWeapon";
            this.btnUseWeapon.Size = new System.Drawing.Size(75, 23);
            this.btnUseWeapon.TabIndex = 11;
            this.btnUseWeapon.Text = "Use";
            this.btnUseWeapon.UseVisualStyleBackColor = true;
            this.btnUseWeapon.Click += new System.EventHandler(this.BtnUseWeapon_Click);
            // 
            // btnUsePotion
            // 
            this.btnUsePotion.Location = new System.Drawing.Point(632, 610);
            this.btnUsePotion.Name = "btnUsePotion";
            this.btnUsePotion.Size = new System.Drawing.Size(75, 23);
            this.btnUsePotion.TabIndex = 12;
            this.btnUsePotion.Text = "Use";
            this.btnUsePotion.UseVisualStyleBackColor = true;
            this.btnUsePotion.Click += new System.EventHandler(this.BtnUsePotion_Click);
            // 
            // btnNorth
            // 
            this.btnNorth.Location = new System.Drawing.Point(493, 433);
            this.btnNorth.Name = "btnNorth";
            this.btnNorth.Size = new System.Drawing.Size(75, 23);
            this.btnNorth.TabIndex = 13;
            this.btnNorth.Text = "North";
            this.btnNorth.UseVisualStyleBackColor = true;
            this.btnNorth.Click += new System.EventHandler(this.BtnNorth_Click);
            // 
            // btnEast
            // 
            this.btnEast.Location = new System.Drawing.Point(573, 457);
            this.btnEast.Name = "btnEast";
            this.btnEast.Size = new System.Drawing.Size(75, 23);
            this.btnEast.TabIndex = 14;
            this.btnEast.Text = "East";
            this.btnEast.UseVisualStyleBackColor = true;
            this.btnEast.Click += new System.EventHandler(this.BtnEast_Click);
            // 
            // btnSouth
            // 
            this.btnSouth.Location = new System.Drawing.Point(493, 487);
            this.btnSouth.Name = "btnSouth";
            this.btnSouth.Size = new System.Drawing.Size(75, 23);
            this.btnSouth.TabIndex = 15;
            this.btnSouth.Text = "South";
            this.btnSouth.UseVisualStyleBackColor = true;
            this.btnSouth.Click += new System.EventHandler(this.BtnSouth_Click);
            // 
            // btnWest
            // 
            this.btnWest.Location = new System.Drawing.Point(412, 457);
            this.btnWest.Name = "btnWest";
            this.btnWest.Size = new System.Drawing.Size(75, 23);
            this.btnWest.TabIndex = 16;
            this.btnWest.Text = "West";
            this.btnWest.UseVisualStyleBackColor = true;
            this.btnWest.Click += new System.EventHandler(this.BtnWest_Click);
            // 
            // rtbLocation
            // 
            this.rtbLocation.Location = new System.Drawing.Point(347, 19);
            this.rtbLocation.Name = "rtbLocation";
            this.rtbLocation.ReadOnly = true;
            this.rtbLocation.Size = new System.Drawing.Size(360, 105);
            this.rtbLocation.TabIndex = 17;
            this.rtbLocation.Text = "";
            // 
            // rtbMessages
            // 
            this.rtbMessages.Location = new System.Drawing.Point(347, 130);
            this.rtbMessages.Name = "rtbMessages";
            this.rtbMessages.ReadOnly = true;
            this.rtbMessages.Size = new System.Drawing.Size(360, 286);
            this.rtbMessages.TabIndex = 18;
            this.rtbMessages.Text = "";
            // 
            // dgvInventory
            // 
            this.dgvInventory.AllowUserToAddRows = false;
            this.dgvInventory.AllowUserToDeleteRows = false;
            this.dgvInventory.AllowUserToResizeRows = false;
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvInventory.Enabled = false;
            this.dgvInventory.Location = new System.Drawing.Point(16, 130);
            this.dgvInventory.MultiSelect = false;
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.ReadOnly = true;
            this.dgvInventory.RowHeadersVisible = false;
            this.dgvInventory.RowTemplate.Height = 24;
            this.dgvInventory.Size = new System.Drawing.Size(312, 309);
            this.dgvInventory.TabIndex = 19;
            // 
            // dgvQuests
            // 
            this.dgvQuests.AllowUserToAddRows = false;
            this.dgvQuests.AllowUserToDeleteRows = false;
            this.dgvQuests.AllowUserToResizeRows = false;
            this.dgvQuests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuests.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvQuests.Enabled = false;
            this.dgvQuests.Location = new System.Drawing.Point(16, 446);
            this.dgvQuests.MultiSelect = false;
            this.dgvQuests.Name = "dgvQuests";
            this.dgvQuests.ReadOnly = true;
            this.dgvQuests.RowHeadersVisible = false;
            this.dgvQuests.RowTemplate.Height = 24;
            this.dgvQuests.Size = new System.Drawing.Size(312, 189);
            this.dgvQuests.TabIndex = 20;
            // 
            // btnBuyItem
            // 
            this.btnBuyItem.Location = new System.Drawing.Point(573, 567);
            this.btnBuyItem.Name = "btnBuyItem";
            this.btnBuyItem.Size = new System.Drawing.Size(134, 30);
            this.btnBuyItem.TabIndex = 22;
            this.btnBuyItem.Text = "Buy";
            this.btnBuyItem.UseVisualStyleBackColor = true;
            this.btnBuyItem.Click += new System.EventHandler(this.btnBuyItem_Click);
            // 
            // cboShopItems
            // 
            this.cboShopItems.DisplayMember = "\"Value\"";
            this.cboShopItems.FormattingEnabled = true;
            this.cboShopItems.Location = new System.Drawing.Point(334, 575);
            this.cboShopItems.MaxDropDownItems = 10;
            this.cboShopItems.Name = "cboShopItems";
            this.cboShopItems.Size = new System.Drawing.Size(121, 24);
            this.cboShopItems.TabIndex = 23;
            this.cboShopItems.ValueMember = "\"";
            this.cboShopItems.SelectedIndexChanged += new System.EventHandler(this.cboShopItems_SelectedIndexChanged);
            // 
            // btnSellItem
            // 
            this.btnSellItem.Location = new System.Drawing.Point(573, 603);
            this.btnSellItem.Name = "btnSellItem";
            this.btnSellItem.Size = new System.Drawing.Size(134, 30);
            this.btnSellItem.TabIndex = 24;
            this.btnSellItem.Text = "Sell";
            this.btnSellItem.UseVisualStyleBackColor = true;
            this.btnSellItem.Click += new System.EventHandler(this.btnSellItem_Click);
            // 
            // cboSellInventory
            // 
            this.cboSellInventory.DisplayMember = "\"Value\"";
            this.cboSellInventory.FormattingEnabled = true;
            this.cboSellInventory.Location = new System.Drawing.Point(334, 609);
            this.cboSellInventory.MaxDropDownItems = 10;
            this.cboSellInventory.Name = "cboSellInventory";
            this.cboSellInventory.Size = new System.Drawing.Size(121, 24);
            this.cboSellInventory.TabIndex = 25;
            this.cboSellInventory.ValueMember = "\"";
            this.cboSellInventory.SelectedIndexChanged += new System.EventHandler(this.cboSellInventory_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = "Armor Strength:";
            // 
            // lblArmorStrength
            // 
            this.lblArmorStrength.AutoSize = true;
            this.lblArmorStrength.Location = new System.Drawing.Point(140, 87);
            this.lblArmorStrength.MaximumSize = new System.Drawing.Size(60, 0);
            this.lblArmorStrength.Name = "lblArmorStrength";
            this.lblArmorStrength.Size = new System.Drawing.Size(16, 17);
            this.lblArmorStrength.TabIndex = 27;
            this.lblArmorStrength.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(200, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 17);
            this.label8.TabIndex = 28;
            this.label8.Text = "Equipped Armor";
            // 
            // lblEquippedHelmet
            // 
            this.lblEquippedHelmet.AutoSize = true;
            this.lblEquippedHelmet.Location = new System.Drawing.Point(200, 27);
            this.lblEquippedHelmet.Name = "lblEquippedHelmet";
            this.lblEquippedHelmet.Size = new System.Drawing.Size(0, 17);
            this.lblEquippedHelmet.TabIndex = 29;
            // 
            // lblEquippedBreastplate
            // 
            this.lblEquippedBreastplate.AutoSize = true;
            this.lblEquippedBreastplate.Location = new System.Drawing.Point(200, 47);
            this.lblEquippedBreastplate.Name = "lblEquippedBreastplate";
            this.lblEquippedBreastplate.Size = new System.Drawing.Size(0, 17);
            this.lblEquippedBreastplate.TabIndex = 30;
            // 
            // lblEquippedShield
            // 
            this.lblEquippedShield.AutoSize = true;
            this.lblEquippedShield.Location = new System.Drawing.Point(200, 67);
            this.lblEquippedShield.Name = "lblEquippedShield";
            this.lblEquippedShield.Size = new System.Drawing.Size(0, 17);
            this.lblEquippedShield.TabIndex = 31;
            // 
            // lblEquippedPants
            // 
            this.lblEquippedPants.AutoSize = true;
            this.lblEquippedPants.Location = new System.Drawing.Point(200, 87);
            this.lblEquippedPants.Name = "lblEquippedPants";
            this.lblEquippedPants.Size = new System.Drawing.Size(0, 17);
            this.lblEquippedPants.TabIndex = 32;
            // 
            // cboArmor
            // 
            this.cboArmor.DisplayMember = "\"Value\"";
            this.cboArmor.FormattingEnabled = true;
            this.cboArmor.Location = new System.Drawing.Point(334, 545);
            this.cboArmor.MaxDropDownItems = 10;
            this.cboArmor.Name = "cboArmor";
            this.cboArmor.Size = new System.Drawing.Size(156, 24);
            this.cboArmor.TabIndex = 33;
            this.cboArmor.ValueMember = "\"";
            this.cboArmor.SelectedIndexChanged += new System.EventHandler(this.cboArmor_SelectedIndexChanged);
            // 
            // btnArmorEquip
            // 
            this.btnArmorEquip.Location = new System.Drawing.Point(630, 538);
            this.btnArmorEquip.Name = "btnArmorEquip";
            this.btnArmorEquip.Size = new System.Drawing.Size(75, 23);
            this.btnArmorEquip.TabIndex = 34;
            this.btnArmorEquip.Text = "Equip";
            this.btnArmorEquip.UseVisualStyleBackColor = true;
            this.btnArmorEquip.Click += new System.EventHandler(this.btnArmorEquip_Click);
            // 
            // SuperAdventure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 643);
            this.Controls.Add(this.btnArmorEquip);
            this.Controls.Add(this.cboArmor);
            this.Controls.Add(this.lblEquippedPants);
            this.Controls.Add(this.lblEquippedShield);
            this.Controls.Add(this.lblEquippedBreastplate);
            this.Controls.Add(this.lblEquippedHelmet);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblArmorStrength);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboSellInventory);
            this.Controls.Add(this.cboShopItems);
            this.Controls.Add(this.dgvQuests);
            this.Controls.Add(this.dgvInventory);
            this.Controls.Add(this.rtbMessages);
            this.Controls.Add(this.rtbLocation);
            this.Controls.Add(this.btnWest);
            this.Controls.Add(this.btnSouth);
            this.Controls.Add(this.btnEast);
            this.Controls.Add(this.btnNorth);
            this.Controls.Add(this.btnUsePotion);
            this.Controls.Add(this.btnUseWeapon);
            this.Controls.Add(this.cboPotions);
            this.Controls.Add(this.cboWeapons);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.lblExperience);
            this.Controls.Add(this.lblGold);
            this.Controls.Add(this.lblHitPoints);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSellItem);
            this.Controls.Add(this.btnBuyItem);
            this.Name = "SuperAdventure";
            this.Text = "My Game";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblHitPoints;
        private System.Windows.Forms.Label lblGold;
        private System.Windows.Forms.Label lblExperience;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.ComboBox cboWeapons;
        private System.Windows.Forms.ComboBox cboPotions;
        private System.Windows.Forms.Button btnUseWeapon;
        private System.Windows.Forms.Button btnUsePotion;
        private System.Windows.Forms.Button btnNorth;
        private System.Windows.Forms.Button btnEast;
        private System.Windows.Forms.Button btnSouth;
        private System.Windows.Forms.Button btnWest;
        private System.Windows.Forms.RichTextBox rtbLocation;
        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.DataGridView dgvQuests;
        private System.Windows.Forms.RichTextBox rtbMessages;
        private System.Windows.Forms.Button btnBuyItem;
        private System.Windows.Forms.ComboBox cboShopItems;
        private System.Windows.Forms.Button btnSellItem;
        private System.Windows.Forms.ComboBox cboSellInventory;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblArmorStrength;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblEquippedHelmet;
        private System.Windows.Forms.Label lblEquippedBreastplate;
        private System.Windows.Forms.Label lblEquippedShield;
        private System.Windows.Forms.Label lblEquippedPants;
        private System.Windows.Forms.ComboBox cboArmor;
        private System.Windows.Forms.Button btnArmorEquip;
    }
}

