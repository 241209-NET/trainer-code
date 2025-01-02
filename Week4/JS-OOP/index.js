//console.log("Hello World!");

const Character = require("./character.js");
const Wizard = require("./wizard.js");

let char1 = new Character("Kung");
let char2 = new Wizard("Harry", "Fire Ball");

console.log(char1);
char1.takeDMG(45);
console.log(char1);

console.log(char2, char2.getMp());
char2.takeDMG(45);
console.log(char2, char2.getMp());
console.log(char2.cast());

console.log(char2.speak());
console.log(char2.speak("Greetings"));