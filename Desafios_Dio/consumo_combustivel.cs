using System; 
using System.Globalization;
class minhaClasse {
    static void Main(string[] args) { 

            int distancia;
            double combustivelGasto, consumoMedio;      

            distancia = Convert.ToInt32(Console.ReadLine());
            combustivelGasto = double.Parse(Console.ReadLine()); 
    
      if(distancia<0 || combustivelGasto<=0)
            {
                throw new ArgumentException();
            }
            else{
                Console.WriteLine("{0:0.000} km/l", consumoMedio);
            }  
            
 }

}