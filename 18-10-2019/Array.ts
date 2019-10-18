var names: Array<string> = ['Bishnu', 'Lokesh', 'Gyana']; 
names.sort(); 
console.log(names); 
console.log("-----------------------------------------");

console.log(names.pop()); 
console.log("-----------------------------------------");

names.push('ZEESHAN'); 
console.log(names); 
console.log("-----------------------------------------");

names = names.concat(['SALMAN', 'KHAN']); 
console.log(names);
console.log("-----------------------------------------");

console.log(names.indexOf('ZEESHAN'));
console.log("-----------------------------------------");

names.reverse();
console.log("Reversed array is : " + names );