﻿using System;
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
            obstacleList.Add(new Obstacle(CactusSimple, 5));
            obstacleList.Add(new Obstacle(CactusDouble, 5));

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

                //Replacement des obstacles
                if (obstacle.obstacle.Right < 0)
                {
                    // Réinitialise la position de l'obstacle à droite de l'écran
                    obstacle.Reset(this.ClientSize.Width);
                }

                // Détection collisions obstacles
                if (trex.trex.Bounds.IntersectsWith(obstacle.obstacle.Bounds))
                {
                    // Jeux s'arrete
                    GameTime.Stop();
                    //Change l'image du T-rex
                    Dino.Image = Properties.Resources.dead;
                }

            }

        }


    }
}
