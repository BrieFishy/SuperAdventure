using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Engine;

namespace SuperAdventure
{
    public partial class SuperAdventure : Form
    {
        private Player _player;
        private Monster _currentMonster;
        private Item _currentShopItem;
        private Armor _equipArmor;

        public SuperAdventure()
        {
            InitializeComponent();

            _player = new Player(10, 10, 20, 0, 1);
            MoveTo(World.LocationByID(World.LOCATION_ID_HOME));
            _player.Inventory.Add(new InventoryItem(World.ItemByID(World.ITEM_ID_RUSTY_SWORD), 1));

            lblHitPoints.Text = _player.CurrentHitPoints.ToString();
            lblGold.Text = _player.Gold.ToString();
            lblExperience.Text = _player.ExperiencePoints.ToString();
            lblLevel.Text = _player.Level.ToString();
        }

        private void BtnNorth_Click(object sender, EventArgs e)
        {
            MoveTo(_player.CurrentLocation.LocationToNorth);
        }

        private void BtnEast_Click(object sender, EventArgs e)
        {
            MoveTo(_player.CurrentLocation.LocationToEast);
        }

        private void BtnSouth_Click(object sender, EventArgs e)
        {
            MoveTo(_player.CurrentLocation.LocationToSouth);
        }

        private void BtnWest_Click(object sender, EventArgs e)
        {
            MoveTo(_player.CurrentLocation.LocationToWest);
        }

