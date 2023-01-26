# lightning-cards
A flashcard program for quick repetitions (for that day-before studying).

## How to use
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

Note that one side may contain more than two definitions by chaining the usage of the character specified on line 2 (the multiple definitions delimiter). Mostly useful for putting text on multiple lines on a side of the card.
