using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * 
 *  Singletonを利用したShuffler 
 * 
 */

namespace DominionShuffler
{
    class Shuffler
    {
        private static Shuffler shuffler = new Shuffler();
        private CardList cardList = CardList.getInstance();

        private List<string> useCards = new List<string>();
        private int[] useCardNumbers = new int[10];

        bool isYoungWitch, isPlatinum;
        int hazardCardNumber;

        Random rand = new Random();

        private Shuffler()
        {

        }

        public static Shuffler getInstance()
        {
            return shuffler;
        }

        public List<string> shuffle(bool[] b)
        {
            /*
             *  初期化
             */
            cardList.flush();
            useCards.Clear();

            for (int i = 0; i < 10; i++)
            {
                useCardNumbers[i] = 0;
            }

            isYoungWitch = false;
            isPlatinum = true;


            /*
             *  セットチョイス & 植民地
             */
            if (b[0])
                cardList.AddBasicCards();
            if (b[1])
                cardList.AddIntrigueCards();
            if (b[2])
                cardList.AddSeasideCards();
            if (b[3])
                cardList.AddProsperityCards();
            if (b[4])
                cardList.AddHarvestCards();
            if (b[5])
                cardList.AddForeignCards();
            if (b[6])
                cardList.AddArchemyCards();
            if (b[7])
                isPlatinum = false;


            /*
             *  リストが空の場合 
             */
            if (cardList.Length == 0) {
                useCards.Add("セットを選んでね!!!");
                return useCards;
            }


            /*
             *  カードチョイス
             */
            for (int i = 0; i < 10; i++) {
                useCardNumbers[i] = rand.Next(cardList.Length);

                for (int j = 0; j < i; j++) {
                    if (useCardNumbers[i] == useCardNumbers[j]) {
                        --i;
                        break;
                    }
                }

                if (cardList.getCard(useCardNumbers[i]).Name == "魔女娘") {
                    isYoungWitch = true;
                }
            }

            Array.Sort(useCardNumbers);

            for (int i = 0; i < 10; i++) {
                useCards.Add(cardList.getCard(useCardNumbers[i]).getCardInfo());
            }


            /*
             *  災いカードチョイス 
             */
            while (isYoungWitch) {
            choice:
                hazardCardNumber = rand.Next(cardList.Length);

                for (int i = 0; i < 10; i++) {
                    if (useCardNumbers[i] == hazardCardNumber || cardList.getCard(hazardCardNumber).Cost > 3 || cardList.getCard(hazardCardNumber).Portion) {
                        goto choice;
                    }
                }

                useCards.Add("");
                useCards.Add(cardList.getCard(hazardCardNumber).getCardInfo());

                isYoungWitch = false;
            }


            /*
             *  植民地チョイス 
             */
            if(isPlatinum) {
                if (rand.Next(100) < 20) {
                    isPlatinum = true;

                    useCards.Add("");
                    useCards.Add("*** - 繁栄 - 白金");
                    useCards.Add("*** - 繁栄 - 植民地");
                }
            }

            return useCards;
        }
    }
}
