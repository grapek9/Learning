console.log('Project Euler Problem1');
var sum = 0;
var i = 0;
for (i = 1; i < 1000; i++) {
    if (i % 3 === 0 || i % 5 === 0) {
        sum += i;
    }
}
console.log('Result :' + sum);
//# sourceMappingURL=app.js.map