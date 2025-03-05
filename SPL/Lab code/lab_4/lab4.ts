import { rejects } from "assert";
import { Console } from "console";
import { resolve } from "path";

//TASK 1
console.group("Task 1");
let prom = new Promise(function(resolve, reject){
    setTimeout(()=>resolve((Math.random()*100).toFixed(0)),1000);
}); 

prom.then(
    result=>console.log(result)
);
console.groupEnd();
//TASK 2
console.group("Task 2");
function previousWithDelay(delay){
    return new Promise((resolve,rejects)=>{
        setTimeout(()=>resolve((Math.random()*100).toFixed(0)),delay);
    });
}

Promise.all([previousWithDelay(2000),previousWithDelay(2500),previousWithDelay(3000)]).then(result=>console.log(result));
console.groupEnd();
//TASK 3
console.group("Task 3");
let pr = new Promise((res,rej)=>{
    rej('ku');
});


pr
    .then(() => console.log(1))
    .catch(() => console.log(2))
    .catch(() => console.log(3))
    .then(() => console.log(4))
    .then(() => console.log(5))


console.groupEnd();

//TASK 4
let prm = new Promise((res,rej)=>{
    
});