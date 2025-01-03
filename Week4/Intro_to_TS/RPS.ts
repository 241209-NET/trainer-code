enum Choice {
    Rock = "rock",
    Paper = "paper",
    Scissors = "scissors"
}

function CPU() : Choice {
    const choice : Choice[] = [Choice.Rock, Choice.Paper, Choice.Scissors];
    const rand : number = Math.floor(Math.random() * 3);
    //console.log(rand);
    return choice[rand];
}

function getWinner(CPU : Choice, player : Choice) : string {
    if(CPU == player) return "TIE!";

    if(
        player == Choice.Paper && CPU == Choice.Rock ||
        player == Choice.Rock && CPU == Choice.Scissors ||
        player == Choice.Scissors && CPU == Choice.Paper
    ) return "Player Wins!"

    return "CPU Wins!"
}

//play the game
function playGame(playerChoice : Choice) : void {
    //CPU make choice
    let cpuChoice : Choice = CPU();
    //determine winner
    let winner = getWinner(cpuChoice, playerChoice);
    //print win/lose
    console.log("CPU chose", cpuChoice);
    console.log("You chose", playerChoice);
    console.log(winner);
}

playGame(Choice.Rock);

//tsc RPS.ts to transpile to JS
//node RPS.js to run