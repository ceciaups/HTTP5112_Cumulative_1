# HTTP 5112 Assignment 2

List of functions in [/Controllers](HTTP5112_Assignment_2/Controllers)  
Original Source: ​https://cemc.math.uwaterloo.ca/contests/computing/past_ccc_contests/2006/stage1/juniorEn.pdf

## J1. The New CCC (Canadian Calorie Counting):
- [/Controllers/J1Controller.cs](HTTP5112_Assignment_2/Controllers/J1Controller.cs)
- GET: `http://localhost/api/J1/Menu/{burger}/{drink}/{side}/{dessert}`
- Compute the total Calories of the meal
- Parameter: {burger} Digit choice of burger, {drink} Digit choice of drink, {side} Digit choice of side, {dessert} Digit choice of dessert
- Return: Returns the total Calories of the meal
- Example: GET api/J1/Menu/1/2/3/4 -> "Your total calorie count is 691"

## J2. Roll the Dice:
- [/Controllers/J2Controller.cs](HTTP5112_Assignment_2/Controllers/J2Controller.cs)
- GET: `http://localhost/api/J2/DiceGame/{m}/{n}`
- Determines how many ways two dices, which have m and n sides respectively, can be rolled the value of 10
- Parameter: {m} Number of sides of the first dice, {n} Number of sides of the second dice
- Return: Returns number of ways the dices can rolled the value of 10
- Example: GET /api/J2/DiceGame/6/8 -> "There are 5 total ways to get the sum 10."

## J3. Cell-Phone Messaging:
- [/Controllers/J3Controller.cs](HTTP5112_Assignment_2/Controllers/J3Controller.cs)
- GET: `http://localhost/api/J3/CellPhoneMessage/{strMessage}`
- Calculate the minimal time needed to type a message on a cell phone, assuming that 1 second per press and 2 seconds per pause
- Parameter: {strMessage} The input string
- Return: Returns the minimal number of seconds needed to type in the word
- Example: GET /api/J3/CellPhoneMessage/abba -> "The minimal number of seconds needed to type in 'abba' is 12s."