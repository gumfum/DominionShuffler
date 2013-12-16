using System;

namespace DominionShuffler {
    enum VersionName {
        Bas, Int, Sea, Pro, Har, For, Alc, Bla, Gui,
    }

    class Card {
        public int Number { get; set; }

        public int Cost { get; set; }

        public bool Portion { get; set; }

        public string Name { get; set; }

        public VersionName Version { get; set; }

        public Card(int number, int cost, bool portion, string name, VersionName version) {
            Number = number;
            Cost = cost;
            Portion = portion;
            Name = name;
            Version = version;
        }

        private string GetVersionName() {
            switch (Version) {
                case VersionName.Bas:
                    return "基本";
                case VersionName.Int:
                    return "陰謀";
                case VersionName.Sea:
                    return "海辺";
                case VersionName.Pro:
                    return "繁栄";
                case VersionName.Har:
                    return "収穫";
                case VersionName.For:
                    return "異郷";
                case VersionName.Alc:
                    return "錬金";
                case VersionName.Bla:
                    return "暗黒";
                case VersionName.Gui:
                    return "ギルド";
                default:
                    return "おっと、プログラムのミスだね^^";
            }
        }

        public string GetCardInfo() {
            return String.Format("{0:D3} - {1} - {2}", Number, GetVersionName(), Name);
        }
    }
}
