using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DominionShuffler 
{
    enum VersionName 
    {
        BASIC, INTRIGUE, SEASIDE, PROSPERITY, HARVEST, ARCHEMY, FOREIGN
    }

    class Card
    {
        int pri_number;
        int pri_cost;
        bool pri_portion;
        string pri_name;
        VersionName pri_version;

        public int Number
        {
            get { return pri_number; }
            set { pri_number = value; }
        }

        public int Cost
        {
            get { return pri_cost; }
            set { pri_cost = value; }
        }

        public bool Portion
        {
            get { return pri_portion; }
            set { pri_portion = value; }
        }

        public string Name
        {
            get { return pri_name; }
            set { pri_name = value; }
        }

        public VersionName Version
        {
            get { return pri_version; }
            set { pri_version = value; }
        }

        public Card(int number, int cost, bool portion, string name, VersionName version)
        {
            Number = number;
            Cost = cost;
            Portion = portion;
            Name = name;
            Version = version;
        }

        private string getVersionName()
        {
            switch (Version)
            {
                case VersionName.BASIC:
                    return "基本";
                case VersionName.INTRIGUE:
                    return "陰謀";
                case VersionName.SEASIDE:
                    return "海辺";
                case VersionName.PROSPERITY:
                    return "繁栄";
                case VersionName.HARVEST:
                    return "収穫";
                case VersionName.FOREIGN:
                    return "異郷";
                case VersionName.ARCHEMY:
                    return "錬金";
                default:
                    return "おっと、プログラムのミスだね^^";
            }
        }

        public string getCardInfo() 
        {
            return String.Format("{0:D3} - {1} - {2}", Number, getVersionName(), Name);
        }
    }
}
