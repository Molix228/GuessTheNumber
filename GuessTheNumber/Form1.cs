namespace GuessTheNumber
{
    public partial class Form1 : Form
    {

        private int randomNumber;
        private int attempts;
        private int totalGuessed;
        public Form1()
        {
            InitializeComponent();
            StartNewGame();
        }

        private void StartNewGame()
        {
            Random random = new Random();
            randomNumber = random.Next(1, 101);
            attempts = 0;
            textBox1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int userGuess))
            {
                attempts++;

                if  (userGuess < randomNumber)
                {
                    MessageBox.Show("Too Low, try again!");
                }
                else if (userGuess > randomNumber)
                {
                    MessageBox.Show("Too High, try again!");
                }
                else
                {
                    totalGuessed++;
                    MessageBox.Show($"Congratulations!!!\nYou guessed the {randomNumber} number for {attempts} attempts!\nTotal guessed: {totalGuessed}");
                    StartNewGame();
                }
            }
            else
            {
                MessageBox.Show("Please, enter a valid value!");
            }
        }
    }
}
