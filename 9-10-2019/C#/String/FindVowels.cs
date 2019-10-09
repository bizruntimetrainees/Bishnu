using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class FindVowels
    {
        static void Main(string[] args)
        {

        
        int vCount = 0, cCount = 0;

         
        string str = "BizRunTime";

   
        str = str.ToLower();  
          
        for(int i = 0; i<str.Length; i++) {  
              
      
            if(str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u') {  
                  
                 
                vCount++;  
            }  
              
       
            else if(str[i] >= 'a' && str[i]<='z') {  
                  
                
                cCount++;  
            }  
        }  
        Console.WriteLine("Number of vowels : " + vCount);  
        Console.WriteLine("Number of consonant : " + cCount);  
    }  
    }
}
