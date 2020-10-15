"use strict";

function binarySearch(arr, key){
    let start = 0, end = arr.length-1;

    while(start <= end){
        let mid = Math.floor((start + end) / 2);

        if(arr[mid] === key){
            return arr.indexOf(arr[mid]);
        }

        else if(arr[mid] < key){
            start = mid + 1;
        }else{
            end = mid - 1;
        }

    }

    for(let i = 0; i < arr.length; i++)
      if(arr[i] !== key){
        return -1;
      }
    }
    


let arr = [1,2,3,4,5,6,7,8,9,10];

let x = 10;

binarySearch(arr, x);