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
        //Position du top du sol
        private int groundTop;

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
            obstacleList.Add(new Obstacle(CactusSimple, 3));
            obstacleList.Add(new Obstacle(CactusDouble, 3));

            // Stockage de la position du top du sol
            groundTop = Ground.Top;

        }


        //Vérification de l'entré de l'utilisateur
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //Quand on appuie sur "espace" on déclenche le saut
            if (e.KeyCode == Keys.Space)
            {
                trex.isJumping = false;
            }
        }

        //Boucle du jeux (s'éxecute à chaque tic du timer)
        private void MainGameTimerEvent(object sender, EventArgs e)
        {
            //Saut du T-rex
            trex.Jump();

            //Update du jump
            trex.UpdateJump(groundTop);

            //Mise à jour de chaque obstacle
            foreach(Obstacle obstacle in obstacleList)
            {
                //Déplacement obstacle
                obstacle.Update();

                // Détection collisions obstacles
                if(trex.trex.Bounds.IntersectsWith(obstacle.obstacle.Bounds))
                {
                    GameTime.Enabled = false;
                }

            }

        }


    }
}
