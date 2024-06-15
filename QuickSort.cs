using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace implementandoQuickSort
{
    public static class QuickSort
    {
        public static void SortArray(int[] arr,int inicio=0, int? fim=null)
        {
            if(!fim.HasValue)
            fim=arr.Length-1;
            
            int p;
            if( inicio<fim){

             p=Particionar(arr,inicio,(int)fim);
             SortArray(arr,inicio,p-1);
             SortArray(arr,p+1,fim);
            }

           
          

            
        }
        public static int Particionar(int[] arr,int inicio,int fim){
            int pivot=arr[fim];
            int aux;
            int divisor=inicio;
            for(int i=inicio;i<fim;i++){
                if(arr[i]<=pivot){
                    aux=arr[i];
                    arr[i]=arr[divisor];
                    arr[divisor]=aux;
                    divisor++;
                }

            }
            aux=arr[fim];
            arr[fim]=arr[divisor];
            arr[divisor]=aux;
            return divisor;
        }
      
    }
}

