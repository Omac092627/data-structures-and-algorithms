'use strict';

function reverseArray(input){
	let newArr = [];
	for(let i = newArr.length -1; i >= 0; i--){
		newArr.push(input[i]);
	
	}
	
	return newArr;
	
}

let countDown = [1,2,3,4,5]
console.log(reverseArray(countDown));