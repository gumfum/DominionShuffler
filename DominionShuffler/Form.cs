using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace DominionShuffler
{
    class DominionForm : Form
    {
        Shuffler shuffler = Shuffler.getInstance();
        List<string> useCardsList = new List<string>();
        List<Label> useCardsLabels = new List<Label>();

        GroupBox checkBoxesArea;
        GroupBox platinumRateArea;
        GroupBox useCardsArea;

        Button shuffleButton;

        CheckBox cbBasic;
        CheckBox cbIntrigue;
        CheckBox cbSeaside;
        CheckBox cbProsperity;
        CheckBox cbHervest;
        CheckBox cbForeign;
        CheckBox cbArchemy;

        CheckBox cbPlatinum;

        public DominionForm()
        {
            Text = "DominionShuffler ver2.0";
            Size = new Size(480, 360);
            
            checkBoxesArea = new GroupBox()
            {
                Text = "使用するセット",
                Location = new Point(20, 20),
                Size = new Size(150, 180)
            };

            platinumRateArea = new GroupBox()
            {
                Text = "白金、植民地",
                Location = new Point(20, 215),
                Size = new Size(150, 50)
            };

            useCardsArea = new GroupBox()
            {
                Text = "使用するカード",
                Location = new Point(200, 20),
                Size = new Size(250, 290),
            };

            shuffleButton = new Button()
            {
                Text = "Shuffle",
                Location = new Point(20, 280),
                Size = new Size(150, 30),
            };

            shuffleButton.Click += new EventHandler(Shuffle_Click);

            cbBasic = new CheckBox() 
            {
                Text = "基本",
                Location = new Point(20, 20),
            };

            cbIntrigue = new CheckBox()
            {
                Text = "陰謀",
                Location = new Point(20, 40),
            };

            cbSeaside = new CheckBox()
            {
                Text = "海辺",
                Location = new Point(20, 60),
            };

            cbProsperity = new CheckBox()
            {
                Text = "繁栄",
                Location = new Point(20, 80),
            };

            cbHervest = new CheckBox()
            {
                Text = "収穫祭",
                Location = new Point(20, 100),
            };

            cbForeign = new CheckBox()
            {
                Text = "異郷",
                Location = new Point(20, 120),
            };

            cbArchemy = new CheckBox()
            {
                Text = "錬金術",
                Location = new Point(20, 140),
            };

            cbPlatinum = new CheckBox()
            {
                Text = "使用しない",
                Location = new Point(20, 20),
            };

            checkBoxesArea.Controls.Add(cbBasic);
            checkBoxesArea.Controls.Add(cbIntrigue);
            checkBoxesArea.Controls.Add(cbSeaside);
            checkBoxesArea.Controls.Add(cbProsperity);
            checkBoxesArea.Controls.Add(cbHervest);
            checkBoxesArea.Controls.Add(cbForeign);
            checkBoxesArea.Controls.Add(cbArchemy);

            platinumRateArea.Controls.Add(cbPlatinum);

            this.Controls.Add(checkBoxesArea);
            this.Controls.Add(platinumRateArea);
            this.Controls.Add(useCardsArea);
            this.Controls.Add(shuffleButton);
        }

        void Shuffle_Click(object sender, EventArgs e) {
            int i = 0;

            useCardsList.Clear();
            useCardsLabels.Clear();
            useCardsArea.Controls.Clear();
            
            bool[] isSelectedSet = new bool[8];

            isSelectedSet[0] = cbBasic.Checked;
            isSelectedSet[1] = cbIntrigue.Checked;
            isSelectedSet[2] = cbSeaside.Checked;
            isSelectedSet[3] = cbProsperity.Checked;
            isSelectedSet[4] = cbHervest.Checked;
            isSelectedSet[5] = cbForeign.Checked;
            isSelectedSet[6] = cbArchemy.Checked;
            isSelectedSet[7] = cbPlatinum.Checked;

            useCardsList = shuffler.shuffle(isSelectedSet);

            foreach (string str in useCardsList) {
                Label label = new Label();
                label.Text = str;
                label.Location= new Point(20, 5 + 16 * (i + 1));
                label.Size = new Size(200, 16);
                ++i;

                useCardsArea.Controls.Add(label);
            }

        }
    }
}
