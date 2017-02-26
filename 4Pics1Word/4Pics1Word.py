
requiredLen = input("Please enter the number of letters: ")
print("The English word you are looking for contains ", requiredLen, " letters")

letterPool = input("Please enter the letters : ")
print("The input letters are: ", letterPool)

# Load in the word list from a dictionary database
with open('words.txt') as f:
    words = f.readlines()

print("There are in total ", len(words), " words in the dictionary.")

for word in words:
    wordToCheck = word[0:-1]
    poolToCheck = letterPool
    if len(wordToCheck) == int(requiredLen):
        found = True
        for elem in wordToCheck:
            index = poolToCheck.find(elem)
            if index == -1:
                found = False
            poolToCheck = poolToCheck[:index] + poolToCheck[index + 1:]
        if found:
            print(wordToCheck)