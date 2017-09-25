'use strict';

console.log();
console.log('Start');
console.log();

let fractionalNumber = 8.75;
const truncated = fractionalNumber | 0,
    truncated2 = Math.trunc(fractionalNumber);

console.log('fractionalNumber = ' + fractionalNumber);
console.log('truncated with "| 0" = ' + truncated);
console.log('truncated with "Math.trunc" = ' + truncated2);

console.log();
fractionalNumber = 8.75;
var roundedInt = (fractionalNumber + 0.5) | 0;
var roundedInt2 = Math.round(fractionalNumber);

console.log('fractionalNumber = ' + fractionalNumber);
console.log('rounding with | = ' + roundedInt);
console.log('rounding with Math.round = ' + roundedInt2);


console.log();
fractionalNumber = 8.75;
roundedInt = Math.ceil(fractionalNumber);
roundedInt2 = Math.floor(fractionalNumber);

console.log('fractionalNumber = ' + fractionalNumber);
console.log('rounding with Math.ceil = ' + roundedInt);
console.log('rounding with Math.floor = ' + roundedInt2);

console.log();
console.log('End');
console.log();