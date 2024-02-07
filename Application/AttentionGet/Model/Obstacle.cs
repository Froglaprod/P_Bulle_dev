using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttentionGet
{
    public class Obstacle
    {
        //Image de l'obstacle
        public PictureBox obstacle;
        //Vitesse d'apparition
        public int speedApparition;

        //Caractéristique par défault de l'obstacle
        public Obstacle(PictureBox imageObstacle, int speed)
        {
            obstacle = imageObstacle;
            speedApparition = speed;
        }

        //Mise a jour de la position l'obsacle
        public void Update()
        {
          obstacle.Left -= speedApparition;
        }

        //Rénisialisation de la position de l'obstacle
        public void Reset(int defaultPosition)
        {
            obstacle.Left -= defaultPosition;
        }

    }
}
