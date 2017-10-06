# EXAM: Programming Basics

### Getting Started
 - Fork this repository under your own account
 - Clone the forked repository to your computer
 - Create a `.gitignore` file so generated files won't be committed
 - Commit your progress frequently and with descriptive commit messages
 - All your answers and solutions should go in this repository

### What can I use?
- You can use any resource online, but **please work individually**
- **Don't just copy-paste** your answers and solutions, use your own words instead.
- **Don't push your work** to GitHub until your mentor announces that the time is up


# Tasks
## 1-3. Complete the following tasks: (~90 mins)
- [Uniques Characters](uniquechars/UniqueChars.cs)
- [Favourite Animals](favouriteanimals/FavouriteAnimals.cs)
- [Candy Shop](candyshop/TakeMeToThe.cs)

### Acceptance criteria
The application is accepted if:
- The solution works according to specification [1p each]
- The solution follows [styleguide](https://github.com/greenfox-academy/teaching-materials/blob/master/styleguide/cs.mds) [1p]
- Has proper error handling where the specification says it [1p each]
- Has the correct loops, methods, filters [1p each]
- The code is clean, without unnecessary repetition, and with descriptive names [1p each]
- You commit frequently with descriptive commit messages [1p]

## 4. Question time! (~10 mins) [4p]

###  What is the difference between a function and a method? [2p]
A **function** is a piece of code that is called by name. It can be passed data to operate on (i.e. the parameters) and can optionally return data (the return value). All data that is passed to a function is explicitly passed.

A **method** is a piece of code that is called by a name that is associated with an object. In most respects it is identical to a function except for two key differences:
1. A method is implicitly passed the object on which it was called.
2. A method is able to operate on data that is contained within the class (remembering that an object is an instance of a class - the class is the definition, the object is an instance of that data).

C# is an OOP language and doesn't have functions that are declared outside of classes, that's why all functions in C# are actually methods.

### What is the constructor? When it is used? [2p]
A **constructor** is a method in the class which gets executed *when its object is created (=instantiated)*.
Usually, we put the initialization code in the constructor.