"use strict";

const LinkedList = require("./linked-list")


describe("Checking my linked lists", () => {
    it("check if null", () => {
        const linked = new LinkedList();
        expect(linked.head).toBeNull();
    })
    it("should insert", () => {
        const linked = new LinkedList();
        linked.insert(2);
        expect(linked.head.value).toEqual(2);
    })
    it("can insert multiple", () => {
        const linked = new LinkedList();
        linked.insert(1);
        linked.insert(2);
        linked.insert(3);
        linked.insert(4);
        linked.insert(5);

        expect(linked.head.value).toEqual(5);
    })
    it("can add node at end", () => {
        let linked = new LinkedList();
        linked.insert(1);
        linked.insert(2);
        linked.insert(3);
        linked.insert(4);
        linked.insert(5);
        linked.append(6);

        let val = linked.toString();

        expect(val). toEqual("4 => 3 => 2 => 1 => 5 => 6")
    })

    it("can insert before", () => {
        let linked = new LinkedList();

        linked.insert(1);
        linked.insert(2);
        linked.insert(3);
        linked.insertBefore(1, 5);

        let val = linked.toString();
        expect(val).toEqual("3 => 2 => 1 => 5")
    })
})