var fruits = ['Æble','Citron','Pære','Banan'];
var select = document.querySelector('p.text');

// Function that types a randomly selected item from fruits to a string
function typeSentence()
{
    var randomNr = Math.floor(Math.random() * fruits.length)
    let split = fruits[randomNr].split('');
    console.log(fruits[1]);
    console.log(split[0]);
    for (let index = 0; index < split.length; index++) 
    {
        setTimeout(() => {select.append(split[index]);},index * 650);
    }
}

// Function for deleting the sentence that typeSentence forms
function deleteSentence() 
{
    console.log(select.innerHTML);
    let split = select.innerHTML.split("");
    console.log(split.length);
    let nr = split.length;
    for (let index = 0; index < split.length; index++) 
    {
        setTimeout(() => {select.innerHTML = select.innerHTML.substring(0,nr  - 1);},index * 650);
        setTimeout(() => {nr--;},index * 650);
    }
    
}

// A function that makes typeSentence and deleteSentence work together in harmony
function typeEffect() 
{
    typeSentence();

    setTimeout(() => {deleteSentence()},5000)
}

// The setInterval function doesn't run when the page is loaded, only after the interval. 
// Just to make it easier to but test, i made it run when the site starts as well
typeEffect();

// setInterval function that runs every 10 seconds
setInterval(() => {
    typeEffect()
}, 10000);