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
        public PictureBox PictureBox;
        public bool isJumping;
        public int force = 10;

        public T_rex(PictureBox pictureBox)
        {
            PictureBox = pictureBox;
        }
        public void Jump()
        {
            if(!isJumping)
            {
                isJumping = true;

            }
        }
    }
}
