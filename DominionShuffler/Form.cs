using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DominionShuffler {
    class DominionForm : Form {
        readonly Shuffler _shuffler;
        
        List<string> _useCardsList = new List<string>();
        List<string> _useExCardsList = new List<string>();

        readonly GroupBox _gbSets;
        readonly GroupBox _gbOptions;
        readonly GroupBox _gbCards;
        readonly GroupBox _gbExCards;

        readonly CheckBox _cbBas;
        readonly CheckBox _cbInt;
        readonly CheckBox _cbSea;
        readonly CheckBox _cbPro;
        readonly CheckBox _cbHer;
        readonly CheckBox _cbFor;
        readonly CheckBox _cbArc;
        readonly CheckBox _cbBla;

        readonly CheckBox _cbPlatinum;

        readonly Button _btShuffle;

        public DominionForm() {
            _shuffler = Shuffler.GetInstance();
            Text = "DominionShuffler ver2.0";
            Size = new Size(480, 400);
            
            _gbSets = new GroupBox {
                Text = "使用するセット",    
                Location = new Point(20, 20),
                Size = new Size(150, 185),    
            };

            _gbOptions = new GroupBox {
                Text = "オプション",
                Location = new Point(20, 215),
                Size = new Size(150, 50)
            };

            _gbCards = new GroupBox {
                Text = "使用するカード",
                Location = new Point(200, 20),
                Size = new Size(250, 185),
            };

            _gbExCards = new GroupBox {
                    Text = "追加するカード",
                    Location = new Point(200, 215),
                    Size = new Size(250, 135),
            };

            _btShuffle = new Button {
                Text = "GO!",
                Location = new Point(20, 280),
                Size = new Size(150, 30),
            };

            _btShuffle.Click += ShuffleClick;

            _cbBas = new CheckBox {
                Text = "基本",
                Location = new Point(20, 15),
            };

            _cbInt = new CheckBox {
                Text = "陰謀",
                Location = new Point(20, 35),
            };

            _cbSea = new CheckBox {
                Text = "海辺",
                Location = new Point(20, 55),
            };

            _cbPro = new CheckBox {
                Text = "繁栄",
                Location = new Point(20, 75),
            };

            _cbHer = new CheckBox {
                Text = "収穫祭",
                Location = new Point(20, 95),
            };

            _cbFor = new CheckBox {
                Text = "異郷",
                Location = new Point(20, 115),
            };

            _cbArc = new CheckBox {
                Text = "錬金術",
                Location = new Point(20, 135),
            };

            _cbBla = new CheckBox {
                Text = "暗黒時代",
                Location = new Point(20, 155),
            };

            _cbPlatinum = new CheckBox {
                Text = "使用しない",
                Location = new Point(20, 20),
            };

            _gbSets.Controls.Add(_cbBas);
            _gbSets.Controls.Add(_cbInt);
            _gbSets.Controls.Add(_cbSea);
            _gbSets.Controls.Add(_cbPro);
            _gbSets.Controls.Add(_cbHer);
            _gbSets.Controls.Add(_cbFor);
            _gbSets.Controls.Add(_cbArc);
            _gbSets.Controls.Add(_cbBla);

            _gbOptions.Controls.Add(_cbPlatinum);

            Controls.Add(_gbSets);
            Controls.Add(_gbOptions);
            Controls.Add(_gbCards);
            Controls.Add(_gbExCards);
            Controls.Add(_btShuffle);
        }

        public override sealed string Text {
            get { return base.Text; }
            set { base.Text = value; }
        }

        void ShuffleClick(object sender, EventArgs e) {
            var i = 0;

            _useCardsList.Clear();
            _gbCards.Controls.Clear();
            _gbExCards.Controls.Clear();
            
            var isSelectedSet = new bool[8];

            isSelectedSet[0] = _cbBas.Checked;
            isSelectedSet[1] = _cbInt.Checked;
            isSelectedSet[2] = _cbSea.Checked;
            isSelectedSet[3] = _cbPro.Checked;
            isSelectedSet[4] = _cbHer.Checked;
            isSelectedSet[5] = _cbFor.Checked;
            isSelectedSet[6] = _cbArc.Checked;
            isSelectedSet[7] = _cbBla.Checked;

            _useCardsList = _shuffler.GetCards(isSelectedSet);
            _useExCardsList = _shuffler.GetExCards();

            foreach (var str in _useCardsList) {
                var label = new Label {
                    Text = str,
                    Location = new Point(20, 4 + 16 * (i + 1)),
                    Size = new Size(200, 16)
                };
                ++i;

                _gbCards.Controls.Add(label);
            }

            foreach (var  str in _useExCardsList) {
                var label = new Label {
                        Text = str,
                        Location = new Point(20, 4 + 16 * (i - 10 + 1)),
                        Size = new Size(200, 16),
                };
                ++i;

                _gbExCards.Controls.Add(label);
            }
        }
    }
}
