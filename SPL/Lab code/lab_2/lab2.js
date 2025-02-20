var _this = this;
;
var array = [
    { id: 1, name: 'Vasya', group: 10 },
    { id: 2, name: 'Ivan', group: 11 },
    { id: 3, name: 'Masha', group: 12 },
    { id: 4, name: 'Petya', group: 10 },
    { id: 5, name: 'Kira', group: 11 }
];
console.log(array);
var car = {};
car.manufacturer = "Toyota";
car.model = "Rav4";
console.log(car);
//TASK 3
var car1 = {};
car1.manufacturer = "Renault";
car1.model = "Kaptur";
var car2 = {};
car2.manufacturer = "Chevrolet";
car2.model = "Equinox";
var arrayCars = [{
        cars: [car1, car2]
    }];
console.log(arrayCars);
1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 | 11 | 12;
var mark = {
    subject: "Math",
    mark: 10,
    done: true,
};
var mark1 = {
    subject: "Science",
    mark: 8,
    done: true,
};
var mark2 = {
    subject: "History",
    mark: 9,
    done: true,
};
var mark3 = {
    subject: "English",
    done: true,
    mark: 7,
};
var mark4 = {
    done: true,
    subject: "Physics",
    mark: 6,
};
var mark5 = {
    subject: "Chemistry",
    mark: 8,
    done: true,
};
var student1 = {
    id: 1,
    name: "Ivan",
    group: 6,
    marks: [mark, mark1, mark2, mark3, mark4],
};
var mark6 = {
    subject: "Biology",
    mark: 9,
    done: true,
};
var mark7 = {
    subject: "Geography",
    mark: 7,
    done: true,
};
var mark8 = {
    subject: "Literature",
    mark: 8,
    done: true,
};
var mark9 = {
    subject: "Computer Science",
    mark: 6,
    done: true,
};
var mark10 = {
    subject: "Art",
    mark: 9,
    done: true,
};
var student2 = {
    id: 2,
    name: "Maria",
    group: 7,
    marks: [mark6, mark7, mark8, mark9, mark10],
};
var Goup = {
    students: [student1, student2],
    studentsFilter: function (groupNumber) {
        return _this.students.filter(function (student) { return student.group === groupNumber; });
    },
    marksFilter: function (markValue) {
        return _this.students.filter(function (student) {
            return student.marks.some(function (mark) { return mark.mark === markValue; });
        });
    },
    deleteStudent: function (id) {
        var index = _this.students.findIndex(function (student) { return student.id === id; });
        if (index === -1)
            return;
        _this.students.splice(index, 1);
    },
    mark: 8,
    group: 6
};
console.log(Goup.studentsFilter(6));
