//TASK 1
interface Student{
    id:number;
    name:string;
    group:number;
};
const array:Student[] = [
    {id:1,name:'Vasya',group:10},
    {id:2,name:'Ivan',group:11},
    {id:3,name:'Masha',group:12},
    {id:4,name:'Petya',group:10},
    {id:5,name:'Kira',group:11}
];
console.log(array);
//TASK 2
type CarsType = {
    manufacturer?:string;
    model?:string;
}
let car:CarsType ={};
car.manufacturer = "Toyota";
car.model = "Rav4";
console.log(car);
//TASK 3

const car1:CarsType = {};
car1.manufacturer = "Renault";
car1.model = "Kaptur";

const car2:CarsType = {};
car2.manufacturer = "Chevrolet";
car2.model = "Equinox";

type ArrayCarType = {
    cars:CarsType[];
}
const arrayCars:Array<ArrayCarType> = [{
    cars:[car1,car2]
}];
console.log(arrayCars);

//TASK 4
type MarkFilterType = 1|2|3|4|5|6|7|8|9|10;
type DoneType = boolean;

type MarkType = {
    subject:string,
    mark:MarkFilterType,
    done:DoneType,
};

type GroupFilterType =number; 1|2|3|4|5|6|7|8|9|10|11|12;

type StudentType = {
    id:number,
    name:string,
    group:GroupFilterType,
    marks:Array<MarkType>,
};

type GroupType = {
    students:Array<StudentType>;
    studentsFilter:(group:number)=>Array<StudentType>,
    marksFilter:(mark:number)=>Array<StudentType>,
    deleteStudent:(id:number)=>void;
    mark:MarkFilterType,
    group:GroupFilterType,
}

let mark:MarkType = {
    subject:"Math",
    mark:10,
    done:true,
}
let mark1: MarkType = {
    subject: "Science",
    mark: 8,
    done: true,
}

let mark2: MarkType = {
    subject: "History",
    mark: 9,
    done: true,
}

let mark3: MarkType = {
    subject: "English",
    done: true,
    mark: 7,
}

let mark4: MarkType = {
    done: true,
    subject: "Physics",
    mark: 6,
}

let mark5: MarkType = {
    subject: "Chemistry",
    mark: 8,
    done: true,
}

let student1:StudentType = {
    id:1,
    name:"Ivan",
    group:6,
    marks:[mark,mark1,mark2,mark3,mark4],
};

let mark6: MarkType = {
    subject: "Biology",
    mark: 9,
    done: true,
}

let mark7: MarkType = {
    subject: "Geography",
    mark: 7,
    done: true,
}

let mark8: MarkType = {
    subject: "Literature",
    mark: 8,
    done: true,
}

let mark9: MarkType = {
    subject: "Computer Science",
    mark: 6,
    done: true,
}

let mark10: MarkType = {
    subject: "Art",
    mark: 9,
    done: true,
}

let student2: StudentType = {
    id: 2,
    name: "Maria",
    group: 7,
    marks: [mark6, mark7, mark8, mark9, mark10],
};


let Goup:GroupType = {
        students:[student1,student2],
        studentsFilter: (groupNumber: number) => {
            return this.students.filter(student => student.group === groupNumber);
        },
        marksFilter:(markValue:number)=>{
            return this.students.filter(student => 
                student.marks.some(mark => mark.mark === markValue)
            );
        },
        deleteStudent:(id:number)=>{
            const index = this.students.findIndex(student => student.id === id);
            if (index === -1) return;
            
            this.students.splice(index, 1);
        },
        mark:8,
        group:6
};

console.log(Goup.studentsFilter(6));