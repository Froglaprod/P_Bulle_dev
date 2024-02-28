using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AttentionGet.Storage
{
    public class Score
    {
        //Score du joueur
        public int score = 0;
        // Permet de se connecter au serveur
        public string connexionDb = "Server=localhost;Port=8080;Database=db_dinogame;User=root;Password=root;";
        // Requêtes pour insert le score du joueur
        public string insertQuery = "INSERT INTO t_player (score) VALUES (@score)";


        // On stock le score du joueur et son pseudo dans la base de données
        public void SaveScore()
        {
            // Utilise l'instruction using MySqlConnection, pour se connecter à la db
            using (MySqlConnection connexion = new MySqlConnection(connexionDb))
            {
                //Ouverture de la connexion
                connexion.Open();

                // Utilise l'instruction using MySqlCommand, pour éxecuter des commandes 
                using (MySqlCommand cmd = new MySqlCommand(insertQuery, connexion))
                {
                    //Insert du score dans la base de données
                    cmd.Parameters.AddWithValue("@score", score);
                    cmd.ExecuteNonQuery();
                }

                //Fermeture de la connexion
                connexion.Close();
            }

        }
    }
}

