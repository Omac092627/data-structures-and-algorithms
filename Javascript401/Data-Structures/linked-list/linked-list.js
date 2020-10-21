"use strict";


const Node = require("./node.js");

class LinkedList{

    constructor(){
        this.head = null;
        this.current = head;

    }

    insert(value){
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

    append(value){
        this.current = this.head;
        if(this.head === null){
            this.head = new Node(value);
        }
        while(this.current !== null){
            let node = new Node(value);
            this.current.next = node;
            this.current = this.current.next;

        }
        this.current = this.current.next;
    }

    insertBefore(value, newValue){
    this.current = this.head;
    if(this.current === value){
        this.insert(newValue);
    }else{
        let last = this.current;

        while(this.current !== null){
            if(this.current.value === value){
                let node = new Node(newValue);
                node.next = this.current;
                last.next = node;
                break;
            }
            last = this.current;
            this.current = this.current.next;
        }
    }

    }

    insertAfter(value, newValue){
        this.current = this.head;

        while(this.current !== null){
            if(this.current.value === value){
                let node = new Node(newValue);
                node.next = this.current.next;
                this.current.next = node;
            }
            this.current = this.current.next;
        }
    }

    kthFromEnd(key){
        this.current = this.head;

        let walker = this.current;
        let runner = this.current;

        let k = key;

        if(k < 0){
            throw new console.error("No negative numbers")
        }
        while(k > 0){
            if(runner.next !== null){
                k--;
                runner = runner.next;
            }else{
                throw new console.error("Can't be same length")
            }

        }
        while(runnier.next !== null){
            walker = walker.next;
            runner = runner.next;
        }
        return walker.value;
    }
}

module.exports = LinkedList;