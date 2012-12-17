using System.Collections.Generic;

namespace DominionShuffler {
    class CardList {
        readonly List<Card> _list = new List<Card>();

        private static readonly CardList cardList = new CardList();

        private CardList() {
            
        }

        public static CardList GetInstance() {
            return cardList;
        }

        public int Length {
            get { return _list.Count; }
            set { throw new System.NotImplementedException(); }
        }

        public void AddBasicCards() {
            _list.Add(new Card(1, 5, false, "市場", VersionName.Bas));
            _list.Add(new Card(2, 4, false, "改築", VersionName.Bas));
            _list.Add(new Card(3, 4, false, "鍛冶屋", VersionName.Bas));
            _list.Add(new Card(4, 4, false, "金貸し", VersionName.Bas));
            _list.Add(new Card(5, 3, false, "木こり", VersionName.Bas));
            _list.Add(new Card(6, 5, false, "議事堂", VersionName.Bas));
            _list.Add(new Card(7, 4, false, "玉座の間", VersionName.Bas));
            _list.Add(new Card(8, 5, false, "研究所", VersionName.Bas));
            _list.Add(new Card(9, 5, false, "鉱山", VersionName.Bas));
            _list.Add(new Card(10, 3, false, "工房", VersionName.Bas));
            _list.Add(new Card(11, 3, false, "宰相", VersionName.Bas));
            _list.Add(new Card(12, 4, false, "祝宴", VersionName.Bas));
            _list.Add(new Card(13, 5, false, "祝祭", VersionName.Bas));
            _list.Add(new Card(14, 5, false, "書庫", VersionName.Bas));
            _list.Add(new Card(15, 2, false, "地下貯蔵庫", VersionName.Bas));
            _list.Add(new Card(16, 4, false, "庭園", VersionName.Bas));
            _list.Add(new Card(17, 4, false, "泥棒", VersionName.Bas));
            _list.Add(new Card(18, 6, false, "冒険者", VersionName.Bas));
            _list.Add(new Card(19, 2, false, "堀", VersionName.Bas));
            _list.Add(new Card(20, 5, false, "魔女", VersionName.Bas));
            _list.Add(new Card(21, 4, false, "密偵", VersionName.Bas));
            _list.Add(new Card(22, 4, false, "民兵", VersionName.Bas));
            _list.Add(new Card(23, 3, false, "村", VersionName.Bas));
            _list.Add(new Card(24, 4, false, "役人", VersionName.Bas));
            _list.Add(new Card(25, 2, false, "礼拝堂", VersionName.Bas));
        }

        public void AddIntrigueCards() {
            _list.Add(new Card(26, 3, false, "大広間", VersionName.Int));
            _list.Add(new Card(27, 5, false, "改良", VersionName.Int));
            _list.Add(new Card(28, 3, false, "仮面舞踏会", VersionName.Int));
            _list.Add(new Card(29, 6, false, "貴族", VersionName.Int));
            _list.Add(new Card(30, 4, false, "共謀者", VersionName.Int));
            _list.Add(new Card(31, 5, false, "交易場", VersionName.Int));
            _list.Add(new Card(32, 4, false, "鉱山の村", VersionName.Int));
            _list.Add(new Card(33, 5, false, "公爵", VersionName.Int));
            _list.Add(new Card(34, 5, false, "拷問人", VersionName.Int));
            _list.Add(new Card(35, 3, false, "詐欺師", VersionName.Int));
            _list.Add(new Card(36, 3, false, "執事", VersionName.Int));
            _list.Add(new Card(37, 4, false, "男爵", VersionName.Int));
            _list.Add(new Card(38, 5, false, "寵臣", VersionName.Int));
            _list.Add(new Card(39, 4, false, "偵察員", VersionName.Int));
            _list.Add(new Card(40, 2, false, "手先", VersionName.Int));
            _list.Add(new Card(41, 4, false, "鉄工所", VersionName.Int));
            _list.Add(new Card(42, 4, false, "銅細工師", VersionName.Int));
            _list.Add(new Card(43, 2, false, "中庭", VersionName.Int));
            _list.Add(new Card(44, 3, false, "願いの井戸", VersionName.Int));
            _list.Add(new Card(45, 6, false, "ハーレム", VersionName.Int));
            _list.Add(new Card(46, 5, false, "破壊工作員", VersionName.Int));
            _list.Add(new Card(47, 4, false, "橋", VersionName.Int));
            _list.Add(new Card(48, 2, false, "秘密の部屋", VersionName.Int));
            _list.Add(new Card(49, 3, false, "貧民街", VersionName.Int));
            _list.Add(new Card(50, 5, false, "貢物", VersionName.Int));
        }

