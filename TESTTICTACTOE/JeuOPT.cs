using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TicTacToe_LB
{
    public class JeuOPT : Form
    {
        #region init components


        protected void InitializeComponent()
        {
            this.lblInfoP1 = new System.Windows.Forms.Label();
            this.lblInfoP2 = new System.Windows.Forms.Label();
            this.tbxJoueur1 = new System.Windows.Forms.TextBox();
            this.tbxJoueur2 = new System.Windows.Forms.TextBox();
            this.btnApliquer = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxChar1 = new System.Windows.Forms.TextBox();
            this.tbxChar2 = new System.Windows.Forms.TextBox();
            this.gbxOptions = new System.Windows.Forms.GroupBox();
            this.lblSecondes = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.OptionsAvances = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gbxOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.OptionsAvances.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInfoP1
            // 
            this.lblInfoP1.AutoSize = true;
            this.lblInfoP1.Location = new System.Drawing.Point(17, 26);
            this.lblInfoP1.Name = "lblInfoP1";
            this.lblInfoP1.Size = new System.Drawing.Size(94, 13);
            this.lblInfoP1.TabIndex = 1;
            this.lblInfoP1.Text = "Nom du Joueur 1 :";
            // 
            // lblInfoP2
            // 
            this.lblInfoP2.AutoSize = true;
            this.lblInfoP2.Location = new System.Drawing.Point(17, 51);
            this.lblInfoP2.Name = "lblInfoP2";
            this.lblInfoP2.Size = new System.Drawing.Size(94, 13);
            this.lblInfoP2.TabIndex = 2;
            this.lblInfoP2.Text = "Nom du Joueur 2 :";
            // 
            // tbxJoueur1
            // 
            this.tbxJoueur1.Location = new System.Drawing.Point(117, 23);
            this.tbxJoueur1.Name = "tbxJoueur1";
            this.tbxJoueur1.Size = new System.Drawing.Size(100, 20);
            this.tbxJoueur1.TabIndex = 0;
            this.tbxJoueur1.TextChanged += new System.EventHandler(this.reEnableBTNAppliquer);
            // 
            // tbxJoueur2
            // 
            this.tbxJoueur2.Location = new System.Drawing.Point(117, 51);
            this.tbxJoueur2.Name = "tbxJoueur2";
            this.tbxJoueur2.Size = new System.Drawing.Size(100, 20);
            this.tbxJoueur2.TabIndex = 1;
            this.tbxJoueur2.TextChanged += new System.EventHandler(this.reEnableBTNAppliquer);
            // 
            // btnApliquer
            // 
            this.btnApliquer.Location = new System.Drawing.Point(183, 255);
            this.btnApliquer.Name = "btnApliquer";
            this.btnApliquer.Size = new System.Drawing.Size(75, 23);
            this.btnApliquer.TabIndex = 3;
            this.btnApliquer.Text = "Appliquer";
            this.btnApliquer.UseVisualStyleBackColor = true;
            this.btnApliquer.Click += new System.EventHandler(this.btnApliquer_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(94, 255);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 23);
            this.btnQuitter.TabIndex = 2;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(6, 255);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Symbloes des cases Joueur 1 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Symbloes des cases Joueur 2 :";
            // 
            // tbxChar1
            // 
            this.tbxChar1.Location = new System.Drawing.Point(176, 82);
            this.tbxChar1.Name = "tbxChar1";
            this.tbxChar1.Size = new System.Drawing.Size(41, 20);
            this.tbxChar1.TabIndex = 2;
            this.tbxChar1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxChar1.TextChanged += new System.EventHandler(this.tbxChar1_TextChanged);
            // 
            // tbxChar2
            // 
            this.tbxChar2.Location = new System.Drawing.Point(176, 104);
            this.tbxChar2.Name = "tbxChar2";
            this.tbxChar2.Size = new System.Drawing.Size(41, 20);
            this.tbxChar2.TabIndex = 3;
            this.tbxChar2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxChar2.TextChanged += new System.EventHandler(this.tbxChar2_TextChanged);
            // 
            // gbxOptions
            // 
            this.gbxOptions.Controls.Add(this.lblSecondes);
            this.gbxOptions.Controls.Add(this.trackBar1);
            this.gbxOptions.Controls.Add(this.lblInfoP1);
            this.gbxOptions.Controls.Add(this.tbxChar2);
            this.gbxOptions.Controls.Add(this.lblInfoP2);
            this.gbxOptions.Controls.Add(this.tbxChar1);
            this.gbxOptions.Controls.Add(this.tbxJoueur1);
            this.gbxOptions.Controls.Add(this.label2);
            this.gbxOptions.Controls.Add(this.tbxJoueur2);
            this.gbxOptions.Controls.Add(this.label1);
            this.gbxOptions.Location = new System.Drawing.Point(6, 6);
            this.gbxOptions.Name = "gbxOptions";
            this.gbxOptions.Size = new System.Drawing.Size(237, 209);
            this.gbxOptions.TabIndex = 0;
            this.gbxOptions.TabStop = false;
            this.gbxOptions.Text = "Options";
            // 
            // lblSecondes
            // 
            this.lblSecondes.AutoSize = true;
            this.lblSecondes.Location = new System.Drawing.Point(30, 178);
            this.lblSecondes.Name = "lblSecondes";
            this.lblSecondes.Size = new System.Drawing.Size(178, 13);
            this.lblSecondes.TabIndex = 13;
            this.lblSecondes.Text = "Temps de répose de l\'ordinateur : 1s";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(20, 130);
            this.trackBar1.Maximum = 20;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(197, 45);
            this.trackBar1.TabIndex = 4;
            this.trackBar1.TickFrequency = 2;
            this.trackBar1.Value = 10;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // OptionsAvances
            // 
            this.OptionsAvances.Controls.Add(this.tabPage1);
            this.OptionsAvances.Controls.Add(this.tabPage2);
            this.OptionsAvances.Location = new System.Drawing.Point(3, 2);
            this.OptionsAvances.Name = "OptionsAvances";
            this.OptionsAvances.SelectedIndex = 0;
            this.OptionsAvances.Size = new System.Drawing.Size(256, 246);
            this.OptionsAvances.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gbxOptions);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(248, 220);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Avancé";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(248, 220);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Autre";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // JeuOPT
            // 
            this.ClientSize = new System.Drawing.Size(262, 290);
            this.Controls.Add(this.OptionsAvances);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnApliquer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "JeuOPT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.JeuOPT_Load);
            this.gbxOptions.ResumeLayout(false);
            this.gbxOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.OptionsAvances.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        

        private Label lblInfoP1;
        private Label lblInfoP2;
        private TextBox tbxJoueur1;
        private TextBox tbxJoueur2;
        private Button btnApliquer;
        private Button btnQuitter;
        private Label label1;
        private Label label2;
        private TextBox tbxChar1;
        private TextBox tbxChar2;
        private GroupBox gbxOptions;
        private Label lblSecondes;
        private TrackBar trackBar1;
        private TabControl OptionsAvances;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button btnOK;

        public JeuOPT()
        {
            InitializeComponent();
            this.Text = "Options Avancés";
        }

        #endregion

        protected bool isSaved = false;
       
        private void JeuOPT_Load(object sender, EventArgs e)
        {
            if (frmTicTacToe.Ordinateur)
            {
                tbxJoueur1.Text = frmTicTacToe.playerName1;
                tbxJoueur2.Text = "Ordinateur";
                tbxJoueur2.Enabled = false;
            }
            else
            {
                tbxJoueur1.Text = frmTicTacToe.playerName1;
                tbxJoueur2.Text = frmTicTacToe.playerName2;
            }

            tbxChar1.Text = frmTicTacToe.LETTRE_JOUEUR_1;
            tbxChar2.Text = frmTicTacToe.LETTRE_JOUEUR_2;

            trackBar1.Value = frmTicTacToe.INTERVAL_TOUR_AI / 100;

            isSaved = true;
        }

        private void tbxChar1_TextChanged(object sender, EventArgs e)
        {
            replaceCharLast(tbxChar1);
        }

        private void tbxChar2_TextChanged(object sender, EventArgs e)
        {
            replaceCharLast(tbxChar2);
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            if (!isSaved)
            {
                if (MessageBox.Show("Voulez-vous vraiment quitter sans sauvegarder ?", "Quitter", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    this.Close();
            }
            else
                this.Close();
        }

        private void btnApliquer_Click(object sender, EventArgs e)
        {
            btnApliquer.Enabled = false;

            if (tbxChar1.Text.Length > 1 || tbxChar2.Text.Length > 1)
            {
                MessageBox.Show("Un seul caractère accepté pour les symboles", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            save();
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            btnApliquer.Enabled = true;
            double secondes = (double)trackBar1.Value / 10;
            lblSecondes.Text = string.Format("Temps de répose de l'ordinateur : {0}s", secondes);
            isSaved = false;
        }

        private void reEnableBTNAppliquer(object sender, EventArgs e)
        {
            btnApliquer.Enabled = true;
            isSaved = false;
        }

        public void save()
        {
            frmTicTacToe.playerName1 = tbxJoueur1.Text;
            frmTicTacToe.playerName2 = tbxJoueur2.Text;

            frmTicTacToe.LETTRE_JOUEUR_1 = tbxChar1.Text;
            frmTicTacToe.LETTRE_JOUEUR_2 = tbxChar2.Text;

            if (trackBar1.Value * 100 > 1)
                frmTicTacToe.INTERVAL_TOUR_AI = trackBar1.Value * 100;
            else
                frmTicTacToe.INTERVAL_TOUR_AI = 1;
                

            isSaved = true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (tbxChar1.Text.Length > 1 || tbxChar2.Text.Length > 1)
            {
                MessageBox.Show("Un seul caractère accepté pour les symboles", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            save();
            this.Close();
        }

        private void replaceCharLast(TextBox obj)
        {
            if (obj.Text.Length > 1)
            {
                obj.SelectAll();
                MessageBox.Show("Un seul carractère accepté.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                char firstChar = obj.GetCharFromPosition(new System.Drawing.Point(0,0));
                obj.Clear();
                obj.Text = firstChar.ToString();
                obj.Select();
            }
            else if (obj.Text == "")
            {
                //MessageBox.Show("Un seul carractère accepté.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            btnApliquer.Enabled = true;
            isSaved = false;
        }
    }
}
