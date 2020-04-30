class Node{
    constructor(data, next=null)
    {
        this.data=data,
        this.next=next;
    }
}

class LinkedList{
    constructor()
    {
        this.head=null;
    }
}

let count=0;
//addFirst
LinkedList.prototype.addFirst = function(data)
{
    let newNode= new Node(data);
    newNode.next=this.head;
    this.head=newNode;
    count++;
    return this.head;
}
//addLast
LinkedList.prototype.addLast=function(data)
{
    let newNode=new Node(data);

    if(!this.head)
    {
        this.head=newNode;
        count++;
        return this.head;
    }

    else{
        let last= this.head;
        while(last.next!==null)
        {
            last=last.next;
        }

        last.next=newNode;
        count++;
        return this.head;
    }
}
//length
LinkedList.prototype.length= function()
{
   return count;
}
//getFirst
LinkedList.prototype.getFirst= function()
{
    return this.head.data;
}
//getLast
LinkedList.prototype.getLast= function()
{
    let last= this.head;
        while(last.next!==null)
        {
            last=last.next;
        }

        return last.data;
}
//Print
LinkedList.prototype.print = function()
{
    let last = this.head;
    while(last.next!=null)
    {
        console.log(last.data);
        last=last.next;

    }

    console.log(last.data);
}

export {  LinkedList};