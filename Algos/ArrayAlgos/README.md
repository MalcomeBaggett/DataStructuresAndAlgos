# Array Algorithims

## Sum of Two Numbers

### Problem

Given a non empty array of integers and integer representing a target sum, find if any two numbers within the array
match the target sum. If no numbers match return an empty array.

### Solution

My solution is a O(nlog(n)) time complexity and O(1) space complexity.
I first use the built in method in order to sort the array. Once the array is sorted I create two pointers in order to iterate through the array. On each iteration I check if the the two pointers match the target sum, if not I increment left of decrement right until a match is found or we iterate throught the array.
