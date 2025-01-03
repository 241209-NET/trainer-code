var Choice;
(function (Choice) {
    Choice["Rock"] = "rock";
    Choice["Paper"] = "paper";
    Choice["Scissors"] = "scissors";
})(Choice || (Choice = {}));
function CPU() {
    var choice = [Choice.Rock, Choice.Paper, Choice.Scissors];
    var rand = Math.floor(Math.random() * 3);
    //console.log(rand);
    return choice[rand];
}
function getWinner(CPU, player) {
    if (CPU == player)
        return "TIE!";
    if (player == Choice.Paper && CPU == Choice.Rock ||
        player == Choice.Rock && CPU == Choice.Scissors ||
        player == Choice.Scissors && CPU == Choice.Paper)
        return "Player Wins!";
    return "CPU Wins!";
}
//play the game
function playGame(playerChoice) {
    //CPU make choice
    var cpuChoice = CPU();
    //determine winner
    var winner = getWinner(cpuChoice, playerChoice);
    //print win/lose
    console.log("CPU chose", cpuChoice);
    console.log("You chose", playerChoice);
    console.log(winner);
}
playGame(Choice.Rock);
