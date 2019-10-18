let empTuple = ["Events", 101, "Abhishek"];     
console.log("Items: "+empTuple);
console.log("---------------------------------");

empTuple.push(101);
console.log(empTuple.length);
console.log("---------------------------------");

function display (tuple_values:any[]) {    
   for(let i = 0;i<empTuple.length;i++) {     
      console.log(empTuple[i]);
   }
}