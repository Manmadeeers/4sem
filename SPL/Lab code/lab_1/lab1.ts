//TASK 1
function transformToPhoneNum(arr:number[]){
    if(arr.length!=10){
        return "Incorrect format";
    }
    let arr_Str:string = arr.join('');
    let code:string = arr_Str.slice(0,3);
    let first_part:string = arr_Str.slice(3,6);
    let sec_part:string = arr_Str.slice(6,10);
    return `(${code})${first_part}-${sec_part}`;
}

console.log(transformToPhoneNum([1,2,3,4,5,6,7,8,9,0]));
console.log(transformToPhoneNum([]));

//TASK 2
class Chalenge{
    static solution(input_number:number){
        if(input_number<0){
            return 0;
        }
        let sum:number = 0;
        for(let i:number=1;i<=input_number;i++){
            if(i%3==0&&i%5==0){
                sum+=i;
                // console.log(i);
            }
            else if(i%3==0&&i%5!=0||i%5==0&&i%3!=0){
                sum+=i;
                // console.log(i);
            }
        }
         return sum;
    }
}

console.log(Chalenge.solution(15));
console.log(Chalenge.solution(72));

//TASK 3

class ArrayReshaper{
    static ReshapeArray(numbers:number[],steps:number){

        let numbers_str:string = numbers.join('');

        if(steps>numbers_str.length){
            return "Can't proceed";
        }

        let moved_part:string = numbers_str.slice(0,steps+1);

        let standing_part:string = numbers_str.slice(steps+1,numbers_str.length);
        return `[${standing_part}${moved_part}]`;
    }
}

console.log(ArrayReshaper.ReshapeArray([123456],3));

//TASK 4


class MedianCounter{
    static CountMedian(nums1:number[],nums2:number[]){
        nums1.sort();
        nums2.sort();
        let result:number[] = nums1.concat(nums2);
        result.sort();
        if(result.length==0){
            return "null";
        }
        if(result.length%2!=0){
            return result[result.length/2];
            
        }
        else{
            return (result[result.length/2]+result[result.length/2-1])/2;
        }
    }
}

console.log(MedianCounter.CountMedian([1,3],[2,4]));