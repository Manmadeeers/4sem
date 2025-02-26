var __extends = (this && this.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (Object.prototype.hasOwnProperty.call(b, p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
    return function (d, b) {
        if (typeof b !== "function" && b !== null)
            throw new TypeError("Class extends value " + String(b) + " is not a constructor or null");
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
//TASK 1
var BaseUser = /** @class */ (function () {
    function BaseUser(id, name) {
        this.id = id;
        this.name = name;
    }
    return BaseUser;
}());
var Guest = /** @class */ (function (_super) {
    __extends(Guest, _super);
    function Guest() {
        var _this = _super !== null && _super.apply(this, arguments) || this;
        _this.permissions = ["View only"];
        return _this;
    }
    Guest.prototype.getRole = function () {
        return "Guest";
    };
    Guest.prototype.getPermissions = function () {
        return this.permissions;
    };
    return Guest;
}(BaseUser));
var User = /** @class */ (function (_super) {
    __extends(User, _super);
    function User() {
        var _this = _super !== null && _super.apply(this, arguments) || this;
        _this.permissions = ["View", "Comment"];
        return _this;
    }
    User.prototype.getRole = function () {
        return "User";
    };
    User.prototype.getPermissions = function () {
        return this.permissions;
    };
    return User;
}(BaseUser));
var Admin = /** @class */ (function (_super) {
    __extends(Admin, _super);
    function Admin() {
        var _this = _super !== null && _super.apply(this, arguments) || this;
        _this.permissions = ["View", "Comment", "Manipulate users", "Delete comments"];
        return _this;
    }
    Admin.prototype.getRole = function () {
        return "Admin";
    };
    Admin.prototype.getPermissions = function () {
        return this.permissions;
    };
    return Admin;
}(BaseUser));
var guest = new Guest(1, "Anon");
var admin = new Admin(122, "Vova");
var user = new User(4, "Vaclov");
console.group("Users");
console.log(guest.getPermissions());
console.log(admin.getPermissions());
console.log(user.getRole());
console.groupEnd();
//TASK 2
var Casche = /** @class */ (function () {
    function Casche() {
        this.map = new Map();
    }
    Casche.prototype.add = function (key, value, ttl) {
        if (value == null) {
            throw new Error("Value was null");
        }
        this.map.set(key, { value: value, expire_time: ttl + Date.now() });
    };
    Casche.prototype.get = function (key) {
        if (key == null) {
            throw new Error("Key was null");
        }
        if (this.map.has(key)) {
            var entry = this.map.get(key);
            if (!entry || Date.now() > (entry === null || entry === void 0 ? void 0 : entry.expire_time)) {
                this.map.delete(key);
                return null;
            }
            return entry.value;
        }
        else {
            return null;
        }
    };
    Casche.prototype.clearExpired = function () {
    };
    return Casche;
}());
console.group("Cache");
try {
    var cache_1 = new Casche;
    cache_1.add("Some number", 100, 6000);
    console.log(cache_1.get("Some number"));
    setTimeout(function () { return console.log(cache_1.get("Some number")); }, 6000);
}
catch (_a) {
    console.log(Error.arguments);
}
console.groupEnd();