        private void MoveTo(Location newLocation)
        {
            //Does the location have any required items
            if (!_player.HasRequiredItemToEnterThisLocation(newLocation))
            {
                rtbMessages.Text += "You must have a " + newLocation.ItemRequiredToEnter.Name + " to enter this location." + Environment.NewLine;
                return;
            }

            // Update the player's current location
            _player.CurrentLocation = newLocation;

            // Show/hide available movement buttons
            btnNorth.Visible = (newLocation.LocationToNorth != null);
            btnEast.Visible = (newLocation.LocationToEast != null);
            btnSouth.Visible = (newLocation.LocationToSouth != null);
            btnWest.Visible = (newLocation.LocationToWest != null);

            // Display current location name and description
            rtbLocation.Text = newLocation.Name + Environment.NewLine;
            rtbLocation.Text += newLocation.Description + Environment.NewLine;

            // Completely heal the player
            _player.CurrentHitPoints = _player.MaximumHitPoints;

            // Update Hit Points in UI
            lblHitPoints.Text = _player.CurrentHitPoints.ToString();

            // Does the location have a quest?
            if (newLocation.QuestAvailableHere != null)
            {
                // See if the player already has the quest, and if they've completed it
                bool playerAlreadyHasQuest = _player.HasThisQuest(newLocation.QuestAvailableHere);
                bool playerAlreadyCompletedQuest = _player.CompletedThisQuest(newLocation.QuestAvailableHere);

                // See if the player already has the quest
                if (playerAlreadyHasQuest)
                {
                    // If the player has not completed the quest yet
                    if (!playerAlreadyCompletedQuest)
                    {
                        // See if the player has all the items needed to complete the quest
                        bool playerHasAllItemsToCompleteQuest = _player.HasAllQuestCompletionItems(newLocation.QuestAvailableHere);

                        // The player has all items required to complete the quest
                        if (playerHasAllItemsToCompleteQuest)
                        {
                            // Display message
                            rtbMessages.Text += Environment.NewLine;
                            rtbMessages.Text += "You complete the '" + newLocation.QuestAvailableHere.Name + "' quest." + Environment.NewLine;

                            // Remove quest items from inventory
                            _player.RemoveQuestCompletionItems(newLocation.QuestAvailableHere);

                            // Give quest rewards
                            rtbMessages.Text += "You receive: " + Environment.NewLine;
                            rtbMessages.Text += newLocation.QuestAvailableHere.RewardExperiencePoints.ToString() + " experience points" + Environment.NewLine;
                            rtbMessages.Text += newLocation.QuestAvailableHere.RewardGold.ToString() + " gold" + Environment.NewLine;
                            rtbMessages.Text += newLocation.QuestAvailableHere.RewardItem.Name + Environment.NewLine;
                            rtbMessages.Text += Environment.NewLine;

                            _player.ExperiencePoints += newLocation.QuestAvailableHere.RewardExperiencePoints;
                            _player.Gold += newLocation.QuestAvailableHere.RewardGold;

                            // Add the reward item to the player's inventory
                            _player.AddItemToInventory(newLocation.QuestAvailableHere.RewardItem);

                            // Mark the quest as completed
                            _player.MarkQuestCompleted(newLocation.QuestAvailableHere);
                        }
                    }
                }
                else
                {
                    // The player does not already have the quest

                    // Display the messages
                    rtbMessages.Text += "You receive the " + newLocation.QuestAvailableHere.Name + " quest." + Environment.NewLine;
                    rtbMessages.Text += newLocation.QuestAvailableHere.Description + Environment.NewLine;
                    rtbMessages.Text += "To complete it, return with:" + Environment.NewLine;
                    foreach (QuestCompletionItem qci in newLocation.QuestAvailableHere.QuestCompletionItems)
                    {
                        if (qci.Quantity == 1)
                        {
                            rtbMessages.Text += qci.Quantity.ToString() + " " + qci.Details.Name + Environment.NewLine;
                        }
                        else
                        {
                            rtbMessages.Text += qci.Quantity.ToString() + " " + qci.Details.NamePlural + Environment.NewLine;
                        }
                    }
                    rtbMessages.Text += Environment.NewLine;

                    // Add the quest to the player's quest list
                    _player.Quests.Add(new PlayerQuest(newLocation.QuestAvailableHere));
                }
            }

            // Does the location have a monster?
            if (newLocation.MonsterLivingHere != null)
            {
                rtbMessages.Text += "You see a " + newLocation.MonsterLivingHere.Name + Environment.NewLine;

                // Make a new monster, using the values from the standard monster in the World.Monster list
                Monster standardMonster = World.MonsterByID(newLocation.MonsterLivingHere.ID);

                _currentMonster = new Monster(standardMonster.ID, standardMonster.Name, standardMonster.MaximumDamage, standardMonster.MinimumDamage,
                    standardMonster.RewardExperiencePoints, standardMonster.RewardGold, standardMonster.CurrentHitPoints, standardMonster.MaximumHitPoints);
                DisplayMonsterStats();
                
                foreach (LootItem lootItem in standardMonster.LootTable)
                {
                    _currentMonster.LootTable.Add(lootItem);
                }

                cboWeapons.Visible = true;
                cboPotions.Visible = true;
                btnUseWeapon.Visible = true;
                btnUsePotion.Visible = true;
            }
            else
            {
                _currentMonster = null;

                cboWeapons.Visible = false;
                cboPotions.Visible = false;
                btnUseWeapon.Visible = false;
                btnUsePotion.Visible = false;
            }

            // Refresh player's inventory list
            UpdateInventoryListInUI();

            // Refresh player's quest list
            UpdateQuestListInUI();

            // Refresh player's weapons combobox
            UpdateWeaponListInUI();

            // Refresh player's potions combobox
            UpdatePotionListInUI();

            UpdateArmorInUI();

            if (newLocation is Shop)
            {
                Shop shop = (Shop)World.LocationByID(newLocation.ID);
                cboShopItems.DataSource = shop.forSale;
                cboShopItems.DisplayMember = "Name";
                cboShopItems.SelectedValue = "ID";
                cboShopItems.SelectedIndex = 0;
                _currentShopItem = (Item)cboShopItems.SelectedItem;
                cboShopItems.Visible = true;
                btnBuyItem.Visible = true;
                UpdateCboSellInventory(0);
            }
            else {
                cboShopItems.Visible = false;
                btnBuyItem.Visible = false;
                cboSellInventory.Visible = false;
                btnSellItem.Visible = false;
            }
            rtbMessages.SelectionStart = rtbMessages.Text.Length;
            rtbMessages.ScrollToCaret();
        }

        private void UpdateInventoryListInUI()
        {
            dgvInventory.RowHeadersVisible = false;

            dgvInventory.ColumnCount = 2;
            dgvInventory.Columns[0].Name = "Name";
            dgvInventory.Columns[0].Width = 197;
            dgvInventory.Columns[1].Name = "Quantity";

            dgvInventory.Rows.Clear();

            foreach (InventoryItem inventoryItem in _player.Inventory)
            {
                if (inventoryItem.Quantity > 0)
                {
                    dgvInventory.Rows.Add(new[] { inventoryItem.Details.Name, inventoryItem.Quantity.ToString() });
                }
            }
        }

