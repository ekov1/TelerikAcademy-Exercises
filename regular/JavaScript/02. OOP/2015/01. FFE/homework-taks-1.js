/* Task 1 */
/* 
	Write a function that sums an array of numbers:
		numbers must be always of type Number
		returns `null` if the array is empty
		throws Error if the parameter is not passed (undefined)
		throws if any of the elements is not convertible to Number	
*/

function sumArray(arr) {
    let sum = 0;

    if (!Array.isArray(arr)) {
        throw Error('function works with arrays only')
    }

    for (let num of arr) {
        sum += num;
    }

    return sum;
}

//sumArray('x');

console.log(sumArray([1,2]));