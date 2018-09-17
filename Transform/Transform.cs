using System;
using System.Linq;
using System.Collections.Generic;


namespace Transform{
    public delegate int Sqre(int x);
    public static class Transform {
        public static int[] Map(this int[] a,Sqre sqr){
            for (int i = 0; i < a.Length; i++){
                a[i]=sqr(a[i]); 
            }
            return a;
        }
    }
}