//TypeScript affords us strict typing

//we defined a type
let age : number = 34;

//not allowed => age = "hello";

//Type by inference
let welcome = "hello";

//not allowed => welcome = 50;

let isRaining : boolean = true;

//Sometimes useful but rule breaking
let myVar : any = 34;
myVar = "hello";
myVar = true;
myVar = 3.45;

//null and undefined
let nothing : null = null;
let undef : undefined = undefined;

//object
let person : {name : string, age : number} = {
    name: "Kung",
    age: 32
}

//Unions
let multiType : string | number | null;
multiType = "Hello";
multiType = 56;
multiType = null;

let numArr : number[] = [1,2,3];
let strArr : string[] = ["hello", "world"];

//functions with return types
function myFunction(dogName : string) : string {
    return "Hello, " + dogName;
}

console.log(myFunction("Rover"));

//defining our own types
interface Animal {
    name : string;
    age : number;
}

let myCat : Animal = {name: "Nyla", age: 12};
console.log(myCat);

type Person = {
    name : string;
    height : number;
    age : number;
}

let myPerson : Person = {name: "Kung", height: 171, age: 32};
console.log(myPerson);

//tsc index.ts to transpile to JS
//node index.js to run