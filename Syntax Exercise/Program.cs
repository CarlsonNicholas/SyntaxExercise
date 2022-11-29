//Syntax Assignment Nick Carlson

//Orginal code

//int answer = 4;
//string response;
//if (answer < 9)
//{
//    response = answer + " is less than nine";
//}
//else
//{
//    response = answer + " is greater than or equal to nine";
//}

// New Code

var answer = 4;
var result = (answer < 9) ? $"{answer} is less than 9" : $"{answer} is more than 9";
Console.WriteLine(result);