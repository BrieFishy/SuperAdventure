using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Quest
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int RewardExperiencePoints { get; set; }
        public int RewardGold { get; set; }
        public Item RewardItem { get; set; }
        public String GetQuestDialogue { get; set; }
        public List<String> QuestNotFinishedDialogues { get; set; }
        public String QuestFinishedDialogue { get; set; }
        public List<QuestCompletionItem> QuestCompletionItems { get; set; }

        public Quest(int id, string name, string description, int rewardExperiencePoints, int rewardGold, string getQuestDialogue, List<String> questNotFinishedDialogues, String questFinishedDialogue)
        {
            ID = id;
            Name = name;
            Description = description;
            RewardExperiencePoints = rewardExperiencePoints;
            RewardGold = rewardGold;
            GetQuestDialogue = getQuestDialogue;
            QuestNotFinishedDialogues = questNotFinishedDialogues;
            QuestFinishedDialogue = questFinishedDialogue;
            QuestCompletionItems = new List<QuestCompletionItem>();
        }
    }
}
