console.log("hello world");

function myAlert()
{
    alert("DANGER!!!");
}

function buttonHandler1(e)
{
    console.log("button");
}

function divHandler1()
{
    console.log("div");
}

function buttonHandler2(e)
{
    console.log("button");
    e.stopPropagation();
}

function divHandler2()
{
    console.log("div");
}

const myBtn = document.getElementById('my-btn');
myBtn.innerText = "NYLA";

myBtn.addEventListener('click', function(e) {
    console.log(e);
    console.log("Button NYLA was pressed!");
});

const myDiv = document.getElementById('first-div')
myDiv.addEventListener('click', function(e) {
    const newBtn = document.createElement('button');
    newBtn.innerText = "New Button";
    myDiv.appendChild(newBtn);
});

function bubbling(e)
{
    console.log(e.target.innerText);
}

function createNewCat()
{
    const newImg = document.createElement('img');
    newImg.src = "https://cataas.com/cat";
    const ul = document.getElementById('cat-list');
    ul.appendChild(newImg);
}