/* Task Description */
/* 
	Write a function that sums an array of numbers:
		numbers must be always of type Number
		returns `null` if the array is empty
		throws Error if the parameter is not passed (undefined)
		throws if any of the elements is not convertible to Number	

*/

function solve(numbers) {
	return function sum() {
		let sum = 0;
		
			if (!Array.isArray(numbers)) {
				throw Error('function works with arrays only')
			}
		
			// for (let num of numbers) {
			// 	sum += num;
			// }

			return numbers.reduce(function(s,n){return s+n;},0)
		
			//return sum;
			console.log(sum);
	}
}

module.exports = solve;
