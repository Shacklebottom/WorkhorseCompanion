namespace CompanionDomain.Objects
{
    public static class Determination
    {
        private static readonly List<string> Conviction =
        [
            "\"It does not matter how slowly you go as long as you do not stop.\" - Confucius",
            "\"Perseverance is not a long race; it is many short races one after the other.\" - Walter Elliot",
            "\"Success is walking from failure to failure with no loss of enthusiasm.\" - Winston Churchill",
            "\"Courage is not having the strength to go on; it is going on when you don't have the strength.\" - Theodore Roosevelt",
            "\"I am not afraid of storms, for I am learning how to sail my ship.\" - Louisa May Alcott",
            "\"Quality is not an act, it is a habit\" - Aristotle",
            "\"If you can\'t explain it simply, you don\'t understand it well enough.\" - Albert Einstein",
            "\"Any sufficiently advanced technology is indistinguishable from magic\" - Arthur C. Clarke",
            "\"I love watching him think,\" Maeve told Lily. \"You can almost hear that poor little hamster running and running on its wheel.\" - Jim Butcher, Cold Days",
            "\"You can't plan for everything or you never get started in the first place.\" - Jim Butcher, Changes",
            "\"Wizards and computers get along about as well as flamethrowers and libraries\" - Jim Butcher, Changes",
            "\"Knowledge is the ultimate weapon. It always has been\" -Jim Butcher, White Night",
        ];

        public static string GetQuote()
        {
            var random = new Random().Next(0, Conviction.Count);

            return Conviction[random];
        }
    }
}
