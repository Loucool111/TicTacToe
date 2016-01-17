using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TicTacToe_LB
{
    public partial class frmTicTacToe : Form
    {
        #region Initialisation des variables

        const string VERSION = "4";
        public static string LETTRE_JOUEUR_1 = "X";
        public static string LETTRE_JOUEUR_2 = "O";

        public static int INTERVAL_TOUR_AI = 1000;

        public static bool bWinX = false;
        public static bool bWinO = false;

        public static bool[] CasePlayer1 = new bool[9];
        public static bool[] CasePlayer2 = new bool[9];

        public static bool[] CaseNonActive = new bool[9];

        public static bool[] TabPourMatchNul = new bool[9];

        public static Label[] labelArray = new Label[9];

        public Random rand = new Random();

        public JeuOPT options = new JeuOPT();

        public Font resetFont = new Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        public Font resetFontCases = new Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

        public static bool estDernierClickPourVictoire = false;

        public static int player = 1; // player1 = 1 / player2 = 2

        public static int ScorePlayer1 = 0;
        public static int ScorePlayer2 = 0;

        public static int nbMatchNul = 0;

        public static string playerName1, playerName2;

        public static bool estMode2Joueur = false;

        public static bool Ordinateur = false;

        #endregion

        public frmTicTacToe()
        {
            InitializeComponent();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez vous vraiment quitter ?", "Quitter", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();
        }

        public void UpdateScoresLabel()
        {
            lblPointsPlayer1.Text = ScorePlayer1.ToString();
            lblPointsPlayer2.Text = ScorePlayer2.ToString();
            
            lblMatchNuls.Text = "Match Nuls : " + nbMatchNul;
        }
       
        public Color GetRandomColor()
        {
            Random _rand = new Random();
            var Color = Enum.GetValues(typeof (Color));
            return (Color)Color.GetValue(_rand.Next(Color.Length));
        }

        public void JeuOrdinateur()
        {
            TimerJeuOrdinateur.Interval = INTERVAL_TOUR_AI;
            ProccesFunc.refreshCases();
            refreshScoresNames();

            if (player != 1)
            {
                int CaseAIOrdinateur = AICase.getAICase(CasePlayer1, CasePlayer2);

                CasePlayer2[CaseAIOrdinateur] = true;
                TabPourMatchNul[CaseAIOrdinateur] = true;
                labelArray[CaseAIOrdinateur].Text = LETTRE_JOUEUR_2;

                bWinX = ProccesFunc.CheckVictoire(CasePlayer1);
                bWinO = ProccesFunc.CheckVictoire(CasePlayer2);

                if (!bWinX && !bWinO)
                    ProccesFunc.ChangerJoueur();

                lblPlayerActuel.Text = ProccesFunc.UpdateJoueurLabel(lblPlayerActuel);

                lblPlayerActuel.Text = ProccesFunc.ProccesVictoire(bWinX, bWinO, lblPlayerActuel);

                lblPlayerActuel.Text = ProccesFunc.CheckMatchNul(lblPlayerActuel);

                UpdateScoresLabel();
            }
        }

        public void ClickSurLabel(object sender, EventArgs e)
        {
            Label LabelTab = (Label)sender;

            String rawName = LabelTab.Name;
            String caseName = "";

            try
            {
                caseName = rawName.Substring(7);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
            int Case = Int32.Parse(caseName) - 1; //-1 car le numéro passé doit être de 1 de moin a cause du Array qui comment à 0.

            TimerJeuOrdinateur.Interval = INTERVAL_TOUR_AI;
            ProccesFunc.refreshCases();
            refreshScoresNames();

            if (!CasePlayer1[Case] && !CasePlayer2[Case])
            {
                UpdateScoresLabel();

                if (player == 1)
                {
                    CasePlayer1[Case] = true;
                    LabelTab.Text = LETTRE_JOUEUR_1;
                }
                else
                {
                    if (estMode2Joueur)
                    {
                        CasePlayer2[Case] = true;
                        LabelTab.Text = LETTRE_JOUEUR_2;
                    }
                    else
                        return;
                }

                bWinX = ProccesFunc.CheckVictoire(CasePlayer1);
                bWinO = ProccesFunc.CheckVictoire(CasePlayer2);

                if (!bWinX && !bWinO)
                    ProccesFunc.ChangerJoueur();

                lblPlayerActuel.Text = ProccesFunc.UpdateJoueurLabel(lblPlayerActuel);

                lblPlayerActuel.Text = ProccesFunc.ProccesVictoire(bWinX, bWinO, lblPlayerActuel);

                TabPourMatchNul[Case] = true;

                lblPlayerActuel.Text = ProccesFunc.CheckMatchNul(lblPlayerActuel);

                UpdateScoresLabel();

            }
        }

        private void frmTicTacToe_Load(object sender, EventArgs e)
        {
            labelArray[0] = lblCase1;
            labelArray[1] = lblCase2;
            labelArray[2] = lblCase3;
            labelArray[3] = lblCase4;
            labelArray[4] = lblCase5;
            labelArray[5] = lblCase6;
            labelArray[6] = lblCase7;
            labelArray[7] = lblCase8;
            labelArray[8] = lblCase9;

            lblPlayerActuel.Text = ProccesFunc.reset(lblPlayerActuel);

            this.Text = "Tic Tac Toe " + VERSION.ToString();

            TimerJeuOrdinateur.Interval = INTERVAL_TOUR_AI;
        }

        private void CommonLabelClickHandler(object sender, EventArgs e)
        {
            ClickSurLabel(sender, e);
            if (Ordinateur && !estDernierClickPourVictoire)
                TimerJeuOrdinateur.Start();
        }

        private void creditsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("Tic Tac Toe Version {0} !\nCréé par Luca Berret.", VERSION), "Crédits", MessageBoxButtons.OK);
        }

        private void resetTotalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblPlayerActuel.Text = ProccesFunc.reset(lblPlayerActuel);

            lblPointsPlayer1.Text = "0";
            lblPointsPlayer2.Text = "0";

            lblMatchNuls.Text = "Match Nuls : 0";

            foreach ( var lab in labelArray)
            {
                lab.BackColor = Color.FromKnownColor(KnownColor.ActiveBorder);
                lab.ForeColor = Color.Black;
            }

            this.BackColor = Color.FromKnownColor(KnownColor.ActiveBorder);
            menuJeu.BackColor = Color.FromKnownColor(KnownColor.ActiveBorder);
            gbxJeu.BackColor = Color.FromKnownColor(KnownColor.ActiveBorder);

            this.ForeColor = Color.Black;
            menuJeu.ForeColor = Color.Black;
            gbxInfos.ForeColor = Color.Black;
            gbxJeu.ForeColor = Color.Black;
            gbxScore.ForeColor = Color.Black;
        }

        private void resetGrilleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblPlayerActuel.Text = ProccesFunc.reset(lblPlayerActuel);
        }

        private void btnJouer_Click(object sender, EventArgs e)
        {
            bool toutEstOK = false;

            playerName1 = tbxNomPlayer1.Text;
            playerName2 = tbxNomPlayer2.Text;

            if (!cbxAIEnclenchee.Checked)
            {
                if (playerName1 == "" || playerName2 == "")              
                    MessageBox.Show("Veuillez entrez le nom des 2 joueurs", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);                
                else
                {
                    toutEstOK = true;
                    estMode2Joueur = true;
                }
            }
            else
            {
                if (playerName1 == "")                
                    MessageBox.Show("Veuillez entrez le nom du joueur 1", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);               
                else
                {
                    toutEstOK = true;
                    lblPlayer2.Text = "Ordinateur";
                    Ordinateur = true;
                }
            }

            if (toutEstOK)
            {
                lblPlayer1.Text = playerName1;
                if (!cbxAIEnclenchee.Checked)
                    lblPlayer2.Text = playerName2;

                PanelMenuPrincipal.Visible = false;
                PanelMenuPrincipal.Enabled = false;

            }
            toutEstOK = false;
            lblPlayerActuel.Text = ProccesFunc.reset(lblPlayerActuel);
        }

        private void refreshScoresNames()
        {
            lblPlayer1.Text = playerName1;
            if (!Ordinateur)
                lblPlayer2.Text = playerName2;
            else
                lblPlayer2.Text = "Ordinateur";
        }

        private void cbxAIEnclenchee_CheckedChanged(object sender, EventArgs e)
        {
            tbxNomPlayer2.Enabled = !tbxNomPlayer2.Enabled;
            lblInfoNom2.Enabled = !lblInfoNom2.Enabled;
            tbxNomPlayer2.Clear();
            if (cbxAIEnclenchee.Checked)
                tbxNomPlayer2.Text = "Ordinateur";
        }

        private void TimerJeuOrdinateur_Tick(object sender, EventArgs e)
        {
            TimerJeuOrdinateur.Stop();
            JeuOrdinateur();            
        }

        private void changerLaCouleurDuFondToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ColorDialogBack.ShowDialog() == DialogResult.OK)
            {
                Color lastColor = lblCase1.ForeColor;
                this.BackColor = ColorDialogBack.Color;
                menuJeu.BackColor = ColorDialogBack.Color;
                gbxJeu.BackColor = ColorDialogBack.Color;

                foreach (var lab in labelArray)
                {
                    lab.ForeColor = ColorDialogBack.Color;
                    lab.ForeColor = lastColor;
                }
            }

        }

        private void changerLaCouleurDuTexteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ColorDialogFore.ShowDialog() == DialogResult.OK)
            {
                Color lastColor = lblCase1.ForeColor;
                this.ForeColor = ColorDialogFore.Color;
                menuJeu.ForeColor = ColorDialogFore.Color;
                gbxInfos.ForeColor = ColorDialogFore.Color;
                gbxJeu.ForeColor = ColorDialogFore.Color;
                gbxScore.ForeColor = ColorDialogFore.Color;

                foreach (var lab in labelArray)
                {
                    lab.ForeColor = lastColor;
                }
            }
        }

        private void changezLaCouleurDesSymbolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SymbolColorDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (var lab in labelArray)
                {
                    lab.ForeColor = SymbolColorDialog.Color;
                }
            }
        }

        private void changezLaPoliceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOK = false;

            do
            {
                if (fontDialog1.ShowDialog() != DialogResult.Cancel)
                {
                    if (fontDialog1.Font.SizeInPoints < 14)
                    {
                        Font newFont = new Font(fontDialog1.Font.FontFamily, 72F, fontDialog1.Font.Style, fontDialog1.Font.Unit, fontDialog1.Font.GdiCharSet);
                        foreach (var lab in labelArray)
                        {
                            lab.Font = newFont;
                        }

                        lblInfoNom1.Font = fontDialog1.Font;
                        lblInfoNom2.Font = fontDialog1.Font;
                        lblMatchNuls.Font = fontDialog1.Font;
                        lblPlayer1.Font = fontDialog1.Font;
                        lblPlayer2.Font = fontDialog1.Font;
                        lblPlayerActuel.Font = fontDialog1.Font;
                        lblPointsPlayer1.Font = fontDialog1.Font;
                        lblPointsPlayer2.Font = fontDialog1.Font;
                        gbxInfos.Font = fontDialog1.Font;
                        gbxJeu.Font = fontDialog1.Font;
                        gbxScore.Font = fontDialog1.Font;
                        menuJeu.Font = fontDialog1.Font;
                        isOK = true;
                    }
                    else
                        MessageBox.Show("Veuillez choisir une taille raisonable\n(moin de 14)", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    isOK = true;
            }
            while (!isOK);
        }

        private void resetPoliceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach ( var tab in labelArray )
            {
                tab.Font = resetFontCases;
            }

            lblInfoNom1.Font = resetFont;
            lblInfoNom2.Font = resetFont;
            lblMatchNuls.Font = resetFont;
            lblPlayer1.Font = resetFont;
            lblPlayer2.Font = resetFont;
            lblPlayerActuel.Font = resetFont;
            lblPointsPlayer1.Font = resetFont;
            lblPointsPlayer2.Font = resetFont;
            gbxInfos.Font = resetFont;
            gbxJeu.Font = resetFont;
            gbxScore.Font = resetFont;
            menuJeu.Font = resetFont;
        }

        private void frmTicTacToe_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (MessageBox.Show("Voulez vous vraiment quitter ?","Quitter",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            //    Application.Exit();

            //DialogResult dr = MessageBox.Show("Voulez vous vraiment quitter ?", "Quitter", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //if (dr == DialogResult.Yes)
            //    ActiveForm.Close();
            //else
            //    return;
        }

        private void optionsAvancesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            options.ShowDialog();
            TimerJeuOrdinateur.Interval = INTERVAL_TOUR_AI;
            ProccesFunc.refreshCases();
            UpdateScoresLabel();
            refreshScoresNames();
        }
    }
}