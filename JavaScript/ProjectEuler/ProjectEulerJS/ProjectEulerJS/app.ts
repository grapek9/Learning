/*console.log('Project Euler Problem1');
var sum = 0;
var i = 0;
for (i = 1; i < 1000; i++) {
    if (i % 3 === 0 || i%5===0) {
        sum += i;
    }
}
console.log('Result :'+sum);*/

console.log('Project Euler Problem 2');
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
console.log('Result ='+sum)