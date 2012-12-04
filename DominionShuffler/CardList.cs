using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DominionShuffler {
    class CardList {
        List<Card> list = new List<Card>();

        private static CardList cardList = new CardList();

        private CardList() {
            
        }

        public static CardList getInstance() {
            return cardList;
        }

        public int Length {
            get { return list.Count; }
        }
    
        public void AddBasicCards() {
            list.Add(new Card(1, 5, false, "市場", VersionName.BASIC));
            list.Add(new Card(2, 4, false, "改築", VersionName.BASIC));
            list.Add(new Card(3, 4, false, "鍛冶屋", VersionName.BASIC));
            list.Add(new Card(4, 4, false, "金貸し", VersionName.BASIC));
            list.Add(new Card(5, 3, false, "木こり", VersionName.BASIC));
            list.Add(new Card(6, 5, false, "議事堂", VersionName.BASIC));
            list.Add(new Card(7, 4, false, "玉座の間", VersionName.BASIC));
            list.Add(new Card(8, 5, false, "研究所", VersionName.BASIC));
            list.Add(new Card(9, 5, false, "鉱山", VersionName.BASIC));
            list.Add(new Card(10, 3, false, "工房", VersionName.BASIC));
            list.Add(new Card(11, 3, false, "宰相", VersionName.BASIC));
            list.Add(new Card(12, 4, false, "祝宴", VersionName.BASIC));
            list.Add(new Card(13, 5, false, "祝祭", VersionName.BASIC));
            list.Add(new Card(14, 5, false, "書庫", VersionName.BASIC));
            list.Add(new Card(15, 2, false, "地下貯蔵庫", VersionName.BASIC));
            list.Add(new Card(16, 4, false, "庭園", VersionName.BASIC));
            list.Add(new Card(17, 4, false, "泥棒", VersionName.BASIC));
            list.Add(new Card(18, 6, false, "冒険者", VersionName.BASIC));
            list.Add(new Card(19, 2, false, "堀", VersionName.BASIC));
            list.Add(new Card(20, 5, false, "魔女", VersionName.BASIC));
            list.Add(new Card(21, 4, false, "密偵", VersionName.BASIC));
            list.Add(new Card(22, 4, false, "民兵", VersionName.BASIC));
            list.Add(new Card(23, 3, false, "村", VersionName.BASIC));
            list.Add(new Card(24, 4, false, "役人", VersionName.BASIC));
            list.Add(new Card(25, 2, false, "礼拝堂", VersionName.BASIC));
        }

        public void AddIntrigueCards() {
            list.Add(new Card(26, 3, false, "大広間", VersionName.INTRIGUE));
            list.Add(new Card(27, 5, false, "改良", VersionName.INTRIGUE));
            list.Add(new Card(28, 3, false, "仮面舞踏会", VersionName.INTRIGUE));
            list.Add(new Card(29, 6, false, "貴族", VersionName.INTRIGUE));
            list.Add(new Card(30, 4, false, "共謀者", VersionName.INTRIGUE));
            list.Add(new Card(31, 5, false, "交易場", VersionName.INTRIGUE));
            list.Add(new Card(32, 4, false, "鉱山の村", VersionName.INTRIGUE));
            list.Add(new Card(33, 5, false, "公爵", VersionName.INTRIGUE));
            list.Add(new Card(34, 5, false, "拷問人", VersionName.INTRIGUE));
            list.Add(new Card(35, 3, false, "詐欺師", VersionName.INTRIGUE));
            list.Add(new Card(36, 3, false, "執事", VersionName.INTRIGUE));
            list.Add(new Card(37, 4, false, "男爵", VersionName.INTRIGUE));
            list.Add(new Card(38, 5, false, "寵臣", VersionName.INTRIGUE));
            list.Add(new Card(39, 4, false, "偵察員", VersionName.INTRIGUE));
            list.Add(new Card(40, 2, false, "手先", VersionName.INTRIGUE));
            list.Add(new Card(41, 4, false, "鉄工所", VersionName.INTRIGUE));
            list.Add(new Card(42, 4, false, "銅細工師", VersionName.INTRIGUE));
            list.Add(new Card(43, 2, false, "中庭", VersionName.INTRIGUE));
            list.Add(new Card(44, 3, false, "願いの井戸", VersionName.INTRIGUE));
            list.Add(new Card(45, 6, false, "ハーレム", VersionName.INTRIGUE));
            list.Add(new Card(46, 5, false, "破壊工作員", VersionName.INTRIGUE));
            list.Add(new Card(47, 4, false, "橋", VersionName.INTRIGUE));
            list.Add(new Card(48, 2, false, "秘密の部屋", VersionName.INTRIGUE));
            list.Add(new Card(49, 3, false, "貧民街", VersionName.INTRIGUE));
            list.Add(new Card(50, 5, false, "貢物", VersionName.INTRIGUE));
        }

        public void AddSeasideCards() {
            list.Add(new Card(51, 4, false, "海の妖婆", VersionName.SEASIDE));
            list.Add(new Card(52, 4, false, "海賊船", VersionName.SEASIDE));
            list.Add(new Card(53, 3, false, "漁村", VersionName.SEASIDE));
            list.Add(new Card(54, 4, false, "巾着切り", VersionName.SEASIDE));
            list.Add(new Card(55, 2, false, "原住民の村", VersionName.SEASIDE));
            list.Add(new Card(56, 4, false, "航海士", VersionName.SEASIDE));
            list.Add(new Card(57, 5, false, "策士", VersionName.SEASIDE));
            list.Add(new Card(58, 4, false, "島", VersionName.SEASIDE));
            list.Add(new Card(59, 5, false, "商船", VersionName.SEASIDE));
            list.Add(new Card(60, 2, false, "真珠採り", VersionName.SEASIDE));
            list.Add(new Card(61, 5, false, "前哨地", VersionName.SEASIDE));
            list.Add(new Card(62, 3, false, "倉庫", VersionName.SEASIDE));
            list.Add(new Card(63, 3, false, "大使", VersionName.SEASIDE));
            list.Add(new Card(64, 4, false, "隊商", VersionName.SEASIDE));
            list.Add(new Card(65, 4, false, "宝の地図", VersionName.SEASIDE));
            list.Add(new Card(66, 5, false, "探検家", VersionName.SEASIDE));
            list.Add(new Card(67, 2, false, "停泊所", VersionName.SEASIDE));
            list.Add(new Card(68, 2, false, "灯台", VersionName.SEASIDE));
            list.Add(new Card(69, 5, false, "バザー", VersionName.SEASIDE));
            list.Add(new Card(70, 4, false, "引揚水夫", VersionName.SEASIDE));
            list.Add(new Card(71, 5, false, "船着場", VersionName.SEASIDE));
            list.Add(new Card(72, 5, false, "宝物庫", VersionName.SEASIDE));
            list.Add(new Card(73, 3, false, "密輸人", VersionName.SEASIDE));
            list.Add(new Card(74, 3, false, "見張り", VersionName.SEASIDE));
            list.Add(new Card(75, 5, false, "幽霊船", VersionName.SEASIDE));
            list.Add(new Card(76, 2, false, "抑留", VersionName.SEASIDE));
        }

        public void AddProsperityCards() {
            list.Add(new Card(77, 4, false, "石切り場", VersionName.PROSPERITY));
            list.Add(new Card(78, 6, false, "大市場", VersionName.PROSPERITY));
            list.Add(new Card(79, 5, false, "会計所", VersionName.PROSPERITY));
            list.Add(new Card(80, 6, false, "隠し財産", VersionName.PROSPERITY));
            list.Add(new Card(81, 7, false, "拡張", VersionName.PROSPERITY));
            list.Add(new Card(82, 4, false, "記念碑", VersionName.PROSPERITY));
            list.Add(new Card(83, 7, false, "宮廷", VersionName.PROSPERITY));
            list.Add(new Card(84, 8, false, "行商人", VersionName.PROSPERITY));
            list.Add(new Card(85, 5, false, "玉璽", VersionName.PROSPERITY));
            list.Add(new Card(86, 7, false, "銀行", VersionName.PROSPERITY));
            list.Add(new Card(87, 5, false, "禁制品", VersionName.PROSPERITY));
            list.Add(new Card(88, 3, false, "交易路", VersionName.PROSPERITY));
            list.Add(new Card(89, 4, false, "護符", VersionName.PROSPERITY));
            list.Add(new Card(90, 4, false, "司教", VersionName.PROSPERITY));
            list.Add(new Card(91, 3, false, "借金", VersionName.PROSPERITY));
            list.Add(new Card(92, 5, false, "造幣所", VersionName.PROSPERITY));
            list.Add(new Card(93, 5, false, "大衆", VersionName.PROSPERITY));
            list.Add(new Card(94, 7, false, "鍛造", VersionName.PROSPERITY));
            list.Add(new Card(95, 5, false, "投機", VersionName.PROSPERITY));
            list.Add(new Card(96, 5, false, "都市", VersionName.PROSPERITY));
            list.Add(new Card(97, 6, false, "ならず者", VersionName.PROSPERITY));
            list.Add(new Card(98, 3, false, "望楼", VersionName.PROSPERITY));
            list.Add(new Card(99, 5, false, "保管庫", VersionName.PROSPERITY));
            list.Add(new Card(100, 5, false, "香具師", VersionName.PROSPERITY));
            list.Add(new Card(101, 4, false, "労働者の村", VersionName.PROSPERITY));
        }

        public void AddHarvestCards() {
            list.Add(new Card(102, 3, false, "移動動物園", VersionName.HARVEST));
            list.Add(new Card(103, 4, false, "馬商人", VersionName.HARVEST));
            list.Add(new Card(104, 3, false, "占い師", VersionName.HARVEST));
            list.Add(new Card(105, 4, false, "再建", VersionName.HARVEST));
            list.Add(new Card(106, 5, false, "収穫", VersionName.HARVEST));
            list.Add(new Card(107, 5, false, "狩猟団", VersionName.HARVEST));
            list.Add(new Card(108, 2, false, "村落", VersionName.HARVEST));
            list.Add(new Card(109, 5, false, "道化師", VersionName.HARVEST));
            list.Add(new Card(110, 4, false, "農村", VersionName.HARVEST));
            list.Add(new Card(111, 4, false, "馬上槍試合", VersionName.HARVEST));
            list.Add(new Card(112, 6, false, "品評会", VersionName.HARVEST));
            list.Add(new Card(113, 5, false, "豊穣の角笛", VersionName.HARVEST));
            list.Add(new Card(114, 4, false, "魔女娘", VersionName.HARVEST));
        }

        public void AddForeignCards() {
            list.Add(new Card(115, 3, false, "オアシス", VersionName.FOREIGN));
            list.Add(new Card(116, 5, false, "街道", VersionName.FOREIGN));
            list.Add(new Card(117, 3, false, "開発", VersionName.FOREIGN));
            list.Add(new Card(118, 3, false, "画策", VersionName.FOREIGN));
            list.Add(new Card(119, 5, false, "官吏", VersionName.FOREIGN));
            list.Add(new Card(120, 4, false, "義賊", VersionName.FOREIGN));
            list.Add(new Card(121, 5, false, "厩舎", VersionName.FOREIGN));
            list.Add(new Card(122, 2, false, "岐路", VersionName.FOREIGN));
            list.Add(new Card(123, 2, false, "愚者の黄金", VersionName.FOREIGN));
            list.Add(new Card(124, 4, false, "交易人", VersionName.FOREIGN));
            list.Add(new Card(125, 2, false, "公爵夫人", VersionName.FOREIGN));
            list.Add(new Card(126, 4, false, "香辛料商人", VersionName.FOREIGN));
            list.Add(new Card(127, 3, false, "坑道", VersionName.FOREIGN));
            list.Add(new Card(128, 6, false, "国境の村", VersionName.FOREIGN));
            list.Add(new Card(129, 4, false, "シルクロード", VersionName.FOREIGN));
            list.Add(new Card(130, 3, false, "信託", VersionName.FOREIGN));
            list.Add(new Card(131, 5, false, "大使館", VersionName.FOREIGN));
            list.Add(new Card(132, 5, false, "地図職人", VersionName.FOREIGN));
            list.Add(new Card(133, 5, false, "値切り屋", VersionName.FOREIGN));
            list.Add(new Card(134, 6, false, "農地", VersionName.FOREIGN));
            list.Add(new Card(135, 5, false, "不正利得", VersionName.FOREIGN));
            list.Add(new Card(136, 5, false, "辺境伯", VersionName.FOREIGN));
            list.Add(new Card(137, 5, false, "埋蔵金", VersionName.FOREIGN));
            list.Add(new Card(138, 5, false, "宿屋", VersionName.FOREIGN));
            list.Add(new Card(139, 4, false, "遊牧民の野営地", VersionName.FOREIGN));
            list.Add(new Card(140, 4, false, "よろずや", VersionName.FOREIGN));
        }

        public void AddArchemyCards() {
            list.Add(new Card(141, 2, true, "薬師", VersionName.ARCHEMY));
            list.Add(new Card(142, 3, true, "賢者の石", VersionName.ARCHEMY));
            list.Add(new Card(143, 4, true, "ゴーレム", VersionName.ARCHEMY));
            list.Add(new Card(144, 6, true, "支配", VersionName.ARCHEMY));
            list.Add(new Card(145, 2, true, "大学", VersionName.ARCHEMY));
            list.Add(new Card(146, 3, true, "使い魔", VersionName.ARCHEMY));
            list.Add(new Card(147, 5, false, "弟子", VersionName.ARCHEMY));
            list.Add(new Card(148, 2, true, "念視の泉", VersionName.ARCHEMY));
            list.Add(new Card(149, 0, true, "ブドウ園", VersionName.ARCHEMY));
            list.Add(new Card(150, 0, true, "変成", VersionName.ARCHEMY));
            list.Add(new Card(151, 2, false, "薬草商", VersionName.ARCHEMY));
            list.Add(new Card(152, 3, true, "錬金術師", VersionName.ARCHEMY));
        }

        public Card getCard(int num) {
            return list[num];
        }

        public void flush() {
            list.Clear();
        }
    }
}
