var str1 = 'Hello';
var str2 = 'Bishnu';
//String Concatenation  
console.log("Combined Result: " + str1.concat(str2));
console.log("--------------------------------------------");
//String charAt  
console.log("Character At 3: " + str2.charAt(3));
console.log("--------------------------------------------");
//String indexOf  
console.log("Index of h: " + str2.indexOf('h'));
console.log("--------------------------------------------");
//String replace  
console.log("After Replacement: " + str1.replace('Hello', 'BishnuMishra'));
console.log("--------------------------------------------");
//String uppercase  
console.log("UpperCase: " + str2.toUpperCase());
console.log("--------------------------------------------");
//String Lowercase 
console.log("LowerCase: " + str2.toLowerCase());
function reverse(str2) {
    return str2.split('').reverse().join('');
}
