using System;
using System.Collections.Generic;

namespace DominionShuffler {
    class Shuffler {
        private static readonly Shuffler shuffler = new Shuffler();
        private readonly CardList _cardList = CardList.GetInstance();

        private readonly List<string> _useCards = new List<string>();
        private readonly int[] _useCardNumbers = new int[10];

        bool _isYoungWitch, _isPlatinum;
        int _hazardCardNumber;

        readonly Random _rand = new Random();

        private Shuffler() {

        }

        public static Shuffler GetInstance() {
            return shuffler;
        }

        public List<string> Shuffle(bool[] b) {
            _cardList.Flush();
            _useCards.Clear();

            for (var i = 0; i < 10; i++) {
                _useCardNumbers[i] = 0;
            }

            _isYoungWitch = false;
            _isPlatinum = true;

            if (b[0])
                _cardList.AddBasicCards();
            if (b[1])
                _cardList.AddIntrigueCards();
            if (b[2])
                _cardList.AddSeasideCards();
            if (b[3])
                _cardList.AddProsperityCards();
            if (b[4])
                _cardList.AddHarvestCards();
            if (b[5])
                _cardList.AddForeignCards();
            if (b[6])
                _cardList.AddArchemyCards();
            if (b[7])
                _cardList.AddBrackageCards();

            if (_cardList.Length == 0) {
                _useCards.Add("セットを選んでね!!!");
                return _useCards;
            }

            for (int i = 0; i < 10; i++) {
                _useCardNumbers[i] = _rand.Next(_cardList.Length);

                for (int j = 0; j < i; j++) {
                    if (_useCardNumbers[i] == _useCardNumbers[j]) {
                        --i;
                        break;
                    }
                }

                if (_cardList.GetCard(_useCardNumbers[i]).Name == "魔女娘") {
                    _isYoungWitch = true;
                }
            }

            Array.Sort(_useCardNumbers);

            for (int i = 0; i < 10; i++) {
                _useCards.Add(_cardList.GetCard(_useCardNumbers[i]).GetCardInfo());
            }

            while (_isYoungWitch) {
            choice:
                _hazardCardNumber = _rand.Next(_cardList.Length);

                for (int i = 0; i < 10; i++) {
                    if (_useCardNumbers[i] == _hazardCardNumber || _cardList.GetCard(_hazardCardNumber).Cost > 3 || _cardList.GetCard(_hazardCardNumber).Portion) {
                        goto choice;
                    }
                }

                _useCards.Add("");
                _useCards.Add(_cardList.GetCard(_hazardCardNumber).GetCardInfo());

                _isYoungWitch = false;
            }

            if(_isPlatinum) {
                if (_rand.Next(100) < 20) {
                    _isPlatinum = true;

                    _useCards.Add("");
                    _useCards.Add("*** - 繁栄 - 白金");
                    _useCards.Add("*** - 繁栄 - 植民地");
                }
            }

            return _useCards;
        }
    }
}
