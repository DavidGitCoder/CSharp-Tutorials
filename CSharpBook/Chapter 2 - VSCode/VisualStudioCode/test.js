const array=[1, 2, 3, 4, 5];

//0 + 1 + 2 + 3 + 4 + 5
const initialValue=0;
const sumWithInitial = array.reduce((acc, currVal) => acc + currVal, initialValue);
console.log(sumWithInitial); // Output: 15
