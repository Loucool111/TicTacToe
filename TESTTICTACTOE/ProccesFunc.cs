using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TicTacToe_LB
{
    public class ProccesFunc
    {
        public static string reset(Label lblPlayerActuel)
        {
            foreach (var labtab in frmTicTacToe.labelArray)
            {
                labtab.Text = "";
                labtab.Visible = true;
            }

            frmTicTacToe.player = 1;

            lblPlayerActuel.Text = string.Format("{0} !\nc'est ton tour !", frmTicTacToe.playerName1);

            ResetTabs();

            frmTicTacToe.estDernierClickPourVictoire = false;

            return lblPlayerActuel.Text;
        }

        public static void ResetTabs()
        {
            for (int i = 0; i < frmTicTacToe.CasePlayer2.Length; i++)
            {
                frmTicTacToe.CasePlayer2[i] = false;
                frmTicTacToe.CasePlayer1[i] = false;
                frmTicTacToe.TabPourMatchNul[i] = false;
                frmTicTacToe.CaseNonActive[i] = false;
            }
        }

        public static bool CheckVictoire(bool[] bArray)
        {
            bool winn = false;

            if (bArray[0] && bArray[1] && bArray[2])
            {
                winn = true;
                frmTicTacToe.CaseNonActive[0] = true;
                frmTicTacToe.CaseNonActive[1] = true;
                frmTicTacToe.CaseNonActive[2] = true;
            }
            if (bArray[3] && bArray[4] && bArray[5])
            {
                winn = true;
                frmTicTacToe.CaseNonActive[3] = true;
                frmTicTacToe.CaseNonActive[4] = true;
                frmTicTacToe.CaseNonActive[5] = true;
            }
            if (bArray[6] && bArray[7] && bArray[8])
            {
                winn = true;
                frmTicTacToe.CaseNonActive[6] = true;
                frmTicTacToe.CaseNonActive[7] = true;
                frmTicTacToe.CaseNonActive[8] = true;
            }
            if (bArray[0] && bArray[3] && bArray[6])
            {
                winn = true;
                frmTicTacToe.CaseNonActive[0] = true;
                frmTicTacToe.CaseNonActive[3] = true;
                frmTicTacToe.CaseNonActive[6] = true;
            }
            if (bArray[1] && bArray[4] && bArray[7])
            {
                winn = true;
                frmTicTacToe.CaseNonActive[1] = true;
                frmTicTacToe.CaseNonActive[4] = true;
                frmTicTacToe.CaseNonActive[7] = true;
            }
            if (bArray[2] && bArray[5] && bArray[8])
            {
                winn = true;
                frmTicTacToe.CaseNonActive[2] = true;
                frmTicTacToe.CaseNonActive[5] = true;
                frmTicTacToe.CaseNonActive[8] = true;
            }
            if (bArray[0] && bArray[4] && bArray[8])
            {
                winn = true;
                frmTicTacToe.CaseNonActive[0] = true;
                frmTicTacToe.CaseNonActive[4] = true;
                frmTicTacToe.CaseNonActive[8] = true;
            }
            if (bArray[2] && bArray[4] && bArray[6])
            {
                winn = true;
                frmTicTacToe.CaseNonActive[2] = true;
                frmTicTacToe.CaseNonActive[4] = true;
                frmTicTacToe.CaseNonActive[6] = true;
            }

            if (winn)
            {
                MontrerCombinaisonVictoire(frmTicTacToe.CaseNonActive);
                frmTicTacToe.estDernierClickPourVictoire = true;
            }
            if (!winn)
            {
                frmTicTacToe.estDernierClickPourVictoire = false;
            }

            return winn;
        }

        public static void MontrerCombinaisonVictoire(bool[] MyTab)
        {
            for (int i = 0; i < frmTicTacToe.CaseNonActive.Length; i++)
            {
                if (!MyTab[i])
                {
                    frmTicTacToe.labelArray[i].Visible = false;
                }
            }
        }

        public static string ProccesVictoire(bool player1vict, bool player2vict, Label lblPlayerActuel)
        {
            if (player1vict)
                if (MessageBox.Show(string.Format("{0} à Gagné !!\nVoulez vous rejouer ? ", frmTicTacToe.playerName1), "Victoire", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    frmTicTacToe.ScorePlayer1++;
                    lblPlayerActuel.Text = reset(lblPlayerActuel);
                    frmTicTacToe.estDernierClickPourVictoire = true;
                }
                else
                    Application.Exit();
            if (player2vict)
                if (frmTicTacToe.Ordinateur)
                {
                    if (MessageBox.Show("L'Ordinateur à Gagné !!\nVoulez vous rejouer ?", "Victoire", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        frmTicTacToe.ScorePlayer2++;
                        lblPlayerActuel.Text = reset(lblPlayerActuel);
                        frmTicTacToe.estDernierClickPourVictoire = true;
                    }
                    else
                        Application.Exit();
                }
                else
                {
                    if (MessageBox.Show(string.Format("{0} à Gagné !!\nVoulez vous rejouer ? ", frmTicTacToe.playerName2), "Victoire", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        frmTicTacToe.ScorePlayer2++;
                        lblPlayerActuel.Text = reset(lblPlayerActuel);
                        frmTicTacToe.estDernierClickPourVictoire = true;
                    }
                    else
                        Application.Exit();
                }
            return lblPlayerActuel.Text;
        }

        public static string UpdateJoueurLabel(Label lblPlayerActuel)
        {

            if (frmTicTacToe.player == 1)
                lblPlayerActuel.Text = string.Format("{0} !\nc'est ton tour !", frmTicTacToe.playerName1);
            else
            {
                if (frmTicTacToe.Ordinateur)
                    lblPlayerActuel.Text = "Ordinateur Joue...";
                else
                    lblPlayerActuel.Text = string.Format("{0} !\nc'est ton tour !", frmTicTacToe.playerName2);
            }
            return lblPlayerActuel.Text;
        }

        public static string CheckMatchNul(Label lblPlayerActuel)
        {
            int nombredefull = 0;

            foreach (var caseMatchNul in frmTicTacToe.TabPourMatchNul)
            {
                if (caseMatchNul)
                {
                    nombredefull++;

                    if (nombredefull == 9)
                    {
                        if (MessageBox.Show("Match nul !\nVoulez-vous rejouer ?", "Rejouer ?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                        {
                            lblPlayerActuel.Text = reset(lblPlayerActuel);
                            frmTicTacToe.estDernierClickPourVictoire = true;
                            frmTicTacToe.nbMatchNul++;
                            nombredefull = 0;
                        }
                        else
                            Application.Exit();
                    }
                }
            }
            return lblPlayerActuel.Text;
        }

        public static void ChangerJoueur()
        {
            if (frmTicTacToe.player == 1)
                frmTicTacToe.player = 2;
            else
                frmTicTacToe.player = 1;
        }

        public static void refreshCases()
        {
            for ( int i = 0; i < frmTicTacToe.labelArray.Length; i++)
            {
                if (frmTicTacToe.CasePlayer1[i])
                {
                    frmTicTacToe.labelArray[i].Text = frmTicTacToe.LETTRE_JOUEUR_1;
                }
                if (frmTicTacToe.CasePlayer2[i])
                {
                    frmTicTacToe.labelArray[i].Text = frmTicTacToe.LETTRE_JOUEUR_2;
                }
            }
        }
    }
}
