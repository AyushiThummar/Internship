/*
Create an object called book with: title,author,pages
Then display the title.
*/
const book = {
    title: "Verity",
    author: "Collen hoover",
    pages: 311
}
console.log(book.title);

/*
let car = {
    brand: "Toyota",
    model: "Fortuner",
    year: 2024
};
Display all three property values separately.
*/
let car = {
    brand: "Toyota",
    model: "Fortuner",
    year: 2024
};
console.log(car.brand);
console.log(car.model);
console.log(car.year);

/*
let student = {
    name: "Riya",
    age: 20,
    branch: "Computer"
};
Change age to 21.
Add a new property city with value "Rajkot".
Display the complete object.
*/
let student = {
    name: "Riya",
    age: 20,
    branch: "Computer"
};
student.age = 21;
student.city = "Rajkot";
console.log(student);

/*
let product = {
    name: "Laptop",
    price: 50000,
    brand: "Dell"
};
Delete the brand property and display the complete object.
*/
let product = {
    name: "Laptop",
    price: 50000,
    brand: "Dell"
};
delete product.brand;
console.log(product);

/*
let employee = {
    name: "John",
    salary: 30000,
    department: "IT"
};
Print exactly : John works in IT and earns 30000
*/
let employee = {
    name: "John",
    salary: 30000,
    department: "IT"
};
console.log(employee.name + " works in " + employee.department + " and earns " + employee.salary);

/*
let person = {
    name: "John",
    age: 22
};
let property = "name";
Print the person's name using the property variable.
*/
let person = {
    name: "John",
    age: 22
};

let property = "name";
console.log(person[property]);

/*
Create an object called student with:
name → "Riya"
marks → 85
result() → method
The result() method should print:
Riya scored 85 marks
Use this inside the method.
*/
const student = {
    name: "Riya",
    marks: 85,
    result: function () {
        return (this.name + " scored " + this.marks + " marks.")
    }
}
console.log(student.result());

/*
student
 ├── name
 ├── age
 └── address
       ├── city
       └── state

name  → "Riya"
age   → 21
city  → "Rajkot"
state → "Gujarat"
Then display only the city.
*/
const student = {
    name: "Riya",
    age: 21,
    address: {
        city: "Rajkot",
        state: "Gujarat"
    }
}
console.log(student["address"]["city"]);

/*
let mobile = {
    brand: "Samsung",
    price: 30000,
    specifications: {
        ram: "8GB",
        storage: "128GB"
    }
};
Display : Samsung
8GB
128GB
*/
let mobile = {
    brand: "Samsung",
    price: 30000,
    specifications: {
        ram: "8GB",
        storage: "128GB"
    }
};
console.log(mobile.brand);
console.log(mobile.specifications.ram);
console.log(mobile.specifications.storage);

/*
let student = {
    name: "Riya",
    age: 21,
    branch: "Computer",
    city: "Rajkot"
};
Use a loop to display every property in this format:

name : Riya
age : 21
branch : Computer
city : Rajkot
*/
let student = {
    name: "Riya",
    age: 21,
    branch: "Computer",
    city: "Rajkot"
};
let text = "";
for (let x in student) {
    text += x + " : " + student[x] + "\n"
}
console.log(text);