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
        public bool isJumping = true;
        //Permission de sauter
        public bool canJump = true;
        //Force du saut
        public int force = 100;
        //Délai d'attente saut
        public int cooldown = 200;

        //Caractéristique par défault du T-rex
        public T_rex(PictureBox imageTrex)
        {
            trex = imageTrex;
        }


        //Saut du T-rex
        public async void Jump()
        {
            //Activation du saut seulement au sol
            if (!isJumping && canJump)
            {
                //Changement de la position du dino
                trex.Top -= force;

                canJump = false;

                //Attent que la tache asynchrone se finisse (cooldown)
                await Task.Delay(cooldown);
                
                isJumping = true;
                canJump = true;
            }
        }

        //Mise a jour du saut (descendre le dino quand il est en l'air)
        public void UpdateJump(int groundTop)
        {
            if (isJumping)
            {
                //Le dino se remet sur le sol quand il est en l'air
                while (trex.Top == groundTop - trex.Height)
                {
                    trex.Top += 2;

                    Task.Delay(cooldown).Wait();
                }

            }
           
           
        }


    }
}
