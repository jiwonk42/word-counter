# Scrabble Score Determiner

#### _An application to return how frequently a word appears in a given string._

#### By _**Jiwon (Gee) Kang**_

## Description

The user enters a word in the first input and a string of multiple words in the second input. Then, the program finds words that match user's first input and count number of the word found in the second input, and returns number of the word found.

## Setup/Installation Requirements

* Requires DNU, DNX, and Mono
* Clone to local machine
* Use command "dnu restore" in command prompt/shell
* Use command "dnx kestrel" to start server
* Navigate to http://localhost:5004 in web browser of choice

## Specifications

**The user enters a word "Hello" and a string of words, "Goodbye". The program returns 0.**
* Example Input: {"Hello", "Goodbye"}
* Example Output: 0

**The user enters a word "Hello" and a string of words, "Hello Goodbye". The program returns 1.**
* Example Input: {"Hello", "Hello Goodbye"}
* Example Output: 1

**The user enters a word "Hello" and a string words, "Hello Goodbye Hello". The program returns 2**
* Example Input: {"Hello", "Hello Goodbye Hello"}
* Example Output: 2

**The user enters a word "HELLO" and a string words, "Herlo HEllo hello HELLO". The program returns 3**
* Example Input: {"HELLO", "Herlo HEllo hello HELLO"}
* Example Output: 3

## Support and contact details

Please contact Jiwon Kang at jiwonk42@gmail.com with any questions, concerns, or suggestions.

## Technologies Used

This web application uses:
* Nancy
* Mono
* DNVM
* C#
* Razor

### License

*This project is licensed under the MIT license.*

Copyright (c) 2017 **_Jiwon Kang_**
