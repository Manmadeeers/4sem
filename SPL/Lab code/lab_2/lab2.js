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
console.log(arrayCars[0].cars[0].manufacturer);
1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 | 11 | 12;
var group = {
    students: [
        { id: 1, name: "Vaclov", group: 6, marks: [{ subject: "Math", mark: 10, done: true }, { subject: "History", mark: 5, done: false }, { subject: "Russian", mark: 2, done: false }] },
        {
            id: 2,
            name: "Petr",
            group: 6,
            marks: [
                { subject: "Math", mark: 8, done: true },
                { subject: "History", mark: 7, done: true },
                { subject: "Russian", mark: 9, done: true }
            ]
        },
        {
            id: 3,
            name: "Gasan",
            group: 6,
            marks: [
                { subject: "Math", mark: 6, done: false },
                { subject: "History", mark: 8, done: true },
                { subject: "Russian", mark: 7, done: false }
            ]
        },
        {
            id: 4,
            name: "Jian-Yang",
            group: 7,
            marks: [
                { subject: "Math", mark: 9, done: true },
                { subject: "History", mark: 6, done: false },
                { subject: "Russian", mark: 8, done: true }
            ]
        },
        {
            id: 5,
            name: "Dinesh",
            group: 8,
            marks: [
                { subject: "Math", mark: 7, done: false },
                { subject: "History", mark: 9, done: true },
                { subject: "Russian", mark: 6, done: true }
            ]
        },
        {
            id: 6,
            name: "Gilfoyl",
            group: 3,
            marks: [
                { subject: "Math", mark: 5, done: true },
                { subject: "History", mark: 7, done: false },
                { subject: "Russian", mark: 9, done: false }
            ]
        },
    ],
    studentsFilter: function (groupVal) {
        return this.students.filter(function (student) { return student.group == groupVal; });
    },
    marksFilter: function (markVal) {
        return this.students.filter(function (student) { return student.marks.some(function (mark) { return mark.mark == markVal; }); });
    },
    deleteStudent: function (id) {
        var index = this.students.findIndex(function (student) { return student.id == id; });
        if (index == -1) {
            console.log("Fail");
            return;
        }
        this.students.splice(index, true);
        console.log("".concat(id, " was deleted"));
    },
    mark: 9,
    group: 6,
};
// console.log(group.studentsFilter(6));
// console.log(group.students[0]);
console.group("Filtered by group");
console.log(group.studentsFilter(6));
console.groupEnd();
console.group("Filtered by mark");
console.log(group.marksFilter(8));
console.groupEnd();
console.log(group.deleteStudent(15));
