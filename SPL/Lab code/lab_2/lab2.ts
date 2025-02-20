//TASK 1
interface Student {
    id: number;
    name: string;
    group: number;
};
const array: Student[] = [
    { id: 1, name: 'Vasya', group: 10 },
    { id: 2, name: 'Ivan', group: 11 },
    { id: 3, name: 'Masha', group: 12 },
    { id: 4, name: 'Petya', group: 10 },
    { id: 5, name: 'Kira', group: 11 }
];
console.log(array);
//TASK 2
type CarsType = {
    manufacturer?: string;
    model?: string;
}
let car: CarsType = {};
car.manufacturer = "Toyota";
car.model = "Rav4";
console.log(car);
//TASK 3

const car1: CarsType = {};
car1.manufacturer = "Renault";
car1.model = "Kaptur";

const car2: CarsType = {};
car2.manufacturer = "Chevrolet";
car2.model = "Equinox";

type ArrayCarType = {
    cars: CarsType[];
}
const arrayCars: Array<ArrayCarType> = [{
    cars: [car1, car2]
}];
console.log(arrayCars[0].cars[0].manufacturer);

//TASK 4
type MarkFilterType = 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10;
type DoneType = boolean;

type MarkType = {
    subject: string,
    mark: MarkFilterType,
    done: DoneType,
};

type GroupFilterType =  1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 | 11 | 12;

type StudentType = {
    id: number,
    name: string,
    group: GroupFilterType,
    marks: Array<MarkType>,
};

type GroupType = {
    students: Array<StudentType>;
    studentsFilter: (group: number) => Array<StudentType>,
    marksFilter: (mark: number) => Array<StudentType>,
    deleteStudent: (id: number) => void;
    mark: MarkFilterType,
    group: GroupFilterType,
}

let group: GroupType = {
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
    studentsFilter(groupVal:number){
        return this.students.filter(student=>student.group==groupVal);
    },
    marksFilter(markVal:number){
        return this.students.filter(student=>student.marks.some(mark=>mark.mark==markVal));
    },
    deleteStudent(id:number){
        let index:number = this.students.findIndex(student=>student.id==id);
        if(index==-1){
            console.log("Fail");
            return;
        }
        this.students.splice(index,1);
        console.log(`${id} was deleted`);
    },
    mark: 9,
    group: 6,
}

// console.log(group.studentsFilter(6));
// console.log(group.students[0]);
console.group("Filtered by group")
console.log(group.studentsFilter(6));
console.groupEnd();
console.group("Filtered by mark");
console.log(group.marksFilter(8));
console.groupEnd();
console.log(group.deleteStudent(1));
