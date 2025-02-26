//TASK 1
abstract class BaseUser{
    id:number;
    name:string;
    abstract getRole():string;
    constructor(id:number,name:string){
        this.id = id;
        this.name = name;
    }
}
class Guest extends BaseUser{
    getRole(): string {
        return "Guest";
    }
    permissions:string[] = ["View only"];
    getPermissions():string[]{
        return this.permissions;
    }
}

class User extends BaseUser{
    getRole(): string {
        return "User";
    }
    permissions:string[] = ["View","Comment"];
    getPermissions():string[]{
        return this.permissions;
    }
}

class Admin extends BaseUser{
    getRole(): string {
        return "Admin"
    }
    permissions:string[] = ["View","Comment","Manipulate users","Delete comments"];
    getPermissions():string[]{
        return this.permissions;
    }
}

let guest = new Guest(1,"Anon");
let admin = new Admin(122,"Vova");
let user = new User(4,"Vaclov");
console.group("Users");
console.log(guest.getPermissions());
console.log(admin.getPermissions());
console.log(user.getRole());
console.groupEnd();

//TASK 2

class Casche<K,T>{
    private map:Map<string,{value:T,expire_time:number}> = new Map();

    public add(key:string, value:T,ttl:number):void{
        if(value==null){
            throw new Error("Value was null");
        }
        this.map.set(key,{value:value,expire_time:ttl+Date.now()});
    }
    public get(key:string){
        if(key==null){
            throw new Error("Key was null");
        }
        if(this.map.has(key)){
            const entry = this.map.get(key);
            if(!entry||Date.now()>entry?.expire_time){
                this.map.delete(key);
                return null;
            }
            return entry.value;
        }
        else{
            return null;
        }
    }
    public clearExpired():void{

    }
  
}




console.group("Cache");
try{
    const cache = new Casche<string,number>;
    cache.add("Some number",100,6000);
    console.log(cache.get("Some number"));

    setTimeout(()=>console.log(cache.get("Some number")),6000);
    cache.clearExpired();
}
catch{
    console.log(Error.arguments);
}

console.groupEnd();
