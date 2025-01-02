const Character = require("./character.js");

class Wizard extends Character {
    #mp;
    #spell;

    constructor(name, spell) {
        super(name);
        this.#spell = spell;
        this.#mp = 10;
    }

    getMp() {
        return this.#mp;
    }

    cast() {
        if(this.#mp > 0)
        {
            this.#mp--;
            return `I am using ${this.#spell} and I now have ${this.#mp} mp left.`
        }
        return "Construct additional pylons!"
    }
}
module.exports = Wizard;