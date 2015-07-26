console.log("Problem1");
var array = [];
for (var i = 1; i <= 1000; i++) {
    array.push(i);
}
 var sum =0;
for (key in array) {
    if (key % 5 === 0 || key%3===0) {
        sum +=parseInt(key);
    }
}
console.log("The sum of numbers is :" + sum);
