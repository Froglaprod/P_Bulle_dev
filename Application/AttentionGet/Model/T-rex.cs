using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttentionGet
{
    public class T_rex
    {
        //Image du T-rex
        public PictureBox trex;
        //Connaitre son etat de saut
        public bool isJumping = false;
        //Permission de sauter
        public bool canJump = true;
        //Force du saut
        public int force = 20;
        //Temp de la descente
        public int speed = 10;
        //Position du T-rex par apport su sol
        public bool isOnGround = true;

        //Caractéristique par défault du T-rex
        public T_rex(PictureBox imageTrex)
        {
            trex = imageTrex;
        }


        //Saut du T-rex
        public void Jump(int groundTop)
        {
            //T-rex monte
            if (isJumping && !isOnGround)
            {
                //Apllique une force au top du t-rex
                trex.Top -= force;
            }

            //T-rex descend progressivement vers le sol
            if (trex.Top < groundTop - trex.Height)
            {
                trex.Top += speed;
            }

            //T-rex peut sauter
            if (trex.Top == groundTop - trex.Height)
            {
                isOnGround = false;
            }

        }

    }
}

