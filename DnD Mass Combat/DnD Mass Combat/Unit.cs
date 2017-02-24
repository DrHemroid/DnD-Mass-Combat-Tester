using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnD_Mass_Combat {
    public partial class Unit : UserControl {
        public Unit() {
            InitializeComponent();
        }

        public void Reset() {
            BRMax.Value = 101;
            BRMax.Value = 100;
            morale.Value = 4;
            fightback.Checked = true;
        }

        public bool FightsBack {
            get { return fightback.Checked; }
            set { fightback.Checked = value; }
        }

        public int Morale {
            get { return Decimal.ToInt32(morale.Value); }
            set { if (value <= 10 && value >= -10) morale.Value = value; }
        }

        public int BattleRating {
            get { return Decimal.ToInt32(BR.Value); }
            set { if (value <= 9999 && value >= 0 && value <= BRMax.Value) BR.Value = value; }
        }

        public int BattleRatingMax {
            get { return Decimal.ToInt32(BRMax.Value); }
            set { if (value <= 9999 && value >= 0) BRMax.Value = value; }
        }

        public int BattleDamage {
            get { return Decimal.ToInt32(BD.Value); }
        }

        private void BattleRating_ValueChanged(object sender, EventArgs e) {
            if (BR.Value > BRMax.Value) {
                BR.Value = BRMax.Value;
            }
            BD.Value = BR.Value / 10;
        }

        private void BattleRatingMax_ValueChanged(object sender, EventArgs e) {
            BR.Value = BRMax.Value;
        }
    }
}
