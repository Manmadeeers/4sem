"use strict";
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
var __spreadArray = (this && this.__spreadArray) || function (to, from, pack) {
    if (pack || arguments.length === 2) for (var i = 0, l = from.length, ar; i < l; i++) {
        if (ar || !(i in from)) {
            if (!ar) ar = Array.prototype.slice.call(from, 0, i);
            ar[i] = from[i];
        }
    }
    return to.concat(ar || Array.prototype.slice.call(from));
};
Object.defineProperty(exports, "__esModule", { value: true });
var inspector_1 = require("inspector");
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
inspector_1.console.group("Users");
inspector_1.console.log(guest.getPermissions());
inspector_1.console.log(admin.getPermissions());
inspector_1.console.log(user.getRole());
inspector_1.console.groupEnd();
var HTMLReport = /** @class */ (function () {
    function HTMLReport(title, content) {
        this.title = title;
        this.content = content;
    }
    HTMLReport.prototype.generate = function () {
        return "<h1>".concat(this.title, "</h1><p>").concat(this.content, "</p>");
    };
    return HTMLReport;
}());
var JSONReport = /** @class */ (function () {
    function JSONReport(title, content) {
        this.title = title;
        this.content = content;
    }
    JSONReport.prototype.generate = function () {
        return "{title:".concat(this.title, ",content:").concat(this.content, "}");
    };
    return JSONReport;
}());
inspector_1.console.group("Interface implementation");
var first = new HTMLReport("First report", "REPORT");
inspector_1.console.log(first.generate());
var second = new JSONReport("Second report", "REPORT");
inspector_1.console.log(second.generate());
inspector_1.console.groupEnd();
//TASK 4
function createInstance(cls) {
    var args = [];
    for (var _i = 1; _i < arguments.length; _i++) {
        args[_i - 1] = arguments[_i];
    }
    return new (cls.bind.apply(cls, __spreadArray([void 0], args, false)))();
}
var Product = /** @class */ (function () {
    function Product(name, price) {
        this.name = name;
        this.price = price;
    }
    return Product;
}());
var Prod = createInstance(Product, "Black people", 10);
inspector_1.console.group("Generic function");
inspector_1.console.log(Prod);
inspector_1.console.groupEnd();
//TASK 5
// enum LogLevel{
//     INFO,
//     WARNING,
//     ERROR
// }
// type logEntry = {
//     entry:[date:Date,level:LogLevel,message:string];
// }
// function LogEvent(entry:logEntry){
//   console.log(`[${entry[0]}]`)
// }
// console.group("Tuples");
// let log:logEntry = {entry:[new Date(),LogLevel.INFO,"OK"]};
// LogEvent(log);
// console.groupEnd();
//TASK 3
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
        var _a;
        if (key == null) {
            throw new Error("Key was null");
        }
        if (this.map.has(key)) {
            if (((_a = this.map.get(key)) === null || _a === void 0 ? void 0 : _a.expire_time) == -1) {
                return "expired";
            }
            var entry = this.map.get(key);
            if (!entry || Date.now() > (entry === null || entry === void 0 ? void 0 : entry.expire_time)) {
                this.map.set(key, { value: null, expire_time: -1 });
                return "expired";
            }
            return entry.value;
        }
        else {
            return null;
        }
    };
    Casche.prototype.viewAll = function () {
        inspector_1.console.log(this.map.entries());
    };
    Casche.prototype.clearExpired = function () {
        var _this = this;
        this.map.forEach(function (value, key) {
            if (value.expire_time == -1) {
                _this.map.delete(key);
                inspector_1.console.log("Expired value deleted");
            }
        });
    };
    return Casche;
}());
inspector_1.console.group("Cache");
try {
    var cache_1 = new Casche;
    cache_1.add("Some number", 100, 2000);
    inspector_1.console.log(cache_1.get("Some number"));
    setTimeout(function () { return inspector_1.console.log(cache_1.get("Some number")); }, 2000);
    setTimeout(function () { cache_1.viewAll(); cache_1.clearExpired(); cache_1.viewAll(); }, 2500);
}
catch (_a) {
    inspector_1.console.log(Error.arguments);
}
inspector_1.console.groupEnd();