        public void AddSeasideCards() {
            _list.Add(new Card(51, 4, false, "海の妖婆", VersionName.Sea));
            _list.Add(new Card(52, 4, false, "海賊船", VersionName.Sea));
            _list.Add(new Card(53, 3, false, "漁村", VersionName.Sea));
            _list.Add(new Card(54, 4, false, "巾着切り", VersionName.Sea));
            _list.Add(new Card(55, 2, false, "原住民の村", VersionName.Sea));
            _list.Add(new Card(56, 4, false, "航海士", VersionName.Sea));
            _list.Add(new Card(57, 5, false, "策士", VersionName.Sea));
            _list.Add(new Card(58, 4, false, "島", VersionName.Sea));
            _list.Add(new Card(59, 5, false, "商船", VersionName.Sea));
            _list.Add(new Card(60, 2, false, "真珠採り", VersionName.Sea));
            _list.Add(new Card(61, 5, false, "前哨地", VersionName.Sea));
            _list.Add(new Card(62, 3, false, "倉庫", VersionName.Sea));
            _list.Add(new Card(63, 3, false, "大使", VersionName.Sea));
            _list.Add(new Card(64, 4, false, "隊商", VersionName.Sea));
            _list.Add(new Card(65, 4, false, "宝の地図", VersionName.Sea));
            _list.Add(new Card(66, 5, false, "探検家", VersionName.Sea));
            _list.Add(new Card(67, 2, false, "停泊所", VersionName.Sea));
            _list.Add(new Card(68, 2, false, "灯台", VersionName.Sea));
            _list.Add(new Card(69, 5, false, "バザー", VersionName.Sea));
            _list.Add(new Card(70, 4, false, "引揚水夫", VersionName.Sea));
            _list.Add(new Card(71, 5, false, "船着場", VersionName.Sea));
            _list.Add(new Card(72, 5, false, "宝物庫", VersionName.Sea));
            _list.Add(new Card(73, 3, false, "密輸人", VersionName.Sea));
            _list.Add(new Card(74, 3, false, "見張り", VersionName.Sea));
            _list.Add(new Card(75, 5, false, "幽霊船", VersionName.Sea));
            _list.Add(new Card(76, 2, false, "抑留", VersionName.Sea));
        }

        public void AddProsperityCards() {
            _list.Add(new Card(77, 4, false, "石切り場", VersionName.Pro));
            _list.Add(new Card(78, 6, false, "大市場", VersionName.Pro));
            _list.Add(new Card(79, 5, false, "会計所", VersionName.Pro));
            _list.Add(new Card(80, 6, false, "隠し財産", VersionName.Pro));
            _list.Add(new Card(81, 7, false, "拡張", VersionName.Pro));
            _list.Add(new Card(82, 4, false, "記念碑", VersionName.Pro));
            _list.Add(new Card(83, 7, false, "宮廷", VersionName.Pro));
            _list.Add(new Card(84, 8, false, "行商人", VersionName.Pro));
            _list.Add(new Card(85, 5, false, "玉璽", VersionName.Pro));
            _list.Add(new Card(86, 7, false, "銀行", VersionName.Pro));
            _list.Add(new Card(87, 5, false, "禁制品", VersionName.Pro));
            _list.Add(new Card(88, 3, false, "交易路", VersionName.Pro));
            _list.Add(new Card(89, 4, false, "護符", VersionName.Pro));
            _list.Add(new Card(90, 4, false, "司教", VersionName.Pro));
            _list.Add(new Card(91, 3, false, "借金", VersionName.Pro));
            _list.Add(new Card(92, 5, false, "造幣所", VersionName.Pro));
            _list.Add(new Card(93, 5, false, "大衆", VersionName.Pro));
            _list.Add(new Card(94, 7, false, "鍛造", VersionName.Pro));
            _list.Add(new Card(95, 5, false, "投機", VersionName.Pro));
            _list.Add(new Card(96, 5, false, "都市", VersionName.Pro));
            _list.Add(new Card(97, 6, false, "ならず者", VersionName.Pro));
            _list.Add(new Card(98, 3, false, "望楼", VersionName.Pro));
            _list.Add(new Card(99, 5, false, "保管庫", VersionName.Pro));
            _list.Add(new Card(100, 5, false, "香具師", VersionName.Pro));
            _list.Add(new Card(101, 4, false, "労働者の村", VersionName.Pro));
        }

