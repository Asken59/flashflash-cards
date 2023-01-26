using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashFlashCard
{
    internal class CardsList
    {
        private string cardDelimiter = "";
        private string orDelimiter = "";
        private string unformatedCards = "";
        private ArrayList formattedCards;
        private string name = "";
        public CardsList(string input, string inputName)
        {
            name = inputName;
            var reader = new StringReader(input);
            if(reader.Peek() == -1)
                throw new Exception();
            else
                cardDelimiter = reader.ReadLine();
            if(reader.Peek() == -1)
                throw new Exception();
            else
                orDelimiter = reader.ReadLine();
            unformatedCards = reader.ReadToEnd();
            reader.Close();
            formattedCards = new ArrayList();
            reader = new StringReader(unformatedCards);
            string lineRead = "";
            while(reader.Peek() != -1)
            {
                lineRead = reader.ReadLine();
                if (lineRead == null)
                    lineRead = "";
                string[] splitString = lineRead.Split(cardDelimiter);
                string[] lhsText = splitString[0].Split(orDelimiter, StringSplitOptions.RemoveEmptyEntries);
                string[] rhsText = splitString[1].Split(orDelimiter, StringSplitOptions.RemoveEmptyEntries);
                for(int i = 0; i < lhsText.Length; i++)
                {
                    lhsText[i] = lhsText[i].Trim().ToLower();
                }
                for (int i = 0; i < rhsText.Length; i++)
                {
                    rhsText[i] = rhsText[i].Trim().ToLower();
                }
                formattedCards.Add(new Card(lhsText, rhsText));
            }
        }

        public Card[] getCards()
        {
            return (Card[])formattedCards.ToArray(typeof(Card)); 
        }

        public string listName()
        {
            return name;
        }


    }
}
