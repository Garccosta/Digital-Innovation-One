window.onscroll = function() {stickNavbar()};

var header = document.getElementById("netflix-header");
var sticky = 50;


function stickNavbar() {
  var scrollPos = window.scrollY;
  if (scrollPos > sticky) {
    header.classList.add("sticky");
  } else {
    header.classList.remove("sticky");
  }
}
