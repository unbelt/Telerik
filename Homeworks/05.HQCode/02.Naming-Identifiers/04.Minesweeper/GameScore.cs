namespace Minesweeper
{
    public class GameScore
    {
        private string playerName;
        private int playerScore;

        public GameScore(string playerName, int playerScore)
        {
            this.playerName = playerName;
            this.playerScore = playerScore;
        }

        public string PlayerName
        {
            get { return this.playerName; }
            set { this.playerName = value; }
        }

        public int PlayerScore
        {
            get { return this.playerScore; }
            set { this.playerScore = value; }
        }
    }
}
