//Assigning DOM elements to variables
const form = document.getElementById('form');
const username = document.getElementById('username');
const Name1 = document.getElementById('Name1');
const password = document.getElementById('password');
const password2 = document.getElementById('password2');
const container = document.querySelector('.container');
const animateCircles = document.querySelector('.animate-circles');

const button = document.querySelector("#Button");
const button2 = document.querySelector("#Button2");
//Listen for for submission
button.addEventListener('click', function(e) {  
    //prevent default loading when form is submitted
    e.preventDefault();

    // Get values of form fields and assign to new variables
    const usernameValue = username.value;
    const Name1Value = Name1.value; 
    const passwordValue = password.value;
    const password2Value = password2.value;
  
    //conditional statements to check if form value is valid ..... If form value is not valid an error function is triggered but if it is valid a success function is triggered

    if (usernameValue === '') {
        errorMessage(username, "Username is empty");
    } else if(usernameValue.length < 4){

        errorMessage(username, "Your username is short, must be between 4 digit and above");
    } else {
        successMessage(username);
    }
    if (Name1Value === '') {
        errorMessage(Name1, "Your name is empty");
    } else if (Name1Value.length < 10) {
        errorMessage(Name1, "Please enter your full name(first middle and, last name)");
    } else {
        successMessage(Name1);
    }

    if (passwordValue === '') {
        errorMessage(password, "Password is empty");
    }
    else if(passwordValue.length < 6){

        errorMessage(password, "Your password is short, must be between 6 digit and above");
      
    } else {
        successMessage(password);
    }

    if (password2Value === '') {
        errorMessage(password2, "Password is empty");
    }   else if(password2Value.length < 6){

        errorMessage(password2, "Your password is short, must be between 6 digit and above");
  
    }
    else if (password2Value !== passwordValue) {
        errorMessage(password2, "Both Passwords does not match");
    } else {
        successMessage(password2);
    }

    // conditional statement to check if all values are valid so the bubbles can appear
    if (username.parentElement.classList.contains('success') && Name1.parentElement.classList.contains('success') && password.parentElement.classList.contains('success') && password2.parentElement.classList.contains('success')) {

        container.classList.add('complete');
        animateCircles.classList.add('complete');
        setTimeout(function () {
            button2.click();
        }, 4000);
        //return true;

    }
});


// function to be triggered if form valu is not valid. This function simply adds the error CSS class and removes that of success if it exists

function errorMessage(value, message) {
    const formControl = value.parentElement;

    if (formControl.classList.contains('success')) {
        formControl.classList.remove('success');
        formControl.classList.add('error');
    } else {
        formControl.classList.add('error');
    }
    formControl.querySelector('.errorMessage').textContent = message;


}

// function to be triggered if form valu is valid. This function simply adds the success CSS class and removes that of error if it exists

function successMessage(value) {
    const formControl = value.parentElement;

    if (formControl.classList.contains('error')) {
        formControl.classList.remove('error');
        formControl.classList.add('success');
    } else {
        formControl.classList.add('success');
    }
}

/*function validateName(Name1){
    var match = Name1.match(/\b[A-Za-z]{2,}\b/g);
    return match.length > 1;
   // const regName = /^[a-zA-Z]+$/;
  //  return regName.test(String(Name1)).toLowerCase();
  
}*/
function validateName(x){
    // var cap = (/\b[A-Za-z]{2,}\b/g);
    if(x.length < 3){
        return false;
    }else{
        // var con = /[bfg]/i;
        //var vow = /[ng]/i;  && con.test(Name1) && vow.test(Name1)
        //if(cap.test(x)){
        return true;
    } 
    
}

 




//This is a simple function to validate the email 