        private void UpdateQuestListInUI()
        {
            dgvQuests.RowHeadersVisible = false;

            dgvQuests.ColumnCount = 2;
            dgvQuests.Columns[0].Name = "Name";
            dgvQuests.Columns[0].Width = 197;
            dgvQuests.Columns[1].Name = "Done?";

            dgvQuests.Rows.Clear();

            foreach (PlayerQuest playerQuest in _player.Quests)
            {
                dgvQuests.Rows.Add(new[] { playerQuest.Details.Name, playerQuest.IsCompleted.ToString() });
            }
        }

        private void UpdateWeaponListInUI()
        {
            List<Weapon> weapons = new List<Weapon>();

            foreach (InventoryItem inventoryItem in _player.Inventory)
            {
                if (inventoryItem.Details is Weapon)
                {
                    if (inventoryItem.Quantity > 0)
                    {
                        weapons.Add((Weapon)inventoryItem.Details);
                    }
                }
            }

            if (weapons.Count == 0)
            {
                // The player doesn't have any weapons, so hide the weapon combobox and "Use" button
                cboWeapons.Visible = false;
                btnUseWeapon.Visible = false;
            }
            else
            {
                cboWeapons.DataSource = weapons;
                cboWeapons.DisplayMember = "Name";
                cboWeapons.ValueMember = "ID";
                
                cboWeapons.SelectedIndex = 0;
            }
        }

        private void UpdatePotionListInUI()
        {
            List<HealingPotion> healingPotions = new List<HealingPotion>();

            foreach (InventoryItem inventoryItem in _player.Inventory)
            {
                if (inventoryItem.Details is HealingPotion)
                {
                    if (inventoryItem.Quantity > 0)
                    {
                        healingPotions.Add((HealingPotion)inventoryItem.Details);
                    }
                }
            }

            if (healingPotions.Count == 0)
            {
                // The player doesn't have any potions, so hide the potion combobox and "Use" button
                cboPotions.Visible = false;
                btnUsePotion.Visible = false;
            }
            else
            {
                cboPotions.DataSource = healingPotions;
                cboPotions.DisplayMember = "Name";
                cboPotions.ValueMember = "ID";

                cboPotions.SelectedIndex = 0;
            }
        }

