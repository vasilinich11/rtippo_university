using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wheelOfFortune
{
    public class GameController
    {
        private WheelOfFortune wheel;
        private Form1 form;

        public GameController(Form1 form)
        {
            this.form = form;
        }

        public void StartGame(int turnsCount)
        {
            wheel = new WheelOfFortune(form, turnsCount);
            Player currentPlayer = wheel.Player;

            form.labelBalance.Text = $"Баланс: {currentPlayer.balance}";
        }

        public void MakeBetOnSector(int sector, int bet, Label label)
        {
            Player currentPlayer = wheel.Player;
            if (!currentPlayer.CanMakeBet(bet))
            {
                form.ShowNotEnoughBalance();
                return;
            }
            currentPlayer.MakeBet(sector, bet);
            form.UpdateBetsUI(currentPlayer.id, currentPlayer.balance, currentPlayer.bets[sector], sector, label);
            return;
        }

        public void StartTurning()
        {
            wheel.wheelIsMoved = true;
            Random rand = new Random();
            wheel.numberOfTwists = rand.Next(50, 100); 
            wheel.wheelTimer.Start();
        }

        public void StartNewGame()
        {
            Application.Restart();
        }

        public void PassTheTurn()
        {
            form.PrepareTurningUI();
        }
    }
}
