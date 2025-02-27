
//TASK 1
abstract class BaseUser {
    id: number;
    name: string;
    abstract getRole(): string;
    constructor(id: number, name: string) {
        this.id = id;
        this.name = name;
    }
}
class Guest extends BaseUser {
    getRole(): string {
        return "Guest";
    }
    permissions: string[] = ["View only"];
    getPermissions(): string[] {
        return this.permissions;
    }
}

class User extends BaseUser {
    getRole(): string {
        return "User";
    }
    permissions: string[] = ["View", "Comment"];
    getPermissions(): string[] {
        return this.permissions;
    }
}

class Admin extends BaseUser {
    getRole(): string {
        return "Admin"
    }
    permissions: string[] = ["View", "Comment", "Manipulate users", "Delete comments"];
    getPermissions(): string[] {
        return this.permissions;
    }
}

let guest = new Guest(1, "Anon");
let admin = new Admin(122, "Vova");
let user = new User(4, "Vaclov");
console.group("Users");
console.log(guest.getPermissions());
console.log(admin.getPermissions());
console.log(user.getRole());
console.groupEnd();

//TASK 2

interface IReport{
    title:string;
    content:string;
    generate():string|object;
}

class HTMLReport implements IReport{
    title: string;
    content: string;
    constructor(title:string,content:string){
        this.title = title;
        this.content = content;
    }
    generate(): string {
        return `<h1>${this.title}</h1><p>${this.content}</p>`;
    }
}

class JSONReport implements IReport{
    title: string;
    content: string;
    constructor(title:string,content:string){
        this.title = title;
        this.content = content;
    }
    generate(): object {
            return {title:this.title,content:this.content};
    }
}

console.group("Interface implementation");
const first = new HTMLReport("First report","REPORT");
console.log(first.generate());
const second = new JSONReport("Second report","REPORT");
console.log(second.generate());
console.groupEnd();



//TASK 4

function createInstance<T>(cls:new(...args:any[])=>T,...args:any[]):T{
    return new cls(...args);
}

class Product{
    name:string;
    price:number;
    constructor(name:string, price:number){
        this.name = name;
        this.price = price;
    }
}
const Prod = createInstance(Product,"BSTU FIT Student",10);

console.group("Generic function");
console.log(Prod);
console.groupEnd();


//TASK 5
enum LogLevel{
    INFO,
    WARNING,
    ERROR
}
type logEntry = {
    enty:[date:Date,level:LogLevel,message:string];
}

function LogEvent(entr:logEntry){
  console.log(`[${entr.enty[0]},${entr.enty[1]},${entr.enty[2]}]`)
}

console.group("Tuples");
let loggg:logEntry = {enty:[new Date(),LogLevel.INFO,"OK"]};
LogEvent(loggg);
console.groupEnd();

//TASK 6

enum HTTPStatus{
    OK,//200
    Bad_Request,//400
    Unauthorized,//401
    Internal_Server_Error,//500
}
type APIResponse<T> = {
    Response?:[status:HTTPStatus,data:T|null,error?:string];
}
function succsess<K>(K):APIResponse<K>{
    let value_to_return:APIResponse<K> = {
        Response:[HTTPStatus.OK,K],
    }
    return value_to_return;
}
function error<T>(message:string,status:HTTPStatus):APIResponse<null>{
    let value_to_return:APIResponse<null> = {
        Response:[status,null,message],
    }
    return value_to_return;
}

let res1 = succsess({user:"USERNAME"});
let res2 = error("Internal Server Error",HTTPStatus.Internal_Server_Error);
console.group("API Response");
console.log(res1);
console.log(res2);
console.groupEnd();




//TASK 3

class Casche<T> {
    private map: Map<string, { value: T | null, expire_time: number }> = new Map();

    public add(key: string, value: T, ttl: number): void {
        if (value == null) {
            throw new Error("Value was null");
        }
        this.map.set(key, { value: value, expire_time: ttl + Date.now() });
    }
    public get(key: string) {
        if (key == null) {
            throw new Error("Key was null");
        }

        if (this.map.has(key)) {
            if (this.map.get(key)?.expire_time == -1) {
                return "expired";
            }
            const entry = this.map.get(key);
            if (!entry || Date.now() > entry?.expire_time) {
                this.map.set(key, { value: null, expire_time: -1 });
                return "expired";
            }
            return entry.value;
        }
        else {
            return null;
        }
    }
    public viewAll(): void {
        console.log(this.map.entries());
    }
    public clearExpired(): void {
        this.map.forEach((value: { value: T | null, expire_time: number }, key: string) => {
            if (value.expire_time == -1) {
                this.map.delete(key); console.log("Expired value deleted")

            }
        })
    }

}




console.group("Cache");

try {
    const cache = new Casche<number>;
    cache.add("Some number", 100, 2000);
    console.log(cache.get("Some number"));

    setTimeout(() => console.log(cache.get("Some number")), 2000);
    
    setTimeout(() => { cache.viewAll(); cache.clearExpired(); cache.viewAll(); }, 2500);
}
catch {
    console.log(Error.arguments);
}

console.groupEnd();

