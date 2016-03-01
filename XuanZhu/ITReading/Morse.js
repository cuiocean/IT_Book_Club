//global variable
	var wordsArray;
	var wordMorse =  new Array();
	var wordMorseSort = new Array();
	var wordWinnerDash = new Array();
	var wordWinnerDot = new Array();
	
function generateValue(raw) {
	var value;
	switch(raw){
		case "a":
		  value = "01";
		  break;
		case "b":
		  value = "1000";
		  break;		  
		case "c":
		  value = "1010";
		  break;		  
		case "d":
		  value = "100";
		  break;		  
		case "e":
		  value = "0";
		  break;		  
		case "f":
		  value = "0010";
		  break;		  
		case "g":
		  value = "110";
		  break;		  
		case "h":
		  value = "0000";
		  break;		  
		case "i":
		  value = "00";
		  break;		  
		case "j":
		  value = "0111";
		  break;		  
		case "k":
		  value = "101";
		  break;		  
		case "l":
		  value = "0100";
		  break;		  
		case "m":
		  value = "11";
		  break;		  
		case "n":
		  value = "10";
		  break;		  
		case "o":
		  value = "111";
		  break;		  
		case "p":
		  value = "0110";
		  break;		  
		case "q":
		  value = "1101";
		  break;		  
		case "r":
		  value = "010";
		  break;		  
		case "s":
		  value = "000";
		  break;		  
		case "t":
		  value = "1";
		  break;		  
		case "u":
		  value = "001";
		  break;
		case "v":
		  value = "0001";
		  break;		  
		case "w":
		  value = "011";
		  break;		  
		case "x":
		  value = "1001";
		  break;		  
		case "y":
		  value = "1011";
		  break;		  
		case "z":
		  value = "1100";
		  break;		
		case "\'":
		  value = "011110";
		  break;			  
		default:
		  value="";
	}
		return value;
		
}
function readTextFile(file)
{
    var rawFile = new XMLHttpRequest();
	var allText;
    rawFile.open("GET", file, false);
    rawFile.onreadystatechange = function ()
    {
        if(rawFile.readyState === 4)
        {
            if(rawFile.status === 200 || rawFile.status == 0)
            {
                allText = rawFile.responseText.toLowerCase();
				wordsArray = allText.split("\n");
            }
        }
    }
    rawFile.send(null);
}
function calculateword(word){
	var wordValue="";
	var tester="";
	if(word != null){
		for(var i=0;i<word.length;i++){
		  for(var j=0; j<word[i].length;j++){
			  wordValue += generateValue(word[i][j]);
		  }
			  wordMorse[i]=wordValue;
			  wordMorseSort[i]=wordValue;
			  wordValue ="";
		}
	 var longest = wordMorseSort.sort(function (a, b) { return b.length - a.length; })[0];
	 var longestlength = longest.length;	
		document.write("Longest DASH Winner:"+"<br>");		
			for(var v=longestlength;v>0;v--){
				tester=Array(v).join("1");
			for(var z=0;z<wordMorse.length;z++){
			  if(wordMorse[z].indexOf(tester)>-1){
				  wordWinnerDash.push([z,wordMorse[z]]);
			  document.write(wordsArray[z]+"<br>");
			  }
			  }
			  if(wordWinnerDash.length != 0){
				  break;
			  }
		}
		
		document.write("Longest DOT Winner:"+"<br>");
			for(var v=longestlength;v>0;v--){
				tester=Array(v).join("0");
			for(var z=0;z<wordMorse.length;z++){
			  if(wordMorse[z].indexOf(tester)>-1){
				  wordWinnerDot.push([z,wordMorse[z]]);
			  document.write(wordsArray[z]+"<br>");
			  }
			  }
			  if(wordWinnerDot.length != 0){
				  break;
			  }
		}
	}
}
function run(){
	readTextFile("/ITReading/words.txt");
	calculateword(wordsArray);
}