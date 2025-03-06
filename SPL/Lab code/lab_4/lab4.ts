import { rejects } from "assert";
import { Console } from "console";
import { resolve } from "path";

//TASK 1

let prom = new Promise(function (resolve, reject) {
    setTimeout(() => resolve((Math.random() * 100).toFixed(0)), 1000);
});
//TASK 2

function previousWithDelay(delay) {

    return new Promise((resolve, rejects) => {
        setTimeout(() => resolve((Math.random() * 100).toFixed(0)), delay);
        console.groupEnd();
    });
}


//TASK 3

let pr = new Promise((res, rej) => {
    rej('ku');
});



//TASK 4
let prm = new Promise((resolve, reject) => {
    setTimeout(() => resolve(21), 1000);
});



async function Executer() {
    const result1 = await prom.then(
        result => {
            console.group("Task 1");
            console.log(result)
            console.groupEnd();
        }
    );

    const result2 = await Promise.all([previousWithDelay(2000), previousWithDelay(2500), previousWithDelay(3000)]).then(result => {
        console.group("Task2");
        console.log(result);
        console.groupEnd();
    }
    );

    const result3 = await pr
    .catch(()=>console.log(0))
    .then(() => console.log(1))
    .catch(() => console.log(2))
    .catch(() => console.log(3))
    .then(() => console.log(4))
    .then(() => console.log(5))



    const result4 = await prm.then(function (result: unknown) {
        console.group("Task 4");
        console.log(result);
        if (typeof (result) == 'number') {
            return new Promise((resolve, reject) => setTimeout(() => resolve(result * 2), 1000))
        }

    }).then(function (result) {
        console.groupEnd();
        console.log(result);
        console.groupEnd();
    })
}
Executer();