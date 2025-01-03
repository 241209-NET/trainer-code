//TypeScript affords us strict typing
//we defined a type
var age = 34;
//not allowed => age = "hello";
//Type by inference
var welcome = "hello";
//not allowed => welcome = 50;
var isRaining = true;
//Sometimes useful but rule breaking
var myVar = 34;
myVar = "hello";
myVar = true;
myVar = 3.45;
//null and undefined
var nothing = null;
var undef = undefined;
//object
var person = {
    name: "Kung",
    age: 32
};
//Unions
var multiType;
multiType = "Hello";
multiType = 56;
multiType = null;
var numArr = [1, 2, 3];
var strArr = ["hello", "world"];
//functions with return types
function myFunction(dogName) {
    return "Hello, " + dogName;
}
console.log(myFunction("Rover"));
var myCat = { name: "Nyla", age: 12 };
console.log(myCat);
var myPerson = { name: "Kung", height: 171, age: 32 };
console.log(myPerson);
