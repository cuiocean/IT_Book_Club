# re for regular expression
import re 

# Define Morse code
morseAlphabet ={
        "A" : ".-",
        "B" : "-...",
        "C" : "-.-.",
        "D" : "-..",
        "E" : ".",
        "F" : "..-.",
        "G" : "--.",
        "H" : "....",
        "I" : "..",
        "J" : ".---",
        "K" : "-.-",
        "L" : ".-..",
        "M" : "--",
        "N" : "-.",
        "O" : "---",
        "P" : ".--.",
        "Q" : "--.-",
        "R" : ".-.",
        "S" : "...",
        "T" : "-",
        "U" : "..-",
        "V" : "...-",
        "W" : ".--",
        "X" : "-..-",
        "Y" : "-.--",
        "Z" : "--..",
        " " : "/"
        }

     
#encode a message in morse code
def encodeToMorse(message):
    encodedMessage = ""
    for char in message[:]:
		if char.isalpha():
			encodedMessage += morseAlphabet[char.upper()]           
    return encodedMessage


def longestRepeatedCharLen( word, char ):	
	longest = 0
	for item in re.findall('%s+' % char, word):
		length = len(item)
		if length > longest:
			longest = length
	return longest
	
# Load in the word list from a dictionary database	
with open('words.txt') as f:
	words = f.readlines();

# Creat two dictionaries to store the dotLength and dashLength
dotLengthDict={}
dashLengthDict={}	
for word in words:
	morseCode= encodeToMorse(word[0:len(word)-1])
 
	# . is a special character in re, so replace it with a
	morseCodeTemp=morseCode.replace(".", 'a')
	dotLen = longestRepeatedCharLen( morseCodeTemp, 'a')
	dotLengthDict[ word ] = dotLen
	 
	dashLen = longestRepeatedCharLen( morseCodeTemp, '-')
	dashLengthDict[word] = dashLen
	 
print(" The word(s) that contains the longest repeated dot are:")
maxx = max(dotLengthDict.values())
keys = [x for x,y in dotLengthDict.items() if y ==maxx] 
for key in keys:
	print key

print("\n")

print(" The word(s) that contains the longest repeated dash are:")
maxx = max(dashLengthDict.values())
keys = [x for x,y in dashLengthDict.items() if y ==maxx] 
for key in keys:
	print key
		
		
 
	 