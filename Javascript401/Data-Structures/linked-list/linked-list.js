"use strict";


const Node = require("./node.js");

class LinkedList{

    constructor(){
        this.head = null;
        this.current = head;

    }

    inser(value){
        this.current = this.head;
        let node = new Node(value);
        node.next = this.head;
        this.head = node;
    }

    includes(value){
        this.current = this.head;

        while(this.current != null){
            if(this.current.value === value){
                return true;
            }
            this.current = this.current.next;
        }
        return false;
    }

    toString(){
        this.current = this.head;

        if(this.head === null){
            return "";
        }

        let objectStr = "";

        while(this.current !== null){
            objectStr = `${objectStr} ${this.current.value} =>`;
            this.current = this.current.next;
        }

        objectStr = `${objectStr} null`;
        return objectStr;
    
    }

}