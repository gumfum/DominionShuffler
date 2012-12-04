using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace DominionShuffler {
    class DominionForm : Form {
        Shuffler shuffler = Shuffler.getInstance();
        List<string> useCardsList = new List<string>();
        List<Label> useCardsLabels = new List<Label>();

        GroupBox gbSets, gbOptions, gbCards;
        
        CheckBox cbBas, cbInt, cbSea, cbPro, cbHer, cbFor, cbArc, cbBla;

        CheckBox cbPlatinum;

        Button btShuffle;

        public DominionForm() {
            Text = "DominionShuffler ver2.0";
            Size = new Size(480, 360);
            
            gbSets = new GroupBox() {
                Text = "使用するセット",
                Location = new Point(20, 20),
                Size = new Size(150, 180)
            };

            gbOptions = new GroupBox() {
                Text = "オプション",
                Location = new Point(20, 215),
                Size = new Size(150, 50)
            };

            gbCards = new GroupBox() {
                Text = "使用するカード",
                Location = new Point(200, 20),
                Size = new Size(250, 290),
            };

            btShuffle = new Button() {
                Text = "Shuffle",
                Location = new Point(20, 280),
                Size = new Size(150, 30),
            };

            btShuffle.Click += new EventHandler(ShuffleClick);

            cbBas = new CheckBox() {
                Text = "基本",
                Location = new Point(20, 20),
            };

            cbInt = new CheckBox() {
                Text = "陰謀",
                Location = new Point(20, 40),
            };

            cbSea = new CheckBox() {
                Text = "海辺",
                Location = new Point(20, 60),
            };

            cbPro = new CheckBox() {
                Text = "繁栄",
                Location = new Point(20, 80),
            };

            cbHer = new CheckBox() {
                Text = "収穫祭",
                Location = new Point(20, 100),
            };

            cbFor = new CheckBox() {
                Text = "異郷",
                Location = new Point(20, 120),
            };

            cbArc = new CheckBox() {
                Text = "錬金術",
                Location = new Point(20, 140),
            };

            cbBla = new CheckBox() {
                Text = "暗黒時代",
                Location = new Point(20, 160),
            };

            cbPlatinum = new CheckBox() {
                Text = "使用しない",
                Location = new Point(20, 20),
            };

            gbSets.Controls.Add(cbBas);
            gbSets.Controls.Add(cbInt);
            gbSets.Controls.Add(cbSea);
            gbSets.Controls.Add(cbPro);
            gbSets.Controls.Add(cbHer);
            gbSets.Controls.Add(cbFor);
            gbSets.Controls.Add(cbArc);

            gbOptions.Controls.Add(cbPlatinum);

            this.Controls.Add(gbSets);
            this.Controls.Add(gbOptions);
            this.Controls.Add(gbCards);
            this.Controls.Add(btShuffle);
        }

        void ShuffleClick(object sender, EventArgs e) {
            int i = 0;

            useCardsList.Clear();
            useCardsLabels.Clear();
            gbCards.Controls.Clear();
            
            bool[] isSelectedSet = new bool[8];

            isSelectedSet[0] = cbBas.Checked;
            isSelectedSet[1] = cbInt.Checked;
            isSelectedSet[2] = cbSea.Checked;
            isSelectedSet[3] = cbPro.Checked;
            isSelectedSet[4] = cbHer.Checked;
            isSelectedSet[5] = cbFor.Checked;
            isSelectedSet[6] = cbArc.Checked;
            isSelectedSet[7] = cbPlatinum.Checked;

            useCardsList = shuffler.shuffle(isSelectedSet);

            foreach (string str in useCardsList) {
                Label label = new Label();
                label.Text = str;
                label.Location= new Point(20, 5 + 16 * (i + 1));
                label.Size = new Size(200, 16);
                ++i;

                gbCards.Controls.Add(label);
            }
        }
    }
}
