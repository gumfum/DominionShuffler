using System;
using System.Collections.Generic;

namespace DominionShuffler {
    class Shuffler {
        private static readonly Shuffler shuffler = new Shuffler();
        private readonly CardList _cardList = CardList.GetInstance();

        readonly List<string> _useCards = new List<string>();
        readonly List<string> _useExCards = new List<string>(); 

        private int[] _useCardNumbers = new int[10];

        int _hazardCardNumber;

        readonly Random _rand = new Random();
        private bool _isProsperityEnvironment;
        private bool _isBlackAgeEnvironment;

        private Shuffler() {

        }

        public static Shuffler GetInstance() {
            return shuffler;
        }

        public List<string> GetCards(bool[] b) {
            _cardList.Flush();
            _useCards.Clear();
            _useExCards.Clear();

            _isProsperityEnvironment = false;
            _isBlackAgeEnvironment = false;

            for (var i = 0; i < 10; i++) {
                _useCardNumbers[i] = 0;
            }

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
            if (b[8])
                _cardList.AddGuildCards();

            if (_cardList.Length == 0) {
                _useCards.Add("セットを選んでね!!!");
                return _useCards;
            }

            for (var i = 0; i < 10; i++) {
                _useCardNumbers[i] = _rand.Next(_cardList.Length);

                for (var j = 0; j < i; j++) {
                    if (_useCardNumbers[i] == _useCardNumbers[j]) {
                        --i;
                        break;
                    }
                }
            }

            var v = _cardList.GetCard(_useCardNumbers[9]).Version;
            if (v == VersionName.Pro) {
                _isProsperityEnvironment = true;
            }
            if (v == VersionName.Bla) {
                _isBlackAgeEnvironment = true;
            }
            
            Array.Sort(_useCardNumbers);

            for (var i = 0; i < 10; i++) {
                _useCards.Add(_cardList.GetCard(_useCardNumbers[i]).GetCardInfo());
            }

            return _useCards;
        }

        public List<string> GetExCards() {
            if (_cardList.Length == 0) {
                return _useExCards;
            }

            if(_isProsperityEnvironment) {
                SetProsperityEnvironment();
            }

            if(_isBlackAgeEnvironment) {
                SetBlackAgeEnvironment();
            }
            
            for (var i = 0; i < 10; i++) {
                var name = _cardList.GetCard(_useCardNumbers[i]).Name;
                switch (name) {
                case "魔女娘":
                    SelectHarardCard();
                    break;
                case "隠遁者":
                    SetMadmanToEnvironment();
                    break;
                case "浮浪児":
                    SetMercenaryToEnvironment();
                    break;
                case "山賊の宿営地":
                case "略奪":
                    SetPillageToEnvironment();
                    break;
                case "死の荷車":
                    SetRuinsToEnvironment();
                    break;
                case "襲撃者":
                    SetPillageToEnvironment();
                    SetRuinsToEnvironment();
                    break;
                }
            }

            return _useExCards;
        }

        private bool SelectHarardCard() {
choice:
            _hazardCardNumber = _rand.Next(_cardList.Length);

            for(var i = 0; i < 10; i++) {
                if(_useCardNumbers[i] == _hazardCardNumber || _cardList.GetCard(_hazardCardNumber).Cost > 3 || _cardList.GetCard(_hazardCardNumber).Portion) {
                    goto choice;
                }
            }

            _useExCards.Add(_cardList.GetCard(_hazardCardNumber).GetCardInfo());
            return true;
        }

        private void SetProsperityEnvironment() {
            _useExCards.Add("*** - 繁栄 - 白金");
            _useExCards.Add("*** - 繁栄 - 植民地");
        }

        private void SetBlackAgeEnvironment() {
            _useExCards.Add("*** - 暗黒 - 避難所");
        }

        private void SetRuinsToEnvironment() {
            _useExCards.Add("*** - 暗黒 - 廃墟");
        }

        private void SetPillageToEnvironment() {
            _useExCards.Add("*** - 暗黒 - 略奪品");
        }

        private void SetMadmanToEnvironment() {
            _useExCards.Add("*** - 暗黒 - 狂人");
        }

        private void SetMercenaryToEnvironment() {
            _useExCards.Add("*** - 暗黒 - 傭兵");
        }
    }
}
