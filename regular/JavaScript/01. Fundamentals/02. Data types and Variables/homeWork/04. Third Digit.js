function solve(args){
    var _number = args[0];
    //find third digit
    
    var gotoThirdDigit = _number/100;
    //turn to int
    gotoThirdDigit = gotoThirdDigit | 0;
    //get third digit
    var thirdDigit = gotoThirdDigit % 10;

    if(thirdDigit == 7){
        console.log('true');
    }else{
        console.log('false ' + thirdDigit);
    }

    
}