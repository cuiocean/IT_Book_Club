#!/usr/bin/python

# Get the required number of letters
lengthOfWord = input("How long is the word you're looking for: ")

# Get the  
inputLetters = input("Please enter the letters : ")


# Load in the word list from a dictionary database
with open('words.txt') as f:
	words = f.readlines()

print("Possible answers for: ", inputLetters)

for word in words:
	# Remove the escape character from the end of the word
	wordToCheck = word[0:-1]
	remainingLetters = inputLetters
	if len(wordToCheck) == int(lengthOfWord):
		found = True
		for letter in wordToCheck:
			index = remainingLetters.find(letter)
			if index == -1:
				found = False
				break
			remainingLetters = remainingLetters[:index] + remainingLetters[index + 1:]
		if found:
			print(wordToCheck)