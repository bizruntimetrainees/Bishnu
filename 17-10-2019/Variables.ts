let num1:number=10;
function letDeclaration(){
    let num2:number=20;
    if(num2 > num1){
        let num3:number=25;
        num3++;
    }
    while(num1<num2){
        let num4: number=45;
        num1++;
    }
    console.log(num1);
    console.log(num2);
    console.log(num3);//CompileTime Error
    console.log(num4);
}
letDeclaration();