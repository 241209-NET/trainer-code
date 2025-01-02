class Character {
    name;
    hp;
    level;

    constructor(name) {
        this.name = name;
        this.hp = 100;
        this.level = 1;
    }

    takeDMG(dmg) {
        this.hp -= dmg;
    }

    speak(msg) {
        const argLength = arguments.length;

        switch(argLength) {
            default:
            case 0: 
                return "Hello";
            case 1:
                return msg;
        }
    }
}

module.exports = Character;