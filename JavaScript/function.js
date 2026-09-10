// Basic Function: Create a greet function that takes a name parameter and returns "Hello, <name>".
function greet(name) {
    return "Hello, " + name;
}
console.log(greet("John"));

// Parameters + Return: Create a multiply function that takes two parameters and returns their multiplication.
function multiply(a, b) {
    return a * b;
}
console.log(multiply(6, 7));

// Default Parameter: Create a calculatePrice function with price and tax = 5 and return price + tax.
function calculatePrice(price, tax = 5) {
    return price + tax;
}
console.log(calculatePrice(100));

// arguments: Create a sumAll function using arguments to add any number of values and return the total.
function sumAll() {
    let sum = 0;
    for (let i = 0; i < arguments.length; i++) {
        sum = sum + arguments[i];
    }
    return sum;
}
console.log(sumAll(10, 20, 30, 40));

// Find Maximum: Create a findMax function using arguments to find and return the largest number.
function findMax() {
    let max = -Infinity;
    for (let i = 0; i < arguments.length; i++) {
        if (max < arguments[i]) {
            max = arguments[i];
        }
    }
    return max;
}
console.log(findMax(12, 45, 7, 89, 34))

// Default Parameter + Calculation: Create a calculateDiscount function with price and discount = 10, 
// and return the final price after discount.
function calculateDiscount(price, discount = 10) {
    let final_price = price - (price * discount / 100);
    return final_price;
}
console.log(calculateDiscount(1000))
console.log(calculateDiscount(1000, 20))

// Rest Parameter: Create a findAverage function using the rest parameter ... 
// to accept any number of numbers and return their average.
function findAverage(...numbers) {
    let sum = 0;
    for (let i = 0; i < numbers.length; i++) {
        sum += numbers[i];
    }
    return sum / numbers.length;
}
console.log(findAverage(10, 20, 30, 40, 50));

// Rest Parameter + Maximum: Create a findMax function using ...numbers 
// to accept any number of numbers and return the largest number.
function findMax(...numbers) {
    let max = -Infinity;
    for (let i = 0; i < numbers.length; i++) {
        if (max < numbers[i]) {
            max = numbers[i];
        }
    }
    return max;
}
console.log(findMax(15, 7, 89, 34, 52));

// Even/Odd: Create a checkEvenOdd function that takes a number and returns "Even" or "Odd".
function checkEvenOdd(num) {
    if (num % 2 == 0) {
        return "Even";
    }
    else {
        return "Odd";
    }
}
console.log(checkEvenOdd(17))

// Smallest Number: Create a findSmallest function that takes three numbers and 
// returns the smallest number without using Math.min().
function findSmallest(a, b, c) {
    if (a < b && a < c) {
        return a;
    }
    else if (b < a && b < c) {
        return b;
    }
    else {
        return c;
    }
}
console.log(findSmallest(25, 10, 18));
// Better :-
function findSmallest(a, b, c) {
    let smallest = a;

    if (b < smallest) {
        smallest = b;
    }

    if (c < smallest) {
        smallest = c;
    }

    return smallest;
}
console.log(findSmallest(10, 10, 18));

// Count Vowels: Create a countVowels function that takes a string and returns the number of vowels (a, e, i, o, u).
function countVowels(input) {
    let count = 0;
    for (let i = 0; i < input.length; i++) {
        if (input[i] == "a" || input[i] == "e" || input[i] == "i" || input[i] == "o" || input[i] == "u") {
            count++;
        }
    }
    return count;
}
console.log(countVowels("javascript"));

// Reverse String: Create a reverseString function that takes a string and 
// returns the reversed string without using .reverse().
function reverseString(input) {
    let reverse = "";
    for (let i = input.length - 1; i >= 0; i--) {
        reverse = reverse + input[i];
    }
    return reverse;
}
console.log(reverseString("hello"));

// Palindrome: Create an isPalindrome function that takes a string and 
// returns "Palindrome" if it reads the same forward and backward, otherwise "Not Palindrome".
function isPalindrome(input) {
    let start = 0;
    let end = input.length - 1;
    for (let i = 0; i < input.length / 2; i++) {
        if (input[start] != input[end]) {
            return "Not Palindrome";
        }
        start++;
        end--;
    }
    return "Palindrome";
}
console.log(isPalindrome("madam"));


// ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ Function Expression ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

// Square Number: Create a function expression square that takes a number and returns its square.
const square = function (num) {
    return num * num;
};
console.log(square(5));

// Find Larger Number: Create a function expression findLarger that takes two numbers 
// and returns the larger number without using Math.max().
const findLarger = function (a, b) {
    if (a > b) {
        return "a";
    }
    else {
        return "b";
    }
};
console.log(findLarger(50, 200))

// Count Characters: Create a function expression countCharacters that takes a string and returns its length.
const countCharacters = function (input) {
    let count = 0;
    for (let i = 0; i < input.length; i++) {
        count++;
    }
    return count;
};
console.log(countCharacters("minimum"));

// Calculate Simple Interest: Create a function expression simpleInterest 
// that takes principal, rate, and time and returns: (P × R × T) / 100
const simpleInterest = function (p, r, t) {
    return (p * r * t) / 100;
};
console.log(simpleInterest(10000, 2, 2));

// Count Vowels: Create a function expression countVowels that takes a string and returns the number of vowels in it.
const countVowels = function (input) {
    let count = 0;
    for (let i = 0; i < input.length; i++) {
        if (input[i] == "a" || input[i] == "e" || input[i] == "i" || input[i] == "o" || input[i] == "u" || input[i] == "A" || input[i] == "E" || input[i] == "I" || input[i] == "O" || input[i] == "U") {
            count++;
        }
    }
    return count;
};
console.log(countVowels("Ohio"));


// ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ Arrow Function ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

// Cube Number: Create an arrow function cube that takes a number and returns its cube.
const cube = (num) => num * num * num;
console.log(cube(10));

// Check Positive/Negative: Create an arrow function checkNumber that takes 
// a number and returns "Positive", "Negative", or "Zero".
const checkNumber = (num) => {
    if (num > 0) {
        return "Positive";
    }
    else if (num < 0) {
        return "Negative";
    }
    else if (num === 0) {
        return "Zero";
    }
};
console.log(checkNumber(45));

// Find Smallest: Create an arrow function findSmallest that takes three numbers and returns the smallest number without using Math.min().
const findSmallest = (n1, n2, n3) => {
    let small = n1;

    if (n2 < small) {
        small = n2;
    }

    if (n3 < small) {
        small = n3;
    }

    return small;
};
console.log(findSmallest(2654, 2654, 55789))

// Calculate Discount: Create an arrow function calculateDiscount that takes price and discount = 10, then returns the final price after discount.
const calculateDiscount = (p, d = 10) => {
    let final_price = p - (p * d / 100);
    return final_price;
};
console.log(calculateDiscount(50000))

// Sum All Numbers: Create an arrow function sumAll using the rest parameter ...numbers that accepts any number of numbers and returns their total.
const sumAll = (...numbers) => {
    let sum = 0;
    for (let i = 0; i < numbers.length; i++) {
        sum += numbers[i];
    }
    return sum;
};
console.log(sumAll(153, 465, 1540, 346, 346));
