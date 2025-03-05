"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
//TASK 1
var prom = new Promise(function (resolve, reject) {
    setTimeout(function () { return resolve((Math.random() * 100).toFixed(0)); }, 1000);
});
prom.then(function (result) { return console.log(result); });
//TASK 2
function previousWithDelay(delay) {
    return new Promise(function (resolve, rejects) {
        setTimeout(function () { return resolve((Math.random() * 100).toFixed(0)); }, delay);
    });
}
Promise.all([previousWithDelay(2000), previousWithDelay(2500), previousWithDelay(3000)]).then(function (result) { return console.log(result); });
//TASK 3
var pr = new Promise(function (res, rej) {
    rej('ku');
});
pr
    .then(function () { return console.log(1); })
    .catch(function () { return console.log(2); })
    .catch(function () { return console.log(3); })
    .then(function () { return console.log(4); })
    .then(function () { return console.log(5); });
