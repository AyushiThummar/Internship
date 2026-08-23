console.log("Hello JavaScript!");

// Single line comment

/*
Multiple line comment
*/

let x = 5, y = 10;
console.log(x+y);

const pi = 3.141592653589793;
// pi = 3.14; // This will give an error

/*
The keyword const is a little misleading.
It does not define a constant value. It defines a constant reference to a value.
Because of this you can NOT:
    Reassign a constant value
    Reassign a constant array
    Reassign a constant object

But you CAN:
    Change the elements of constant array
    Change the properties of constant object
*/
const car = ["Saab", "Volvo", "BMW"];
console.log(car);
console.log(car[1]);
car.push("Audi");
console.log(car);
car[1] = "Toyota";
console.log(car);

/*
Redeclaration 
    var :- You can declare the same var variable again in the same scope.
    let :- Redeclaration is not allowed, value can be Reassign.
    const :- Redeclaration and reassignment NOT allowed.
*/

/*
* 8 datatypes :- 
    String
    Number
    Bigint
    Boolean
    Object
    Undefined
    Null
    Symbol
*/

console.log(typeof("abc"));
console.log(typeof(0));

