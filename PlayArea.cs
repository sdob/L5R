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

            L5R.Card testHolding = new Card();
            L5R.Card testHolding2 = new Card();

            Console.WriteLine("Creating decks");
            List<L5R.Card> testFateDeck = new List<L5R.Card>();
            List<L5R.Card> testDynastyDeck = new List<L5R.Card>();


            testDynastyCard.IsPersonality = true;
            testDynastyCard.BaseForce = 4;
            testDynastyCard.BaseChi = 4;
            testDynastyCard.CardName = "Togashi Satsu";
            testDynastyCard.BaseGoldCost = 8;
            testDynastyCard.BasePersonalHonour = 3;
            testDynastyCard.HonourRequirment = 0;
            testDynastyCard.addAction(new MeleeAttack(8, "Battle:Melee 8 attack"));

            testHolding.IsHolding = true;
            testHolding.CardName = "Small Farm";
            testHolding.BaseGoldCost = 0;

            testHolding2.IsHolding = true;
            testHolding2.CardName = "Remote village";
            testHolding2.BaseGoldCost = 3;

            


            testDynastyDeck.Add(testHolding);
            testDynastyDeck.Add(testHolding2);
            testDynastyDeck.Add(testDynastyCard);
            testFateDeck.Add(testFateCard);

            Console.WriteLine("Creating players");
            L5R.Player player1 = new L5R.Player(testDynastyDeck, testFateDeck);
            L5R.Player player2 = new L5R.Player(testDynastyDeck, testFateDeck);

            

            player1.getCardsInProvence()[0,0]=testDynastyCard;
            player1.getCardsInProvence()[1,0]=testHolding2;
            player1.getCardsInProvence()[2,0]=testDynastyCard;
            player1.getCardsInProvence()[3,0]=testHolding;

            Console.WriteLine("Number of provances:" + player1.getCardsInProvence().GetLength(0).ToString());

            Console.WriteLine("Creating gamestate");
            this.gs = new GameState.GameState(player1, player2);
        
        }


    }
}
