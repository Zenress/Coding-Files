const knap = document.querySelector('.menu');
const nav = document.querySelector('ul');
let isOpen = false;

knap.addEventListener('click', function() {
  if(isOpen) {
    nav.style.transition = "transform 150ms ease-in";
    nav.style.transform = "translateX(-450px)";
    isOpen = false;
  } else {
    nav.style.transition = "transform 1s ease-out";
    nav.style.transform = "translateX(0)";
    isOpen = true;
  }
})