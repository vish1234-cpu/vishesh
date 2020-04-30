import {circle,rectangle,cylinder} from './Area.js' 
import {UniqueArray} from './UniqueArray.js' 
import {LinkedList} from './LinkedList.js' 
import {stackUsingLinkList} from './Stack.js' 



alert("Welcome!! All The Answers Are In Console!!");

//ques1)  Given this array: `[3,62,234,7,23,74,23,76,92]`, Using arrow function, create an array of the numbers greater than `70`.
console.log("Ans1");
const intArray = [3, 62, 234, 7, 23, 74, 23, 76, 92]; 
const resultArray = intArray.filter(intArray => intArray > 70);
console.log(`Array after filtering elements less than 70 ${resultArray}`);

/////////////////////////////////////////////////////////////////////////////////////

//ques3. Create a markup template using string literal
const song = {
 name: 'Dying to live',
 artist: 'Tupac',
 featuring: 'Biggie Smalls'
};

console.log("Ans3");
const literal = `<div class="song">
        <p>
            ${song.name} - ${song.artist}
            (Featuring ${song.featuring})
        </p>
    </div>`;

console.log(`Markup Template: ${literal}`); 

///////////////////////////////////////////////////////////////////////////////////////


// ques4) Extract all keys inside address object from user object using destructuring ?

const user = {
firstName: 'Sahil',
lastName: 'Dua',
Address: {
Line1: 'address line 1',
Line2: 'address line 2',
State: 'Delhi',
Pin: 110085,
Country: 'India',
City: 'New Delhi',
},
phoneNo: 9999999999
};

console.log("Ans4"); 
let{Line1,Line2,State,Pin,Country,City}=user.Address;
console.log(`"keys: ${Line1},${Line2},${State},${Pin},${Country},${City}`); 

///////////////////////////////////////////////////////////////////////////////////////

// ques5)   Filter unique array members using Set.
console.log("Ans5"); 
const CommanArray = [1,1,1,2,2,3,4,5,6,7,8,9,9,0,10,10,12,12,14,14,15,15,17,20,25,30,45]
const distinctArray = [...new Set(CommanArray)]
console.log(distinctArray); 

///////////////////////////////////////////////////////////////////////////////////////


// ques6)  Find the possible combinations of a string and store them in a MAP? 

function getAllStrings(string)
{
    var results = [];

  if (string.length === 1) {
    results.push(string);
    return results;
  }
  
  for (var i = 0; i < string.length; i++) {
    var char1 = string[i];
    var char2 = string.substring(0, i) + string.substring(i + 1);
    var inner = getAllStrings(char2);
    for (var j = 0; j < inner.length; j++) {
      results.push(char1 + inner[j]);
    }
  }
  return results;
}

console.log("Ans6"); 
console.log(getAllStrings("vishesh")); 

///////////////////////////////////////////////////////////////////////////////////////

// ques7)  Write a program to implement inheritance upto 3 classes.The Class must  public variables and static functions.

class Laptop
 {
   constructor(Warrenty)
   {
     this.Warrenty = Warrenty;
   }
   static WarrentyPeriod()
   {
     console.log("Ans7: Lenovo having 2 years of Warrenty..");
   }
   Cost()
   {
     console.log(`${this.Warrenty} costs starts from 30k.`);
   }
}
class Tablet extends Laptop // inherited the Driver class
{
    Cost()
  {
    console.log(`${this.Warrenty} costs starts from 15k..`); // method is overrided
  }
}
class CellPhone extends Tablet // inherited the Corider class
{
    Cost()
    {
      super.Cost(); // it invokes the method from the parent class
      console.log(`${this.Warrenty} costs starts from 10k.`);

    }

}
let a = new CellPhone('Lenovo'); 
console.log(Laptop.WarrentyPeriod()); // static method ivoked by class name
console.log(a.Cost()); // method inherited from parent class

///////////////////////////////////////////////////////////////////////////////////////

// ques8) Write a program to implement a class having static functions

class Mobile {
  static OS() {
    return 'OS of Mobile is Android.'; 
  }
}
console.log("Ans8"); 

console.log(Mobile.OS());

///////////////////////////////////////////////////////////////////////////////////////

// ques9) Import a module containing the constants and method for calculating area of circle, rectangle, cylinder.

console.log("Ans 9 : Area of circle : " + circle(15));
console.log(" Area of rectangle : " + rectangle(10,20));
console.log(" Area of cylinder : " + cylinder(5,10)); 


///////////////////////////////////////////////////////////////////////////////////////

// ques10)  Import a module for filtering unique elements in an array.

console.log("Ans10:");
// implemented the array filtering using set as we have done Ques4 
console.log("UniqueArray: " + UniqueArray); 

///////////////////////////////////////////////////////////////////////////////////////

// ques11) Write a program to flatten a nested array to single level using arrow functions.

console.log("Ans 11:");
const nonFlatenedArray= [[0,[9]],[1,8,[3]],[0,[5,1,7,[8,11,51]]]];
const resultarray = nonFlatenedArray.flat(nonFlatenedArray => nonFlatenedArray);
console.log(` Array after flattening ${resultarray}`);


///////////////////////////////////////////////////////////////////////////////////////

// ques12) Implement a singly linked list in es6 and implement addFirst() addLast(), length(), getFirst(), getLast(). (without using array)
console.log("Ans 12 :");
let linklist= new LinkedList();
linklist.addFirst(23);
linklist.addFirst(12);
linklist.addLast(99);
linklist.print(); 
console.log("Length of the Linked List : " + linklist.length());
console.log("First element of the Linked List " + linklist.getFirst());
console.log("Last element of the Linked List " + linklist.getLast());



///////////////////////////////////////////////////////////////////////////////////////

 //ques13)  Implement Map and Set using Es6
console.log("Ans 13:");

console.log("Map method");

 let string= "Vishesh";

 let letters= new Map();

 for(let i=0;i<string.length;i++)
 {
     let letter = string[i];

     if(!letters.has(letter))
     {
         letters.set(letter,1);
     }
     else{
         letters.set(letter, letters.get(letter)+1);
     }
 }

 console.log(letters);

 console.log("Set method");

 let array= [10,31,80,77,36,480];
 let newSet= new Set(array);
 newSet.add(5);
 newSet.delete(36);
 console.log(newSet);

///////////////////////////////////////////////////////////////////////////////////////

// ques14)  Implementation of stack (using linked list)

console.log("Ans 14 :");

let stack = new stackUsingLinkList();

stack.push(11);
stack.push(5);
stack.pop();
stack.push(68);
stack.push(255);
stack.push(10);
stack.pop();

console.log("Elememts in stack are ");
console.log( stack.toArray());
console.log("Is the Stack Empty : " + stack.isEmpty());
console.log("size of stack is : " + stack.size());