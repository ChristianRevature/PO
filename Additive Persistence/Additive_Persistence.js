//AP
var number;
var AP = 0;
var MP = 0;


Integerize = function (){
    //takes any number input and converts it to an integer
    let integerized = document.getElementById("APInput");
    inputNumber = parseInt(integerized);
    console.log(typeof inputNumber);
}

function FindAP(number){


    //Check if number <10. If so, AP = 0
    if(number <10 && number >0){
        AP = 0;
        console.log('The AP is ${AP}');
    }
    else{
    //if the sum is less than 10, add 1 to AP finish and print the sum
        ArraySum(number);
    }
  
    //else, keep turning into character array and summing values 
}

function ArraySum(number){
    let sum = 0;
    //turn number into a character array
    numArray = Array.from(Number(number), Number);
    //sum the values of the character array
    for(let i = 0; i < numArray.length-1; i++ ){
        sum += charArray[i];
        return sum; 
    }
}
//MP

MPfunc =function(){
    console.log("this is the MP funciton");
}