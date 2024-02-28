using AttentionGet.Diplay;
using AttentionGet.Storage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AttentionGet
{

    public partial class Form1 : Form
    {
        //Objet liée au t-rex
        private T_rex trex;
        //Liste d'objet liée a l'obstacle
        private List<Obstacle> obstacleList;
        //Objet liée au score
        private Score score;
        //Position du top du sol
        private int groundTop;
        //Vitesse des obstacles
        private int speedObstacle = 6;
        //Etat du jeu
        private bool gameStatus = true;


        //Initialisation du jeu par défault
        public Form1()
        {
            InitializeComponent();
            InitializeGame();
        }

        //Initialisations des objects du jeu
        private void InitializeGame()
        {
            //Instanciation du T-rex
            trex = new T_rex(Dino);

            //Instanciation de la liste d'obstacles
            obstacleList = new List<Obstacle>();

            //Ajout des obstacles
            obstacleList.Add(new Obstacle(CactusSimple, speedObstacle));
            obstacleList.Add(new Obstacle(CactusDouble, speedObstacle));

            //Instanciation du score
            score = new Score();

            // Stockage de la position du top du sol
            groundTop = Ground.Top;

            // Démarrage du timer du jeu
            GameTime.Start();

        }


        // Active le saut progressif en maintenant la touche espace
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                trex.isJumping = true;
                trex.isOnGround = true;
            }
        }

        //Désactive le saut progressif lorsque la touche espace est relachée 
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                trex.isJumping = false;
            }
        }


        //Boucle du jeux (s'éxecute à chaque tic du timer)
        private void MainGameTimerEvent(object sender, EventArgs e)
        {
            //Saut du T-rex
            trex.Jump(groundTop);

            //Mise à jour de chaque obstacle
            foreach (Obstacle obstacle in obstacleList)
            {
                //Déplacement obstacle
                obstacle.Update();

                //Si un obstacles est passé
                if (obstacle.obstacle.Right < 0)
                {
                    // Mise à jour du score
                    score.score++;
                    txtScore.Text = "Score: " + score.score;

                    // Réinitialise la position de l'obstacle à droite de l'écran
                    obstacle.Reset(this.ClientSize.Width);
                }

                // Détection collisions obstacles
                if (trex.trex.Bounds.IntersectsWith(obstacle.obstacle.Bounds))
                {
                    gameStatus = false;

                    // Jeux s'arrete
                    GameTime.Stop();

                    //Change l'image du T-rex
                    Dino.Image = Properties.Resources.dead;
                }

            }

            //La vitesse augmente en fonction du score
            if (score.score % 6 == 0)
            {
                speedObstacle++;
            }

            //Fin de partie
            if (!gameStatus)
            {
                //Affiche le label GameOver
                gameOver.Visible = true;

                //Affiche / Active les boutton
                buttonReplay.Visible = true;
                buttonReplay.Enabled = true;
                buttonLeave.Visible = true;
                buttonLeave.Enabled = true;

                //Insert les donne dans la db
                score.SaveScore();
            }

        }

        //Relancement du jeux par défault
        private void buttonReplay_Click(object sender, EventArgs e)
        {
            //Variable
            speedObstacle = 5;
            gameStatus = true;
            score.score = 0;

            //Label
            gameOver.Visible = false;
            txtScore.Text = "Score: " + score.score;

            //Boutton
            buttonReplay.Visible = false;
            buttonReplay.Enabled = false;
            buttonLeave.Visible = false; 
            buttonLeave.Enabled = false;

            //Image
            Dino.Image = Properties.Resources.running__1_;

            //Objet
            CactusDouble.Location = new Point(643, 358);
            CactusSimple.Location = new Point(504, 345);

            GameTime.Start();


        }

        //Reviens au menu principale
        private void buttonLeave_Click(object sender, EventArgs e)
        {
            // Créez une instance de Nenu
            Menuprincipale menu = new Menuprincipale();


            //Desaffiche le form
            this.Hide();


            //Affiche le menu
            menu.Show();
        }


    }
}
