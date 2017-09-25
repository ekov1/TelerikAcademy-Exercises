'use strict';

console.log();
console.log('Start');
console.log();

const numAsString = '1234';
console.log('numAsString = 1234');

console.log();
console.log('parseInt(1234) + 1 = ' + (parseInt(numAsString) + 1));
console.log('parseFloat(1234) + 1 = ' + parseFloat(numAsString) + 1);
console.log('+1234 + 1 =' + (+numAsString + 1));

console.log();
console.log('1234 * 1 + 1 = ' + numAsString * 1 + 1);
console.log('(numAsString | 0) + 1 = ' + (numAsString | 0) + 1);
console.log('Number(numAsString) + 1 = ' + Number(numAsString) + 1)

console.log();
const invalidNumString = '435javascript';
console.log('invalidNumString = 435javascript');
console.log('parseInt(invalidNumString) + 1 = ' + parseInt(invalidNumString) + 1); // will parse whatever it can - 435
console.log('+invalidNumString = ' + (+invalidNumString)); // NaN
console.log('Number(invalidNumString) =' + Number(invalidNumString)); // NaN

console.log();
const fractionString = '3.65';
console.log('fractionString = 3.65');
console.log('parseFloat(fractionString) + 1 = ' + parseFloat(fractionString) + 1);
console.log('Number(fractionString) + 1 = ' + Number(fractionString) + 1);
console.log('+fractionString + 1 = ' + (+fractionString + 1));

console.log();
console.log('End');
console.log();