# lightning-cards
A flashcard program for quick repetitions (for that day-before studying).

## How to use
The first tab contains the actual flashcard game.  
Simply start it by choosing either Side 1 to Side 2 or the inverse. Note that the cards are shuffled each time a new game is started.  
If the bottom input is blank when clicking Check, the answer to the card will be displayed (and the program advances to the next card), incrementing the wrong answers.

The second tab contains the loading and choosing of card files. Load them by inputing their parent folder path in the bottom field.



## Card file formats
The program accepts .txt files that are formated as follows:  
- 1st line specifies the delimiting character(s) of the two sides of the card  
- 2nd line specifies the delimiting character(s) for multiple definitions of a side of the card  
- Each line there after contains a single card

An example would be:  
.  
/  
がくせい / gakusei . student

which is a file containing a single card with the side:  
がくせい  
gakusei 

and the side:  
student.

Note that one side may contain more than two definitions by chaining the usage of the character specified on line 2 (the multiple definitions delimiter). Useful for allowing multiple answers to be correct (or for putting text on multiple lines for the card side that is shown).
