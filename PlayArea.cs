using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace L5R
{
    public partial class PlayArea : Form
    {
        private GameState.GameState gs;
        
        
        public PlayArea()
        {
            InitializeComponent();
            InitializeGame();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void startGameButton_Click(object sender, EventArgs e)
        {
           

            Console.WriteLine("Perform Dynasty Phase");
            gs.performDynastyPhase();
        }

        private void InitializeGame()
        {

            Console.WriteLine("Creating cards");

            L5R.Card testFateCard = new Card();
            L5R.Card testDynastyCard = new Card();

            L5R.Card testHolding1 = new Card();
            L5R.Card testHolding2 = new Card();
            L5R.Card testHolding3 = new Card();
            L5R.Card testHolding4 = new Card();
            L5R.Card testHolding5 = new Card();
            L5R.Card testHolding6 = new Card();



            Console.WriteLine("Creating decks");
            List<L5R.Card> testFateDeck = new List<L5R.Card>();
            List<L5R.Card> testDynastyDeck = new List<L5R.Card>();


            testDynastyCard.IsPersonality = true;
            testDynastyCard.BaseForce = 0;
            testDynastyCard.BaseChi = 4;
            testDynastyCard.CardName = "Togashi Mitsu";
            testDynastyCard.BaseGoldCost = 7;
            testDynastyCard.BasePersonalHonour = 1;
            testDynastyCard.HonourRequirment = 5;
            testDynastyCard.addAction(new MeleeAttack(8, "Battle:Melee 8 attack"));
            testDynastyCard.CardImage = L5R.Properties.Resources._10590;


            testHolding1.IsHolding = true;
            testHolding1.CardName = "Small Farm";
            testHolding1.BaseGoldCost = 0;
            testHolding1.CardImage = L5R.Properties.Resources._3436;

            testHolding2.IsHolding = true;
            testHolding2.CardName = "Small Farm";
            testHolding2.BaseGoldCost = 0;
            testHolding2.CardImage = L5R.Properties.Resources._3436;

            testHolding3.IsHolding = true;
            testHolding3.CardName = "Small Farm";
            testHolding3.BaseGoldCost = 0;
            testHolding3.CardImage = L5R.Properties.Resources._3436;


            testHolding4.IsHolding = true;
            testHolding4.CardName = "Remote village";
            testHolding4.BaseGoldCost = 3;
            testHolding4.CardImage = L5R.Properties.Resources._9504;

            testHolding5.IsHolding = true;
            testHolding5.CardName = "Remote village";
            testHolding5.BaseGoldCost = 3;
            testHolding5.CardImage = L5R.Properties.Resources._9504;

            testHolding6.IsHolding = true;
            testHolding6.CardName = "Remote village";
            testHolding6.BaseGoldCost = 3;
            testHolding6.CardImage = L5R.Properties.Resources._9504;

            


            testDynastyDeck.Add(testHolding1);
            testDynastyDeck.Add(testHolding2);
            testDynastyDeck.Add(testHolding3);
            testDynastyDeck.Add(testHolding4);


            testDynastyDeck.Add(testDynastyCard);
            testFateDeck.Add(testFateCard);

            Console.WriteLine("Creating players");
            L5R.Player player1 = new L5R.Player(testDynastyDeck, testFateDeck);
            L5R.Player player2 = new L5R.Player(testDynastyDeck, testFateDeck);


            player1.ThePlayArea = this;
            player2.ThePlayArea = this;


           

            player1.getCardsInProvence()[0,0]=testDynastyCard;
            this.myP1.Image = testDynastyCard.CardImage;

            player1.getCardsInProvence()[1,0]=testHolding5;
            this.myP2.Image = testHolding5.CardImage;
            player1.getCardsInProvence()[2,0]=testDynastyCard;
            this.myP3.Image = testDynastyCard.CardImage;
            player1.getCardsInProvence()[3,0]=testHolding6;
            this.myP4.Image = testHolding6.CardImage;

            Console.WriteLine("Number of provances:" + player1.getCardsInProvence().GetLength(0).ToString());

            Console.WriteLine("Creating gamestate");
            this.gs = new GameState.GameState(player1, player2);
        
        }


    }
}
