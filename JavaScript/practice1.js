/* 1. 
Create two variables a = 25 and b = 10. 
Calculate and print their addition, subtraction, multiplication, division, and remainder.
*/
let a = 25;
let b = 10;
console.log("Addition:", a + b);
console.log("Subtraction:", a - b);
console.log("Multiplication:", a * b);
console.log("Division:", a / b);
console.log("Remainder:", a % b);

/* 2.
Create a variable num = 7. Print the number, its square, and its cube.
*/
let num = 7;
console.log("Number:", num);
console.log("Square:", (num * num));
console.log("Cube:", (num * num * num));

/* 3.
Create firstName = "Ayushi" and lastName = "Thummar". 
Combine them and print the full name with a space between them.
*/
let firstName = "Ayushi";
let lastName = "Thummar";
console.log("Full Name:", firstName + " " + lastName);

/* 4.
Create text = "JavaScript". Print the string and the number of characters in it.
*/
let text = "JavaScript";
console.log("Text: " + text);
console.log("Length: " + text.length);

/* 5. 
Create text = "JavaScript". Print the first character and the last character.
*/
console.log("First character: " + text.at(0));
console.log("Last character: " + text.at(-1));

/* 6. 
Create text = "JavaScript". Print the first 4 characters and the last 3 characters.
*/
console.log("First 4 characters: " + text.slice(0, 4));
console.log("Last 3 characters: " + text.slice(-3));

/* 7.
Create text = "Hello World". Print the string once in uppercase and once in lowercase.
*/
let text1 = "Hello World";
console.log("Upper case: " + text1.toUpperCase());
console.log("Lower case: " + text1.toLowerCase());

/* 8.
Create text = " JavaScript ". Print the original string and then print it after removing the extra spaces from both ends.
*/
let text2 = "   JavaScript  ";
console.log("Origibal: " + text2);
console.log("Cleaned: " + text2.trim())

/* 9.
Create text = "I love JavaScript". Check whether the string contains "JavaScript".
*/
let text3 = "I love JavaScript";
console.log(text3.includes("JavaScript"))

/* 10.
Create text = "JavaScript is easy". Check whether the string starts with "JavaScript".
*/
let text4 = "JavaScript is easy";
console.log(text4.startsWith("JavaScript"))

/* 11.
Create text = "JavaScript is awesome". Check whether the string ends with "awesome".
*/
let text5 = "JavaScript is awesome";
console.log(text5.endsWith("awesome"))

/* 12.
Create text = "Hello World". Replace "World" with "JavaScript" and print the result.
*/
console.log(text1.replace("World", "JavaScript"));

/* 13.
Create text = "Apple, Banana, Mango, Orange". Convert the string into an array of individual fruits.
*/
let text6 = "Apple, Banana, Mango, Orange";
console.log(text6.split(","));

/* 14. 
Create text = "JavaScript". Find and print the index of the first occurrence of "a".
*/
console.log(text.indexOf("a"));

/* 15.
Create text = "JavaScript is fun". Find and print the index of the last occurrence of "i".
*/
let text7 = "JavaScript is fun";
console.log(text7.lastIndexOf("i"));

