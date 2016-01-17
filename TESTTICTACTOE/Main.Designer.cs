namespace TicTacToe_LB
{
    partial class frmTicTacToe
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblCase1 = new System.Windows.Forms.Label();
            this.lblCase2 = new System.Windows.Forms.Label();
            this.lblCase3 = new System.Windows.Forms.Label();
            this.lblCase4 = new System.Windows.Forms.Label();
            this.lblCase5 = new System.Windows.Forms.Label();
            this.lblCase6 = new System.Windows.Forms.Label();
            this.lblCase7 = new System.Windows.Forms.Label();
            this.lblCase8 = new System.Windows.Forms.Label();
            this.lblCase9 = new System.Windows.Forms.Label();
            this.menuJeu = new System.Windows.Forms.MenuStrip();
            this.jeuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetGrilleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetTotalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetPoliceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changerLaCouleurDuFondToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changerLaCouleurDuTexteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changezLaCouleurDesSymbolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changezLaPoliceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsAvancésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblPlayerActuel = new System.Windows.Forms.Label();
            this.gbxJeu = new System.Windows.Forms.GroupBox();
            this.gbxInfos = new System.Windows.Forms.GroupBox();
            this.gbxScore = new System.Windows.Forms.GroupBox();
            this.lblINUTILE2 = new System.Windows.Forms.Label();
            this.lblMatchNuls = new System.Windows.Forms.Label();
            this.lblPointsPlayer2 = new System.Windows.Forms.Label();
            this.lblPointsPlayer1 = new System.Windows.Forms.Label();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.lblINUTILE1 = new System.Windows.Forms.Label();
            this.PanelMenuPrincipal = new System.Windows.Forms.Panel();
            this.gbxIAOuiNon = new System.Windows.Forms.GroupBox();
            this.cbxAIEnclenchee = new System.Windows.Forms.CheckBox();
            this.btnJouer = new System.Windows.Forms.Button();
            this.lblInfoNom2 = new System.Windows.Forms.Label();
            this.lblInfoNom1 = new System.Windows.Forms.Label();
            this.tbxNomPlayer2 = new System.Windows.Forms.TextBox();
            this.tbxNomPlayer1 = new System.Windows.Forms.TextBox();
            this.TimerJeuOrdinateur = new System.Windows.Forms.Timer(this.components);
            this.ColorDialogFore = new System.Windows.Forms.ColorDialog();
            this.ColorDialogBack = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.SymbolColorDialog = new System.Windows.Forms.ColorDialog();
            this.menuJeu.SuspendLayout();
            this.gbxJeu.SuspendLayout();
            this.gbxInfos.SuspendLayout();
            this.gbxScore.SuspendLayout();
            this.PanelMenuPrincipal.SuspendLayout();
            this.gbxIAOuiNon.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCase1
            // 
            this.lblCase1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCase1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCase1.Location = new System.Drawing.Point(22, 26);
            this.lblCase1.Name = "lblCase1";
            this.lblCase1.Size = new System.Drawing.Size(100, 100);
            this.lblCase1.TabIndex = 0;
            this.lblCase1.Text = "X";
            this.lblCase1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCase1.Click += new System.EventHandler(this.CommonLabelClickHandler);
            // 
            // lblCase2
            // 
            this.lblCase2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCase2.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCase2.Location = new System.Drawing.Point(22, 134);
            this.lblCase2.Name = "lblCase2";
            this.lblCase2.Size = new System.Drawing.Size(100, 100);
            this.lblCase2.TabIndex = 1;
            this.lblCase2.Text = "X";
            this.lblCase2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCase2.Click += new System.EventHandler(this.CommonLabelClickHandler);
            // 
            // lblCase3
            // 
            this.lblCase3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCase3.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCase3.Location = new System.Drawing.Point(22, 242);
            this.lblCase3.Name = "lblCase3";
            this.lblCase3.Size = new System.Drawing.Size(100, 100);
            this.lblCase3.TabIndex = 2;
            this.lblCase3.Text = "X";
            this.lblCase3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCase3.Click += new System.EventHandler(this.CommonLabelClickHandler);
            // 
            // lblCase4
            // 
            this.lblCase4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCase4.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCase4.Location = new System.Drawing.Point(138, 26);
            this.lblCase4.Name = "lblCase4";
            this.lblCase4.Size = new System.Drawing.Size(100, 100);
            this.lblCase4.TabIndex = 3;
            this.lblCase4.Text = "X";
            this.lblCase4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCase4.Click += new System.EventHandler(this.CommonLabelClickHandler);
            // 
            // lblCase5
            // 
            this.lblCase5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCase5.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCase5.Location = new System.Drawing.Point(138, 134);
            this.lblCase5.Name = "lblCase5";
            this.lblCase5.Size = new System.Drawing.Size(100, 100);
            this.lblCase5.TabIndex = 4;
            this.lblCase5.Text = "X";
            this.lblCase5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCase5.Click += new System.EventHandler(this.CommonLabelClickHandler);
            // 
            // lblCase6
            // 
            this.lblCase6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCase6.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCase6.Location = new System.Drawing.Point(138, 242);
            this.lblCase6.Name = "lblCase6";
            this.lblCase6.Size = new System.Drawing.Size(100, 100);
            this.lblCase6.TabIndex = 5;
            this.lblCase6.Text = "X";
            this.lblCase6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCase6.Click += new System.EventHandler(this.CommonLabelClickHandler);
            // 
            // lblCase7
            // 
            this.lblCase7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCase7.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCase7.Location = new System.Drawing.Point(254, 26);
            this.lblCase7.Name = "lblCase7";
            this.lblCase7.Size = new System.Drawing.Size(100, 100);
            this.lblCase7.TabIndex = 6;
            this.lblCase7.Text = "X";
            this.lblCase7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCase7.Click += new System.EventHandler(this.CommonLabelClickHandler);
            // 
            // lblCase8
            // 
            this.lblCase8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCase8.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCase8.Location = new System.Drawing.Point(254, 134);
            this.lblCase8.Name = "lblCase8";
            this.lblCase8.Size = new System.Drawing.Size(100, 100);
            this.lblCase8.TabIndex = 7;
            this.lblCase8.Text = "X";
            this.lblCase8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCase8.Click += new System.EventHandler(this.CommonLabelClickHandler);
            // 
            // lblCase9
            // 
            this.lblCase9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCase9.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCase9.Location = new System.Drawing.Point(254, 242);
            this.lblCase9.Name = "lblCase9";
            this.lblCase9.Size = new System.Drawing.Size(100, 100);
            this.lblCase9.TabIndex = 8;
            this.lblCase9.Text = "X";
            this.lblCase9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCase9.Click += new System.EventHandler(this.CommonLabelClickHandler);
            // 
            // menuJeu
            // 
            this.menuJeu.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuJeu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jeuToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.creditsToolStripMenuItem});
            this.menuJeu.Location = new System.Drawing.Point(0, 0);
            this.menuJeu.Name = "menuJeu";
            this.menuJeu.Size = new System.Drawing.Size(622, 24);
            this.menuJeu.TabIndex = 9;
            this.menuJeu.Text = "menuStrip1";
            // 
            // jeuToolStripMenuItem
            // 
            this.jeuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.jeuToolStripMenuItem.Name = "jeuToolStripMenuItem";
            this.jeuToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.jeuToolStripMenuItem.Text = "Jeu...";
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetGrilleToolStripMenuItem,
            this.resetTotalToolStripMenuItem,
            this.resetPoliceToolStripMenuItem});
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.resetToolStripMenuItem.Text = "Reset...";
            // 
            // resetGrilleToolStripMenuItem
            // 
            this.resetGrilleToolStripMenuItem.Name = "resetGrilleToolStripMenuItem";
            this.resetGrilleToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.resetGrilleToolStripMenuItem.Text = "Reset Grille";
            this.resetGrilleToolStripMenuItem.Click += new System.EventHandler(this.resetGrilleToolStripMenuItem_Click);
            // 
            // resetTotalToolStripMenuItem
            // 
            this.resetTotalToolStripMenuItem.Name = "resetTotalToolStripMenuItem";
            this.resetTotalToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.resetTotalToolStripMenuItem.Text = "Reset Total";
            this.resetTotalToolStripMenuItem.Click += new System.EventHandler(this.resetTotalToolStripMenuItem_Click);
            // 
            // resetPoliceToolStripMenuItem
            // 
            this.resetPoliceToolStripMenuItem.Name = "resetPoliceToolStripMenuItem";
            this.resetPoliceToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.resetPoliceToolStripMenuItem.Text = "Reset Police";
            this.resetPoliceToolStripMenuItem.Click += new System.EventHandler(this.resetPoliceToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changerLaCouleurDuFondToolStripMenuItem,
            this.changerLaCouleurDuTexteToolStripMenuItem,
            this.changezLaCouleurDesSymbolesToolStripMenuItem,
            this.changezLaPoliceToolStripMenuItem,
            this.optionsAvancésToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // changerLaCouleurDuFondToolStripMenuItem
            // 
            this.changerLaCouleurDuFondToolStripMenuItem.Name = "changerLaCouleurDuFondToolStripMenuItem";
            this.changerLaCouleurDuFondToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.changerLaCouleurDuFondToolStripMenuItem.Text = "Changer la couleur du fond";
            this.changerLaCouleurDuFondToolStripMenuItem.Click += new System.EventHandler(this.changerLaCouleurDuFondToolStripMenuItem_Click);
            // 
            // changerLaCouleurDuTexteToolStripMenuItem
            // 
            this.changerLaCouleurDuTexteToolStripMenuItem.Name = "changerLaCouleurDuTexteToolStripMenuItem";
            this.changerLaCouleurDuTexteToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.changerLaCouleurDuTexteToolStripMenuItem.Text = "Changer la couleur du texte";
            this.changerLaCouleurDuTexteToolStripMenuItem.Click += new System.EventHandler(this.changerLaCouleurDuTexteToolStripMenuItem_Click);
            // 
            // changezLaCouleurDesSymbolesToolStripMenuItem
            // 
            this.changezLaCouleurDesSymbolesToolStripMenuItem.Name = "changezLaCouleurDesSymbolesToolStripMenuItem";
            this.changezLaCouleurDesSymbolesToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.changezLaCouleurDesSymbolesToolStripMenuItem.Text = "Changez la couleur des symboles";
            this.changezLaCouleurDesSymbolesToolStripMenuItem.Click += new System.EventHandler(this.changezLaCouleurDesSymbolesToolStripMenuItem_Click);
            // 
            // changezLaPoliceToolStripMenuItem
            // 
            this.changezLaPoliceToolStripMenuItem.Name = "changezLaPoliceToolStripMenuItem";
            this.changezLaPoliceToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.changezLaPoliceToolStripMenuItem.Text = "Changez la police de carractères";
            this.changezLaPoliceToolStripMenuItem.Click += new System.EventHandler(this.changezLaPoliceToolStripMenuItem_Click);
            // 
            // optionsAvancésToolStripMenuItem
            // 
            this.optionsAvancésToolStripMenuItem.Name = "optionsAvancésToolStripMenuItem";
            this.optionsAvancésToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.optionsAvancésToolStripMenuItem.Text = "Options avancés";
            this.optionsAvancésToolStripMenuItem.Click += new System.EventHandler(this.optionsAvancesToolStripMenuItem_Click);
            // 
            // creditsToolStripMenuItem
            // 
            this.creditsToolStripMenuItem.Name = "creditsToolStripMenuItem";
            this.creditsToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.creditsToolStripMenuItem.Text = "Crédits";
            this.creditsToolStripMenuItem.Click += new System.EventHandler(this.creditsToolStripMenuItem_Click);
            // 
            // lblPlayerActuel
            // 
            this.lblPlayerActuel.AutoSize = true;
            this.lblPlayerActuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerActuel.Location = new System.Drawing.Point(6, 26);
            this.lblPlayerActuel.Name = "lblPlayerActuel";
            this.lblPlayerActuel.Size = new System.Drawing.Size(77, 20);
            this.lblPlayerActuel.TabIndex = 10;
            this.lblPlayerActuel.Text = "<player>";
            // 
            // gbxJeu
            // 
            this.gbxJeu.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gbxJeu.Controls.Add(this.lblCase1);
            this.gbxJeu.Controls.Add(this.lblCase2);
            this.gbxJeu.Controls.Add(this.lblCase9);
            this.gbxJeu.Controls.Add(this.lblCase3);
            this.gbxJeu.Controls.Add(this.lblCase8);
            this.gbxJeu.Controls.Add(this.lblCase4);
            this.gbxJeu.Controls.Add(this.lblCase7);
            this.gbxJeu.Controls.Add(this.lblCase5);
            this.gbxJeu.Controls.Add(this.lblCase6);
            this.gbxJeu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbxJeu.Location = new System.Drawing.Point(12, 41);
            this.gbxJeu.Name = "gbxJeu";
            this.gbxJeu.Size = new System.Drawing.Size(391, 359);
            this.gbxJeu.TabIndex = 11;
            this.gbxJeu.TabStop = false;
            this.gbxJeu.Text = "Grille de jeu";
            // 
            // gbxInfos
            // 
            this.gbxInfos.Controls.Add(this.lblPlayerActuel);
            this.gbxInfos.Location = new System.Drawing.Point(410, 41);
            this.gbxInfos.Name = "gbxInfos";
            this.gbxInfos.Size = new System.Drawing.Size(200, 100);
            this.gbxInfos.TabIndex = 12;
            this.gbxInfos.TabStop = false;
            this.gbxInfos.Text = "Informations";
            // 
            // gbxScore
            // 
            this.gbxScore.Controls.Add(this.lblINUTILE2);
            this.gbxScore.Controls.Add(this.lblMatchNuls);
            this.gbxScore.Controls.Add(this.lblPointsPlayer2);
            this.gbxScore.Controls.Add(this.lblPointsPlayer1);
            this.gbxScore.Controls.Add(this.lblPlayer2);
            this.gbxScore.Controls.Add(this.lblPlayer1);
            this.gbxScore.Controls.Add(this.lblINUTILE1);
            this.gbxScore.Location = new System.Drawing.Point(410, 147);
            this.gbxScore.Name = "gbxScore";
            this.gbxScore.Size = new System.Drawing.Size(200, 253);
            this.gbxScore.TabIndex = 13;
            this.gbxScore.TabStop = false;
            this.gbxScore.Text = "Score";
            // 
            // lblINUTILE2
            // 
            this.lblINUTILE2.AutoSize = true;
            this.lblINUTILE2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblINUTILE2.Location = new System.Drawing.Point(91, 49);
            this.lblINUTILE2.Name = "lblINUTILE2";
            this.lblINUTILE2.Size = new System.Drawing.Size(13, 72);
            this.lblINUTILE2.TabIndex = 3;
            this.lblINUTILE2.Text = "|\n|\n|\n|\n";
            // 
            // lblMatchNuls
            // 
            this.lblMatchNuls.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatchNuls.Location = new System.Drawing.Point(43, 145);
            this.lblMatchNuls.Name = "lblMatchNuls";
            this.lblMatchNuls.Size = new System.Drawing.Size(131, 18);
            this.lblMatchNuls.TabIndex = 6;
            this.lblMatchNuls.Text = "Match Nuls : 0";
            // 
            // lblPointsPlayer2
            // 
            this.lblPointsPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPointsPlayer2.Location = new System.Drawing.Point(130, 90);
            this.lblPointsPlayer2.Name = "lblPointsPlayer2";
            this.lblPointsPlayer2.Size = new System.Drawing.Size(41, 18);
            this.lblPointsPlayer2.TabIndex = 5;
            this.lblPointsPlayer2.Text = "0";
            this.lblPointsPlayer2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPointsPlayer1
            // 
            this.lblPointsPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPointsPlayer1.Location = new System.Drawing.Point(32, 90);
            this.lblPointsPlayer1.Name = "lblPointsPlayer1";
            this.lblPointsPlayer1.Size = new System.Drawing.Size(40, 18);
            this.lblPointsPlayer1.TabIndex = 4;
            this.lblPointsPlayer1.Text = "0";
            this.lblPointsPlayer1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2.Location = new System.Drawing.Point(105, 49);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(89, 18);
            this.lblPlayer2.TabIndex = 1;
            this.lblPlayer2.Text = "Player 2";
            this.lblPlayer2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1.Location = new System.Drawing.Point(22, 49);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(61, 18);
            this.lblPlayer1.TabIndex = 0;
            this.lblPlayer1.Text = "Player 1";
            this.lblPlayer1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblINUTILE1
            // 
            this.lblINUTILE1.AutoSize = true;
            this.lblINUTILE1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblINUTILE1.Location = new System.Drawing.Point(6, 67);
            this.lblINUTILE1.Name = "lblINUTILE1";
            this.lblINUTILE1.Size = new System.Drawing.Size(188, 18);
            this.lblINUTILE1.TabIndex = 2;
            this.lblINUTILE1.Text = "------------------------------------";
            // 
            // PanelMenuPrincipal
            // 
            this.PanelMenuPrincipal.Controls.Add(this.gbxIAOuiNon);
            this.PanelMenuPrincipal.Controls.Add(this.btnJouer);
            this.PanelMenuPrincipal.Controls.Add(this.lblInfoNom2);
            this.PanelMenuPrincipal.Controls.Add(this.lblInfoNom1);
            this.PanelMenuPrincipal.Controls.Add(this.tbxNomPlayer2);
            this.PanelMenuPrincipal.Controls.Add(this.tbxNomPlayer1);
            this.PanelMenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.PanelMenuPrincipal.Name = "PanelMenuPrincipal";
            this.PanelMenuPrincipal.Size = new System.Drawing.Size(622, 446);
            this.PanelMenuPrincipal.TabIndex = 14;
            // 
            // gbxIAOuiNon
            // 
            this.gbxIAOuiNon.Controls.Add(this.cbxAIEnclenchee);
            this.gbxIAOuiNon.Location = new System.Drawing.Point(204, 237);
            this.gbxIAOuiNon.Name = "gbxIAOuiNon";
            this.gbxIAOuiNon.Size = new System.Drawing.Size(200, 63);
            this.gbxIAOuiNon.TabIndex = 3;
            this.gbxIAOuiNon.TabStop = false;
            this.gbxIAOuiNon.Text = "Options";
            // 
            // cbxAIEnclenchee
            // 
            this.cbxAIEnclenchee.AutoSize = true;
            this.cbxAIEnclenchee.Location = new System.Drawing.Point(37, 26);
            this.cbxAIEnclenchee.Name = "cbxAIEnclenchee";
            this.cbxAIEnclenchee.Size = new System.Drawing.Size(139, 17);
            this.cbxAIEnclenchee.TabIndex = 0;
            this.cbxAIEnclenchee.Text = "Jouer contre l\'ordinateur";
            this.cbxAIEnclenchee.UseVisualStyleBackColor = true;
            this.cbxAIEnclenchee.CheckedChanged += new System.EventHandler(this.cbxAIEnclenchee_CheckedChanged);
            // 
            // btnJouer
            // 
            this.btnJouer.Location = new System.Drawing.Point(204, 339);
            this.btnJouer.Name = "btnJouer";
            this.btnJouer.Size = new System.Drawing.Size(199, 55);
            this.btnJouer.TabIndex = 2;
            this.btnJouer.Text = "Jouer !";
            this.btnJouer.UseVisualStyleBackColor = true;
            this.btnJouer.Click += new System.EventHandler(this.btnJouer_Click);
            // 
            // lblInfoNom2
            // 
            this.lblInfoNom2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoNom2.Location = new System.Drawing.Point(336, 67);
            this.lblInfoNom2.Name = "lblInfoNom2";
            this.lblInfoNom2.Size = new System.Drawing.Size(169, 44);
            this.lblInfoNom2.TabIndex = 5;
            this.lblInfoNom2.Text = "Entrez le nom du deuxième joueur";
            this.lblInfoNom2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInfoNom1
            // 
            this.lblInfoNom1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoNom1.Location = new System.Drawing.Point(119, 67);
            this.lblInfoNom1.Name = "lblInfoNom1";
            this.lblInfoNom1.Size = new System.Drawing.Size(169, 44);
            this.lblInfoNom1.TabIndex = 4;
            this.lblInfoNom1.Text = "Entrez le nom du premier joueur";
            this.lblInfoNom1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxNomPlayer2
            // 
            this.tbxNomPlayer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxNomPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNomPlayer2.Location = new System.Drawing.Point(336, 131);
            this.tbxNomPlayer2.Name = "tbxNomPlayer2";
            this.tbxNomPlayer2.Size = new System.Drawing.Size(169, 44);
            this.tbxNomPlayer2.TabIndex = 1;
            this.tbxNomPlayer2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxNomPlayer1
            // 
            this.tbxNomPlayer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxNomPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNomPlayer1.Location = new System.Drawing.Point(119, 131);
            this.tbxNomPlayer1.Name = "tbxNomPlayer1";
            this.tbxNomPlayer1.Size = new System.Drawing.Size(169, 44);
            this.tbxNomPlayer1.TabIndex = 0;
            this.tbxNomPlayer1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TimerJeuOrdinateur
            // 
            this.TimerJeuOrdinateur.Tick += new System.EventHandler(this.TimerJeuOrdinateur_Tick);
            // 
            // frmTicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(622, 443);
            this.Controls.Add(this.PanelMenuPrincipal);
            this.Controls.Add(this.gbxScore);
            this.Controls.Add(this.gbxInfos);
            this.Controls.Add(this.gbxJeu);
            this.Controls.Add(this.menuJeu);
            this.MainMenuStrip = this.menuJeu;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(638, 482);
            this.MinimumSize = new System.Drawing.Size(638, 482);
            this.Name = "frmTicTacToe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTicTacToe_FormClosing);
            this.Load += new System.EventHandler(this.frmTicTacToe_Load);
            this.menuJeu.ResumeLayout(false);
            this.menuJeu.PerformLayout();
            this.gbxJeu.ResumeLayout(false);
            this.gbxInfos.ResumeLayout(false);
            this.gbxInfos.PerformLayout();
            this.gbxScore.ResumeLayout(false);
            this.gbxScore.PerformLayout();
            this.PanelMenuPrincipal.ResumeLayout(false);
            this.PanelMenuPrincipal.PerformLayout();
            this.gbxIAOuiNon.ResumeLayout(false);
            this.gbxIAOuiNon.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCase1;
        private System.Windows.Forms.Label lblCase2;
        private System.Windows.Forms.Label lblCase3;
        private System.Windows.Forms.Label lblCase4;
        private System.Windows.Forms.Label lblCase5;
        private System.Windows.Forms.Label lblCase6;
        private System.Windows.Forms.Label lblCase7;
        private System.Windows.Forms.Label lblCase8;
        private System.Windows.Forms.Label lblCase9;
        private System.Windows.Forms.MenuStrip menuJeu;
        private System.Windows.Forms.ToolStripMenuItem jeuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        public System.Windows.Forms.Label lblPlayerActuel;
        public System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbxJeu;
        private System.Windows.Forms.GroupBox gbxInfos;
        private System.Windows.Forms.ToolStripMenuItem creditsToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbxScore;
        private System.Windows.Forms.Label lblINUTILE2;
        private System.Windows.Forms.Label lblINUTILE1;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.Label lblPointsPlayer1;
        private System.Windows.Forms.Label lblPointsPlayer2;
        private System.Windows.Forms.Label lblMatchNuls;
        private System.Windows.Forms.ToolStripMenuItem resetGrilleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetTotalToolStripMenuItem;
        private System.Windows.Forms.Panel PanelMenuPrincipal;
        private System.Windows.Forms.GroupBox gbxIAOuiNon;
        private System.Windows.Forms.CheckBox cbxAIEnclenchee;
        private System.Windows.Forms.TextBox tbxNomPlayer2;
        private System.Windows.Forms.TextBox tbxNomPlayer1;
        private System.Windows.Forms.Button btnJouer;
        private System.Windows.Forms.Label lblInfoNom2;
        private System.Windows.Forms.Label lblInfoNom1;
        private System.Windows.Forms.Timer TimerJeuOrdinateur;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changerLaCouleurDuFondToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changerLaCouleurDuTexteToolStripMenuItem;
        private System.Windows.Forms.ColorDialog ColorDialogFore;
        private System.Windows.Forms.ToolStripMenuItem changezLaPoliceToolStripMenuItem;
        private System.Windows.Forms.ColorDialog ColorDialogBack;
        private System.Windows.Forms.ToolStripMenuItem changezLaCouleurDesSymbolesToolStripMenuItem;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog SymbolColorDialog;
        private System.Windows.Forms.ToolStripMenuItem resetPoliceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsAvancésToolStripMenuItem;
    }
}

