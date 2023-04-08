using ODEV5.GameFile;
using ODEV5.OfferFile;
using ODEV5.PlayerFile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODEV5
{
    public class Program
    {
        static void Main(string[] args)
        {

            

            Player player1 = new Player()
            {
                Id = 1,
                FirstName = "Talat",
                LastName = "Erdoğan",
                BirthDate = new DateTime(2000,10,10),
                NationalityId = "111111111111"
            };

            
            PlayerManager playerManager = new PlayerManager(new PlayerCheckManager());


            playerManager.Save(player1);
            Console.WriteLine("-----");
            playerManager.Delete(player1);
            Console.WriteLine("--------");
            playerManager.Update(player1);

            Console.WriteLine("----------------");

            Offer offer1 = new Offer()
            {
                id = 1,
                OfferName = "Bahar İndirimi",
                OfferDescription = "Bahar da gelen indirim",
                DiscountRate = 10,
            };


            Game game1 = new Game()
            {
                Id= 1,
                GameName = "Gta5",
                Price = 100
            };

            //for Update the game 
            GameManager gameManager = new GameManager(new GameUpdateCheckManager());

            gameManager.AddGame(game1);
            Console.WriteLine("-----");
            gameManager.UpdateGame(game1);
            Console.WriteLine("-----");
            gameManager.RemoveGame(game1);
            Console.WriteLine("------");

            OfferGameManager offerGame = new OfferGameManager();
            
            OfferManager offerManager = new OfferManager();
            
            offerManager.AddOffer(offer1);
            Console.WriteLine("------");
            offerManager.DeleteOffer(offer1);
            Console.WriteLine("--------");
            offerManager.UpdateOffer(offer1);

            offerGame.Sale(player1, offer1, game1);

            Console.ReadLine();
        }
    }
}
