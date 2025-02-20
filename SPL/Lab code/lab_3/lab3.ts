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
 
console.log(guest.getPermissions());
console.log(admin.getPermissions());
console.log(user.getRole());

//TASK 2