        public void AddHarvestCards() {
            _list.Add(new Card(102, 3, false, "移動動物園", VersionName.Har));
            _list.Add(new Card(103, 4, false, "馬商人", VersionName.Har));
            _list.Add(new Card(104, 3, false, "占い師", VersionName.Har));
            _list.Add(new Card(105, 4, false, "再建", VersionName.Har));
            _list.Add(new Card(106, 5, false, "収穫", VersionName.Har));
            _list.Add(new Card(107, 5, false, "狩猟団", VersionName.Har));
            _list.Add(new Card(108, 2, false, "村落", VersionName.Har));
            _list.Add(new Card(109, 5, false, "道化師", VersionName.Har));
            _list.Add(new Card(110, 4, false, "農村", VersionName.Har));
            _list.Add(new Card(111, 4, false, "馬上槍試合", VersionName.Har));
            _list.Add(new Card(112, 6, false, "品評会", VersionName.Har));
            _list.Add(new Card(113, 5, false, "豊穣の角笛", VersionName.Har));
            _list.Add(new Card(114, 4, false, "魔女娘", VersionName.Har));
        }

        public void AddForeignCards() {
            _list.Add(new Card(115, 3, false, "オアシス", VersionName.For));
            _list.Add(new Card(116, 5, false, "街道", VersionName.For));
            _list.Add(new Card(117, 3, false, "開発", VersionName.For));
            _list.Add(new Card(118, 3, false, "画策", VersionName.For));
            _list.Add(new Card(119, 5, false, "官吏", VersionName.For));
            _list.Add(new Card(120, 4, false, "義賊", VersionName.For));
            _list.Add(new Card(121, 5, false, "厩舎", VersionName.For));
            _list.Add(new Card(122, 2, false, "岐路", VersionName.For));
            _list.Add(new Card(123, 2, false, "愚者の黄金", VersionName.For));
            _list.Add(new Card(124, 4, false, "交易人", VersionName.For));
            _list.Add(new Card(125, 2, false, "公爵夫人", VersionName.For));
            _list.Add(new Card(126, 4, false, "香辛料商人", VersionName.For));
            _list.Add(new Card(127, 3, false, "坑道", VersionName.For));
            _list.Add(new Card(128, 6, false, "国境の村", VersionName.For));
            _list.Add(new Card(129, 4, false, "シルクロード", VersionName.For));
            _list.Add(new Card(130, 3, false, "信託", VersionName.For));
            _list.Add(new Card(131, 5, false, "大使館", VersionName.For));
            _list.Add(new Card(132, 5, false, "地図職人", VersionName.For));
            _list.Add(new Card(133, 5, false, "値切り屋", VersionName.For));
            _list.Add(new Card(134, 6, false, "農地", VersionName.For));
            _list.Add(new Card(135, 5, false, "不正利得", VersionName.For));
            _list.Add(new Card(136, 5, false, "辺境伯", VersionName.For));
            _list.Add(new Card(137, 5, false, "埋蔵金", VersionName.For));
            _list.Add(new Card(138, 5, false, "宿屋", VersionName.For));
            _list.Add(new Card(139, 4, false, "遊牧民の野営地", VersionName.For));
            _list.Add(new Card(140, 4, false, "よろずや", VersionName.For));
        }

        public void AddArchemyCards() {
            _list.Add(new Card(141, 2, true, "薬師", VersionName.Alc));
            _list.Add(new Card(142, 3, true, "賢者の石", VersionName.Alc));
            _list.Add(new Card(143, 4, true, "ゴーレム", VersionName.Alc));
            _list.Add(new Card(144, 6, true, "支配", VersionName.Alc));
            _list.Add(new Card(145, 2, true, "大学", VersionName.Alc));
            _list.Add(new Card(146, 3, true, "使い魔", VersionName.Alc));
            _list.Add(new Card(147, 5, false, "弟子", VersionName.Alc));
            _list.Add(new Card(148, 2, true, "念視の泉", VersionName.Alc));
            _list.Add(new Card(149, 0, true, "ブドウ園", VersionName.Alc));
            _list.Add(new Card(150, 0, true, "変成", VersionName.Alc));
            _list.Add(new Card(151, 2, false, "薬草商", VersionName.Alc));
            _list.Add(new Card(152, 3, true, "錬金術師", VersionName.Alc));
        }

        public Card GetCard(int num) {
            return _list[num];
        }

        public void Flush() {
            _list.Clear();
        }
    }
}
