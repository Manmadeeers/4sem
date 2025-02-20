//TASK 1
function transformToPhoneNum(arr) {
    if (arr.length != 10) {
        return "Incorrect format";
    }
    var arr_Str = arr.join('');
    var code = arr_Str.slice(0, 3);
    var first_part = arr_Str.slice(3, 6);
    var sec_part = arr_Str.slice(6, 10);
    return "(".concat(code, ")").concat(first_part, "-").concat(sec_part);
}
console.log(transformToPhoneNum([1, 2, 3, 4, 5, 6, 7, 8, 9, 0]));
console.log(transformToPhoneNum([]));
//TASK 2
var Chalenge = /** @class */ (function () {
    function Chalenge() {
    }
    Chalenge.solution = function (input_number) {
        if (input_number < 0) {
            return 0;
        }
        var sum = 0;
        for (var i = 1; i <= input_number; i++) {
            if (i % 3 == 0 && i % 5 == 0) {
                sum += i;
                // console.log(i);
            }
            else if (i % 3 == 0 && i % 5 != 0 || i % 5 == 0 && i % 3 != 0) {
                sum += i;
                // console.log(i);
            }
        }
        return sum;
    };
    return Chalenge;
}());
console.log(Chalenge.solution(15));
console.log(Chalenge.solution(72));
//TASK 3
var ArrayReshaper = /** @class */ (function () {
    function ArrayReshaper() {
    }
    ArrayReshaper.ReshapeArray = function (numbers, steps) {
        var numbers_str = numbers.join('');
        if (steps > numbers_str.length) {
            return "Can't proceed";
        }
        var moved_part = numbers_str.slice(0, steps + 1);
        var standing_part = numbers_str.slice(steps + 1, numbers_str.length);
        return "[".concat(standing_part).concat(moved_part, "]");
    };
    return ArrayReshaper;
}());
console.log(ArrayReshaper.ReshapeArray([123456], 3));
//TASK 4
var MedianCounter = /** @class */ (function () {
    function MedianCounter() {
    }
    MedianCounter.CountMedian = function (nums1, nums2) {
        nums1.sort();
        nums2.sort();
        var result = nums1.concat(nums2);
        result.sort();
        if (result.length == 0) {
            return "null";
        }
        if (result.length % 2 != 0) {
            return result[result.length / 2 - 0.5];
        }
        else {
            return (result[result.length / 2] + result[result.length / 2 - 1]) / 2;
        }
    };
    return MedianCounter;
}());
console.log(MedianCounter.CountMedian([1, 3], [2, 4]));
console.log(MedianCounter.CountMedian([1, 3], [2]));
