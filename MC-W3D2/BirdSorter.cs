using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MC_W3D2
{
    public class BirdSorter
    {
        public void BirdScore()
        {
            int score = 5000;
            int lives = 3;

            if (lives > 0)
            {
                string birdMovement = "Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,InvincibleBirdHunter,EveningGrosbeak,GreaterPrairieChicken,VulnerableBirdHunter,VulnerableBirdHunter,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,IcelandGull,CrestedIbis,GreatKiskudee,InvincibleBirdHunter,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,RedCrossbill,Red-neckedPhalarope,InvincibleBirdHunter,VulnerableBirdHunter,Orange-belliedParrot,InvincibleBirdHunter,Bird,Bird,Bird,Bird,Bird,VulnerableBirdHunter";
                string[] movement = birdMovement.Split(',');

                foreach (var word in movement)
                {
                    if (score >= 10000)
                    {
                        lives++;
                        switch (word)
                        {
                            case "Bird":
                                score += 10;
                                break;
                            case "InvincibleBirdHunter":
                                lives--;
                                break;
                            case "EveningGrosbeak":
                                score += 1000;
                                break;
                            case "GreaterPrairieChicken":
                                score += 2000;
                                break;
                            case "VulnerableBirdHunter":
                                score += 200;
                                break;
                            case "IcelandGull":
                                score += 3000;
                                break;
                            case "CrestedIbis":
                                score += 100;
                                break;
                            case "GreatKiskudee":
                                score += 300;
                                break;
                            case "RedCrossbill":
                                score += 500;
                                break;
                            case "Red-neckedPhalarope":
                                score += 700;
                                break;
                            case "Orange-belliedParrot":
                                score += 5000;
                                break;
                        }
                    }
                }
                Console.WriteLine(score);
            }
            else
            {
                Console.WriteLine("Gave over.");
            }
        }


    }
}