        private void BtnUseWeapon_Click(object sender, EventArgs e)
        {
            // Get the currently selected weapon from the cboWeapons ComboBox
            Weapon currentWeapon = (Weapon)cboWeapons.SelectedItem;

            // Determine the amount of damage to do to the monster
            int damageToMonster = RandomNumberGenerator.NumberBetween(currentWeapon.MinimumDamage, currentWeapon.MaximumDamage);

            // Apply the damage to the monster's CurrentHitPoints
            _currentMonster.CurrentHitPoints -= damageToMonster;

            // Display message
            rtbMessages.Text += "You hit the " + _currentMonster.Name + " for " + damageToMonster.ToString() + " points." + Environment.NewLine;

            // Check if the monster is dead
            if (_currentMonster.CurrentHitPoints <= 0)
            {
                // Monster is dead
                rtbMessages.Text += Environment.NewLine;
                rtbMessages.Text += "You defeated the " + _currentMonster.Name + Environment.NewLine;

                // Give player experience points for killing the monster
                _player.ExperiencePoints += _currentMonster.RewardExperiencePoints;
                rtbMessages.Text += "You receive " + _currentMonster.RewardExperiencePoints.ToString() + " experience points" + Environment.NewLine;

                // Give player gold for killing the monster 
                _player.Gold += _currentMonster.RewardGold;
                rtbMessages.Text += "You receive " + _currentMonster.RewardGold.ToString() + " gold" + Environment.NewLine;

                // Get random loot items from the monster
                List<InventoryItem> lootedItems = new List<InventoryItem>();

                // Add items to the lootedItems list, comparing a random number to the drop percentage
                foreach (LootItem lootItem in _currentMonster.LootTable)
                {
                    if (RandomNumberGenerator.NumberBetween(1, 100) <= lootItem.DropPercentage)
                    {
                        lootedItems.Add(new InventoryItem(lootItem.Details, 1));
                    }
                }

                // If no items were randomly selected, then add the default loot item(s).
                if (lootedItems.Count == 0)
                {
                    foreach (LootItem lootItem in _currentMonster.LootTable)
                    {
                        if (lootItem.IsDefaultItem)
                        {
                            lootedItems.Add(new InventoryItem(lootItem.Details, 1));
                        }
                    }
                }

                // Add the looted items to the player's inventory
                foreach (InventoryItem inventoryItem in lootedItems)
                {
                    _player.AddItemToInventory(inventoryItem.Details);

                    if (inventoryItem.Quantity == 1)
                    {
                        rtbMessages.Text += "You loot " + inventoryItem.Quantity.ToString() + " " + inventoryItem.Details.Name + Environment.NewLine;
                    }
                    else
                    {
                        rtbMessages.Text += "You loot " + inventoryItem.Quantity.ToString() + " " + inventoryItem.Details.NamePlural + Environment.NewLine;
                    }
                }

                // Refresh player information and inventory controls
                lblHitPoints.Text = _player.CurrentHitPoints.ToString();
                lblGold.Text = _player.Gold.ToString();
                lblExperience.Text = _player.ExperiencePoints.ToString();
                lblLevel.Text = _player.Level.ToString();

                UpdateInventoryListInUI();
                UpdateWeaponListInUI();
                UpdatePotionListInUI();

                // Add a blank line to the messages box, just for appearance.
                rtbMessages.Text += Environment.NewLine;

                // Move player to current location (to heal player and create a new monster to fight)
                MoveTo(_player.CurrentLocation);
            }
            else
            {
                DisplayMonsterStats();
                MonsterAttack();
            }
            ScrollMessagesToBottom();
        }
        private void BtnUsePotion_Click(object sender, EventArgs e)
        {
            // Get the currently selected potion from the combobox
            HealingPotion potion = (HealingPotion)cboPotions.SelectedItem;

            // Add healing amount to the player's current hit points
            _player.CurrentHitPoints = (_player.CurrentHitPoints + potion.AmountToHeal);

            // CurrentHitPoints cannot exceed player's MaximumHitPoints
            if (_player.CurrentHitPoints > _player.MaximumHitPoints)
            {
                _player.CurrentHitPoints = _player.MaximumHitPoints;
            }

            // Remove the potion from the player's inventory
            foreach (InventoryItem ii in _player.Inventory)
            {
                if (ii.Details.ID == potion.ID)
                {
                    ii.Quantity--;
                    break;
                }
            }

            // Display message
            rtbMessages.Text += "You drink a " + potion.Name + Environment.NewLine;

            MonsterAttack();

            // Refresh player data in UI
            lblHitPoints.Text = _player.CurrentHitPoints.ToString();
            ScrollMessagesToBottom();
        }

        private void btnBuyItem_Click(object sender, EventArgs e)
        {
            _currentShopItem = (Item)cboShopItems.SelectedItem;
            int gold = _currentShopItem.Value;
            if (gold <= _player.Gold)
            {
                rtbMessages.Text += "You just purchased a " + _currentShopItem.Name + " for " + _currentShopItem.Value + " gold." + Environment.NewLine;
                _player.Gold -= gold;
                _player.AddItemToInventory(_currentShopItem);
                UpdateInventoryListInUI();
                UpdateWeaponListInUI();
                UpdatePotionListInUI();
                UpdateArmorInUI();
                lblGold.Text = _player.Gold.ToString();
            }

            else
            {
                rtbMessages.Text += "You do not have enough gold to buy this item." + Environment.NewLine;
            }
            ScrollMessagesToBottom();
        }

        private void cboShopItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentShopItem = (Item)cboShopItems.SelectedItem;
            try
            {
                int gold = _currentShopItem.Value;
                btnBuyItem.Text = "Buy (" + gold + ") Gold";
            }
            catch {}
        }

