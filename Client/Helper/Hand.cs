namespace RockPaperAndScissors.Client.Helper
{
    public class Hand
    {
        //what the user chose
        public OptionRPS Selection { get; set; }
        //what the user wingsagainst
        public OptionRPS WinsAgainst { get; set; }
        //what the user losses against
        public OptionRPS LosesAgainst { get; set; }

        public String Image {  get; set; }
        public GameStatus PlayAgaint(Hand opponentHand)
        {
            if(Selection == opponentHand.Selection)
            {
                return GameStatus.Draw;
            }
            if(LosesAgainst == opponentHand.Selection)
            {
                return GameStatus.Loss;
            }
            return GameStatus.Victory;
        }
    }
}
