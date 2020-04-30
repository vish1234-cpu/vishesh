function stackUsingLinkList(){

    let Node = function(e){
      this.element = e;
      this.next = null;
    }

    let size = 0;
    let head = null;

    this.push = function(e){

      let node = new Node(e),current;

      current = head;
      node.next = current;
      head = node;

      size++;
    }


    this.pop = function(){
      let current = head;

     if(current){
        let e = current.element;
        current = current.next;
        head = current;
        size--;
        return e;
      }

      return null;
    }


    this.peek = function(){
      if(head){
        return head.element;
      }

      return null;
    }


    this.toArray = function(){
      let arr = [];
      let current = head;
      while(current){
        arr.push(current.element);
        current = current.next;
      }

      return arr;
    }


    this.isEmpty = function(){
      return size === 0;
    }


    this.size = function(){
      return size;
    }


    this.clear = function(){
      head = null;
      size = 0;
    }

}

export {stackUsingLinkList};