        private void cboSellInventory_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentShopItem = (Item)cboSellInventory.SelectedItem;
            try
            {
                int gold = _currentShopItem.Value / 2;
                btnSellItem.Text = "Sell (" + gold + ") Gold";
            }
            catch { }
        }

        private void btnSellItem_Click(object sender, EventArgs e)
        {
            int cboSellInventorySelectedIndex = cboSellInventory.SelectedIndex;
            _currentShopItem = (Item)cboSellInventory.SelectedItem;
            int gold = _currentShopItem.Value / 2;
            lblGold.Text = _player.Gold.ToString();
            if (_player.RemoveItemFromInventory(_currentShopItem))
            {
                rtbMessages.Text += "You just sold a " + _currentShopItem.Name + " for " + gold + " Gold." +Environment.NewLine;
                _player.Gold += gold;
                cboSellInventory.SelectedValue = "ID";
                UpdateCboSellInventory(cboSellInventorySelectedIndex);
                UpdateInventoryListInUI();
                UpdateArmorInUI();
            }
            else
            {
                rtbMessages.Text += "You do not have a " + _currentShopItem.Name + " to sell." + Environment.NewLine;
            }
            ScrollMessagesToBottom();
        }

        private void UpdateCboSellInventory(int selectedIndex)
        {
            List<Item> sellInventory = new List<Item>();
            foreach (InventoryItem item in _player.Inventory)
            {
                if (item.Details.Value > 0)
                {
                    sellInventory.Add(item.Details);
                }
            }
            if (sellInventory.Count() < 1)
            {
                cboSellInventory.Visible = false;
                btnSellItem.Visible = false;
            }
            else
            {
                cboSellInventory.Visible = true;
                btnSellItem.Visible = true;
                cboSellInventory.DataSource = sellInventory;
                cboSellInventory.DisplayMember = "Name";
                try
                {
                    cboSellInventory.SelectedIndex = selectedIndex;
                }
                catch
                {
                    cboSellInventory.SelectedIndex = 0;
                }
            }
        }
        private void ScrollMessagesToBottom()
        {
            rtbMessages.SelectionStart = rtbMessages.Text.Length;
            rtbMessages.ScrollToCaret();
        }
        private void MonsterAttack()
        {
            // Monster is still alive

            // Determine the amount of damage the monster does to the player
            int damageToPlayer = (int)((100-_player.ArmorStrength)/100)*RandomNumberGenerator.NumberBetween(_currentMonster.MinimumDamage, _currentMonster.MaximumDamage);

            // Display message
            rtbMessages.Text += "The " + _currentMonster.Name + " did " + damageToPlayer.ToString() + " points of damage." + Environment.NewLine;

            // Subtract damage from player
            _player.CurrentHitPoints -= damageToPlayer;

            // Refresh player data in UI
            lblHitPoints.Text = _player.CurrentHitPoints.ToString();

            if (_player.CurrentHitPoints <= 0)
            {
                // Display message
                rtbMessages.Text += Environment.NewLine + "The " + _currentMonster.Name + " killed you." + Environment.NewLine;

                // Move player to "Home"
                MoveTo(World.LocationByID(World.LOCATION_ID_HOME));
            }
        }

        private void cboArmor_SelectedIndexChanged(object sender, EventArgs e)
        {
            _equipArmor = (Armor)cboArmor.SelectedItem;
        }

        private void UpdateArmorInUI()
        {
            List<Armor> armor = new List<Armor>();
            foreach (InventoryItem item in _player.Inventory)
            {
                if (item.Details is Armor)
                {
                    armor.Add((Armor)item.Details);
                }
            }
            if (armor.Count() > 0)
            {
                cboArmor.Visible = true;
                btnArmorEquip.Visible = true;
                cboArmor.DataSource = armor;
                cboArmor.DisplayMember = "Name";
            }
            else
            {
                cboArmor.Visible = false;
                btnArmorEquip.Visible = false;
            }


        }

        private void btnArmorEquip_Click(object sender, EventArgs e)
        {
            if (!_player.equipArmor(_equipArmor))
            {
                rtbMessages.Text += "Error: Could not equip " + _equipArmor.Name + ", invalid armor type" + Environment.NewLine;
            }
            else
            {
                lblArmorStrength.Text = _player.ArmorStrength.ToString();
                if (_player.Helmet != null) { lblEquippedHelmet.Text = _player.Helmet.Name; }
                if (_player.Breastplate != null){ lblEquippedBreastplate.Text = _player.Breastplate.Name; }
                if (_player.Shield != null) { lblEquippedShield.Text = _player.Shield.Name; }
                if (_player.Pants != null) { lblEquippedPants.Text = _player.Pants.Name; }
            }
        }

        private void DisplayMonsterStats()
        {
            rtbLocation.Text = _player.CurrentLocation.Name + Environment.NewLine + _player.CurrentLocation.Description + Environment.NewLine;
            rtbLocation.Text += _currentMonster.Name + ":" + Environment.NewLine;
            rtbLocation.Text += "Max damage: " + _currentMonster.MaximumDamage + Environment.NewLine + "Min damage: " + _currentMonster.MinimumDamage + Environment.NewLine;
            rtbLocation.Text += "Hit points: " + _currentMonster.CurrentHitPoints + Environment.NewLine;
        }
    }
}
