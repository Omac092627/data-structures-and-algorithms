'use strict'

function insertShiftArray(array, number){
    const newArray = [];
    const count = Math.round(array.length / 2); 
    for(let i = 0; i < array.length; i++){
        if(i === count && !newArray.includes(number)){
            newArray[i] = number;
            newArray[i+1] = array[i];    
            i--;     
        }
        else if(i > count){
            newArray[i+1] = array[i];
        }
        else if(i < count){
            newArray[i] = array[i];
        }
            console.log(newArray)
    }
    return newArray;
}