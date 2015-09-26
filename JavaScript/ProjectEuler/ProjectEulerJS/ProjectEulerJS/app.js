/*console.log('Project Euler Problem1');
var sum = 0;
var i = 0;
for (i = 1; i < 1000; i++) {
    if (i % 3 === 0 || i%5===0) {
        sum += i;
    }
}
console.log('Result :'+sum);*/
/*console.log('Project Euler Problem 2');
var firstArg = 1;
var secondArg = 1;
var temp = 0;
var sum = 0;
while (secondArg < 4000000) {
    temp = secondArg;
    secondArg = firstArg + secondArg;
    firstArg = temp;
    (secondArg % 2 === 0) ? sum += secondArg : sum+=0;
}
console.log('Result ='+sum);*/
/*console.log('Project Euler Problem 3');
function isPrime(value) {
    for (var i = 2; i < value; i++) {
        if (value % i === 0) {
            return false;
            }
        }
    return true;
    }
var value = 600851475143;
var max = 0;
var factor = 1;
while (value != 1) {
    factor++;
    if (value % factor === 0) {
        if (isPrime(factor) === true) {
            max = factor;
            value = value / factor;
            }
        }
}
console.log('Result = '+max)*/
/*console.log("Project Euler Problem 4");
function isPalindrome(value) {
    for (var i = 0; i < value.length; i++) {
        if (value.charAt(i) != value.charAt(value.length-1-i)) {
            return false;
        }
    }
    return true;
}
var value = 0;
for (var i = 100; i < 1000; i++) {
    for (var j = 100; j < 1000; j++) {
        if (isPalindrome((i * j).toString()) === true) {
            if ((i * j) > value) {
                value = i * j;
                }
            }
        }
    }
console.log('Result = '+value)*/
/*console.log("Project Euler Problem 6 "); // posted as problem nr5 (mistake)
function sumOfSquares(number) {
    var output = 0;
    for (var i = 1; i <= number; i++) {
        output += square(i);
    }
    return output;
}
function squareOfsum(number) {
    var output = 0;
    for (var i = 1; i <= number; i++) {
        output += i;
    }
    return square(output);
}
function square(number) {
    return number * number;
}
var value = 20;
console.log(squareOfsum(value) - sumOfSquares(value));*/
/*console.log("Project Euler Problem 7");
function isPrime(number) {
    for (var i = 2; i < Math.round(number / 2)+1; i++) {
        if (number % i === 0) {
            return false;}
    }
    return true;
}
var listOfPrimes = []
var iterator = 1;
while (listOfPrimes.length < 10002) {
    iterator++;
    if (isPrime(iterator) === true) {
        listOfPrimes.push(iterator);
        }
}
console.log(listOfPrimes[10001]);*/
/*console.log("Project Euler Problem 10");
function isPrime(number) {
    for (var i = 2; i < Math.round(number / 2)+1; i++) {
        if (number % i === 0) {
            return false;
        }
    }
    return true;
}

var sum = 0;
for (var i = 2; i < 2000000; i++) {
    if (isPrime(i) === true) { sum += i; console.log(i); }
}
console.log(sum)*/
/*console.log("Project Euler Problem 15");
function factorial(number) {
    if (number === 1) return 1;
    return number * factorial(number - 1);
}
var gridSize = 20;
var moves = gridSize * 2;
console.log(factorial(moves) / (factorial(gridSize) * factorial(moves - gridSize)));*/
/*console.log("Project Euler Problem 16");
function sumator(value) {
    var sum = 0;
    for (var i = 0; i < value.length; i++) {
        sum += parseInt(value.charAt(i));
    }
    return sum;
}
var value = Math.pow(2, 1000);
console.log("Value "+value);
var sum = sumator(String(value));
console.log("Sum :" + sum);*/
/*console.log("Project Euler Problem 20");
function factorial(value) {
    if (value === 1) return 1;
    return value * factorial(value - 1);
}
function sumator(value) {
    var sum = 0;
    for (var i = 0; i < value.length; i++) {
        sum += parseInt(value.charAt(i));
    }
    return sum;
}
console.log(sumator(String(factorial(10))));*/
/*console.log("Project Euler Problem 30 ");
function isSumOfFifthEqualToValue(value) {
    var sum = 0;
    var numberAsString = String(value);
    for (var i = 0; i < numberAsString.length; i++) {
        sum += power(parseInt(numberAsString.charAt(i)));
    }
    if (sum === value) {
        return true;
    } else {
        return false;
    }
}
function power(value) {
    return Math.pow(value, 5);
}
var sum = 0;
for (var i = 1; i <= 1000000; i++) {
    if (i % 10000 === 0) { console.log(i/10000+"%");}
    if (isSumOfFifthEqualToValue(i) === true) {
        sum += i;
    }
}
console.log(sum);*/
console.log("Project Euler Problem 36");
function isPalindrome(value) {
    for (var i = 0; i < value.length; i++) {
        if (value.charAt(i) != value.charAt(value.length - 1 - i)) {
            return false;
        }
    }
    return true;
}
function toBin(value) {
    var binValue = "";
    while (value != 0) {
        if (value % 2 === 0) {
            binValue += "0";
        }
        else {
            binValue += "1";
        }
        value = Math.floor(value / 2);
    }
    return reverse(binValue);
}
function reverse(value) {
    var reversedString = "";
    for (var i = 0; i <= value.length; i++) {
        reversedString += value.charAt(value.length - i);
    }
    return reversedString;
}
var sum = 0;
for (var i = 1; i < 1000001; i++) {
    if (isPalindrome(i.toString()) === true && isPalindrome(toBin(i)) === true) {
        sum += i;
    }
    if (i % 10000 === 0) {
        console.log(i / 10000 + "%");
    }
}
console.log(sum);
//# sourceMappingURL=app.js.map