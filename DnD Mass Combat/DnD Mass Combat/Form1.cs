using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnD_Mass_Combat {
    public partial class Form1 : Form {
        Random rnd;
        public Form1() {
            InitializeComponent();
            rnd = new Random();
            //Log(D20());
        }

        private void button1_Click(object sender, EventArgs e) {
            //A v B
            Attack(Unit1, Unit2);
            if (Unit2.FightsBack)
                Attack(Unit2, Unit1);
        }

        private void button2_Click(object sender, EventArgs e) {
            //B v A
            Attack(Unit2, Unit1);
            if (Unit2.FightsBack)
                Attack(Unit1, Unit2);
        }

        private void button3_Click(object sender, EventArgs e) {
            //C v B
            Attack(Unit3, Unit2);
            if (Unit2.FightsBack)
                Attack(Unit2, Unit3);
        }

        private void button4_Click(object sender, EventArgs e) {
            // B v C
            Attack(Unit2, Unit3);
            if (Unit3.FightsBack)
                Attack(Unit3, Unit2);
        }

        private void button5_Click(object sender, EventArgs e) {
            //A v C
            Attack(Unit1, Unit3);
            if (Unit3.FightsBack)
                Attack(Unit3, Unit1);
        }

        private void button6_Click(object sender, EventArgs e) {
            //C v A
            Attack(Unit3, Unit1);
            if (Unit1.FightsBack)
                Attack(Unit1, Unit3);
        }

        public void Attack(Unit attacker, Unit defender) {
            Log(attacker.Name + " is attacking " + defender.Name);
            int damage = defender.BattleRating;
            int a = attacker.Morale + D20();
            int d = defender.Morale + D20();
            int check = a - d;
            if(check >= 10) {
                defender.Morale--;
                defender.BattleRating -= attacker.BattleDamage * 2;
                Log("Attacker won by 10");
                Log("-1 Morale");
            } else if (check >= 5) {
                defender.BattleRating -= attacker.BattleDamage;
                Log("Attacker won by 5");
                if (D20() + defender.Morale < 16) {
                    defender.Morale--;
                    Log("-1 Morale");
                }
            } else if (check >= 0) {
                defender.BattleRating -= attacker.BattleDamage;
                Log("Attacker won/tied");
                if (D20() + defender.Morale < 14) {
                    defender.Morale--;
                    Log("-1 Morale");
                }
            } else if (check > -5) {
                defender.BattleRating -= attacker.BattleDamage / 2;
                Log("Attacker lost");
            } else if (check > -10) {
                Log("Attacker lost by 5");
                defender.BattleRating -= attacker.BattleDamage / 4;
            } else {
                defender.BattleRating -= attacker.BattleDamage / 4;
                Log("Attacker lost by 10");
                if (D20() + defender.Morale >= 14) {
                    defender.Morale++;
                    Log("+1 Morale");
                }
            }
            damage -= defender.BattleRating;
            Log(attacker.Name + " did " + damage.ToString() + " damage to " + defender.Name);
            Log("---------------------------------------------------------");
        }

        public int D20() {
            return rnd.Next(1, 20)+1;
        }

        public void Log(string l) {
            log.AppendText(l + "\r\n");
            log.ScrollToCaret();
        }

        public void Log(object l) {
            Log(l.ToString());
        }

        private void reset_Click(object sender, EventArgs e) {
            Unit1.Reset();
            Unit2.Reset();
            Unit3.Reset();
            log.Clear();
        }

        
    }
}
