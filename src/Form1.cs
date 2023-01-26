using System.Collections;

namespace FlashFlashCard
{
    public partial class Form1 : Form
    {
        private CardsList[] cardLists;
        private ArrayList activeCards;
        private bool side1To2;
        private int cardNumber;
        private int rightAnswers;
        private int wrongAnswers;
        private bool stateChanged;
        private Random rng;
        private string directoryPath;

        public Form1()
        {
            InitializeComponent();
            inputButton.Enabled = false;
            CardsList[] cardLists = new CardsList[0];
            activeCards = new ArrayList();
            side1To2 = false;
            stateChanged = false;
            cardNumber = 0;
            rightAnswers = 0;
            wrongAnswers = 0;
            rng = new Random();
            directoryPath = "";
        }

        private void flashFlashCardForm_Load(object sender, EventArgs e)
        {

        }

        private void fileInputButton_Click(object sender, EventArgs e)
        {
            if (fileInput.Text == "") //maybe some error or pop up
                return;
            fileCheckBoxList.Items.Clear();
            if (Directory.Exists(fileInput.Text)) {
                string[] cardListPaths = Directory.GetFiles(fileInput.Text, "*.txt");
                cardLists = new CardsList[cardListPaths.Length];
                string path;
                for (int i = 0; i < cardListPaths.Length; ++i)
                {
                    path = cardListPaths[i];
                    fileCheckBoxList.Items.Add(Path.GetFileName(path));
                    cardLists[i] = new CardsList(System.IO.File.ReadAllText(path), Path.GetFileName(path));
                }
            }
        }

        private void side1Side2Button_Click(object sender, EventArgs e)
        {
            cardNumber = 0;
            rightAnswers = 0;
            wrongAnswers = 0;
            side1To2 = true;
            cardNumberLabel.Text = "Cards answered: 0";
            rightLabel.Text = "Right: 0";
            wrongLabel.Text = "Wrong: 0";
            if(activeCards.Count > 0)
            {
                inputButton.Enabled = true;
                shuffle(activeCards);
                printCard(0, true);
                infoBox.Text = "";
                inputBox.SelectAll();
            }
            else
            {
                outputBox.Text = "The deck is empty";
            }

        }

        private void side2Side1Button_Click(object sender, EventArgs e)
        {
            cardNumber = 0;
            rightAnswers = 0;
            wrongAnswers = 0;
            side1To2 = false;
            cardNumberLabel.Text = "Cards answered: 0";
            rightLabel.Text = "Right: 0";
            wrongLabel.Text = "Wrong: 0";
            if (activeCards.Count > 0)
            {
                inputButton.Enabled = true;
                shuffle(activeCards);
                printCard(0, false);
                infoBox.Text = "";
                inputBox.SelectAll();
            }
            else
            {
                outputBox.Text = "The deck is empty";
            }
        }
        private void inputButton_Click(object sender, EventArgs e)
        {
            if (cardNumber >= activeCards.Count)
                return;

            if(inputBox.Text != "")
            {
                string input = inputBox.Text.Trim().ToLower();
                if (side1To2)
                {
                    if (((Card)activeCards[cardNumber]).Rhs.Contains(input))
                    {
                        rightAnswers++;
                        inputBox.SelectAll();
                        printInfo(cardNumber, side1To2, 0);
                        cardNumber++;
                    }
                    else
                    {
                        wrongAnswers++;
                        inputBox.SelectAll();
                        infoBox.Text = "Wrong answer";
                    }
                   
                }
                else
                {
                    if (((Card)activeCards[cardNumber]).Lhs.Contains(input))
                    {
                        rightAnswers++;
                        inputBox.SelectAll();
                        printInfo(cardNumber, side1To2, 0);
                        cardNumber++;
                    }
                    else
                    {
                        wrongAnswers++;
                        inputBox.SelectAll();
                        infoBox.Text = "Wrong answer";
                    }
                }
            }
            else
            {
                printInfo(cardNumber, side1To2, 1);
                wrongAnswers++;
                cardNumber++;
            }
            cardNumberLabel.Text = "Cards answered: ";
            cardNumberLabel.Text += cardNumber;
            rightLabel.Text = "Right: ";
            rightLabel.Text += rightAnswers;
            wrongLabel.Text = "Wrong: ";
            wrongLabel.Text += wrongAnswers;
            if (cardNumber < activeCards.Count)
                printCard(cardNumber, side1To2);
            else
            {
                outputBox.Text = "No more cards in decks";
                inputButton.Enabled = false;
            }
        }

        private void fileCheckBoxList_ItemCheck(object sender, ItemCheckEventArgs e) //Checked or unchecked a file
        {
            stateChanged = true;
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e) //
        {
            if(tabControl.SelectedIndex == 0 && stateChanged)
            {
                activeCards.Clear();
                foreach(string pathName in fileCheckBoxList.CheckedItems)
                {
                    for(int i = 0; i < cardLists.Length; i++)
                    {
                        if(cardLists[i].listName() == pathName)
                        {
                            activeCards.AddRange(cardLists[i].getCards());
                            break;
                        }
                    }
                }
                inputButton.Enabled = false;
            }
        }
        private void printCard(int number, bool side)
        {
            outputBox.Text = "";
            if (activeCards.Count > 0 && number < activeCards.Count)
            {
                if (side)
                {
                    foreach (string text in ((Card)activeCards[number]).Lhs)
                    {
                        outputBox.Text += text;
                        outputBox.Text += Environment.NewLine;
                    }
                }
                else
                {
                    foreach (string text in ((Card)activeCards[number]).Rhs)
                    {
                        outputBox.Text += text;
                        outputBox.Text += Environment.NewLine;
                    }
                }
            }
        }

        private void printInfo(int number, bool side, int typeOfMessage)
        {
            infoBox.Text = "";
            if (activeCards.Count > 0 && number < activeCards.Count)
            {
                if (typeOfMessage == 0)
                    infoBox.Text = "Right answer!" + Environment.NewLine;
                else if (typeOfMessage == 1)
                    infoBox.Text = "Here's the answer:" + Environment.NewLine;
                string lhs = "";
                string rhs = "";
                foreach (string text in ((Card)activeCards[number]).Lhs)
                {
                    lhs += text;
                    lhs += Environment.NewLine;
                }
                foreach (string text in ((Card)activeCards[number]).Rhs)
                {
                    rhs += text;
                    rhs += Environment.NewLine;
                }
                if (side)
                {
                    infoBox.Text += lhs;
                    infoBox.Text += Environment.NewLine;
                    infoBox.Text += rhs;
                }
                else
                {
                    infoBox.Text += rhs;
                    infoBox.Text += Environment.NewLine;
                    infoBox.Text += lhs;
                }
            }
        }
        private void shuffle(ArrayList input)
        {
            int n = input.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                (input[n], input[k]) = (input[k], input[n]);
            }
        }
    }
}